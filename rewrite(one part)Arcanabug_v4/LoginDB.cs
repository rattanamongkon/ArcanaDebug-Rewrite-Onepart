using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
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
        MySqlConnection cnn;
        ArrayList listDatabase = new ArrayList();
        ArrayList listTable = new ArrayList();
        TreeNode node;
        string[] path = { "0","00" };
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
                try
                {
                    queryAll();
                    MessageBox.Show("Connection Open ! ");
                    panel2.Enabled = true;
                    //panel1.Enabled = false;
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

        private void queryDatabase()
        {
            treeView1.Nodes.Clear();
            connetionString = "Server = " + tbServer.Text + ";  Port = 3306; Uid = " + tbUid.Text + "; Pwd = " + tbPwd.Text;
            cnn = new MySqlConnection(connetionString);
            try
            {
                MySqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SHOW DATABASES;";
                MySqlDataReader Reader;
                cnn.Open();
                Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    string root = "";
                    for (int i = 0; i < Reader.FieldCount; i++)
                    {
                        root += Reader.GetValue(i).ToString();
                    }
                    listDatabase.Add(root);
                }
                cnn.Close();
            } catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }

        public void queryAll()
        {
            listDatabase = new ArrayList();
            queryDatabase();
            for (int i = 0; i < listDatabase.Count - 1; i++)
            {
                MySqlCommand cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SHOW TABLES FROM " + listDatabase[i].ToString() + ";";
                MySqlDataReader Reader;

                listTable = new ArrayList();
                node = treeView1.Nodes.Add(listDatabase[i].ToString());

                cnn.Open();
                Reader = cmd.ExecuteReader();
                int countTable = 0;
                while (Reader.Read())
                {
                    string child = "";
                    for (int j = 0; j < Reader.FieldCount; j++)
                    {
                        child += Reader.GetValue(j).ToString();
                        listTable.Add(child);
                    }
                    node.Nodes.Add(listTable[countTable].ToString());
                    countTable++;
                }
                cnn.Close();
            }
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            string type = "Database";
            if (path[0] == "0")
            {
                path[0] = "Empty";
            }
            NameCreate fCreate = new NameCreate(connetionString, type,path[0]);
            fCreate.Show();
            queryAll();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            if (!treeView1.Focus())
            {
                MessageBox.Show("Please select Database");
            }
            else
            {
                string[] path = treeView1.SelectedNode.FullPath.Split('\\');
                if (path.Length > 1)
                {
                    connetionString = "Server = " + tbServer.Text + ";  Port = 3306; Database = " + path[0] + "; Uid = " + tbUid.Text + "; Pwd = " + tbPwd.Text;
                    Form1 f1 = new Form1(connetionString, path[1]);
                    f1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please select or create DataTable!", "Select Table", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    treeView1.Focus();
                }
            }
        }

        private void btCreateTable_Click(object sender, EventArgs e)
        {
            string type = "Table";
            NameCreate fCreate = new NameCreate(connetionString, type, path[0]);
            fCreate.Show();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (path.Length > 1)
            {
                DialogResult result = MessageBox.Show("Do you want to delete this table?", "Delate Table", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        cnn.Open();
                        MySqlCommand cmd = new MySqlCommand("USE `" + path[0] + "`", cnn);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        string s0 = "DROP TABLE " + path[1];
                        cmd = new MySqlCommand(s0, cnn);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        cnn.Close();
                        MessageBox.Show("Delete Table success");
                        queryAll();
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.ToString());
                    }
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Do you want to delete this Database?", "Delate Database", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        cnn.Open();
                        string s0 = "DROP DATABASE " + path[0];
                        MySqlCommand cmd = new MySqlCommand(s0, cnn);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        cnn.Close();
                        MessageBox.Show("Delete Database success");
                        queryAll();
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.ToString());
                    }
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            btConnect.Enabled = true;
            btCreateTable.Enabled = true;
            btDelete.Enabled = true;

            path = treeView1.SelectedNode.FullPath.Split('\\');
        }

        private void button1_Click(object sender, EventArgs e)
        {
            queryAll();
        }
    }
}
