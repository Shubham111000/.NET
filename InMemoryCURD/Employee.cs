using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InMemoryCURD
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Addresss { get; set; }
        public float Salary {  get; set; }
        public char Gender {  get; set; }
        public override string ToString()
        {
            return $"Id={Id} Name={Name} Salary={Salary} Gender={Gender} Addres={Addresss}";
        }
    }
}
