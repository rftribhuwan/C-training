using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3InterfaceCalculator
{
    class Subtraction:ICalculator
    {
        public int Compute(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}
