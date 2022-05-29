using Microsoft.EntityFrameworkCore.Migrations;

namespace Condominiosdotcom.Api.Migrations
{
    public partial class adding_conceptoTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cuotas_Pagos_PagoID",
                table: "Cuotas");

            migrationBuilder.DropIndex(
                name: "IX_Cuotas_PagoID",
                table: "Cuotas");

            migrationBuilder.DropColumn(
                name: "Apart_casa",
                table: "Condominio");

            migrationBuilder.RenameColumn(
                name: "PagoID",
                table: "Cuotas",
                newName: "Pendiente");

            migrationBuilder.RenameColumn(
                name: "NombreCondominio",
                table: "Condominio",
                newName: "Vivienda");

            migrationBuilder.AddColumn<int>(
                name: "ClienteID",
                table: "Cuotas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ConceptoID",
                table: "Cuotas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mora",
                table: "Cuotas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Cedula",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Concepto",
                columns: table => new
                {
                    ConceptoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Elconcepto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Recurrencia = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concepto", x => x.ConceptoID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cuotas_ClienteID",
                table: "Cuotas",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Cuotas_ConceptoID",
                table: "Cuotas",
                column: "ConceptoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cuotas_Cliente_ClienteID",
                table: "Cuotas",
                column: "ClienteID",
                principalTable: "Cliente",
                principalColumn: "ClienteID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cuotas_Concepto_ConceptoID",
                table: "Cuotas",
                column: "ConceptoID",
                principalTable: "Concepto",
                principalColumn: "ConceptoID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cuotas_Cliente_ClienteID",
                table: "Cuotas");

            migrationBuilder.DropForeignKey(
                name: "FK_Cuotas_Concepto_ConceptoID",
                table: "Cuotas");

            migrationBuilder.DropTable(
                name: "Concepto");

            migrationBuilder.DropIndex(
                name: "IX_Cuotas_ClienteID",
                table: "Cuotas");

            migrationBuilder.DropIndex(
                name: "IX_Cuotas_ConceptoID",
                table: "Cuotas");

            migrationBuilder.DropColumn(
                name: "ClienteID",
                table: "Cuotas");

            migrationBuilder.DropColumn(
                name: "ConceptoID",
                table: "Cuotas");

            migrationBuilder.DropColumn(
                name: "Mora",
                table: "Cuotas");

            migrationBuilder.DropColumn(
                name: "Cedula",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "Cliente");

            migrationBuilder.RenameColumn(
                name: "Pendiente",
                table: "Cuotas",
                newName: "PagoID");

            migrationBuilder.RenameColumn(
                name: "Vivienda",
                table: "Condominio",
                newName: "NombreCondominio");

            migrationBuilder.AddColumn<string>(
                name: "Apart_casa",
                table: "Condominio",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cuotas_PagoID",
                table: "Cuotas",
                column: "PagoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cuotas_Pagos_PagoID",
                table: "Cuotas",
                column: "PagoID",
                principalTable: "Pagos",
                principalColumn: "PagoID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
