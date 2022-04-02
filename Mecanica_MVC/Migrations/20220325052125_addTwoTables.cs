using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mecanica_MVC.Migrations
{
    public partial class addTwoTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Matricula = table.Column<int>(type: "int", nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dataAdmissao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Servico",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Preco = table.Column<double>(type: "float", nullable: false),
                    FuncionarioServico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarroServico = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servico", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropTable(
                name: "Servico");
        }
    }
}
