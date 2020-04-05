using Microsoft.EntityFrameworkCore.Migrations;

namespace KinoEF.Migrations
{
    public partial class Adres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adres",
                table: "Kina");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Kina",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateTable(
                name: "Adresy",
                columns: table => new
                {
                    IdKina = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Miasto = table.Column<string>(nullable: true),
                    Ulica = table.Column<string>(nullable: true),
                    Numer = table.Column<int>(nullable: false),
                    NumerTel = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresy", x => x.IdKina);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Kina_Adresy_Id",
                table: "Kina",
                column: "Id",
                principalTable: "Adresy",
                principalColumn: "IdKina",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kina_Adresy_Id",
                table: "Kina");

            migrationBuilder.DropTable(
                name: "Adresy");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Kina",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Adres",
                table: "Kina",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
