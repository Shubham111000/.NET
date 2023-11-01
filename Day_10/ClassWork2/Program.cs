using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork2
{
    delegate void CountIt(int end);

    class AnonMethDemo2
    {
        static void Main()
        {
            // Here, the ending value for the count 
            // is passed to the anonymous method. 
            CountIt count = delegate (int end)
            {
                for (int i = 0; i <= end; i++)
                    Console.WriteLine(i);
            };
            count(3);
            Console.WriteLine();
            count(5);
        }
    }

}
