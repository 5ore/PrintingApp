using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace PrintingStatus
{
    class SavePrices
    {
        public static float  BA4;
        public static float BA3;
        public static float CA4;
        public static float CA3;

        public static void LoadData()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(AppDomain.CurrentDomain.BaseDirectory + "prices.xml");

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
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

        public static void SaveData()
        {
            XmlDocument doc = new XmlDocument();

            //(1) the xml declaration is recommended, but not mandatory
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);

            //(2) string.Empty makes cleaner code
            XmlElement element1 = doc.CreateElement(string.Empty, "body", string.Empty);
            doc.AppendChild(element1);
            XmlElement element2 = doc.CreateElement(string.Empty, "BA4", string.Empty);
            XmlText text1 = doc.CreateTextNode(Encrypt(BA4.ToString()));
            element2.AppendChild(text1);
            element1.AppendChild(element2);
            XmlElement element3 = doc.CreateElement(string.Empty, "BA3", string.Empty);
            XmlText text2 = doc.CreateTextNode(Encrypt(BA3.ToString()));
            element3.AppendChild(text2);
            element1.AppendChild(element3);
            XmlElement element4 = doc.CreateElement(string.Empty, "CA4", string.Empty);
            XmlText text3 = doc.CreateTextNode(Encrypt(CA4.ToString()));
            element4.AppendChild(text3);
            element1.AppendChild(element4);
            XmlElement element5 = doc.CreateElement(string.Empty, "CA3", string.Empty);
            XmlText text4 = doc.CreateTextNode(Encrypt(CA3.ToString()));
            element5.AppendChild(text4);
            element1.AppendChild(element5);
            doc.Save(AppDomain.CurrentDomain.BaseDirectory+"prices.xml");


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

    }


}
