using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EmployeeEntity.Models
{
    public class DepartmentEmployee:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=Department;Integrated Security=True;");
        }
        public DbSet<Department> DepartmentSet { get; set; }
        public DbSet<Employee> EmployeeSet { get; set; }

    }
}
