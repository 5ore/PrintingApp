using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Management;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using PrintingStatus.Properties;


namespace PrintingStatus
{
    public partial class Form1 : Form
    {
        public int printers, recentErrors, recentWarnings, totalPages, pagesToday, holdReleaseJobs;
        public string current_state;
        public Form1()
        {   
            printers = recentErrors = recentWarnings =  holdReleaseJobs = 0;
            InitializeComponent();
            pictureBox1.Image = Resources.dashboard;
            pictureBox2.Image = Resources.log;
            pictureBox3.Image = Resources.printers;
            pictureBox4.Image = Resources.reports;
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
            btnPrices.Visible = false;


            SetLabels();
            WaitForTime();
            PullData();
            listBox1.Visible = false;
            lbNoFilesFound.Visible = false;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Printer");
            foreach (ManagementObject printer in searcher.Get())
            {
                string status = printer.Properties["PrinterStatus"].Value.ToString();
                switch (printer.Properties["PrinterStatus"].Value.ToString())
                {
                    case "1": current_state = "Other"; break;
                    case "2": current_state = "Unkown"; break;
                    case "3": current_state = "Idle"; break;
                    case "4": current_state = "Printing"; break;
                    case "5": current_state = "Warmup"; break;
                    case "6": current_state = "Stopped printing"; break;
                    case "7": current_state = "Offline"; break;
                }
                this.dgvPrinterStatus.Rows.Add(printer["Name"].ToString(), current_state);

                if (status.Trim() != "2" && status.Trim() != "7")
                { 
                    clbPrinters.Items.Add(printer["Name"].ToString());
                    comboBox3.Items.Add(printer["Name"].ToString());
                    printers++;
                }
                SetLabels();
             /*   if (dataGridView2.Rows.Count == 0)
                {
                    lbPrintLogToday.Text = "No files have been printed today.";
                    dataGridView2.Visible = false;
                }*/

                   
             //   MessageBox.Show("Name: "+printer["Name"].ToString()+"\nStatus: "+status.Trim());
                //  MessageBox.Show("Status: "+printer["Status"].ToString());
            }

            //PullData();
            /*   int ActivePrintersCount = 0;
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Printer");
                foreach (ManagementObject printer in searcher.Get())
                {
            if (printer["Availability"].ToString() == "true")
                        ActivePrintersCount++;
                }
                ManagementObject[] printers = new ManagementObject[ActivePrintersCount];
                int j = 0;
                foreach (ManagementObject printer in searcher.Get())
                {
                    try
                    {
                        MessageBox.Show(printer["Availability"].ToString());
                        if (printer["Availability"].ToString() == "true")
                        {
                            printers[j] = printer;
                            j++;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }*/
        }

        // your data table
        private DataTable dataTable = new DataTable();

        // your method to pull data from database to datatable   
        public void PullData()
        {
            //string connString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\lukaz\Documents\Printers.mdf; Integrated Security = True; Connect Timeout = 30";

            //SqlConnection connection = new SqlConnection(connString);
            //SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM PrintLog",connection);

            //DataTable dt = new DataTable();

            //adapter.Fill(dt);

            //connection.Close();

            try
            {//sg2plcpnl0257.prod.sin2.secureserver.net
                MySqlConnection con1 = new MySqlConnection("Server=sg2plcpnl0257.prod.sin2.secureserver.net; Port=3306; Database=newdataase123; Uid=newdbuser; Pwd=5core123;");
                con1.Open();
                MessageBox.Show("Connection established");
                //string query = "INSERT INTO TestTable VALUES(1,'myname','myusername','mypass')";
                //MySqlCommand cmd = new MySqlCommand(query, con1);
                //cmd.ExecuteNonQuery();
                con1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



           



        }

        public void SetLabels()
        {
            lbPrinters.Text = printers.ToString();
            lbRecentErrors.Text = recentErrors.ToString();
            lbRecentWarnings.Text = recentWarnings.ToString();
            lbTotalPages.Text = totalPages.ToString();
            lbPagesToday.Text = pagesToday.ToString();
            lbHoldReleaseJobs.Text = holdReleaseJobs.ToString();
        }






        private async void WaitForTime()
        {
            await Task.Delay(new TimeSpan(0, 0, 1));
            Tips tips = new Tips();
            tips.Show(); 
        }


        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.dashboard;
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectTab(1);
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Resources.printers;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Resources.reports;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Resources.dashboard2;
            pictureBox1.Cursor = Cursors.Hand;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.log2;
            pictureBox2.Cursor = Cursors.Hand;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Image = Resources.printers2;
            pictureBox3.Cursor = Cursors.Hand;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Image = Resources.reports2;
            pictureBox4.Cursor = Cursors.Hand;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectTab(2);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectTab(3);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void clbPrinters_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (clbPrinters.SelectedIndex==0)
            {
                if (clbPrinters.GetItemCheckState(clbPrinters.SelectedIndex) == CheckState.Unchecked)
                {
                    for (int i = 0; i < clbPrinters.Items.Count; i++)
                    {
                        clbPrinters.SetItemCheckState(i, CheckState.Checked);
                    }
                }
                else
                {
                    for (int i = 0; i < clbPrinters.Items.Count; i++)
                    {
                        clbPrinters.SetItemCheckState(i, CheckState.Unchecked);
                    }
                }
            }
            else
            {
                if (clbPrinters.SelectedIndex == -1)
                    clbPrinters.SelectedIndex = -1;
                else if (clbPrinters.GetItemCheckState(clbPrinters.SelectedIndex) == CheckState.Unchecked)
                    clbPrinters.SetItemCheckState(clbPrinters.SelectedIndex, CheckState.Checked);
                else
                    clbPrinters.SetItemCheckState(clbPrinters.SelectedIndex, CheckState.Unchecked);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tpPrinters_Click(object sender, EventArgs e)
        {

        }

        private void clbPrinters_ItemCheck(object sender, ItemCheckEventArgs e)
        {
           
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Resources.log;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'printersDataSet.PrintLog' table. You can move, or remove it, as needed.
            //this.printLogTableAdapter.Fill(this.printersDataSet.PrintLog);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 && clbPrinters.SelectedIndex == -1)
                MessageBox.Show("Please select how many and which available printers you'd like to see.");
            else if (comboBox1.SelectedIndex == -1)
                MessageBox.Show("Please select how many available printers you'd like to see.");
            else if (clbPrinters.SelectedIndex == -1)
                MessageBox.Show("Please select which kind of available printers you'd like to see.");
            else
            {
                lbNoFilesFound.Visible = true;
            }

        }

        private void btnPrices_Click(object sender, EventArgs e)
        {
            var form = new ChangePrices();
            form.Show();

        }

    }
}
