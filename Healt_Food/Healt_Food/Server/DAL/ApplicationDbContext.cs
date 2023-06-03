using Healt_Food.Shared.Entites;
using Microsoft.EntityFrameworkCore;

namespace Healt_Food.Server.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Food>().HasData(
                new Food()
                {
                    Id = 1,
                    Name = "Foo",
                    Calories = 12,
                    Carbohydrates = 1234,
                    Fat = 15,
                    Protein = 15,
                    Favorite = false,
                    DayOfWeek = DayOfWeek.Monday
                },
                new Food()
                {
                    Id = 2,
                    Name = "Bar",
                    Carbohydrates = 124,
                    Calories = 123,
                    Fat = 1,
                    Protein = 515,
                    Favorite = true,
                    DayOfWeek = DayOfWeek.Tuesday
                });
        }

        public DbSet<Food> Foods { get; set; }
    }
}
