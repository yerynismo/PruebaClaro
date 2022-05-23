using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Condominiosdotcom.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteID);
                });

            migrationBuilder.CreateTable(
                name: "Residencial",
                columns: table => new
                {
                    ResidencialID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreResidencial = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residencial", x => x.ResidencialID);
                });

            migrationBuilder.CreateTable(
                name: "Condominio",
                columns: table => new
                {
                    CondominioID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCondominio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apart_casa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResidencialID = table.Column<int>(type: "int", nullable: false),
                    ClienteID = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Condominio", x => x.CondominioID);
                    table.ForeignKey(
                        name: "FK_Condominio_Cliente_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Cliente",
                        principalColumn: "ClienteID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Condominio_Residencial_ResidencialID",
                        column: x => x.ResidencialID,
                        principalTable: "Residencial",
                        principalColumn: "ResidencialID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    PagoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteID = table.Column<int>(type: "int", nullable: true),
                    CondominioID = table.Column<int>(type: "int", nullable: true),
                    Pendiente = table.Column<int>(type: "int", nullable: false),
                    Mora = table.Column<int>(type: "int", nullable: false),
                    Monto = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.PagoID);
                    table.ForeignKey(
                        name: "FK_Pagos_Cliente_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Cliente",
                        principalColumn: "ClienteID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pagos_Condominio_CondominioID",
                        column: x => x.CondominioID,
                        principalTable: "Condominio",
                        principalColumn: "CondominioID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cuotas",
                columns: table => new
                {
                    CuotaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Monto = table.Column<int>(type: "int", nullable: false),
                    PagoID = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuotas", x => x.CuotaID);
                    table.ForeignKey(
                        name: "FK_Cuotas_Pagos_PagoID",
                        column: x => x.PagoID,
                        principalTable: "Pagos",
                        principalColumn: "PagoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Condominio_ClienteID",
                table: "Condominio",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Condominio_ResidencialID",
                table: "Condominio",
                column: "ResidencialID");

            migrationBuilder.CreateIndex(
                name: "IX_Cuotas_PagoID",
                table: "Cuotas",
                column: "PagoID");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_ClienteID",
                table: "Pagos",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_CondominioID",
                table: "Pagos",
                column: "CondominioID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cuotas");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "Condominio");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Residencial");
        }
    }
}
