using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4ConstructorCalculator
{
    class Calculator
    {
        int firstNum, secondNum;
        public Calculator(int firstNum, int secondNum)
        {
            this.firstNum = firstNum;
            this.secondNum = secondNum;
        }

        public int Add()
        {
            return this.firstNum + this.secondNum;
        }
        public int Subtraction()
        {
            return this.firstNum - this.secondNum;
        }
        public int Multiplication()
        {
            return this.firstNum * this.secondNum;
        }
        public int Division()
        {
            return this.firstNum / this.secondNum;
        }
    }
}
