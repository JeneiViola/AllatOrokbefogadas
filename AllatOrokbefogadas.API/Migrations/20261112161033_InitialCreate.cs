using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AllatOrokbefogadas.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Allatok",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nev = table.Column<string>(type: "TEXT", nullable: false),
                    Tipus = table.Column<string>(type: "TEXT", nullable: false),
                    Eletkor = table.Column<int>(type: "INTEGER", nullable: false),
                    Telepules = table.Column<string>(type: "TEXT", nullable: false),
                    Aktivitas = table.Column<string>(type: "TEXT", nullable: false),
                    LakasbanTarthato = table.Column<bool>(type: "INTEGER", nullable: false),
                    MasAllattalKijon = table.Column<bool>(type: "INTEGER", nullable: false),
                    Leiras = table.Column<string>(type: "TEXT", nullable: false),
                    KepUrl = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allatok", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Allatok");
        }
    }
}
