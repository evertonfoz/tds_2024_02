using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstoqueResidencial.Persistencia.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class UnidadesMedida : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UnidadesMedida",
                columns: table => new
                {
                    UnidadeMedidaID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Sigla = table.Column<string>(type: "TEXT", nullable: true),
                    Quantidade = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadesMedida", x => x.UnidadeMedidaID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UnidadesMedida");
        }
    }
}
