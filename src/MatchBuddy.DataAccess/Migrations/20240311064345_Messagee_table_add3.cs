using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MatchBuddy.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Messagee_table_add3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateorUserId",
                table: "Match");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreateorUserId",
                table: "Match",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
