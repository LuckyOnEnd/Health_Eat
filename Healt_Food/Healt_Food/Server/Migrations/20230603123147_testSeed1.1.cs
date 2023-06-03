using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Healt_Food.Server.Migrations
{
    /// <inheritdoc />
    public partial class testSeed11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Favorites_FavoritesId",
                table: "Foods");

            migrationBuilder.DropIndex(
                name: "IX_Foods_FavoritesId",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "FavoritesId",
                table: "Foods");

            migrationBuilder.AddColumn<int>(
                name: "FoodsId",
                table: "Favorites",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Favorites",
                columns: new[] { "Id", "FoodsId" },
                values: new object[] { 1, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Favorites",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "FoodsId",
                table: "Favorites");

            migrationBuilder.AddColumn<int>(
                name: "FavoritesId",
                table: "Foods",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "FavoritesId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "FavoritesId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Foods_FavoritesId",
                table: "Foods",
                column: "FavoritesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Favorites_FavoritesId",
                table: "Foods",
                column: "FavoritesId",
                principalTable: "Favorites",
                principalColumn: "Id");
        }
    }
}
