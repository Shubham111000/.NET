using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Calculator
    {
        public float square(float x) {
            return x * x;
        }
        public float cube (float x)
        {
            return x * x * x;
        }
        public int RoundOff(float x)
        {
            return ((int)x);
        }    
    }

}
