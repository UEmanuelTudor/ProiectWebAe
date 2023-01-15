using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProiectAEWeb.Migrations
{
    public partial class Personal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonalID",
                table: "Serviciu",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Personal",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenume = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personal", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Serviciu_PersonalID",
                table: "Serviciu",
                column: "PersonalID");

            migrationBuilder.AddForeignKey(
                name: "FK_Serviciu_Personal_PersonalID",
                table: "Serviciu",
                column: "PersonalID",
                principalTable: "Personal",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Serviciu_Personal_PersonalID",
                table: "Serviciu");

            migrationBuilder.DropTable(
                name: "Personal");

            migrationBuilder.DropIndex(
                name: "IX_Serviciu_PersonalID",
                table: "Serviciu");

            migrationBuilder.DropColumn(
                name: "PersonalID",
                table: "Serviciu");
        }
    }
}
