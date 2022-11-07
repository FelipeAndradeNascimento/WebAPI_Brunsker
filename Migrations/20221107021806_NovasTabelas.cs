using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Adm_Imoveis.Migrations
{
    public partial class NovasTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DtCadastro",
                table: "tb_Imovel");

            migrationBuilder.CreateTable(
                name: "tb_Visitas",
                columns: table => new
                {
                    IdVisitas = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    idCliente = table.Column<int>(type: "int", nullable: false),
                    idCorretor = table.Column<int>(type: "int", nullable: false),
                    idImovel = table.Column<int>(type: "int", nullable: false),
                    dtVisita = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Visitas", x => x.IdVisitas);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_Visitas");

            migrationBuilder.AddColumn<DateOnly>(
                name: "DtCadastro",
                table: "tb_Imovel",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));
        }
    }
}
