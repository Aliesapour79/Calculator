using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    internal class Class1
    {
        public int sum(int a, int b)
        {

            if (b == 0)
            {
                return a;
            }
            else
                return sum(a, b - 1) + 1;
        }
    }
}
