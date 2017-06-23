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

namespace PrintingStatus
{
    public partial class Tips : Form
    {
        private int nextIndex;
        private string[] tips = null; 
        public Tips()
        {
            InitializeComponent();
            GetTips();
            ShowRandomHint();
        }

        private void GetTips()
        {
            string tips = "";
            try
            {
                tips = TipsGenerator.Generate(
                System.AppDomain.CurrentDomain.BaseDirectory + "Tips.txt");
                if (tips == null)
                    throw new Exception("Tips.cs Line: 31 -Lukaz");
            }
            catch(Exception e)
            {
                StreamWriter writer = new StreamWriter(
                    System.AppDomain.CurrentDomain.BaseDirectory + "LogFile.txt");
                writer.WriteLine(DateTime.Now);
                writer.WriteLine(e.Message);
                writer.Close();
                Hide();
                return;
            }
            this.tips = tips.Split(new[] { "--END" }, StringSplitOptions.None);
        }

        private void ShowRandomHint()
        {
            int nextIndex;
            try
            {
                do
                {
                    nextIndex = new Random().Next(0, tips.Length);
                } while (nextIndex == this.nextIndex);

                this.nextIndex = nextIndex;
                lbHint.Text = tips[nextIndex];
            }
            catch(Exception e)
            {
                StreamWriter writer = new StreamWriter(
                    System.AppDomain.CurrentDomain.BaseDirectory + "LogFile.txt",true);
                writer.WriteLine(DateTime.Now);
                writer.WriteLine(e.Message + " Tips.cs Line: 58");
                writer.Close();
                Hide();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ShowRandomHint();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Tips_Load(object sender, EventArgs e)
        {
            
        }
    }
}
