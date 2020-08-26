using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DailyProject
{
    class Class1:BaseClass
    {
        public override int MyMethod(int a)
        {
            int x = 25;
            string ab = $"Neeraj age is {x}";
            string b = "Reuben";
            int comp = strcmp(ab, b);
            
            return base.MyMethod(a);
        }
    }
}
