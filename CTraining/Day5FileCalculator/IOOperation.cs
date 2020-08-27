using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5FileCalculator
{
    class IOOperation
    {
        int result;
        public int CheckValidation(string input)
        {
            int validatedInput;
            while(!int.TryParse(input, out validatedInput))
            {
                Console.WriteLine("This is not a valid input! Re-enter");
                input = Console.ReadLine();
            }
            return validatedInput;
        }
        public void Inputfunction()
        {
            try
            {
                int number1, number2, option;
                Console.WriteLine("Welcome! Calculator options are as follows:\n1. Add\t2. Subtract\t3. Multiply\t4. Divide\nPlease select an option!");
                string optionInput = Console.ReadLine();
                option = CheckValidation(optionInput);
                if (option != 1 && option != 2 && option != 3 && option != 4)
                {
                    Console.WriteLine("Invalid choice!");
                    return;
                }
                Console.WriteLine("Enter first number:");
                string firstNumberInput = Console.ReadLine();
                number1 = CheckValidation(firstNumberInput);
                Console.WriteLine("Enter second number");
                string secondNumberInput = Console.ReadLine();
                number2 = CheckValidation(firstNumberInput);
                var calculator = new Calculator();
                switch (option)
                {
                    case 1:
                        result = calculator.Add(number1, number2);
                        Console.WriteLine("Result = " + result);
                        break;
                    case 2:
                        result = calculator.Subtraction(number1, number2);
                        Console.WriteLine("Result = " + result);
                        break;
                    case 3:
                        result = calculator.Multiplication(number1, number2);
                        Console.WriteLine("Result = " + result);
                        break;
                    case 4:
                        result = calculator.Division(number1, number2);
                        Console.WriteLine("Result = " + result);
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
                var fileOperation = new FileOperation(number1, number2, option, result);
                fileOperation.FileOperations();
            }
            catch(Exception e)
            {
                Console.Write(e);
            }
            

        }
    }
}
