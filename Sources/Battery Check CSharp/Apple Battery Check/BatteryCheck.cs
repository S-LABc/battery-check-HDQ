using Apple_Battery_Check.Properties;
using Bulb;
using MetroFramework;
using MetroFramework.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace Apple_Battery_Check
{
    public enum ControlStatus
    {
        QEN, VOK, RUP_DIS, LDMD, SLEEP, FULLSLEEP, HIBERNATE, SHUTDN_EN,
        HOSTIE, QMAXUPDATE, BCA, CCA, CALMODE, SS, FAS, SE_EN
    }


    public partial class BatteryCheck : MetroForm
    {
        private Dictionary<ControlStatus, string> ControlStatusDescriptions = new Dictionary<ControlStatus, string>
        {
            { ControlStatus.SE_EN, "Status bit indicating if shutdown is active" },
            { ControlStatus.FAS, "Status bit indicating the fuel gauge is in FULL ACCESS SEALED state. Active when set (no data flash access)." },
            { ControlStatus.SS, "Status bit indicating the fuel gauge is in the SEALED state. Active when set (no ROM access)." },
            { ControlStatus.CALMODE, "Status bit indicating the calibration function is active. True when set. Default is 0." },
            { ControlStatus.CCA, "Status bit indicating the Coulomb Counter Calibration routine is active. The CCA routine takes place approximately 1 minute after the initialization and periodically as gauging conditions change. Active when set." },
            { ControlStatus.BCA, "Status bit indicating the Board Calibration routine is active. Active when set." },
            { ControlStatus.QMAXUPDATE, "Status bit toggling every time there is a QMAX update" },
            { ControlStatus.HOSTIE, "Status bit indicating SET_HDQINTEN subcommand has been received and armed the HDQ Host interrupt" },
            { ControlStatus.SHUTDN_EN, "Control bit indicating that the SET_SHUTDOWN subcommand has been sent and signals an external shutdown of the fuel gauge when conditions permit. See Section 2.4.1, SHUTDOWN Mode." },
            { ControlStatus.HIBERNATE, "Status bit indicating a request for entry into HIBERNATE from SLEEP mode has been issued. True when set. Default is 0" },
            { ControlStatus.FULLSLEEP, "Status bit indicating the fuel gauge is in FULLSLEEP mode. True when set. The state can be detected by monitoring the power used by the fuel gauge because any communication automatically clears it." },
            { ControlStatus.SLEEP, "Status bit indicating the fuel gauge is in SLEEP mode. True when set." },
            { ControlStatus.LDMD, "Status bit indicating the Impedance Track algorithm is using constant-power model. True when set. Default is 0 (constant-current model)." },
            { ControlStatus.RUP_DIS, "Status bit indicating the Ra table updates are disabled. True when set." },
            { ControlStatus.VOK, "Status bit indicating cell voltages are OK for Qmax updates. True when set." },
            { ControlStatus.QEN, "Status bit indicating the Qmax updates are enabled. True when set." }
        };
        public BatteryPack batteryPack = new BatteryPack();
        public BatteryCheck()
        {
            InitializeComponent();
            ElemetsDefaultValue();
            LabelDefaultValue();
            PortPreparation();
        }

        private void LabelDefaultValue()
        {
            lblCycleCount.Text = Resources.LBL_DEFAULT_TEXT;
            lblVoltage.Text = Resources.LBL_DEFAULT_TEXT;
            lblTemperature.Text = Resources.LBL_DEFAULT_TEXT;
            lblStateOfCharge.Text = Resources.LBL_DEFAULT_TEXT;
            lblDesignCapacity.Text = Resources.LBL_DEFAULT_TEXT;
            lblFullChargeCapacity.Text = Resources.LBL_DEFAULT_TEXT;
            lblRemainingCapacity.Text = Resources.LBL_DEFAULT_TEXT;
            lblDeviceType.Text = Resources.LBL_DEFAULT_TEXT;
            lblFirmwareVersion.Text = Resources.LBL_DEFAULT_TEXT;
            lblHardwareVersion.Text = Resources.LBL_DEFAULT_TEXT;
        }

        private void ElemetsDefaultValue()
        {
            cbInterface.Items.AddRange(new object[] {
            Resources.TEXT_HDQ,
            Resources.TEXT_I2C});
            cbInterface.Text = Settings.Default.INTERFACE_TYPE;
            chbDataLog.Checked = Settings.Default.DATALOG_STATE;
            serialPortBAT.BaudRate = Settings.Default.SERIAL_BAUDRATE;
            Icon = Resources.Battery_Charging;
        }

        private void PortPreparation()
        {
            string[] ports = SerialPort.GetPortNames();

            cbPrort.Items.Clear();
            cbPrort.Items.AddRange(ports);

            cbPrort.SelectedIndex = (ports.Length != 0) ? 0 : -1;

            if (cbPrort.Text == string.Empty)
            {
                btnRead.Enabled = false;
            }
            else
            {
                btnRead.Enabled = true;
            }
        }

        private void LogFileCreation()
        {
            string[] textData = {
                        cbInterface.Text,
                        lCycleCount.Text + Resources.SPACE_TEXT + lblCycleCount.Text,
                        lDesignCapacity.Text + Resources.SPACE_TEXT +  lblDesignCapacity.Text,
                        lDeviceType.Text + Resources.SPACE_TEXT + lblDeviceType.Text,
                        lFirmwareVersion.Text + Resources.SPACE_TEXT + lblFirmwareVersion.Text,
                        lFullChargeCapacity.Text + Resources.SPACE_TEXT + lblFullChargeCapacity.Text,
                        lHardwareVersion.Text + Resources.SPACE_TEXT + lblHardwareVersion.Text,
                        lRemainingCapacity.Text + Resources.SPACE_TEXT + lblRemainingCapacity.Text,
                        lStateOfCharge.Text + Resources.SPACE_TEXT + lblStateOfCharge.Text,
                        lTemperature.Text + Resources.SPACE_TEXT + lblTemperature.Text,
                        lVoltage.Text + Resources.SPACE_TEXT + lblVoltage.Text,
                        JsonConvert.SerializeObject(batteryPack, Formatting.Indented)

                     };

            File.WriteAllLines(@".\" + DateTime.Now.ToString(Resources.FILE_NAME_FORMAT) + Resources.BOT_SLASH + cbInterface.Text + Resources.EXTANSION_FORMAT, textData, Encoding.UTF8);
        }

        private void LabelDataAdd(string[] addData)
        {
            //STANDARD COMMANDS
            lblTemperature.Text = batteryPack.TemperatureCelsius + Resources.SUFFIX_CELSIUS_DEGREE;
            cpbTempature.Value = Convert.ToInt32(batteryPack.TemperatureCelsius);
            cpbTempature.SubscriptText = lblTemperature.Text;
            cpbTempature.SuperscriptText = batteryPack.TemperatureFahrenheit + " F";// TODO

            lblVoltage.Text = batteryPack.Voltage / Settings.Default.SHIFT_VOLTAGE + Resources.SUFFIX_VOLTAGE;
            cpbVoltage.Minimum = 3200;
            cpbVoltage.Maximum = 4400;
            cpbVoltage.Value = Convert.ToInt32(batteryPack.Voltage);//hack
            cpbVoltage.SubscriptText = batteryPack.Voltage + " mV";
            cpbVoltage.SuperscriptText = lblVoltage.Text;


            lblRemainingCapacity.Text = batteryPack.RemainingCapacity + Resources.SUFFIX_CAPACITY;
            lblFullChargeCapacity.Text = batteryPack.FullChargeCapacity + Resources.SUFFIX_CAPACITY;
            cpbCapacity.Minimum = 0;
            cpbCapacity.Maximum = batteryPack.FullChargeCapacity;
            cpbCapacity.Value = Convert.ToInt32(batteryPack.RemainingCapacity);
            cpbCapacity.SubscriptText = batteryPack.RemainingCapacity + Resources.SUFFIX_CAPACITY;
            cpbCapacity.SuperscriptText = batteryPack.FullChargeCapacity + Resources.SUFFIX_CAPACITY;

            cpbStateofCharge.Maximum = 100;
            cpbStateofCharge.Value = Convert.ToInt32(batteryPack.StateOfCharge);
            cpbStateofCharge.SubscriptText = cpbStateofCharge.Value + Resources.SUFFIX_PERCENT;

            cpbStateofHealth.Maximum = 100;
            cpbStateofHealth.Value = Convert.ToInt32(batteryPack.StateOfHealth);
            cpbStateofHealth.SubscriptText = cpbStateofHealth.Value + Resources.SUFFIX_PERCENT;

            cpbChargingVoltage.Maximum = 6000;
            cpbChargingVoltage.Value = Convert.ToInt32(batteryPack.ChargingVoltage);
            cpbChargingVoltage.SubscriptText = cpbChargingVoltage.Value + Resources.SUFFIX_VOLTAGE;

            cpbChargingCurrent.Maximum = 6000;
            cpbChargingCurrent.Value = Convert.ToInt32(batteryPack.ChargingCurrent);
            cpbChargingCurrent.SubscriptText = cpbChargingCurrent.Value + Resources.SUFFIX_CURRENT;


            cpbAveragePower.Maximum = 30000;
            cpbAveragePower.Value = Convert.ToInt32(batteryPack.AveragePower);
            cpbAveragePower.SubscriptText = cpbAveragePower.Value + Resources.SUFFIX_POWER;

            cpbAverageCurrent.Maximum = 6000;
            cpbAverageCurrent.Value = Convert.ToInt32(batteryPack.AverageCurrent);
            cpbAverageCurrent.SubscriptText = cpbAverageCurrent.Value + Resources.SUFFIX_CURRENT;

            lblCycleCount.Text =  batteryPack.CycleCount;
            lblStateOfCharge.Text = batteryPack.StateOfCharge + Resources.SUFFIX_PERCENT;
            lblBatteryHealth.Text = batteryPack.StateOfHealth + Resources.SUFFIX_PERCENT;

            // +EXTENDED COMMAND
            lblDesignCapacity.Text = batteryPack.DesignCapacity + Resources.SUFFIX_CAPACITY;

            //CONTROL SUB COMMANDS
            lblControlStatus.Text = batteryPack.ControlStatus;
            lblDeviceType.Text = batteryPack.DeviceType;
            lblFirmwareVersion.Text = batteryPack.FirmwareVersion;
            lblHardwareVersion.Text = batteryPack.HardwareVersion;

            //BLOCK COMMANDS

            lblManufacturerBlockA.Text = batteryPack.ManufacturerBlockA;
            lblManufacturerBlockB.Text = batteryPack.ManufacturerBlockB;
            lblManufacturerBlockC.Text = batteryPack.ManufacturerBlockC;
            //lblChecksum.Text = batteryPack.Checksum;


            ////HESAPLANAN VERİLER
            //lblBatteryHealth.Text = ((Convert.ToDouble(addData[7]) / Convert.ToDouble(addData[27])) * 100).ToString("0.00") + Resources.SUFFIX_PERCENT;
            

            UpdateBitStatus(Convert.ToUInt16(batteryPack.ControlStatus, 16));

        }

        private void UpdateBitStatus(ushort receivedData)
        {
            flowLayoutPanel5.Controls.Clear(); // Önceki kutuları temizle
            foreach (ControlStatus bit in Enum.GetValues(typeof(ControlStatus)))
            {
                string labelText = bit.ToString();
                bool isActive = ((receivedData >> (int)bit) & 1) != 0;

                Panel panel = new Panel
                {
                    Size = new System.Drawing.Size(90, 15),
                    BackColor = isActive ? System.Drawing.Color.Green : System.Drawing.Color.OrangeRed,
                    Controls = {
                new Label {
                    Text = labelText,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill
                }
            }
                };
                flowLayoutPanel5.Controls.Add(panel);
            }
        }

        private void CbPrort_MouseClick(object sender, MouseEventArgs e)
        {
            PortPreparation();
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            try
            {
                serialPortBAT.PortName = Convert.ToString(cbPrort.Text);
                serialPortBAT.Open();

                if (cbInterface.Text == Resources.TEXT_HDQ)
                {
                    serialPortBAT.Write(Resources.KEY_HDQ);
                }
                else if (cbInterface.Text == Resources.TEXT_I2C)
                {
                    serialPortBAT.Write(Resources.KEY_I2C);
                }
            }
            catch
            {
                serialPortBAT.Close();
                //MetroMessageBox.Show(this,
                //    Messages.ERROR_RELATION,
                //    Messages.ERROR,
                //    MessageBoxButtons.OK,
                //    MessageBoxIcon.Error);
            }
        }

        private delegate void ReceivedEvent(string data);
        private void SerialPortBAT_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            BeginInvoke(new ReceivedEvent(DataProcessing), serialPortBAT.ReadLine());
            serialPortBAT.Close();
        }

        private void DataProcessing(string dataReceived)
        {
            Console.WriteLine(dataReceived);
            string[] tempSplited = dataReceived.Split(Settings.Default.SEPARATOR_SLASH);
            batteryPack.UpdateData(dataReceived);
            try
            {
                LabelDataAdd(tempSplited);

                if (chbDataLog.Checked)
                {
                    LogFileCreation();
                }
            }
            catch
            {
                LabelDefaultValue();
                //MetroMessageBox.Show(this,
                //    Messages.ERROR_DATA_TYPE,
                //    Messages.ERROR,
                //    MessageBoxButtons.OK,
                //    MessageBoxIcon.Error);
            }
        }

        private void BatteryCheck_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cbInterface.Text != Settings.Default.INTERFACE_TYPE || chbDataLog.Checked != Settings.Default.DATALOG_STATE)
            {
                Settings.Default.INTERFACE_TYPE = cbInterface.Text;
                Settings.Default.DATALOG_STATE = chbDataLog.Checked;
                Settings.Default.Save();
            }
        }

        private void YT_Click(object sender, EventArgs e)
        {
            ledBulb1.On = !ledBulb1.On;
        }
        private int _blink = 0;
        private void ledBulb1_Click(object sender, EventArgs e)
        {
            //((LedBulb)sender).On = !((LedBulb)sender).On;
            if (_blink == 0) _blink = 500;
            else _blink = 0;
            ((LedBulb)sender).Blink(_blink);
        }

        private void btnWatch_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
