using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Healt_Food.Server.Migrations
{
    /// <inheritdoc />
    public partial class testSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Calories", "Carbohydrates", "Fat", "FavoritesId", "Name", "Protein" },
                values: new object[,]
                {
                    { 1, 12.0, 1234.0, 15.0, null, "Foo", 15.0 },
                    { 2, 123.0, 124.0, 1.0, null, "Bar", 515.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
