namespace IoT_Based_Manhole_Detection_System
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gBoxComPortControl = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxPARITYBITS = new System.Windows.Forms.ComboBox();
            this.cBoxSTOPBITS = new System.Windows.Forms.ComboBox();
            this.cBoxDATABITS = new System.Windows.Forms.ComboBox();
            this.cBoxBAUDRATE = new System.Windows.Forms.ComboBox();
            this.cBoxCOMPORT = new System.Windows.Forms.ComboBox();
            this.gBoxOpenClose = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sendWaterValue = new System.Windows.Forms.Button();
            this.cBoxWater = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.sendLightValue = new System.Windows.Forms.Button();
            this.cBoxLight = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.sendMicValue = new System.Windows.Forms.Button();
            this.cBoxMic = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.sendGasValue = new System.Windows.Forms.Button();
            this.cBoxGas = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.waterStatusLabel = new System.Windows.Forms.Label();
            this.soundStatusLabel = new System.Windows.Forms.Label();
            this.gasStatusLabel = new System.Windows.Forms.Label();
            this.lightStatusLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gBoxComPortControl.SuspendLayout();
            this.gBoxOpenClose.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxComPortControl
            // 
            this.gBoxComPortControl.Controls.Add(this.label5);
            this.gBoxComPortControl.Controls.Add(this.label4);
            this.gBoxComPortControl.Controls.Add(this.label3);
            this.gBoxComPortControl.Controls.Add(this.label2);
            this.gBoxComPortControl.Controls.Add(this.label1);
            this.gBoxComPortControl.Controls.Add(this.cBoxPARITYBITS);
            this.gBoxComPortControl.Controls.Add(this.cBoxSTOPBITS);
            this.gBoxComPortControl.Controls.Add(this.cBoxDATABITS);
            this.gBoxComPortControl.Controls.Add(this.cBoxBAUDRATE);
            this.gBoxComPortControl.Controls.Add(this.cBoxCOMPORT);
            this.gBoxComPortControl.Location = new System.Drawing.Point(12, 12);
            this.gBoxComPortControl.Name = "gBoxComPortControl";
            this.gBoxComPortControl.Size = new System.Drawing.Size(336, 168);
            this.gBoxComPortControl.TabIndex = 0;
            this.gBoxComPortControl.TabStop = false;
            this.gBoxComPortControl.Text = "Com Port Control";
            this.gBoxComPortControl.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "PARITY BITS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "STOP BITS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "DATA BITS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "BAUD RATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM PORT";
            // 
            // cBoxPARITYBITS
            // 
            this.cBoxPARITYBITS.FormattingEnabled = true;
            this.cBoxPARITYBITS.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxPARITYBITS.Location = new System.Drawing.Point(97, 140);
            this.cBoxPARITYBITS.Name = "cBoxPARITYBITS";
            this.cBoxPARITYBITS.Size = new System.Drawing.Size(121, 21);
            this.cBoxPARITYBITS.TabIndex = 4;
            this.cBoxPARITYBITS.Text = "None";
            // 
            // cBoxSTOPBITS
            // 
            this.cBoxSTOPBITS.FormattingEnabled = true;
            this.cBoxSTOPBITS.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxSTOPBITS.Location = new System.Drawing.Point(97, 113);
            this.cBoxSTOPBITS.Name = "cBoxSTOPBITS";
            this.cBoxSTOPBITS.Size = new System.Drawing.Size(121, 21);
            this.cBoxSTOPBITS.TabIndex = 3;
            this.cBoxSTOPBITS.Text = "One";
            // 
            // cBoxDATABITS
            // 
            this.cBoxDATABITS.FormattingEnabled = true;
            this.cBoxDATABITS.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cBoxDATABITS.Location = new System.Drawing.Point(97, 86);
            this.cBoxDATABITS.Name = "cBoxDATABITS";
            this.cBoxDATABITS.Size = new System.Drawing.Size(121, 21);
            this.cBoxDATABITS.TabIndex = 2;
            this.cBoxDATABITS.Text = "8";
            this.cBoxDATABITS.SelectedIndexChanged += new System.EventHandler(this.cBoxDATABITS_SelectedIndexChanged);
            // 
            // cBoxBAUDRATE
            // 
            this.cBoxBAUDRATE.FormattingEnabled = true;
            this.cBoxBAUDRATE.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.cBoxBAUDRATE.Location = new System.Drawing.Point(97, 59);
            this.cBoxBAUDRATE.Name = "cBoxBAUDRATE";
            this.cBoxBAUDRATE.Size = new System.Drawing.Size(121, 21);
            this.cBoxBAUDRATE.TabIndex = 1;
            this.cBoxBAUDRATE.Text = "115200";
            this.cBoxBAUDRATE.SelectedIndexChanged += new System.EventHandler(this.cBoxBAUDRATE_SelectedIndexChanged);
            // 
            // cBoxCOMPORT
            // 
            this.cBoxCOMPORT.FormattingEnabled = true;
            this.cBoxCOMPORT.Location = new System.Drawing.Point(97, 32);
            this.cBoxCOMPORT.Name = "cBoxCOMPORT";
            this.cBoxCOMPORT.Size = new System.Drawing.Size(121, 21);
            this.cBoxCOMPORT.TabIndex = 0;
            // 
            // gBoxOpenClose
            // 
            this.gBoxOpenClose.Controls.Add(this.progressBar1);
            this.gBoxOpenClose.Controls.Add(this.btnClose);
            this.gBoxOpenClose.Controls.Add(this.btnOpen);
            this.gBoxOpenClose.Location = new System.Drawing.Point(12, 186);
            this.gBoxOpenClose.Name = "gBoxOpenClose";
            this.gBoxOpenClose.Size = new System.Drawing.Size(175, 80);
            this.gBoxOpenClose.TabIndex = 1;
            this.gBoxOpenClose.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 48);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(147, 23);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(97, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(10, 19);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(60, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sendWaterValue);
            this.groupBox3.Controls.Add(this.cBoxWater);
            this.groupBox3.Location = new System.Drawing.Point(757, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 107);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Water Detection";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // sendWaterValue
            // 
            this.sendWaterValue.Location = new System.Drawing.Point(142, 24);
            this.sendWaterValue.Name = "sendWaterValue";
            this.sendWaterValue.Size = new System.Drawing.Size(75, 23);
            this.sendWaterValue.TabIndex = 2;
            this.sendWaterValue.Text = "send";
            this.sendWaterValue.UseVisualStyleBackColor = true;
            this.sendWaterValue.Click += new System.EventHandler(this.sendWaterValue_Click);
            // 
            // cBoxWater
            // 
            this.cBoxWater.FormattingEnabled = true;
            this.cBoxWater.Location = new System.Drawing.Point(0, 24);
            this.cBoxWater.Name = "cBoxWater";
            this.cBoxWater.Size = new System.Drawing.Size(121, 21);
            this.cBoxWater.TabIndex = 1;
            this.cBoxWater.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.sendLightValue);
            this.groupBox4.Controls.Add(this.cBoxLight);
            this.groupBox4.Location = new System.Drawing.Point(757, 158);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(273, 108);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Light Detection";
            // 
            // sendLightValue
            // 
            this.sendLightValue.Location = new System.Drawing.Point(142, 28);
            this.sendLightValue.Name = "sendLightValue";
            this.sendLightValue.Size = new System.Drawing.Size(75, 23);
            this.sendLightValue.TabIndex = 2;
            this.sendLightValue.Text = "send";
            this.sendLightValue.UseVisualStyleBackColor = true;
            this.sendLightValue.Click += new System.EventHandler(this.sendLightValue_Click);
            // 
            // cBoxLight
            // 
            this.cBoxLight.FormattingEnabled = true;
            this.cBoxLight.Location = new System.Drawing.Point(0, 28);
            this.cBoxLight.Name = "cBoxLight";
            this.cBoxLight.Size = new System.Drawing.Size(121, 21);
            this.cBoxLight.TabIndex = 1;
            this.cBoxLight.SelectedIndexChanged += new System.EventHandler(this.cBoxLight_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.sendMicValue);
            this.groupBox5.Controls.Add(this.cBoxMic);
            this.groupBox5.Location = new System.Drawing.Point(435, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(273, 107);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Microphone Detection";
            // 
            // sendMicValue
            // 
            this.sendMicValue.Location = new System.Drawing.Point(150, 29);
            this.sendMicValue.Name = "sendMicValue";
            this.sendMicValue.Size = new System.Drawing.Size(75, 23);
            this.sendMicValue.TabIndex = 1;
            this.sendMicValue.Text = "send";
            this.sendMicValue.UseVisualStyleBackColor = true;
            this.sendMicValue.Click += new System.EventHandler(this.sendMicValue_Click);
            // 
            // cBoxMic
            // 
            this.cBoxMic.FormattingEnabled = true;
            this.cBoxMic.Location = new System.Drawing.Point(0, 29);
            this.cBoxMic.Name = "cBoxMic";
            this.cBoxMic.Size = new System.Drawing.Size(121, 21);
            this.cBoxMic.TabIndex = 0;
            this.cBoxMic.SelectedIndexChanged += new System.EventHandler(this.cBoxMic_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.sendGasValue);
            this.groupBox6.Controls.Add(this.cBoxGas);
            this.groupBox6.Location = new System.Drawing.Point(435, 158);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(273, 108);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Gas Detection";
            // 
            // sendGasValue
            // 
            this.sendGasValue.Location = new System.Drawing.Point(150, 26);
            this.sendGasValue.Name = "sendGasValue";
            this.sendGasValue.Size = new System.Drawing.Size(75, 23);
            this.sendGasValue.TabIndex = 2;
            this.sendGasValue.Text = "send";
            this.sendGasValue.UseVisualStyleBackColor = true;
            this.sendGasValue.Click += new System.EventHandler(this.sendGasValue_Click);
            // 
            // cBoxGas
            // 
            this.cBoxGas.FormattingEnabled = true;
            this.cBoxGas.Location = new System.Drawing.Point(0, 28);
            this.cBoxGas.Name = "cBoxGas";
            this.cBoxGas.Size = new System.Drawing.Size(121, 21);
            this.cBoxGas.TabIndex = 1;
            this.cBoxGas.SelectedIndexChanged += new System.EventHandler(this.cBoxGas_SelectedIndexChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // waterStatusLabel
            // 
            this.waterStatusLabel.AutoSize = true;
            this.waterStatusLabel.Location = new System.Drawing.Point(19, 357);
            this.waterStatusLabel.Name = "waterStatusLabel";
            this.waterStatusLabel.Size = new System.Drawing.Size(89, 13);
            this.waterStatusLabel.TabIndex = 6;
            this.waterStatusLabel.Text = "waterStatusLabel";
            this.waterStatusLabel.Click += new System.EventHandler(this.waterStatus_Click);
            // 
            // soundStatusLabel
            // 
            this.soundStatusLabel.AutoSize = true;
            this.soundStatusLabel.Location = new System.Drawing.Point(278, 357);
            this.soundStatusLabel.Name = "soundStatusLabel";
            this.soundStatusLabel.Size = new System.Drawing.Size(92, 13);
            this.soundStatusLabel.TabIndex = 7;
            this.soundStatusLabel.Text = "soundStatusLabel";
            this.soundStatusLabel.Click += new System.EventHandler(this.micStatus_Click);
            // 
            // gasStatusLabel
            // 
            this.gasStatusLabel.AutoSize = true;
            this.gasStatusLabel.Location = new System.Drawing.Point(791, 357);
            this.gasStatusLabel.Name = "gasStatusLabel";
            this.gasStatusLabel.Size = new System.Drawing.Size(80, 13);
            this.gasStatusLabel.TabIndex = 9;
            this.gasStatusLabel.Text = "gasStatusLabel";
            this.gasStatusLabel.Click += new System.EventHandler(this.gasStatus_Click);
            // 
            // lightStatusLabel
            // 
            this.lightStatusLabel.AutoSize = true;
            this.lightStatusLabel.Location = new System.Drawing.Point(517, 357);
            this.lightStatusLabel.Name = "lightStatusLabel";
            this.lightStatusLabel.Size = new System.Drawing.Size(82, 13);
            this.lightStatusLabel.TabIndex = 10;
            this.lightStatusLabel.Text = "lightStatusLabel";
            this.lightStatusLabel.Click += new System.EventHandler(this.lightStatus_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 446);
            this.Controls.Add(this.lightStatusLabel);
            this.Controls.Add(this.gasStatusLabel);
            this.Controls.Add(this.soundStatusLabel);
            this.Controls.Add(this.waterStatusLabel);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gBoxOpenClose);
            this.Controls.Add(this.gBoxComPortControl);
            this.Name = "Form1";
            this.Text = "C# Manhole Detection System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBoxComPortControl.ResumeLayout(false);
            this.gBoxComPortControl.PerformLayout();
            this.gBoxOpenClose.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxComPortControl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxPARITYBITS;
        private System.Windows.Forms.ComboBox cBoxSTOPBITS;
        private System.Windows.Forms.ComboBox cBoxDATABITS;
        private System.Windows.Forms.ComboBox cBoxBAUDRATE;
        private System.Windows.Forms.ComboBox cBoxCOMPORT;
        private System.Windows.Forms.GroupBox gBoxOpenClose;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cBoxWater;
        private System.Windows.Forms.ComboBox cBoxLight;
        private System.Windows.Forms.ComboBox cBoxMic;
        private System.Windows.Forms.ComboBox cBoxGas;
        private System.Windows.Forms.Button sendWaterValue;
        private System.Windows.Forms.Button sendLightValue;
        private System.Windows.Forms.Button sendMicValue;
        private System.Windows.Forms.Button sendGasValue;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label waterStatusLabel;
        private System.Windows.Forms.Label soundStatusLabel;
        private System.Windows.Forms.Label gasStatusLabel;
        private System.Windows.Forms.Label lightStatusLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

