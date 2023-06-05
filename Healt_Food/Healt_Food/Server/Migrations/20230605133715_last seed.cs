using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Healt_Food.Server.Migrations
{
    /// <inheritdoc />
    public partial class lastseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DayOfWeek",
                table: "Foods");

            migrationBuilder.AddColumn<bool>(
                name: "InFriday",
                table: "Foods",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "InMonday",
                table: "Foods",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "InSaturday",
                table: "Foods",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "InSunday",
                table: "Foods",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "InThursday",
                table: "Foods",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "InTuesday",
                table: "Foods",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "InWednesday",
                table: "Foods",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InFriday", "InMonday", "InSaturday", "InSunday", "InThursday", "InTuesday", "InWednesday" },
                values: new object[] { false, false, false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InFriday", "InMonday", "InSaturday", "InSunday", "InThursday", "InTuesday", "InWednesday" },
                values: new object[] { false, false, false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InFriday", "InMonday", "InSaturday", "InSunday", "InThursday", "InTuesday", "InWednesday" },
                values: new object[] { false, false, false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InFriday", "InMonday", "InSaturday", "InSunday", "InThursday", "InTuesday", "InWednesday" },
                values: new object[] { false, false, false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InFriday", "InMonday", "InSaturday", "InSunday", "InThursday", "InTuesday", "InWednesday" },
                values: new object[] { false, false, false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InFriday", "InMonday", "InSaturday", "InSunday", "InThursday", "InTuesday", "InWednesday" },
                values: new object[] { false, false, false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "InFriday", "InMonday", "InSaturday", "InSunday", "InThursday", "InTuesday", "InWednesday" },
                values: new object[] { false, false, false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "InFriday", "InMonday", "InSaturday", "InSunday", "InThursday", "InTuesday", "InWednesday" },
                values: new object[] { false, false, false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "InFriday", "InMonday", "InSaturday", "InSunday", "InThursday", "InTuesday", "InWednesday" },
                values: new object[] { false, false, false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "InFriday", "InMonday", "InSaturday", "InSunday", "InThursday", "InTuesday", "InWednesday" },
                values: new object[] { false, false, false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "InFriday", "InMonday", "InSaturday", "InSunday", "InThursday", "InTuesday", "InWednesday" },
                values: new object[] { false, false, false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "InFriday", "InMonday", "InSaturday", "InSunday", "InThursday", "InTuesday", "InWednesday" },
                values: new object[] { false, false, false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "InFriday", "InMonday", "InSaturday", "InSunday", "InThursday", "InTuesday", "InWednesday" },
                values: new object[] { false, false, false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "InFriday", "InMonday", "InSaturday", "InSunday", "InThursday", "InTuesday", "InWednesday" },
                values: new object[] { false, false, false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "InFriday", "InMonday", "InSaturday", "InSunday", "InThursday", "InTuesday", "InWednesday" },
                values: new object[] { false, false, false, false, false, false, false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InFriday",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "InMonday",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "InSaturday",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "InSunday",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "InThursday",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "InTuesday",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "InWednesday",
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
                value: 7);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2,
                column: "DayOfWeek",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "DayOfWeek",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                column: "DayOfWeek",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5,
                column: "DayOfWeek",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6,
                column: "DayOfWeek",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7,
                column: "DayOfWeek",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8,
                column: "DayOfWeek",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9,
                column: "DayOfWeek",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10,
                column: "DayOfWeek",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 11,
                column: "DayOfWeek",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 12,
                column: "DayOfWeek",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 13,
                column: "DayOfWeek",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 14,
                column: "DayOfWeek",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 15,
                column: "DayOfWeek",
                value: 7);
        }
    }
}
