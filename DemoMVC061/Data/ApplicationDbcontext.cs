using Microsoft.EntityFrameworkCore;
using DemoMVC061.Models;
namespace DemoMVC061.Data
{
     
    
    public class ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : DbContext(options)
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
