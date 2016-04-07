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
    public partial class NameCreate : Form
    {
        public NameCreate(string con, string type, string xpath)
        {
            InitializeComponent();
            connetionString = con;
            typeLabel = type;
            path = xpath;
        }

        string path = string.Empty;
        string typeLabel = string.Empty;
        string connetionString = string.Empty;
        MySqlConnection con;

        private void NameCreate_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection(connetionString);
            label2.Text = "Create " + typeLabel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                MySqlCommand cmd;
                string s0 = "";
                try
                {
                    con.Open();
                    if (typeLabel == "Database")
                    {
                        s0 = "CREATE DATABASE IF NOT EXISTS `" + textBox1.Text + "`;";
                    }
                    else
                    {
                        //use database;
                        cmd = new MySqlCommand("USE `" + path + "`", con);
                        cmd.ExecuteNonQuery();
                        //string create table
                        s0 = "CREATE TABLE IF NOT EXISTS `" + textBox1.Text + "` (" +
                            "`id` INT NOT NULL AUTO_INCREMENT," +
                            "`status` VARCHAR(40) NULL," +
                            "`send` VARCHAR(41) NULL," +
                            "`recive` VARCHAR(26) NULL," +
                            "`keyconfig` VARCHAR(29) NULL," +
                            "`raw_send` VARCHAR(42) NULL," +
                            "`raw_recive` VARCHAR(34) NULL," +
                            "`remark` VARCHAR(11) NULL," +
                            "`datetime` VARCHAR(21) NULL," +
                            "PRIMARY KEY (`id`));";
                    }
                    //create table in database
                    cmd = new MySqlCommand(s0, con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                    MessageBox.Show("Create " + typeLabel + " Success!!");
                    this.Close();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
            }else
            {
                MessageBox.Show("Please enter " + typeLabel + " name!!!","Please...",MessageBoxButtons.OK,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NameCreate_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (System.Windows.Forms.Application.OpenForms["LoginDB"] != null)
                {
                    (System.Windows.Forms.Application.OpenForms["LoginDB"] as LoginDB).queryAll();
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar >= 97 && (int)e.KeyChar <= 122)
                || ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
                || (int)e.KeyChar == 8
                || (int)e.KeyChar == 13
                || (int)e.KeyChar == 46
                || (int)e.KeyChar == 95)
            {
                e.Handled = false;
            } else
            {
                e.Handled = true;
            }
        }
    }
}
