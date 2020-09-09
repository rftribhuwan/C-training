using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSecond
{
    class Program
    {
        public delegate void Rectangle(float firstNum, float secondNum);
        public void Area(float firstNum, float secondNum)
        {
            Console.WriteLine("Area of rectangle=" + (firstNum * secondNum));
        }
        public void Perimeter(float firstNum, float secondNum)
        {
            Console.WriteLine("Perimeter of rectangle=" + (2 * (firstNum + secondNum)));
        }
        static void Main(string[] args)
        {
            int firstNum, secondNum;
            Console.WriteLine("Please enter first number!");
            firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number!");
            secondNum = int.Parse(Console.ReadLine());
            Program program = new Program();
            Rectangle rectangle = new Rectangle(program.Area);
            rectangle += program.Perimeter;
            rectangle(firstNum, secondNum);
        }
    }
}
