using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace rewrite_one_part_Arcanabug_v4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        SqlConnection con = new SqlConnection(@"Data Source = localhost\sqlexpress; Initial Catalog = ArcanaTestDB; User ID = sa; Password = 123456789");
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\rattanamongkon\documents\visual studio 2015\Projects\rewrite(one part)Arcanabug_v4\rewrite(one part)Arcanabug_v4\Database1.mdf;Integrated Security=True");
        //string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\rattanamongkon\documents\visual studio 2015\Projects\rewrite(one part)Arcanabug_v4\rewrite(one part)Arcanabug_v4\Database1.mdf;Integrated Security=True";

        private void Form2_Load(object sender, EventArgs e)
        {
            statusForm.Text = "true";

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM tblArcana";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            //set below scorllbar
            dataGridView1.FirstDisplayedCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0];
            con.Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            statusForm.Text = "false";
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdl = new SaveFileDialog();
            sfdl.Filter = "CSV Files(*.csv)|*.csv|Text Files(*.txt)|*.txt";
            if (sfdl.ShowDialog() == DialogResult.OK)
            {
                string filename = sfdl.FileName;
                writeCSV(dataGridView1, filename);
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM tblArcana WHERE keyconfig LIKE ('" + textBox2.Text + "%') AND send LIKE ('"+ textBox3.Text +"%') AND remark LIKE ('"+ comboBox1.Text +"%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            } catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM tblArcana WHERE keyconfig LIKE ('" + textBox2.Text + "%') AND send LIKE ('" + textBox3.Text + "%') AND remark LIKE ('" + comboBox1.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM tblArcana WHERE keyconfig LIKE ('" + textBox2.Text + "%') AND send LIKE ('" + textBox3.Text + "%') AND remark LIKE ('" + comboBox1.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }

        public void writeCSV(DataGridView gridIn, string outputFile)
        {
            try
            {
                //test to see if the DataGridView has any rows
                if (gridIn.RowCount > 0)
                {
                    string value = "";
                    DataGridViewRow dr = new DataGridViewRow();
                    StreamWriter swOut = new StreamWriter(outputFile);

                    //write header rows to csv
                    for (int i = 0; i <= gridIn.Columns.Count - 1; i++)
                    {
                        if (i > 0)
                        {
                            swOut.Write(",");
                        }
                        swOut.Write(gridIn.Columns[i].HeaderText);
                    }

                    swOut.WriteLine();

                    //write DataGridView rows to csv
                    for (int j = 0; j <= gridIn.Rows.Count - 1; j++)
                    {
                        if (j > 0)
                        {
                            swOut.WriteLine();
                        }

                        dr = gridIn.Rows[j];

                        for (int i = 0; i <= gridIn.Columns.Count - 1; i++)
                        {
                            if (i > 0)
                            {
                                swOut.Write(",");
                            }

                            value = dr.Cells[i].Value.ToString();
                            //replace comma's with spaces
                            value = value.Replace(',', ' ');
                            //replace embedded newlines with spaces
                            value = value.Replace(Environment.NewLine, " ");

                            swOut.Write(value);
                        }
                    }
                    swOut.Close();
                    MessageBox.Show("Save file completed");
                }
            } catch (Exception er)
            {
                MessageBox.Show(er.ToString());
                return;
            }
            
        }
    }
}
