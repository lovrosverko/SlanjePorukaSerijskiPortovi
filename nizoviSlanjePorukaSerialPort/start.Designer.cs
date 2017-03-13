namespace nizoviSlanjePorukaSerialPort
{
    partial class start
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnServo1 = new System.Windows.Forms.Button();
            this.scrollServo1 = new System.Windows.Forms.HScrollBar();
            this.txtServoPos1 = new System.Windows.Forms.TextBox();
            this.btnLed2 = new System.Windows.Forms.Button();
            this.btnLed1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.btnFindArduino = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.servo1Vise = new System.Windows.Forms.Button();
            this.servo1Manje = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnServo1
            // 
            this.btnServo1.Location = new System.Drawing.Point(243, 328);
            this.btnServo1.Name = "btnServo1";
            this.btnServo1.Size = new System.Drawing.Size(77, 47);
            this.btnServo1.TabIndex = 69;
            this.btnServo1.Text = "Pošalji";
            this.btnServo1.UseVisualStyleBackColor = true;
            // 
            // scrollServo1
            // 
            this.scrollServo1.Location = new System.Drawing.Point(12, 301);
            this.scrollServo1.Maximum = 184;
            this.scrollServo1.Minimum = 5;
            this.scrollServo1.Name = "scrollServo1";
            this.scrollServo1.Size = new System.Drawing.Size(308, 17);
            this.scrollServo1.SmallChange = 5;
            this.scrollServo1.TabIndex = 68;
            this.scrollServo1.Value = 90;
            // 
            // txtServoPos1
            // 
            this.txtServoPos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtServoPos1.Location = new System.Drawing.Point(130, 328);
            this.txtServoPos1.Name = "txtServoPos1";
            this.txtServoPos1.ReadOnly = true;
            this.txtServoPos1.Size = new System.Drawing.Size(101, 47);
            this.txtServoPos1.TabIndex = 67;
            // 
            // btnLed2
            // 
            this.btnLed2.Font = new System.Drawing.Font("OCR-A BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLed2.ForeColor = System.Drawing.Color.Red;
            this.btnLed2.Location = new System.Drawing.Point(174, 12);
            this.btnLed2.Name = "btnLed2";
            this.btnLed2.Size = new System.Drawing.Size(75, 75);
            this.btnLed2.TabIndex = 64;
            this.btnLed2.Text = "Led 2";
            this.btnLed2.UseVisualStyleBackColor = true;
            this.btnLed2.Click += new System.EventHandler(this.btnLed2_Click);
            // 
            // btnLed1
            // 
            this.btnLed1.Font = new System.Drawing.Font("OCR-A BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLed1.ForeColor = System.Drawing.Color.Red;
            this.btnLed1.Location = new System.Drawing.Point(93, 12);
            this.btnLed1.Name = "btnLed1";
            this.btnLed1.Size = new System.Drawing.Size(75, 75);
            this.btnLed1.TabIndex = 63;
            this.btnLed1.Text = "Led 1";
            this.btnLed1.UseVisualStyleBackColor = true;
            this.btnLed1.Click += new System.EventHandler(this.btnLed1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(12, 115);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(308, 20);
            this.txtStatus.TabIndex = 61;
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "74880",
            "115200",
            "230400",
            "250000"});
            this.cmbBaudRate.Location = new System.Drawing.Point(255, 39);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(65, 21);
            this.cmbBaudRate.TabIndex = 60;
            this.cmbBaudRate.TabStop = false;
            this.cmbBaudRate.Text = "9600";
            // 
            // cmbPort
            // 
            this.cmbPort.Enabled = false;
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8"});
            this.cmbPort.Location = new System.Drawing.Point(255, 12);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(65, 21);
            this.cmbPort.Sorted = true;
            this.cmbPort.TabIndex = 59;
            this.cmbPort.TabStop = false;
            this.cmbPort.Text = "COM1";
            // 
            // btnFindArduino
            // 
            this.btnFindArduino.Location = new System.Drawing.Point(12, 12);
            this.btnFindArduino.Name = "btnFindArduino";
            this.btnFindArduino.Size = new System.Drawing.Size(75, 75);
            this.btnFindArduino.TabIndex = 58;
            this.btnFindArduino.Text = "Pronađi Arduino";
            this.btnFindArduino.UseVisualStyleBackColor = true;
            this.btnFindArduino.Click += new System.EventHandler(this.btnFindArduino_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::nizoviSlanjePorukaSerialPort.Properties.Resources.roboticArm;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 147);
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // servo1Vise
            // 
            this.servo1Vise.BackColor = System.Drawing.SystemColors.HighlightText;
            this.servo1Vise.BackgroundImage = global::nizoviSlanjePorukaSerialPort.Properties.Resources.desno;
            this.servo1Vise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.servo1Vise.Location = new System.Drawing.Point(71, 328);
            this.servo1Vise.Name = "servo1Vise";
            this.servo1Vise.Size = new System.Drawing.Size(47, 47);
            this.servo1Vise.TabIndex = 66;
            this.servo1Vise.UseVisualStyleBackColor = false;
            // 
            // servo1Manje
            // 
            this.servo1Manje.BackColor = System.Drawing.SystemColors.HighlightText;
            this.servo1Manje.BackgroundImage = global::nizoviSlanjePorukaSerialPort.Properties.Resources.lijevo;
            this.servo1Manje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.servo1Manje.Location = new System.Drawing.Point(12, 328);
            this.servo1Manje.Name = "servo1Manje";
            this.servo1Manje.Size = new System.Drawing.Size(47, 47);
            this.servo1Manje.TabIndex = 65;
            this.servo1Manje.UseVisualStyleBackColor = false;
            // 
            // start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 388);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnServo1);
            this.Controls.Add(this.scrollServo1);
            this.Controls.Add(this.txtServoPos1);
            this.Controls.Add(this.servo1Vise);
            this.Controls.Add(this.servo1Manje);
            this.Controls.Add(this.btnLed2);
            this.Controls.Add(this.btnLed1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.cmbBaudRate);
            this.Controls.Add(this.cmbPort);
            this.Controls.Add(this.btnFindArduino);
            this.Name = "start";
            this.Text = "start";
            this.Load += new System.EventHandler(this.Start_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnServo1;
        private System.Windows.Forms.HScrollBar scrollServo1;
        private System.Windows.Forms.TextBox txtServoPos1;
        private System.Windows.Forms.Button servo1Vise;
        private System.Windows.Forms.Button servo1Manje;
        private System.Windows.Forms.Button btnLed2;
        private System.Windows.Forms.Button btnLed1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.Button btnFindArduino;
    }
}