using Healt_Food.Shared.Entites;
using Healt_Food.Shared.Enums;
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
                    Name = "Hühnerbrust",
                    Fat = 1.5,
                    Carbohydrates = 0,
                    Protein = 31,
                    Calories = 147,
                    Favorite = false,
                    DayOfWeek = DayOfWeekEnum.None,
                },
                new Food()
                {
                    Id = 2,
                    Name = "Brokkoli",
                    Fat = 0.6,
                    Carbohydrates = 6,
                    Protein = 2.8,
                    Calories = 31,
                    Favorite = false,
                    DayOfWeek = DayOfWeekEnum.None,
                },
                new Food()
                {
                    Id = 3,
                    Name = "Haferflocken",
                    Fat = 7,
                    Carbohydrates = 56,
                    Protein = 13,
                    Calories = 389,
                    Favorite = false,
                    DayOfWeek = DayOfWeekEnum.None,
                },
                new Food()
                {
                    Id = 4,
                    Name = "Lachsfilet",
                    Fat = 13.6,
                    Carbohydrates = 0,
                    Protein = 20.4,
                    Calories = 206,
                    Favorite = false,
                    DayOfWeek = DayOfWeekEnum.None,
                },
                new Food()
                {
                    Id = 5,
                    Name = "Quinoa",
                    Fat = 6.1,
                    Carbohydrates = 63,
                    Protein = 14,
                    Calories = 368,
                    Favorite = false,
                    DayOfWeek = DayOfWeekEnum.None,
                },
                new Food()
                {
                    Id = 6,
                    Name = "Mandeln",
                    Fat = 49.9,
                    Carbohydrates = 21,
                    Protein = 21,
                    Calories = 576,
                    Favorite = false,
                    DayOfWeek = DayOfWeekEnum.None,
                },
                new Food()
                {
                    Id = 7,
                    Name = "Banane",
                    Fat = 0.2,
                    Carbohydrates = 22,
                    Protein = 1.1,
                    Calories = 96,
                    Favorite = false,
                    DayOfWeek = DayOfWeekEnum.None,
                },
                new Food()
                {
                    Id = 8,
                    Name = "Vollmilch",
                    Fat = 3.6,
                    Carbohydrates = 4.8,
                    Protein = 3.3,
                    Calories = 62,
                    Favorite = false,
                    DayOfWeek = DayOfWeekEnum.None,
                },
                new Food()
                {
                    Id = 9,
                    Name = "Rindfleisch",
                    Fat = 18.9,
                    Carbohydrates = 0,
                    Protein = 26.4,
                    Calories = 252,
                    Favorite = false,
                    DayOfWeek = DayOfWeekEnum.None,
                },
                new Food()
                {
                    Id = 10,
                    Name = "Süßkartoffel",
                    Fat = 0.1,
                    Carbohydrates = 20,
                    Protein = 1.6,
                    Calories = 86,
                    Favorite = false,
                    DayOfWeek = DayOfWeekEnum.None,
                },
                new Food()
                {
                    Id = 11,
                    Name = "Griechischer Joghurt",
                    Fat = 10,
                    Carbohydrates = 3.6,
                    Protein = 9.3,
                    Calories = 145,
                    Favorite = false,
                    DayOfWeek = DayOfWeekEnum.None,
                },
                new Food()
                {
                    Id = 12,
                    Name = "Spinat",
                    Fat = 0.4,
                    Carbohydrates = 3.6,
                    Protein = 2.9,
                    Calories = 23,
                    Favorite = false,
                    DayOfWeek = DayOfWeekEnum.None,
                },
                new Food()
                {
                    Id = 13,
                    Name = "Ei (mittelgroß) ",
                    Fat = 5.3,
                    Carbohydrates = 0.6,
                    Protein = 6,
                    Calories = 72,
                    Favorite = false,
                    DayOfWeek = DayOfWeekEnum.None,
                },
                new Food()
                {
                    Id = 14,
                    Name = "Kidneybohnen",
                    Fat = 0.5,
                    Carbohydrates = 19,
                    Protein = 8.7,
                    Calories = 127,
                    Favorite = false,
                    DayOfWeek = DayOfWeekEnum.None,
                },
                new Food()
                {
                    Id = 15,
                    Name = "Avocado",
                    Fat = 14.7,
                    Carbohydrates = 8.5,
                    Protein = 2,
                    Calories = 160,
                    Favorite = false,
                    DayOfWeek = DayOfWeekEnum.None,
                }
                );
        }

        public DbSet<Food> Foods { get; set; }
    }
}
