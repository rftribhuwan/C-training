using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5StringCompare
{
    class FileOperation
    {
        string firststring, secondString;
        int result;
        public FileOperation(string string1, string string2, int result)
        {
            this.firststring = string1;
            this.secondString = string2;
            this.result = result;
        }
        public void FileOperations()
        {
            try
            {
                string path = @"C:\Users\reuben.tribhuwan\source\repos\rftribhuwan\C-training\CTraining\Day5StringCompare\StringComparison.txt";
                string timeStamp = DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss");
                if (!File.Exists(path))
                {
                    var fs = File.Create(path);
                }
                using (var sw = new StreamWriter(path))
                {
                    if (result < 0)
                    {
                        sw.WriteLine(timeStamp+"-->"+firststring + " is less than " + secondString);
                    }
                    else if (result == 0)
                    {
                        sw.WriteLine(timeStamp + "-->" + firststring + " is equal " + secondString);
                    }
                    else
                    {
                        sw.WriteLine(timeStamp + "-->" + firststring + " is greater than " + secondString);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            
        }
    }
}
