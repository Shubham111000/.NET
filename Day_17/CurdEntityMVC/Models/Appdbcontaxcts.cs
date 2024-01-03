using Microsoft.EntityFrameworkCore;

namespace CurdEntityMVC.Models
{
    public class appdbcontaxcts:DbContext
    {
        public appdbcontaxcts(DbContextOptions<appdbcontaxcts> options): base(options)
        {

        }

        public DbSet<Employee>Employees { get; set; }

    }
}
