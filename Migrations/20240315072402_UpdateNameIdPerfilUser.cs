using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EchoEmotionalServer.Migrations
{
    /// <inheritdoc />
    public partial class UpdateNameIdPerfilUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Perfil_users",
                newName: "Id_accont_facebook");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id_accont_facebook",
                table: "Perfil_users",
                newName: "Id");
        }
    }
}
