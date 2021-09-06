using CommanderGQL.Models;
using Microsoft.EntityFrameworkCore;

namespace CommanderGQL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Command> Commands { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Platform>()
                .HasMany(p => p.Commands)
                .WithOne(p => p.Platform!)
                .HasForeignKey(p => p.PlatformId);
            modelBuilder
                .Entity<Command>()
                .HasOne(p => p.Platform)
                .WithMany(p => p.Commands)
                .HasForeignKey(p => p.PlatformId);

            modelBuilder
                .Entity<Project>()
                .HasMany(p => p.Tasks)
                .WithOne(p => p.Project!)
                .HasForeignKey(p => p.ProjectId);
            modelBuilder
                .Entity<Task>()
                .HasOne(p => p.Project)
                .WithMany(p => p.Tasks)
                .HasForeignKey(p => p.ProjectId);
        }
    }
}