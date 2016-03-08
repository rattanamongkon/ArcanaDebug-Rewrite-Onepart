namespace rewrite_one_part_Arcanabug_v4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlPort = new System.Windows.Forms.Panel();
            this.comboPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlKey = new System.Windows.Forms.Panel();
            this.btPnlKey = new System.Windows.Forms.PictureBox();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlEncrypt = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlResponse = new System.Windows.Forms.Panel();
            this.chkRandom = new System.Windows.Forms.CheckBox();
            this.btLoadCSV = new System.Windows.Forms.Button();
            this.tbTrimes = new System.Windows.Forms.TextBox();
            this.tbData = new System.Windows.Forms.TextBox();
            this.btPnlResponse = new System.Windows.Forms.PictureBox();
            this.tbCommand = new System.Windows.Forms.TextBox();
            this.tbResponse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlSetRan = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pnlGridview = new System.Windows.Forms.Panel();
            this.btSave = new System.Windows.Forms.Button();
            this.dgrDatabase = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboSremark = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSkey = new System.Windows.Forms.TextBox();
            this.tbSsend = new System.Windows.Forms.TextBox();
            this.btSaveCSV = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlPort.SuspendLayout();
            this.pnlKey.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btPnlKey)).BeginInit();
            this.pnlEncrypt.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlResponse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btPnlResponse)).BeginInit();
            this.pnlSetRan.SuspendLayout();
            this.pnlGridview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDatabase)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPort
            // 
            this.pnlPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPort.Controls.Add(this.comboPort);
            this.pnlPort.Controls.Add(this.label1);
            this.pnlPort.Location = new System.Drawing.Point(12, 12);
            this.pnlPort.Name = "pnlPort";
            this.pnlPort.Size = new System.Drawing.Size(120, 75);
            this.pnlPort.TabIndex = 0;
            // 
            // comboPort
            // 
            this.comboPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPort.FormattingEnabled = true;
            this.comboPort.Location = new System.Drawing.Point(17, 42);
            this.comboPort.Name = "comboPort";
            this.comboPort.Size = new System.Drawing.Size(88, 21);
            this.comboPort.TabIndex = 1;
            this.comboPort.SelectedIndexChanged += new System.EventHandler(this.comboPort_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // pnlKey
            // 
            this.pnlKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKey.Controls.Add(this.btPnlKey);
            this.pnlKey.Controls.Add(this.tbKey);
            this.pnlKey.Controls.Add(this.label2);
            this.pnlKey.Location = new System.Drawing.Point(138, 12);
            this.pnlKey.Name = "pnlKey";
            this.pnlKey.Size = new System.Drawing.Size(339, 75);
            this.pnlKey.TabIndex = 1;
            // 
            // btPnlKey
            // 
            this.btPnlKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPnlKey.Enabled = false;
            this.btPnlKey.Image = global::rewrite_one_part_Arcanabug_v4.Properties.Resources.success_next_button;
            this.btPnlKey.Location = new System.Drawing.Point(294, 30);
            this.btPnlKey.Name = "btPnlKey";
            this.btPnlKey.Size = new System.Drawing.Size(40, 40);
            this.btPnlKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btPnlKey.TabIndex = 2;
            this.btPnlKey.TabStop = false;
            this.btPnlKey.Click += new System.EventHandler(this.btPnlKey_Click);
            // 
            // tbKey
            // 
            this.tbKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKey.Location = new System.Drawing.Point(4, 42);
            this.tbKey.MaxLength = 20;
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(284, 30);
            this.tbKey.TabIndex = 1;
            this.tbKey.Text = "0123456789ABCDEF0123";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "ENTER KEY";
            // 
            // pnlEncrypt
            // 
            this.pnlEncrypt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEncrypt.Controls.Add(this.groupBox1);
            this.pnlEncrypt.Controls.Add(this.label4);
            this.pnlEncrypt.Enabled = false;
            this.pnlEncrypt.Location = new System.Drawing.Point(483, 12);
            this.pnlEncrypt.Name = "pnlEncrypt";
            this.pnlEncrypt.Size = new System.Drawing.Size(231, 75);
            this.pnlEncrypt.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(72, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 56);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(6, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "80 Bit";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(80, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(68, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "40 Bit";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Encrypt";
            // 
            // pnlResponse
            // 
            this.pnlResponse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResponse.Controls.Add(this.pictureBox1);
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
            this.pnlResponse.Location = new System.Drawing.Point(12, 93);
            this.pnlResponse.Name = "pnlResponse";
            this.pnlResponse.Size = new System.Drawing.Size(702, 223);
            this.pnlResponse.TabIndex = 3;
            // 
            // chkRandom
            // 
            this.chkRandom.AutoSize = true;
            this.chkRandom.Location = new System.Drawing.Point(217, 121);
            this.chkRandom.Name = "chkRandom";
            this.chkRandom.Size = new System.Drawing.Size(66, 17);
            this.chkRandom.TabIndex = 9;
            this.chkRandom.Text = "Random";
            this.chkRandom.UseVisualStyleBackColor = true;
            this.chkRandom.Click += new System.EventHandler(this.chkRandom_Click);
            // 
            // btLoadCSV
            // 
            this.btLoadCSV.Location = new System.Drawing.Point(527, 117);
            this.btLoadCSV.Name = "btLoadCSV";
            this.btLoadCSV.Size = new System.Drawing.Size(60, 20);
            this.btLoadCSV.TabIndex = 7;
            this.btLoadCSV.Text = ".CSV";
            this.btLoadCSV.UseVisualStyleBackColor = true;
            this.btLoadCSV.Click += new System.EventHandler(this.btLoadCSV_Click);
            // 
            // tbTrimes
            // 
            this.tbTrimes.Location = new System.Drawing.Point(163, 118);
            this.tbTrimes.Name = "tbTrimes";
            this.tbTrimes.Size = new System.Drawing.Size(48, 20);
            this.tbTrimes.TabIndex = 6;
            // 
            // tbData
            // 
            this.tbData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbData.Location = new System.Drawing.Point(163, 82);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(424, 30);
            this.tbData.TabIndex = 5;
            // 
            // btPnlResponse
            // 
            this.btPnlResponse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPnlResponse.Image = global::rewrite_one_part_Arcanabug_v4.Properties.Resources.success_next_button;
            this.btPnlResponse.Location = new System.Drawing.Point(344, 167);
            this.btPnlResponse.Name = "btPnlResponse";
            this.btPnlResponse.Size = new System.Drawing.Size(50, 50);
            this.btPnlResponse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btPnlResponse.TabIndex = 1;
            this.btPnlResponse.TabStop = false;
            this.btPnlResponse.Click += new System.EventHandler(this.btPnlResponse_Click);
            // 
            // tbCommand
            // 
            this.tbCommand.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCommand.Location = new System.Drawing.Point(111, 82);
            this.tbCommand.MaxLength = 2;
            this.tbCommand.Name = "tbCommand";
            this.tbCommand.Size = new System.Drawing.Size(46, 30);
            this.tbCommand.TabIndex = 4;
            // 
            // tbResponse
            // 
            this.tbResponse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbResponse.Enabled = false;
            this.tbResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResponse.Location = new System.Drawing.Point(195, 46);
            this.tbResponse.Name = "tbResponse";
            this.tbResponse.Size = new System.Drawing.Size(364, 30);
            this.tbResponse.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(319, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Response";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Fix";
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
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // pnlGridview
            // 
            this.pnlGridview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGridview.Controls.Add(this.btSave);
            this.pnlGridview.Controls.Add(this.dgrDatabase);
            this.pnlGridview.Controls.Add(this.groupBox2);
            this.pnlGridview.Controls.Add(this.btSaveCSV);
            this.pnlGridview.Location = new System.Drawing.Point(12, 322);
            this.pnlGridview.Name = "pnlGridview";
            this.pnlGridview.Size = new System.Drawing.Size(702, 366);
            this.pnlGridview.TabIndex = 4;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(495, 19);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(109, 23);
            this.btSave.TabIndex = 18;
            this.btSave.Text = "Save to Database";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // dgrDatabase
            // 
            this.dgrDatabase.AllowUserToAddRows = false;
            this.dgrDatabase.AllowUserToDeleteRows = false;
            this.dgrDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDatabase.Location = new System.Drawing.Point(3, 57);
            this.dgrDatabase.Name = "dgrDatabase";
            this.dgrDatabase.ReadOnly = true;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgrDatabase.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgrDatabase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrDatabase.Size = new System.Drawing.Size(694, 304);
            this.dgrDatabase.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboSremark);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbSkey);
            this.groupBox2.Controls.Add(this.tbSsend);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 48);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            // 
            // comboSremark
            // 
            this.comboSremark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSremark.FormattingEnabled = true;
            this.comboSremark.Items.AddRange(new object[] {
            "",
            "random",
            "load .CSV",
            "one command",
            "set key",
            "encrypt80",
            "encrypt40"});
            this.comboSremark.Location = new System.Drawing.Point(374, 18);
            this.comboSremark.Name = "comboSremark";
            this.comboSremark.Size = new System.Drawing.Size(101, 21);
            this.comboSremark.TabIndex = 12;
            this.comboSremark.SelectedIndexChanged += new System.EventHandler(this.comboSremark_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Remark";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Key";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(154, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Data Send";
            // 
            // tbSkey
            // 
            this.tbSkey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSkey.Location = new System.Drawing.Point(45, 18);
            this.tbSkey.Name = "tbSkey";
            this.tbSkey.Size = new System.Drawing.Size(100, 20);
            this.tbSkey.TabIndex = 7;
            this.tbSkey.TextChanged += new System.EventHandler(this.tbSkey_TextChanged);
            // 
            // tbSsend
            // 
            this.tbSsend.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSsend.Location = new System.Drawing.Point(218, 18);
            this.tbSsend.Name = "tbSsend";
            this.tbSsend.Size = new System.Drawing.Size(100, 20);
            this.tbSsend.TabIndex = 8;
            this.tbSsend.TextChanged += new System.EventHandler(this.tbSsend_TextChanged);
            // 
            // btSaveCSV
            // 
            this.btSaveCSV.Location = new System.Drawing.Point(610, 19);
            this.btSaveCSV.Name = "btSaveCSV";
            this.btSaveCSV.Size = new System.Drawing.Size(87, 23);
            this.btSaveCSV.TabIndex = 15;
            this.btSaveCSV.Text = "Save to .CSV";
            this.btSaveCSV.UseVisualStyleBackColor = true;
            this.btSaveCSV.Click += new System.EventHandler(this.btSaveCSV_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::rewrite_one_part_Arcanabug_v4.Properties.Resources.ajax_loader;
            this.pictureBox1.Location = new System.Drawing.Point(344, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 700);
            this.Controls.Add(this.pnlGridview);
            this.Controls.Add(this.pnlResponse);
            this.Controls.Add(this.pnlEncrypt);
            this.Controls.Add(this.pnlKey);
            this.Controls.Add(this.pnlPort);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rewrite(1part) ArcanaDebug";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlPort.ResumeLayout(false);
            this.pnlPort.PerformLayout();
            this.pnlKey.ResumeLayout(false);
            this.pnlKey.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btPnlKey)).EndInit();
            this.pnlEncrypt.ResumeLayout(false);
            this.pnlEncrypt.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlResponse.ResumeLayout(false);
            this.pnlResponse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btPnlResponse)).EndInit();
            this.pnlSetRan.ResumeLayout(false);
            this.pnlSetRan.PerformLayout();
            this.pnlGridview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrDatabase)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel pnlGridview;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboSremark;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSkey;
        private System.Windows.Forms.TextBox tbSsend;
        private System.Windows.Forms.Button btSaveCSV;
        private System.Windows.Forms.DataGridView dgrDatabase;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

