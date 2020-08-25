using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProject
{
    public abstract class BaseClass: Class2,Interface1
    {
        public virtual int MyMethod(int a)
        {
            return a;
        }
    }
}
