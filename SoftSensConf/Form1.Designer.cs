namespace SoftSensConf
{
    partial class SoftSensConf
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SerialConf = new System.Windows.Forms.TabPage();
            this.SerialLightStatus = new System.Windows.Forms.TextBox();
            this.SerialStatusTextBox = new System.Windows.Forms.TextBox();
            this.DisconnectButt = new System.Windows.Forms.Button();
            this.ConnectButt = new System.Windows.Forms.Button();
            this.BitBox = new System.Windows.Forms.ComboBox();
            this.ComBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.InstrumentControl = new System.Windows.Forms.TabPage();
            this.NewAlarmLow = new System.Windows.Forms.TextBox();
            this.NewAlarmUP = new System.Windows.Forms.TextBox();
            this.NewLower = new System.Windows.Forms.TextBox();
            this.NewUpper = new System.Windows.Forms.TextBox();
            this.NewSerial = new System.Windows.Forms.TextBox();
            this.SendInstCont = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SerialNum = new System.Windows.Forms.Label();
            this.AlarmLow = new System.Windows.Forms.Label();
            this.UpperVal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AlarmUp = new System.Windows.Forms.Label();
            this.LowVal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SaveConf = new System.Windows.Forms.Button();
            this.LightInstCont = new System.Windows.Forms.TextBox();
            this.StatusInstCon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ConfFromFile = new System.Windows.Forms.Button();
            this.CurrentConf = new System.Windows.Forms.Button();
            this.CurrentValues = new System.Windows.Forms.TabPage();
            this.LightStatCV = new System.Windows.Forms.TextBox();
            this.ConStatCV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.StatusTimer = new System.Windows.Forms.Timer(this.components);
            this.OpenConfigDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveConfigDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.SerialConf.SuspendLayout();
            this.InstrumentControl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.CurrentValues.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SerialConf);
            this.tabControl1.Controls.Add(this.InstrumentControl);
            this.tabControl1.Controls.Add(this.CurrentValues);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(839, 556);
            this.tabControl1.TabIndex = 0;
            // 
            // SerialConf
            // 
            this.SerialConf.Controls.Add(this.SerialLightStatus);
            this.SerialConf.Controls.Add(this.SerialStatusTextBox);
            this.SerialConf.Controls.Add(this.DisconnectButt);
            this.SerialConf.Controls.Add(this.ConnectButt);
            this.SerialConf.Controls.Add(this.BitBox);
            this.SerialConf.Controls.Add(this.ComBox);
            this.SerialConf.Controls.Add(this.label2);
            this.SerialConf.Controls.Add(this.label1);
            this.SerialConf.Location = new System.Drawing.Point(4, 22);
            this.SerialConf.Name = "SerialConf";
            this.SerialConf.Padding = new System.Windows.Forms.Padding(3);
            this.SerialConf.Size = new System.Drawing.Size(831, 530);
            this.SerialConf.TabIndex = 0;
            this.SerialConf.Text = "Serial Port Configuration";
            this.SerialConf.UseVisualStyleBackColor = true;
            // 
            // SerialLightStatus
            // 
            this.SerialLightStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialLightStatus.Location = new System.Drawing.Point(500, 31);
            this.SerialLightStatus.Name = "SerialLightStatus";
            this.SerialLightStatus.Size = new System.Drawing.Size(21, 26);
            this.SerialLightStatus.TabIndex = 7;
            // 
            // SerialStatusTextBox
            // 
            this.SerialStatusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialStatusTextBox.Location = new System.Drawing.Point(374, 31);
            this.SerialStatusTextBox.Name = "SerialStatusTextBox";
            this.SerialStatusTextBox.Size = new System.Drawing.Size(110, 26);
            this.SerialStatusTextBox.TabIndex = 6;
            // 
            // DisconnectButt
            // 
            this.DisconnectButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisconnectButt.Location = new System.Drawing.Point(259, 71);
            this.DisconnectButt.Name = "DisconnectButt";
            this.DisconnectButt.Size = new System.Drawing.Size(97, 28);
            this.DisconnectButt.TabIndex = 5;
            this.DisconnectButt.Text = "Disconnect";
            this.DisconnectButt.UseVisualStyleBackColor = true;
            this.DisconnectButt.Click += new System.EventHandler(this.DisconnectButt_Click);
            // 
            // ConnectButt
            // 
            this.ConnectButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectButt.Location = new System.Drawing.Point(259, 32);
            this.ConnectButt.Name = "ConnectButt";
            this.ConnectButt.Size = new System.Drawing.Size(97, 26);
            this.ConnectButt.TabIndex = 4;
            this.ConnectButt.Text = "Connect";
            this.ConnectButt.UseVisualStyleBackColor = true;
            this.ConnectButt.Click += new System.EventHandler(this.ConnectButt_Click);
            // 
            // BitBox
            // 
            this.BitBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BitBox.FormattingEnabled = true;
            this.BitBox.Location = new System.Drawing.Point(86, 68);
            this.BitBox.Name = "BitBox";
            this.BitBox.Size = new System.Drawing.Size(121, 28);
            this.BitBox.TabIndex = 3;
            // 
            // ComBox
            // 
            this.ComBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBox.FormattingEnabled = true;
            this.ComBox.Location = new System.Drawing.Point(86, 29);
            this.ComBox.Name = "ComBox";
            this.ComBox.Size = new System.Drawing.Size(121, 28);
            this.ComBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "BitRate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ComPort";
            // 
            // InstrumentControl
            // 
            this.InstrumentControl.Controls.Add(this.NewAlarmLow);
            this.InstrumentControl.Controls.Add(this.NewAlarmUP);
            this.InstrumentControl.Controls.Add(this.NewLower);
            this.InstrumentControl.Controls.Add(this.NewUpper);
            this.InstrumentControl.Controls.Add(this.NewSerial);
            this.InstrumentControl.Controls.Add(this.SendInstCont);
            this.InstrumentControl.Controls.Add(this.label16);
            this.InstrumentControl.Controls.Add(this.label15);
            this.InstrumentControl.Controls.Add(this.label14);
            this.InstrumentControl.Controls.Add(this.label13);
            this.InstrumentControl.Controls.Add(this.label12);
            this.InstrumentControl.Controls.Add(this.label11);
            this.InstrumentControl.Controls.Add(this.groupBox1);
            this.InstrumentControl.Controls.Add(this.SaveConf);
            this.InstrumentControl.Controls.Add(this.LightInstCont);
            this.InstrumentControl.Controls.Add(this.StatusInstCon);
            this.InstrumentControl.Controls.Add(this.label3);
            this.InstrumentControl.Controls.Add(this.ConfFromFile);
            this.InstrumentControl.Controls.Add(this.CurrentConf);
            this.InstrumentControl.Location = new System.Drawing.Point(4, 22);
            this.InstrumentControl.Name = "InstrumentControl";
            this.InstrumentControl.Padding = new System.Windows.Forms.Padding(3);
            this.InstrumentControl.Size = new System.Drawing.Size(831, 530);
            this.InstrumentControl.TabIndex = 1;
            this.InstrumentControl.Text = "Instrument Control";
            this.InstrumentControl.UseVisualStyleBackColor = true;
            // 
            // NewAlarmLow
            // 
            this.NewAlarmLow.Location = new System.Drawing.Point(369, 215);
            this.NewAlarmLow.Name = "NewAlarmLow";
            this.NewAlarmLow.Size = new System.Drawing.Size(100, 20);
            this.NewAlarmLow.TabIndex = 34;
            // 
            // NewAlarmUP
            // 
            this.NewAlarmUP.Location = new System.Drawing.Point(369, 175);
            this.NewAlarmUP.Name = "NewAlarmUP";
            this.NewAlarmUP.Size = new System.Drawing.Size(100, 20);
            this.NewAlarmUP.TabIndex = 33;
            // 
            // NewLower
            // 
            this.NewLower.Location = new System.Drawing.Point(369, 135);
            this.NewLower.Name = "NewLower";
            this.NewLower.Size = new System.Drawing.Size(100, 20);
            this.NewLower.TabIndex = 32;
            // 
            // NewUpper
            // 
            this.NewUpper.Location = new System.Drawing.Point(369, 95);
            this.NewUpper.Name = "NewUpper";
            this.NewUpper.Size = new System.Drawing.Size(100, 20);
            this.NewUpper.TabIndex = 31;
            // 
            // NewSerial
            // 
            this.NewSerial.Location = new System.Drawing.Point(369, 55);
            this.NewSerial.Name = "NewSerial";
            this.NewSerial.Size = new System.Drawing.Size(100, 20);
            this.NewSerial.TabIndex = 30;
            // 
            // SendInstCont
            // 
            this.SendInstCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendInstCont.Location = new System.Drawing.Point(369, 246);
            this.SendInstCont.Name = "SendInstCont";
            this.SendInstCont.Size = new System.Drawing.Size(86, 24);
            this.SendInstCont.TabIndex = 29;
            this.SendInstCont.Text = "Send";
            this.SendInstCont.UseVisualStyleBackColor = true;
            this.SendInstCont.Click += new System.EventHandler(this.SendInstCont_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(238, 215);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 20);
            this.label16.TabIndex = 28;
            this.label16.Text = "Alarm Lower:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(238, 175);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 20);
            this.label15.TabIndex = 27;
            this.label15.Text = "Alarm Upper:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(238, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Lower Value:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(238, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Upper Value:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(238, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Serial Number:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(238, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "New Config:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.SerialNum);
            this.groupBox1.Controls.Add(this.AlarmLow);
            this.groupBox1.Controls.Add(this.UpperVal);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.AlarmUp);
            this.groupBox1.Controls.Add(this.LowVal);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(559, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 218);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Current Config:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Serial Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Upper Value:";
            // 
            // SerialNum
            // 
            this.SerialNum.AutoSize = true;
            this.SerialNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerialNum.Location = new System.Drawing.Point(160, 35);
            this.SerialNum.Name = "SerialNum";
            this.SerialNum.Size = new System.Drawing.Size(14, 20);
            this.SerialNum.TabIndex = 12;
            this.SerialNum.Text = "-";
            // 
            // AlarmLow
            // 
            this.AlarmLow.AutoSize = true;
            this.AlarmLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmLow.Location = new System.Drawing.Point(160, 175);
            this.AlarmLow.Name = "AlarmLow";
            this.AlarmLow.Size = new System.Drawing.Size(14, 20);
            this.AlarmLow.TabIndex = 21;
            this.AlarmLow.Text = "-";
            // 
            // UpperVal
            // 
            this.UpperVal.AutoSize = true;
            this.UpperVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpperVal.Location = new System.Drawing.Point(160, 65);
            this.UpperVal.Name = "UpperVal";
            this.UpperVal.Size = new System.Drawing.Size(14, 20);
            this.UpperVal.TabIndex = 14;
            this.UpperVal.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Alarm Lower:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Lower Value:";
            // 
            // AlarmUp
            // 
            this.AlarmUp.AutoSize = true;
            this.AlarmUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlarmUp.Location = new System.Drawing.Point(160, 135);
            this.AlarmUp.Name = "AlarmUp";
            this.AlarmUp.Size = new System.Drawing.Size(14, 20);
            this.AlarmUp.TabIndex = 19;
            this.AlarmUp.Text = "-";
            // 
            // LowVal
            // 
            this.LowVal.AutoSize = true;
            this.LowVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowVal.Location = new System.Drawing.Point(160, 95);
            this.LowVal.Name = "LowVal";
            this.LowVal.Size = new System.Drawing.Size(14, 20);
            this.LowVal.TabIndex = 16;
            this.LowVal.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Alarm Upper:";
            // 
            // SaveConf
            // 
            this.SaveConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveConf.Location = new System.Drawing.Point(16, 135);
            this.SaveConf.Name = "SaveConf";
            this.SaveConf.Size = new System.Drawing.Size(176, 31);
            this.SaveConf.TabIndex = 9;
            this.SaveConf.Text = "Save Config to File";
            this.SaveConf.UseVisualStyleBackColor = true;
            // 
            // LightInstCont
            // 
            this.LightInstCont.Location = new System.Drawing.Point(795, 502);
            this.LightInstCont.Name = "LightInstCont";
            this.LightInstCont.Size = new System.Drawing.Size(21, 20);
            this.LightInstCont.TabIndex = 8;
            // 
            // StatusInstCon
            // 
            this.StatusInstCon.Location = new System.Drawing.Point(693, 502);
            this.StatusInstCon.Name = "StatusInstCon";
            this.StatusInstCon.Size = new System.Drawing.Size(95, 20);
            this.StatusInstCon.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(590, 505);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Connection Status:";
            // 
            // ConfFromFile
            // 
            this.ConfFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfFromFile.Location = new System.Drawing.Point(16, 85);
            this.ConfFromFile.Name = "ConfFromFile";
            this.ConfFromFile.Size = new System.Drawing.Size(176, 31);
            this.ConfFromFile.TabIndex = 1;
            this.ConfFromFile.Text = "Load Config From File";
            this.ConfFromFile.UseVisualStyleBackColor = true;
            this.ConfFromFile.Click += new System.EventHandler(this.ConfFromFile_Click);
            // 
            // CurrentConf
            // 
            this.CurrentConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentConf.Location = new System.Drawing.Point(16, 35);
            this.CurrentConf.Name = "CurrentConf";
            this.CurrentConf.Size = new System.Drawing.Size(176, 31);
            this.CurrentConf.TabIndex = 0;
            this.CurrentConf.Text = "Load Current Config";
            this.CurrentConf.UseVisualStyleBackColor = true;
            this.CurrentConf.Click += new System.EventHandler(this.CurrentConf_Click);
            // 
            // CurrentValues
            // 
            this.CurrentValues.Controls.Add(this.LightStatCV);
            this.CurrentValues.Controls.Add(this.ConStatCV);
            this.CurrentValues.Controls.Add(this.label4);
            this.CurrentValues.Location = new System.Drawing.Point(4, 22);
            this.CurrentValues.Name = "CurrentValues";
            this.CurrentValues.Padding = new System.Windows.Forms.Padding(3);
            this.CurrentValues.Size = new System.Drawing.Size(831, 530);
            this.CurrentValues.TabIndex = 2;
            this.CurrentValues.Text = "CurrentValues";
            this.CurrentValues.UseVisualStyleBackColor = true;
            // 
            // LightStatCV
            // 
            this.LightStatCV.Location = new System.Drawing.Point(795, 502);
            this.LightStatCV.Name = "LightStatCV";
            this.LightStatCV.Size = new System.Drawing.Size(21, 20);
            this.LightStatCV.TabIndex = 2;
            // 
            // ConStatCV
            // 
            this.ConStatCV.Location = new System.Drawing.Point(693, 502);
            this.ConStatCV.Name = "ConStatCV";
            this.ConStatCV.Size = new System.Drawing.Size(95, 20);
            this.ConStatCV.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(590, 505);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Connection Status:";
            // 
            // StatusTimer
            // 
            this.StatusTimer.Tick += new System.EventHandler(this.StatusTimer_Tick);
            // 
            // OpenConfigDialog
            // 
            this.OpenConfigDialog.FileName = "OpenConfigDialog";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SoftSensConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 571);
            this.Controls.Add(this.tabControl1);
            this.Name = "SoftSensConf";
            this.Text = "SoftSensConf ver. 1.0";
            this.tabControl1.ResumeLayout(false);
            this.SerialConf.ResumeLayout(false);
            this.SerialConf.PerformLayout();
            this.InstrumentControl.ResumeLayout(false);
            this.InstrumentControl.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.CurrentValues.ResumeLayout(false);
            this.CurrentValues.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SerialConf;
        private System.Windows.Forms.TabPage InstrumentControl;
        private System.Windows.Forms.TabPage CurrentValues;
        private System.Windows.Forms.TextBox SerialLightStatus;
        private System.Windows.Forms.TextBox SerialStatusTextBox;
        private System.Windows.Forms.Button DisconnectButt;
        private System.Windows.Forms.Button ConnectButt;
        private System.Windows.Forms.ComboBox BitBox;
        private System.Windows.Forms.ComboBox ComBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button ConfFromFile;
        private System.Windows.Forms.Button CurrentConf;
        private System.Windows.Forms.TextBox LightInstCont;
        private System.Windows.Forms.TextBox StatusInstCon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveConf;
        private System.Windows.Forms.Timer StatusTimer;
        private System.Windows.Forms.TextBox LightStatCV;
        private System.Windows.Forms.TextBox ConStatCV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label AlarmLow;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label AlarmUp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LowVal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label UpperVal;
        private System.Windows.Forms.Label SerialNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NewAlarmLow;
        private System.Windows.Forms.TextBox NewAlarmUP;
        private System.Windows.Forms.TextBox NewLower;
        private System.Windows.Forms.TextBox NewUpper;
        private System.Windows.Forms.TextBox NewSerial;
        private System.Windows.Forms.Button SendInstCont;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.OpenFileDialog OpenConfigDialog;
        private System.Windows.Forms.SaveFileDialog SaveConfigDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

