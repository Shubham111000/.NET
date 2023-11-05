using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDatabaseEmployeeTable
{
    internal class Employee
    {
        public String Name { get; set; }
        public Char Gender { get; set; }    
        public float Salary {  get; set; }  
        public String Address {  get; set; }    
        public int Id { get; set; }
    }
}
