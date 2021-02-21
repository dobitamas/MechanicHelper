using Microsoft.EntityFrameworkCore.Migrations;

namespace MechanicHelper.Migrations
{
    public partial class AddedServices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RepairService_Cars_ServicedOnId",
                table: "RepairService");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RepairService",
                table: "RepairService");

            migrationBuilder.RenameTable(
                name: "RepairService",
                newName: "RepairServices");

            migrationBuilder.RenameIndex(
                name: "IX_RepairService_ServicedOnId",
                table: "RepairServices",
                newName: "IX_RepairServices_ServicedOnId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RepairServices",
                table: "RepairServices",
                column: "RepairServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_RepairServices_Cars_ServicedOnId",
                table: "RepairServices",
                column: "ServicedOnId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RepairServices_Cars_ServicedOnId",
                table: "RepairServices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RepairServices",
                table: "RepairServices");

            migrationBuilder.RenameTable(
                name: "RepairServices",
                newName: "RepairService");

            migrationBuilder.RenameIndex(
                name: "IX_RepairServices_ServicedOnId",
                table: "RepairService",
                newName: "IX_RepairService_ServicedOnId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RepairService",
                table: "RepairService",
                column: "RepairServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_RepairService_Cars_ServicedOnId",
                table: "RepairService",
                column: "ServicedOnId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
