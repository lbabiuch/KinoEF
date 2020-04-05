using Microsoft.EntityFrameworkCore.Migrations;

namespace KinoEF.Migrations
{
    public partial class Sala : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Kina",
                table: "Kina");

            migrationBuilder.RenameTable(
                name: "Kina",
                newName: "Kino");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kino",
                table: "Kino",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    IdSali = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazwaSali = table.Column<string>(nullable: true),
                    LiczbaMiejsc = table.Column<int>(nullable: false),
                    KinoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.IdSali);
                    table.ForeignKey(
                        name: "FK_Sale_Kino_KinoId",
                        column: x => x.KinoId,
                        principalTable: "Kino",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sale_KinoId",
                table: "Sale",
                column: "KinoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kino",
                table: "Kino");

            migrationBuilder.RenameTable(
                name: "Kino",
                newName: "Kina");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kina",
                table: "Kina",
                column: "Id");
        }
    }
}
