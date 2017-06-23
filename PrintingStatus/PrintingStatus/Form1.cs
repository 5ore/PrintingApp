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

namespace PrintingStatus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WaitForTime();
            PullData();
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
            string connString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\lukaz\Documents\Printers.mdf; Integrated Security = True; Connect Timeout = 30";

            SqlConnection connection = new SqlConnection(connString);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM PrintLog",connection);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            connection.Close();
        }

        
        private async void WaitForTime()
        {
            await Task.Delay(new TimeSpan(0, 0, 1));
            Tips tips = new Tips();
            tips.Show(); 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'printersDataSet.PrintLog' table. You can move, or remove it, as needed.
            this.printLogTableAdapter.Fill(this.printersDataSet.PrintLog);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 && comboBox2.SelectedIndex == -1)
                MessageBox.Show("Please select how many and which available printers you'd like to see.");
            else if (comboBox1.SelectedIndex == -1)
                MessageBox.Show("Please select how many available printers you'd like to see.");
            else if (comboBox2.SelectedIndex == -1)
                MessageBox.Show("Please select which kind of available printers you'd like to see.");
            else
            {

            }

        }

    }
}
