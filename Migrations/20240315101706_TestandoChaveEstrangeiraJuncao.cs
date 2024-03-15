using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EchoEmotionalServer.Migrations
{
    /// <inheritdoc />
    public partial class TestandoChaveEstrangeiraJuncao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_emotion_Reactions",
                table: "emotion_Reactions");

            migrationBuilder.DropIndex(
                name: "IX_emotion_Reactions_Emotion_Id",
                table: "emotion_Reactions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_emotion_Reactions",
                table: "emotion_Reactions",
                columns: new[] { "Emotion_Id", "Reaction_Id" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_emotion_Reactions",
                table: "emotion_Reactions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_emotion_Reactions",
                table: "emotion_Reactions",
                column: "Id_account_facebook");

            migrationBuilder.CreateIndex(
                name: "IX_emotion_Reactions_Emotion_Id",
                table: "emotion_Reactions",
                column: "Emotion_Id");
        }
    }
}
