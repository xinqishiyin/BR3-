using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using System.IO;

namespace BR3walkietalkie
{
    public partial class MainForm : Form
    {
        #region 参数

        /// <summary>
        /// 表绑定表单
        /// </summary>
       // DataTable dt;

        /* 成功标志位*/
        public static bool issessce = false;

        /*写入、读取所用线程*/
        public static Thread conn;

        /*委托*/
        public delegate void Entrust();

        /*进度条值*/
        public static int borValue = 0;

        int conCount = 0;
        //等待
        public static Loading lg;

        public static bool dataerrer = true;
        public static System.Windows.Forms.ToolStripProgressBar barEditItem3 = new System.Windows.Forms.ToolStripProgressBar();

        enum ConState
        {
            write,
            read
        }
        ConState s;

        /// <summary>
        /// 通用窗体
        /// </summary>
        //Form frm;

        //public delegate void BarValue(int i);

        #endregion
        Models.BR3Channel br3;
        public MainForm()
        {
            InitializeComponent();

            LoadBar();
            InitMenu();
            Class.ChannelItem.addCTCSSdata();
            GetComList(); //获取端口 
            PortCommunication.timerSend.Elapsed += new System.Timers.ElapsedEventHandler(timerSend_Elapsed);
            PortCommunication.timerSend.AutoReset = false;
            Control.CheckForIllegalCrossThreadCalls = false;
         

            //this.Text = Models.ModelClass.models[0].Name + "(" + Models.ModelClass.models[0].MinFrequency + "MHz" + "-" + Models.ModelClass.models[0].MaxFrequency + "MHz";
        }

        private void setFrequency()
        {
            if (!File.Exists(Environment.CurrentDirectory + "\\Model.dat"))
            {
                MessageBox.Show("No missing piece, unable to open");
                this.Dispose();
                return;
            }

            string obj = Common.Common.Deserialize(Environment.CurrentDirectory + "\\Model.dat");

            string[] str = Common.Encryption.DES_Decrypt(obj, "11111111").Split('|');

            if (str[0].Substring(0, 5) == "Model")
            {
                str[0] = str[0].Substring(5);

                Models.ModelClass.models[0].MinFrequency = Convert.ToDecimal(str[2]);
                Models.ModelClass.models[0].MaxFrequency = Convert.ToDecimal(str[3]);

            }
            else
            {
                MessageBox.Show("No missing piece, unable to open");
                this.Dispose();
            }
        }

        #region 菜单事件      

 

        #endregion


        #region 初始化菜单

        private void InitMenu()
        {
            //var imgindex = 0;
            //foreach (var item in LoginForm.strMenus)
            //{
            //    DevExpress.XtraBars.BarButtonItem barLargeItem = new DevExpress.XtraBars.BarButtonItem();
            //    barLargeItem.Caption = LoginForm.model + item;
            //    barLargeItem.Hint = LoginForm.model + item;
            //    barLargeItem.Tag = LoginForm.model + item;
            //    imgindex++;
            //    barSubItem6.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(barLargeItem, false));
            //    barMgr.Items.Add(barLargeItem);
            //}
        }

        #endregion





       



        #region 端口获取

        /// <summary>
        /// 获取端口
        /// </summary>
        public void GetComList()
        {

            string[] ses = MulGetHardwareInfo(HardwareEnum.Win32_PnPEntity, "Name");
            //portItem.DropDownItems.Clear();
            for (int i = 0; i < ses.Length; i++)
            {             
                //this.barSubItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Com_CheckedChanged);
                

                if (ses[i].ToString().Contains("USB"))
                {
                    
                    PortCommunication.ComName = ses[i].Substring(ses[i].Length - 5).Substring(0, 4);
                    mondelName.Text = PortCommunication.ComName;
                } 
            }
        }
        

        /// <summary>
        /// 枚举win32 api
        /// </summary>
        public enum HardwareEnum
        {
            // 硬件
            Win32_Processor, // CPU 处理器
            Win32_PhysicalMemory, // 物理内存条
            Win32_Keyboard, // 键盘
            Win32_PointingDevice, // 点输入设备，包括鼠标。
            Win32_FloppyDrive, // 软盘驱动器
            Win32_DiskDrive, // 硬盘驱动器
            Win32_CDROMDrive, // 光盘驱动器
            Win32_BaseBoard, // 主板
            Win32_BIOS, // BIOS 芯片
            Win32_ParallelPort, // 并口
            Win32_SerialPort, // 串口
            Win32_SerialPortConfiguration, // 串口配置
            Win32_SoundDevice, // 多媒体设置，一般指声卡。
            Win32_SystemSlot, // 主板插槽 (ISA & PCI & AGP)
            Win32_USBController, // USB 控制器
            Win32_NetworkAdapter, // 网络适配器
            Win32_NetworkAdapterConfiguration, // 网络适配器设置
            Win32_Printer, // 打印机
            Win32_PrinterConfiguration, // 打印机设置
            Win32_PrintJob, // 打印机任务
            Win32_TCPIPPrinterPort, // 打印机端口
            Win32_POTSModem, // MODEM
            Win32_POTSModemToSerialPort, // MODEM 端口
            Win32_DesktopMonitor, // 显示器
            Win32_DisplayConfiguration, // 显卡
            Win32_DisplayControllerConfiguration, // 显卡设置
            Win32_VideoController, // 显卡细节。
            Win32_VideoSettings, // 显卡支持的显示模式。

            // 操作系统
            Win32_TimeZone, // 时区
            Win32_SystemDriver, // 驱动程序
            Win32_DiskPartition, // 磁盘分区
            Win32_LogicalDisk, // 逻辑磁盘
            Win32_LogicalDiskToPartition, // 逻辑磁盘所在分区及始末位置。
            Win32_LogicalMemoryConfiguration, // 逻辑内存配置
            Win32_PageFile, // 系统页文件信息
            Win32_PageFileSetting, // 页文件设置
            Win32_BootConfiguration, // 系统启动配置
            Win32_ComputerSystem, // 计算机信息简要
            Win32_OperatingSystem, // 操作系统信息
            Win32_StartupCommand, // 系统自动启动程序
            Win32_Service, // 系统安装的服务
            Win32_Group, // 系统管理组
            Win32_GroupUser, // 系统组帐号
            Win32_UserAccount, // 用户帐号
            Win32_Process, // 系统进程
            Win32_Thread, // 系统线程
            Win32_Share, // 共享
            Win32_NetworkClient, // 已安装的网络客户端
            Win32_NetworkProtocol, // 已安装的网络协议
            Win32_PnPEntity,//all device
        }
        /// <summary>
        /// WMI取硬件信息
        /// </summary>
        /// <param name="hardType"></param>
        /// <param name="propKey"></param>
        /// <returns></returns>
        public static string[] MulGetHardwareInfo(HardwareEnum hardType, string propKey)
        {

            List<string> strs = new List<string>();
            try
            {
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from " + hardType))
                {
                    var hardInfos = searcher.Get();
                    foreach (var hardInfo in hardInfos)
                    {
                        if (hardInfo.Properties[propKey].Value != null)
                        {
                            if (hardInfo.Properties[propKey].Value.ToString().Contains("COM"))
                            {
                                strs.Add(hardInfo.Properties[propKey].Value.ToString());
                            }
                        }

                    }
                    searcher.Dispose();
                }
                return strs.ToArray();
            }
            catch
            {
                return null;
            }
            finally
            { strs = null; }
        }

        #endregion



        #region 按钮事件

        private void btnNew_ItemClick(object sender, EventArgs e)
        {


            br3.newBR3Channel();
          


        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            br3.OpenBR3Channel();
          

        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            br3.SaveBR3Channel();
            

        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {


            br3.SaveBR3ChannelAs();
          

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    

        private void btnRead_Click(object sender, EventArgs e)
        {
            conCount = 0;
          
            ReadClick();
        }

        private void ReadClick()
        {
            s = ConState.read;
            dataerrer = true;
            issessce = false;           
            Common.Common.massage = "";
            if (PortCommunication.ComName == null)
            {
                mondelName.Text = "Select Port ...";
                GetComList(); //获取端口 
                if (PortCommunication.ComName == null)
                {
                    MessageBox.Show("Please Select Port ...");
                    foreach (Control item in this.Controls)
                    {
                        item.Enabled = true;
                    }
                    return;
                }
            }

            //lg = new Loading();
            //lg.Location = new Point(this.Width / 2 - lg.Width / 2,  this.Height / 2 - lg.Height / 2);
            //lg.TopLevel = false;
            //try
            //{
            //    lg.Parent = this;
            //}
            //catch (Exception)
            //{

            //    ;
            //}           

            try
            {
                PortCommunication.NewSerialPort();

                PortCommunication.openPort();
            }
            catch (Exception)
            {

                MessageBox.Show("The port failed to open, please check the port!");
                foreach (Control item in this.Controls)
                {
                    item.Enabled = true;
                }
                return;
            }
            
           conn = new Thread(br3.readMessage);
                       
         
            conn.IsBackground = true;
            //timerSend.Interval = timeout;

            PortCommunication.timerSend.Interval = PortCommunication.timeout;
            PortCommunication.timerSend.Enabled = true;
            PortCommunication.timerSend.Start();

            //timerSend.Start();
            //timer1.Start();
            foreach (Control item in this.Controls)
            {
                item.Enabled = false;
            }
            conn.Start();

        }

        public static void SetBarValue(int value)
        {
            barEditItem3.Value = value;
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
           
            conCount = 0;
            WriteClick();
        }

        private void WriteClick()
        {
            s = ConState.write;
            dataerrer = true;
            issessce = false;           
            Common.Common.massage = "";
            //writeP();
            if (PortCommunication.ComName == null)
            {
                mondelName.Text = "Select Port ...";
                GetComList(); //获取端口 
                if (PortCommunication.ComName == null)
                {
                    MessageBox.Show("Please Select Port ...");
                    foreach (Control item in this.Controls)
                    {
                        item.Enabled = true;
                    }
                    return;
                }
            }
            //lg = new Loading();

            //lg.Location = new Point(this.Width / 2 - lg.Width / 2, this.Height / 2 - lg.Height / 2);
            //lg.TopLevel = false;
            //lg.Parent = this;            
            try
            {
                PortCommunication.NewSerialPort();

                PortCommunication.openPort();
            }
            catch (Exception)
            {

                MessageBox.Show("The port failed to open, please check the port!");
                foreach (Control item in this.Controls)
                {
                    item.Enabled = true;
                }
                return;
            }  

            conn = new Thread(br3.writeMessage);

         
           
            conn.IsBackground = true;
            PortCommunication.timerSend.Interval = PortCommunication.timeout;
            PortCommunication.timerSend.Enabled = true;
            PortCommunication.timerSend.Start();
            //timer1.Start();
            foreach (Control item in this.Controls)
            {
                item.Enabled = false;
            }
            conn.Start();
            //lg.BringToFront();
            //lg.Show();
        }


  

       
    
        #endregion

        /// <summary>
        /// 连接超时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void timerSend_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            
            PortCommunication.timerSend.Enabled = false;
            // PortCommunication.timerSend.Interval = 0;

            //if (lg.IsHandleCreated)
            //{ 
            //    lg.Invoke(new Action(() =>
            //    {
            //        lg.Close();
            //    }));
            // }           
            if (conn.IsAlive)
            {
                conn.Abort();
            }

            PortCommunication.closePort();
            barEditItem3.Value = 0;
            if (dataerrer == true)
            {
                if (!issessce)
                {
                    if (conCount <= 1)
                    {
                        conCount++;
                        Thread.Sleep(200);
                        if (s == ConState.read)
                        {
                            ReadClick();
                        }
                        else if (s == ConState.write)
                        {
                            WriteClick();
                        }
                    }
                    else
                    {
                        Common.Common.massage = "Connect Time Out";
                        foreach (Control item in this.Controls)
                        {
                            item.Enabled = true;
                        }
                        MessageBox.Show(Common.Common.massage);


                    }
                }
                else
                {

                    foreach (Control item in this.Controls)
                    {
                        item.Enabled = true;
                    }
                    MessageBox.Show(Common.Common.massage);
                }
            }
            else
            {
                foreach (Control item in this.Controls)
                {
                    item.Enabled = true;
                }
            }
            
            
        }

      

        #region 进度条



        private void LoadBar()
        {
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { barEditItem3 });
            // 
            // barEditItem3
            // 

            barEditItem3.Name = "barEditItem3";
            barEditItem3.Size = new System.Drawing.Size(200, 16);
            statusStrip1.Size = new Size(statusStrip1.Size.Width + 400, statusStrip1.Size.Height);
            mondelName.Text = Models.ModelClass.models[0].Name;
            ToolTip p = new ToolTip();
            p.ShowAlways = true;
            p.SetToolTip(this.btnNew, "New");
            p.SetToolTip(this.btnOpen, "Open");
            //p.SetToolTip(this.btnParam, "Param");
            p.SetToolTip(this.btnSave, "Save");
            p.SetToolTip(this.btnSaveAs, "Save As");
            p.SetToolTip(this.btnRead, "Read");
            p.SetToolTip(this.btnWrite, "Write");
         
           // p.SetToolTip(this.btnChannel, "Channel");
            foreach (var item in barPanel.Controls)
            {
                if (item is Button)
                {
                    Button btn = (Button)item;
                    btn.Tag = Models.ModelClass.models[0].Name + btn.Name.Substring(3);
                }
            }
            


        }

        #endregion



        private void barButtonItem3_ItemClick(object sender, EventArgs e)
        {
            //About abt = new About();
            //abt.ShowDialog();
        }

        private void exitItem_Click(object sender, EventArgs e)
        {

        }

   

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.Control&e.Alt&e.KeyCode==Keys.P)
            //{
            //    PassWord pw = new PassWord();

            //    if (pw.ShowDialog() == DialogResult.OK)
            //    {
            //        Admin ad = new Admin();
            //        ad.ShowDialog();
            //    }
            //}
            //if (e.Control & e.Alt & e.KeyCode == Keys.Q)
            //{
            //    PassWord pw = new PassWord();
            //    if (pw.ShowDialog() == DialogResult.OK)
            //    {
            //        Button btnTruing = new Button();
            //        btnTruing.Tag = Models.ModelClass.models[0].Name + "Tuning";
            //        barMain_ItemClick(btnTruing, e);
            //    }
            //}
            //}
        }

        private void commonicationPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ports port = new Ports();
            port.ShowDialog();
            mondelName.Text = PortCommunication.ComName;
        }

        private void readFromRadioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conCount = 0;
            ReadClick();
        }

        private void writeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conCount = 0;
            WriteClick();
        }

        private void abortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.StartPosition = FormStartPosition.CenterParent;
            ab.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            br3 = new Models.BR3Channel();
            br3.TopLevel = false;
            br3.Dock = DockStyle.Fill;
            panel1.Controls.Add(br3);
            br3.Show();
            br3.set477DefaultFre();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (br3.isChange==true)
            {
                switch (MessageBox.Show("Whether to save the settings ?", "point out", MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.None:
                        break;
                    case DialogResult.OK:
                        br3.SaveBR3ChannelAs();
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;                    
                    default:
                        break;
                }
                
            }
        }
    }
}

