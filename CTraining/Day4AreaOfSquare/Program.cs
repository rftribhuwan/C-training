using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4AreaOfSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int side;
            Console.WriteLine("Enter the side of a square:\t");
            side = int.Parse(Console.ReadLine());
            Area area = new Area();
            Console.Write("Area of square = "+area.CalculateArea(side));
        }
    }
}
