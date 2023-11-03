using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task_1 { 
    public class Program
    {
        static void Main(string[] args)
        {
            Calculator @ref = new Calculator();

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(@ref.add(a, b));
            Console.ReadLine();


        }
    }
}