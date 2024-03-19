using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MatchBuddy.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class MathTeamtableadd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Match_Team_TeamId",
                table: "Match");

            migrationBuilder.DropForeignKey(
                name: "FK_Message_Player_PlayerId",
                table: "Message");

            migrationBuilder.DropForeignKey(
                name: "FK_Message_Player_SendPlayerId",
                table: "Message");

            migrationBuilder.DropTable(
                name: "MatchComments");

            migrationBuilder.DropIndex(
                name: "IX_Message_PlayerId",
                table: "Message");

            migrationBuilder.DropIndex(
                name: "IX_Message_SendPlayerId",
                table: "Message");

            migrationBuilder.DropIndex(
                name: "IX_Match_TeamId",
                table: "Match");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "Message");

            migrationBuilder.RenameColumn(
                name: "TeamId",
                table: "Match",
                newName: "MatchTeamId");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Stadiums",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "Stadiums",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Stadiums",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "SendPlayerId",
                table: "Message",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "MatchComment",
                columns: table => new
                {
                    CommentsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    playerId = table.Column<int>(type: "int", nullable: false),
                    MatchId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchComment", x => x.CommentsId);
                    table.ForeignKey(
                        name: "FK_MatchComment_Match_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Match",
                        principalColumn: "MatchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MatchComment_Player_playerId",
                        column: x => x.playerId,
                        principalTable: "Player",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MatchTeam",
                columns: table => new
                {
                    MatchTeamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatchId = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchTeam", x => x.MatchTeamId);
                    table.ForeignKey(
                        name: "FK_MatchTeam_Match_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Match",
                        principalColumn: "MatchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MatchTeam_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    MatchId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_User_Match_MatchId",
                        column: x => x.MatchId,
                        principalTable: "Match",
                        principalColumn: "MatchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Player_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Player",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MatchComment_MatchId",
                table: "MatchComment",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchComment_playerId",
                table: "MatchComment",
                column: "playerId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchTeam_MatchId",
                table: "MatchTeam",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchTeam_TeamId",
                table: "MatchTeam",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_User_MatchId",
                table: "User",
                column: "MatchId");

            migrationBuilder.CreateIndex(
                name: "IX_User_PlayerId",
                table: "User",
                column: "PlayerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MatchComment");

            migrationBuilder.DropTable(
                name: "MatchTeam");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Stadiums");

            migrationBuilder.DropColumn(
                name: "District",
                table: "Stadiums");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Stadiums");

            migrationBuilder.RenameColumn(
                name: "MatchTeamId",
                table: "Match",
                newName: "TeamId");

            migrationBuilder.AlterColumn<int>(
                name: "SendPlayerId",
                table: "Message",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "Message",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MatchComments",
                columns: table => new
                {
                    CommentsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatchId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
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
                name: "IX_Message_PlayerId",
                table: "Message",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Message_SendPlayerId",
                table: "Message",
                column: "SendPlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Match_TeamId",
                table: "Match",
                column: "TeamId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Match_Team_TeamId",
                table: "Match",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Message_Player_PlayerId",
                table: "Message",
                column: "PlayerId",
                principalTable: "Player",
                principalColumn: "PlayerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Message_Player_SendPlayerId",
                table: "Message",
                column: "SendPlayerId",
                principalTable: "Player",
                principalColumn: "PlayerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
