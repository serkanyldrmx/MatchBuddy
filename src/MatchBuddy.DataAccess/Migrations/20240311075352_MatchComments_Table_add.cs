using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MatchBuddy.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class MatchComments_Table_add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Match_Player_PlayerId",
                table: "Match");

            migrationBuilder.DropIndex(
                name: "IX_Match_PlayerId",
                table: "Match");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "Match");

            migrationBuilder.CreateTable(
                name: "MatchComments",
                columns: table => new
                {
                    CommentsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    MatchId = table.Column<int>(type: "int", nullable: false),
                    MatchId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchComments", x => x.CommentsId);
                    table.ForeignKey(
                        name: "FK_MatchComments_Match_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Match",
                        principalColumn: "MatchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MatchComments_Match_MatchId1",
                        column: x => x.MatchId1,
                        principalTable: "Match",
                        principalColumn: "MatchId");
                    table.ForeignKey(
                        name: "FK_MatchComments_Player_UserId",
                        column: x => x.UserId,
                        principalTable: "Player",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MatchComments_MatchId",
                table: "MatchComments",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchComments_MatchId1",
                table: "MatchComments",
                column: "MatchId1");

            migrationBuilder.CreateIndex(
                name: "IX_MatchComments_UserId",
                table: "MatchComments",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MatchComments");

            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "Match",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Match_PlayerId",
                table: "Match",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Match_Player_PlayerId",
                table: "Match",
                column: "PlayerId",
                principalTable: "Player",
                principalColumn: "PlayerId");
        }
    }
}
