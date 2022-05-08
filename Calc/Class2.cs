using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    internal class Class2
    {
        public int Mul(int a, int b)
        {

            if (b == 1)
            {
                return a;
            }
            else
                return Mul(a, b - 1) + a;
        }
    }
}
