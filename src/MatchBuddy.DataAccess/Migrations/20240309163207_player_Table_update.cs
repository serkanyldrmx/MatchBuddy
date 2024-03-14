using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MatchBuddy.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class player_Table_update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_Match_MatchId",
                table: "Player");

            migrationBuilder.RenameColumn(
                name: "MatchId",
                table: "Player",
                newName: "TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_Player_MatchId",
                table: "Player",
                newName: "IX_Player_TeamId");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Match",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "IsActive",
                table: "Match",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "MatchDate",
                table: "Match",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "Match",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserCount",
                table: "Match",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    TeamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.TeamId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Match_TeamId",
                table: "Match",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Match_Team_TeamId",
                table: "Match",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Team_TeamId",
                table: "Player",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "TeamId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Match_Team_TeamId",
                table: "Match");

            migrationBuilder.DropForeignKey(
                name: "FK_Player_Team_TeamId",
                table: "Player");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropIndex(
                name: "IX_Match_TeamId",
                table: "Match");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Match");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Match");

            migrationBuilder.DropColumn(
                name: "MatchDate",
                table: "Match");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Match");

            migrationBuilder.DropColumn(
                name: "UserCount",
                table: "Match");

            migrationBuilder.RenameColumn(
                name: "TeamId",
                table: "Player",
                newName: "MatchId");

            migrationBuilder.RenameIndex(
                name: "IX_Player_TeamId",
                table: "Player",
                newName: "IX_Player_MatchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Match_MatchId",
                table: "Player",
                column: "MatchId",
                principalTable: "Match",
                principalColumn: "MatchId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
