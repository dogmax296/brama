using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Brama.Migrations
{
    /// <inheritdoc />
    public partial class RemovePersonUsername : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "username",
                table: "person");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "username",
                table: "person",
                type: "text",
                nullable: true);
        }
    }
}
