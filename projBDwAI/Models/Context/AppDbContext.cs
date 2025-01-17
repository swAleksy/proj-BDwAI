using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace projBDwAI.Models.Context
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Bug> Bugs { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Twoje konfiguracje
            modelBuilder.Entity<Bug>()
                .HasOne(b => b.Priority)
                .WithMany(p => p.Bugs)
                .HasForeignKey(b => b.PriorityId);

            modelBuilder.Entity<Bug>()
                .HasOne(b => b.Project)
                .WithMany(p => p.Bugs)
                .HasForeignKey(b => b.ProjectId);

            modelBuilder.Entity<Comment>()
                .HasOne(c => c.Bug)
                .WithMany(b => b.Comments)
                .HasForeignKey(c => c.BugId);

            modelBuilder.Entity<Comment>()
                .HasOne(c => c.User)
                .WithMany(u => u.Comments)
                .HasForeignKey(c => c.UserId);
        }

        private class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<User>
        {
            public void Configure(EntityTypeBuilder<User> builder)
            {
                builder.Property(x => x.FirstName).HasMaxLength(255);
                builder.Property(x => x.LastName).HasMaxLength(255);
            }
        }
    }
}
