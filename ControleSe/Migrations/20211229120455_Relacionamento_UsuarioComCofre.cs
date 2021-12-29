using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleSe.Migrations
{
    public partial class Relacionamento_UsuarioComCofre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Cofre",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cofre_UsuarioId",
                table: "Cofre",
                column: "UsuarioId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cofre_Usuario_UsuarioId",
                table: "Cofre",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cofre_Usuario_UsuarioId",
                table: "Cofre");

            migrationBuilder.DropIndex(
                name: "IX_Cofre_UsuarioId",
                table: "Cofre");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Cofre");
        }
    }
}
