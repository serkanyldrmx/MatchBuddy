using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MatchBuddy.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Message_table_add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NotificationId",
                table: "Player",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreateorUser",
                table: "Match",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "Match",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    NotificationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.NotificationId);
                });

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    MessageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatchMessage = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    SendingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: false),
                    NotificationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.MessageId);
                    table.ForeignKey(
                        name: "FK_Message_Notification_NotificationId",
                        column: x => x.NotificationId,
                        principalTable: "Notification",
                        principalColumn: "NotificationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Player_NotificationId",
                table: "Player",
                column: "NotificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Match_PlayerId",
                table: "Match",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Message_NotificationId",
                table: "Message",
                column: "NotificationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Match_Player_PlayerId",
                table: "Match",
                column: "PlayerId",
                principalTable: "Player",
                principalColumn: "PlayerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Notification_NotificationId",
                table: "Player",
                column: "NotificationId",
                principalTable: "Notification",
                principalColumn: "NotificationId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Match_Player_PlayerId",
                table: "Match");

            migrationBuilder.DropForeignKey(
                name: "FK_Player_Notification_NotificationId",
                table: "Player");

            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DropIndex(
                name: "IX_Player_NotificationId",
                table: "Player");

            migrationBuilder.DropIndex(
                name: "IX_Match_PlayerId",
                table: "Match");

            migrationBuilder.DropColumn(
                name: "NotificationId",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "CreateorUser",
                table: "Match");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "Match");
        }
    }
}
