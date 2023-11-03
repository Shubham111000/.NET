using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Employee
    {
        static int ID;
        int id; int salary; int netsalary;
        string name;

        static Employee()
        {
            Console.WriteLine("Welcome to SM Vita");
        }


        public Employee(string name,int salary) 
        {
            id = ++ID;
            this.salary = salary;
            this.name = name;
        }
        public Double CalculateSal() 
        {
            this.netsalary = this.salary - (salary * 10);
            return this.netsalary;
        }
        public void disp()
        {
            Console.WriteLine($"name = {name} netsalary ={CalculateSal()}");
        }
    }
}
