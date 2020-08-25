using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4AbstractAddition
{
    class Addition:AbstractAddition
    {
        public override int AdditionFunction(int number)
        {
            return number + 10;
        }
    }
}
