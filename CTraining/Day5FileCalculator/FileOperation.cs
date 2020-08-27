using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5FileCalculator
{
    class FileOperation
    {
        int number1, number2, option, result;
        public FileOperation(int number1, int number2, int option, int result)
        {
            this.number1 = number1;
            this.number2 = number2;
            this.option = option;
            this.result = result;
        }
        public void FileOperations()
        {
            try
            {
                string path = @"C:\Users\reuben.tribhuwan\source\repos\rftribhuwan\C-training\CTraining\Day5FileCalculator\AnswerFile.txt";
                if (!File.Exists(path))
                {
                    var fs = File.Create(path);
                }
                using (var sw = new StreamWriter(path))
                {
                    sw.WriteLine("First Number =" + number1);
                    sw.WriteLine("Second Number =" + number2);
                    switch (option)
                    {
                        case 1:
                            sw.WriteLine("Addition:-" + number1 + "+" + number2 + "=" + result);
                            break;
                        case 2:
                            sw.WriteLine("Subtraction:-" + number1 + "-" + number2 + "=" + result);
                            break;
                        case 3:
                            sw.WriteLine("Multiplication:-" + number1 + "*" + number2 + "=" + result);
                            break;
                        case 4:
                            sw.WriteLine($"Division:-{ number1}/{number2}={result}");
                            break;
                        default:
                            Console.WriteLine("Invalid choice!");
                            break;

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
