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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpDashboard = new System.Windows.Forms.TabPage();
            this.tpLog = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tpPrinters = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.printLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printersDataSet = new PrintingStatus.PrintersDataSet();
            this.tpReports = new System.Windows.Forms.TabPage();
            this.printLogTableAdapter = new PrintingStatus.PrintersDataSetTableAdapters.PrintLogTableAdapter();
            this.printerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blackA4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blackA3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blacktotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coloredA4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coloredA3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coloredtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duplexPagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lbPrintLogToday = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lbLog_Printers = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tpDashboard.SuspendLayout();
            this.tpLog.SuspendLayout();
            this.tpPrinters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printersDataSet)).BeginInit();
            this.tpReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpDashboard);
            this.tabControl.Controls.Add(this.tpLog);
            this.tabControl.Controls.Add(this.tpPrinters);
            this.tabControl.Controls.Add(this.tpReports);
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(413, 465);
            this.tabControl.TabIndex = 0;
            // 
            // tpDashboard
            // 
            this.tpDashboard.Controls.Add(this.lbPrintLogToday);
            this.tpDashboard.Controls.Add(this.dataGridView2);
            this.tpDashboard.Location = new System.Drawing.Point(4, 22);
            this.tpDashboard.Name = "tpDashboard";
            this.tpDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tpDashboard.Size = new System.Drawing.Size(405, 439);
            this.tpDashboard.TabIndex = 0;
            this.tpDashboard.Text = "Dashboard";
            this.tpDashboard.UseVisualStyleBackColor = true;
            // 
            // tpLog
            // 
            this.tpLog.Controls.Add(this.checkedListBox1);
            this.tpLog.Controls.Add(this.lbLog_Printers);
            this.tpLog.Controls.Add(this.button1);
            this.tpLog.Controls.Add(this.listBox1);
            this.tpLog.Controls.Add(this.label1);
            this.tpLog.Controls.Add(this.comboBox1);
            this.tpLog.Location = new System.Drawing.Point(4, 22);
            this.tpLog.Name = "tpLog";
            this.tpLog.Padding = new System.Windows.Forms.Padding(3);
            this.tpLog.Size = new System.Drawing.Size(405, 439);
            this.tpLog.TabIndex = 1;
            this.tpLog.Text = "Log";
            this.tpLog.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 54);
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
            this.listBox1.Location = new System.Drawing.Point(17, 170);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(370, 108);
            this.listBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select how many last printed files you want to see.";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "5",
            "10",
            "20"});
            this.comboBox1.Location = new System.Drawing.Point(9, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // tpPrinters
            // 
            this.tpPrinters.Controls.Add(this.dataGridView1);
            this.tpPrinters.Location = new System.Drawing.Point(4, 22);
            this.tpPrinters.Name = "tpPrinters";
            this.tpPrinters.Padding = new System.Windows.Forms.Padding(3);
            this.tpPrinters.Size = new System.Drawing.Size(405, 439);
            this.tpPrinters.TabIndex = 2;
            this.tpPrinters.Text = "Printers";
            this.tpPrinters.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.printerNameDataGridViewTextBoxColumn,
            this.dateTimeDataGridViewTextBoxColumn,
            this.blackA4DataGridViewTextBoxColumn,
            this.blackA3DataGridViewTextBoxColumn,
            this.blacktotalDataGridViewTextBoxColumn,
            this.coloredA4DataGridViewTextBoxColumn,
            this.coloredA3DataGridViewTextBoxColumn,
            this.coloredtotalDataGridViewTextBoxColumn,
            this.duplexPagesDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.printLogBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(393, 302);
            this.dataGridView1.TabIndex = 0;
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
            // tpReports
            // 
            this.tpReports.Controls.Add(this.dataGridView3);
            this.tpReports.Controls.Add(this.button2);
            this.tpReports.Controls.Add(this.comboBox3);
            this.tpReports.Location = new System.Drawing.Point(4, 22);
            this.tpReports.Name = "tpReports";
            this.tpReports.Padding = new System.Windows.Forms.Padding(3);
            this.tpReports.Size = new System.Drawing.Size(405, 439);
            this.tpReports.TabIndex = 3;
            this.tpReports.Text = "Reports";
            this.tpReports.UseVisualStyleBackColor = true;
            // 
            // printLogTableAdapter
            // 
            this.printLogTableAdapter.ClearBeforeFill = true;
            // 
            // printerNameDataGridViewTextBoxColumn
            // 
            this.printerNameDataGridViewTextBoxColumn.DataPropertyName = "Printer name";
            this.printerNameDataGridViewTextBoxColumn.HeaderText = "Printer name";
            this.printerNameDataGridViewTextBoxColumn.Name = "printerNameDataGridViewTextBoxColumn";
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "Date/Time";
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "Date/Time";
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            // 
            // blackA4DataGridViewTextBoxColumn
            // 
            this.blackA4DataGridViewTextBoxColumn.DataPropertyName = "black_A4";
            this.blackA4DataGridViewTextBoxColumn.HeaderText = "black_A4";
            this.blackA4DataGridViewTextBoxColumn.Name = "blackA4DataGridViewTextBoxColumn";
            // 
            // blackA3DataGridViewTextBoxColumn
            // 
            this.blackA3DataGridViewTextBoxColumn.DataPropertyName = "black_A3";
            this.blackA3DataGridViewTextBoxColumn.HeaderText = "black_A3";
            this.blackA3DataGridViewTextBoxColumn.Name = "blackA3DataGridViewTextBoxColumn";
            // 
            // blacktotalDataGridViewTextBoxColumn
            // 
            this.blacktotalDataGridViewTextBoxColumn.DataPropertyName = "black_total";
            this.blacktotalDataGridViewTextBoxColumn.HeaderText = "black_total";
            this.blacktotalDataGridViewTextBoxColumn.Name = "blacktotalDataGridViewTextBoxColumn";
            // 
            // coloredA4DataGridViewTextBoxColumn
            // 
            this.coloredA4DataGridViewTextBoxColumn.DataPropertyName = "colored_A4";
            this.coloredA4DataGridViewTextBoxColumn.HeaderText = "colored_A4";
            this.coloredA4DataGridViewTextBoxColumn.Name = "coloredA4DataGridViewTextBoxColumn";
            // 
            // coloredA3DataGridViewTextBoxColumn
            // 
            this.coloredA3DataGridViewTextBoxColumn.DataPropertyName = "colored_A3";
            this.coloredA3DataGridViewTextBoxColumn.HeaderText = "colored_A3";
            this.coloredA3DataGridViewTextBoxColumn.Name = "coloredA3DataGridViewTextBoxColumn";
            // 
            // coloredtotalDataGridViewTextBoxColumn
            // 
            this.coloredtotalDataGridViewTextBoxColumn.DataPropertyName = "colored_total";
            this.coloredtotalDataGridViewTextBoxColumn.HeaderText = "colored_total";
            this.coloredtotalDataGridViewTextBoxColumn.Name = "coloredtotalDataGridViewTextBoxColumn";
            // 
            // duplexPagesDataGridViewTextBoxColumn
            // 
            this.duplexPagesDataGridViewTextBoxColumn.DataPropertyName = "Duplex pages";
            this.duplexPagesDataGridViewTextBoxColumn.HeaderText = "Duplex pages";
            this.duplexPagesDataGridViewTextBoxColumn.Name = "duplexPagesDataGridViewTextBoxColumn";
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "Total price";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "Total price";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(25, 30);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 98);
            this.dataGridView2.TabIndex = 0;
            // 
            // lbPrintLogToday
            // 
            this.lbPrintLogToday.AutoSize = true;
            this.lbPrintLogToday.Location = new System.Drawing.Point(25, 11);
            this.lbPrintLogToday.Name = "lbPrintLogToday";
            this.lbPrintLogToday.Size = new System.Drawing.Size(92, 13);
            this.lbPrintLogToday.TabIndex = 1;
            this.lbPrintLogToday.Text = "Files printed today";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "All printers"});
            this.comboBox3.Location = new System.Drawing.Point(19, 18);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 0;
            // 
            // lbLog_Printers
            // 
            this.lbLog_Printers.AutoSize = true;
            this.lbLog_Printers.Location = new System.Drawing.Point(155, 14);
            this.lbLog_Printers.Name = "lbLog_Printers";
            this.lbLog_Printers.Size = new System.Drawing.Size(74, 13);
            this.lbLog_Printers.TabIndex = 7;
            this.lbLog_Printers.Text = "Select printers";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "All printers"});
            this.checkedListBox1.Location = new System.Drawing.Point(158, 52);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 8;
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
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(19, 137);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(366, 263);
            this.dataGridView3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 490);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Printer System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tpDashboard.ResumeLayout(false);
            this.tpDashboard.PerformLayout();
            this.tpLog.ResumeLayout(false);
            this.tpLog.PerformLayout();
            this.tpPrinters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printersDataSet)).EndInit();
            this.tpReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private PrintersDataSet printersDataSet;
        private System.Windows.Forms.BindingSource printLogBindingSource;
        private PrintersDataSetTableAdapters.PrintLogTableAdapter printLogTableAdapter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn printerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blackA4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blackA3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blacktotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coloredA4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coloredA3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coloredtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duplexPagesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbPrintLogToday;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lbLog_Printers;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button2;
    }
}

