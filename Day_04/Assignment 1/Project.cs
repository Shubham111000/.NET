using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Project
    {
        static Project()
        {
            Console.WriteLine("Inside Project");
        }
        static Double TDS = 0.1;
        int id;
        public int ID { get { return id; } }
        int salary;
        Double tax;
        public Double Tax { get { return tax; } }  
        static int getID    ;
        const int maxCapacity= 3;
        public string Name{ set; get;}
        public int Salary 
        { 
            get 
            {
                return salary;
            } 
            set 
            {   if (value <= 0 || value > 50000)
                    throw new Exception("Salry is not Valid");
                else
                salary = value;
            } 
        }
        Double netSalry;
        public Double NetSalary
        { 
        get
                { return netSalry; }
        }
        public Double TdsDed() 
        {
            this.tax = Salary *TDS;
            this.netSalry = Salary - tax;
            return tax;
        }
        public Project(int salary,string name) 
        {
            if (getID < 3)
            {
                Name = name;
                Salary = salary;
                id = ++getID;
            }
            else
                throw new Exception("limit Reached");
        } 


    }
}
