using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProiectAEWeb.Migrations
{
    public partial class Personal2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Personal",
                table: "Serviciu");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Personal",
                table: "Serviciu",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
