using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Data.SqlClient;
using System.Threading;
using MySql.Data.MySqlClient;

namespace rewrite_one_part_Arcanabug_v4
{
    public partial class Form1 : Form
    {
        public Form1(string con, string xtable)
        {
            InitializeComponent();
            connetionString = con;
            table = xtable;
        }
        string table = string.Empty;
        string connetionString = string.Empty;
        DataSet ds = new DataSet();
        //SqlConnection con = new SqlConnection(@"Data Source = localhost\sqlexpress; Initial Catalog = ArcanaTestDB; User ID = sa; Password = 123456789");
        MySqlConnection con;

        //status save remark database
        private string sendDB = string.Empty;
        private string reciveDB = string.Empty;
        private string keyDB = string.Empty;
        private string rawsendDB = string.Empty;
        private string rawreciveDB = string.Empty;
        private string remarkDB = string.Empty;

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection(connetionString);
            //add port to comboBox
            string[] arr = SerialPort.GetPortNames();
            for (int i = 0; i < arr.Length; i++)
            {
                comboPort.Items.Add(arr[i]);
            }
            if (arr.Length > 0)
            {
                comboPort.SelectedIndex = 0;
            }
            loadDB();
            //f2.Show();
        }

        private void comboPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPort.SelectedIndex > -1)
            {
                btPnlKey.Enabled = true;
            }
        }

        //setkey
        private void btPnlKey_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.PortName = comboPort.Text;
                    serialPort1.Open();
                }

                if (!string.IsNullOrWhiteSpace(tbKey.Text) && tbKey.TextLength == 20)
                {
                    // set 80 bit encrypt befor set key
                    // background process
                    workingThread("setkey80");

                    //check key
                    //MessageBox.Show("Setting 80bit key success");
                    pnlEncrypt.Enabled = true;
                    groupBox1.Enabled = true;
                    pnlResponse.Enabled = true;                        
                }
                else if (!string.IsNullOrWhiteSpace(tbKey.Text) && tbKey.TextLength == 10)
                {
                    // set 40 bit encrypt befor set key
                    // background process
                    workingThread("setkey40");

                    //check key
                    //MessageBox.Show("Setting 40bit key success");
                    pnlEncrypt.Enabled = true;
                    groupBox1.Enabled = true;
                    pnlResponse.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Please enter key");
                }

            } catch (Exception er)
            {
                MessageBox.Show(er.ToString());
                pnlEncrypt.Enabled = false;
                groupBox1.Enabled = false;
                pnlResponse.Enabled = false;

            }
        }

        //###########################################################
        int trimes; //trimes random
        string tempKey = string.Empty;
        string tempEncrypt = string.Empty;
        private void btPnlResponse_Click(object sender, EventArgs e)
        {
            pnlGridview.Enabled = true;
            //Load .CSV
            if (f3.lblFileStatus.Text == "true")
            {
                if (f3.dataGridView1.RowCount > 1)
                {
                    try
                    {
                        //Start Thread
                        workingThread("loadCSV");

                    } catch(Exception er)
                    {
                        MessageBox.Show(er.ToString());
                    }
                } else
                {
                    MessageBox.Show("File format was wrong");
                }
                return;
            }

            if (!string.IsNullOrWhiteSpace(tbCommand.Text))
            {
                //random
                if (chkRandom.Checked)
                {
                    remarkDB = "random";
                    if (string.IsNullOrWhiteSpace(tbTrimes.Text))
                    {
                        MessageBox.Show("Please enter number of trimes");
                    }
                    else
                    {
                        trimes = Int32.Parse(tbTrimes.Text);
                        //Start Thread
                        workingThread("random");
                    }
                }
                else
                {
                    //one command
                    remarkDB = "one command";
                    rxCM = tbCommand.Text;
                    rxData = tbData.Text;
                    //StartThread
                    workingThread("onecommand");
                }
            }else
            {
                MessageBox.Show("Please enter command");
            }
            
        }

        private void encrypt40()
        {
            remarkDB = "encrypt40";
            rxCMconfig = "9E";
            rxDataconfig = "0062";
            lengthConfig = 13;
            lengthCRC = 4;
            if (flg == 0)
            {
                ConfigKey();
                waitSend();
                rawreciveDB = curval;
                keyDB = "";
                insertDB(sendDB, reciveDB, keyDB, rawsendDB, rawreciveDB, remarkDB);
                UpdateTable(ds, rxData, curval);
            }
            else
            {
                return;
            }
        }
        private void radioButton1_Click(object sender, EventArgs e)
        {
            workingThread("encrypt40");
            statuswork = true;
            if (!checkDataReciveChip(curval))
                MessageBox.Show("Fail!! \nPlease try agin.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Encrypt 40 Bit");
            workThread.Abort();
        }

        private void encrypt80()
        {
            remarkDB = "encrypt80";
            rxCMconfig = "9E";
            rxDataconfig = "1062";
            lengthConfig = 13;
            lengthCRC = 4;
            if (flg == 0)
            {
                ConfigKey();
                waitSend();
                rawreciveDB = curval;
                keyDB = "";
                insertDB(sendDB, reciveDB, keyDB, rawsendDB, rawreciveDB, remarkDB);
                UpdateTable(ds, rxData, curval);
            }
            else
            {
                return;
            }
        }
        private void radioButton2_Click(object sender, EventArgs e)
        {
            workingThread("encrypt80");
            statuswork = true;
            if (!checkDataReciveChip(curval))
                MessageBox.Show("Fail!! \nPlease try agin.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Encrypt 80 Bit");
            workThread.Abort();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort1.Close();
            Application.Exit();
        }

        int c = 1;
        private void chkRandom_Click(object sender, EventArgs e)
        {
            if (c == 1)
            {
                pnlSetRan.Visible = true;
                c = 0;
            }
            else
            {
                pnlSetRan.Visible = false;
                c = 1;
            }
        }
        
        Form3 f3 = new Form3();
        private void btLoadCSV_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tableLoad = new DataTable();
                OpenFileDialog fdlg = new OpenFileDialog();
                fdlg.Title = "Select file";
                fdlg.InitialDirectory = @"c:\";
                fdlg.Filter = "Text and CSV Files(*.txt, *.csv)|*.txt;*.csv|Text Files(*.txt)|*.txt|CSV Files(*.csv)|*.csv|All Files(*.*)|*.*";
                fdlg.FilterIndex = 1;
                fdlg.RestoreDirectory = true;
                if (fdlg.ShowDialog() == DialogResult.OK)
                {
                    string[] raw_text = System.IO.File.ReadAllLines(fdlg.FileName);
                    string[] data_col = null;
                    int x = 0;
                    foreach (string text_line in raw_text)
                    {
                        data_col = text_line.Split(',');
                        if (x == 0)
                        {
                            //header
                            for (int i = 0; i <= data_col.Count() - 1; i++)
                            {
                                tableLoad.Columns.Add(data_col[i]);
                            }
                            x++;
                        }
                        else
                        {
                            //data
                            tableLoad.Rows.Add(data_col);
                        }
                    }
                    if (f3.lblFileStatus.Text == "false")
                    {
                        f3 = new Form3();
                        f3.Show();
                        f3.Text = fdlg.FileName;
                        f3.dataGridView1.DataSource = tableLoad;
                    }
                    else
                    {
                        f3.Close();
                        f3 = new Form3();
                        f3.Show();
                        f3.Text = fdlg.FileName;
                        f3.dataGridView1.DataSource = tableLoad;
                    }
                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }

        bool statuuSaveDB = true;
        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!statuuSaveDB)
                {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM " + table;
                    cmd.ExecuteNonQuery();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
                    da.Update(ds, "tblArcana");
                    con.Close();

                    MessageBox.Show("!--Save to Database Success--!");
                    loadDB();
                    statuuSaveDB = true;
                    btSave.Text = "Save to Database";
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (!statuuSaveDB)
                {
                    DialogResult result = MessageBox.Show("Want to save your changes to Database?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.Yes)
                    {
                        con.Open();
                        MySqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT * FROM " + table;
                        cmd.ExecuteNonQuery();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
                        da.Update(ds, "tblArcana");
                        con.Close();

                        MessageBox.Show("!--Save to Database Success--!");
                        //loadDB();
                        statuuSaveDB = true;
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }

        private void tbSkey_TextChanged(object sender, EventArgs e)
        {
            (dgrDatabase.DataSource as DataTable).DefaultView.RowFilter = string.Format("keyconfig LIKE '%{0}%' AND send LIKE '%{1}%' AND remark LIKE '%{2}%' AND datetime LIKE '%{3}%'", tbSkey.Text, tbSsend.Text, comboSremark.Text, dateTimePicker1.Text);
        }

        private void tbSsend_TextChanged(object sender, EventArgs e)
        {
            (dgrDatabase.DataSource as DataTable).DefaultView.RowFilter = string.Format("keyconfig LIKE '%{0}%' AND send LIKE '%{1}%' AND remark LIKE '%{2}%' AND datetime LIKE '%{3}%'", tbSkey.Text, tbSsend.Text, comboSremark.Text, dateTimePicker1.Text);
        }

        private void comboSremark_SelectedIndexChanged(object sender, EventArgs e)
        {
            (dgrDatabase.DataSource as DataTable).DefaultView.RowFilter = string.Format("keyconfig LIKE '%{0}%' AND send LIKE '%{1}%' AND remark LIKE '%{2}%' AND datetime LIKE '%{3}%'", tbSkey.Text, tbSsend.Text, comboSremark.Text, dateTimePicker1.Text);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            (dgrDatabase.DataSource as DataTable).DefaultView.RowFilter = string.Format("keyconfig LIKE '%{0}%' AND send LIKE '%{1}%' AND remark LIKE '%{2}%' AND datetime LIKE '%{3}%'", tbSkey.Text, tbSsend.Text, comboSremark.Text, dateTimePicker1.Text);
        }

        private void btSaveCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdl = new SaveFileDialog();
            sfdl.Filter = "CSV Files(*.csv)|*.csv|Text Files(*.txt)|*.txt";
            if (sfdl.ShowDialog() == DialogResult.OK)
            {
                string filename = sfdl.FileName;
                writeCSV(dgrDatabase, filename);
            }
        }

        private void tbKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!OnlyHexInString(ch.ToString()) && ch != 8)
            {
                MessageBox.Show("Please enter HEXIMAL type");
                e.Handled = true;
            }
        }

        private void tbCommand_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!OnlyHexInString(ch.ToString()) && ch != 8)
            {
                MessageBox.Show("Please enter HEXIMAL type");
                e.Handled = true;
            }
        }

        private void tbData_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!OnlyHexInString(ch.ToString()) && ch != 8)
            {
                MessageBox.Show("Please enter HEXIMAL type");
                e.Handled = true;
            }
        }

        private void tbSsend_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!OnlyHexInString(ch.ToString()) && ch != 8 && ch != 32)
            {
                MessageBox.Show("Please enter HEXIMAL type");
                e.Handled = true;
            }
        }

        private void tbSkey_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!OnlyHexInString(ch.ToString()) && ch != 8 && ch != 32)
            {
                MessageBox.Show("Please enter HEXIMAL type");
                e.Handled = true;
            }
        }

        //Recive reader
        string curval;
        string strBuffer;
        //status recive data chip
        bool statusRecive = true;
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (!serialPort1.IsOpen) return;

            int dataLength = serialPort1.BytesToRead;
            byte[] buffer = new byte[dataLength];
            serialPort1.Read(buffer, 0, dataLength);

            strBuffer += ByteArrayToString(buffer);
            //Recive all 17 byte
            string strtemp = string.Empty;
            if (strBuffer.Length >= 34)
            {
                curval = strBuffer.Substring(0, 34);
                if (strBuffer.Length == 34)
                {
                    strBuffer = string.Empty;
                    statusRecive = true;
                }
                else
                {
                    //MessageBox.Show("Fail");
                    strBuffer = string.Empty;
                    statusRecive = false;
                    //strBuffer = strBuffer.Substring(34, strBuffer.Length - 34);
                }
                reciveDB = strResponse(curval);
                flg = 1;
            }
        }

        Thread workThread = null;
        bool statuswork = true;
        private void workingThread(string mode)
        {
            statuswork = false;
            btSave.Text = "Save to Database*";
            if (mode == "random")
            {
                workThread = new Thread(new ThreadStart(sendingRandom));
            }
            else if (mode == "setkey80")
            {
                workThread = new Thread(new ThreadStart(setting80bitKey));
            }
            else if (mode == "setkey40")
            {
                workThread = new Thread(new ThreadStart(setting40bitKey));
            }
            else if (mode == "onecommand")
            {
                workThread = new Thread(new ThreadStart(sendingOneCommand));
            }
            else if (mode == "encrypt40")
            {
                workThread = new Thread(new ThreadStart(encrypt40));
            }
            else if (mode == "encrypt80")
            {
                workThread = new Thread(new ThreadStart(encrypt80));
            }
            else if (mode == "loadCSV")
            {
                workThread = new Thread(new ThreadStart(loadingCSV));
            }
            statuuSaveDB = false;
            workThread.IsBackground = true;
            pnlKey.Enabled = false;
            pnlEncrypt.Enabled = false;
            btLoadCSV.Enabled = false;
            workThread.Start();
        }

        delegate void StringParameterDelegate(DataSet ds, string rxData, string curval);
        private void UpdateTable(DataSet ds, string rxData, string curval)
        {
            try
            {
                if (InvokeRequired)
                {
                    // We're not in the UI thread, so we need to call BeginInvoke
                    BeginInvoke(new StringParameterDelegate(UpdateTable), new object[] { ds, rxData, curval });
                    return;
                }

                // show status working
                if (statuswork)
                {
                    pictureBox1.Visible = false;
                    pnlKey.Enabled = true;
                    pnlEncrypt.Enabled = true;
                    btLoadCSV.Enabled = true;
                }
                else
                {
                    pictureBox1.Visible = true;
                }

                //Processchang UI
                tbData.Text = rxData;
                tbResponse.Text = strResponse(curval);
                //update data gridview
                dgrDatabase.DataSource = ds.Tables["tblArcana"];
                //set below scrollbar
                //dgrDatabase.FirstDisplayedCell = dgrDatabase.Rows[dgrDatabase.Rows.Count - 1].Cells[0];
                //sort new data on top
                if (dgrDatabase.RowCount > 0)
                {
                    dgrDatabase.Sort(dgrDatabase.Columns[0], ListSortDirection.Descending);
                    //set top scrollbar
                    dgrDatabase.FirstDisplayedCell = dgrDatabase.Rows[0].Cells[0];
                    //dgrDatabase.Refresh();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return;
            }
        }

        private void sendingRandom()
        {
            for (int i = 0; i < trimes; i++)
            {
                rxCM = tbCommand.Text;
                rxData = rand();
                //tbData.Text = rxData;
                SendData();
                waitSend();
                ///////////////////////////////////////
                //tbResponse.Text = strResponse(curval);
                rawreciveDB = curval;
                insertDB(sendDB, reciveDB, keyDB, rawsendDB, rawreciveDB, remarkDB);
                UpdateTable(ds, rxData, curval);
                ///////////////////////////////////////
            }
            if (!checkDataReciveChip(curval))
                MessageBox.Show("Fail!! \nPlease try agin.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            statuswork = true;
            workThread.Abort();
        }

        private void sendingOneCommand()
        {
            SendData();
            waitSend();
            //tbResponse.Text = strResponse(curval);
            rawreciveDB = curval;
            insertDB(sendDB, reciveDB, keyDB, rawsendDB, rawreciveDB, remarkDB);
            UpdateTable(ds, rxData, curval);
            statuswork = true;
            if (!checkDataReciveChip(curval))
                MessageBox.Show("Fail!! \nPlease try agin.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            workThread.Abort();
        }

        private void setting80bitKey()
        {
            set80bitKey(tbKey.Text);
            statuswork = true;
            if (!checkDataReciveChip(curval))
                MessageBox.Show("Fail!! \nPlease try agin.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Setting 80bit key success");
            workThread.Abort();
        }

        private void setting40bitKey()
        {
            set40bitKey(tbKey.Text);
            statuswork = true;
            if (!checkDataReciveChip(curval))
                MessageBox.Show("Fail!! \nPlease try agin.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Setting 40bit key success");
            workThread.Abort();
        }

        private void loadingCSV()
        {
            for (int i = 0; i < f3.dataGridView1.RowCount; i++)
            {
                if (tempKey != f3.dataGridView1.Rows[i].Cells[0].Value.ToString())
                {
                    tempKey = f3.dataGridView1.Rows[i].Cells[0].Value.ToString();
                    if (tempKey.Length == 20)
                    {
                        set80bitKey(tempKey);
                    }else if (tempKey.Length == 10)
                    {
                        set40bitKey(tempKey);
                    }
                }

                if (tempEncrypt != f3.dataGridView1.Rows[i].Cells[3].Value.ToString())
                {
                    tempEncrypt = f3.dataGridView1.Rows[i].Cells[3].Value.ToString();
                    if (tempEncrypt == "40 bit")
                    {
                        encrypt40();
                    }
                    else if (tempEncrypt == "80 bit")
                    {
                        encrypt80();
                    }
                }

                remarkDB = "load .CSV";
                rxCM = f3.dataGridView1.Rows[i].Cells[2].Value.ToString();
                rxData = f3.dataGridView1.Rows[i].Cells[1].Value.ToString();

                SendData();
                waitSend();
                rawreciveDB = curval;
                insertDB(sendDB, reciveDB, keyDB, rawsendDB, rawreciveDB, remarkDB);
                UpdateTable(ds, rxData, curval);
            }
            statuswork = true;
            workThread.Abort();
        }

        private void set80bitKey(string rxDataKey)
        {
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    //set 80 bit befor set key
                    remarkDB = "encrypt80";
                    rxCMconfig = "9E";
                    rxDataconfig = "1062";
                    lengthConfig = 13;
                    lengthCRC = 4;
                }
                else
                {
                    remarkDB = "set key";
                    rxCMconfig = "88";
                    rxDataconfig = rxDataKey;
                    lengthConfig = 21;
                    lengthCRC = 12;
                }

                if (flg == 0)
                {
                    ConfigKey();
                    waitSend();
                    rawreciveDB = curval;
                    insertDB(sendDB, reciveDB, keyDB, rawsendDB, rawreciveDB, remarkDB);
                    UpdateTable(ds, rxData, curval);
                }
            }
        }

        private void set40bitKey(string rxDataKey)
        {
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    //set 40 bit befor set key
                    remarkDB = "encrypt40";
                    rxCMconfig = "9E";
                    rxDataconfig = "0062";
                    lengthConfig = 13;
                    lengthCRC = 4;
                }
                else
                {
                    remarkDB = "set key";
                    rxCMconfig = "88";
                    rxDataconfig = rxDataKey;
                    lengthConfig = 16;
                    lengthCRC = 7;
                }

                if (flg == 0)
                {
                    ConfigKey();
                    waitSend();
                    rawreciveDB = curval;
                    insertDB(sendDB, reciveDB, keyDB, rawsendDB, rawreciveDB, remarkDB);
                    UpdateTable(ds, rxData, curval);
                }
            }
        }

        int flg = 0;
        private void waitSend()
        {
            while (true)
            {
                if (flg == 1)
                {
                    flg = 0;
                    break;
                }
            }
        }

        //send data config
        string rxCMconfig = string.Empty;
        string rxDataconfig = string.Empty;
        int lengthConfig = 0;
        int lengthCRC = 0;
        byte[] dataConfig;
        private void ConfigKey()
        {
            dataConfig = new byte[lengthConfig];
            //byte header
            dataConfig[0] = 0xAA;
            //byte length command
            int x = dataConfig.Length - 2;
            string strLength = x.ToString("X");
            byte Length = Convert.ToByte(strLength, 16);
            dataConfig[1] = Length;
            //byte manual command
            dataConfig[2] = 0x45;
            //byte protocol
            dataConfig[3] = 0x01;
            //byte length tx
            //|command||selective||data||CRC|
            int l = (1 + 1 + (rxDataconfig.Length / 2) + 2) * 8;
            string templ = l.ToString("X");
            byte lengthTx = Convert.ToByte(templ, 16);
            dataConfig[4] = lengthTx;
            //byte length rx
            dataConfig[5] = 0x48;
            //byte command setting chip
            byte[] tempCM = StringToByteArray(rxCMconfig);
            dataConfig[6] = tempCM[0];
            //byte selective
            dataConfig[7] = 0xc0;

            //Pre save to Database
            if (rxDataconfig != "1062" && rxDataconfig != "0062")
                keyDB = whitespace(rxDataconfig);
            //byte Key
            byte[] keybyte = StringToByteArray(rxDataconfig);
            for (int j = 0; j < keybyte.Length; j++)
            {
                dataConfig[j + 8] = keybyte[j];
            }

            //calculate CRC
            byte[] tempCRC = new byte[lengthCRC];
            for (int i = 0; i < lengthCRC; i++)
            {
                tempCRC[i] = dataConfig[i + 6];
            }
            string strCRC = CalcCRC16(ByteArrayToString(tempCRC));
            byte[] crc = StringToByteArray(strCRC);

            //byte CRC1
            dataConfig[dataConfig.Length - 3] = crc[0];

            //byte CRC2
            dataConfig[dataConfig.Length - 2] = crc[1];

            //byte Checksum
            byte chkSum = CalculateChecksum(dataConfig, dataConfig.Length - 1);
            dataConfig[dataConfig.Length - 1] = chkSum;

            byte[] temp = new byte[dataConfig.Length - 7];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = dataConfig[i + 6];
            }
            sendDB = whitespace(ByteArrayToString(temp));
            //Send to Reader
            if (serialPort1.IsOpen)
            {
                rawsendDB = ByteArrayToString(dataConfig);
                serialPort1.Write(dataConfig, 0, dataConfig.Length);
            }
            else
                return;
        }

        //Data send to Reader
        string rxCM = string.Empty;
        string rxData = string.Empty;
        byte[] datasend;
        private void SendData()
        {
            //byte header
            byte header = Convert.ToByte("AA", 16);
            //byte data
            byte[] ttbyte = StringToByteArray(rxData);
            //byte command
            byte tbcm = Convert.ToByte(rxCM, 16);
            //Total length command  
            //|Data||header||total length||manual cm||protocol||tx length||rx length||cm chip||check sum|
            int la = ttbyte.Length + (1 + 1 + 1 + 1 + 1 + 1 + 1 + 1);


            int lengthOfsend = la - 2;
            string strla = lengthOfsend.ToString("X");
            byte cmlength = Convert.ToByte(strla, 16);

            //convert length command byte to bit
            int txLengthCM = (ttbyte.Length + 1) * 8;
            string strtx = txLengthCM.ToString("X");
            byte txLength = Convert.ToByte(strtx, 16);

            datasend = new byte[la];
            //add header to datasend
            datasend[0] = header;
            //add total length to datasend
            datasend[1] = cmlength;
            //add manual command to datasend
            datasend[2] = 0x45;
            //add protocol to datasend
            datasend[3] = 0x01;
            //add length tx of command chip and data to datasend
            datasend[4] = txLength;
            //add length rx of chip to datasend
            datasend[5] = 0x48;
            //add command chip to datasend
            datasend[6] = tbcm;

            for (int j = 0; j < ttbyte.Length; j++)
            {
                datasend[j + 7] = ttbyte[j];
            }
            byte chkSum = CalculateChecksum(datasend, datasend.Length - 1);
            datasend[datasend.Length - 1] = chkSum;

            //Pre save to Database
            byte[] temp = new byte[datasend.Length - 7];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = datasend[i + 6];
            }
            sendDB = whitespace(ByteArrayToString(temp));

            if (serialPort1.IsOpen)
            {
                //Pre save to Database
                rawsendDB = ByteArrayToString(datasend);
                serialPort1.Write(datasend, 0, datasend.Length);
            }
            else
                return;
        }

        private string strResponse(string temp)
        {
            string response = string.Empty;
            string rxStr = string.Empty;
            string[] strFnc;
            strFnc = SubStr(temp);
            for (int k = 0; k < strFnc.Length; k++)
            {
                rxStr = rxStr + strFnc[k] + " ";
                if (k > 6 && k != strFnc.Length - 1)
                {
                    response = response + strFnc[k] + " ";
                }
            }
            return response;
        }

        private string whitespace(string temp)
        {
            string str = string.Empty;
            string[] strFnc;
            strFnc = SubStr(temp);
            for (int k = 0; k < strFnc.Length; k++)
            {
                str = str + strFnc[k] + " ";
            }
            return str;
        }

        public static string[] SubStr(string str)
        {
            string[] text2 = { };
            try
            {
                text2 = new string[str.Length / 2];
                for (int i = 0; i < str.Length; i = i + 2)
                {
                    text2[i / 2] = str.Substring(i, 2);
                }

            } catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return text2;
        }

        public static byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[(NumberChars / 2)];
            try
            {
                for (int i = 0; i < NumberChars; i += 2)
                {
                    string sub = hex.Substring(i, 2);
                    //Console.Write(sub);
                    bytes[i / 2] = Convert.ToByte(sub, 16);
                }
            } catch (Exception er)
            {
                MessageBox.Show("Data dose not format!! \n Please try agin.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return bytes;
        }

        public static string ByteArrayToString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }

        public static byte CalculateChecksum(byte[] _PacketData, int PacketLength)
        {
            Byte _CheckSumByte = 0x00;
            for (int i = 0; i < PacketLength; i++)
                _CheckSumByte ^= _PacketData[i];
            return _CheckSumByte;
        }

        public string CalcCRC16(string strInput)
        {
            ushort crc = 0x89EC;
            byte[] data = StringToByteArray(strInput);
            for (int i = 0; i < data.Length; i++)
            {
                crc ^= (ushort)(data[i] << 8);
                for (int j = 0; j < 8; j++)
                {
                    if ((crc & 0x8000) > 0)
                        crc = (ushort)((crc << 1) ^ 0x1021);
                    else
                        crc <<= 1;
                }
            }
            return crc.ToString("X4");
        }

        Random random = new Random();
        string[] myStrings = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
        public string randdombit()
        {
            string s;
            int rnd = random.Next(0, myStrings.Length);
            s = myStrings[rnd];
            return s;
        }

        public string rand()
        {
            string[] randbit;
            string rand = "";
            randbit = new string[10];

            if (string.IsNullOrWhiteSpace(tbRan1.Text) || chkRan1.Checked == false)
            {
                randbit[0] = randdombit();
                //tbRan1.Text = randbit[0];
            }
            else
            {
                randbit[0] = tbRan1.Text;
            }
            if (string.IsNullOrWhiteSpace(tbRan2.Text) || chkRan2.Checked == false)
            {
                randbit[1] = randdombit();
                //tbRan2.Text = randbit[1];
            }
            else
            {
                randbit[1] = tbRan2.Text;
            }
            if (string.IsNullOrWhiteSpace(tbRan3.Text) || chkRan3.Checked == false)
            {
                randbit[2] = randdombit();
                //tbRan3.Text = randbit[2];
            }
            else
            {
                randbit[2] = tbRan3.Text;
            }
            if (string.IsNullOrWhiteSpace(tbRan4.Text) || chkRan4.Checked == false)
            {
                randbit[3] = randdombit();
                //tbRan4.Text = randbit[3];
            }
            else
            {
                randbit[3] = tbRan4.Text;
            }
            if (string.IsNullOrWhiteSpace(tbRan5.Text) || chkRan5.Checked == false)
            {
                randbit[4] = randdombit();
                //tbRan5.Text = randbit[4];
            }
            else
            {
                randbit[4] = tbRan5.Text;
            }
            if (string.IsNullOrWhiteSpace(tbRan6.Text) || chkRan6.Checked == false)
            {
                randbit[5] = randdombit();
                //tbRan6.Text = randbit[5];
            }
            else
            {
                randbit[5] = tbRan6.Text;
            }
            if (string.IsNullOrWhiteSpace(tbRan7.Text) || chkRan7.Checked == false)
            {
                randbit[6] = randdombit();
                //tbRan7.Text = randbit[6];
            }
            else
            {
                randbit[6] = tbRan7.Text;
            }
            if (string.IsNullOrWhiteSpace(tbRan8.Text) || chkRan8.Checked == false)
            {
                randbit[7] = randdombit();
                //tbRan8.Text = randbit[7];
            }
            else
            {
                randbit[7] = tbRan8.Text;
            }
            if (string.IsNullOrWhiteSpace(tbRan9.Text) || chkRan9.Checked == false)
            {
                randbit[8] = randdombit();
                //tbRan9.Text = randbit[8];
            }
            else
            {
                randbit[8] = tbRan9.Text;
            }
            if (string.IsNullOrWhiteSpace(tbRan10.Text) || chkRan10.Checked == false)
            {
                randbit[9] = randdombit();
                //tbRan10.Text = randbit[9];
            }
            else
            {
                randbit[9] = tbRan10.Text;
            }

            for (int i = 0; i < 10; i++)
            {
                rand = rand + randbit[i];
            }
            return rand;
        }

        private void insertDB(string send, string recive, string key, string raw_send, string raw_recive, string remark)
        {
            try
            {
                //string sql = "SELECT * FROM tblArcana";
                //SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                //da.Fill(ds, "tblArcana");
                
                DataRow dr = ds.Tables["tblArcana"].NewRow();
                index++;
                dr["id"] = index;
                dr["datetime"] = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
                dr["send"] = send.ToUpper();
                dr["recive"] = recive.ToUpper();
                dr["keyconfig"] = key.ToUpper();
                dr["raw_send"] = raw_send.ToUpper();
                dr["raw_recive"] = raw_recive.ToUpper();
                dr["remark"] = remark;

                ds.Tables["tblArcana"].Rows.Add(dr);
                //Realtime show Form2 datagridview (if haveThread)
                //f2.dataGridView1.DataSource = ds.Tables["tblArcana"];
                //SqlCommandBuilder cb = new SqlCommandBuilder(da);
                //da.Update(ds, "tblArcana");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        int index;
        private void loadDB()
        {
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM " + table;
                cmd.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds, "tblArcana");

                dgrDatabase.DataSource = ds.Tables["tblArcana"];

                // set width cell
                // id
                dgrDatabase.Columns[0].Width = 40;
                // datetime
                dgrDatabase.Columns[1].Width = 70;
                //dgrDatabase.Columns[1].DefaultCellStyle.Format = "MM/dd/yyyy";
                // send
                dgrDatabase.Columns[2].Width = 150;
                // recive
                dgrDatabase.Columns[3].Width = 200;
                // keyconfig
                dgrDatabase.Columns[4].Width = 220;
                // raw_send
                dgrDatabase.Columns[5].Width = 150;
                // raw_recive
                dgrDatabase.Columns[6].Width = 150;
                // raw_remark
                dgrDatabase.Columns[7].Width = 100;

                if (dgrDatabase.RowCount > 0)
                {
                    index = Int32.Parse(dgrDatabase.Rows[dgrDatabase.Rows.Count - 1].Cells[0].Value.ToString());
                }
                //set below scorllbar
                //dgrDatabase.FirstDisplayedCell = dgrDatabase.Rows[dgrDatabase.Rows.Count - 1].Cells[0];
                dgrDatabase.Sort(dgrDatabase.Columns[0], ListSortDirection.Descending);
                con.Close();
            } catch (Exception er)
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
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
                return;
            }

        }

        //Check Hex string
        private bool OnlyHexInString(string test)
        {
            // For C-style hex notation (0xFF) you can use @"\A\b(0[xX])?[0-9a-fA-F]+\b\Z"
            return System.Text.RegularExpressions.Regex.IsMatch(test, @"\A\b[0-9a-fA-F]+\b\Z");
        }
        
        //check data recive chip
        private bool checkDataReciveChip(string curval)
        {
            char c1 = curval[6];
            char c2 = curval[7];
            if (c1 == '0' && c2 == '0')
                return true;
            else
                return false;
        }
    }
}