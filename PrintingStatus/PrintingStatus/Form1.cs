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
    public enum PrinterState
    {
        Other,
        Unknown,
        Idle,
        Printing,
        Warmup,
        Stopped,
        Offline
    }
    public class Printer
    {
        string name;
        PrinterState state;

        public Printer() { }
        public Printer(string name = "", PrinterState state = PrinterState.Unknown)
        {
            this.name = name;
            this.state = state;
        }
    }
    public partial class Form1 : Form
    {
        List<Printer> printers = new List<Printer>();
        public Form1()
        {
            InitializeComponent();
            WaitForTime();
            //PullData();
            //getPrinters();
            
        }
        // your data table
       /* private DataTable dataTable = new DataTable();

        public void getPrinters()
        {
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher("SELECT * FROM Win32_Printer");

            foreach (ManagementObject printer in searcher.Get())
            {
                string printerName = printer["Name"].ToString();
                printers.Add(new Printer(printerName, (PrinterState)printer["PrinterStatus"]));
            }
            Printer[] printersArray = printers.ToArray();
            foreach ()
            {

            } 
        }
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
        */
        
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
          /*  // TODO: This line of code loads data into the 'printersDataSet.PrintLog' table. You can move, or remove it, as needed.
            this.printLogTableAdapter.Fill(this.printersDataSet.PrintLog);
            */
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*private void button1_Click(object sender, EventArgs e)
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

        }*/

    }
}