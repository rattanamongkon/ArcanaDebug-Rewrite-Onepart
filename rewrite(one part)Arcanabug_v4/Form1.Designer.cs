﻿namespace rewrite_one_part_Arcanabug_v4
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
            this.pnlPort = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboPort = new System.Windows.Forms.ComboBox();
            this.pnlKey = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.pnlEncrypt = new System.Windows.Forms.Panel();
            this.pnlResponse = new System.Windows.Forms.Panel();
            this.pnlSetRan = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbResponse = new System.Windows.Forms.TextBox();
            this.tbCommand = new System.Windows.Forms.TextBox();
            this.tbData = new System.Windows.Forms.TextBox();
            this.tbTrimes = new System.Windows.Forms.TextBox();
            this.btLoadCSV = new System.Windows.Forms.Button();
            this.chkRan10 = new System.Windows.Forms.CheckBox();
            this.chkRan9 = new System.Windows.Forms.CheckBox();
            this.chkRan8 = new System.Windows.Forms.CheckBox();
            this.chkRan7 = new System.Windows.Forms.CheckBox();
            this.chkRan6 = new System.Windows.Forms.CheckBox();
            this.chkRan5 = new System.Windows.Forms.CheckBox();
            this.chkRan4 = new System.Windows.Forms.CheckBox();
            this.chkRan3 = new System.Windows.Forms.CheckBox();
            this.chkRan2 = new System.Windows.Forms.CheckBox();
            this.chkRan1 = new System.Windows.Forms.CheckBox();
            this.tbRan10 = new System.Windows.Forms.TextBox();
            this.tbRan9 = new System.Windows.Forms.TextBox();
            this.tbRan8 = new System.Windows.Forms.TextBox();
            this.tbRan7 = new System.Windows.Forms.TextBox();
            this.tbRan6 = new System.Windows.Forms.TextBox();
            this.tbRan5 = new System.Windows.Forms.TextBox();
            this.tbRan4 = new System.Windows.Forms.TextBox();
            this.tbRan3 = new System.Windows.Forms.TextBox();
            this.tbRan2 = new System.Windows.Forms.TextBox();
            this.tbRan1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.chkRandom = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btPnlResponse = new System.Windows.Forms.PictureBox();
            this.btPnlKey = new System.Windows.Forms.PictureBox();
            this.pnlPort.SuspendLayout();
            this.pnlKey.SuspendLayout();
            this.pnlEncrypt.SuspendLayout();
            this.pnlResponse.SuspendLayout();
            this.pnlSetRan.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btPnlResponse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btPnlKey)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPort
            // 
            this.pnlPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPort.Controls.Add(this.comboPort);
            this.pnlPort.Controls.Add(this.label1);
            this.pnlPort.Location = new System.Drawing.Point(12, 12);
            this.pnlPort.Name = "pnlPort";
            this.pnlPort.Size = new System.Drawing.Size(144, 75);
            this.pnlPort.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // comboPort
            // 
            this.comboPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPort.FormattingEnabled = true;
            this.comboPort.Location = new System.Drawing.Point(29, 41);
            this.comboPort.Name = "comboPort";
            this.comboPort.Size = new System.Drawing.Size(88, 21);
            this.comboPort.TabIndex = 1;
            this.comboPort.SelectedIndexChanged += new System.EventHandler(this.comboPort_SelectedIndexChanged);
            // 
            // pnlKey
            // 
            this.pnlKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKey.Controls.Add(this.btPnlKey);
            this.pnlKey.Controls.Add(this.tbKey);
            this.pnlKey.Controls.Add(this.label2);
            this.pnlKey.Location = new System.Drawing.Point(162, 12);
            this.pnlKey.Name = "pnlKey";
            this.pnlKey.Size = new System.Drawing.Size(455, 75);
            this.pnlKey.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "ENTER KEY";
            // 
            // tbKey
            // 
            this.tbKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKey.Location = new System.Drawing.Point(3, 42);
            this.tbKey.MaxLength = 20;
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(403, 30);
            this.tbKey.TabIndex = 1;
            // 
            // pnlEncrypt
            // 
            this.pnlEncrypt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEncrypt.Controls.Add(this.label4);
            this.pnlEncrypt.Enabled = false;
            this.pnlEncrypt.Location = new System.Drawing.Point(12, 93);
            this.pnlEncrypt.Name = "pnlEncrypt";
            this.pnlEncrypt.Size = new System.Drawing.Size(605, 66);
            this.pnlEncrypt.TabIndex = 2;
            // 
            // pnlResponse
            // 
            this.pnlResponse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResponse.Controls.Add(this.chkRandom);
            this.pnlResponse.Controls.Add(this.btLoadCSV);
            this.pnlResponse.Controls.Add(this.tbTrimes);
            this.pnlResponse.Controls.Add(this.tbData);
            this.pnlResponse.Controls.Add(this.btPnlResponse);
            this.pnlResponse.Controls.Add(this.tbCommand);
            this.pnlResponse.Controls.Add(this.tbResponse);
            this.pnlResponse.Controls.Add(this.label3);
            this.pnlResponse.Controls.Add(this.pnlSetRan);
            this.pnlResponse.Enabled = false;
            this.pnlResponse.Location = new System.Drawing.Point(12, 165);
            this.pnlResponse.Name = "pnlResponse";
            this.pnlResponse.Size = new System.Drawing.Size(605, 223);
            this.pnlResponse.TabIndex = 3;
            // 
            // pnlSetRan
            // 
            this.pnlSetRan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSetRan.Controls.Add(this.label6);
            this.pnlSetRan.Controls.Add(this.label5);
            this.pnlSetRan.Controls.Add(this.chkRan10);
            this.pnlSetRan.Controls.Add(this.chkRan9);
            this.pnlSetRan.Controls.Add(this.chkRan8);
            this.pnlSetRan.Controls.Add(this.chkRan7);
            this.pnlSetRan.Controls.Add(this.chkRan6);
            this.pnlSetRan.Controls.Add(this.chkRan5);
            this.pnlSetRan.Controls.Add(this.chkRan4);
            this.pnlSetRan.Controls.Add(this.chkRan3);
            this.pnlSetRan.Controls.Add(this.chkRan2);
            this.pnlSetRan.Controls.Add(this.chkRan1);
            this.pnlSetRan.Controls.Add(this.tbRan10);
            this.pnlSetRan.Controls.Add(this.tbRan9);
            this.pnlSetRan.Controls.Add(this.tbRan8);
            this.pnlSetRan.Controls.Add(this.tbRan7);
            this.pnlSetRan.Controls.Add(this.tbRan6);
            this.pnlSetRan.Controls.Add(this.tbRan5);
            this.pnlSetRan.Controls.Add(this.tbRan4);
            this.pnlSetRan.Controls.Add(this.tbRan3);
            this.pnlSetRan.Controls.Add(this.tbRan2);
            this.pnlSetRan.Controls.Add(this.tbRan1);
            this.pnlSetRan.Location = new System.Drawing.Point(3, 156);
            this.pnlSetRan.Name = "pnlSetRan";
            this.pnlSetRan.Size = new System.Drawing.Size(287, 62);
            this.pnlSetRan.TabIndex = 0;
            this.pnlSetRan.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(273, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Response";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Encrypt";
            // 
            // tbResponse
            // 
            this.tbResponse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbResponse.Enabled = false;
            this.tbResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResponse.Location = new System.Drawing.Point(149, 47);
            this.tbResponse.Name = "tbResponse";
            this.tbResponse.Size = new System.Drawing.Size(364, 30);
            this.tbResponse.TabIndex = 3;
            // 
            // tbCommand
            // 
            this.tbCommand.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCommand.Location = new System.Drawing.Point(65, 83);
            this.tbCommand.MaxLength = 2;
            this.tbCommand.Name = "tbCommand";
            this.tbCommand.Size = new System.Drawing.Size(46, 30);
            this.tbCommand.TabIndex = 4;
            // 
            // tbData
            // 
            this.tbData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbData.Location = new System.Drawing.Point(117, 83);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(424, 30);
            this.tbData.TabIndex = 5;
            // 
            // tbTrimes
            // 
            this.tbTrimes.Location = new System.Drawing.Point(117, 119);
            this.tbTrimes.Name = "tbTrimes";
            this.tbTrimes.Size = new System.Drawing.Size(48, 20);
            this.tbTrimes.TabIndex = 6;
            // 
            // btLoadCSV
            // 
            this.btLoadCSV.Location = new System.Drawing.Point(481, 118);
            this.btLoadCSV.Name = "btLoadCSV";
            this.btLoadCSV.Size = new System.Drawing.Size(60, 20);
            this.btLoadCSV.TabIndex = 7;
            this.btLoadCSV.Text = ".CSV";
            this.btLoadCSV.UseVisualStyleBackColor = true;
            this.btLoadCSV.Click += new System.EventHandler(this.btLoadCSV_Click);
            // 
            // chkRan10
            // 
            this.chkRan10.AutoSize = true;
            this.chkRan10.Location = new System.Drawing.Point(264, 41);
            this.chkRan10.Name = "chkRan10";
            this.chkRan10.Size = new System.Drawing.Size(15, 14);
            this.chkRan10.TabIndex = 39;
            this.chkRan10.UseVisualStyleBackColor = true;
            // 
            // chkRan9
            // 
            this.chkRan9.AutoSize = true;
            this.chkRan9.Location = new System.Drawing.Point(248, 41);
            this.chkRan9.Name = "chkRan9";
            this.chkRan9.Size = new System.Drawing.Size(15, 14);
            this.chkRan9.TabIndex = 38;
            this.chkRan9.UseVisualStyleBackColor = true;
            // 
            // chkRan8
            // 
            this.chkRan8.AutoSize = true;
            this.chkRan8.Location = new System.Drawing.Point(209, 41);
            this.chkRan8.Name = "chkRan8";
            this.chkRan8.Size = new System.Drawing.Size(15, 14);
            this.chkRan8.TabIndex = 37;
            this.chkRan8.UseVisualStyleBackColor = true;
            // 
            // chkRan7
            // 
            this.chkRan7.AutoSize = true;
            this.chkRan7.Location = new System.Drawing.Point(193, 41);
            this.chkRan7.Name = "chkRan7";
            this.chkRan7.Size = new System.Drawing.Size(15, 14);
            this.chkRan7.TabIndex = 36;
            this.chkRan7.UseVisualStyleBackColor = true;
            // 
            // chkRan6
            // 
            this.chkRan6.AutoSize = true;
            this.chkRan6.Location = new System.Drawing.Point(152, 41);
            this.chkRan6.Name = "chkRan6";
            this.chkRan6.Size = new System.Drawing.Size(15, 14);
            this.chkRan6.TabIndex = 35;
            this.chkRan6.UseVisualStyleBackColor = true;
            // 
            // chkRan5
            // 
            this.chkRan5.AutoSize = true;
            this.chkRan5.Location = new System.Drawing.Point(136, 41);
            this.chkRan5.Name = "chkRan5";
            this.chkRan5.Size = new System.Drawing.Size(15, 14);
            this.chkRan5.TabIndex = 34;
            this.chkRan5.UseVisualStyleBackColor = true;
            // 
            // chkRan4
            // 
            this.chkRan4.AutoSize = true;
            this.chkRan4.Location = new System.Drawing.Point(98, 41);
            this.chkRan4.Name = "chkRan4";
            this.chkRan4.Size = new System.Drawing.Size(15, 14);
            this.chkRan4.TabIndex = 33;
            this.chkRan4.UseVisualStyleBackColor = true;
            // 
            // chkRan3
            // 
            this.chkRan3.AutoSize = true;
            this.chkRan3.Location = new System.Drawing.Point(82, 41);
            this.chkRan3.Name = "chkRan3";
            this.chkRan3.Size = new System.Drawing.Size(15, 14);
            this.chkRan3.TabIndex = 32;
            this.chkRan3.UseVisualStyleBackColor = true;
            // 
            // chkRan2
            // 
            this.chkRan2.AutoSize = true;
            this.chkRan2.Location = new System.Drawing.Point(45, 41);
            this.chkRan2.Name = "chkRan2";
            this.chkRan2.Size = new System.Drawing.Size(15, 14);
            this.chkRan2.TabIndex = 31;
            this.chkRan2.UseVisualStyleBackColor = true;
            // 
            // chkRan1
            // 
            this.chkRan1.AutoSize = true;
            this.chkRan1.Location = new System.Drawing.Point(29, 41);
            this.chkRan1.Name = "chkRan1";
            this.chkRan1.Size = new System.Drawing.Size(15, 14);
            this.chkRan1.TabIndex = 30;
            this.chkRan1.UseVisualStyleBackColor = true;
            // 
            // tbRan10
            // 
            this.tbRan10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbRan10.Location = new System.Drawing.Point(264, 12);
            this.tbRan10.MaxLength = 1;
            this.tbRan10.Name = "tbRan10";
            this.tbRan10.Size = new System.Drawing.Size(17, 20);
            this.tbRan10.TabIndex = 29;
            // 
            // tbRan9
            // 
            this.tbRan9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbRan9.Location = new System.Drawing.Point(246, 12);
            this.tbRan9.MaxLength = 1;
            this.tbRan9.Name = "tbRan9";
            this.tbRan9.Size = new System.Drawing.Size(17, 20);
            this.tbRan9.TabIndex = 28;
            // 
            // tbRan8
            // 
            this.tbRan8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbRan8.Location = new System.Drawing.Point(209, 12);
            this.tbRan8.MaxLength = 1;
            this.tbRan8.Name = "tbRan8";
            this.tbRan8.Size = new System.Drawing.Size(17, 20);
            this.tbRan8.TabIndex = 27;
            // 
            // tbRan7
            // 
            this.tbRan7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbRan7.Location = new System.Drawing.Point(191, 12);
            this.tbRan7.MaxLength = 1;
            this.tbRan7.Name = "tbRan7";
            this.tbRan7.Size = new System.Drawing.Size(17, 20);
            this.tbRan7.TabIndex = 26;
            // 
            // tbRan6
            // 
            this.tbRan6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbRan6.Location = new System.Drawing.Point(152, 12);
            this.tbRan6.MaxLength = 1;
            this.tbRan6.Name = "tbRan6";
            this.tbRan6.Size = new System.Drawing.Size(17, 20);
            this.tbRan6.TabIndex = 25;
            // 
            // tbRan5
            // 
            this.tbRan5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbRan5.Location = new System.Drawing.Point(134, 12);
            this.tbRan5.MaxLength = 1;
            this.tbRan5.Name = "tbRan5";
            this.tbRan5.Size = new System.Drawing.Size(17, 20);
            this.tbRan5.TabIndex = 24;
            // 
            // tbRan4
            // 
            this.tbRan4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbRan4.Location = new System.Drawing.Point(98, 12);
            this.tbRan4.MaxLength = 1;
            this.tbRan4.Name = "tbRan4";
            this.tbRan4.Size = new System.Drawing.Size(17, 20);
            this.tbRan4.TabIndex = 23;
            // 
            // tbRan3
            // 
            this.tbRan3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbRan3.Location = new System.Drawing.Point(80, 12);
            this.tbRan3.MaxLength = 1;
            this.tbRan3.Name = "tbRan3";
            this.tbRan3.Size = new System.Drawing.Size(17, 20);
            this.tbRan3.TabIndex = 22;
            // 
            // tbRan2
            // 
            this.tbRan2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbRan2.Location = new System.Drawing.Point(45, 12);
            this.tbRan2.MaxLength = 1;
            this.tbRan2.Name = "tbRan2";
            this.tbRan2.Size = new System.Drawing.Size(17, 20);
            this.tbRan2.TabIndex = 21;
            // 
            // tbRan1
            // 
            this.tbRan1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbRan1.Location = new System.Drawing.Point(27, 12);
            this.tbRan1.MaxLength = 1;
            this.tbRan1.Name = "tbRan1";
            this.tbRan1.Size = new System.Drawing.Size(17, 20);
            this.tbRan1.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(221, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(122, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(68, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "40 Bit";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(31, 25);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "80 Bit";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // chkRandom
            // 
            this.chkRandom.AutoSize = true;
            this.chkRandom.Location = new System.Drawing.Point(171, 122);
            this.chkRandom.Name = "chkRandom";
            this.chkRandom.Size = new System.Drawing.Size(66, 17);
            this.chkRandom.TabIndex = 9;
            this.chkRandom.Text = "Random";
            this.chkRandom.UseVisualStyleBackColor = true;
            this.chkRandom.Click += new System.EventHandler(this.chkRandom_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Bit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Fix";
            // 
            // btPnlResponse
            // 
            this.btPnlResponse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPnlResponse.Image = global::rewrite_one_part_Arcanabug_v4.Properties.Resources.success_next_button;
            this.btPnlResponse.Location = new System.Drawing.Point(298, 168);
            this.btPnlResponse.Name = "btPnlResponse";
            this.btPnlResponse.Size = new System.Drawing.Size(50, 50);
            this.btPnlResponse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btPnlResponse.TabIndex = 1;
            this.btPnlResponse.TabStop = false;
            this.btPnlResponse.Click += new System.EventHandler(this.btPnlResponse_Click);
            // 
            // btPnlKey
            // 
            this.btPnlKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPnlKey.Enabled = false;
            this.btPnlKey.Image = global::rewrite_one_part_Arcanabug_v4.Properties.Resources.success_next_button;
            this.btPnlKey.Location = new System.Drawing.Point(412, 32);
            this.btPnlKey.Name = "btPnlKey";
            this.btPnlKey.Size = new System.Drawing.Size(40, 40);
            this.btPnlKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btPnlKey.TabIndex = 2;
            this.btPnlKey.TabStop = false;
            this.btPnlKey.Click += new System.EventHandler(this.btPnlKey_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 400);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlResponse);
            this.Controls.Add(this.pnlEncrypt);
            this.Controls.Add(this.pnlKey);
            this.Controls.Add(this.pnlPort);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rewrite(1part) ArcanaDebug";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlPort.ResumeLayout(false);
            this.pnlPort.PerformLayout();
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            this.pnlEncrypt.ResumeLayout(false);
            this.pnlEncrypt.PerformLayout();
            this.pnlResponse.ResumeLayout(false);
            this.pnlResponse.PerformLayout();
            this.pnlSetRan.ResumeLayout(false);
            this.pnlSetRan.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btPnlResponse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btPnlKey)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPort;
        private System.Windows.Forms.ComboBox comboPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlKey;
        private System.Windows.Forms.PictureBox btPnlKey;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlEncrypt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlResponse;
        private System.Windows.Forms.Button btLoadCSV;
        private System.Windows.Forms.TextBox tbTrimes;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.TextBox tbCommand;
        private System.Windows.Forms.TextBox tbResponse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btPnlResponse;
        private System.Windows.Forms.Panel pnlSetRan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox chkRan10;
        private System.Windows.Forms.CheckBox chkRan9;
        private System.Windows.Forms.CheckBox chkRan8;
        private System.Windows.Forms.CheckBox chkRan7;
        private System.Windows.Forms.CheckBox chkRan6;
        private System.Windows.Forms.CheckBox chkRan5;
        private System.Windows.Forms.CheckBox chkRan4;
        private System.Windows.Forms.CheckBox chkRan3;
        private System.Windows.Forms.CheckBox chkRan2;
        private System.Windows.Forms.CheckBox chkRan1;
        private System.Windows.Forms.TextBox tbRan10;
        private System.Windows.Forms.TextBox tbRan9;
        private System.Windows.Forms.TextBox tbRan8;
        private System.Windows.Forms.TextBox tbRan7;
        private System.Windows.Forms.TextBox tbRan6;
        private System.Windows.Forms.TextBox tbRan5;
        private System.Windows.Forms.TextBox tbRan4;
        private System.Windows.Forms.TextBox tbRan3;
        private System.Windows.Forms.TextBox tbRan2;
        private System.Windows.Forms.TextBox tbRan1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox chkRandom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}
