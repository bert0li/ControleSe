using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleSe.Migrations
{
    public partial class DividaNovaColunaPago : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TipoDivida",
                table: "Divida",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Pago",
                table: "Divida",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pago",
                table: "Divida");

            migrationBuilder.AlterColumn<int>(
                name: "TipoDivida",
                table: "Divida",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
