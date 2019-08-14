using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLogin.FileManag
{
   public class FileManager
    {
        public string FileName(string Photo)
        {
            string path = ConfigurationManager.AppSettings["Pathh"].ToString();
            string FullPath = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\", path, Photo));

            return FullPath;
        }

        public byte[] ReadFromFile(string path)
        {
            byte[] array = null;
            using (FileStream stream = File.Open(path, FileMode.Open))
            {
                array = new byte[stream.Length];
                stream.Read(array, 0, array.Length);
            }
            return array;
        }
    }
}
