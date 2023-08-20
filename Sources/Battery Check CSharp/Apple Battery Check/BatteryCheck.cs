using Apple_Battery_Check.Properties;
using Bulb;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace Apple_Battery_Check
{
    public partial class BatteryCheck : MetroForm
    {
        public BatteryCheck()
        {
            InitializeComponent();
            ElemetsDefaultValue();
            LabelDefaultValue();           
            PortPreparation();
        }

        //Заполнение полей данных прочерком
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

        //Установка основных настроек для программы
        private void ElemetsDefaultValue()
        {
            //Добавление элементов интерфесов
            cbInterface.Items.AddRange(new object[] {
            Resources.TEXT_HDQ,
            Resources.TEXT_I2C});
            //Выбор последнего интерфейса выбранного пользователем
            cbInterface.Text = Settings.Default.INTERFACE_TYPE;
            //Состояние сохранения считанных данных
            chbDataLog.Checked = Settings.Default.DATALOG_STATE;
            //Установка скорости связи
            serialPortBAT.BaudRate = Settings.Default.SERIAL_BAUDRATE;
            //Установка значка приложения
            Icon = Resources.Battery_Charging;
        }

        //Подготовка и выбор порта в списке
        private void PortPreparation()
        {
            //Заполнение массива найденными портами
            string[] ports = SerialPort.GetPortNames();

            //Очистка и заполнение списка
            cbPrort.Items.Clear();
            cbPrort.Items.AddRange(ports);

            //Если есть хоть один порт - выбрать его, иначе пустое поле
            cbPrort.SelectedIndex = (ports.Length != 0) ? 0 : -1;

            //Активность кнопки в зависимости от наличия портов
            if (cbPrort.Text == string.Empty)
            {
                btnRead.Enabled = false;
            }
            else
            {
                btnRead.Enabled = true;
            }
        }

        //Создание файла логов
        private void LogFileCreation()
        {
            //Формирование содержимго файла логов
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
                        lVoltage.Text + Resources.SPACE_TEXT + lblVoltage.Text
                     };

            //Создать файл логов
            File.WriteAllLines(@".\" + DateTime.Now.ToString(Resources.FILE_NAME_FORMAT) + Resources.BOT_SLASH + cbInterface.Text + Resources.EXTANSION_FORMAT, textData, Encoding.UTF8);
        }

        //
        private void LabelDataAdd(string[] addData)
        {
            //STANDARD COMMANDS
            lblTemperature.Text = Convert.ToString(Convert.ToDouble(addData[2]) * Settings.Default.DECIMAL_FACTOR - Settings.Default.CELSIUS_OFFSET) + Resources.SUFFIX_CELSIUS_DEGREE;
            cpbTempature.Maximum = 100;
            cpbTempature.Minimum = 0;
            cpbTempature.Value = Convert.ToInt32(Convert.ToDouble(addData[2]) * Settings.Default.DECIMAL_FACTOR - Settings.Default.CELSIUS_OFFSET);
            cpbTempature.SubscriptText = Convert.ToString(Convert.ToDouble(addData[2]) * Settings.Default.DECIMAL_FACTOR - Settings.Default.CELSIUS_OFFSET);
            cpbTempature.SuperscriptText = Resources.SUFFIX_CELSIUS_DEGREE;

            lblVoltage.Text = Convert.ToString(Convert.ToDouble(addData[3]) / Settings.Default.SHIFT_VOLTAGE) + Resources.SUFFIX_VOLTAGE;
            lblRemainingCapacity.Text = addData[6] + Resources.SUFFIX_CAPACITY; // NEYE GÖRE HESAPLIYOR ENTEGRE BAK
            lblFullChargeCapacity.Text = addData[7] + Resources.SUFFIX_CAPACITY;
            lblCycleCount.Text = addData[18];
            lblStateOfCharge.Text = addData[19] + Resources.SUFFIX_PERCENT; // NEYE GÖRE HESAPLIYOR ENTEGRE BAK
            
            // +EXTENDED COMMAND
            lblDesignCapacity.Text = addData[27] + Resources.SUFFIX_CAPACITY;

            //CONTROL SUB COMMANDS
            lblControlStatus.Text = "0x"+addData[31].ToUpper();
            lblDeviceType.Text = Resources.PREFIX_CONTROLLER + addData[32];
            lblFirmwareVersion.Text = addData[33].Insert(1, Settings.Default.SEPARATOR_DOT);
            lblHardwareVersion.Text = Convert.ToInt32(addData[34].ToUpper(), 16).ToString().Insert(1, Settings.Default.SEPARATOR_DOT);

            //BLOCK COMMANDS
            
            lblManufacturerBlockA.Text = addData[36];
            lblManufacturerBlockB.Text = addData[37];
            lblManufacturerBlockC.Text = addData[38];
            lblChecksum.Text = addData[39];


            ////HESAPLANAN VERİLER
            lblBatteryHealth.Text = ((Convert.ToDouble(addData[7]) / Convert.ToDouble(addData[27])) * 100).ToString("0.00") + Resources.SUFFIX_PERCENT;


        }

        //Обновление списка портов
        private void CbPrort_MouseClick(object sender, MouseEventArgs e)
        {
            PortPreparation();
        }

        //Чтение данных из АКБ
        private void BtnRead_Click(object sender, EventArgs e)
        {
            try
            {
                //Выбор порта
                serialPortBAT.PortName = Convert.ToString(cbPrort.Text);

                //Открыть соединение
                serialPortBAT.Open();

                if (cbInterface.Text == Resources.TEXT_HDQ)
                {
                    //Отправить ключ для HDQ
                    serialPortBAT.Write(Resources.KEY_HDQ);
                }
                else if (cbInterface.Text == Resources.TEXT_I2C)
                {
                    //Отправить ключ для I2C
                    serialPortBAT.Write(Resources.KEY_I2C);
                }
            }
            catch
            {
                serialPortBAT.Close();
                //Сообщение об ошибке связи
                MetroMessageBox.Show(this,
                    Messages.ERROR_RELATION,
                    Messages.ERROR,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //Делегат
        private delegate void ReceivedEvent(string data);

        //Прием данных из порта
        private void SerialPortBAT_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //Вызов метода выдачи значений через делегат 
            BeginInvoke(new ReceivedEvent(DataProcessing), serialPortBAT.ReadLine());

            serialPortBAT.Close();
        }

        //Обработка принятых из порта данных
        private void DataProcessing(string dataReceived)
        {
            //Разбить принятый пакет на элементы
            Console.WriteLine(dataReceived);
            string[] tempSplited = dataReceived.Split(Settings.Default.SEPARATOR_SLASH);

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
                MetroMessageBox.Show(this,
                    Messages.ERROR_DATA_TYPE,
                    Messages.ERROR,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //Обработка изменений типа интерфейса и сохранения данных в файл
        private void BatteryCheck_FormClosing(object sender, FormClosingEventArgs e)
        {
            //При изменении типа интерфейса или флага сохранения данных
            if (cbInterface.Text != Settings.Default.INTERFACE_TYPE || chbDataLog.Checked != Settings.Default.DATALOG_STATE)
            {
                //Переписать новое значение интефейса и флага данных
                Settings.Default.INTERFACE_TYPE = cbInterface.Text;
                Settings.Default.DATALOG_STATE = chbDataLog.Checked;

                //Сохранить новые настройки
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

        private void SN1_Click(object sender, EventArgs e)
        {

        }
    }
}
