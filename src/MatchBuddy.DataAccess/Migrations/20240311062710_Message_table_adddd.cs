using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MatchBuddy.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Message_table_adddd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message_Notification_NotificationId",
                table: "Message");

            migrationBuilder.DropForeignKey(
                name: "FK_Player_Notification_NotificationId",
                table: "Player");

            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DropIndex(
                name: "IX_Player_NotificationId",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "NotificationId",
                table: "Player");

            migrationBuilder.RenameColumn(
                name: "NotificationId",
                table: "Message",
                newName: "SendPlayerId");

            migrationBuilder.RenameColumn(
                name: "MatchMesage",
                table: "Message",
                newName: "MatchMessage");

            migrationBuilder.RenameIndex(
                name: "IX_Message_NotificationId",
                table: "Message",
                newName: "IX_Message_SendPlayerId");

            migrationBuilder.RenameColumn(
                name: "CreateorUser",
                table: "Match",
                newName: "CreateorUserId");

            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "Message",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecipientPlayerId",
                table: "Message",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Message_PlayerId",
                table: "Message",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_Player_PlayerId",
                table: "Message",
                column: "PlayerId",
                principalTable: "Player",
                principalColumn: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_Player_SendPlayerId",
                table: "Message",
                column: "SendPlayerId",
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

            migrationBuilder.DropForeignKey(
                name: "FK_Message_Player_SendPlayerId",
                table: "Message");

            migrationBuilder.DropIndex(
                name: "IX_Message_PlayerId",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "RecipientPlayerId",
                table: "Message");

            migrationBuilder.RenameColumn(
                name: "SendPlayerId",
                table: "Message",
                newName: "NotificationId");

            migrationBuilder.RenameColumn(
                name: "MatchMessage",
                table: "Message",
                newName: "MatchMesage");

            migrationBuilder.RenameIndex(
                name: "IX_Message_SendPlayerId",
                table: "Message",
                newName: "IX_Message_NotificationId");

            migrationBuilder.RenameColumn(
                name: "CreateorUserId",
                table: "Match",
                newName: "CreateorUser");

            migrationBuilder.AddColumn<int>(
                name: "NotificationId",
                table: "Player",
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

            migrationBuilder.CreateIndex(
                name: "IX_Player_NotificationId",
                table: "Player",
                column: "NotificationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_Notification_NotificationId",
                table: "Message",
                column: "NotificationId",
                principalTable: "Notification",
                principalColumn: "NotificationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Notification_NotificationId",
                table: "Player",
                column: "NotificationId",
                principalTable: "Notification",
                principalColumn: "NotificationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
