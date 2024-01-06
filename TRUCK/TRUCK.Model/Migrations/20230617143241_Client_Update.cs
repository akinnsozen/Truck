using Microsoft.EntityFrameworkCore.Migrations;

namespace TRUCK.Model.Migrations
{
    public partial class Client_Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Sales",
                newName: "ClientSurname");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Sales",
                newName: "ClientName");

            migrationBuilder.AddColumn<string>(
                name: "ClientMobileNo",
                table: "Sales",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientMobileNo",
                table: "Sales");

            migrationBuilder.RenameColumn(
                name: "ClientSurname",
                table: "Sales",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "ClientName",
                table: "Sales",
                newName: "Name");
        }
    }
}
