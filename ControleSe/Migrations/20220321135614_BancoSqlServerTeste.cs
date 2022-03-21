using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleSe.Migrations
{
    public partial class BancoSqlServerTeste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UsuarioAcesso = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SenhaAcesso = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    EhAdm = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cofre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalCobre = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cofre", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cofre_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Divida",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    TipoDivida = table.Column<int>(type: "int", nullable: false),
                    DataVencimento = table.Column<DateTime>(type: "date", nullable: false),
                    DataPagamento = table.Column<DateTime>(type: "date", nullable: true),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    Pago = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divida", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Divida_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Email",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Smtp = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
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
                name: "Entrada",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValorEntrada = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    DataEntrada = table.Column<DateTime>(type: "date", nullable: false),
                    Observacao = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrada", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entrada_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cofre_UsuarioId",
                table: "Cofre",
                column: "UsuarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "index_nome_divida",
                table: "Divida",
                column: "Nome");

            migrationBuilder.CreateIndex(
                name: "IX_Divida_UsuarioId",
                table: "Divida",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Email_UsuarioId",
                table: "Email",
                column: "UsuarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "index_dataEntrada_entrada",
                table: "Entrada",
                column: "DataEntrada");

            migrationBuilder.CreateIndex(
                name: "IX_Entrada_UsuarioId",
                table: "Entrada",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "index_nome_usuario",
                table: "Usuario",
                column: "Nome");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cofre");

            migrationBuilder.DropTable(
                name: "Divida");

            migrationBuilder.DropTable(
                name: "Email");

            migrationBuilder.DropTable(
                name: "Entrada");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
