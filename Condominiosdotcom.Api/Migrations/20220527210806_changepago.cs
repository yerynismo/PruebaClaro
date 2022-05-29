using Microsoft.EntityFrameworkCore.Migrations;

namespace Condominiosdotcom.Api.Migrations
{
    public partial class changepago : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Condominio_CondominioID",
                table: "Pagos");

            migrationBuilder.RenameColumn(
                name: "CondominioID",
                table: "Pagos",
                newName: "ConceptoID");

            migrationBuilder.RenameIndex(
                name: "IX_Pagos_CondominioID",
                table: "Pagos",
                newName: "IX_Pagos_ConceptoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Concepto_ConceptoID",
                table: "Pagos",
                column: "ConceptoID",
                principalTable: "Concepto",
                principalColumn: "ConceptoID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Concepto_ConceptoID",
                table: "Pagos");

            migrationBuilder.RenameColumn(
                name: "ConceptoID",
                table: "Pagos",
                newName: "CondominioID");

            migrationBuilder.RenameIndex(
                name: "IX_Pagos_ConceptoID",
                table: "Pagos",
                newName: "IX_Pagos_CondominioID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Condominio_CondominioID",
                table: "Pagos",
                column: "CondominioID",
                principalTable: "Condominio",
                principalColumn: "CondominioID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
