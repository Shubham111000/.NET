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
            DAC.DAC @ref = new DAC.DAC();
            DBDA.DBDA ref1 = new DBDA.DBDA();
            Console.WriteLine(@ref.add(10,20));
            Console.WriteLine(ref1.add(100, 200));
        }
    }
}
