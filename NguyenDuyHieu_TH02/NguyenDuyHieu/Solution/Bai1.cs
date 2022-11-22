using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDuyHieu.Solution
{
    public class Bai1
    {
        public int UCLN(int a, int b)
        {
            if (a * b == 0)
                return a + b;
            if (a > b)
                return UCLN(a - b, b);
            else
                return UCLN(a, b - a);
        }
        public int  BCNN(int a, int b)
        {
            int result = UCLN(a, b);
            return a * b / result;
        }
    }
}
