using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculatorAPI
{
    public class Adder
    {
        public int Addition(int number1, int number2)
        {
            int result;
            result = number1 + number2;
            return result;
        }
    }
}