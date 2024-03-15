using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EchoEmotionalServer.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Perfil_users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Full_Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Data_Post = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Data_Nasc = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Data_Registro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfil_users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Emotion",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Emotion_Desc = table.Column<string>(type: "text", nullable: true),
                    Id_Post = table.Column<Guid>(type: "uuid", nullable: false),
                    Perfil_UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emotion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emotion_Perfil_users_Perfil_UserId",
                        column: x => x.Perfil_UserId,
                        principalTable: "Perfil_users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Emotion_Perfil_UserId",
                table: "Emotion",
                column: "Perfil_UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emotion");

            migrationBuilder.DropTable(
                name: "Perfil_users");
        }
    }
}
