using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleSe.Migrations
{
    public partial class MySqlMariaDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuarioAcesso = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SenhaAcesso = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ativo = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cofre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TotalCobre = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Divida",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "varchar(400)", maxLength: 400, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Valor = table.Column<decimal>(type: "decimal(65,30)", nullable: false, defaultValue: 0m),
                    TipoDivida = table.Column<int>(type: "int", nullable: false),
                    DataVencimento = table.Column<DateTime>(type: "date", nullable: false),
                    DataPagamento = table.Column<DateTime>(type: "date", nullable: true),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    Pago = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divida", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Divida_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Entrada",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ValorEntrada = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    DataEntrada = table.Column<DateTime>(type: "date", nullable: false),
                    Observacao = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
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
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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
                name: "Entrada");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
