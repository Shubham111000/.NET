using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;


/*Create a table employee with a column id name salary enter the record using 
sql connection class connect to the database and display record*/

namespace Task_1
{
    internal class Program
    {
        private static IConfiguration _iconfiguration;
        static void Main(string[] args)
        {
            GetJsonFile();
            PrintProduct();

        }

        public static void GetJsonFile()
        {
            var builder = new ConfigurationBuilder()
                         .SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("Appsettings.json", optional: false, reloadOnChange: true);
            _iconfiguration = builder.Build();
        }
        public static void PrintProduct()
        {
            AdoDotNet ado = new AdoDotNet(_iconfiguration);
            ado.Products();
        }
    }
}
