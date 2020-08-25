using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4AbstractAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter number:-");
            number = int.Parse(Console.ReadLine());
            Addition addition = new Addition();
            Console.WriteLine("Addition = " +addition.AdditionFunction(number));
        }
    }
}
