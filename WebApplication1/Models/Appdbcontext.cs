using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace WebApplication1.Models
{
    public class Appdbcontext : DbContext
    {

        public Appdbcontext(DbContextOptions<Appdbcontext> options)
                 : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\\ProjectModels;Initial Catalog=ReactDay01;Integrated Security=True");
            }
        }
        public DbSet<Employee> Employees { get; set; }
    }

}
