using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MatchBuddy.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Message_tablee_addd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message_Player_PlayerId",
                table: "Message");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_Player_PlayerId",
                table: "Message",
                column: "PlayerId",
                principalTable: "Player",
                principalColumn: "PlayerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message_Player_PlayerId",
                table: "Message");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_Player_PlayerId",
                table: "Message",
                column: "PlayerId",
                principalTable: "Player",
                principalColumn: "PlayerId");
        }
    }
}
