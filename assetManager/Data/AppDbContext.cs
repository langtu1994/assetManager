using Microsoft.EntityFrameworkCore;
using assetManager.Models;

namespace assetManager.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<TaskDbModel> Tasks { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
    }
}
