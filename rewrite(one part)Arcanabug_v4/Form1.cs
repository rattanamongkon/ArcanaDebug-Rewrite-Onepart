using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Data.SqlClient;

namespace rewrite_one_part_Arcanabug_v4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\rattanamongkon\documents\visual studio 2015\Projects\rewrite(one part)Arcanabug_v4\rewrite(one part)Arcanabug_v4\Database1.mdf;Integrated Security=True";

        //status save remark database
        string sendDB = string.Empty;
        string reciveDB = string.Empty;
        string keyDB = string.Empty;
        string rawsendDB = string.Empty;
        string rawreciveDB = string.Empty;
        string remarkDB = string.Empty;

        private void Form1_Load(object sender, EventArgs e)
        {
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
            //f2.Show();
        }

        private void comboPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPort.SelectedIndex > -1)
            {
                btPnlKey.Enabled = true;
            }
        }

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
                    //set 80 bit encrypt befor set key
                    for (int i = 0; i < 2; i++)
                    {
                        if (i == 0)
                        {
                            remarkDB = "encrypt80";
                            rxCMconfig = "9E";
                            rxDataconfig = "1062";
                            lengthConfig = 13;
                            lengthCRC = 4;
                        } else
                        {
                            remarkDB = "set key";
                            rxCMconfig = "88";
                            rxDataconfig = tbKey.Text;
                            lengthConfig = 21;
                            lengthCRC = 12;
                        }

                        if (flg == 0)
                        {
                            ConfigKey();
                            waitSend();
                            rawreciveDB = curval;
                            insertDB(sendDB, reciveDB, keyDB, rawsendDB, rawreciveDB, remarkDB);
                        } else
                        {
                            MessageBox.Show("Please try again");
                        }

                        //check key
                        if (i == 1)
                        {
                            MessageBox.Show("Setting key success" + curval);
                            pnlEncrypt.Enabled = true;
                            groupBox1.Enabled = true;
                            pnlResponse.Enabled = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter key");
                }

            } catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }

        Form2 f2 = new Form2();
        int statusForm = 0;
        private void btPnlResponse_Click(object sender, EventArgs e)
        {
            int trimes;
            //Load .CSV
            if (f3.lblFileStatus.Text == "true")
            {
                if (f3.dataGridView1.RowCount > 1)
                {
                    remarkDB = "load .CSV";
                    try
                    {
                        for (int i = 0; i < f3.dataGridView1.RowCount - 1; i++)
                        {
                            rxCM = f3.dataGridView1.Rows[i].Cells[0].Value.ToString();
                            rxData = f3.dataGridView1.Rows[i].Cells[1].Value.ToString();

                            SendData();
                            waitSend();
                            rawreciveDB = curval;
                            insertDB(sendDB, reciveDB, keyDB, rawsendDB, rawreciveDB, remarkDB);
                        }
                        if (f2.statusForm.Text == "false" || statusForm == 0)
                        {
                            f2 = new Form2();
                            f2.Show();
                            statusForm = 1;
                        }
                        else
                        {
                            f2.Close();
                            f2 = new Form2();
                            f2.Show();
                        }
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
                        for (int i = 0; i < trimes; i++)
                        {
                            rxCM = tbCommand.Text;
                            rxData = rand();
                            tbData.Text = rxData;
                            SendData();
                            waitSend();
                            ///////////////////////////////////////
                            tbResponse.Text = strResponse(curval);
                            rawreciveDB = curval;
                            insertDB(sendDB, reciveDB, keyDB, rawsendDB, rawreciveDB, remarkDB);
                            ///////////////////////////////////////
                        }
                        if (f2.statusForm.Text == "false" || statusForm == 0)
                        {
                            f2 = new Form2();
                            f2.Show();
                            statusForm = 1;
                        }
                        else
                        {
                            f2.Close();
                            f2 = new Form2();
                            f2.Show();
                        }
                    }
                }
                else
                {
                    remarkDB = "one command";
                    rxCM = tbCommand.Text;
                    rxData = tbData.Text;

                    if (flg == 0)
                    {
                        SendData();
                        waitSend();
                        tbResponse.Text = strResponse(curval);
                        rawreciveDB = curval;
                        insertDB(sendDB, reciveDB, keyDB, rawsendDB, rawreciveDB, remarkDB);
                        if (f2.statusForm.Text == "false" || statusForm == 0)
                        {
                            f2 = new Form2();
                            f2.Show();
                            statusForm = 1;
                        }
                        else
                        {
                            f2.Close();
                            f2 = new Form2();
                            f2.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please try agian");
                    }
                }
            }else
            {
                MessageBox.Show("Please enter command");
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
                    return;
                }
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
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
                insertDB(sendDB, reciveDB, keyDB, rawsendDB, rawreciveDB, remarkDB);
                MessageBox.Show("40 bit" + curval);
            }
            else
            {
                MessageBox.Show("Please try again");
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
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
                insertDB(sendDB, reciveDB, keyDB, rawsendDB, rawreciveDB, remarkDB);
                MessageBox.Show("80 bit" + curval);
            } else
            {
                MessageBox.Show("Please try again");
            }
        }

        //Recive reader
        string curval;
        string strBuffer;
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (!serialPort1.IsOpen) return;

            int dataLength = serialPort1.BytesToRead;
            byte[] buffer = new byte[dataLength];
            serialPort1.Read(buffer, 0, dataLength);

            strBuffer += ByteArrayToString(buffer);
            //Recive all 17 byte
            if (strBuffer.Length >= 34)
            {
                curval = strBuffer.Substring(0, 34);
                if (strBuffer.Length == 34)
                    strBuffer = string.Empty;
                else
                    strBuffer = strBuffer.Substring(34, strBuffer.Length - 34);
            }
            reciveDB = strResponse(curval);
            flg = 1;
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
            for (int i = 0; i < NumberChars; i += 2)
            {
                string sub = hex.Substring(i, 2);
                //Console.Write(sub);
                bytes[i / 2] = Convert.ToByte(sub, 16);
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
            string sql = "SELECT * FROM tblDB";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            da.Fill(ds, "DB");

            DataRow dr = ds.Tables["DB"].NewRow();
            dr["datetime"] = DateTime.Now.ToString();
            dr["send"] = send;
            dr["recive"] = recive;
            dr["keyconfig"] = key;
            dr["raw_send"] = raw_send;
            dr["raw_recive"] = raw_recive;
            dr["remark"] = remark;

            ds.Tables["DB"].Rows.Add(dr);


            //sql = "SELECT * FROM tblDB";
            //da = new SqlDataAdapter(sql, cn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "DB");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort1.Close();
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
        int statusForm3 = 0;
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
                    if (f3.lblFileStatus.Text == "false" || statusForm == 0)
                    {
                        f3 = new Form3();
                        f3.Show();
                        f3.Text = fdlg.FileName;
                        f3.dataGridView1.DataSource = tableLoad;
                        statusForm3 = 1;
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

            } catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
        }
    }
}
