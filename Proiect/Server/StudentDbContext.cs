using Microsoft.EntityFrameworkCore;
using Proiect.Shared;

namespace Proiect.Server
{
     public class StudentDbContext:DbContext
     {
          public StudentDbContext(DbContextOptions<StudentDbContext> options):base(options) { }

          public DbSet<Students> Students { get; set; }
     }
}
