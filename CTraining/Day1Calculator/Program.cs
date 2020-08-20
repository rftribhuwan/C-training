﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, option, result;
            Console.WriteLine("Welcome! Calculator options are as follows:\n1. Add\t2. Subtract\t3. Multiply\t4. Divide\nPlease select an option!");
            option = int.Parse(Console.ReadLine());
            if(option!=1 || option!=2 || option!=3 || option!=4)
            {
                Console.WriteLine("Invalid choice!");
                return;
            }
            Console.WriteLine("Enter first number:");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            number2 = int.Parse(Console.ReadLine());
            var calculator = new Calculator();
            if (option == 1)
                result = calculator.Add(number1, number2);
            else if (option == 2)
                result = calculator.Subtraction(number1, number2);
            else if (option == 3)
                result = calculator.Multiplication(number1, number2);
            else
                result = calculator.Division(number1, number2);
            Console.WriteLine("Result = " + result);
        }
    }
}


