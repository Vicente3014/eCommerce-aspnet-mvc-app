using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ePerfumes.Migrations
{
    /// <inheritdoc />
    public partial class PerfumeCreaion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Perfumes_Marcas_Marca_ID",
                table: "Perfumes");

            migrationBuilder.AlterColumn<string>(
                name: "Perfume_Name",
                table: "Perfumes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Marca_ID",
                table: "Perfumes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Marca_Name",
                table: "Marcas",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Perfume_ID",
                table: "Marcas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Marcas_Perfume_ID",
                table: "Marcas",
                column: "Perfume_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Marcas_Perfumes_Perfume_ID",
                table: "Marcas",
                column: "Perfume_ID",
                principalTable: "Perfumes",
                principalColumn: "Perfume_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Perfumes_Marcas_Marca_ID",
                table: "Perfumes",
                column: "Marca_ID",
                principalTable: "Marcas",
                principalColumn: "Marca_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Marcas_Perfumes_Perfume_ID",
                table: "Marcas");

            migrationBuilder.DropForeignKey(
                name: "FK_Perfumes_Marcas_Marca_ID",
                table: "Perfumes");

            migrationBuilder.DropIndex(
                name: "IX_Marcas_Perfume_ID",
                table: "Marcas");

            migrationBuilder.DropColumn(
                name: "Perfume_ID",
                table: "Marcas");

            migrationBuilder.AlterColumn<string>(
                name: "Perfume_Name",
                table: "Perfumes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "Marca_ID",
                table: "Perfumes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Marca_Name",
                table: "Marcas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AddForeignKey(
                name: "FK_Perfumes_Marcas_Marca_ID",
                table: "Perfumes",
                column: "Marca_ID",
                principalTable: "Marcas",
                principalColumn: "Marca_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
