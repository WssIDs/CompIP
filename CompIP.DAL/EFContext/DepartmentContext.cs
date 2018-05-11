using System.Data.Entity;
using CompIP.DAL.Entities;

namespace CompIP.DAL.EFContext
{
    public class DepartmentContext : DbContext
    {
        public DepartmentContext(string name) : base(name)
        {
            Database.SetInitializer(new DepartmentInitializer());
        }

        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Computer> Computers { get; set; }
    }
}
