using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Burger.DAL.Migrations
{
    public partial class Login_fields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Kullanicilar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Kullanicilar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Kullanicilar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Kullanicilar");
        }
    }
}
