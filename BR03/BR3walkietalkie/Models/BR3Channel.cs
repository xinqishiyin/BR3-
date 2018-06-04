using BR3walkietalkie.Class;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BR3walkietalkie.Models
{
    public partial class BR3Channel : Form
    {
        public static DataTable dt = new DataTable();
        public bool isChange = false;

        string FileString = "";

        public BR3Channel()
        {
            InitializeComponent();
            

            adItem();
           
            cmbDisplayMode.SelectedIndex = 2;
            txtDisplay.Text = "MIDLAND";
            cmbSquelchLevel.SelectedIndex = 6;
            cmbTXLimit.SelectedIndex = 6;
            cmbShotPress1.SelectedIndex = 1;
            cmbShotPress2.SelectedIndex = 6;
            cmbLongPress1.SelectedIndex = 3;
            //cmbLongPress2.SelectedIndex = 2;
            cmbVoiceLevel.SelectedIndex = 0;
            cmbVoiceDelay.SelectedIndex = 2;
            
            cmbPPT.SelectedIndex = 0;
            cmbStartUpCH.SelectedIndex = 0;
            cmbVoiceAnnouncements.SelectedIndex = 0;
            cmbScanMode.SelectedIndex = 0;
            chkBeepSound.Checked = true;
            chkPowerSaving.Checked = true;
            //cmbFTO.Enabled = false;
          
            //InitializaDatatable();
            //Init();
            this.gridControl1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            //gridControl1.RowsDefaultCellStyle.Font = new Font("Fixedsys", 9, FontStyle.Strikeout);
            this.gridControl1.DataError += delegate (object sender, DataGridViewDataErrorEventArgs e)
            {
                
            };
            isChange = false;

        }
        
        private void BR3Channel_Load(object sender, EventArgs e)
        {
            Type type = gridControl1.GetType();
            System.Reflection.PropertyInfo pi = type.GetProperty("DoubleBuffered",
            System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            pi.SetValue(gridControl1, true, null);
            
            cmbFTO.SelectedIndex = 0;
            
        }
        private void InitializaDatatable()
        {
            dt.Clear();
            dt.TableName = "BR3";
            if (dt.Columns.Count == 0)
            {
                for (int i = 0; i < 13; i++)
                {
                    dt.Columns.Add(Enum.Parse(typeof(BR3), i.ToString()).ToString());
                }
            }
            for (int i = 0; i < 99; i++)
            {
                DataRow dr = dt.NewRow();
                dr[ChannelBR3.Channel] = i + 1;
                dt.Rows.Add(dr);
            }
            ShowData();
        }
        public void ShowData()
        {
           
            gridControl1.DataSource = dt;
        }

        private void Init()
        {
            string path = Environment.CurrentDirectory + "\\BR3.dat";
            if (!File.Exists(path))
            {
                //InitializaDatatable();
                return;
            }
            string obj = Common.Common.Deserialize(path);
            string str =Common.Encryption.DES_Decrypt(obj, "11111111");
            string[] see;
            if (str.Substring(0, 3) == "BR3")
            {
                str = str.Substring(3);
                see = str.Split('|');
                dt = Common.Common.StringToDataTable(see[0]);
                chkBeepSound.Checked = Convert.ToBoolean(see[1]);
                txtDisplay.Text = see[2];
                cmbDisplayMode.SelectedIndex = Convert.ToInt32(see[3]);
                cmbFTO.SelectedIndex = Convert.ToInt32(see[4]);
                cmbLongPress1.SelectedIndex = Convert.ToInt32(see[5]);
                cmbShotPress2.SelectedIndex = Convert.ToInt32(see[6]);
                chkPowerSaving.Checked = Convert.ToBoolean(see[7]);
                cmbPPT.SelectedIndex = Convert.ToInt32(see[8]);
                cmbScanMode.SelectedIndex = Convert.ToInt32(see[9]);
                cmbShotPress1.SelectedIndex = Convert.ToInt32(see[10]);
                cmbShotPress2.SelectedIndex = Convert.ToInt32(see[11]);
                cmbSquelchLevel.SelectedIndex = Convert.ToInt32(see[12]);
                cmbTXLimit.SelectedIndex = Convert.ToInt32(see[13]);
                txtTXStart.Text = see[14];
                txtTXStop.Text = see[15];
                cmbVoiceAnnouncements.SelectedIndex = Convert.ToInt32(see[16]);
                cmbVoiceDelay.SelectedIndex = Convert.ToInt32(see[17]);
                cmbVoiceLevel.SelectedIndex = Convert.ToInt32(see[18]);
                cmbStartUpCH.SelectedIndex = Convert.ToInt32(see[19]);
                ShowData();
            }
            else
            {
                MessageBox.Show("Read Fail,Please Select the correct file");
            }
            isChange = false;
        }
        private void adItem()
        {
            #region ChannelItem

            for (int i = 0; i < Class.ChannelItem.countCtcss(); i++)
            {
                CTCSDec.Items.Add(ChannelItem.ctcssItemAdd(i).ToString());
                CTCSEnc.Items.Add(ChannelItem.ctcssItemAdd(i).ToString());
            }

            for (int i = 0; i < ChannelItem.countCtcssN(); i++)
            {
                CTCSDec.Items.Add(ChannelItem.ctcssNItemAdd(i).ToString());
                CTCSEnc.Items.Add(ChannelItem.ctcssNItemAdd(i).ToString());
            }
            for (int i = 0; i < ChannelItem.countCtcssI(); i++)
            {
               CTCSDec.Items.Add(ChannelItem.ctcssIItemAdd(i).ToString());
                CTCSEnc.Items.Add(ChannelItem.ctcssIItemAdd(i).ToString());
            }


            #endregion

            /*****************************************************************************************/

            #region 其他 Item



            TXPower.Items.Add("Low");

            TXPower.Items.Add("High");

            /*****************************************************************************************/


            WN.Items.Add("Narrow");

            WN.Items.Add("Wide");

            /*****************************************************************************************/

            BusyLock.Items.Add("Yes");

            BusyLock.Items.Add("No");
            /*****************************************************************************************/


            Companding.Items.Add("Yes");
            Companding.Items.Add("No");

            PPTID.Items.Add("Yes");
            PPTID.Items.Add("No");

            /*****************************************************************************************/
            Scrambling.Items.Add("Yes");
            Scrambling.Items.Add("No");



            ScanningAdd.Items.Add("Yes");
            ScanningAdd.Items.Add("No");

            Repeater.Items.Add("Yes");
            Repeater.Items.Add("No");

            #endregion
        }


        internal void newBR3Channel()
        {
            InitializaDatatable();
        }
        #region 表单新建打开保存


        internal void OpenBR3Channel()
        {
            if (isChange == true)
            {
                switch (MessageBox.Show("Whether to save the settings ?", "point out", MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Yes:
                        SaveBR3ChannelAs();
                        break;                    
                }
            }
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open";
            ofd.Filter = "Dat|*.dat";
            string[] see;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileString = ofd.FileName;
                string obj = Common.Common.Deserialize(ofd.FileName);
                obj = Common.Common.Deserialize(ofd.FileName);
                string str =Common.Encryption.DES_Decrypt(obj, "11111111");
                str = Common.Encryption.DES_Decrypt(obj, "11111111");
                if (str.Substring(0, 3) == "BR3")
                {
                    str = str.Substring(3);
                    see = str.Split('|');
                    dt = Common.Common.StringToDataTable(see[0]);
                    chkBeepSound.Checked = Convert.ToBoolean(see[1]);
                    txtDisplay.Text = see[2];
                    cmbDisplayMode.SelectedIndex = Convert.ToInt32(see[3]);
                    cmbFTO.SelectedIndexChanged -= cmbFTO_SelectedIndexChanged;
                    cmbFTO.SelectedIndex = Convert.ToInt32(see[4]);
                    cmbFTO.SelectedIndexChanged += cmbFTO_SelectedIndexChanged;
                    cmbLongPress1.SelectedIndex = Convert.ToInt32(see[5]);
                    cmbShotPress2.SelectedIndex = Convert.ToInt32(see[6]);
                    chkPowerSaving.Checked = Convert.ToBoolean(see[7]);
                    cmbPPT.SelectedIndex = Convert.ToInt32(see[8]);
                    cmbScanMode.SelectedIndex = Convert.ToInt32(see[9]);
                    cmbShotPress1.SelectedIndex = Convert.ToInt32(see[10]);
                    cmbShotPress2.SelectedIndex = Convert.ToInt32(see[11]);
                    cmbSquelchLevel.SelectedIndex = Convert.ToInt32(see[12]);
                    cmbTXLimit.SelectedIndex = Convert.ToInt32(see[13]);
                    txtTXStart.Text = see[14];
                    txtTXStop.Text = see[15];
                    cmbVoiceAnnouncements.SelectedIndex = Convert.ToInt32(see[16]);
                    cmbVoiceDelay.SelectedIndex = Convert.ToInt32(see[17]);
                    cmbVoiceLevel.SelectedIndex = Convert.ToInt32(see[18]);
                    cmbStartUpCH.SelectedIndex = Convert.ToInt32(see[19]);
                    ShowData();
                    isChange = false;
                }
                else
                {
                    MessageBox.Show("Read Fail,Please Select the correct file");
                }
            }
        }

        internal void SaveBR3Channel()
        {
            GetWriteData();
            if (FileString=="")
            {
                SaveBR3ChannelAs();
            }
            else
            {
                if (Common.Common.WriteDat(FileString, Common.Encryption.DES_Encryption(getSaveStr(), "11111111")))
                {
                    MessageBox.Show("Save Success !");
                    isChange = false;
                }
                else
                {
                    MessageBox.Show("Save Filed !");
                }
            }
            
        }

        public void SaveBR3ChannelAs()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.AddExtension = true;
            sfd.Title = "BR3 Save As";
            sfd.Filter = "Dat|*.dat";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FileString = sfd.FileName;
                if (Common.Common.WriteDat(sfd.FileName, Common.Encryption.DES_Encryption(getSaveStr(), "11111111")))
                {
                    isChange = false;
                    MessageBox.Show("Save Success !");
                }
                else
                {
                    MessageBox.Show("Save Filed !");
                }
            }
        }
        private string getSaveStr()
        {
            gridControl1.EndEdit();
            GetWriteData();
            
            string str = "BR3" + Common.Common.DataTableToString(dt)
                + "|" + br3.BeepSound.ToString()
                + "|" + br3.Display.ToString()
                + "|" + br3.DisplayMode.ToString()
                + "|" + br3.Fto.ToString()
                + "|" + br3.LongPress1.ToString()
                + "|" + br3.LongPress2.ToString()
                + "|" + br3.PowerSaving.ToString()
                + "|" + br3.Ppt.ToString()
                + "|" + br3.ScanMode.ToString()
                + "|" + br3.ShotPress1.ToString()
                + "|" + br3.ShotPress2.ToString()
                + "|" + br3.SquelchLevel.ToString()
                + "|" + br3.TxLimit.ToString()
                + "|" + br3.TxStart.ToString()
                + "|" + br3.TxStop.ToString()
                + "|" + br3.VoiceAnnouncements.ToString()
                + "|" + br3.VoiceDelay.ToString()
                + "|" + br3.VoiceLevel.ToString()
                + "|" + br3.StartupCh.ToString();
                return str;
          
        }

        #endregion


        #region 读写
        public void readMessage()
        {
            //loading.ShowWaitForm();

            if (!ReadWrite.BR3.connect())
            {
                MessageBox.Show(Common.Common.massage);
                return;
            }
            if (!ReadWrite.BR3.BR3Read())
            {
                MessageBox.Show(Common.Common.massage);
                return;
            }
            this.Invoke(new Action(() =>
            {
                ShowData(ReadWrite.BR3.recive);
            }));
            MainForm.issessce = true;
            Common.PortCommunication.timerSend.Enabled = false;
            Common.PortCommunication.timerSend.Interval = 5;
            Common.PortCommunication.timerSend.Enabled = true;

            Common.Common.massage = "Read complete";
            //MessageBox.Show("Read complete");
            //MainForm.conn.Abort();
        }
        Class.BR3Class br3;
        public void writeMessage()
        {
       
            if (!GetWriteData())
            {
                MainForm.dataerrer = false;
                PortCommunication.timerSend.Interval = 1;
                return;
            }
            if (!ReadWrite.BR3.connect())
            {
                MessageBox.Show(Common.Common.massage);
                return;
            }
            if (!ReadWrite.BR3.BR3Write(br3))
            {
                MessageBox.Show(Common.Common.massage);
                return ;
            }
            MainForm.issessce = true;
            Common.PortCommunication.timerSend.Enabled = false;
            Common.PortCommunication.timerSend.Interval = 5;
            Common.PortCommunication.timerSend.Enabled = true;
            Common.Common.massage = "Write Complete";
            return ;
            //MessageBox.Show("Write complete");
        }


        private void ShowData(string[] reciveData)
        {
            string str = "";
            string[] reciveN;
            dt.Rows.Clear();
            for (int i = 0; i < 99; i++)
            {
                DataRow dr = dt.NewRow();
                dr[ChannelBR3.Channel] = i + 1;
                dt.Rows.Add(dr);
            }
            for (int i = 0; i < 99; i++)
            {

                reciveN = reciveData[i * 2 + 2].Split(' ');
                if (reciveN[7].ToLower() != "ff")
                {
                    dt.Rows[i][ChannelBR3.TXFrequency] = (Convert.ToDouble(reciveN[7]) * 10 + Convert.ToDouble(reciveN[6]) * 0.1 + Convert.ToDouble(reciveN[5]) * 0.001 + Convert.ToDouble(reciveN[4]) * 0.00001).ToString("#0.00000");
                    dt.Rows[i][ChannelBR3.RXFrequency] = (Convert.ToDouble(reciveN[11]) * 10 + Convert.ToDouble(reciveN[10]) * 0.1 + Convert.ToDouble(reciveN[9]) * 0.001 + Convert.ToDouble(reciveN[8]) * 0.00001).ToString("#0.00000");

                    reciveN = reciveData[i * 2 + 3].Split(' ');
                    if (reciveN[4].ToLower() == "ff"|| reciveN[5].ToLower() == "ff")
                    {
                        dt.Rows[i][ChannelBR3.CTCSDec] = "Off";
                    }
                    else if (Common.Common.hexToDec(reciveN[5]) < 8 * 16)
                    {
                        dt.Rows[i][ChannelBR3.CTCSDec] = (Convert.ToDouble(reciveN[5]) * 10 + Convert.ToDouble(reciveN[4]) * 0.1).ToString("#0.0");//reciveN[5]+ reciveN[4];

                    }
                    else if (Common.Common.hexToDec(reciveN[5]) >= 12 * 16)
                    {
                        dt.Rows[i][ChannelBR3.CTCSDec] = "D" + (Convert.ToDouble(Common.Common.hexToDec(reciveN[5]) - 12 * 16)).ToString() + Convert.ToDouble(reciveN[4]).ToString("#00") + "I";//reciveN[5]+ reciveN[4];
                    }
                    else
                    {
                    
                        dt.Rows[i][ChannelBR3.CTCSDec] = "D" + (Convert.ToDouble(Common.Common.hexToDec(reciveN[5]) - 8 * 16)).ToString() + Convert.ToDouble(reciveN[4]).ToString("#00") + "N";
                    }
                    if (reciveN[6].ToLower() == "ff" || reciveN[7].ToLower() == "ff")
                    {
                       
                        dt.Rows[i][ChannelBR3.CTCSEnc] = "Off";
                    }
                    else if (Common.Common.hexToDec(reciveN[7]) < 8 * 16)
                    {
                        
                        dt.Rows[i][ChannelBR3.CTCSEnc] = (Convert.ToDouble(reciveN[7])* 10 + Convert.ToDouble(reciveN[6]) * 0.1).ToString("#0.0");// reciveN[7] + reciveN[6];
                    }
                    else if (Common.Common.hexToDec(reciveN[7]) >= 12 * 16)
                    {
                        dt.Rows[i][ChannelBR3.CTCSEnc] = "D" + (Convert.ToDouble(Common.Common.hexToDec(reciveN[7]) - 12 * 16)).ToString() + Convert.ToDouble(reciveN[6]).ToString("#00") + "I";//reciveN[5]+ reciveN[4];
                    }
                    else
                    {
                       
                        string asdsd= "D" + (Convert.ToDouble(Common.Common.hexToDec(reciveN[7]) - 8 * 16) ).ToString() + Convert.ToDouble(reciveN[6]).ToString("#00") + "N";
                        if (i == 7)
                        {
                            asdsd = "D" + (Convert.ToDouble(Common.Common.hexToDec(reciveN[7]) - 8 * 16) ).ToString() + Convert.ToDouble(reciveN[6]).ToString("#00") + "N";
                        }
                        dt.Rows[i][ChannelBR3.CTCSEnc] = "D" + (Convert.ToDouble(Common.Common.hexToDec(reciveN[7]) - 8 * 16)).ToString() + Convert.ToDouble(reciveN[6]).ToString("#00") + "N";

                    }
                    int x = Common.Common.hexToDec(reciveN[8]);
                    int H4 = x / 16;
                    int L4 = x % 16;
                    dt.Rows[i][ChannelBR3.PPTID] = Convert.ToBoolean(H4 / 8) ? "No" : "Yes";
                    dt.Rows[i][ChannelBR3.Companding] = Convert.ToBoolean(H4 % 8 / 4) ? "No" : "Yes";
                    dt.Rows[i][ChannelBR3.Scrambling] = Convert.ToBoolean(H4 % 8 % 4 / 2) ? "No" : "Yes";
                    dt.Rows[i][ChannelBR3.ScanningAdd] = Convert.ToBoolean(H4 % 8 % 4 % 2) ? "No" : "Yes";
                    dt.Rows[i][ChannelBR3.TXPower] = Convert.ToBoolean(L4 / 8) ? "High" : "Low";
                    dt.Rows[i][ChannelBR3.WN] = Convert.ToBoolean(L4 % 8 / 4) ? "Narrow" : "Wide";
                    dt.Rows[i][ChannelBR3.BusyLock] = Convert.ToBoolean(L4 % 8 % 4 % 2) ? "No" : "Yes";
                    dt.Rows[i][ChannelBR3.Repeater] = Convert.ToBoolean(L4 % 8 % 4 / 2) ? "Yes" : "No";
                }
            }
            MainForm.barEditItem3.Value = 94;
            //57 07 90 08  57 07 98 08 开机显示名称  reciveData[32*7+18]和reciveData[32*7+19]
            str = reciveData[32 * 7 + 18] + " " + reciveData[32 * 7 + 19];
            reciveN = str.Split(' ');
            txtDisplay.Text = NumToLetter(Common.Common.hexToDec(reciveN[4])) + NumToLetter(Common.Common.hexToDec(reciveN[5])) + NumToLetter(Common.Common.hexToDec(reciveN[6]))
                + NumToLetter(Common.Common.hexToDec(reciveN[7])) + NumToLetter(Common.Common.hexToDec(reciveN[8])) + NumToLetter(Common.Common.hexToDec(reciveN[9]))
                + NumToLetter(Common.Common.hexToDec(reciveN[10])) + NumToLetter(Common.Common.hexToDec(reciveN[11])) + NumToLetter(Common.Common.hexToDec(reciveN[16]))
                + NumToLetter(Common.Common.hexToDec(reciveN[17]));
            if (Common.Common.hexToDec(reciveN[23]) <= 99)
            {
                cmbStartUpCH.SelectedIndex = Common.Common.hexToDec(reciveN[23]);
            }
            else
            {
                cmbStartUpCH.SelectedIndex = 0;
            }
            chkRogerTone.Checked = Common.Common.hexToDec(reciveN[22])==1? true:false;
            //57 07 a0 08 发射开始  reciveData[32*27+20]
            str = reciveData[32 * 7 + 20];
            reciveN = str.Split(' ');
            txtTXStart.Text = "";
            for (int i = 4; i < 12; i++)
            {
                if (reciveN[i].ToLower() != "ff")
                {
                    txtTXStart.Text += reciveN[i].Substring(1, 1);
                }
            }
          

            //57 07 C0 08   PTT ID和语音语言 reciveData[32*27+24]
            str = reciveData[32 * 7 + 24];
            reciveN = str.Split(' ');
            int x1 = Common.Common.hexToDec(reciveN[4]) / 16;
            int x2 = Common.Common.hexToDec(reciveN[4]) % 16;
            switch (x1)
            {
                case 0:
                    cmbScanMode.SelectedIndex = 0;
                    cmbPPT.SelectedIndex = 0;
                    break;
                case 1:
                    cmbScanMode.SelectedIndex = 0;
                    cmbPPT.SelectedIndex = 1;
                    break;
                case 2:
                    cmbScanMode.SelectedIndex = 0;
                    cmbPPT.SelectedIndex = 2;
                    break;
                case 3:
                    cmbScanMode.SelectedIndex = 0;
                    cmbPPT.SelectedIndex = 3;
                    break;
                case 4:
                    cmbScanMode.SelectedIndex = 1;
                    cmbPPT.SelectedIndex = 0;
                    break;
                case 5:
                    cmbScanMode.SelectedIndex = 1;
                    cmbPPT.SelectedIndex = 1;
                    break;
                case 6:
                    cmbScanMode.SelectedIndex = 1;
                    cmbPPT.SelectedIndex = 2;
                    break;
                case 7:
                    cmbScanMode.SelectedIndex = 1;
                    cmbPPT.SelectedIndex = 3;
                    break;
                case 8:
                    cmbScanMode.SelectedIndex = 2;
                    cmbPPT.SelectedIndex = 0;
                    break;
                case 9:
                    cmbScanMode.SelectedIndex = 2;
                    cmbPPT.SelectedIndex = 1;
                    break;
                case 10:
                    cmbScanMode.SelectedIndex = 2;
                    cmbPPT.SelectedIndex = 2;
                    break;
                case 11:
                    cmbScanMode.SelectedIndex = 2;
                    cmbPPT.SelectedIndex = 3;
                    break;
                default:
                    break;
            }
            switch (x2)
            {
                case 0:
                    cmbVoiceAnnouncements.SelectedIndex = 0;
                    chkBeepSound.Checked = false;
                    chkPowerSaving.Checked = false; ;
                    break;
                case 1:
                    cmbVoiceAnnouncements.SelectedIndex = 0;
                    chkBeepSound.Checked = true;
                    chkPowerSaving.Checked = false; ;
                    break;
                case 2:
                    cmbVoiceAnnouncements.SelectedIndex = 0;
                    chkBeepSound.Checked = false;
                    chkPowerSaving.Checked = true; ;
                    break;
                case 3:
                    cmbVoiceAnnouncements.SelectedIndex = 0;
                    chkBeepSound.Checked = true;
                    chkPowerSaving.Checked = true; ;
                    break;
                case 4:
                    cmbVoiceAnnouncements.SelectedIndex = 1;
                    chkBeepSound.Checked = false;
                    chkPowerSaving.Checked = false; ;
                    break;
                case 5:
                    cmbVoiceAnnouncements.SelectedIndex = 1;
                    chkBeepSound.Checked = true;
                    chkPowerSaving.Checked = false; ;
                    break;
                case 6:
                    cmbVoiceAnnouncements.SelectedIndex = 1;
                    chkBeepSound.Checked = false;
                    chkPowerSaving.Checked = true; ;
                    break;
                case 7:
                    cmbVoiceAnnouncements.SelectedIndex = 1;
                    chkBeepSound.Checked = true;
                    chkPowerSaving.Checked = true; ;
                    break;
                case 8:
                    cmbVoiceAnnouncements.SelectedIndex = 2;
                    chkBeepSound.Checked = false;
                    chkPowerSaving.Checked = false; ;
                    break;
                case 9:
                    cmbVoiceAnnouncements.SelectedIndex = 2;
                    chkBeepSound.Checked = true;
                    chkPowerSaving.Checked = false; ;
                    break;
                case 10:
                    cmbVoiceAnnouncements.SelectedIndex = 2;
                    chkBeepSound.Checked = false;
                    chkPowerSaving.Checked = true; ;
                    break;
                case 11:
                    cmbVoiceAnnouncements.SelectedIndex = 2;
                    chkBeepSound.Checked = true;
                    chkPowerSaving.Checked = true; ;
                    break;
                default:
                    break;
            }
            MainForm.barEditItem3.Value = 98;
            //静噪等级
            cmbSquelchLevel.SelectedIndex = Common.Common.hexToDec(reciveN[5]);
            //侧键1短
            switch (Common.Common.hexToDec(reciveN[6]))
            {
                case 0:
                    cmbShotPress1.SelectedIndex = 0;
                    break;
                case 1:
                    cmbShotPress1.SelectedIndex = 1;
                    break;
                case 2:
                    cmbShotPress1.SelectedIndex = 2;
                    break;
                case 3:
                    cmbShotPress1.SelectedIndex = 3;
                    break;
                case 5:
                    cmbShotPress1.SelectedIndex = 4;
                    break;
                case 6:
                    cmbShotPress1.SelectedIndex = 5;
                    break;
                case 7:
                    cmbShotPress1.SelectedIndex = 6;
                    break;
                default:
                    break;
            }
            //发射限时
            cmbTXLimit.SelectedIndex = Common.Common.hexToDec(reciveN[7]);
            //声控等级
            cmbVoiceLevel.SelectedIndex = Common.Common.hexToDec(reciveN[8]);
            //侧键2短
            switch (Common.Common.hexToDec(reciveN[9]))
            {
                case 0:
                    cmbShotPress2.SelectedIndex = 0;
                    break;
                case 1:
                    cmbShotPress2.SelectedIndex = 1;
                    break;
                case 2:
                    cmbShotPress2.SelectedIndex = 2;
                    break;
                case 3:
                    cmbShotPress2.SelectedIndex = 3;
                    break;
                case 5:
                    cmbShotPress2.SelectedIndex = 4;
                    break;
                case 6:
                    cmbShotPress2.SelectedIndex = 5;
                    break;
                case 7:
                    cmbShotPress2.SelectedIndex = 6;
                    break;
                default:
                    break;
            }
            //声控延迟时间
            cmbVoiceDelay.SelectedIndex = Common.Common.hexToDec(reciveN[11]);


            //57 07 d8 08   侧键长按与开机显示方式 reciveData[32*27+27]
            str = reciveData[32 * 7 + 27];
            reciveN = str.Split(' ');

            if (reciveN[4] == "60" && reciveN[5] == "44" && reciveN[6] == "80" && reciveN[7] == "44")
            {
                cmbFTO.SelectedIndexChanged -= cmbFTO_SelectedIndexChanged;
                cmbFTO.SelectedIndex = 0;
                cmbFTO.SelectedIndexChanged += cmbFTO_SelectedIndexChanged;
            }
            else if (reciveN[4] == "00" && reciveN[5] == "45" && reciveN[6] == "00" && reciveN[7] == "52")
            {
                cmbFTO.SelectedIndexChanged -= cmbFTO_SelectedIndexChanged;
                cmbFTO.SelectedIndex = 1;
                cmbFTO.SelectedIndexChanged += cmbFTO_SelectedIndexChanged;
            }

            //57 07 C8 08   侧键长按与开机显示方式 reciveData[32*27+25]
            str = reciveData[32 * 7 + 25];
            reciveN = str.Split(' ');
            //侧键1长
            switch (Common.Common.hexToDec(reciveN[4]))
            {
                case 0:
                    cmbLongPress1.SelectedIndex = 0;
                    break;
                case 1:
                    cmbLongPress1.SelectedIndex = 1;
                    break;
                case 2:
                    cmbLongPress1.SelectedIndex = 2;
                    break;
                case 3:
                    cmbLongPress1.SelectedIndex = 3;
                    break;
                case 5:
                    cmbLongPress1.SelectedIndex = 4;
                    break;
                case 6:
                    cmbLongPress1.SelectedIndex = 5;
                    break;
                case 7:
                    cmbLongPress1.SelectedIndex = 6;
                    break;
                default:
                    break;
            }
            //侧键2长         
            
            switch (Common.Common.hexToDec(reciveN[5]))
            {
                case 0:
                    cmbLongPress2.SelectedIndex = 0;
                    break;
                case 1:
                    cmbLongPress2.SelectedIndex = 1;
                    break;
                case 2:
                    cmbLongPress2.SelectedIndex = 2;
                    break;
                case 3:
                    cmbLongPress2.SelectedIndex = 3;
                    break;
                case 5:
                    cmbLongPress2.SelectedIndex = 4;
                    break;
                case 6:
                    cmbLongPress2.SelectedIndex = 5;
                    break;
                case 7:
                    cmbLongPress2.SelectedIndex = 6;
                    break;
                default:
                    cmbLongPress2.SelectedIndex = 0;
                    break;
            }
            
           
            //开机显示方式
            cmbDisplayMode.SelectedIndex = Common.Common.hexToDec(reciveN[6]);

           
            MainForm.barEditItem3.Value = 100;
            //57 07 e0 08   发射结束码 reciveData[32*27+28]
            str = reciveData[32 * 7 + 28];
            reciveN = str.Split(' ');
            txtTXStop.Text = "";
            for (int i = 4; i < 12; i++)
            {
                if (reciveN[i].ToLower() != "ff")
                {
                    txtTXStop.Text += reciveN[i].Substring(1, 1);
                }
            }           
        }

        private bool GetWriteData()
        {
            decimal dec;
            gridControl1.EndEdit();
            br3 = new Class.BR3Class();
            br3.BeepSound = chkBeepSound.Checked; 
            br3.Channel = dt;
            br3.Display = txtDisplay.Text;
            br3.DisplayMode = cmbDisplayMode.SelectedIndex;
            br3.Fto = cmbFTO.SelectedIndex;
            br3.LongPress1 = cmbLongPress1.SelectedIndex;
            br3.LongPress2 = cmbLongPress2.SelectedIndex;
            br3.PowerSaving = chkPowerSaving.Checked;
            br3.Ppt = cmbPPT.SelectedIndex;
            br3.ScanMode = cmbScanMode.SelectedIndex;
            br3.ShotPress1 = cmbShotPress1.SelectedIndex;
            br3.ShotPress2 = cmbShotPress2.SelectedIndex;
            br3.SquelchLevel = cmbSquelchLevel.SelectedIndex;
            br3.TxLimit = cmbTXLimit.SelectedIndex;
            br3.TxStart = txtTXStart.Text;
            br3.TxStop = txtTXStop.Text;
            br3.VoiceAnnouncements = cmbVoiceAnnouncements.SelectedIndex;
            br3.VoiceDelay = cmbVoiceDelay.SelectedIndex;
            br3.VoiceLevel = cmbVoiceLevel.SelectedIndex;
            br3.StartupCh = cmbStartUpCH.SelectedIndex;
            br3.RogerTone = chkRogerTone.Checked;
            for (int i = 0; i < 99; i++)
            {
                if ( dt.Rows[i][ChannelBR3.RXFrequency]!=null&& dt.Rows[i][ChannelBR3.RXFrequency].ToString()!="")
                {
                    dec = Convert.ToDecimal(dt.Rows[i][ChannelBR3.RXFrequency]);
                    if (dec < Models.ModelClass.models[0].MinFrequency | dec > Models.ModelClass.models[0].MaxFrequency)
                    {
                        MessageBox.Show("Frequency range of " + Models.ModelClass.models[0].MinFrequency + "MHZ-" + Models.ModelClass.models[0].MaxFrequency + "MHZ");
                        gridControl1.CurrentCell = gridControl1.Rows[i].Cells[1];
                        return false;
                    }
                }
                if (dt.Rows[i][ChannelBR3.TXFrequency] != null && dt.Rows[i][ChannelBR3.TXFrequency].ToString() != "")
                {
                    dec = Convert.ToDecimal(dt.Rows[i][ChannelBR3.TXFrequency]);
                    if (dec < Models.ModelClass.models[0].MinFrequency | dec > Models.ModelClass.models[0].MaxFrequency)
                    {
                        MessageBox.Show("Frequency range of " + Models.ModelClass.models[0].MinFrequency + "MHZ-" + Models.ModelClass.models[0].MaxFrequency + "MHZ");
                        gridControl1.CurrentCell = gridControl1.Rows[i].Cells[3];
                        return false;
                    }
                }

            }
            return true;
        }

        /// <summary>
        /// 按规则数据转为字线  41：A   42：B .....5A：Z   02为空格
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private string NumToLetter(int num)
        {
            switch (num)
            {
                case 2: return " ";
                case 4 * 16 + 1: return "A";
                case 4 * 16 + 2: return "B";
                case 4 * 16 + 3: return "C";
                case 4 * 16 + 4: return "D";
                case 4 * 16 + 5: return "E";
                case 4 * 16 + 6: return "F";
                case 4 * 16 + 7: return "G";
                case 4 * 16 + 8: return "H";
                case 4 * 16 + 9: return "I";
                case 4 * 16 + 10: return "J";
                case 4 * 16 + 11: return "K";
                case 4 * 16 + 12: return "L";
                case 4 * 16 + 13: return "M";
                case 4 * 16 + 14: return "N";
                case 4 * 16 + 15: return "O";
                case 5 * 16: return "P";
                case 5 * 16 + 1: return "Q";
                case 5 * 16 + 2: return "R";
                case 5 * 16 + 3: return "S";
                case 5 * 16 + 4: return "T";
                case 5 * 16 + 5: return "U";
                case 5 * 16 + 6: return "V";
                case 5 * 16 + 7: return "W";
                case 5 * 16 + 8: return "X";
                case 5 * 16 + 9: return "Y";
                case 5 * 16 + 10: return "Z";
                default: return "";

            }
        }


        #endregion
        /// <summary>
        /// 接收频率改变时   发射频率跟着改变       
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void repositoryItemTextEdit1_Leave(object sender, EventArgs e)
        {
            gridControl1.EndEdit();
            DataGridViewTextBoxEditingControl te = (DataGridViewTextBoxEditingControl)sender;
            //if (!te.Focus())
            //{
            //    return;
            //}

            int index = te.EditingControlRowIndex;
            decimal sadj = Models.ModelClass.models[0].MinFrequency;
            decimal writdat;
            if (te.Text.Trim() == "")
            {
                dt.Rows[index][Class.ChannelBR3.TXFrequency] = "";
                dt.Rows[index][Class.ChannelBR3.BusyLock] =null;
                dt.Rows[index][Class.ChannelBR3.CTCSDec] = null;
                dt.Rows[index][Class.ChannelBR3.CTCSEnc] = null;
                dt.Rows[index][Class.ChannelBR3.Companding] = null;
                dt.Rows[index][Class.ChannelBR3.ScanningAdd] = null;
                dt.Rows[index][Class.ChannelBR3.TXPower] = null;
                dt.Rows[index][Class.ChannelBR3.WN] = null;
                dt.Rows[index][Class.ChannelBR3.PPTID] = null;
                dt.Rows[index][Class.ChannelBR3.Scrambling] = null;
                dt.Rows[index][ChannelBR3.Repeater] = null;
                return;
            }
            else
            {
                try
                {
                    writdat = Convert.ToDecimal(te.Text);
                }
                catch (Exception)
                {

                    MessageBox.Show("Input error!");
                    return;
                }
                
            }
            if (writdat < Models.ModelClass.models[0].MinFrequency | writdat > Models.ModelClass.models[0].MaxFrequency)
            {

                MessageBox.Show("Frequency range of " + Models.ModelClass.models[0].MinFrequency + "MHZ-" + Models.ModelClass.models[0].MaxFrequency + "MHZ");
                te.Leave -= repositoryItemTextEdit1_Leave;
                dt.Rows[index][Class.ChannelBR3.RXFrequency] = te.Text = sadj.ToString("#0.00000");
            }
            else
            {
                te.Leave -= repositoryItemTextEdit1_Leave;
                dt.Rows[index][Class.ChannelBR3.RXFrequency] = te.Text = writdat.ToString("#0.00000");    
            }
            string str = dt.Rows[index][2].ToString();
            if (dt.Rows[index][Class.ChannelBR3.TXFrequency].ToString().Trim() == "")
            {               
                dt.Rows[index][Class.ChannelBR3.TXFrequency] = te.Text;                
                dt.Rows[index][Class.ChannelBR3.BusyLock] ="No";
                dt.Rows[index][Class.ChannelBR3.CTCSDec] = "Off";
                dt.Rows[index][Class.ChannelBR3.CTCSEnc] = "Off";
                dt.Rows[index][Class.ChannelBR3.Companding] ="No";
                dt.Rows[index][Class.ChannelBR3.ScanningAdd] = "Yes";
                dt.Rows[index][Class.ChannelBR3.TXPower] = "Low";
                dt.Rows[index][Class.ChannelBR3.WN] = "Narrow";
                dt.Rows[index][Class.ChannelBR3.PPTID] = "No";
                dt.Rows[index][Class.ChannelBR3.Scrambling] = "No";
                dt.Rows[index][Class.ChannelBR3.Repeater] = "No";
                dt.Rows[index][ChannelBR3.Repeater] = "No";
            }
            else
            {
                dt.Rows[index][Class.ChannelBR3.TXFrequency] = te.Text;
            }
            ShowData();

        }

        /// <summary>
        /// 发射频率改变时 整理格式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void repositoryItemTextEdit2_Leave(object sender, EventArgs e)
        {
            DataGridViewTextBoxEditingControl te = (DataGridViewTextBoxEditingControl)sender;

        
            int index = te.EditingControlRowIndex;
            decimal sadj = Models.ModelClass.models[0].MinFrequency;
            decimal writdat;
            if (te.Text.Trim() == "")
            {
                return;
            }
            else
            {
                try
                {
                    writdat = Convert.ToDecimal(te.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Input error !");
                    te.Focus();
                    return;
                }
            }
            if (writdat < Models.ModelClass.models[0].MinFrequency | writdat > Models.ModelClass.models[0].MaxFrequency)
            {
                MessageBox.Show("Frequency range of " + Models.ModelClass.models[0].MinFrequency + "MHZ-" + Models.ModelClass.models[0].MaxFrequency + "MHZ");

                te.Leave -= repositoryItemTextEdit2_Leave;
                dt.Rows[index][Class.ChannelBR3.TXFrequency] = te.Text = sadj.ToString("#0.00000");
                //te.Leave += repositoryItemTextEdit2_Leave;
            }
            else
            {
                te.Leave -= repositoryItemTextEdit2_Leave;
                dt.Rows[index][Class.ChannelBR3.TXFrequency] = writdat.ToString("#0.00000");
            }         
        }
        private void cmbDisplayMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDisplayMode.SelectedIndex == 1)
            {
                txtDisplay.Text = "cmbDisplayMode";
            }
            else if (cmbDisplayMode.SelectedIndex == 2)
            {
                txtDisplay.Text = "MIDLAND";
            }
        }

        private void txtDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtDisplay.Text.Length >= 10)
            {
                if (e.KeyChar == 8)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                if ((int)e.KeyChar >= 97)
                {
                    e.KeyChar = (char)((int)e.KeyChar - 32);
                }
                //限制只能输入1-9的数字字母ABCD，退格键，回车
                if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || e.KeyChar == 13 || e.KeyChar == 8 || ((int)e.KeyChar >= 65 && (int)e.KeyChar <= 90) || ((int)e.KeyChar >= 97 && (int)e.KeyChar <= 122))
                {
                    
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtTXStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtTXStart.Text.Length >= 8)
            {
                if (e.KeyChar == 8)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

            }
            else
            {
                if ((int)e.KeyChar >= 97)
                {
                    e.KeyChar = (char)((int)e.KeyChar - 32);
                }
                //限制只能输入1-9的数字字母ABCD，退格键，回车
                if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || e.KeyChar == 13 || e.KeyChar == 8 )
                {
                    
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtTXStop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtTXStop.Text.Length >= 8)
            {
                if (e.KeyChar == 8)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
                if ((int)e.KeyChar >= 97)
                {
                    e.KeyChar = (char)((int)e.KeyChar - 32);
                }
                //限制只能输入1-9的数 退格键，回车
                if (((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57) || e.KeyChar == 13 || e.KeyChar == 8 )
                {
                   
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        ComboBox comb = new ComboBox();
        private void gridControl1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            isChange = true;
            //去除事件
            if (e.Control is DataGridViewComboBoxEditingControl)
            {
                comb = e.Control as DataGridViewComboBoxEditingControl;
                comb.SelectionChangeCommitted -= Comb_TextUpdate; ;
            }
            else
            {               
                e.Control.KeyPress -= TextBoxDec_KeyPress;
                e.Control.Leave -= repositoryItemTextEdit1_Leave;
                e.Control.Leave -= repositoryItemTextEdit2_Leave;
            }
           
            
            //添加相应事件
            if (this.gridControl1.CurrentCellAddress.X == gridControl1.Columns[Class.ChannelBR3.RXFrequency].Index)
            {
                
                e.Control.KeyPress += TextBoxDec_KeyPress;
                e.Control.Leave += repositoryItemTextEdit1_Leave;
            }
            else if (this.gridControl1.CurrentCellAddress.X == gridControl1.Columns[Class.ChannelBR3.TXFrequency].Index)
            {   
                e.Control.KeyPress += TextBoxDec_KeyPress;
                e.Control.Leave += repositoryItemTextEdit2_Leave;
            }
            if (this.gridControl1.CurrentCellAddress.X== gridControl1.Columns[Class.ChannelBR3.CTCSDec].Index)
            {
                comb.SelectionChangeCommitted += Comb_TextUpdate; ;
            }
        }

        private void Comb_TextUpdate(object sender, EventArgs e)
        {
            DataGridViewComboBoxEditingControl comb = (DataGridViewComboBoxEditingControl)sender;
            int index = comb.EditingControlRowIndex;
            string coms = comb.Text;
            dt.Rows[index][Class.ChannelBR3.CTCSEnc] = coms;
            dt.Rows[index][Class.ChannelBR3.CTCSDec] = coms;
        }



        private void TextBoxDec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            TextBox tb = (TextBox)sender;
            if (tb.Text.Contains('.') && e.KeyChar == '.')
            {
                e.Handled = true;
            }
            //DataGridViewTextBoxEditingControl dgt = (DataGridViewTextBoxEditingControl)sender;           
            //string str = dgt.Text.Trim();
            //if (str.Contains('.'))
            //{
            //    string[] ss = str.Split('.');
            //    if (ss[0].Length == 3)
            //    {
            //        e.Handled = true;
            //    }
            //    if (ss[1].Length==5)
            //    {
            //        e.Handled = true;
            //    }
            //}
            //else
            //{
            //    dgt.Text = str + ".00000";
            //}

        }
        private void gridControl1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView te = (DataGridView)sender; ;

            for (int rowsc = 0; rowsc < te.Rows.Count; rowsc++)
            {
                if (te.Rows[rowsc].Cells[1].Value.ToString().Trim() == "")
                {
                    te.Rows[rowsc].Cells[2].Value = null;
                    te.Rows[rowsc].Cells[3].Value = null;
                    te.Rows[rowsc].Cells[4].Value = null;
                    te.Rows[rowsc].Cells[5].Value = null;
                    te.Rows[rowsc].Cells[6].Value = null;
                    te.Rows[rowsc].Cells[7].Value = null;
                    te.Rows[rowsc].Cells[8].Value = null;
                    te.Rows[rowsc].Cells[9].Value = null;
                    te.Rows[rowsc].Cells[10].Value = null;
                    te.Rows[rowsc].Cells[11].Value = null;
                    te.Rows[rowsc].Cells[12].Value = null;
                }
            }
        }

        private void cmbFTO_SelectedIndexChanged(object sender, EventArgs e)
        {            
            switch (cmbFTO.SelectedIndex)
            {           
                case 0:
                    Models.ModelClass.models[0].MinFrequency = 446;
                    Models.ModelClass.models[0].MaxFrequency = 478;               
                    set477DefaultFre();
                    break;
                case 1:
                    Models.ModelClass.models[0].MinFrequency = 450;
                    Models.ModelClass.models[0].MaxFrequency = 520;                    
                    cmbStartUpCH.SelectedIndex = 0;                    
                    set520DefaultFre();

                    break;
                default:
                    break;
            }
            //InitializaDatatable();
        }
        private void set520DefaultFre()
        {
            InitializaDatatable();
            cmbLongPress2.Enabled = true;
            cmbLongPress2.Items.Clear();
            cmbLongPress2.Items.Add("Off");
            cmbLongPress2.Items.Add("Monitor Momenter");
            cmbLongPress2.Items.Add("Scan");
            cmbLongPress2.Items.Add("Show Battery");
            cmbLongPress2.Items.Add("Emergency Alarm");
            cmbLongPress2.Items.Add("High / Low Power");
            cmbLongPress2.Items.Add("Menu");
            cmbLongPress2.SelectedIndex = 0;

            gridControl1.Columns[ChannelBR3.Repeater].ReadOnly = true;
            

            for (int i = 0; i < 9; i++)
            {
                dt.Rows[i][ChannelBR3.BusyLock] = "No";
                dt.Rows[i][ChannelBR3.CTCSDec] = "Off";
                dt.Rows[i][ChannelBR3.CTCSEnc] = "Off";
                dt.Rows[i][ChannelBR3.Companding] = "No";
                dt.Rows[i][ChannelBR3.ScanningAdd] = "Yes";
                dt.Rows[i][ChannelBR3.TXPower] = "High";
                dt.Rows[i][ChannelBR3.WN] = "Narrow";
                dt.Rows[i][ChannelBR3.PPTID] = "No";
                dt.Rows[i][ChannelBR3.Scrambling] = "No";
                dt.Rows[i][ChannelBR3.Repeater] = "No";
                gridControl1.Rows[i].Cells[ChannelBR3.Repeater].Style.BackColor =Color.PowderBlue;
                switch (i)
                {
                    case 0:
                        dt.Rows[i][ChannelBR3.RXFrequency] = "450.02500";
                        dt.Rows[i][ChannelBR3.TXFrequency] = "450.02500";
                        break;
                    case 1:
                        dt.Rows[i][ChannelBR3.RXFrequency] = "450.02500";
                        dt.Rows[i][ChannelBR3.TXFrequency] = "450.02500";
                        dt.Rows[i][ChannelBR3.WN] = "Wide";
                        break;
                    case 2:
                        dt.Rows[i][ChannelBR3.RXFrequency] = "485.05000";
                        dt.Rows[i][ChannelBR3.TXFrequency] = "485.05000";
                        break;
                    case 3:
                        dt.Rows[i][ChannelBR3.RXFrequency] = "485.05000";
                        dt.Rows[i][ChannelBR3.TXFrequency] = "485.05000";
                        dt.Rows[i][ChannelBR3.WN] = "Wide";
                        break;
                    case 4:
                        dt.Rows[i][ChannelBR3.RXFrequency] = "519.97500";
                        dt.Rows[i][ChannelBR3.TXFrequency] = "519.97500";
                        break;
                    case 5:
                        dt.Rows[i][ChannelBR3.RXFrequency] = "519.97500";
                        dt.Rows[i][ChannelBR3.TXFrequency] = "519.97500";
                        dt.Rows[i][ChannelBR3.WN] = "Wide";
                        break;
                    case 6:
                        dt.Rows[i][ChannelBR3.RXFrequency] = "450.10000";
                        dt.Rows[i][ChannelBR3.TXFrequency] = "450.10000";
                        dt.Rows[i][ChannelBR3.TXPower] = "Low";
                        break;
                    case 7:
                        dt.Rows[i][ChannelBR3.RXFrequency] = "485.10000";
                        dt.Rows[i][ChannelBR3.TXFrequency] = "485.10000";
                        dt.Rows[i][ChannelBR3.CTCSDec] = "114.8";
                        dt.Rows[i][ChannelBR3.CTCSEnc] = "114.8";
                        break;
                    case 8:
                        dt.Rows[i][ChannelBR3.RXFrequency] = "519.95000";
                        dt.Rows[i][ChannelBR3.TXFrequency] = "519.95000";
                        dt.Rows[i][ChannelBR3.TXPower] = "Low";
                        break;
                    default:
                        break;
                }
            }
            
        }

        public void set477DefaultFre()
        {
            InitializaDatatable();
            cmbLongPress2.Enabled = false;
            cmbLongPress2.Items.Clear();
            cmbLongPress2.Items.Add("Repeater");
            cmbLongPress2.SelectedIndex = 0;
            gridControl1.Columns[ChannelBR3.Repeater].ReadOnly = true;

            for (int i = 0; i < 80; i++)
            {
                
                if (i<40)
                {
                    dt.Rows[i][ChannelBR3.RXFrequency] = (476.42500 + 0.02500 * i).ToString("#0.00000");
                    dt.Rows[i][ChannelBR3.TXFrequency] = (476.42500 + 0.02500 * i).ToString("#0.00000");
                    dt.Rows[i][ChannelBR3.BusyLock] = "No";
                    dt.Rows[i][ChannelBR3.CTCSDec] = "Off";
                    dt.Rows[i][ChannelBR3.CTCSEnc] = "Off";
                    dt.Rows[i][ChannelBR3.Companding] = "No";
                    dt.Rows[i][ChannelBR3.ScanningAdd] = "Yes";
                    dt.Rows[i][ChannelBR3.TXPower] = "High";
                    dt.Rows[i][ChannelBR3.WN] = "Narrow";
                    dt.Rows[i][ChannelBR3.PPTID] = "No";
                    dt.Rows[i][ChannelBR3.Scrambling] = "No";
                    dt.Rows[i][ChannelBR3.Repeater] = "No";
                    gridControl1.Rows[i].Cells[ChannelBR3.Repeater].Style.BackColor = Color.PowderBlue;
                    if (i==4)
                    {
                        gridControl1.Rows[i].Cells[ChannelBR3.CTCSEnc].ReadOnly = true;
                        gridControl1.Rows[i].Cells[ChannelBR3.CTCSDec].ReadOnly = true;
                        gridControl1.Rows[i].Cells[ChannelBR3.CTCSDec].Style.BackColor = Color.PowderBlue;
                        gridControl1.Rows[i].Cells[ChannelBR3.CTCSEnc].Style.BackColor = Color.PowderBlue;
                    }
                    if (i == 34)
                    {
                        gridControl1.Rows[i].Cells[ChannelBR3.CTCSEnc].ReadOnly = true;
                        gridControl1.Rows[i].Cells[ChannelBR3.CTCSDec].ReadOnly = true;
                        gridControl1.Rows[i].Cells[ChannelBR3.CTCSDec].Style.BackColor = Color.PowderBlue;
                        gridControl1.Rows[i].Cells[ChannelBR3.CTCSEnc].Style.BackColor = Color.PowderBlue;
                    }
                }
                else if (i<60)
                {
                    dt.Rows[i][ChannelBR3.RXFrequency] = (476.43750 + 0.02500 * (i-40)).ToString("#0.00000");
                    dt.Rows[i][ChannelBR3.TXFrequency] = (476.43750 + 0.02500 * (i-40)).ToString("#0.00000");
                    dt.Rows[i][ChannelBR3.BusyLock] = "No";
                    dt.Rows[i][ChannelBR3.CTCSDec] = "Off";
                    dt.Rows[i][ChannelBR3.CTCSEnc] = "Off";
                    dt.Rows[i][ChannelBR3.Companding] = "No";
                    dt.Rows[i][ChannelBR3.ScanningAdd] = "Yes";
                    dt.Rows[i][ChannelBR3.TXPower] = "High";
                    dt.Rows[i][ChannelBR3.WN] = "Narrow";
                    dt.Rows[i][ChannelBR3.PPTID] = "No";
                    dt.Rows[i][ChannelBR3.Scrambling] = "No";
                    dt.Rows[i][ChannelBR3.Repeater] = "No";
                    gridControl1.Rows[i].Cells[ChannelBR3.Repeater].Style.BackColor = Color.PowderBlue;
                }
                else if(i>=63)
                {
                    dt.Rows[i][ChannelBR3.RXFrequency] = (477.01250 + 0.02500 * (i - 63)).ToString("#0.00000");
                    dt.Rows[i][ChannelBR3.TXFrequency] = (477.01250 + 0.02500 * (i - 63)).ToString("#0.00000");
                    dt.Rows[i][ChannelBR3.BusyLock] = "No";
                    dt.Rows[i][ChannelBR3.CTCSDec] = "Off";
                    dt.Rows[i][ChannelBR3.CTCSEnc] = "Off";
                    dt.Rows[i][ChannelBR3.Companding] = "No";
                    dt.Rows[i][ChannelBR3.ScanningAdd] = "Yes";
                    dt.Rows[i][ChannelBR3.TXPower] = "High";
                    dt.Rows[i][ChannelBR3.WN] = "Narrow";
                    dt.Rows[i][ChannelBR3.PPTID] = "No";
                    dt.Rows[i][ChannelBR3.Scrambling] = "No";
                    dt.Rows[i][ChannelBR3.Repeater] = "No";
                    gridControl1.Rows[i].Cells[ChannelBR3.Repeater].Style.BackColor = Color.PowderBlue;
                }           

            }
            for (int i = 0; i < 8; i++)
            {
                gridControl1.Rows[i + 0].Cells[ChannelBR3.Repeater].ReadOnly = false;
                gridControl1.Rows[i + 0].Cells[ChannelBR3.Repeater].Style.BackColor = Color.GhostWhite;
                gridControl1.Rows[i + 30].Cells[ChannelBR3.Repeater].ReadOnly = false;
                gridControl1.Rows[i + 30].Cells[ChannelBR3.Repeater].Style.BackColor = Color.GhostWhite;
                gridControl1.Rows[i + 40].Cells[ChannelBR3.Repeater].ReadOnly = false;
                gridControl1.Rows[i + 40].Cells[ChannelBR3.Repeater].Style.BackColor = Color.GhostWhite;
                gridControl1.Rows[i + 70].Cells[ChannelBR3.Repeater].ReadOnly = false;
                gridControl1.Rows[i + 70].Cells[ChannelBR3.Repeater].Style.BackColor = Color.GhostWhite;
            }
        }

        private void txtTXStart_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTXStop_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }

    

        private void txt_TextChanged(object sender, EventArgs e)
        {
            isChange = true;
        }
    }
}
