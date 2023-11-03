using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB1
{
    public class Fact
    {
        public int Facotrial(int a)
        {
            if (a == 0 || a == 1)
                return 1;
            else
                return a * (Facotrial(a - 1));
       }
    }
}
