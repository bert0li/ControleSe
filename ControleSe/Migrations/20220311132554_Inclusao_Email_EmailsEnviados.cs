using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleSe.Migrations
{
    public partial class Inclusao_Email_EmailsEnviados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Email",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Smpt = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Porta = table.Column<int>(type: "int", nullable: false),
                    Ssl = table.Column<bool>(type: "bit", nullable: false),
                    EnderecoEmail = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SenhaEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Email", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Email_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmailsEnviados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    Cc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    EmailDestinatario = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Assunto = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Mensagem = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    DataEnvio = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailsEnviados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailsEnviados_Email_EmailId",
                        column: x => x.EmailId,
                        principalTable: "Email",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmailsEnviados_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Email_UsuarioId",
                table: "Email",
                column: "UsuarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmailsEnviados_EmailId",
                table: "EmailsEnviados",
                column: "EmailId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailsEnviados_UsuarioId",
                table: "EmailsEnviados",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailsEnviados");

            migrationBuilder.DropTable(
                name: "Email");
        }
    }
}
