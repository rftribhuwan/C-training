using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMinimum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            int numberOfElements, i, minimumNumber;
            Console.WriteLine("\nPlease enter the amount of numbers to use");
            numberOfElements = int.Parse(Console.ReadLine());
            Console.WriteLine("\nPlease enter the numbers");
            for (i = 0; i < numberOfElements; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            var minimumElement = new MinimumElement();
            minimumNumber = minimumElement.FindMinimum(array, numberOfElements);
            Console.WriteLine("Smallest Number in the array is:-\t" + minimumNumber);
        }
    }
}