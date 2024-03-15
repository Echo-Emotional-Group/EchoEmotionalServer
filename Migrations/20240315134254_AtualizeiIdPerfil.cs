using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EchoEmotionalServer.Migrations
{
    /// <inheritdoc />
    public partial class AtualizeiIdPerfil : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id_accont_facebook",
                table: "perfil_users",
                newName: "Id_account_facebook");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id_account_facebook",
                table: "perfil_users",
                newName: "Id_accont_facebook");
        }
    }
}
