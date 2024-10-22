using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Wine> Wines { get; set; }
        public DbSet<Tasting> TastingEvents { get; set; }
        public DbSet<TastingWine> TastingWines { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            User lukas = new User()
            {
                Id = 1,
                Username = "Lukas",
                Password = "password"
            };
            User samantha = new User()
            {
                Id = 2,
                Username = "Samantha",
                Password = "password"
            };
            User friedrich = new User()
            {
                Id = 3,
                Username = "Friedrich",
                Password = "password"
            };

            modelBuilder.Entity<User>().HasData(lukas, samantha, friedrich);

            modelBuilder.Entity<Tasting>().HasMany(t => t.Wines).WithMany();
            modelBuilder.Entity<Wine>().HasMany(w => w.TastingInstances).WithMany();

            base.OnModelCreating(modelBuilder);
        }
    }
}
