using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EchoEmotionalServer.Migrations
{
    /// <inheritdoc />
    public partial class ModelagemInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "emotion",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "serial", nullable: false),
                    emotion_desc = table.Column<string>(type: "text", nullable: true),
                    id_post = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_emotion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "reaction",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "serial", nullable: false),
                    type = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reaction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "emotion_reaction",
                columns: table => new
                {
                    emotion_id = table.Column<Guid>(type: "serial", nullable: false),
                    reaction_id = table.Column<Guid>(type: "serial", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_emotion_reaction", x => new { x.emotion_id, x.reaction_id });
                    table.ForeignKey(
                        name: "FK_emotion_reaction_emotion_emotion_id",
                        column: x => x.emotion_id,
                        principalTable: "emotion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_emotion_reaction_reaction_reaction_id",
                        column: x => x.reaction_id,
                        principalTable: "reaction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_emotion_reaction_reaction_id",
                table: "emotion_reaction",
                column: "reaction_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "emotion_reaction");

            migrationBuilder.DropTable(
                name: "emotion");

            migrationBuilder.DropTable(
                name: "reaction");
        }
    }
}
