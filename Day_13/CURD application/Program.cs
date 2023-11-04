using System;
using System.Collections.Generic;
using System.IO;
//using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace CURD_application
{
    internal class Program
    {
        private static IConfiguration _iconfigurations;
        static void Main()
        {
            GetAppsettings();
            Insert_Products();
            Print_products();
        }
        public static void GetAppsettings() 
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).
                AddJsonFile("Appsettings.json", optional: false, reloadOnChange: true);
           _iconfigurations = builder.Build();                   
        }
        public static void Insert_Products() 
        {
            AdoDotNet ado = new AdoDotNet(_iconfigurations);
            ado.Insert_Products(new Customer() { Id=12,Name="MacBook",Address="Firozpur",MobileNumber="9205737517"});
        }
        public static void Print_products() 
        {
            AdoDotNet ado = new AdoDotNet(_iconfigurations);
            ado.Products();

        }
    }
}
