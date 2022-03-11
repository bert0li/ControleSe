using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleSe.Migrations
{
    public partial class ExclusaoEmailsEnviados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailsEnviados");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmailsEnviados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Assunto = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Cc = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DataEnvio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmailDestinatario = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EmailId = table.Column<int>(type: "int", nullable: false),
                    Mensagem = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
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
                name: "IX_EmailsEnviados_EmailId",
                table: "EmailsEnviados",
                column: "EmailId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailsEnviados_UsuarioId",
                table: "EmailsEnviados",
                column: "UsuarioId");
        }
    }
}
