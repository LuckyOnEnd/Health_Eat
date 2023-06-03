using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Healt_Food.Server.Migrations
{
    /// <inheritdoc />
    public partial class testSeed14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_WeeklyPlans_WeeklyPlanId",
                table: "Foods");

            migrationBuilder.DropTable(
                name: "WeeklyPlans");

            migrationBuilder.DropIndex(
                name: "IX_Foods_WeeklyPlanId",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "WeeklyPlanId",
                table: "Foods");

            migrationBuilder.AddColumn<int>(
                name: "DayOfWeek",
                table: "Foods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "DayOfWeek",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "DayOfWeek",
                value: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DayOfWeek",
                table: "Foods");

            migrationBuilder.AddColumn<int>(
                name: "WeeklyPlanId",
                table: "Foods",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "WeeklyPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayOfWeek = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeeklyPlans", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                column: "WeeklyPlanId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "WeeklyPlanId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Foods_WeeklyPlanId",
                table: "Foods",
                column: "WeeklyPlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_WeeklyPlans_WeeklyPlanId",
                table: "Foods",
                column: "WeeklyPlanId",
                principalTable: "WeeklyPlans",
                principalColumn: "Id");
        }
    }
}
