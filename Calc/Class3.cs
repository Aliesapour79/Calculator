using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    internal class Class3
    {
        public int Div(int a, int b)
        {
            if (a < b) return 0;
            else return Div(a - b, b) + 1;
        }
    }
}
