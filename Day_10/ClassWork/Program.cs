using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AnonMethDemo
{
    delegate void CountIt();
    class Class1
    {
        static void Main()
        {
            // Here, the code for counting is passed 
            // as an anonymous method. 
            CountIt count = delegate {
                // This is the block of code passed to the delegate. 
                for (int i = 0; i <= 5; i++)
                    Console.WriteLine(i);
            }; // notice the semicolon 
            count();
        }
    }

}

