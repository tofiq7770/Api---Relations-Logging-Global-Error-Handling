using Domain.Configurations;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GroupConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StudentConfiguration).Assembly);
        }
    }
}

