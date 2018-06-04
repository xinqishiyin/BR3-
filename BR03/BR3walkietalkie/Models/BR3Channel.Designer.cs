namespace BR3walkietalkie.Models
{
    partial class BR3Channel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmbSquelchLevel = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbTXLimit = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbVoiceAnnouncements = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbStartUpCH = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbScanMode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbPPT = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTXStart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTXStop = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbDisplayMode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbVoiceDelay = new System.Windows.Forms.ComboBox();
            this.cmbVoiceLevel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbLongPress2 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbLongPress1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbShotPress2 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbShotPress1 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.chkRogerTone = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFTO = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkBeepSound = new System.Windows.Forms.CheckBox();
            this.chkPowerSaving = new System.Windows.Forms.CheckBox();
            this.gridControl1 = new System.Windows.Forms.DataGridView();
            this.Channel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RXFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTCSDec = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TXFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTCSEnc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ScanningAdd = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.WN = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TXPower = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.BusyLock = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Scrambling = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Companding = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Repeater = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PPTID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.chkRogerTone);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.chkBeepSound);
            this.panel1.Controls.Add(this.chkPowerSaving);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 212);
            this.panel1.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmbSquelchLevel);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.cmbTXLimit);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.cmbVoiceAnnouncements);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.cmbStartUpCH);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.cmbScanMode);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Location = new System.Drawing.Point(475, 17);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(225, 187);
            this.groupBox6.TabIndex = 54;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Other";
            // 
            // cmbSquelchLevel
            // 
            this.cmbSquelchLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSquelchLevel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbSquelchLevel.FormattingEnabled = true;
            this.cmbSquelchLevel.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbSquelchLevel.Location = new System.Drawing.Point(122, 17);
            this.cmbSquelchLevel.Name = "cmbSquelchLevel";
            this.cmbSquelchLevel.Size = new System.Drawing.Size(95, 20);
            this.cmbSquelchLevel.TabIndex = 35;
            this.cmbSquelchLevel.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 12);
            this.label11.TabIndex = 5;
            this.label11.Text = "Voice Annunciation";
            // 
            // cmbTXLimit
            // 
            this.cmbTXLimit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTXLimit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbTXLimit.FormattingEnabled = true;
            this.cmbTXLimit.Items.AddRange(new object[] {
            "Off",
            "30",
            "60",
            "90",
            "120",
            "150",
            "180",
            "210",
            "240",
            "270",
            "300"});
            this.cmbTXLimit.Location = new System.Drawing.Point(122, 43);
            this.cmbTXLimit.Name = "cmbTXLimit";
            this.cmbTXLimit.Size = new System.Drawing.Size(95, 20);
            this.cmbTXLimit.TabIndex = 36;
            this.cmbTXLimit.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 12);
            this.label9.TabIndex = 32;
            this.label9.Text = "Time Out Timer[s]";
            // 
            // cmbVoiceAnnouncements
            // 
            this.cmbVoiceAnnouncements.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoiceAnnouncements.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbVoiceAnnouncements.FormattingEnabled = true;
            this.cmbVoiceAnnouncements.Items.AddRange(new object[] {
            "None",
            "English"});
            this.cmbVoiceAnnouncements.Location = new System.Drawing.Point(122, 69);
            this.cmbVoiceAnnouncements.Name = "cmbVoiceAnnouncements";
            this.cmbVoiceAnnouncements.Size = new System.Drawing.Size(95, 20);
            this.cmbVoiceAnnouncements.TabIndex = 20;
            this.cmbVoiceAnnouncements.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 12);
            this.label10.TabIndex = 31;
            this.label10.Text = "Squelch Level";
            // 
            // cmbStartUpCH
            // 
            this.cmbStartUpCH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStartUpCH.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbStartUpCH.FormattingEnabled = true;
            this.cmbStartUpCH.Items.AddRange(new object[] {
            "Off",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99"});
            this.cmbStartUpCH.Location = new System.Drawing.Point(122, 118);
            this.cmbStartUpCH.Name = "cmbStartUpCH";
            this.cmbStartUpCH.Size = new System.Drawing.Size(95, 20);
            this.cmbStartUpCH.TabIndex = 48;
            this.cmbStartUpCH.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 121);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 12);
            this.label17.TabIndex = 47;
            this.label17.Text = "Start Up CH";
            // 
            // cmbScanMode
            // 
            this.cmbScanMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScanMode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbScanMode.FormattingEnabled = true;
            this.cmbScanMode.Items.AddRange(new object[] {
            "Carrier",
            "Time",
            "Carrier+Tone"});
            this.cmbScanMode.Location = new System.Drawing.Point(122, 94);
            this.cmbScanMode.Name = "cmbScanMode";
            this.cmbScanMode.Size = new System.Drawing.Size(95, 20);
            this.cmbScanMode.TabIndex = 30;
            this.cmbScanMode.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 29;
            this.label6.Text = "Scan Mode";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbPPT);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.txtTXStart);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.txtTXStop);
            this.groupBox5.Location = new System.Drawing.Point(255, 104);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(214, 100);
            this.groupBox5.TabIndex = 53;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "PPT ID";
            // 
            // cmbPPT
            // 
            this.cmbPPT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPPT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbPPT.FormattingEnabled = true;
            this.cmbPPT.Items.AddRange(new object[] {
            "None",
            "Begin of Tx",
            "End of Tx",
            "Both"});
            this.cmbPPT.Location = new System.Drawing.Point(101, 15);
            this.cmbPPT.Name = "cmbPPT";
            this.cmbPPT.Size = new System.Drawing.Size(95, 20);
            this.cmbPPT.TabIndex = 19;
            this.cmbPPT.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 12);
            this.label16.TabIndex = 4;
            this.label16.Text = "PPT ID";
            // 
            // txtTXStart
            // 
            this.txtTXStart.Location = new System.Drawing.Point(101, 41);
            this.txtTXStart.Name = "txtTXStart";
            this.txtTXStart.Size = new System.Drawing.Size(95, 21);
            this.txtTXStart.TabIndex = 25;
            this.txtTXStart.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtTXStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTXStart_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "Begin of Tx";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "End of Tx";
            // 
            // txtTXStop
            // 
            this.txtTXStop.BackColor = System.Drawing.SystemColors.Window;
            this.txtTXStop.Location = new System.Drawing.Point(101, 68);
            this.txtTXStop.Name = "txtTXStop";
            this.txtTXStop.Size = new System.Drawing.Size(95, 21);
            this.txtTXStop.TabIndex = 26;
            this.txtTXStop.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtTXStop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTXStop_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbDisplayMode);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtDisplay);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(255, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(214, 83);
            this.groupBox4.TabIndex = 52;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Power On";
            // 
            // cmbDisplayMode
            // 
            this.cmbDisplayMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisplayMode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbDisplayMode.FormattingEnabled = true;
            this.cmbDisplayMode.Items.AddRange(new object[] {
            "OFF",
            "POWER ON",
            "MSG"});
            this.cmbDisplayMode.Location = new System.Drawing.Point(101, 19);
            this.cmbDisplayMode.Name = "cmbDisplayMode";
            this.cmbDisplayMode.Size = new System.Drawing.Size(95, 20);
            this.cmbDisplayMode.TabIndex = 28;
            this.cmbDisplayMode.SelectedIndexChanged += new System.EventHandler(this.cmbDisplayMode_SelectedIndexChanged);
            this.cmbDisplayMode.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "Power On Type";
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(101, 46);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(95, 21);
            this.txtDisplay.TabIndex = 27;
            this.txtDisplay.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtDisplay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDisplay_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "Power On Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbVoiceDelay);
            this.groupBox3.Controls.Add(this.cmbVoiceLevel);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(706, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(241, 81);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vox";
            // 
            // cmbVoiceDelay
            // 
            this.cmbVoiceDelay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoiceDelay.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbVoiceDelay.FormattingEnabled = true;
            this.cmbVoiceDelay.Items.AddRange(new object[] {
            "0.5",
            "1.0",
            "1.5",
            "2.0",
            "2.5",
            "3.0"});
            this.cmbVoiceDelay.Location = new System.Drawing.Point(124, 46);
            this.cmbVoiceDelay.Name = "cmbVoiceDelay";
            this.cmbVoiceDelay.Size = new System.Drawing.Size(95, 20);
            this.cmbVoiceDelay.TabIndex = 42;
            // 
            // cmbVoiceLevel
            // 
            this.cmbVoiceLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVoiceLevel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbVoiceLevel.FormattingEnabled = true;
            this.cmbVoiceLevel.Items.AddRange(new object[] {
            "Off",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cmbVoiceLevel.Location = new System.Drawing.Point(124, 19);
            this.cmbVoiceLevel.Name = "cmbVoiceLevel";
            this.cmbVoiceLevel.Size = new System.Drawing.Size(95, 20);
            this.cmbVoiceLevel.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 12);
            this.label7.TabIndex = 40;
            this.label7.Text = "VOX Delay Time[s]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 39;
            this.label8.Text = "Vox Level";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbLongPress2);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cmbLongPress1);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cmbShotPress2);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cmbShotPress1);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(12, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 142);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Keys";
            // 
            // cmbLongPress2
            // 
            this.cmbLongPress2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLongPress2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbLongPress2.FormattingEnabled = true;
            this.cmbLongPress2.Items.AddRange(new object[] {
            "Off",
            "Monitor Momenter",
            "Scan",
            "Show Battery",
            "Emergency Alarm",
            "High/Low Power",
            "Menu"});
            this.cmbLongPress2.Location = new System.Drawing.Point(122, 98);
            this.cmbLongPress2.Name = "cmbLongPress2";
            this.cmbLongPress2.Size = new System.Drawing.Size(90, 20);
            this.cmbLongPress2.TabIndex = 54;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 12);
            this.label12.TabIndex = 50;
            this.label12.Text = "Side Key 2(Long)";
            // 
            // cmbLongPress1
            // 
            this.cmbLongPress1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLongPress1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbLongPress1.FormattingEnabled = true;
            this.cmbLongPress1.Items.AddRange(new object[] {
            "Off",
            "Monitor Momenter",
            "Scan",
            "Show Battery",
            "Emergency Alarm",
            "High/Low Power",
            "Menu"});
            this.cmbLongPress1.Location = new System.Drawing.Point(122, 72);
            this.cmbLongPress1.Name = "cmbLongPress1";
            this.cmbLongPress1.Size = new System.Drawing.Size(90, 20);
            this.cmbLongPress1.TabIndex = 53;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 12);
            this.label13.TabIndex = 49;
            this.label13.Text = "Side Key 1(Long)";
            // 
            // cmbShotPress2
            // 
            this.cmbShotPress2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShotPress2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbShotPress2.FormattingEnabled = true;
            this.cmbShotPress2.Items.AddRange(new object[] {
            "Off",
            "Monitor Momenter",
            "Scan",
            "Show Battery",
            "Emergency Alarm",
            "High/Low Power",
            "Menu"});
            this.cmbShotPress2.Location = new System.Drawing.Point(122, 46);
            this.cmbShotPress2.Name = "cmbShotPress2";
            this.cmbShotPress2.Size = new System.Drawing.Size(90, 20);
            this.cmbShotPress2.TabIndex = 52;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 12);
            this.label14.TabIndex = 48;
            this.label14.Text = "Side Key 2(Short)";
            // 
            // cmbShotPress1
            // 
            this.cmbShotPress1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShotPress1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbShotPress1.FormattingEnabled = true;
            this.cmbShotPress1.Items.AddRange(new object[] {
            "Off",
            "Monitor Momenter",
            "Scan",
            "Show Battery",
            "Emergency Alarm",
            "High/Low Power",
            "Menu"});
            this.cmbShotPress1.Location = new System.Drawing.Point(122, 19);
            this.cmbShotPress1.Name = "cmbShotPress1";
            this.cmbShotPress1.Size = new System.Drawing.Size(90, 20);
            this.cmbShotPress1.TabIndex = 51;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 12);
            this.label15.TabIndex = 47;
            this.label15.Text = "Side Key 1(Short)";
            // 
            // chkRogerTone
            // 
            this.chkRogerTone.AutoSize = true;
            this.chkRogerTone.Location = new System.Drawing.Point(830, 134);
            this.chkRogerTone.Name = "chkRogerTone";
            this.chkRogerTone.Size = new System.Drawing.Size(84, 16);
            this.chkRogerTone.TabIndex = 49;
            this.chkRogerTone.Text = "Roger Tone";
            this.chkRogerTone.UseVisualStyleBackColor = true;
            this.chkRogerTone.Visible = false;
            this.chkRogerTone.CheckedChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFTO);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 46);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Model Information";
            // 
            // cmbFTO
            // 
            this.cmbFTO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFTO.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbFTO.FormattingEnabled = true;
            this.cmbFTO.Items.AddRange(new object[] {
            "477M Default",
            "450M-520M"});
            this.cmbFTO.Location = new System.Drawing.Point(85, 18);
            this.cmbFTO.Name = "cmbFTO";
            this.cmbFTO.Size = new System.Drawing.Size(141, 20);
            this.cmbFTO.TabIndex = 7;
            this.cmbFTO.SelectedIndexChanged += new System.EventHandler(this.cmbFTO_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Freq Range：";
            // 
            // chkBeepSound
            // 
            this.chkBeepSound.AutoSize = true;
            this.chkBeepSound.Location = new System.Drawing.Point(714, 174);
            this.chkBeepSound.Name = "chkBeepSound";
            this.chkBeepSound.Size = new System.Drawing.Size(78, 16);
            this.chkBeepSound.TabIndex = 8;
            this.chkBeepSound.Text = "Beep Tone";
            this.chkBeepSound.UseVisualStyleBackColor = true;
            this.chkBeepSound.CheckedChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // chkPowerSaving
            // 
            this.chkPowerSaving.AutoSize = true;
            this.chkPowerSaving.Location = new System.Drawing.Point(830, 174);
            this.chkPowerSaving.Name = "chkPowerSaving";
            this.chkPowerSaving.Size = new System.Drawing.Size(96, 16);
            this.chkPowerSaving.TabIndex = 7;
            this.chkPowerSaving.Text = "Battery Save";
            this.chkPowerSaving.UseVisualStyleBackColor = true;
            this.chkPowerSaving.CheckedChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.AllowUserToAddRows = false;
            this.gridControl1.AllowUserToDeleteRows = false;
            this.gridControl1.AllowUserToResizeRows = false;
            this.gridControl1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridControl1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridControl1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridControl1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridControl1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Channel,
            this.RXFrequency,
            this.CTCSDec,
            this.TXFrequency,
            this.CTCSEnc,
            this.ScanningAdd,
            this.WN,
            this.TXPower,
            this.BusyLock,
            this.Scrambling,
            this.Companding,
            this.Repeater,
            this.PPTID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridControl1.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 212);
            this.gridControl1.MultiSelect = false;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RowHeadersVisible = false;
            this.gridControl1.RowTemplate.Height = 23;
            this.gridControl1.Size = new System.Drawing.Size(965, 448);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridControl1_CellEndEdit);
            this.gridControl1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.gridControl1_EditingControlShowing);
            // 
            // Channel
            // 
            this.Channel.DataPropertyName = "Channel";
            this.Channel.FillWeight = 60.9137F;
            this.Channel.HeaderText = "CH.";
            this.Channel.Name = "Channel";
            this.Channel.ReadOnly = true;
            this.Channel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RXFrequency
            // 
            this.RXFrequency.DataPropertyName = "RXFrequency";
            this.RXFrequency.FillWeight = 103.5533F;
            this.RXFrequency.HeaderText = "RXFreq(MHz)";
            this.RXFrequency.Name = "RXFrequency";
            this.RXFrequency.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CTCSDec
            // 
            this.CTCSDec.DataPropertyName = "CTCSDec";
            this.CTCSDec.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.CTCSDec.FillWeight = 103.5533F;
            this.CTCSDec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CTCSDec.HeaderText = "CTC/DCS DEC";
            this.CTCSDec.Name = "CTCSDec";
            this.CTCSDec.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // TXFrequency
            // 
            this.TXFrequency.DataPropertyName = "TXFrequency";
            this.TXFrequency.FillWeight = 103.5533F;
            this.TXFrequency.HeaderText = "TXFreq(MHz)";
            this.TXFrequency.Name = "TXFrequency";
            this.TXFrequency.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CTCSEnc
            // 
            this.CTCSEnc.DataPropertyName = "CTCSEnc";
            this.CTCSEnc.FillWeight = 103.5533F;
            this.CTCSEnc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CTCSEnc.HeaderText = "CTC/DCS ENC";
            this.CTCSEnc.Name = "CTCSEnc";
            // 
            // ScanningAdd
            // 
            this.ScanningAdd.DataPropertyName = "ScanningAdd";
            this.ScanningAdd.FillWeight = 103.5533F;
            this.ScanningAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ScanningAdd.HeaderText = "Scan Add";
            this.ScanningAdd.Name = "ScanningAdd";
            // 
            // WN
            // 
            this.WN.DataPropertyName = "WN";
            this.WN.FillWeight = 103.5533F;
            this.WN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WN.HeaderText = "W/N";
            this.WN.Name = "WN";
            // 
            // TXPower
            // 
            this.TXPower.DataPropertyName = "TXPower";
            this.TXPower.FillWeight = 103.5533F;
            this.TXPower.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TXPower.HeaderText = "TXPower";
            this.TXPower.Name = "TXPower";
            // 
            // BusyLock
            // 
            this.BusyLock.DataPropertyName = "BusyLock";
            this.BusyLock.FillWeight = 103.5533F;
            this.BusyLock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BusyLock.HeaderText = "BusyLock";
            this.BusyLock.Name = "BusyLock";
            // 
            // Scrambling
            // 
            this.Scrambling.DataPropertyName = "Scrambling";
            this.Scrambling.FillWeight = 103.5533F;
            this.Scrambling.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Scrambling.HeaderText = "Scramble";
            this.Scrambling.Name = "Scrambling";
            // 
            // Companding
            // 
            this.Companding.DataPropertyName = "Companding";
            this.Companding.FillWeight = 103.5533F;
            this.Companding.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Companding.HeaderText = "Companding";
            this.Companding.Name = "Companding";
            // 
            // Repeater
            // 
            this.Repeater.DataPropertyName = "Repeater";
            this.Repeater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Repeater.HeaderText = "Repeater";
            this.Repeater.Name = "Repeater";
            this.Repeater.ReadOnly = true;
            this.Repeater.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // PPTID
            // 
            this.PPTID.DataPropertyName = "PPTID";
            this.PPTID.FillWeight = 103.5533F;
            this.PPTID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PPTID.HeaderText = "PPTID";
            this.PPTID.Name = "PPTID";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Channel";
            this.dataGridViewTextBoxColumn1.FillWeight = 60.9137F;
            this.dataGridViewTextBoxColumn1.HeaderText = "CH.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 45;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RXFrequency";
            this.dataGridViewTextBoxColumn2.FillWeight = 103.5533F;
            this.dataGridViewTextBoxColumn2.HeaderText = "RXFreq(MHz)";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 77;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TXFrequency";
            this.dataGridViewTextBoxColumn3.FillWeight = 103.5533F;
            this.dataGridViewTextBoxColumn3.HeaderText = "TXFreq(MHz)";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 77;
            // 
            // BR3Channel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 660);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BR3Channel";
            this.Text = "BR3Channel";
            this.Load += new System.EventHandler(this.BR3Channel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbVoiceAnnouncements;
        private System.Windows.Forms.CheckBox chkBeepSound;
        private System.Windows.Forms.ComboBox cmbPPT;
        private System.Windows.Forms.CheckBox chkPowerSaving;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView gridControl1;
        private System.Windows.Forms.ComboBox cmbTXLimit;
        private System.Windows.Forms.ComboBox cmbSquelchLevel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbScanMode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbFTO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDisplayMode;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TextBox txtTXStop;
        private System.Windows.Forms.TextBox txtTXStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStartUpCH;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox chkRogerTone;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbVoiceDelay;
        private System.Windows.Forms.ComboBox cmbVoiceLevel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbLongPress2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbLongPress1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbShotPress2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbShotPress1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Channel;
        private System.Windows.Forms.DataGridViewTextBoxColumn RXFrequency;
        private System.Windows.Forms.DataGridViewComboBoxColumn CTCSDec;
        private System.Windows.Forms.DataGridViewTextBoxColumn TXFrequency;
        private System.Windows.Forms.DataGridViewComboBoxColumn CTCSEnc;
        private System.Windows.Forms.DataGridViewComboBoxColumn ScanningAdd;
        private System.Windows.Forms.DataGridViewComboBoxColumn WN;
        private System.Windows.Forms.DataGridViewComboBoxColumn TXPower;
        private System.Windows.Forms.DataGridViewComboBoxColumn BusyLock;
        private System.Windows.Forms.DataGridViewComboBoxColumn Scrambling;
        private System.Windows.Forms.DataGridViewComboBoxColumn Companding;
        private System.Windows.Forms.DataGridViewComboBoxColumn Repeater;
        private System.Windows.Forms.DataGridViewComboBoxColumn PPTID;
    }
}