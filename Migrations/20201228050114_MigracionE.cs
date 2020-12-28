using Microsoft.EntityFrameworkCore.Migrations;

namespace norcam.Migrations
{
    public partial class MigracionE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "valor_num",
                table: "Orden");

            migrationBuilder.DropColumn(
                name: "cif",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "dua",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "factura",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "igv",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "igv_2",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "tc",
                table: "Factura");

            migrationBuilder.AlterColumn<double>(
                name: "peso",
                table: "Orden",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "cif",
                table: "Orden",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "dua",
                table: "Orden",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "razon_socialid",
                table: "Orden",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "tc",
                table: "Orden",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "cifid",
                table: "Factura",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "cod_clienteid",
                table: "Factura",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "cod_ordenid",
                table: "Factura",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "duaid",
                table: "Factura",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "igv_adu",
                table: "Factura",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "igv_fact",
                table: "Factura",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "tcid",
                table: "Factura",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(128)",
                oldMaxLength: 128);

            migrationBuilder.CreateIndex(
                name: "IX_Orden_razon_socialid",
                table: "Orden",
                column: "razon_socialid");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_cifid",
                table: "Factura",
                column: "cifid");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_cod_clienteid",
                table: "Factura",
                column: "cod_clienteid");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_cod_ordenid",
                table: "Factura",
                column: "cod_ordenid");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_duaid",
                table: "Factura",
                column: "duaid");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_tcid",
                table: "Factura",
                column: "tcid");

            migrationBuilder.AddForeignKey(
                name: "FK_Factura_Orden_cifid",
                table: "Factura",
                column: "cifid",
                principalTable: "Orden",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Factura_Cliente_cod_clienteid",
                table: "Factura",
                column: "cod_clienteid",
                principalTable: "Cliente",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Factura_Orden_cod_ordenid",
                table: "Factura",
                column: "cod_ordenid",
                principalTable: "Orden",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Factura_Orden_duaid",
                table: "Factura",
                column: "duaid",
                principalTable: "Orden",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Factura_Orden_tcid",
                table: "Factura",
                column: "tcid",
                principalTable: "Orden",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orden_Cliente_razon_socialid",
                table: "Orden",
                column: "razon_socialid",
                principalTable: "Cliente",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Factura_Orden_cifid",
                table: "Factura");

            migrationBuilder.DropForeignKey(
                name: "FK_Factura_Cliente_cod_clienteid",
                table: "Factura");

            migrationBuilder.DropForeignKey(
                name: "FK_Factura_Orden_cod_ordenid",
                table: "Factura");

            migrationBuilder.DropForeignKey(
                name: "FK_Factura_Orden_duaid",
                table: "Factura");

            migrationBuilder.DropForeignKey(
                name: "FK_Factura_Orden_tcid",
                table: "Factura");

            migrationBuilder.DropForeignKey(
                name: "FK_Orden_Cliente_razon_socialid",
                table: "Orden");

            migrationBuilder.DropIndex(
                name: "IX_Orden_razon_socialid",
                table: "Orden");

            migrationBuilder.DropIndex(
                name: "IX_Factura_cifid",
                table: "Factura");

            migrationBuilder.DropIndex(
                name: "IX_Factura_cod_clienteid",
                table: "Factura");

            migrationBuilder.DropIndex(
                name: "IX_Factura_cod_ordenid",
                table: "Factura");

            migrationBuilder.DropIndex(
                name: "IX_Factura_duaid",
                table: "Factura");

            migrationBuilder.DropIndex(
                name: "IX_Factura_tcid",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "cif",
                table: "Orden");

            migrationBuilder.DropColumn(
                name: "dua",
                table: "Orden");

            migrationBuilder.DropColumn(
                name: "razon_socialid",
                table: "Orden");

            migrationBuilder.DropColumn(
                name: "tc",
                table: "Orden");

            migrationBuilder.DropColumn(
                name: "cifid",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "cod_clienteid",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "cod_ordenid",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "duaid",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "igv_adu",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "igv_fact",
                table: "Factura");

            migrationBuilder.DropColumn(
                name: "tcid",
                table: "Factura");

            migrationBuilder.AlterColumn<string>(
                name: "peso",
                table: "Orden",
                type: "text",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AddColumn<double>(
                name: "valor_num",
                table: "Orden",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "cif",
                table: "Factura",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "dua",
                table: "Factura",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "factura",
                table: "Factura",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "igv",
                table: "Factura",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "igv_2",
                table: "Factura",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "tc",
                table: "Factura",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
