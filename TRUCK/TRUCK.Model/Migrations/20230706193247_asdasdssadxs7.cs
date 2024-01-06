using Microsoft.EntityFrameworkCore.Migrations;

namespace TRUCK.Model.Migrations
{
    public partial class asdasdssadxs7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Drivers_DriverID1",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_DriverID1",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "DriverID1",
                table: "Sales");

            migrationBuilder.AlterColumn<int>(
                name: "DriverID",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_DriverID",
                table: "Sales",
                column: "DriverID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Drivers_DriverID",
                table: "Sales",
                column: "DriverID",
                principalTable: "Drivers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Drivers_DriverID",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_DriverID",
                table: "Sales");

            migrationBuilder.AlterColumn<string>(
                name: "DriverID",
                table: "Sales",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
    }
}
