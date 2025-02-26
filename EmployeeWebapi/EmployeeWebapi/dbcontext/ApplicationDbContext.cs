using EmployeeWebapi.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeWebapi.dbcontext
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 
        
        }
        public DbSet<Employee> Employees { get; set; }


    }
}
