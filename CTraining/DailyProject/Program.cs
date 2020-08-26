using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\reuben.tribhuwan\source\repos\rftribhuwan\C - training\CTraining\DailyProject\AnswerFile123.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
        }
    }
}
