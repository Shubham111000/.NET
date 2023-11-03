using System;
using System.Collections.Generic;
using System.IO;
//using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;


/*
Create a table coustomer with column id name address mobile number display all records 
insert new record 
update name of coustomer where id equal to 1
Delete record where id equal to 3
 */

namespace Task_2
{
    internal class Program
    {
        private static IConfiguration _iconfiguration;
        static void Main(string[] args)
        {
            GetAppsettings();
            PrintProduct();

        }
        public static void GetAppsettings() 
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("Appsettings.json", optional: false, reloadOnChange: true);
            _iconfiguration= builder.Build();   
        }
        public static void PrintProduct() 
        {
            DatabaseConnection databaseConnection = new DatabaseConnection(_iconfiguration);
            databaseConnection.Products();
            databaseConnection.product_insert();
            databaseConnection.Products();
        }
    }
}
