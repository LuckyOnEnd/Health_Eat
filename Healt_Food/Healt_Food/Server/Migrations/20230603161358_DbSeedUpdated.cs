using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Healt_Food.Server.Migrations
{
    /// <inheritdoc />
    public partial class DbSeedUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Calories", "Carbohydrates", "DayOfWeek", "Fat", "Name", "Protein" },
                values: new object[] { 147.0, 0.0, 7, 1.5, "Hühnerbrust", 31.0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Calories", "Carbohydrates", "DayOfWeek", "Fat", "Favorite", "Name", "Protein" },
                values: new object[] { 31.0, 6.0, 7, 0.59999999999999998, false, "Brokkoli", 2.7999999999999998 });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Calories", "Carbohydrates", "DayOfWeek", "Fat", "Favorite", "Name", "Protein" },
                values: new object[,]
                {
                    { 3, 389.0, 56.0, 7, 7.0, false, "Haferflocken", 13.0 },
                    { 4, 206.0, 0.0, 7, 13.6, false, "Lachsfilet", 20.399999999999999 },
                    { 5, 368.0, 63.0, 7, 6.0999999999999996, false, "Quinoa", 14.0 },
                    { 6, 576.0, 21.0, 7, 49.899999999999999, false, "Mandeln", 21.0 },
                    { 7, 96.0, 22.0, 7, 0.20000000000000001, false, "Banane", 1.1000000000000001 },
                    { 8, 62.0, 4.7999999999999998, 7, 3.6000000000000001, false, "Vollmilch", 3.2999999999999998 },
                    { 9, 252.0, 0.0, 7, 18.899999999999999, false, "Rindfleisch", 26.399999999999999 },
                    { 10, 86.0, 20.0, 7, 0.10000000000000001, false, "Süßkartoffel", 1.6000000000000001 },
                    { 11, 145.0, 3.6000000000000001, 7, 10.0, false, "Griechischer Joghurt", 9.3000000000000007 },
                    { 12, 23.0, 3.6000000000000001, 7, 0.40000000000000002, false, "Spinat", 2.8999999999999999 },
                    { 13, 72.0, 0.59999999999999998, 7, 5.2999999999999998, false, "Ei (mittelgroß) ", 6.0 },
                    { 14, 127.0, 19.0, 7, 0.5, false, "Kidneybohnen", 8.6999999999999993 },
                    { 15, 160.0, 8.5, 7, 14.699999999999999, false, "Avocado", 2.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Calories", "Carbohydrates", "DayOfWeek", "Fat", "Name", "Protein" },
                values: new object[] { 12.0, 1234.0, 1, 15.0, "Foo", 15.0 });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Calories", "Carbohydrates", "DayOfWeek", "Fat", "Favorite", "Name", "Protein" },
                values: new object[] { 123.0, 124.0, 2, 1.0, true, "Bar", 515.0 });
        }
    }
}
