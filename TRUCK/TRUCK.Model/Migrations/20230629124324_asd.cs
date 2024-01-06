using Microsoft.EntityFrameworkCore.Migrations;

namespace TRUCK.Model.Migrations
{
    public partial class asd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Oparetor",
                table: "Sales");

            migrationBuilder.AddColumn<string>(
                name: "DriverID",
                table: "Sales",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DriverID1",
                table: "Sales",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_DriverID1",
                table: "Sales",
                column: "DriverID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Drivers_DriverID1",
                table: "Sales",
                column: "DriverID1",
                principalTable: "Drivers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Drivers_DriverID1",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_DriverID1",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "DriverID",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "DriverID1",
                table: "Sales");

            migrationBuilder.AddColumn<string>(
                name: "Oparetor",
                table: "Sales",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
