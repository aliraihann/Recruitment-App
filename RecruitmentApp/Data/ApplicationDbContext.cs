using Microsoft.EntityFrameworkCore;
using RecruitmentApp.Models.Entities;

namespace RecruitmentApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }  
    }
}
