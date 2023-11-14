using JobHub.Models;
using Microsoft.EntityFrameworkCore;

namespace JobHub.Data
{
    public class JobHubDbContext: DbContext
    {
        public JobHubDbContext(DbContextOptions<JobHubDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<User> Users { get; set; }
    }
}
