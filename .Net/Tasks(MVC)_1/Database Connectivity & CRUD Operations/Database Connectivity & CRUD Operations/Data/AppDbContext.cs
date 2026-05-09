using Database_Connectivity___CRUD_Operations.Models;
using Microsoft.EntityFrameworkCore;

namespace Database_Connectivity___CRUD_Operations.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}