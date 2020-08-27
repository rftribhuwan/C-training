using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6GetAssemblyPath
{
    class Program
    {
        static void Main(string[] args)
        {
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            string fileName = "Day6File.txt";
            string path = Path.Combine(dir, fileName);
            if(!File.Exists(path))
            {
                var fs = File.Create(path);
            }
            Console.WriteLine(dir);
            Console.WriteLine(path);
        }
    }
}
