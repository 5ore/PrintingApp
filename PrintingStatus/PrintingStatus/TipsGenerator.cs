using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintingStatus
{
    public static class TipsGenerator
    {
        
        /// <summary>
        /// Generates all the tips from a given file.
        /// </summary>
        /// <param name="path">The path to the text file.</param>
        public static string Generate(string path)
        {
            string result = "";
            try
            {
                StreamReader stream = new StreamReader(path);
                while (!stream.EndOfStream)
                {
                    result += stream.ReadLine();
                }
                return result;
            }
            catch(IOException e)
            {
                StreamWriter writer = new StreamWriter(System.AppDomain.CurrentDomain.BaseDirectory +
                "LogFile.txt");
                writer.WriteLine(DateTime.Now);
                writer.WriteLine(e.Message);
                writer.Close();

                return null;
            }
            catch(Exception e)
            {
                StreamWriter writer = new StreamWriter(System.AppDomain.CurrentDomain.BaseDirectory +
                "LogFile.txt");
                writer.WriteLine(DateTime.Now);
                writer.WriteLine(e.Message);
                writer.Close();
                return null;
            }
        }
    }
}
