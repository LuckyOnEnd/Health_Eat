﻿// <auto-generated />
using Healt_Food.Server.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Healt_Food.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230603161358_DbSeedUpdated")]
    partial class DbSeedUpdated
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Healt_Food.Shared.Entites.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Calories")
                        .HasColumnType("float");

                    b.Property<double>("Carbohydrates")
                        .HasColumnType("float");

                    b.Property<int>("DayOfWeek")
                        .HasColumnType("int");

                    b.Property<double>("Fat")
                        .HasColumnType("float");

                    b.Property<bool>("Favorite")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Protein")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Calories = 147.0,
                            Carbohydrates = 0.0,
                            DayOfWeek = 7,
                            Fat = 1.5,
                            Favorite = false,
                            Name = "Hühnerbrust",
                            Protein = 31.0
                        },
                        new
                        {
                            Id = 2,
                            Calories = 31.0,
                            Carbohydrates = 6.0,
                            DayOfWeek = 7,
                            Fat = 0.59999999999999998,
                            Favorite = false,
                            Name = "Brokkoli",
                            Protein = 2.7999999999999998
                        },
                        new
                        {
                            Id = 3,
                            Calories = 389.0,
                            Carbohydrates = 56.0,
                            DayOfWeek = 7,
                            Fat = 7.0,
                            Favorite = false,
                            Name = "Haferflocken",
                            Protein = 13.0
                        },
                        new
                        {
                            Id = 4,
                            Calories = 206.0,
                            Carbohydrates = 0.0,
                            DayOfWeek = 7,
                            Fat = 13.6,
                            Favorite = false,
                            Name = "Lachsfilet",
                            Protein = 20.399999999999999
                        },
                        new
                        {
                            Id = 5,
                            Calories = 368.0,
                            Carbohydrates = 63.0,
                            DayOfWeek = 7,
                            Fat = 6.0999999999999996,
                            Favorite = false,
                            Name = "Quinoa",
                            Protein = 14.0
                        },
                        new
                        {
                            Id = 6,
                            Calories = 576.0,
                            Carbohydrates = 21.0,
                            DayOfWeek = 7,
                            Fat = 49.899999999999999,
                            Favorite = false,
                            Name = "Mandeln",
                            Protein = 21.0
                        },
                        new
                        {
                            Id = 7,
                            Calories = 96.0,
                            Carbohydrates = 22.0,
                            DayOfWeek = 7,
                            Fat = 0.20000000000000001,
                            Favorite = false,
                            Name = "Banane",
                            Protein = 1.1000000000000001
                        },
                        new
                        {
                            Id = 8,
                            Calories = 62.0,
                            Carbohydrates = 4.7999999999999998,
                            DayOfWeek = 7,
                            Fat = 3.6000000000000001,
                            Favorite = false,
                            Name = "Vollmilch",
                            Protein = 3.2999999999999998
                        },
                        new
                        {
                            Id = 9,
                            Calories = 252.0,
                            Carbohydrates = 0.0,
                            DayOfWeek = 7,
                            Fat = 18.899999999999999,
                            Favorite = false,
                            Name = "Rindfleisch",
                            Protein = 26.399999999999999
                        },
                        new
                        {
                            Id = 10,
                            Calories = 86.0,
                            Carbohydrates = 20.0,
                            DayOfWeek = 7,
                            Fat = 0.10000000000000001,
                            Favorite = false,
                            Name = "Süßkartoffel",
                            Protein = 1.6000000000000001
                        },
                        new
                        {
                            Id = 11,
                            Calories = 145.0,
                            Carbohydrates = 3.6000000000000001,
                            DayOfWeek = 7,
                            Fat = 10.0,
                            Favorite = false,
                            Name = "Griechischer Joghurt",
                            Protein = 9.3000000000000007
                        },
                        new
                        {
                            Id = 12,
                            Calories = 23.0,
                            Carbohydrates = 3.6000000000000001,
                            DayOfWeek = 7,
                            Fat = 0.40000000000000002,
                            Favorite = false,
                            Name = "Spinat",
                            Protein = 2.8999999999999999
                        },
                        new
                        {
                            Id = 13,
                            Calories = 72.0,
                            Carbohydrates = 0.59999999999999998,
                            DayOfWeek = 7,
                            Fat = 5.2999999999999998,
                            Favorite = false,
                            Name = "Ei (mittelgroß) ",
                            Protein = 6.0
                        },
                        new
                        {
                            Id = 14,
                            Calories = 127.0,
                            Carbohydrates = 19.0,
                            DayOfWeek = 7,
                            Fat = 0.5,
                            Favorite = false,
                            Name = "Kidneybohnen",
                            Protein = 8.6999999999999993
                        },
                        new
                        {
                            Id = 15,
                            Calories = 160.0,
                            Carbohydrates = 8.5,
                            DayOfWeek = 7,
                            Fat = 14.699999999999999,
                            Favorite = false,
                            Name = "Avocado",
                            Protein = 2.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
