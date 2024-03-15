using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EchoEmotionalServer.Migrations
{
    /// <inheritdoc />
    public partial class ChaveEstrangeiraEmotionReactions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_emotion_Reactions",
                table: "emotion_Reactions");

            migrationBuilder.AlterColumn<string>(
                name: "Id_account_facebook",
                table: "emotion_Reactions",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_emotion_Reactions",
                table: "emotion_Reactions",
                columns: new[] { "Emotion_Id", "Reaction_Id", "Id_account_facebook" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_emotion_Reactions",
                table: "emotion_Reactions");

            migrationBuilder.AlterColumn<string>(
                name: "Id_account_facebook",
                table: "emotion_Reactions",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddPrimaryKey(
                name: "PK_emotion_Reactions",
                table: "emotion_Reactions",
                columns: new[] { "Emotion_Id", "Reaction_Id" });
        }
    }
}
