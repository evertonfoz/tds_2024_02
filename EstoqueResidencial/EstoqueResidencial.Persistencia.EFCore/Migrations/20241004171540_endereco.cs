using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstoqueResidencial.Persistencia.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class endereco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Fornecedores",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Fornecedores");
        }
    }
}
