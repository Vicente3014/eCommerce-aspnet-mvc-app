using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ePerfumes.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    Marca_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marca_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marca_Pic_URL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.Marca_ID);
                });

            migrationBuilder.CreateTable(
                name: "Perfumes",
                columns: table => new
                {
                    Perfume_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Perfume_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Perfume_Pic_URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tamanho = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    PerfumeType = table.Column<int>(type: "int", nullable: false),
                    Marca_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfumes", x => x.Perfume_ID);
                    table.ForeignKey(
                        name: "FK_Perfumes_Marcas_Marca_ID",
                        column: x => x.Marca_ID,
                        principalTable: "Marcas",
                        principalColumn: "Marca_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Perfumes_Marca_ID",
                table: "Perfumes",
                column: "Marca_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Perfumes");

            migrationBuilder.DropTable(
                name: "Marcas");
        }
    }
}
