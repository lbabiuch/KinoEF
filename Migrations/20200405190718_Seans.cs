using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KinoEF.Migrations
{
    public partial class Seans : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SeansIdSeansu",
                table: "Bilety",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Seanse",
                columns: table => new
                {
                    IdSeansu = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazwaSeansu = table.Column<string>(nullable: true),
                    Data = table.Column<DateTime>(nullable: false),
                    Godzina = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seanse", x => x.IdSeansu);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bilety_SeansIdSeansu",
                table: "Bilety",
                column: "SeansIdSeansu");

            migrationBuilder.AddForeignKey(
                name: "FK_Bilety_Seanse_SeansIdSeansu",
                table: "Bilety",
                column: "SeansIdSeansu",
                principalTable: "Seanse",
                principalColumn: "IdSeansu",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bilety_Seanse_SeansIdSeansu",
                table: "Bilety");

            migrationBuilder.DropTable(
                name: "Seanse");

            migrationBuilder.DropIndex(
                name: "IX_Bilety_SeansIdSeansu",
                table: "Bilety");

            migrationBuilder.DropColumn(
                name: "SeansIdSeansu",
                table: "Bilety");
        }
    }
}
