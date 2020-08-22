using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3InterfaceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, option, result;
            Console.WriteLine("Welcome! Calculator options are as follows:\n1. Add\t2. Subtract\t3. Multiply\t4. Divide\nPlease select an option!");
            option = int.Parse(Console.ReadLine());
            if(option != 1 && option != 2 && option != 3 && option != 4)
            {
                Console.WriteLine("Invalid choice!");
             
            }
            Console.WriteLine("Enter first number:");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            number2 = int.Parse(Console.ReadLine());
            var addition = new Addition();
            var subtraction = new Subtraction();
            var multiplication = new Multiplication();
            var division = new Division();
            if (option == 1)
                result = addition.Compute(number1, number2);
            else if (option == 2)
                result = subtraction.Compute(number1, number2);
            else if (option == 3)
                result = multiplication.Compute(number1, number2);
            else
                result = division.Compute(number1, number2);
            Console.WriteLine("Result = " + result);
        }
    }
}
