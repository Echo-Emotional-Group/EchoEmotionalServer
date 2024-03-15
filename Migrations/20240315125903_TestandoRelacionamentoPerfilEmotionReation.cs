using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EchoEmotionalServer.Migrations
{
    /// <inheritdoc />
    public partial class TestandoRelacionamentoPerfilEmotionReation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_emotion_Reactions_Emotions_Emotion_Id",
                table: "emotion_Reactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Emotions_Perfil_users_Id_Post",
                table: "Emotions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Perfil_users",
                table: "Perfil_users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Emotions",
                table: "Emotions");

            migrationBuilder.RenameTable(
                name: "Perfil_users",
                newName: "perfil_users");

            migrationBuilder.RenameTable(
                name: "Emotions",
                newName: "emotions");

            migrationBuilder.RenameIndex(
                name: "IX_Emotions_Id_Post",
                table: "emotions",
                newName: "IX_emotions_Id_Post");

            migrationBuilder.AlterColumn<string>(
                name: "Id_account_facebook",
                table: "emotion_Reactions",
                type: "text",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddColumn<string>(
                name: "Perfil_UserId_accont_facebook",
                table: "emotion_Reactions",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_perfil_users",
                table: "perfil_users",
                column: "Id_accont_facebook");

            migrationBuilder.AddPrimaryKey(
                name: "PK_emotions",
                table: "emotions",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_emotion_Reactions_Perfil_UserId_accont_facebook",
                table: "emotion_Reactions",
                column: "Perfil_UserId_accont_facebook");

            migrationBuilder.AddForeignKey(
                name: "FK_emotion_Reactions_emotions_Emotion_Id",
                table: "emotion_Reactions",
                column: "Emotion_Id",
                principalTable: "emotions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_emotion_Reactions_perfil_users_Perfil_UserId_accont_facebook",
                table: "emotion_Reactions",
                column: "Perfil_UserId_accont_facebook",
                principalTable: "perfil_users",
                principalColumn: "Id_accont_facebook",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_emotions_perfil_users_Id_Post",
                table: "emotions",
                column: "Id_Post",
                principalTable: "perfil_users",
                principalColumn: "Id_accont_facebook");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_emotion_Reactions_emotions_Emotion_Id",
                table: "emotion_Reactions");

            migrationBuilder.DropForeignKey(
                name: "FK_emotion_Reactions_perfil_users_Perfil_UserId_accont_facebook",
                table: "emotion_Reactions");

            migrationBuilder.DropForeignKey(
                name: "FK_emotions_perfil_users_Id_Post",
                table: "emotions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_perfil_users",
                table: "perfil_users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_emotions",
                table: "emotions");

            migrationBuilder.DropIndex(
                name: "IX_emotion_Reactions_Perfil_UserId_accont_facebook",
                table: "emotion_Reactions");

            migrationBuilder.DropColumn(
                name: "Perfil_UserId_accont_facebook",
                table: "emotion_Reactions");

            migrationBuilder.RenameTable(
                name: "perfil_users",
                newName: "Perfil_users");

            migrationBuilder.RenameTable(
                name: "emotions",
                newName: "Emotions");

            migrationBuilder.RenameIndex(
                name: "IX_emotions_Id_Post",
                table: "Emotions",
                newName: "IX_Emotions_Id_Post");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id_account_facebook",
                table: "emotion_Reactions",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Perfil_users",
                table: "Perfil_users",
                column: "Id_accont_facebook");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emotions",
                table: "Emotions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_emotion_Reactions_Emotions_Emotion_Id",
                table: "emotion_Reactions",
                column: "Emotion_Id",
                principalTable: "Emotions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Emotions_Perfil_users_Id_Post",
                table: "Emotions",
                column: "Id_Post",
                principalTable: "Perfil_users",
                principalColumn: "Id_accont_facebook");
        }
    }
}
