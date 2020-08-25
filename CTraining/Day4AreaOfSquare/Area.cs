using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4AreaOfSquare
{
    class Area:AbstractArea
    {
        public override int CalculateArea(int side)
        {
            return side * side;          
        }
    }
}
