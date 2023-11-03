using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork5
{
    delegate void CountIt(int a, int b);

    class AnonMethDemo2
    {
        static void Main()
        {

            CountIt count = delegate (int a, int b)
            {
                int sum = a + b;
                Console.WriteLine("The sum is " + sum);


            };

            count += delegate (int a, int b)
            {
                int multi = a * b;
                Console.WriteLine("Multiplication is " + multi);
            };
            count(10, 20);
            Console.WriteLine();

        }
    }
}
