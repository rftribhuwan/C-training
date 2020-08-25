using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4AbstractAddition
{
    public abstract class AbstractAddition
    {
        public virtual int AdditionFunction(int number)
        {
            return number + 5;
        }
    }
}
