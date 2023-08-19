
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
            this.chbDataLog = new System.Windows.Forms.CheckBox();
            this.YT = new MetroFramework.Controls.MetroLink();
            this.ledBulb1 = new Bulb.LedBulb();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lTemperature = new System.Windows.Forms.Label();
            this.lVoltage = new System.Windows.Forms.Label();
            this.lRemainingCapacity = new System.Windows.Forms.Label();
            this.lFullChargeCapacity = new System.Windows.Forms.Label();
            this.lDesignCapacity = new System.Windows.Forms.Label();
            this.lCycleCount = new System.Windows.Forms.Label();
            this.lStateOfCharge = new System.Windows.Forms.Label();
            this.lDeviceType = new System.Windows.Forms.Label();
            this.lFirmwareVersion = new System.Windows.Forms.Label();
            this.lHardwareVersion = new System.Windows.Forms.Label();
            this.lBatteryHealth = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblVoltage = new System.Windows.Forms.Label();
            this.lblRemainingCapacity = new System.Windows.Forms.Label();
            this.lblFullChargeCapacity = new System.Windows.Forms.Label();
            this.lblDesignCapacity = new System.Windows.Forms.Label();
            this.lblCycleCount = new System.Windows.Forms.Label();
            this.lblStateOfCharge = new System.Windows.Forms.Label();
            this.lblDeviceType = new System.Windows.Forms.Label();
            this.lblFirmwareVersion = new System.Windows.Forms.Label();
            this.lblHardwareVersion = new System.Windows.Forms.Label();
            this.lblBatteryHealth = new System.Windows.Forms.Label();
            this.serialPortBAT = new System.IO.Ports.SerialPort(this.components);
            this.SN1 = new System.Windows.Forms.Label();
            this.SN2 = new System.Windows.Forms.Label();
            this.SN3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cbInterface);
            this.flowLayoutPanel1.Controls.Add(this.cbPrort);
            this.flowLayoutPanel1.Controls.Add(this.btnRead);
            this.flowLayoutPanel1.Controls.Add(this.chbDataLog);
            this.flowLayoutPanel1.Controls.Add(this.YT);
            this.flowLayoutPanel1.Controls.Add(this.ledBulb1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 595);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(401, 80);
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
            // chbDataLog
            // 
            this.chbDataLog.AutoSize = true;
            this.chbDataLog.Location = new System.Drawing.Point(5, 49);
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
            this.YT.Location = new System.Drawing.Point(186, 49);
            this.YT.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.YT.Name = "YT";
            this.YT.Size = new System.Drawing.Size(75, 23);
            this.YT.TabIndex = 11;
            this.YT.Text = "YouTube";
            this.YT.UseSelectable = true;
            this.YT.Click += new System.EventHandler(this.YT_Click);
            // 
            // ledBulb1
            // 
            this.ledBulb1.Location = new System.Drawing.Point(269, 42);
            this.ledBulb1.Name = "ledBulb1";
            this.ledBulb1.On = true;
            this.ledBulb1.Size = new System.Drawing.Size(26, 23);
            this.ledBulb1.TabIndex = 12;
            this.ledBulb1.Text = "ledBulb1";
            this.ledBulb1.Click += new System.EventHandler(this.ledBulb1_Click);
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
            this.flowLayoutPanel2.Controls.Add(this.lFirmwareVersion);
            this.flowLayoutPanel2.Controls.Add(this.lHardwareVersion);
            this.flowLayoutPanel2.Controls.Add(this.lBatteryHealth);
            this.flowLayoutPanel2.Controls.Add(this.SN1);
            this.flowLayoutPanel2.Controls.Add(this.SN2);
            this.flowLayoutPanel2.Controls.Add(this.SN3);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(10, 70);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(277, 525);
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
            // lFirmwareVersion
            // 
            this.lFirmwareVersion.AutoSize = true;
            this.lFirmwareVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFirmwareVersion.Location = new System.Drawing.Point(5, 290);
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
            this.lHardwareVersion.Location = new System.Drawing.Point(5, 325);
            this.lHardwareVersion.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lHardwareVersion.Name = "lHardwareVersion";
            this.lHardwareVersion.Size = new System.Drawing.Size(133, 20);
            this.lHardwareVersion.TabIndex = 9;
            this.lHardwareVersion.Text = "Donanım Sürümü";
            this.lHardwareVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lBatteryHealth
            // 
            this.lBatteryHealth.AutoSize = true;
            this.lBatteryHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lBatteryHealth.Location = new System.Drawing.Point(5, 360);
            this.lBatteryHealth.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lBatteryHealth.Name = "lBatteryHealth";
            this.lBatteryHealth.Size = new System.Drawing.Size(76, 20);
            this.lBatteryHealth.TabIndex = 10;
            this.lBatteryHealth.Text = "Pil Sağlığı";
            this.lBatteryHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.flowLayoutPanel3.Controls.Add(this.lblFirmwareVersion);
            this.flowLayoutPanel3.Controls.Add(this.lblHardwareVersion);
            this.flowLayoutPanel3.Controls.Add(this.lblBatteryHealth);
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(287, 70);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(124, 525);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // lblTemperature
            // 
            this.lblTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTemperature.Location = new System.Drawing.Point(5, 10);
            this.lblTemperature.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(100, 20);
            this.lblTemperature.TabIndex = 36;
            this.lblTemperature.Text = "--/--";
            this.lblTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVoltage
            // 
            this.lblVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVoltage.Location = new System.Drawing.Point(5, 45);
            this.lblVoltage.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblVoltage.Name = "lblVoltage";
            this.lblVoltage.Size = new System.Drawing.Size(100, 20);
            this.lblVoltage.TabIndex = 35;
            this.lblVoltage.Text = "--/--";
            this.lblVoltage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRemainingCapacity
            // 
            this.lblRemainingCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRemainingCapacity.Location = new System.Drawing.Point(5, 80);
            this.lblRemainingCapacity.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblRemainingCapacity.Name = "lblRemainingCapacity";
            this.lblRemainingCapacity.Size = new System.Drawing.Size(100, 20);
            this.lblRemainingCapacity.TabIndex = 40;
            this.lblRemainingCapacity.Text = "--/--";
            this.lblRemainingCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFullChargeCapacity
            // 
            this.lblFullChargeCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFullChargeCapacity.Location = new System.Drawing.Point(5, 115);
            this.lblFullChargeCapacity.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblFullChargeCapacity.Name = "lblFullChargeCapacity";
            this.lblFullChargeCapacity.Size = new System.Drawing.Size(100, 20);
            this.lblFullChargeCapacity.TabIndex = 39;
            this.lblFullChargeCapacity.Text = "--/--";
            this.lblFullChargeCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDesignCapacity
            // 
            this.lblDesignCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDesignCapacity.Location = new System.Drawing.Point(5, 150);
            this.lblDesignCapacity.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblDesignCapacity.Name = "lblDesignCapacity";
            this.lblDesignCapacity.Size = new System.Drawing.Size(100, 20);
            this.lblDesignCapacity.TabIndex = 38;
            this.lblDesignCapacity.Text = "--/--";
            this.lblDesignCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCycleCount
            // 
            this.lblCycleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCycleCount.Location = new System.Drawing.Point(5, 185);
            this.lblCycleCount.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblCycleCount.Name = "lblCycleCount";
            this.lblCycleCount.Size = new System.Drawing.Size(100, 20);
            this.lblCycleCount.TabIndex = 34;
            this.lblCycleCount.Text = "--/--";
            this.lblCycleCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStateOfCharge
            // 
            this.lblStateOfCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStateOfCharge.Location = new System.Drawing.Point(5, 220);
            this.lblStateOfCharge.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblStateOfCharge.Name = "lblStateOfCharge";
            this.lblStateOfCharge.Size = new System.Drawing.Size(100, 20);
            this.lblStateOfCharge.TabIndex = 37;
            this.lblStateOfCharge.Text = "--/--";
            this.lblStateOfCharge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeviceType
            // 
            this.lblDeviceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDeviceType.Location = new System.Drawing.Point(5, 255);
            this.lblDeviceType.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblDeviceType.Name = "lblDeviceType";
            this.lblDeviceType.Size = new System.Drawing.Size(100, 20);
            this.lblDeviceType.TabIndex = 41;
            this.lblDeviceType.Text = "--/--";
            this.lblDeviceType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirmwareVersion
            // 
            this.lblFirmwareVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirmwareVersion.Location = new System.Drawing.Point(5, 290);
            this.lblFirmwareVersion.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblFirmwareVersion.Name = "lblFirmwareVersion";
            this.lblFirmwareVersion.Size = new System.Drawing.Size(100, 20);
            this.lblFirmwareVersion.TabIndex = 42;
            this.lblFirmwareVersion.Text = "--/--";
            this.lblFirmwareVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHardwareVersion
            // 
            this.lblHardwareVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHardwareVersion.Location = new System.Drawing.Point(5, 325);
            this.lblHardwareVersion.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblHardwareVersion.Name = "lblHardwareVersion";
            this.lblHardwareVersion.Size = new System.Drawing.Size(100, 20);
            this.lblHardwareVersion.TabIndex = 43;
            this.lblHardwareVersion.Text = "--/--";
            this.lblHardwareVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBatteryHealth
            // 
            this.lblBatteryHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBatteryHealth.Location = new System.Drawing.Point(5, 360);
            this.lblBatteryHealth.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.lblBatteryHealth.Name = "lblBatteryHealth";
            this.lblBatteryHealth.Size = new System.Drawing.Size(100, 20);
            this.lblBatteryHealth.TabIndex = 44;
            this.lblBatteryHealth.Text = "--/--";
            this.lblBatteryHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serialPortBAT
            // 
            this.serialPortBAT.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPortBAT_DataReceived);
            // 
            // SN1
            // 
            this.SN1.AutoSize = true;
            this.SN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SN1.Location = new System.Drawing.Point(5, 395);
            this.SN1.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.SN1.Name = "SN1";
            this.SN1.Size = new System.Drawing.Size(76, 20);
            this.SN1.TabIndex = 11;
            this.SN1.Text = "Pil Sağlığı";
            this.SN1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SN2
            // 
            this.SN2.AutoSize = true;
            this.SN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SN2.Location = new System.Drawing.Point(5, 430);
            this.SN2.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.SN2.Name = "SN2";
            this.SN2.Size = new System.Drawing.Size(76, 20);
            this.SN2.TabIndex = 12;
            this.SN2.Text = "Pil Sağlığı";
            this.SN2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SN3
            // 
            this.SN3.AutoSize = true;
            this.SN3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SN3.Location = new System.Drawing.Point(5, 465);
            this.SN3.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.SN3.Name = "SN3";
            this.SN3.Size = new System.Drawing.Size(76, 20);
            this.SN3.TabIndex = 13;
            this.SN3.Text = "Pil Sağlığı";
            this.SN3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 395);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "--/--";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(5, 430);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "--/--";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(5, 465);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "--/--";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BatteryCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 685);
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
        private System.Windows.Forms.Label SN1;
        private System.Windows.Forms.Label SN2;
        private System.Windows.Forms.Label SN3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

