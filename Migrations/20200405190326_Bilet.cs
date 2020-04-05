using Microsoft.EntityFrameworkCore.Migrations;

namespace KinoEF.Migrations
{
    public partial class Bilet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bilety",
                columns: table => new
                {
                    IdBiletu = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cena = table.Column<double>(nullable: false),
                    MiejsceIdMiejsca = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bilety", x => x.IdBiletu);
                    table.ForeignKey(
                        name: "FK_Bilety_Miejsca_MiejsceIdMiejsca",
                        column: x => x.MiejsceIdMiejsca,
                        principalTable: "Miejsca",
                        principalColumn: "IdMiejsca",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bilety_MiejsceIdMiejsca",
                table: "Bilety",
                column: "MiejsceIdMiejsca");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bilety");
        }
    }
}
