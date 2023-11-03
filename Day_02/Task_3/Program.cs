using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator c= new Calculator();
            Console.WriteLine(c.cube(10.2f));
            Console.WriteLine(c.square(10.2f));
            Console.WriteLine(c.RoundOff(22.5f));
        }
    }
}
