using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Healt_Food.Server.Migrations
{
    /// <inheritdoc />
    public partial class testSeed13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeeklyPlans_Foods_FoodInfoId",
                table: "WeeklyPlans");

            migrationBuilder.DropIndex(
                name: "IX_WeeklyPlans_FoodInfoId",
                table: "WeeklyPlans");

            migrationBuilder.DropColumn(
                name: "FoodInfoId",
                table: "WeeklyPlans");

            migrationBuilder.AddColumn<int>(
                name: "WeeklyPlanId",
                table: "Foods",
                type: "int",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_WeeklyPlans_WeeklyPlanId",
                table: "Foods");

            migrationBuilder.DropIndex(
                name: "IX_Foods_WeeklyPlanId",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "WeeklyPlanId",
                table: "Foods");

            migrationBuilder.AddColumn<int>(
                name: "FoodInfoId",
                table: "WeeklyPlans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_WeeklyPlans_FoodInfoId",
                table: "WeeklyPlans",
                column: "FoodInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_WeeklyPlans_Foods_FoodInfoId",
                table: "WeeklyPlans",
                column: "FoodInfoId",
                principalTable: "Foods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
