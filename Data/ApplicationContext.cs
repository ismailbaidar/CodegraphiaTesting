using CodegraphiaTesting.Models;
using Microsoft.EntityFrameworkCore;
namespace CodegraphiaTesting.Data
{
    public class ApplicationContext:DbContext
    {
        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }
        public ApplicationContext(DbContextOptions options):base(options)
        {
            
        }
    }
}
