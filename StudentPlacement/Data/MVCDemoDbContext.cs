using Microsoft.EntityFrameworkCore;
using StudentPlacement.Models.Domain;

namespace StudentPlacement.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> students{ get; set; }
    }
}
