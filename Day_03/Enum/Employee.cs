using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Employee
    {
        int id;
        Double salary;
        string name;
        dep d;
        Double NetSalary;
        public Employee(int id,Double salary,string name,dep d) 
        {
            this.id = id;
            this.salary = salary;
            this.name = name;
            this.d = d;
        }
        public dep GetDep()
        {
            return d;
        }
        public double GetSalary()
        {
            return salary;
        }
        public Double PayTax(double p)
        {
            this.NetSalary = salary - (salary * p/100);
            return NetSalary;
        }

    }
}
