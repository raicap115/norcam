using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace norcam.Migrations
{
    public partial class Models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    razon_social = table.Column<string>(nullable: true),
                    ruc = table.Column<string>(nullable: true),
                    direccion = table.Column<string>(nullable: true),
                    telefono = table.Column<string>(nullable: true),
                    fax = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    archivo = table.Column<string>(nullable: true),
                    factura = table.Column<string>(nullable: true),
                    fec_fac = table.Column<string>(nullable: true),
                    fec_canc = table.Column<string>(nullable: true),
                    dua = table.Column<string>(nullable: true),
                    cif = table.Column<double>(nullable: false),
                    tc = table.Column<double>(nullable: false),
                    adval = table.Column<double>(nullable: false),
                    igv = table.Column<double>(nullable: false),
                    ipm = table.Column<double>(nullable: false),
                    reintegro = table.Column<double>(nullable: false),
                    total_liq = table.Column<double>(nullable: false),
                    gasto_ope = table.Column<double>(nullable: false),
                    gasto_admin = table.Column<double>(nullable: false),
                    sup_cont = table.Column<double>(nullable: false),
                    comision = table.Column<double>(nullable: false),
                    igv_2 = table.Column<double>(nullable: false),
                    total_neto = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Ordenes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fec_rec = table.Column<string>(nullable: true),
                    id_clienteid = table.Column<int>(nullable: true),
                    proveedor = table.Column<string>(nullable: true),
                    contenido = table.Column<string>(nullable: true),
                    peso = table.Column<string>(nullable: true),
                    ubicacion = table.Column<string>(nullable: true),
                    regimen = table.Column<string>(nullable: true),
                    fec_num = table.Column<string>(nullable: true),
                    fec_entrega = table.Column<string>(nullable: true),
                    valor_num = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordenes", x => x.id);
                    table.ForeignKey(
                        name: "FK_Ordenes_Clientes_id_clienteid",
                        column: x => x.id_clienteid,
                        principalTable: "Clientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ordenes_id_clienteid",
                table: "Ordenes",
                column: "id_clienteid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropTable(
                name: "Ordenes");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
