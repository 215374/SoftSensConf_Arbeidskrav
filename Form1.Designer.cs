namespace SoftSensConf_Arbeidskrav
{
    partial class Form1
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.comboBoxBit = new System.Windows.Forms.ComboBox();
            this.D_Connect_Button = new System.Windows.Forms.Button();
            this.Connect_Button = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.groupParameter = new System.Windows.Forms.GroupBox();
            this.labelAlarmUpper = new System.Windows.Forms.Label();
            this.labelAlarmLower = new System.Windows.Forms.Label();
            this.labelLowerValue = new System.Windows.Forms.Label();
            this.labelUpperValue = new System.Windows.Forms.Label();
            this.labelAdress = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAlarmLower = new System.Windows.Forms.TextBox();
            this.textBoxAlarmUpper = new System.Windows.Forms.TextBox();
            this.textBoxLowerValue = new System.Windows.Forms.TextBox();
            this.textBoxUpperValue = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.buttonLoadFromFile = new System.Windows.Forms.Button();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.buttonReadCurrentValue = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBoxSerialResult = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupParameter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1259, 507);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxSerialResult);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBoxPort);
            this.tabPage1.Controls.Add(this.comboBoxBit);
            this.tabPage1.Controls.Add(this.D_Connect_Button);
            this.tabPage1.Controls.Add(this.Connect_Button);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1251, 478);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Serial Port Configuration";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "SoftSenseConf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bit Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Port_choice";
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(150, 78);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPort.TabIndex = 3;
            // 
            // comboBoxBit
            // 
            this.comboBoxBit.FormattingEnabled = true;
            this.comboBoxBit.Location = new System.Drawing.Point(150, 121);
            this.comboBoxBit.Name = "comboBoxBit";
            this.comboBoxBit.Size = new System.Drawing.Size(121, 24);
            this.comboBoxBit.TabIndex = 2;
            // 
            // D_Connect_Button
            // 
            this.D_Connect_Button.Location = new System.Drawing.Point(46, 230);
            this.D_Connect_Button.Name = "D_Connect_Button";
            this.D_Connect_Button.Size = new System.Drawing.Size(107, 36);
            this.D_Connect_Button.TabIndex = 1;
            this.D_Connect_Button.Text = "Disconnect";
            this.D_Connect_Button.UseVisualStyleBackColor = true;
            // 
            // Connect_Button
            // 
            this.Connect_Button.Location = new System.Drawing.Point(46, 185);
            this.Connect_Button.Name = "Connect_Button";
            this.Connect_Button.Size = new System.Drawing.Size(107, 39);
            this.Connect_Button.TabIndex = 0;
            this.Connect_Button.Text = "Connect";
            this.Connect_Button.UseVisualStyleBackColor = true;
            this.Connect_Button.Click += new System.EventHandler(this.Connect_Button_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.groupParameter);
            this.tabPage2.Controls.Add(this.buttonUpdate);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBoxAlarmLower);
            this.tabPage2.Controls.Add(this.textBoxAlarmUpper);
            this.tabPage2.Controls.Add(this.textBoxLowerValue);
            this.tabPage2.Controls.Add(this.textBoxUpperValue);
            this.tabPage2.Controls.Add(this.textBoxAdress);
            this.tabPage2.Controls.Add(this.buttonLoadFromFile);
            this.tabPage2.Controls.Add(this.buttonSaveToFile);
            this.tabPage2.Controls.Add(this.buttonReadCurrentValue);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1251, 478);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Instrument Configuration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(265, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "Lower Value:";
            // 
            // groupParameter
            // 
            this.groupParameter.Controls.Add(this.labelAlarmUpper);
            this.groupParameter.Controls.Add(this.labelAlarmLower);
            this.groupParameter.Controls.Add(this.labelLowerValue);
            this.groupParameter.Controls.Add(this.labelUpperValue);
            this.groupParameter.Controls.Add(this.labelAdress);
            this.groupParameter.Controls.Add(this.label17);
            this.groupParameter.Controls.Add(this.label11);
            this.groupParameter.Controls.Add(this.label12);
            this.groupParameter.Controls.Add(this.label13);
            this.groupParameter.Controls.Add(this.label14);
            this.groupParameter.Controls.Add(this.label15);
            this.groupParameter.Controls.Add(this.label16);
            this.groupParameter.Location = new System.Drawing.Point(632, 21);
            this.groupParameter.Name = "groupParameter";
            this.groupParameter.Size = new System.Drawing.Size(429, 438);
            this.groupParameter.TabIndex = 15;
            this.groupParameter.TabStop = false;
            // 
            // labelAlarmUpper
            // 
            this.labelAlarmUpper.AutoSize = true;
            this.labelAlarmUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlarmUpper.Location = new System.Drawing.Point(286, 315);
            this.labelAlarmUpper.Name = "labelAlarmUpper";
            this.labelAlarmUpper.Size = new System.Drawing.Size(16, 22);
            this.labelAlarmUpper.TabIndex = 27;
            this.labelAlarmUpper.Text = "-";
            // 
            // labelAlarmLower
            // 
            this.labelAlarmLower.AutoSize = true;
            this.labelAlarmLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlarmLower.Location = new System.Drawing.Point(286, 249);
            this.labelAlarmLower.Name = "labelAlarmLower";
            this.labelAlarmLower.Size = new System.Drawing.Size(16, 22);
            this.labelAlarmLower.TabIndex = 26;
            this.labelAlarmLower.Text = "-";
            // 
            // labelLowerValue
            // 
            this.labelLowerValue.AutoSize = true;
            this.labelLowerValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLowerValue.Location = new System.Drawing.Point(286, 200);
            this.labelLowerValue.Name = "labelLowerValue";
            this.labelLowerValue.Size = new System.Drawing.Size(16, 22);
            this.labelLowerValue.TabIndex = 25;
            this.labelLowerValue.Text = "-";
            // 
            // labelUpperValue
            // 
            this.labelUpperValue.AutoSize = true;
            this.labelUpperValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpperValue.Location = new System.Drawing.Point(286, 127);
            this.labelUpperValue.Name = "labelUpperValue";
            this.labelUpperValue.Size = new System.Drawing.Size(16, 22);
            this.labelUpperValue.TabIndex = 24;
            this.labelUpperValue.Text = "-";
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdress.Location = new System.Drawing.Point(286, 60);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(16, 22);
            this.labelAdress.TabIndex = 17;
            this.labelAdress.Text = "-";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(194, 25);
            this.label17.TabIndex = 23;
            this.label17.Text = "Current_Parameters:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 25);
            this.label11.TabIndex = 22;
            this.label11.Text = "Lower Value:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 317);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 25);
            this.label12.TabIndex = 21;
            this.label12.Text = "Alarm Upper:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 249);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 25);
            this.label13.TabIndex = 20;
            this.label13.Text = "Alarm Lower:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(69, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 25);
            this.label14.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 118);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 25);
            this.label15.TabIndex = 18;
            this.label15.Text = "Upper Value:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 25);
            this.label16.TabIndex = 17;
            this.label16.Text = "Adress:";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(398, 402);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(138, 35);
            this.buttonUpdate.TabIndex = 14;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(393, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "New_Parameters:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(271, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Alarm Upper:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(271, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Alarm Lower:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(328, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(265, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Upper Value:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(312, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adress:";
            // 
            // textBoxAlarmLower
            // 
            this.textBoxAlarmLower.Location = new System.Drawing.Point(398, 274);
            this.textBoxAlarmLower.Multiline = true;
            this.textBoxAlarmLower.Name = "textBoxAlarmLower";
            this.textBoxAlarmLower.Size = new System.Drawing.Size(138, 37);
            this.textBoxAlarmLower.TabIndex = 7;
            // 
            // textBoxAlarmUpper
            // 
            this.textBoxAlarmUpper.Location = new System.Drawing.Point(398, 338);
            this.textBoxAlarmUpper.Multiline = true;
            this.textBoxAlarmUpper.Name = "textBoxAlarmUpper";
            this.textBoxAlarmUpper.Size = new System.Drawing.Size(138, 37);
            this.textBoxAlarmUpper.TabIndex = 6;
            // 
            // textBoxLowerValue
            // 
            this.textBoxLowerValue.Location = new System.Drawing.Point(398, 209);
            this.textBoxLowerValue.Multiline = true;
            this.textBoxLowerValue.Name = "textBoxLowerValue";
            this.textBoxLowerValue.Size = new System.Drawing.Size(138, 37);
            this.textBoxLowerValue.TabIndex = 5;
            // 
            // textBoxUpperValue
            // 
            this.textBoxUpperValue.Location = new System.Drawing.Point(398, 139);
            this.textBoxUpperValue.Multiline = true;
            this.textBoxUpperValue.Name = "textBoxUpperValue";
            this.textBoxUpperValue.Size = new System.Drawing.Size(138, 37);
            this.textBoxUpperValue.TabIndex = 4;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(398, 75);
            this.textBoxAdress.Multiline = true;
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(138, 37);
            this.textBoxAdress.TabIndex = 3;
            // 
            // buttonLoadFromFile
            // 
            this.buttonLoadFromFile.Location = new System.Drawing.Point(8, 221);
            this.buttonLoadFromFile.Name = "buttonLoadFromFile";
            this.buttonLoadFromFile.Size = new System.Drawing.Size(200, 37);
            this.buttonLoadFromFile.TabIndex = 2;
            this.buttonLoadFromFile.Text = "Load From File";
            this.buttonLoadFromFile.UseVisualStyleBackColor = true;
            this.buttonLoadFromFile.Click += new System.EventHandler(this.buttonLoadFromFile_Click);
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Location = new System.Drawing.Point(8, 148);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(200, 37);
            this.buttonSaveToFile.TabIndex = 1;
            this.buttonSaveToFile.Text = "Save to file";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // buttonReadCurrentValue
            // 
            this.buttonReadCurrentValue.Location = new System.Drawing.Point(8, 75);
            this.buttonReadCurrentValue.Name = "buttonReadCurrentValue";
            this.buttonReadCurrentValue.Size = new System.Drawing.Size(200, 37);
            this.buttonReadCurrentValue.TabIndex = 0;
            this.buttonReadCurrentValue.Text = "Read Current Value";
            this.buttonReadCurrentValue.UseVisualStyleBackColor = true;
            this.buttonReadCurrentValue.Click += new System.EventHandler(this.buttonReadCurrentValue_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1251, 478);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Online Values";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxSerialResult
            // 
            this.textBoxSerialResult.Location = new System.Drawing.Point(480, 97);
            this.textBoxSerialResult.Name = "textBoxSerialResult";
            this.textBoxSerialResult.Size = new System.Drawing.Size(100, 22);
            this.textBoxSerialResult.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 519);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupParameter.ResumeLayout(false);
            this.groupParameter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.ComboBox comboBoxBit;
        private System.Windows.Forms.Button D_Connect_Button;
        private System.Windows.Forms.Button Connect_Button;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupParameter;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAlarmLower;
        private System.Windows.Forms.TextBox textBoxAlarmUpper;
        private System.Windows.Forms.TextBox textBoxLowerValue;
        private System.Windows.Forms.TextBox textBoxUpperValue;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.Button buttonLoadFromFile;
        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.Button buttonReadCurrentValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelAlarmUpper;
        private System.Windows.Forms.Label labelAlarmLower;
        private System.Windows.Forms.Label labelLowerValue;
        private System.Windows.Forms.Label labelUpperValue;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBoxSerialResult;
    }
}

