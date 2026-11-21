using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AllatOrokbefogadas.API.Migrations
{
    /// <inheritdoc />
    public partial class AddEletkorSzoveg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EletkorSzoveg",
                table: "Allatok",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EletkorSzoveg",
                table: "Allatok");
        }
    }
}
