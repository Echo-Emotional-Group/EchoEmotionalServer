using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EchoEmotionalServer.Migrations
{
    /// <inheritdoc />
    public partial class MudeiTipoIdPost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emotion_Perfil_users_Perfil_UserId",
                table: "Emotion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Emotion",
                table: "Emotion");

            migrationBuilder.DropIndex(
                name: "IX_Emotion_Perfil_UserId",
                table: "Emotion");

            migrationBuilder.DropColumn(
                name: "Perfil_UserId",
                table: "Emotion");

            migrationBuilder.RenameTable(
                name: "Emotion",
                newName: "Emotions");

            migrationBuilder.AlterColumn<string>(
                name: "Full_Name",
                table: "Perfil_users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Perfil_users",
                type: "text",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<string>(
                name: "Id_Post",
                table: "Emotions",
                type: "text",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emotions",
                table: "Emotions",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Emotions_Id_Post",
                table: "Emotions",
                column: "Id_Post");

            migrationBuilder.AddForeignKey(
                name: "FK_Emotions_Perfil_users_Id_Post",
                table: "Emotions",
                column: "Id_Post",
                principalTable: "Perfil_users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emotions_Perfil_users_Id_Post",
                table: "Emotions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Emotions",
                table: "Emotions");

            migrationBuilder.DropIndex(
                name: "IX_Emotions_Id_Post",
                table: "Emotions");

            migrationBuilder.RenameTable(
                name: "Emotions",
                newName: "Emotion");

            migrationBuilder.AlterColumn<string>(
                name: "Full_Name",
                table: "Perfil_users",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Perfil_users",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id_Post",
                table: "Emotion",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Perfil_UserId",
                table: "Emotion",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emotion",
                table: "Emotion",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Emotion_Perfil_UserId",
                table: "Emotion",
                column: "Perfil_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Emotion_Perfil_users_Perfil_UserId",
                table: "Emotion",
                column: "Perfil_UserId",
                principalTable: "Perfil_users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
