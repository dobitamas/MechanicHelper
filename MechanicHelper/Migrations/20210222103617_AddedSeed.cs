using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MechanicHelper.Migrations
{
    public partial class AddedSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "Built", "Distance", "Make", "Model" },
                values: new object[] { -1, new DateTime(2021, 2, 22, 11, 36, 17, 316, DateTimeKind.Local).AddTicks(1298), 20000, "Alfa", "Romeo" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "Built", "Distance", "Make", "Model" },
                values: new object[] { -2, new DateTime(2021, 2, 22, 11, 36, 17, 318, DateTimeKind.Local).AddTicks(8851), 20000, "Alfa", "Romeo" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "Built", "Distance", "Make", "Model" },
                values: new object[] { -3, new DateTime(2021, 2, 22, 11, 36, 17, 318, DateTimeKind.Local).AddTicks(8882), 20000, "Alfa", "Romeo" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "CarId",
                keyValue: -1);
        }
    }
}
