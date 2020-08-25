using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day3InterfaceCalculator
{
    class Addition:ICalculator, IScientificCalculator
    {
        public int Compute(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
