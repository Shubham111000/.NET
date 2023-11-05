using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

/*
Q) : Create a table customer id name address mobno use table customer and complete following task
1: display all customer data(strongly type);
2: accept id from the user and delete particular customers;
3: create a object of customer and store data in customer table;
4: write search method with parameter id; write search method with parameter string(name,mobileno);
5: accept id and name from user and update the record
*/
namespace CURD_application
{
    internal class Program
    {
        private static IConfiguration _iconfigurations;
        static void Main()
        {
            GetAppsettings();
            //Insert_Products();
            //Print_products();
            //Delete(1002);
            Print_products();
            Update(new Customer { Name = "Sanket Sasne", MobileNumber = "98476763176" }, 1003);
            Print_products();
            Search(1);
            Search("Shubham Gaiwkad", "7709796352");




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
            var x = ado.Show_Data();
            foreach(var item in x) 
            {
                Console.WriteLine(" {0} {1} {2} {3} ",item.Id,item.Name,item.Address,item.MobileNumber);
            }

        }
        public static void Delete(int id) 
        {
            AdoDotNet ado = new AdoDotNet(_iconfigurations);
            ado.Delete_Record(id);
        }
        public static void Update(Customer e,int id)
        {
            AdoDotNet ado = new AdoDotNet(_iconfigurations);
            ado.Update_Data(e, id);
        }
        public static void Search(int id) 
        {
            AdoDotNet ado = new AdoDotNet(_iconfigurations);
            var list =ado.Search(id);
            
            foreach(var item in list) 
            {
                Console.WriteLine(" {0} {1} {2} {3} ", item.Id, item.Name, item.Address, item.MobileNumber);
            } 

        }
        public static void Search(String Name,String Mobile)
        {
            AdoDotNet ado = new AdoDotNet(_iconfigurations);
            var list = ado.Search(Name,Mobile);

            foreach (var item in list)
            {
                Console.WriteLine(" {0} {1} {2} {3} ", item.Id, item.Name, item.Address, item.MobileNumber);
            }

        }
    }
}
