using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIB1;
namespace Main {
    public class Program
    {
        public static void Main(string[] args)
        {
            Fact @ref= new LIB1.Fact();
            Console.WriteLine(@ref.Facotrial(5));

        }
    } 
}

