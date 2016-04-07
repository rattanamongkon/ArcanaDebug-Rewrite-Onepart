namespace rewrite_one_part_Arcanabug_v4
{
    partial class LoginDB
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
            this.btLogin = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUid = new System.Windows.Forms.TextBox();
            this.tbPwd = new System.Windows.Forms.TextBox();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btDelete = new System.Windows.Forms.Button();
            this.btCreateTable = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.btCreate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(34, 150);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(73, 35);
            this.btLogin.TabIndex = 5;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(126, 150);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(73, 35);
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "Exit";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Connect to MySQL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "User ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // tbUid
            // 
            this.tbUid.Location = new System.Drawing.Point(85, 98);
            this.tbUid.Name = "tbUid";
            this.tbUid.Size = new System.Drawing.Size(131, 20);
            this.tbUid.TabIndex = 3;
            this.tbUid.Text = "root";
            // 
            // tbPwd
            // 
            this.tbPwd.Location = new System.Drawing.Point(85, 124);
            this.tbPwd.Name = "tbPwd";
            this.tbPwd.PasswordChar = '*';
            this.tbPwd.Size = new System.Drawing.Size(131, 20);
            this.tbPwd.TabIndex = 4;
            this.tbPwd.Text = "root";
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(85, 46);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(131, 20);
            this.tbServer.TabIndex = 1;
            this.tbServer.Text = "localhost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Server";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(313, 191);
            this.treeView1.TabIndex = 11;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbPort);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btLogin);
            this.panel1.Controls.Add(this.tbServer);
            this.panel1.Controls.Add(this.btCancel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbPwd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbUid);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 199);
            this.panel1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Port";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(85, 72);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(131, 20);
            this.tbPort.TabIndex = 2;
            this.tbPort.Text = "3306";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btDelete);
            this.panel2.Controls.Add(this.btCreateTable);
            this.panel2.Controls.Add(this.btConnect);
            this.panel2.Controls.Add(this.btCreate);
            this.panel2.Controls.Add(this.treeView1);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(252, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(426, 199);
            this.panel2.TabIndex = 13;
            // 
            // btDelete
            // 
            this.btDelete.Enabled = false;
            this.btDelete.Location = new System.Drawing.Point(322, 102);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(96, 23);
            this.btDelete.TabIndex = 9;
            this.btDelete.Text = "Delete DB";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btCreateTable
            // 
            this.btCreateTable.Enabled = false;
            this.btCreateTable.Location = new System.Drawing.Point(322, 73);
            this.btCreateTable.Name = "btCreateTable";
            this.btCreateTable.Size = new System.Drawing.Size(96, 23);
            this.btCreateTable.TabIndex = 8;
            this.btCreateTable.Text = "Create Table";
            this.btCreateTable.UseVisualStyleBackColor = true;
            this.btCreateTable.Click += new System.EventHandler(this.btCreateTable_Click);
            // 
            // btConnect
            // 
            this.btConnect.Enabled = false;
            this.btConnect.Location = new System.Drawing.Point(322, 131);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(96, 63);
            this.btConnect.TabIndex = 10;
            this.btConnect.Text = "Connect DB";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(322, 44);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(96, 23);
            this.btCreate.TabIndex = 7;
            this.btCreate.Text = "Create DB";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // LoginDB
            // 
            this.AcceptButton = this.btLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 223);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginDB_FormClosed);
            this.Load += new System.EventHandler(this.LoginDB_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUid;
        private System.Windows.Forms.TextBox tbPwd;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btCreateTable;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btCreate;
        public System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPort;
    }
}