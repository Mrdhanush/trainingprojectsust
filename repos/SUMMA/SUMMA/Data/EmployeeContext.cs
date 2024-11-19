using Microsoft.EntityFrameworkCore;
using SUMMA.Models;
using System.Security.Cryptography.X509Certificates;

namespace SUMMA.Data
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() {
        }

        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options)
        {
            public virtual DbSet<Employee> Employees { get; set; }
    
    }
}
