using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MatchBuddy.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Message_tablee_add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MatchMessage",
                table: "Message",
                newName: "MatchMesage");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MatchMesage",
                table: "Message",
                newName: "MatchMessage");
        }
    }
}
