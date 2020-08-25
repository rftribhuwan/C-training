using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4ListCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            var myList = new List<int>();
            Console.WriteLine("Welcome! Calculator options are as follows:\n1. Add\t2. Subtract\t3. Multiply\t4. Divide\nPlease select an option!");
            option = int.Parse(Console.ReadLine());
            if (option != 1 && option != 2 && option != 3 && option != 4)
            {
                Console.WriteLine("Invalid choice!");
                return;
            }
            Console.WriteLine("Please enter the number of elements");
            int numberOfElements = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the elements!");
            for (int i = 0; i < numberOfElements; i++)
                myList.Add(int.Parse(Console.ReadLine()));
            Calculator calculator = new Calculator();
            switch (option)
            {
                case 1:
                    Console.WriteLine("Result = " + calculator.Add(myList));
                    break;
                case 2:
                    Console.WriteLine("Result = " + calculator.Subtraction(myList));
                    break;
                case 3:
                    Console.WriteLine("Result = " + calculator.Multiplication(myList));
                    break;
                case 4:
                    Console.WriteLine("Result = " + calculator.Division(myList));
                    break;
            }


        }
    }
}
