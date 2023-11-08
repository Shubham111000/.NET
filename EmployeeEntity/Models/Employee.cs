using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeEntity
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public float? Salary { get; set; }

        [ForeignKey("DepartmentName")]
        public string? Department { get; set; }

        [ForeignKey("DepartmentId")]
        public int DeparmentID { get; set; }
        public override string ToString()
        {
            return $"Id={Id} Name={Name} Department={Department} Salary={Salary}$  ";
        }
    }
}
