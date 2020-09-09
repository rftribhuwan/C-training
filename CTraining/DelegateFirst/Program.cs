using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DelegateFirst
{
    class Program
    {
        public delegate int Addition(int firstNum, int secondNum);
        public delegate int Subtraction(int firstNum, int secondNum);

        public int Add(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
        public int Sub(int firstNum, int secondNum)
        {
            return firstNum - secondNum;
        }
        static void Main(string[] args)
        {
            int firstNum, secondNum;
            Console.WriteLine("Please enter first number!");
            firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number!");
            secondNum = int.Parse(Console.ReadLine());
            Program program = new Program();
            Addition object1 = new Addition(program.Add);
            Subtraction object2 = new Subtraction(program.Sub);
            int result1 = object1(firstNum, secondNum);
            int result2 = object2(firstNum, secondNum);
            Console.WriteLine("Addition=" + result1);
            Console.WriteLine("Subtraction=" + result2);

        }
    }
}
