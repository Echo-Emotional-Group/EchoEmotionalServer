using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EchoEmotionalServer.Migrations
{
    /// <inheritdoc />
    public partial class ChaveEstrangeiraImplementadaManeiraDiferente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_emotion_Reactions_perfil_users_Perfil_UserId_accont_facebook",
                table: "emotion_Reactions");

            migrationBuilder.DropIndex(
                name: "IX_emotion_Reactions_Perfil_UserId_accont_facebook",
                table: "emotion_Reactions");

            migrationBuilder.DropColumn(
                name: "Perfil_UserId_accont_facebook",
                table: "emotion_Reactions");

            migrationBuilder.CreateIndex(
                name: "IX_emotion_Reactions_Id_account_facebook",
                table: "emotion_Reactions",
                column: "Id_account_facebook");

            migrationBuilder.AddForeignKey(
                name: "FK_emotion_Reactions_perfil_users_Id_account_facebook",
                table: "emotion_Reactions",
                column: "Id_account_facebook",
                principalTable: "perfil_users",
                principalColumn: "Id_accont_facebook",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_emotion_Reactions_perfil_users_Id_account_facebook",
                table: "emotion_Reactions");

            migrationBuilder.DropIndex(
                name: "IX_emotion_Reactions_Id_account_facebook",
                table: "emotion_Reactions");

            migrationBuilder.AddColumn<string>(
                name: "Perfil_UserId_accont_facebook",
                table: "emotion_Reactions",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_emotion_Reactions_Perfil_UserId_accont_facebook",
                table: "emotion_Reactions",
                column: "Perfil_UserId_accont_facebook");

            migrationBuilder.AddForeignKey(
                name: "FK_emotion_Reactions_perfil_users_Perfil_UserId_accont_facebook",
                table: "emotion_Reactions",
                column: "Perfil_UserId_accont_facebook",
                principalTable: "perfil_users",
                principalColumn: "Id_accont_facebook",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
