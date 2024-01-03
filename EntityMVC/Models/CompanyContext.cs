using System.Data.Entity;

namespace EntityMVC.Models
{
    public class CompanyContext:DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
        {

        }

        public DbSet<Company> Company { get; set; }
        public D
    }
}
