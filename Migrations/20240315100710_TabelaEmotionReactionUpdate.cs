using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EchoEmotionalServer.Migrations
{
    /// <inheritdoc />
    public partial class TabelaEmotionReactionUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "reactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Tipo = table.Column<string>(type: "text", nullable: true),
                    id_emotion_Reaction = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reactions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "emotion_Reactions",
                columns: table => new
                {
                    Id_account_facebook = table.Column<Guid>(type: "uuid", nullable: false),
                    Emotion_Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Reaction_Id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_emotion_Reactions", x => x.Id_account_facebook);
                    table.ForeignKey(
                        name: "FK_emotion_Reactions_Emotions_Emotion_Id",
                        column: x => x.Emotion_Id,
                        principalTable: "Emotions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_emotion_Reactions_reactions_Reaction_Id",
                        column: x => x.Reaction_Id,
                        principalTable: "reactions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_emotion_Reactions_Emotion_Id",
                table: "emotion_Reactions",
                column: "Emotion_Id");

            migrationBuilder.CreateIndex(
                name: "IX_emotion_Reactions_Reaction_Id",
                table: "emotion_Reactions",
                column: "Reaction_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "emotion_Reactions");

            migrationBuilder.DropTable(
                name: "reactions");
        }
    }
}
