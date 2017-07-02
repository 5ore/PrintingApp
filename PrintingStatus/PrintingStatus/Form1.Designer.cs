namespace PrintingStatus
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpDashboard = new System.Windows.Forms.TabPage();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbHoldReleaseJobs = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbPagesToday = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbTotalPages = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbRecentWarnings = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbRecentErrors = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbPrinters = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tpLog = new System.Windows.Forms.TabPage();
            this.lbNoFilesFound = new System.Windows.Forms.Label();
            this.clbPrinters = new System.Windows.Forms.CheckedListBox();
            this.lbLog_Printers = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tpPrinters = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPrinterStatus = new System.Windows.Forms.DataGridView();
            this.Printer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpReports = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.printLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printersDataSet = new PrintingStatus.PrintersDataSet();
            this.printLogTableAdapter = new PrintingStatus.PrintersDataSetTableAdapters.PrintLogTableAdapter();
            this.lbSelectPrice = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tpDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tpLog.SuspendLayout();
            this.tpPrinters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrinterStatus)).BeginInit();
            this.tpReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpDashboard);
            this.tabControl.Controls.Add(this.tpLog);
            this.tabControl.Controls.Add(this.tpPrinters);
            this.tabControl.Controls.Add(this.tpReports);
            this.tabControl.Location = new System.Drawing.Point(9, 9);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(0, 0);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(674, 455);
            this.tabControl.TabIndex = 0;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // tpDashboard
            // 
            this.tpDashboard.BackColor = System.Drawing.Color.Transparent;
            this.tpDashboard.BackgroundImage = global::PrintingStatus.Properties.Resources.background;
            this.tpDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpDashboard.Controls.Add(this.pictureBox5);
            this.tpDashboard.Controls.Add(this.pictureBox4);
            this.tpDashboard.Controls.Add(this.pictureBox3);
            this.tpDashboard.Controls.Add(this.pictureBox2);
            this.tpDashboard.Controls.Add(this.pictureBox1);
            this.tpDashboard.Controls.Add(this.label2);
            this.tpDashboard.Controls.Add(this.panel1);
            this.tpDashboard.Location = new System.Drawing.Point(4, 22);
            this.tpDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.tpDashboard.Name = "tpDashboard";
            this.tpDashboard.Size = new System.Drawing.Size(666, 429);
            this.tpDashboard.TabIndex = 0;
            this.tpDashboard.Text = "Dashboard";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::PrintingStatus.Properties.Resources.testlogo;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(15, 16);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(201, 113);
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 337);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(225, 67);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseEnter += new System.EventHandler(this.pictureBox4_MouseEnter);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(0, 272);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(225, 75);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.pictureBox3_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(0, 207);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(216, 59);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(15, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 59);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(273, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Basic info";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(192)))), ((int)(((byte)(206)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.lbHoldReleaseJobs);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.lbPagesToday);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.lbTotalPages);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lbRecentWarnings);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lbRecentErrors);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lbPrinters);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Font = new System.Drawing.Font("Niagara Engraved", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.Location = new System.Drawing.Point(274, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 235);
            this.panel1.TabIndex = 3;
            // 
            // lbHoldReleaseJobs
            // 
            this.lbHoldReleaseJobs.AutoSize = true;
            this.lbHoldReleaseJobs.Font = new System.Drawing.Font("Niagara Engraved", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbHoldReleaseJobs.Location = new System.Drawing.Point(131, 197);
            this.lbHoldReleaseJobs.Name = "lbHoldReleaseJobs";
            this.lbHoldReleaseJobs.Size = new System.Drawing.Size(54, 16);
            this.lbHoldReleaseJobs.TabIndex = 15;
            this.lbHoldReleaseJobs.Text = "label17";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Niagara Engraved", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label16.Location = new System.Drawing.Point(1, 197);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 16);
            this.label16.TabIndex = 14;
            this.label16.Text = "Hold/release jobs";
            // 
            // lbPagesToday
            // 
            this.lbPagesToday.AutoSize = true;
            this.lbPagesToday.Font = new System.Drawing.Font("Niagara Engraved", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbPagesToday.Location = new System.Drawing.Point(131, 159);
            this.lbPagesToday.Name = "lbPagesToday";
            this.lbPagesToday.Size = new System.Drawing.Size(54, 16);
            this.lbPagesToday.TabIndex = 13;
            this.lbPagesToday.Text = "label15";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Niagara Engraved", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(1, 159);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 16);
            this.label14.TabIndex = 12;
            this.label14.Text = "Pages today";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbTotalPages
            // 
            this.lbTotalPages.AutoSize = true;
            this.lbTotalPages.Font = new System.Drawing.Font("Niagara Engraved", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTotalPages.Location = new System.Drawing.Point(131, 123);
            this.lbTotalPages.Name = "lbTotalPages";
            this.lbTotalPages.Size = new System.Drawing.Size(54, 16);
            this.lbTotalPages.TabIndex = 11;
            this.lbTotalPages.Text = "label13";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Niagara Engraved", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(2, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "Total pages";
            // 
            // lbRecentWarnings
            // 
            this.lbRecentWarnings.AutoSize = true;
            this.lbRecentWarnings.Font = new System.Drawing.Font("Niagara Engraved", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbRecentWarnings.Location = new System.Drawing.Point(131, 87);
            this.lbRecentWarnings.Name = "lbRecentWarnings";
            this.lbRecentWarnings.Size = new System.Drawing.Size(53, 16);
            this.lbRecentWarnings.TabIndex = 9;
            this.lbRecentWarnings.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Niagara Engraved", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(1, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Recent warnings";
            // 
            // lbRecentErrors
            // 
            this.lbRecentErrors.AutoSize = true;
            this.lbRecentErrors.Font = new System.Drawing.Font("Niagara Engraved", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbRecentErrors.Location = new System.Drawing.Point(131, 50);
            this.lbRecentErrors.Name = "lbRecentErrors";
            this.lbRecentErrors.Size = new System.Drawing.Size(46, 16);
            this.lbRecentErrors.TabIndex = 7;
            this.lbRecentErrors.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Niagara Engraved", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(1, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Recent errors";
            // 
            // lbPrinters
            // 
            this.lbPrinters.AutoSize = true;
            this.lbPrinters.Font = new System.Drawing.Font("Niagara Engraved", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbPrinters.Location = new System.Drawing.Point(131, 13);
            this.lbPrinters.Name = "lbPrinters";
            this.lbPrinters.Size = new System.Drawing.Size(46, 16);
            this.lbPrinters.TabIndex = 5;
            this.lbPrinters.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Niagara Engraved", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(1, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Printers";
            // 
            // tpLog
            // 
            this.tpLog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpLog.BackgroundImage")));
            this.tpLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpLog.Controls.Add(this.lbNoFilesFound);
            this.tpLog.Controls.Add(this.clbPrinters);
            this.tpLog.Controls.Add(this.lbLog_Printers);
            this.tpLog.Controls.Add(this.button1);
            this.tpLog.Controls.Add(this.listBox1);
            this.tpLog.Controls.Add(this.label1);
            this.tpLog.Controls.Add(this.comboBox1);
            this.tpLog.Location = new System.Drawing.Point(4, 22);
            this.tpLog.Name = "tpLog";
            this.tpLog.Padding = new System.Windows.Forms.Padding(3);
            this.tpLog.Size = new System.Drawing.Size(666, 429);
            this.tpLog.TabIndex = 1;
            this.tpLog.Text = "Log";
            this.tpLog.UseVisualStyleBackColor = true;
            // 
            // lbNoFilesFound
            // 
            this.lbNoFilesFound.AutoSize = true;
            this.lbNoFilesFound.BackColor = System.Drawing.Color.Transparent;
            this.lbNoFilesFound.Font = new System.Drawing.Font("Calibri", 10F);
            this.lbNoFilesFound.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbNoFilesFound.Location = new System.Drawing.Point(6, 164);
            this.lbNoFilesFound.Name = "lbNoFilesFound";
            this.lbNoFilesFound.Size = new System.Drawing.Size(88, 17);
            this.lbNoFilesFound.TabIndex = 9;
            this.lbNoFilesFound.Text = "No files found.";
            // 
            // clbPrinters
            // 
            this.clbPrinters.FormattingEnabled = true;
            this.clbPrinters.Items.AddRange(new object[] {
            "All printers"});
            this.clbPrinters.Location = new System.Drawing.Point(274, 50);
            this.clbPrinters.Name = "clbPrinters";
            this.clbPrinters.Size = new System.Drawing.Size(148, 94);
            this.clbPrinters.TabIndex = 8;
            this.clbPrinters.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbPrinters_ItemCheck);
            this.clbPrinters.SelectedIndexChanged += new System.EventHandler(this.clbPrinters_SelectedIndexChanged);
            // 
            // lbLog_Printers
            // 
            this.lbLog_Printers.AutoSize = true;
            this.lbLog_Printers.BackColor = System.Drawing.Color.Transparent;
            this.lbLog_Printers.Font = new System.Drawing.Font("Calibri", 10F);
            this.lbLog_Printers.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbLog_Printers.Location = new System.Drawing.Point(271, 16);
            this.lbLog_Printers.Name = "lbLog_Printers";
            this.lbLog_Printers.Size = new System.Drawing.Size(93, 17);
            this.lbLog_Printers.TabIndex = 7;
            this.lbLog_Printers.Text = "Select printers.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 198);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(370, 108);
            this.listBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select how many last printed files you want to see.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "5",
            "10",
            "20"});
            this.comboBox1.Location = new System.Drawing.Point(9, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // tpPrinters
            // 
            this.tpPrinters.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpPrinters.BackgroundImage")));
            this.tpPrinters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpPrinters.Controls.Add(this.lbSelectPrice);
            this.tpPrinters.Controls.Add(this.label3);
            this.tpPrinters.Controls.Add(this.dgvPrinterStatus);
            this.tpPrinters.Location = new System.Drawing.Point(4, 22);
            this.tpPrinters.Name = "tpPrinters";
            this.tpPrinters.Padding = new System.Windows.Forms.Padding(3);
            this.tpPrinters.Size = new System.Drawing.Size(666, 429);
            this.tpPrinters.TabIndex = 2;
            this.tpPrinters.Text = "Printers";
            this.tpPrinters.UseVisualStyleBackColor = true;
            this.tpPrinters.Click += new System.EventHandler(this.tpPrinters_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(159, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 41);
            this.label3.TabIndex = 1;
            this.label3.Text = "Here you can see the status of every printer installed on your computer.";
            // 
            // dgvPrinterStatus
            // 
            this.dgvPrinterStatus.AllowUserToAddRows = false;
            this.dgvPrinterStatus.AllowUserToDeleteRows = false;
            this.dgvPrinterStatus.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvPrinterStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrinterStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrinterStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Printer,
            this.Status});
            this.dgvPrinterStatus.Location = new System.Drawing.Point(151, 107);
            this.dgvPrinterStatus.Name = "dgvPrinterStatus";
            this.dgvPrinterStatus.ReadOnly = true;
            this.dgvPrinterStatus.RowHeadersWidth = 90;
            this.dgvPrinterStatus.Size = new System.Drawing.Size(293, 177);
            this.dgvPrinterStatus.TabIndex = 0;
            this.dgvPrinterStatus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrinterStatus_CellContentClick);
            // 
            // Printer
            // 
            this.Printer.HeaderText = "Printer";
            this.Printer.Name = "Printer";
            this.Printer.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // tpReports
            // 
            this.tpReports.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpReports.BackgroundImage")));
            this.tpReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpReports.Controls.Add(this.dataGridView3);
            this.tpReports.Controls.Add(this.button2);
            this.tpReports.Controls.Add(this.comboBox3);
            this.tpReports.Location = new System.Drawing.Point(4, 22);
            this.tpReports.Name = "tpReports";
            this.tpReports.Padding = new System.Windows.Forms.Padding(3);
            this.tpReports.Size = new System.Drawing.Size(666, 429);
            this.tpReports.TabIndex = 3;
            this.tpReports.Text = "Reports";
            this.tpReports.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(19, 137);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(366, 263);
            this.dataGridView3.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show report";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "All printers"});
            this.comboBox3.Location = new System.Drawing.Point(19, 49);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 0;
            // 
            // printLogBindingSource
            // 
            this.printLogBindingSource.DataMember = "PrintLog";
            this.printLogBindingSource.DataSource = this.printersDataSet;
            // 
            // printersDataSet
            // 
            this.printersDataSet.DataSetName = "PrintersDataSet";
            this.printersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // printLogTableAdapter
            // 
            this.printLogTableAdapter.ClearBeforeFill = true;
            // 
            // lbSelectPrice
            // 
            this.lbSelectPrice.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbSelectPrice.Location = new System.Drawing.Point(162, 71);
            this.lbSelectPrice.Name = "lbSelectPrice";
            this.lbSelectPrice.Size = new System.Drawing.Size(157, 33);
            this.lbSelectPrice.TabIndex = 2;
            this.lbSelectPrice.Text = "Click on any printer to view or adjust the pricing";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PrintingStatus.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(692, 491);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Printer System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tpDashboard.ResumeLayout(false);
            this.tpDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tpLog.ResumeLayout(false);
            this.tpLog.PerformLayout();
            this.tpPrinters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrinterStatus)).EndInit();
            this.tpReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printersDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpDashboard;
        private System.Windows.Forms.TabPage tpLog;
        private System.Windows.Forms.TabPage tpPrinters;
        private System.Windows.Forms.TabPage tpReports;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private PrintersDataSet printersDataSet;
        private System.Windows.Forms.BindingSource printLogBindingSource;
        private PrintersDataSetTableAdapters.PrintLogTableAdapter printLogTableAdapter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox clbPrinters;
        private System.Windows.Forms.Label lbLog_Printers;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbNoFilesFound;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbPrinters;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbRecentErrors;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbRecentWarnings;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbHoldReleaseJobs;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbPagesToday;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbTotalPages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DataGridView dgvPrinterStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Printer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSelectPrice;
    }
}

