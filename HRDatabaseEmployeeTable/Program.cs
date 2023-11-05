using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace HRDatabaseEmployeeTable
{
    internal class Program
    {
        private static IConfiguration _iconfiguration;

        public static void Main()
        {
            GetAppsettingsFile();
            Print_list();
            Insert(new Employee { Name="Akshay S",Id=0,Address="Kolhapur",Gender="M",Salary=57000});           
            Print_list();
            Update(new Employee() { Name="Sushil",Address="Kannad",Id=10,Gender="M",Salary=52500},0);
            Print_list();
            Delete(10);
            Print_list();
            GetEmployee(1);


        }
        static void GetAppsettingsFile() 
        {
            var builder= new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).
                AddJsonFile("Appsettings.json",optional:false,reloadOnChange:true);
            _iconfiguration= builder.Build();
        }
        static void Insert(Employee e) 
        {
            StronglyType Strobj = new StronglyType(_iconfiguration);
            Strobj.Insert_Employee(e);
        }
        static void ShowTable() 
        {
            StronglyType Strobj = new StronglyType(_iconfiguration);
            Strobj.Show_Table();

        }
        static void Delete(int id) 
        {
            StronglyType Strobj = new StronglyType(_iconfiguration);
            Strobj.Delete(id);
        }
        static void Update(Employee e,int id) 
        {
            StronglyType Strobj = new StronglyType(_iconfiguration);
            Strobj.Update_Employee(e, id);        
        }
        static void Print_list() 
        {
            StronglyType Strobj = new StronglyType(_iconfiguration);
            var elist=Strobj.GetEmployees();
            foreach ( var e in elist ) 
            {
                Console.WriteLine("{0} {1} {2} {3} ", e.Id,e.Name,e.Salary,e.Address); 
            }
        }
        static void GetEmployee(int i) 
        {
            StronglyType Strobj = new StronglyType(_iconfiguration);
            var elist = Strobj.GetOneRecord(i);
            foreach (var e in elist)
            {
                Console.WriteLine("{0} {1} {2} {3} ", e.Id, e.Name, e.Salary, e.Address);
            }
        }

    }
}
