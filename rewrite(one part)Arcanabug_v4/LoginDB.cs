using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace rewrite_one_part_Arcanabug_v4
{
    public partial class LoginDB : Form
    {
        public LoginDB()
        {
            InitializeComponent();
        }

        //string myConnectionString = "server=localhost;database=arcanatestdb;uid=root;pwd=ๅ/-ภ;";
        private void LoginDB_Load(object sender, EventArgs e)
        {

        }

        public string connetionString = null;
        private void btLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbServer.Text))
            {
                MessageBox.Show("Please enter Server name");
            } else if (string.IsNullOrWhiteSpace(tbUid.Text))
            {
                MessageBox.Show("Please enter User ID name");
            } else if (string.IsNullOrWhiteSpace(tbPwd.Text))
            {
                MessageBox.Show("Please enter Password");
            }
            else
            {
                MySqlConnection cnn;
                connetionString = "Server = " + tbServer.Text + "; Port = 3306; Database = arcanatestdb; Uid = " + tbUid.Text +"; Pwd = " + tbPwd.Text;
                cnn = new MySqlConnection(connetionString);
                try
                {
                    cnn.Open();
                    MessageBox.Show("Connection Open ! ");
                    cnn.Close();
                    Form1 f1 = new Form1(connetionString);
                    f1.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't open connection ! \n Please cheak you Server name/Username/Password","Authentication Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
