
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lTemperature = new System.Windows.Forms.Label();
            this.lVoltage = new System.Windows.Forms.Label();
            this.lRemainingCapacity = new System.Windows.Forms.Label();
            this.lFullChargeCapacity = new System.Windows.Forms.Label();
            this.lDesignCapacity = new System.Windows.Forms.Label();
            this.lCycleCount = new System.Windows.Forms.Label();
            this.lStateOfCharge = new System.Windows.Forms.Label();
            this.lDeviceType = new System.Windows.Forms.Label();
            this.lControlStatus = new System.Windows.Forms.Label();
            this.lFirmwareVersion = new System.Windows.Forms.Label();
            this.lHardwareVersion = new System.Windows.Forms.Label();
            this.lManufacturerBlockA = new System.Windows.Forms.Label();
            this.lManufacturerBlockB = new System.Windows.Forms.Label();
            this.lManufacturerBlockC = new System.Windows.Forms.Label();
            this.lBatteryHealth = new System.Windows.Forms.Label();
            this.lChecksum = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblVoltage = new System.Windows.Forms.Label();
            this.lblRemainingCapacity = new System.Windows.Forms.Label();
            this.lblFullChargeCapacity = new System.Windows.Forms.Label();
            this.lblDesignCapacity = new System.Windows.Forms.Label();
            this.lblCycleCount = new System.Windows.Forms.Label();
            this.lblStateOfCharge = new System.Windows.Forms.Label();
            this.lblDeviceType = new System.Windows.Forms.Label();
            this.lblControlStatus = new System.Windows.Forms.Label();
            this.lblFirmwareVersion = new System.Windows.Forms.Label();
            this.lblHardwareVersion = new System.Windows.Forms.Label();
            this.lblManufacturerBlockA = new System.Windows.Forms.Label();
            this.lblManufacturerBlockB = new System.Windows.Forms.Label();
            this.lblManufacturerBlockC = new System.Windows.Forms.Label();
            this.lblBatteryHealth = new System.Windows.Forms.Label();
            this.lblChecksum = new System.Windows.Forms.Label();
            this.serialPortBAT = new System.IO.Ports.SerialPort(this.components);
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.cpbTempature = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar2 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar3 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar4 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar5 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar6 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar7 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar8 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar9 = new CircularProgressBar.CircularProgressBar();
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
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 636);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(649, 80);
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
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lTemperature);
            this.flowLayoutPanel2.Controls.Add(this.lVoltage);
            this.flowLayoutPanel2.Controls.Add(this.lRemainingCapacity);
            this.flowLayoutPanel2.Controls.Add(this.lFullChargeCapacity);
            this.flowLayoutPanel2.Controls.Add(this.lDesignCapacity);
            this.flowLayoutPanel2.Controls.Add(this.lCycleCount);
            this.flowLayoutPanel2.Controls.Add(this.lStateOfCharge);
            this.flowLayoutPanel2.Controls.Add(this.lDeviceType);
            this.flowLayoutPanel2.Controls.Add(this.lControlStatus);
            this.flowLayoutPanel2.Controls.Add(this.lFirmwareVersion);
            this.flowLayoutPanel2.Controls.Add(this.lHardwareVersion);
            this.flowLayoutPanel2.Controls.Add(this.lManufacturerBlockA);
            this.flowLayoutPanel2.Controls.Add(this.lManufacturerBlockB);
            this.flowLayoutPanel2.Controls.Add(this.lManufacturerBlockC);
            this.flowLayoutPanel2.Controls.Add(this.lBatteryHealth);
            this.flowLayoutPanel2.Controls.Add(this.lChecksum);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(10, 70);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(176, 566);
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
            // lDeviceType
            // 
            this.lDeviceType.AutoSize = true;
            this.lDeviceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDeviceType.Location = new System.Drawing.Point(5, 255);
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
            this.lControlStatus.Location = new System.Drawing.Point(5, 290);
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
            this.lFirmwareVersion.Location = new System.Drawing.Point(5, 325);
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
            this.lHardwareVersion.Location = new System.Drawing.Point(5, 360);
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
            this.lManufacturerBlockA.Location = new System.Drawing.Point(5, 395);
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
            this.lManufacturerBlockB.Location = new System.Drawing.Point(5, 430);
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
            this.lManufacturerBlockC.Location = new System.Drawing.Point(5, 465);
            this.lManufacturerBlockC.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lManufacturerBlockC.Name = "lManufacturerBlockC";
            this.lManufacturerBlockC.Size = new System.Drawing.Size(162, 20);
            this.lManufacturerBlockC.TabIndex = 14;
            this.lManufacturerBlockC.Text = "Manufacturer Block C";
            this.lManufacturerBlockC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lBatteryHealth
            // 
            this.lBatteryHealth.AutoSize = true;
            this.lBatteryHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lBatteryHealth.Location = new System.Drawing.Point(5, 500);
            this.lBatteryHealth.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lBatteryHealth.Name = "lBatteryHealth";
            this.lBatteryHealth.Size = new System.Drawing.Size(76, 20);
            this.lBatteryHealth.TabIndex = 10;
            this.lBatteryHealth.Text = "Pil Sağlığı";
            this.lBatteryHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.flowLayoutPanel3.Controls.Add(this.lblDeviceType);
            this.flowLayoutPanel3.Controls.Add(this.lblControlStatus);
            this.flowLayoutPanel3.Controls.Add(this.lblFirmwareVersion);
            this.flowLayoutPanel3.Controls.Add(this.lblHardwareVersion);
            this.flowLayoutPanel3.Controls.Add(this.lblManufacturerBlockA);
            this.flowLayoutPanel3.Controls.Add(this.lblManufacturerBlockB);
            this.flowLayoutPanel3.Controls.Add(this.lblManufacturerBlockC);
            this.flowLayoutPanel3.Controls.Add(this.lblBatteryHealth);
            this.flowLayoutPanel3.Controls.Add(this.lblChecksum);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(186, 70);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(473, 566);
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
            // lblDeviceType
            // 
            this.lblDeviceType.AutoSize = true;
            this.lblDeviceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDeviceType.Location = new System.Drawing.Point(5, 255);
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
            this.lblControlStatus.Location = new System.Drawing.Point(5, 290);
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
            this.lblFirmwareVersion.Location = new System.Drawing.Point(5, 325);
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
            this.lblHardwareVersion.Location = new System.Drawing.Point(5, 360);
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
            this.lblManufacturerBlockA.Location = new System.Drawing.Point(5, 395);
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
            this.lblManufacturerBlockB.Location = new System.Drawing.Point(5, 430);
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
            this.lblManufacturerBlockC.Location = new System.Drawing.Point(5, 465);
            this.lblManufacturerBlockC.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblManufacturerBlockC.Name = "lblManufacturerBlockC";
            this.lblManufacturerBlockC.Size = new System.Drawing.Size(33, 20);
            this.lblManufacturerBlockC.TabIndex = 48;
            this.lblManufacturerBlockC.Text = "--/--";
            this.lblManufacturerBlockC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBatteryHealth
            // 
            this.lblBatteryHealth.AutoSize = true;
            this.lblBatteryHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBatteryHealth.Location = new System.Drawing.Point(5, 500);
            this.lblBatteryHealth.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblBatteryHealth.Name = "lblBatteryHealth";
            this.lblBatteryHealth.Size = new System.Drawing.Size(33, 20);
            this.lblBatteryHealth.TabIndex = 44;
            this.lblBatteryHealth.Text = "--/--";
            this.lblBatteryHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.flowLayoutPanel4.Controls.Add(this.circularProgressBar1);
            this.flowLayoutPanel4.Controls.Add(this.circularProgressBar2);
            this.flowLayoutPanel4.Controls.Add(this.circularProgressBar3);
            this.flowLayoutPanel4.Controls.Add(this.circularProgressBar4);
            this.flowLayoutPanel4.Controls.Add(this.circularProgressBar5);
            this.flowLayoutPanel4.Controls.Add(this.circularProgressBar6);
            this.flowLayoutPanel4.Controls.Add(this.circularProgressBar7);
            this.flowLayoutPanel4.Controls.Add(this.circularProgressBar8);
            this.flowLayoutPanel4.Controls.Add(this.circularProgressBar9);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(438, 70);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(221, 566);
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
            this.cpbTempature.Size = new System.Drawing.Size(100, 100);
            this.cpbTempature.StartAngle = 270;
            this.cpbTempature.SubscriptColor = System.Drawing.Color.Red;
            this.cpbTempature.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.cpbTempature.SubscriptText = ".23";
            this.cpbTempature.SuperscriptColor = System.Drawing.Color.Red;
            this.cpbTempature.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.cpbTempature.SuperscriptText = "°C";
            this.cpbTempature.TabIndex = 0;
            this.cpbTempature.Text = "Sıcaklık";
            this.cpbTempature.TextMargin = new System.Windows.Forms.Padding(0);
            this.cpbTempature.Value = 1;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.DarkCyan;
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar1.InnerMargin = 1;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(109, 3);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar1.OuterMargin = -15;
            this.circularProgressBar1.OuterWidth = 15;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBar1.ProgressWidth = 15;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.Size = new System.Drawing.Size(100, 100);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.Red;
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar1.SubscriptText = ".23";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.Red;
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar1.SuperscriptText = "°C";
            this.circularProgressBar1.TabIndex = 1;
            this.circularProgressBar1.Text = "Sıcaklık";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar1.Value = 1;
            // 
            // circularProgressBar2
            // 
            this.circularProgressBar2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar2.AnimationSpeed = 500;
            this.circularProgressBar2.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.circularProgressBar2.ForeColor = System.Drawing.Color.DarkCyan;
            this.circularProgressBar2.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar2.InnerMargin = 1;
            this.circularProgressBar2.InnerWidth = -1;
            this.circularProgressBar2.Location = new System.Drawing.Point(3, 109);
            this.circularProgressBar2.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar2.Name = "circularProgressBar2";
            this.circularProgressBar2.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar2.OuterMargin = -15;
            this.circularProgressBar2.OuterWidth = 15;
            this.circularProgressBar2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBar2.ProgressWidth = 15;
            this.circularProgressBar2.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar2.Size = new System.Drawing.Size(100, 100);
            this.circularProgressBar2.StartAngle = 270;
            this.circularProgressBar2.SubscriptColor = System.Drawing.Color.Red;
            this.circularProgressBar2.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar2.SubscriptText = ".23";
            this.circularProgressBar2.SuperscriptColor = System.Drawing.Color.Red;
            this.circularProgressBar2.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar2.SuperscriptText = "°C";
            this.circularProgressBar2.TabIndex = 2;
            this.circularProgressBar2.Text = "Sıcaklık";
            this.circularProgressBar2.TextMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar2.Value = 1;
            // 
            // circularProgressBar3
            // 
            this.circularProgressBar3.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar3.AnimationSpeed = 500;
            this.circularProgressBar3.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.circularProgressBar3.ForeColor = System.Drawing.Color.DarkCyan;
            this.circularProgressBar3.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar3.InnerMargin = 1;
            this.circularProgressBar3.InnerWidth = -1;
            this.circularProgressBar3.Location = new System.Drawing.Point(109, 109);
            this.circularProgressBar3.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar3.Name = "circularProgressBar3";
            this.circularProgressBar3.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar3.OuterMargin = -15;
            this.circularProgressBar3.OuterWidth = 15;
            this.circularProgressBar3.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBar3.ProgressWidth = 15;
            this.circularProgressBar3.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar3.Size = new System.Drawing.Size(100, 100);
            this.circularProgressBar3.StartAngle = 270;
            this.circularProgressBar3.SubscriptColor = System.Drawing.Color.Red;
            this.circularProgressBar3.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar3.SubscriptText = ".23";
            this.circularProgressBar3.SuperscriptColor = System.Drawing.Color.Red;
            this.circularProgressBar3.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar3.SuperscriptText = "°C";
            this.circularProgressBar3.TabIndex = 3;
            this.circularProgressBar3.Text = "Sıcaklık";
            this.circularProgressBar3.TextMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar3.Value = 1;
            // 
            // circularProgressBar4
            // 
            this.circularProgressBar4.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar4.AnimationSpeed = 500;
            this.circularProgressBar4.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.circularProgressBar4.ForeColor = System.Drawing.Color.DarkCyan;
            this.circularProgressBar4.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar4.InnerMargin = 1;
            this.circularProgressBar4.InnerWidth = -1;
            this.circularProgressBar4.Location = new System.Drawing.Point(3, 215);
            this.circularProgressBar4.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar4.Name = "circularProgressBar4";
            this.circularProgressBar4.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar4.OuterMargin = -15;
            this.circularProgressBar4.OuterWidth = 15;
            this.circularProgressBar4.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBar4.ProgressWidth = 15;
            this.circularProgressBar4.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar4.Size = new System.Drawing.Size(100, 100);
            this.circularProgressBar4.StartAngle = 270;
            this.circularProgressBar4.SubscriptColor = System.Drawing.Color.Red;
            this.circularProgressBar4.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar4.SubscriptText = ".23";
            this.circularProgressBar4.SuperscriptColor = System.Drawing.Color.Red;
            this.circularProgressBar4.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar4.SuperscriptText = "°C";
            this.circularProgressBar4.TabIndex = 4;
            this.circularProgressBar4.Text = "Sıcaklık";
            this.circularProgressBar4.TextMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar4.Value = 1;
            // 
            // circularProgressBar5
            // 
            this.circularProgressBar5.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar5.AnimationSpeed = 500;
            this.circularProgressBar5.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.circularProgressBar5.ForeColor = System.Drawing.Color.DarkCyan;
            this.circularProgressBar5.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar5.InnerMargin = 1;
            this.circularProgressBar5.InnerWidth = -1;
            this.circularProgressBar5.Location = new System.Drawing.Point(109, 215);
            this.circularProgressBar5.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar5.Name = "circularProgressBar5";
            this.circularProgressBar5.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar5.OuterMargin = -15;
            this.circularProgressBar5.OuterWidth = 15;
            this.circularProgressBar5.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBar5.ProgressWidth = 15;
            this.circularProgressBar5.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar5.Size = new System.Drawing.Size(100, 100);
            this.circularProgressBar5.StartAngle = 270;
            this.circularProgressBar5.SubscriptColor = System.Drawing.Color.Red;
            this.circularProgressBar5.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar5.SubscriptText = ".23";
            this.circularProgressBar5.SuperscriptColor = System.Drawing.Color.Red;
            this.circularProgressBar5.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar5.SuperscriptText = "°C";
            this.circularProgressBar5.TabIndex = 5;
            this.circularProgressBar5.Text = "Sıcaklık";
            this.circularProgressBar5.TextMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar5.Value = 1;
            // 
            // circularProgressBar6
            // 
            this.circularProgressBar6.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar6.AnimationSpeed = 500;
            this.circularProgressBar6.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.circularProgressBar6.ForeColor = System.Drawing.Color.DarkCyan;
            this.circularProgressBar6.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar6.InnerMargin = 1;
            this.circularProgressBar6.InnerWidth = -1;
            this.circularProgressBar6.Location = new System.Drawing.Point(3, 321);
            this.circularProgressBar6.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar6.Name = "circularProgressBar6";
            this.circularProgressBar6.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar6.OuterMargin = -15;
            this.circularProgressBar6.OuterWidth = 15;
            this.circularProgressBar6.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBar6.ProgressWidth = 15;
            this.circularProgressBar6.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar6.Size = new System.Drawing.Size(100, 100);
            this.circularProgressBar6.StartAngle = 270;
            this.circularProgressBar6.SubscriptColor = System.Drawing.Color.Red;
            this.circularProgressBar6.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar6.SubscriptText = ".23";
            this.circularProgressBar6.SuperscriptColor = System.Drawing.Color.Red;
            this.circularProgressBar6.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar6.SuperscriptText = "°C";
            this.circularProgressBar6.TabIndex = 6;
            this.circularProgressBar6.Text = "Sıcaklık";
            this.circularProgressBar6.TextMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar6.Value = 1;
            // 
            // circularProgressBar7
            // 
            this.circularProgressBar7.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar7.AnimationSpeed = 500;
            this.circularProgressBar7.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.circularProgressBar7.ForeColor = System.Drawing.Color.DarkCyan;
            this.circularProgressBar7.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar7.InnerMargin = 1;
            this.circularProgressBar7.InnerWidth = -1;
            this.circularProgressBar7.Location = new System.Drawing.Point(109, 321);
            this.circularProgressBar7.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar7.Name = "circularProgressBar7";
            this.circularProgressBar7.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar7.OuterMargin = -15;
            this.circularProgressBar7.OuterWidth = 15;
            this.circularProgressBar7.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBar7.ProgressWidth = 15;
            this.circularProgressBar7.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar7.Size = new System.Drawing.Size(100, 100);
            this.circularProgressBar7.StartAngle = 270;
            this.circularProgressBar7.SubscriptColor = System.Drawing.Color.Red;
            this.circularProgressBar7.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar7.SubscriptText = ".23";
            this.circularProgressBar7.SuperscriptColor = System.Drawing.Color.Red;
            this.circularProgressBar7.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar7.SuperscriptText = "°C";
            this.circularProgressBar7.TabIndex = 7;
            this.circularProgressBar7.Text = "Sıcaklık";
            this.circularProgressBar7.TextMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar7.Value = 1;
            // 
            // circularProgressBar8
            // 
            this.circularProgressBar8.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar8.AnimationSpeed = 500;
            this.circularProgressBar8.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.circularProgressBar8.ForeColor = System.Drawing.Color.DarkCyan;
            this.circularProgressBar8.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar8.InnerMargin = 1;
            this.circularProgressBar8.InnerWidth = -1;
            this.circularProgressBar8.Location = new System.Drawing.Point(3, 427);
            this.circularProgressBar8.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar8.Name = "circularProgressBar8";
            this.circularProgressBar8.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar8.OuterMargin = -15;
            this.circularProgressBar8.OuterWidth = 15;
            this.circularProgressBar8.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBar8.ProgressWidth = 15;
            this.circularProgressBar8.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar8.Size = new System.Drawing.Size(100, 100);
            this.circularProgressBar8.StartAngle = 270;
            this.circularProgressBar8.SubscriptColor = System.Drawing.Color.Red;
            this.circularProgressBar8.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar8.SubscriptText = ".23";
            this.circularProgressBar8.SuperscriptColor = System.Drawing.Color.Red;
            this.circularProgressBar8.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar8.SuperscriptText = "°C";
            this.circularProgressBar8.TabIndex = 8;
            this.circularProgressBar8.Text = "Sıcaklık";
            this.circularProgressBar8.TextMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar8.Value = 1;
            // 
            // circularProgressBar9
            // 
            this.circularProgressBar9.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar9.AnimationSpeed = 500;
            this.circularProgressBar9.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.circularProgressBar9.ForeColor = System.Drawing.Color.DarkCyan;
            this.circularProgressBar9.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar9.InnerMargin = 1;
            this.circularProgressBar9.InnerWidth = -1;
            this.circularProgressBar9.Location = new System.Drawing.Point(109, 427);
            this.circularProgressBar9.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar9.Name = "circularProgressBar9";
            this.circularProgressBar9.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar9.OuterMargin = -15;
            this.circularProgressBar9.OuterWidth = 15;
            this.circularProgressBar9.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBar9.ProgressWidth = 15;
            this.circularProgressBar9.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar9.Size = new System.Drawing.Size(100, 100);
            this.circularProgressBar9.StartAngle = 270;
            this.circularProgressBar9.SubscriptColor = System.Drawing.Color.Red;
            this.circularProgressBar9.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar9.SubscriptText = ".23";
            this.circularProgressBar9.SuperscriptColor = System.Drawing.Color.Red;
            this.circularProgressBar9.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar9.SuperscriptText = "°C";
            this.circularProgressBar9.TabIndex = 9;
            this.circularProgressBar9.Text = "Sıcaklık";
            this.circularProgressBar9.TextMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar9.Value = 1;
            // 
            // BatteryCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 726);
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
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private CircularProgressBar.CircularProgressBar circularProgressBar2;
        private CircularProgressBar.CircularProgressBar circularProgressBar3;
        private CircularProgressBar.CircularProgressBar circularProgressBar4;
        private CircularProgressBar.CircularProgressBar circularProgressBar5;
        private CircularProgressBar.CircularProgressBar circularProgressBar6;
        private CircularProgressBar.CircularProgressBar circularProgressBar7;
        private CircularProgressBar.CircularProgressBar circularProgressBar8;
        private CircularProgressBar.CircularProgressBar circularProgressBar9;
    }
}

