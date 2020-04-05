using Microsoft.EntityFrameworkCore.Migrations;

namespace KinoEF.Migrations
{
    public partial class Miejsce : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sale_Kino_KinoId",
                table: "Sale");

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

            migrationBuilder.CreateTable(
                name: "Miejsca",
                columns: table => new
                {
                    IdMiejsca = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rzad = table.Column<int>(nullable: false),
                    Numer = table.Column<int>(nullable: false),
                    SalaIdSali = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Miejsca", x => x.IdMiejsca);
                    table.ForeignKey(
                        name: "FK_Miejsca_Sale_SalaIdSali",
                        column: x => x.SalaIdSali,
                        principalTable: "Sale",
                        principalColumn: "IdSali",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Miejsca_SalaIdSali",
                table: "Miejsca",
                column: "SalaIdSali");

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_Kina_KinoId",
                table: "Sale",
                column: "KinoId",
                principalTable: "Kina",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sale_Kina_KinoId",
                table: "Sale");

            migrationBuilder.DropTable(
                name: "Miejsca");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Sale_Kino_KinoId",
                table: "Sale",
                column: "KinoId",
                principalTable: "Kino",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
