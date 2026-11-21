using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AllatOrokbefogadas.API.Migrations
{
    /// <inheritdoc />
    public partial class AddAllatNem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nem",
                table: "Allatok",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nem",
                table: "Allatok");
        }
    }
}
