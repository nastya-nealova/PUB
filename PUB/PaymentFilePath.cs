using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// for work with Directory and file
using System.IO;

namespace PUB
{
    class PaymentFilePath
    {
        private string location_path;
        private string file_name;

        public string LocationPath
        {
            get
            {
                return location_path;
            }
            set
            {
                if (CheckPathExist(value))
                {
                    location_path = value;
                }
            }
        }
        public string FileName
        {
            get
            {
                return file_name;
            }
            set
            {
                if (CheckFileExist(value))
                {
                    string oldFileName = $"{location_path}\\{file_name}";
                    string newFileName = $"{location_path}\\{value}";
                    try
                    {
                        File.Move(oldFileName, newFileName); // Rename the oldFileName into newFileName
                        File.Delete(newFileName); // Delete the existing file if exists
                        file_name = value;
                    }
                    catch (Exception)
                    {
                        throw new Exception("FileName Exception");
                    }
                }
            }
        }

        private bool CheckPathExist(string path)
        {
            if (Directory.Exists(path))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckFileExist(string name)
        {
            string path = $"{location_path}\\{name}";
            if (File.Exists(path))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public PaymentFilePath(string file_name, string location_path)
        {
            FileName = file_name;
            LocationPath = location_path;
        }
    }
}
