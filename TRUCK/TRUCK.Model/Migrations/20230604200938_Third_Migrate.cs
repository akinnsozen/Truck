using Microsoft.EntityFrameworkCore.Migrations;

namespace TRUCK.Model.Migrations
{
    public partial class Third_Migrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Day",
                table: "Sales",
                type: "int",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Oparetor",
                table: "Sales",
                type: "bit",
                maxLength: 50,
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TotalPrice",
                table: "Sales",
                type: "int",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WorkMachineID",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_WorkMachineID",
                table: "Sales",
                column: "WorkMachineID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_WorkMachines_WorkMachineID",
                table: "Sales",
                column: "WorkMachineID",
                principalTable: "WorkMachines",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_WorkMachines_WorkMachineID",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_WorkMachineID",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "Day",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "Oparetor",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "WorkMachineID",
                table: "Sales");
        }
    }
}
