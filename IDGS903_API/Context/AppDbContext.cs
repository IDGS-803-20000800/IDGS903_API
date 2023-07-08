using IDGS903_API.Models;
using Microsoft.EntityFrameworkCore;

namespace IDGS903_API.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }
        public DbSet<alumnos> alumnos { get; set; }
    }
}
