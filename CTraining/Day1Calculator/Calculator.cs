using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Calculator
{
    public class Calculator
    {
        public int Add(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
        public int Subtraction(int firstNum, int secondNum)
        {
            return firstNum - secondNum;
        }
        public int Multiplication(int firstNum, int secondNum)
        {
            return firstNum * secondNum;
        }
        public int Division(int firstNum, int secondNum)
        {
            return firstNum / secondNum;
        }
    }
}