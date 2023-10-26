using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mecanica_MVC.Migrations
{
    public partial class nova_Tabela_ServicosMecanica : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "dataAdmissao",
                table: "Funcionario",
                newName: "DataAdmissao");

            migrationBuilder.CreateTable(
                name: "ServicosMecanicas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Valor = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicosMecanicas", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServicosMecanicas");

            migrationBuilder.RenameColumn(
                name: "DataAdmissao",
                table: "Funcionario",
                newName: "dataAdmissao");
        }
    }
}
