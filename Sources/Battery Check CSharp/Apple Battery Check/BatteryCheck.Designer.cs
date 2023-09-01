
namespace Apple_Battery_Check
{
    partial class BatteryCheck
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbInterface = new MetroFramework.Controls.MetroComboBox();
            this.cbPrort = new MetroFramework.Controls.MetroComboBox();
            this.btnRead = new MetroFramework.Controls.MetroButton();
            this.ledBulb1 = new Bulb.LedBulb();
            this.chbDataLog = new System.Windows.Forms.CheckBox();
            this.YT = new MetroFramework.Controls.MetroLink();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lTemperature = new System.Windows.Forms.Label();
            this.lVoltage = new System.Windows.Forms.Label();
            this.lRemainingCapacity = new System.Windows.Forms.Label();
            this.lFullChargeCapacity = new System.Windows.Forms.Label();
            this.lDesignCapacity = new System.Windows.Forms.Label();
            this.lCycleCount = new System.Windows.Forms.Label();
            this.lStateOfCharge = new System.Windows.Forms.Label();
            this.lBatteryHealth = new System.Windows.Forms.Label();
            this.lDeviceType = new System.Windows.Forms.Label();
            this.lControlStatus = new System.Windows.Forms.Label();
            this.lFirmwareVersion = new System.Windows.Forms.Label();
            this.lHardwareVersion = new System.Windows.Forms.Label();
            this.lManufacturerBlockA = new System.Windows.Forms.Label();
            this.lManufacturerBlockB = new System.Windows.Forms.Label();
            this.lManufacturerBlockC = new System.Windows.Forms.Label();
            this.lChecksum = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblVoltage = new System.Windows.Forms.Label();
            this.lblRemainingCapacity = new System.Windows.Forms.Label();
            this.lblFullChargeCapacity = new System.Windows.Forms.Label();
            this.lblDesignCapacity = new System.Windows.Forms.Label();
            this.lblCycleCount = new System.Windows.Forms.Label();
            this.lblStateOfCharge = new System.Windows.Forms.Label();
            this.lblBatteryHealth = new System.Windows.Forms.Label();
            this.lblDeviceType = new System.Windows.Forms.Label();
            this.lblControlStatus = new System.Windows.Forms.Label();
            this.lblFirmwareVersion = new System.Windows.Forms.Label();
            this.lblHardwareVersion = new System.Windows.Forms.Label();
            this.lblManufacturerBlockA = new System.Windows.Forms.Label();
            this.lblManufacturerBlockB = new System.Windows.Forms.Label();
            this.lblManufacturerBlockC = new System.Windows.Forms.Label();
            this.lblChecksum = new System.Windows.Forms.Label();
            this.serialPortBAT = new System.IO.Ports.SerialPort(this.components);
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.cpbTempature = new CircularProgressBar.CircularProgressBar();
            this.cpbVoltage = new CircularProgressBar.CircularProgressBar();
            this.cpbCapacity = new CircularProgressBar.CircularProgressBar();
            this.cpbChargingCurrent = new CircularProgressBar.CircularProgressBar();
            this.cpbChargingVoltage = new CircularProgressBar.CircularProgressBar();
            this.cpbStateofCharge = new CircularProgressBar.CircularProgressBar();
            this.cpbAverageCurrent = new CircularProgressBar.CircularProgressBar();
            this.cpbAveragePower = new CircularProgressBar.CircularProgressBar();
            this.cpbStateofHealth = new CircularProgressBar.CircularProgressBar();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cbInterface);
            this.flowLayoutPanel1.Controls.Add(this.cbPrort);
            this.flowLayoutPanel1.Controls.Add(this.btnRead);
            this.flowLayoutPanel1.Controls.Add(this.ledBulb1);
            this.flowLayoutPanel1.Controls.Add(this.chbDataLog);
            this.flowLayoutPanel1.Controls.Add(this.YT);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 635);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1219, 209);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // cbInterface
            // 
            this.cbInterface.FormattingEnabled = true;
            this.cbInterface.ItemHeight = 23;
            this.cbInterface.Location = new System.Drawing.Point(5, 5);
            this.cbInterface.Margin = new System.Windows.Forms.Padding(5);
            this.cbInterface.Name = "cbInterface";
            this.cbInterface.Size = new System.Drawing.Size(78, 29);
            this.cbInterface.TabIndex = 9;
            this.cbInterface.UseSelectable = true;
            // 
            // cbPrort
            // 
            this.cbPrort.FormattingEnabled = true;
            this.cbPrort.ItemHeight = 23;
            this.cbPrort.Location = new System.Drawing.Point(93, 5);
            this.cbPrort.Margin = new System.Windows.Forms.Padding(5);
            this.cbPrort.Name = "cbPrort";
            this.cbPrort.PromptText = "Port";
            this.cbPrort.Size = new System.Drawing.Size(79, 29);
            this.cbPrort.Sorted = true;
            this.cbPrort.TabIndex = 8;
            this.cbPrort.UseSelectable = true;
            this.cbPrort.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CbPrort_MouseClick);
            // 
            // btnRead
            // 
            this.btnRead.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRead.Location = new System.Drawing.Point(182, 5);
            this.btnRead.Margin = new System.Windows.Forms.Padding(5);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(113, 29);
            this.btnRead.TabIndex = 7;
            this.btnRead.Text = "Batarya Oku";
            this.btnRead.UseSelectable = true;
            this.btnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // ledBulb1
            // 
            this.ledBulb1.Dock = System.Windows.Forms.DockStyle.Right;
            this.ledBulb1.Location = new System.Drawing.Point(303, 3);
            this.ledBulb1.Name = "ledBulb1";
            this.ledBulb1.On = true;
            this.ledBulb1.Size = new System.Drawing.Size(31, 33);
            this.ledBulb1.TabIndex = 12;
            this.ledBulb1.Text = "ledBulb1";
            this.ledBulb1.Click += new System.EventHandler(this.ledBulb1_Click);
            // 
            // chbDataLog
            // 
            this.chbDataLog.AutoSize = true;
            this.chbDataLog.Location = new System.Drawing.Point(342, 10);
            this.chbDataLog.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.chbDataLog.Name = "chbDataLog";
            this.chbDataLog.Size = new System.Drawing.Size(171, 20);
            this.chbDataLog.TabIndex = 10;
            this.chbDataLog.Text = "Verileri dosyaya kaydet.";
            this.chbDataLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbDataLog.UseVisualStyleBackColor = true;
            // 
            // YT
            // 
            this.YT.Location = new System.Drawing.Point(523, 10);
            this.YT.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.YT.Name = "YT";
            this.YT.Size = new System.Drawing.Size(75, 23);
            this.YT.TabIndex = 11;
            this.YT.Text = "YouTube";
            this.YT.UseSelectable = true;
            this.YT.Click += new System.EventHandler(this.YT_Click);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 42);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(790, 100);
            this.flowLayoutPanel5.TabIndex = 13;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lTemperature);
            this.flowLayoutPanel2.Controls.Add(this.lVoltage);
            this.flowLayoutPanel2.Controls.Add(this.lRemainingCapacity);
            this.flowLayoutPanel2.Controls.Add(this.lFullChargeCapacity);
            this.flowLayoutPanel2.Controls.Add(this.lDesignCapacity);
            this.flowLayoutPanel2.Controls.Add(this.lCycleCount);
            this.flowLayoutPanel2.Controls.Add(this.lStateOfCharge);
            this.flowLayoutPanel2.Controls.Add(this.lBatteryHealth);
            this.flowLayoutPanel2.Controls.Add(this.lDeviceType);
            this.flowLayoutPanel2.Controls.Add(this.lControlStatus);
            this.flowLayoutPanel2.Controls.Add(this.lFirmwareVersion);
            this.flowLayoutPanel2.Controls.Add(this.lHardwareVersion);
            this.flowLayoutPanel2.Controls.Add(this.lManufacturerBlockA);
            this.flowLayoutPanel2.Controls.Add(this.lManufacturerBlockB);
            this.flowLayoutPanel2.Controls.Add(this.lManufacturerBlockC);
            this.flowLayoutPanel2.Controls.Add(this.lChecksum);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(10, 70);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(176, 565);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // lTemperature
            // 
            this.lTemperature.AutoSize = true;
            this.lTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTemperature.Location = new System.Drawing.Point(5, 10);
            this.lTemperature.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lTemperature.Name = "lTemperature";
            this.lTemperature.Size = new System.Drawing.Size(62, 20);
            this.lTemperature.TabIndex = 2;
            this.lTemperature.Text = "Sıcaklık";
            this.lTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lVoltage
            // 
            this.lVoltage.AutoSize = true;
            this.lVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lVoltage.Location = new System.Drawing.Point(5, 45);
            this.lVoltage.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lVoltage.Name = "lVoltage";
            this.lVoltage.Size = new System.Drawing.Size(49, 20);
            this.lVoltage.TabIndex = 1;
            this.lVoltage.Text = "Voltaj";
            this.lVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lRemainingCapacity
            // 
            this.lRemainingCapacity.AutoSize = true;
            this.lRemainingCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lRemainingCapacity.Location = new System.Drawing.Point(5, 80);
            this.lRemainingCapacity.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lRemainingCapacity.Name = "lRemainingCapacity";
            this.lRemainingCapacity.Size = new System.Drawing.Size(158, 20);
            this.lRemainingCapacity.TabIndex = 6;
            this.lRemainingCapacity.Text = "Kalan Şarj Kapasitesi";
            this.lRemainingCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lFullChargeCapacity
            // 
            this.lFullChargeCapacity.AutoSize = true;
            this.lFullChargeCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFullChargeCapacity.Location = new System.Drawing.Point(5, 115);
            this.lFullChargeCapacity.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lFullChargeCapacity.Name = "lFullChargeCapacity";
            this.lFullChargeCapacity.Size = new System.Drawing.Size(149, 20);
            this.lFullChargeCapacity.TabIndex = 5;
            this.lFullChargeCapacity.Text = "Tam Şarj Kapasitesi";
            this.lFullChargeCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lDesignCapacity
            // 
            this.lDesignCapacity.AutoSize = true;
            this.lDesignCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDesignCapacity.Location = new System.Drawing.Point(5, 150);
            this.lDesignCapacity.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lDesignCapacity.Name = "lDesignCapacity";
            this.lDesignCapacity.Size = new System.Drawing.Size(142, 20);
            this.lDesignCapacity.TabIndex = 4;
            this.lDesignCapacity.Text = "Tasarım Kapasitesi";
            this.lDesignCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lCycleCount
            // 
            this.lCycleCount.AutoSize = true;
            this.lCycleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCycleCount.Location = new System.Drawing.Point(5, 185);
            this.lCycleCount.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lCycleCount.Name = "lCycleCount";
            this.lCycleCount.Size = new System.Drawing.Size(102, 20);
            this.lCycleCount.TabIndex = 0;
            this.lCycleCount.Text = "Çevrim Sayısı";
            this.lCycleCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lStateOfCharge
            // 
            this.lStateOfCharge.AutoSize = true;
            this.lStateOfCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lStateOfCharge.Location = new System.Drawing.Point(5, 220);
            this.lStateOfCharge.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lStateOfCharge.Name = "lStateOfCharge";
            this.lStateOfCharge.Size = new System.Drawing.Size(98, 20);
            this.lStateOfCharge.TabIndex = 3;
            this.lStateOfCharge.Text = "Şarj Durumu";
            this.lStateOfCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lBatteryHealth
            // 
            this.lBatteryHealth.AutoSize = true;
            this.lBatteryHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lBatteryHealth.Location = new System.Drawing.Point(5, 255);
            this.lBatteryHealth.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lBatteryHealth.Name = "lBatteryHealth";
            this.lBatteryHealth.Size = new System.Drawing.Size(76, 20);
            this.lBatteryHealth.TabIndex = 10;
            this.lBatteryHealth.Text = "Pil Sağlığı";
            this.lBatteryHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lDeviceType
            // 
            this.lDeviceType.AutoSize = true;
            this.lDeviceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDeviceType.Location = new System.Drawing.Point(5, 290);
            this.lDeviceType.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lDeviceType.Name = "lDeviceType";
            this.lDeviceType.Size = new System.Drawing.Size(72, 20);
            this.lDeviceType.TabIndex = 7;
            this.lDeviceType.Text = "Aygıt Tipi";
            this.lDeviceType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lControlStatus
            // 
            this.lControlStatus.AutoSize = true;
            this.lControlStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lControlStatus.Location = new System.Drawing.Point(5, 325);
            this.lControlStatus.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lControlStatus.Name = "lControlStatus";
            this.lControlStatus.Size = new System.Drawing.Size(111, 20);
            this.lControlStatus.TabIndex = 11;
            this.lControlStatus.Text = "Control Status";
            this.lControlStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lFirmwareVersion
            // 
            this.lFirmwareVersion.AutoSize = true;
            this.lFirmwareVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFirmwareVersion.Location = new System.Drawing.Point(5, 360);
            this.lFirmwareVersion.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lFirmwareVersion.Name = "lFirmwareVersion";
            this.lFirmwareVersion.Size = new System.Drawing.Size(119, 20);
            this.lFirmwareVersion.TabIndex = 8;
            this.lFirmwareVersion.Text = "Yazılım Sürümü";
            this.lFirmwareVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lHardwareVersion
            // 
            this.lHardwareVersion.AutoSize = true;
            this.lHardwareVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lHardwareVersion.Location = new System.Drawing.Point(5, 395);
            this.lHardwareVersion.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lHardwareVersion.Name = "lHardwareVersion";
            this.lHardwareVersion.Size = new System.Drawing.Size(133, 20);
            this.lHardwareVersion.TabIndex = 9;
            this.lHardwareVersion.Text = "Donanım Sürümü";
            this.lHardwareVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lManufacturerBlockA
            // 
            this.lManufacturerBlockA.AutoSize = true;
            this.lManufacturerBlockA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lManufacturerBlockA.Location = new System.Drawing.Point(5, 430);
            this.lManufacturerBlockA.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lManufacturerBlockA.Name = "lManufacturerBlockA";
            this.lManufacturerBlockA.Size = new System.Drawing.Size(162, 20);
            this.lManufacturerBlockA.TabIndex = 12;
            this.lManufacturerBlockA.Text = "Manufacturer Block A";
            this.lManufacturerBlockA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lManufacturerBlockB
            // 
            this.lManufacturerBlockB.AutoSize = true;
            this.lManufacturerBlockB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lManufacturerBlockB.Location = new System.Drawing.Point(5, 465);
            this.lManufacturerBlockB.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lManufacturerBlockB.Name = "lManufacturerBlockB";
            this.lManufacturerBlockB.Size = new System.Drawing.Size(162, 20);
            this.lManufacturerBlockB.TabIndex = 13;
            this.lManufacturerBlockB.Text = "Manufacturer Block B";
            this.lManufacturerBlockB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lManufacturerBlockC
            // 
            this.lManufacturerBlockC.AutoSize = true;
            this.lManufacturerBlockC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lManufacturerBlockC.Location = new System.Drawing.Point(5, 500);
            this.lManufacturerBlockC.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lManufacturerBlockC.Name = "lManufacturerBlockC";
            this.lManufacturerBlockC.Size = new System.Drawing.Size(162, 20);
            this.lManufacturerBlockC.TabIndex = 14;
            this.lManufacturerBlockC.Text = "Manufacturer Block C";
            this.lManufacturerBlockC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lChecksum
            // 
            this.lChecksum.AutoSize = true;
            this.lChecksum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lChecksum.Location = new System.Drawing.Point(5, 535);
            this.lChecksum.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lChecksum.Name = "lChecksum";
            this.lChecksum.Size = new System.Drawing.Size(84, 20);
            this.lChecksum.TabIndex = 15;
            this.lChecksum.Text = "Checksum";
            this.lChecksum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.lblTemperature);
            this.flowLayoutPanel3.Controls.Add(this.lblVoltage);
            this.flowLayoutPanel3.Controls.Add(this.lblRemainingCapacity);
            this.flowLayoutPanel3.Controls.Add(this.lblFullChargeCapacity);
            this.flowLayoutPanel3.Controls.Add(this.lblDesignCapacity);
            this.flowLayoutPanel3.Controls.Add(this.lblCycleCount);
            this.flowLayoutPanel3.Controls.Add(this.lblStateOfCharge);
            this.flowLayoutPanel3.Controls.Add(this.lblBatteryHealth);
            this.flowLayoutPanel3.Controls.Add(this.lblDeviceType);
            this.flowLayoutPanel3.Controls.Add(this.lblControlStatus);
            this.flowLayoutPanel3.Controls.Add(this.lblFirmwareVersion);
            this.flowLayoutPanel3.Controls.Add(this.lblHardwareVersion);
            this.flowLayoutPanel3.Controls.Add(this.lblManufacturerBlockA);
            this.flowLayoutPanel3.Controls.Add(this.lblManufacturerBlockB);
            this.flowLayoutPanel3.Controls.Add(this.lblManufacturerBlockC);
            this.flowLayoutPanel3.Controls.Add(this.lblChecksum);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(186, 70);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1043, 565);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTemperature.Location = new System.Drawing.Point(5, 10);
            this.lblTemperature.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(33, 20);
            this.lblTemperature.TabIndex = 36;
            this.lblTemperature.Text = "--/--";
            this.lblTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVoltage
            // 
            this.lblVoltage.AutoSize = true;
            this.lblVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVoltage.Location = new System.Drawing.Point(5, 45);
            this.lblVoltage.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblVoltage.Name = "lblVoltage";
            this.lblVoltage.Size = new System.Drawing.Size(33, 20);
            this.lblVoltage.TabIndex = 35;
            this.lblVoltage.Text = "--/--";
            this.lblVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRemainingCapacity
            // 
            this.lblRemainingCapacity.AutoSize = true;
            this.lblRemainingCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRemainingCapacity.Location = new System.Drawing.Point(5, 80);
            this.lblRemainingCapacity.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblRemainingCapacity.Name = "lblRemainingCapacity";
            this.lblRemainingCapacity.Size = new System.Drawing.Size(33, 20);
            this.lblRemainingCapacity.TabIndex = 40;
            this.lblRemainingCapacity.Text = "--/--";
            this.lblRemainingCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFullChargeCapacity
            // 
            this.lblFullChargeCapacity.AutoSize = true;
            this.lblFullChargeCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFullChargeCapacity.Location = new System.Drawing.Point(5, 115);
            this.lblFullChargeCapacity.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblFullChargeCapacity.Name = "lblFullChargeCapacity";
            this.lblFullChargeCapacity.Size = new System.Drawing.Size(33, 20);
            this.lblFullChargeCapacity.TabIndex = 39;
            this.lblFullChargeCapacity.Text = "--/--";
            this.lblFullChargeCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDesignCapacity
            // 
            this.lblDesignCapacity.AutoSize = true;
            this.lblDesignCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDesignCapacity.Location = new System.Drawing.Point(5, 150);
            this.lblDesignCapacity.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblDesignCapacity.Name = "lblDesignCapacity";
            this.lblDesignCapacity.Size = new System.Drawing.Size(33, 20);
            this.lblDesignCapacity.TabIndex = 38;
            this.lblDesignCapacity.Text = "--/--";
            this.lblDesignCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCycleCount
            // 
            this.lblCycleCount.AutoSize = true;
            this.lblCycleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCycleCount.Location = new System.Drawing.Point(5, 185);
            this.lblCycleCount.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblCycleCount.Name = "lblCycleCount";
            this.lblCycleCount.Size = new System.Drawing.Size(33, 20);
            this.lblCycleCount.TabIndex = 34;
            this.lblCycleCount.Text = "--/--";
            this.lblCycleCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStateOfCharge
            // 
            this.lblStateOfCharge.AutoSize = true;
            this.lblStateOfCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStateOfCharge.Location = new System.Drawing.Point(5, 220);
            this.lblStateOfCharge.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblStateOfCharge.Name = "lblStateOfCharge";
            this.lblStateOfCharge.Size = new System.Drawing.Size(33, 20);
            this.lblStateOfCharge.TabIndex = 37;
            this.lblStateOfCharge.Text = "--/--";
            this.lblStateOfCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBatteryHealth
            // 
            this.lblBatteryHealth.AutoSize = true;
            this.lblBatteryHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBatteryHealth.Location = new System.Drawing.Point(5, 255);
            this.lblBatteryHealth.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblBatteryHealth.Name = "lblBatteryHealth";
            this.lblBatteryHealth.Size = new System.Drawing.Size(33, 20);
            this.lblBatteryHealth.TabIndex = 44;
            this.lblBatteryHealth.Text = "--/--";
            this.lblBatteryHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeviceType
            // 
            this.lblDeviceType.AutoSize = true;
            this.lblDeviceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDeviceType.Location = new System.Drawing.Point(5, 290);
            this.lblDeviceType.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblDeviceType.Name = "lblDeviceType";
            this.lblDeviceType.Size = new System.Drawing.Size(33, 20);
            this.lblDeviceType.TabIndex = 41;
            this.lblDeviceType.Text = "--/--";
            this.lblDeviceType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblControlStatus
            // 
            this.lblControlStatus.AutoSize = true;
            this.lblControlStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblControlStatus.Location = new System.Drawing.Point(5, 325);
            this.lblControlStatus.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblControlStatus.Name = "lblControlStatus";
            this.lblControlStatus.Size = new System.Drawing.Size(33, 20);
            this.lblControlStatus.TabIndex = 45;
            this.lblControlStatus.Text = "--/--";
            this.lblControlStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirmwareVersion
            // 
            this.lblFirmwareVersion.AutoSize = true;
            this.lblFirmwareVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirmwareVersion.Location = new System.Drawing.Point(5, 360);
            this.lblFirmwareVersion.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblFirmwareVersion.Name = "lblFirmwareVersion";
            this.lblFirmwareVersion.Size = new System.Drawing.Size(33, 20);
            this.lblFirmwareVersion.TabIndex = 42;
            this.lblFirmwareVersion.Text = "--/--";
            this.lblFirmwareVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHardwareVersion
            // 
            this.lblHardwareVersion.AutoSize = true;
            this.lblHardwareVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHardwareVersion.Location = new System.Drawing.Point(5, 395);
            this.lblHardwareVersion.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblHardwareVersion.Name = "lblHardwareVersion";
            this.lblHardwareVersion.Size = new System.Drawing.Size(33, 20);
            this.lblHardwareVersion.TabIndex = 43;
            this.lblHardwareVersion.Text = "--/--";
            this.lblHardwareVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblManufacturerBlockA
            // 
            this.lblManufacturerBlockA.AutoSize = true;
            this.lblManufacturerBlockA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblManufacturerBlockA.Location = new System.Drawing.Point(5, 430);
            this.lblManufacturerBlockA.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblManufacturerBlockA.Name = "lblManufacturerBlockA";
            this.lblManufacturerBlockA.Size = new System.Drawing.Size(33, 20);
            this.lblManufacturerBlockA.TabIndex = 46;
            this.lblManufacturerBlockA.Text = "--/--";
            this.lblManufacturerBlockA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblManufacturerBlockB
            // 
            this.lblManufacturerBlockB.AutoSize = true;
            this.lblManufacturerBlockB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblManufacturerBlockB.Location = new System.Drawing.Point(5, 465);
            this.lblManufacturerBlockB.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblManufacturerBlockB.Name = "lblManufacturerBlockB";
            this.lblManufacturerBlockB.Size = new System.Drawing.Size(33, 20);
            this.lblManufacturerBlockB.TabIndex = 47;
            this.lblManufacturerBlockB.Text = "--/--";
            this.lblManufacturerBlockB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblManufacturerBlockC
            // 
            this.lblManufacturerBlockC.AutoSize = true;
            this.lblManufacturerBlockC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblManufacturerBlockC.Location = new System.Drawing.Point(5, 500);
            this.lblManufacturerBlockC.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblManufacturerBlockC.Name = "lblManufacturerBlockC";
            this.lblManufacturerBlockC.Size = new System.Drawing.Size(33, 20);
            this.lblManufacturerBlockC.TabIndex = 48;
            this.lblManufacturerBlockC.Text = "--/--";
            this.lblManufacturerBlockC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChecksum
            // 
            this.lblChecksum.AutoSize = true;
            this.lblChecksum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChecksum.Location = new System.Drawing.Point(5, 535);
            this.lblChecksum.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblChecksum.Name = "lblChecksum";
            this.lblChecksum.Size = new System.Drawing.Size(33, 20);
            this.lblChecksum.TabIndex = 49;
            this.lblChecksum.Text = "--/--";
            this.lblChecksum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serialPortBAT
            // 
            this.serialPortBAT.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPortBAT_DataReceived);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.cpbTempature);
            this.flowLayoutPanel4.Controls.Add(this.cpbVoltage);
            this.flowLayoutPanel4.Controls.Add(this.cpbCapacity);
            this.flowLayoutPanel4.Controls.Add(this.cpbChargingCurrent);
            this.flowLayoutPanel4.Controls.Add(this.cpbChargingVoltage);
            this.flowLayoutPanel4.Controls.Add(this.cpbStateofCharge);
            this.flowLayoutPanel4.Controls.Add(this.cpbAverageCurrent);
            this.flowLayoutPanel4.Controls.Add(this.cpbAveragePower);
            this.flowLayoutPanel4.Controls.Add(this.cpbStateofHealth);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(757, 70);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(472, 565);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // cpbTempature
            // 
            this.cpbTempature.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.CircularEaseInOut;
            this.cpbTempature.AnimationSpeed = 1000;
            this.cpbTempature.BackColor = System.Drawing.Color.Transparent;
            this.cpbTempature.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cpbTempature.ForeColor = System.Drawing.Color.DarkCyan;
            this.cpbTempature.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cpbTempature.InnerMargin = 1;
            this.cpbTempature.InnerWidth = -1;
            this.cpbTempature.Location = new System.Drawing.Point(3, 3);
            this.cpbTempature.MarqueeAnimationSpeed = 2000;
            this.cpbTempature.Name = "cpbTempature";
            this.cpbTempature.OuterColor = System.Drawing.Color.Gray;
            this.cpbTempature.OuterMargin = -15;
            this.cpbTempature.OuterWidth = 15;
            this.cpbTempature.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cpbTempature.ProgressWidth = 15;
            this.cpbTempature.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.cpbTempature.Size = new System.Drawing.Size(150, 150);
            this.cpbTempature.StartAngle = 270;
            this.cpbTempature.SubscriptColor = System.Drawing.Color.Red;
            this.cpbTempature.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.cpbTempature.SubscriptText = "";
            this.cpbTempature.SuperscriptColor = System.Drawing.Color.Red;
            this.cpbTempature.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.cpbTempature.SuperscriptText = "";
            this.cpbTempature.TabIndex = 0;
            this.cpbTempature.Text = "Tempature";
            this.cpbTempature.TextMargin = new System.Windows.Forms.Padding(0);
            this.cpbTempature.Value = 1;
            // 
            // cpbVoltage
            // 
            this.cpbVoltage.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbVoltage.AnimationSpeed = 500;
            this.cpbVoltage.BackColor = System.Drawing.Color.Transparent;
            this.cpbVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cpbVoltage.ForeColor = System.Drawing.Color.DarkCyan;
            this.cpbVoltage.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cpbVoltage.InnerMargin = 1;
            this.cpbVoltage.InnerWidth = -1;
            this.cpbVoltage.Location = new System.Drawing.Point(159, 3);
            this.cpbVoltage.MarqueeAnimationSpeed = 2000;
            this.cpbVoltage.Name = "cpbVoltage";
            this.cpbVoltage.OuterColor = System.Drawing.Color.Gray;
            this.cpbVoltage.OuterMargin = -15;
            this.cpbVoltage.OuterWidth = 15;
            this.cpbVoltage.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cpbVoltage.ProgressWidth = 15;
            this.cpbVoltage.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.cpbVoltage.Size = new System.Drawing.Size(150, 150);
            this.cpbVoltage.StartAngle = 270;
            this.cpbVoltage.SubscriptColor = System.Drawing.Color.Red;
            this.cpbVoltage.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.cpbVoltage.SubscriptText = "";
            this.cpbVoltage.SuperscriptColor = System.Drawing.Color.Red;
            this.cpbVoltage.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.cpbVoltage.SuperscriptText = "";
            this.cpbVoltage.TabIndex = 1;
            this.cpbVoltage.Text = "Voltage";
            this.cpbVoltage.TextMargin = new System.Windows.Forms.Padding(0);
            this.cpbVoltage.Value = 1;
            // 
            // cpbCapacity
            // 
            this.cpbCapacity.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbCapacity.AnimationSpeed = 500;
            this.cpbCapacity.BackColor = System.Drawing.Color.Transparent;
            this.cpbCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cpbCapacity.ForeColor = System.Drawing.Color.DarkCyan;
            this.cpbCapacity.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cpbCapacity.InnerMargin = 1;
            this.cpbCapacity.InnerWidth = -1;
            this.cpbCapacity.Location = new System.Drawing.Point(315, 3);
            this.cpbCapacity.MarqueeAnimationSpeed = 2000;
            this.cpbCapacity.Name = "cpbCapacity";
            this.cpbCapacity.OuterColor = System.Drawing.Color.Gray;
            this.cpbCapacity.OuterMargin = -15;
            this.cpbCapacity.OuterWidth = 15;
            this.cpbCapacity.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cpbCapacity.ProgressWidth = 15;
            this.cpbCapacity.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.cpbCapacity.Size = new System.Drawing.Size(150, 150);
            this.cpbCapacity.StartAngle = 270;
            this.cpbCapacity.SubscriptColor = System.Drawing.Color.Red;
            this.cpbCapacity.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.cpbCapacity.SubscriptText = "";
            this.cpbCapacity.SuperscriptColor = System.Drawing.Color.Red;
            this.cpbCapacity.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.cpbCapacity.SuperscriptText = "";
            this.cpbCapacity.TabIndex = 2;
            this.cpbCapacity.Text = "Capacity";
            this.cpbCapacity.TextMargin = new System.Windows.Forms.Padding(0);
            this.cpbCapacity.Value = 1;
            // 
            // cpbChargingCurrent
            // 
            this.cpbChargingCurrent.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbChargingCurrent.AnimationSpeed = 500;
            this.cpbChargingCurrent.BackColor = System.Drawing.Color.Transparent;
            this.cpbChargingCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cpbChargingCurrent.ForeColor = System.Drawing.Color.DarkCyan;
            this.cpbChargingCurrent.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cpbChargingCurrent.InnerMargin = 1;
            this.cpbChargingCurrent.InnerWidth = -1;
            this.cpbChargingCurrent.Location = new System.Drawing.Point(3, 159);
            this.cpbChargingCurrent.MarqueeAnimationSpeed = 2000;
            this.cpbChargingCurrent.Name = "cpbChargingCurrent";
            this.cpbChargingCurrent.OuterColor = System.Drawing.Color.Gray;
            this.cpbChargingCurrent.OuterMargin = -15;
            this.cpbChargingCurrent.OuterWidth = 15;
            this.cpbChargingCurrent.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cpbChargingCurrent.ProgressWidth = 15;
            this.cpbChargingCurrent.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.cpbChargingCurrent.Size = new System.Drawing.Size(150, 150);
            this.cpbChargingCurrent.StartAngle = 270;
            this.cpbChargingCurrent.SubscriptColor = System.Drawing.Color.Red;
            this.cpbChargingCurrent.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.cpbChargingCurrent.SubscriptText = "";
            this.cpbChargingCurrent.SuperscriptColor = System.Drawing.Color.Red;
            this.cpbChargingCurrent.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.cpbChargingCurrent.SuperscriptText = "";
            this.cpbChargingCurrent.TabIndex = 3;
            this.cpbChargingCurrent.Text = "Charging Current";
            this.cpbChargingCurrent.TextMargin = new System.Windows.Forms.Padding(0);
            this.cpbChargingCurrent.Value = 1;
            // 
            // cpbChargingVoltage
            // 
            this.cpbChargingVoltage.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbChargingVoltage.AnimationSpeed = 500;
            this.cpbChargingVoltage.BackColor = System.Drawing.Color.Transparent;
            this.cpbChargingVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cpbChargingVoltage.ForeColor = System.Drawing.Color.DarkCyan;
            this.cpbChargingVoltage.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cpbChargingVoltage.InnerMargin = 1;
            this.cpbChargingVoltage.InnerWidth = -1;
            this.cpbChargingVoltage.Location = new System.Drawing.Point(159, 159);
            this.cpbChargingVoltage.MarqueeAnimationSpeed = 2000;
            this.cpbChargingVoltage.Name = "cpbChargingVoltage";
            this.cpbChargingVoltage.OuterColor = System.Drawing.Color.Gray;
            this.cpbChargingVoltage.OuterMargin = -15;
            this.cpbChargingVoltage.OuterWidth = 15;
            this.cpbChargingVoltage.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cpbChargingVoltage.ProgressWidth = 15;
            this.cpbChargingVoltage.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.cpbChargingVoltage.Size = new System.Drawing.Size(150, 150);
            this.cpbChargingVoltage.StartAngle = 270;
            this.cpbChargingVoltage.SubscriptColor = System.Drawing.Color.Red;
            this.cpbChargingVoltage.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.cpbChargingVoltage.SubscriptText = "";
            this.cpbChargingVoltage.SuperscriptColor = System.Drawing.Color.Red;
            this.cpbChargingVoltage.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.cpbChargingVoltage.SuperscriptText = "";
            this.cpbChargingVoltage.TabIndex = 5;
            this.cpbChargingVoltage.Text = "Charging Voltage";
            this.cpbChargingVoltage.TextMargin = new System.Windows.Forms.Padding(0);
            this.cpbChargingVoltage.Value = 1;
            // 
            // cpbStateofCharge
            // 
            this.cpbStateofCharge.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbStateofCharge.AnimationSpeed = 500;
            this.cpbStateofCharge.BackColor = System.Drawing.Color.Transparent;
            this.cpbStateofCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cpbStateofCharge.ForeColor = System.Drawing.Color.DarkCyan;
            this.cpbStateofCharge.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cpbStateofCharge.InnerMargin = 1;
            this.cpbStateofCharge.InnerWidth = -1;
            this.cpbStateofCharge.Location = new System.Drawing.Point(315, 159);
            this.cpbStateofCharge.MarqueeAnimationSpeed = 2000;
            this.cpbStateofCharge.Name = "cpbStateofCharge";
            this.cpbStateofCharge.OuterColor = System.Drawing.Color.Gray;
            this.cpbStateofCharge.OuterMargin = -15;
            this.cpbStateofCharge.OuterWidth = 15;
            this.cpbStateofCharge.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cpbStateofCharge.ProgressWidth = 15;
            this.cpbStateofCharge.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.cpbStateofCharge.Size = new System.Drawing.Size(150, 150);
            this.cpbStateofCharge.StartAngle = 270;
            this.cpbStateofCharge.SubscriptColor = System.Drawing.Color.Red;
            this.cpbStateofCharge.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.cpbStateofCharge.SubscriptText = "";
            this.cpbStateofCharge.SuperscriptColor = System.Drawing.Color.Red;
            this.cpbStateofCharge.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.cpbStateofCharge.SuperscriptText = "";
            this.cpbStateofCharge.TabIndex = 6;
            this.cpbStateofCharge.Text = "State of Charge";
            this.cpbStateofCharge.TextMargin = new System.Windows.Forms.Padding(0);
            this.cpbStateofCharge.Value = 1;
            // 
            // cpbAverageCurrent
            // 
            this.cpbAverageCurrent.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbAverageCurrent.AnimationSpeed = 500;
            this.cpbAverageCurrent.BackColor = System.Drawing.Color.Transparent;
            this.cpbAverageCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cpbAverageCurrent.ForeColor = System.Drawing.Color.DarkCyan;
            this.cpbAverageCurrent.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cpbAverageCurrent.InnerMargin = 1;
            this.cpbAverageCurrent.InnerWidth = -1;
            this.cpbAverageCurrent.Location = new System.Drawing.Point(3, 315);
            this.cpbAverageCurrent.MarqueeAnimationSpeed = 2000;
            this.cpbAverageCurrent.Name = "cpbAverageCurrent";
            this.cpbAverageCurrent.OuterColor = System.Drawing.Color.Gray;
            this.cpbAverageCurrent.OuterMargin = -15;
            this.cpbAverageCurrent.OuterWidth = 15;
            this.cpbAverageCurrent.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cpbAverageCurrent.ProgressWidth = 15;
            this.cpbAverageCurrent.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.cpbAverageCurrent.Size = new System.Drawing.Size(150, 150);
            this.cpbAverageCurrent.StartAngle = 270;
            this.cpbAverageCurrent.SubscriptColor = System.Drawing.Color.Red;
            this.cpbAverageCurrent.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.cpbAverageCurrent.SubscriptText = "";
            this.cpbAverageCurrent.SuperscriptColor = System.Drawing.Color.Red;
            this.cpbAverageCurrent.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.cpbAverageCurrent.SuperscriptText = "";
            this.cpbAverageCurrent.TabIndex = 7;
            this.cpbAverageCurrent.Text = "Average Current";
            this.cpbAverageCurrent.TextMargin = new System.Windows.Forms.Padding(0);
            this.cpbAverageCurrent.Value = 1;
            // 
            // cpbAveragePower
            // 
            this.cpbAveragePower.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbAveragePower.AnimationSpeed = 500;
            this.cpbAveragePower.BackColor = System.Drawing.Color.Transparent;
            this.cpbAveragePower.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cpbAveragePower.ForeColor = System.Drawing.Color.DarkCyan;
            this.cpbAveragePower.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cpbAveragePower.InnerMargin = 1;
            this.cpbAveragePower.InnerWidth = -1;
            this.cpbAveragePower.Location = new System.Drawing.Point(159, 315);
            this.cpbAveragePower.MarqueeAnimationSpeed = 2000;
            this.cpbAveragePower.Name = "cpbAveragePower";
            this.cpbAveragePower.OuterColor = System.Drawing.Color.Gray;
            this.cpbAveragePower.OuterMargin = -15;
            this.cpbAveragePower.OuterWidth = 15;
            this.cpbAveragePower.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cpbAveragePower.ProgressWidth = 15;
            this.cpbAveragePower.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.cpbAveragePower.Size = new System.Drawing.Size(150, 150);
            this.cpbAveragePower.StartAngle = 270;
            this.cpbAveragePower.SubscriptColor = System.Drawing.Color.Red;
            this.cpbAveragePower.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.cpbAveragePower.SubscriptText = "";
            this.cpbAveragePower.SuperscriptColor = System.Drawing.Color.Red;
            this.cpbAveragePower.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.cpbAveragePower.SuperscriptText = "";
            this.cpbAveragePower.TabIndex = 8;
            this.cpbAveragePower.Text = "Average Power";
            this.cpbAveragePower.TextMargin = new System.Windows.Forms.Padding(0);
            this.cpbAveragePower.Value = 1;
            // 
            // cpbStateofHealth
            // 
            this.cpbStateofHealth.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbStateofHealth.AnimationSpeed = 500;
            this.cpbStateofHealth.BackColor = System.Drawing.Color.Transparent;
            this.cpbStateofHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cpbStateofHealth.ForeColor = System.Drawing.Color.DarkCyan;
            this.cpbStateofHealth.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cpbStateofHealth.InnerMargin = 1;
            this.cpbStateofHealth.InnerWidth = -1;
            this.cpbStateofHealth.Location = new System.Drawing.Point(315, 315);
            this.cpbStateofHealth.MarqueeAnimationSpeed = 2000;
            this.cpbStateofHealth.Name = "cpbStateofHealth";
            this.cpbStateofHealth.OuterColor = System.Drawing.Color.Gray;
            this.cpbStateofHealth.OuterMargin = -15;
            this.cpbStateofHealth.OuterWidth = 15;
            this.cpbStateofHealth.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cpbStateofHealth.ProgressWidth = 15;
            this.cpbStateofHealth.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.cpbStateofHealth.Size = new System.Drawing.Size(150, 150);
            this.cpbStateofHealth.StartAngle = 270;
            this.cpbStateofHealth.SubscriptColor = System.Drawing.Color.Red;
            this.cpbStateofHealth.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.cpbStateofHealth.SubscriptText = "";
            this.cpbStateofHealth.SuperscriptColor = System.Drawing.Color.Red;
            this.cpbStateofHealth.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.cpbStateofHealth.SuperscriptText = "";
            this.cpbStateofHealth.TabIndex = 9;
            this.cpbStateofHealth.Text = "State of Health";
            this.cpbStateofHealth.TextMargin = new System.Windows.Forms.Padding(0);
            this.cpbStateofHealth.Value = 1;
            // 
            // BatteryCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 854);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "BatteryCheck";
            this.Padding = new System.Windows.Forms.Padding(10, 70, 10, 10);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "Apple Batarya Kontrolü";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BatteryCheck_FormClosing);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label lCycleCount;
        private System.Windows.Forms.Label lVoltage;
        private System.Windows.Forms.Label lTemperature;
        private System.Windows.Forms.Label lStateOfCharge;
        private System.Windows.Forms.Label lFullChargeCapacity;
        private System.Windows.Forms.Label lRemainingCapacity;
        private System.Windows.Forms.Label lDeviceType;
        private System.IO.Ports.SerialPort serialPortBAT;
        private System.Windows.Forms.Label lblCycleCount;
        private System.Windows.Forms.Label lblVoltage;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblStateOfCharge;
        private System.Windows.Forms.Label lblDesignCapacity;
        private System.Windows.Forms.Label lblFullChargeCapacity;
        private System.Windows.Forms.Label lblRemainingCapacity;
        private System.Windows.Forms.Label lblDeviceType;
        private System.Windows.Forms.Label lFirmwareVersion;
        private System.Windows.Forms.Label lblFirmwareVersion;
        private MetroFramework.Controls.MetroComboBox cbPrort;
        private MetroFramework.Controls.MetroButton btnRead;
        private MetroFramework.Controls.MetroComboBox cbInterface;
        private System.Windows.Forms.Label lHardwareVersion;
        private System.Windows.Forms.Label lblHardwareVersion;
        private System.Windows.Forms.CheckBox chbDataLog;
        private MetroFramework.Controls.MetroLink YT;
        private System.Windows.Forms.Label lBatteryHealth;
        private System.Windows.Forms.Label lblBatteryHealth;
        private System.Windows.Forms.Label lDesignCapacity;
        private Bulb.LedBulb ledBulb1;
        private System.Windows.Forms.Label lControlStatus;
        private System.Windows.Forms.Label lManufacturerBlockA;
        private System.Windows.Forms.Label lManufacturerBlockB;
        private System.Windows.Forms.Label lblControlStatus;
        private System.Windows.Forms.Label lblManufacturerBlockA;
        private System.Windows.Forms.Label lblManufacturerBlockB;
        private System.Windows.Forms.Label lManufacturerBlockC;
        private System.Windows.Forms.Label lblManufacturerBlockC;
        private System.Windows.Forms.Label lChecksum;
        private System.Windows.Forms.Label lblChecksum;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private CircularProgressBar.CircularProgressBar cpbTempature;
        private CircularProgressBar.CircularProgressBar cpbVoltage;
        private CircularProgressBar.CircularProgressBar cpbCapacity;
        private CircularProgressBar.CircularProgressBar cpbChargingCurrent;
        private CircularProgressBar.CircularProgressBar cpbChargingVoltage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private CircularProgressBar.CircularProgressBar cpbStateofCharge;
        private CircularProgressBar.CircularProgressBar cpbAverageCurrent;
        private CircularProgressBar.CircularProgressBar cpbAveragePower;
        private CircularProgressBar.CircularProgressBar cpbStateofHealth;
    }
}

