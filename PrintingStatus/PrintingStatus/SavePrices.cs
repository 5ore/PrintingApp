using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Windows.Forms;

namespace PrintingStatus
{
    class SavePrices
    {
        public static string selectedPrinter;

        public static float  BA4;
        public static float BA3;
        public static float CA4;
        public static float CA3;

        public static void LoadData(string printerAttribute)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(AppDomain.CurrentDomain.BaseDirectory + "prices.xml");

            XmlNodeList docList = doc.SelectNodes(
                "//printer[@name='" + printerAttribute + "']");

            foreach (XmlNode node in docList)
            {
                switch (node.Name)
                {
                    case "BA4": BA4 = float.Parse(Decrypt(node.InnerText)); break;
                    case "BA3": BA3 = float.Parse(Decrypt(node.InnerText)); break;
                    case "CA4": CA4 = float.Parse(Decrypt(node.InnerText)); break;
                    case "CA3": CA3 = float.Parse(Decrypt(node.InnerText)); break;
                }
            
               // string text = node.InnerText;
            }
        }

        public static void SaveData(string printerName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(AppDomain.CurrentDomain.BaseDirectory + "prices.xml");

            XmlNodeList docList = doc.SelectNodes(
                "//printer[@name='" + printerName + "']");

            foreach (XmlNode node in docList)
            {
                switch (node.Name)
                {
                    case "BA4": node.InnerText = Encrypt(BA4.ToString()); break;
                    case "BA3": node.InnerText = Encrypt(BA3.ToString()); break;
                    case "CA4": node.InnerText = Encrypt(CA4.ToString()); break;
                    case "CA3": node.InnerText = Encrypt(CA3.ToString()); break;
                }

                // string text = node.InnerText;
            }
        }

        public static void CreateXML()
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);

            XmlElement container = doc.CreateElement(string.Empty, "printers", string.Empty);
            doc.AppendChild(container);

            doc.Save(AppDomain.CurrentDomain.BaseDirectory + "prices.xml");
        }

        /// <summary>
        /// Adds another printer to the XML document.
        /// </summary>
        /// <param name="printerName">The name of the printer</param>
        public static void AppendPrinter(string printerName)
        {
            XmlDocument doc = new XmlDocument();

            doc.Load(AppDomain.CurrentDomain.BaseDirectory + "prices.xml");

            XmlElement printerElement = doc.CreateElement(string.Empty, "printer", string.Empty);
            printerElement.SetAttribute("name", printerName);
            doc.SelectSingleNode("//printers").AppendChild(printerElement);

            XmlElement element2 = doc.CreateElement(string.Empty, "BA4", string.Empty);
            XmlText text1 = doc.CreateTextNode(Encrypt(BA4.ToString()));
            element2.AppendChild(text1);
            printerElement.AppendChild(element2);
            XmlElement element3 = doc.CreateElement(string.Empty, "BA3", string.Empty);
            XmlText text2 = doc.CreateTextNode(Encrypt(BA3.ToString()));
            element3.AppendChild(text2);
            printerElement.AppendChild(element3);
            XmlElement element4 = doc.CreateElement(string.Empty, "CA4", string.Empty);
            XmlText text3 = doc.CreateTextNode(Encrypt(CA4.ToString()));
            element4.AppendChild(text3);
            printerElement.AppendChild(element4);
            XmlElement element5 = doc.CreateElement(string.Empty, "CA3", string.Empty);
            XmlText text4 = doc.CreateTextNode(Encrypt(CA3.ToString()));
            element5.AppendChild(text4);
            printerElement.AppendChild(element5);
            doc.Save(AppDomain.CurrentDomain.BaseDirectory + "prices.xml");
        }

        /// <summary>
        /// Adds another printer to the XML document and sets the default prices.
        /// </summary>
        /// <param name="printerName">The name of the printer</param>
        /// <param name="black_A4"></param>
        /// <param name="black_A3"></param>
        /// <param name="color_A4"></param>
        /// <param name="color_A3"></param>
        public static void AppendPrinter(string printerName,
            float black_A4, float black_A3, float color_A4, float color_A3)
        {
            XmlDocument doc = new XmlDocument();

            XmlElement printerElement = doc.CreateElement(string.Empty, "printer", string.Empty);
            printerElement.SetAttribute("name", printerName);
            doc.AppendChild(printerElement);

            XmlElement element2 = doc.CreateElement(string.Empty, "BA4", string.Empty);
            XmlText text1 = doc.CreateTextNode(Encrypt(black_A4.ToString()));
            element2.AppendChild(text1);
            printerElement.AppendChild(element2);
            XmlElement element3 = doc.CreateElement(string.Empty, "BA3", string.Empty);
            XmlText text2 = doc.CreateTextNode(Encrypt(black_A3.ToString()));
            element3.AppendChild(text2);
            printerElement.AppendChild(element3);
            XmlElement element4 = doc.CreateElement(string.Empty, "CA4", string.Empty);
            XmlText text3 = doc.CreateTextNode(Encrypt(color_A4.ToString()));
            element4.AppendChild(text3);
            printerElement.AppendChild(element4);
            XmlElement element5 = doc.CreateElement(string.Empty, "CA3", string.Empty);
            XmlText text4 = doc.CreateTextNode(Encrypt(color_A3.ToString()));
            element5.AppendChild(text4);
            printerElement.AppendChild(element5);
            doc.Save(AppDomain.CurrentDomain.BaseDirectory + "prices.xml");
        }

        public static string Encrypt(string plainText)
        {
            byte[] initVectorBytes = Encoding.ASCII.GetBytes("teto1620@#$%asdf");
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] keyBytes = Encoding.Unicode.GetBytes("_+)&qwer9512popo");
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
            cryptoStream.FlushFinalBlock();
            byte[] cipherTextBytes = memoryStream.ToArray();
            memoryStream.Close();
            cryptoStream.Close();
            string cipherText = Convert.ToBase64String(cipherTextBytes);
            return cipherText;
        }
        public static string Decrypt(string cipherText)
        {
            byte[] initVectorBytes = Encoding.ASCII.GetBytes("teto1620@#$%asdf");
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
            byte[] keyBytes = Encoding.Unicode.GetBytes("_+)&qwer9512popo");
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
            MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
            CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];
            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            string plainText = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
            return plainText;
        }

        public static bool FindPrinter(string printerName)
        {
            XmlDocument doc = new XmlDocument();

            try
            {
                doc.Load(AppDomain.CurrentDomain.BaseDirectory + "prices.xml");
            }
            catch (Exception e)
            {
                XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                XmlElement root = doc.DocumentElement;
                doc.InsertBefore(xmlDeclaration, root);
            }

            XmlNodeList elemList;

            try
            {
                elemList = doc.SelectNodes("//printers/printer");
                MessageBox.Show(elemList.Count.ToString());
                if (elemList.Count == 0)
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                return false;
            }

            foreach (XmlNode node in elemList)
            {
                MessageBox.Show(node.Attributes["name"].Value.ToString()
                    + " == " + printerName);
                if (node.Attributes["name"].Value.ToString() == printerName)
                {
                    MessageBox.Show("True");
                    return true;
                }
            }

            return false;
        }
    }

}
