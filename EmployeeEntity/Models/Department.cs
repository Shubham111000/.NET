using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeEntity
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("DepartmentName")]
        public String DepartmentName { get; set; }
        public IList<Employee> Employees { get; set; }  

        //[ForeignKey("DepartmentId")]



    }
}
