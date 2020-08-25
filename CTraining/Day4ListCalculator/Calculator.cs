using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4ListCalculator
{
    class Calculator
    {
        int result;
        public int Add(List<int> numbers)
        {
            result = numbers[0];
            for(int i=1;i<numbers.Count;i++)
                result += numbers[i];
            return result;
        }
        public int Subtraction(List<int> numbers)
        {
            result = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
                result -= numbers[i];
            return result;
        }
        public int Multiplication(List<int> numbers)
        {
            result = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
                result *= numbers[i];
            return result;
        }
        public int Division(List<int> numbers)
        {
            result = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
                result /= numbers[i];
            return result;
        }
    }
}
