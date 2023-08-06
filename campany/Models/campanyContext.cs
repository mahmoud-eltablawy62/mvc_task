using Microsoft.EntityFrameworkCore;
namespace campany.Models
{
    public class campanyContext : DbContext
    {
     public DbSet<Employee> Employees { get; set; } 
     public DbSet<project> Projects { get; set; }    
     public DbSet<office> Office { get; set; }
     public DbSet<Emp_projects> Employees_projects { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Campany_ITI;Trusted_Connection=True;TrustServerCertificate=True;");
        }


    }
}
