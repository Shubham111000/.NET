using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork3
{
    delegate void CountIt(string name);

    class AnonMethDemo2
    {
        static void Main()
        {

            CountIt displ = delegate (string name)
            {
                for (int i = 0; i <= 5; i++)
                    Console.WriteLine(name);

            };
            displ("Hello everyone");
            Console.WriteLine();
            displ("Shubham here from Pg-Dac");
        }
    }

}
