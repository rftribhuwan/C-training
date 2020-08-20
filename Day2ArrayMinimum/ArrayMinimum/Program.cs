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
            int[] array1 = new int[100];
            int n, i, minimum;
            Console.WriteLine("\nPlease enter the amount of numbers to use");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nPlease enter the numbers");
            for (i=0;i<n;i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }
            var object1 = new Minimum();
            minimum = object1.FindMinimum(array1,n);
            Console.WriteLine("Smallest Number in the array is:-\t"+minimum);
        }
    }
}
