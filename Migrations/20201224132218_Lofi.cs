using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace norcam.Migrations
{
    public partial class Lofi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(nullable: true),
                    apellido = table.Column<string>(nullable: true),
                    puesto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    razon_social = table.Column<string>(nullable: false),
                    ruc = table.Column<string>(nullable: false),
                    direccion = table.Column<string>(nullable: false),
                    telefono = table.Column<string>(nullable: false),
                    fax = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Factura",
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
                    table.PrimaryKey("PK_Factura", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Orden",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fec_rec = table.Column<string>(nullable: true),
                    cod_clienteid = table.Column<int>(nullable: true),
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
                    table.PrimaryKey("PK_Orden", x => x.id);
                    table.ForeignKey(
                        name: "FK_Orden_Cliente_cod_clienteid",
                        column: x => x.cod_clienteid,
                        principalTable: "Cliente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orden_cod_clienteid",
                table: "Orden",
                column: "cod_clienteid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Factura");

            migrationBuilder.DropTable(
                name: "Orden");

            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}
