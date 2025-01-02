using Microsoft.EntityFrameworkCore;

namespace projBDwAI.Models.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Bug> Bugs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Priority> Priorities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Priority>().HasData(
                new Priority { Id = 1, Name = "Niski" },
                new Priority { Id = 2, Name = "Średni" },
                new Priority { Id = 3, Name = "Wysoki" }
            );
        }
    }
}
