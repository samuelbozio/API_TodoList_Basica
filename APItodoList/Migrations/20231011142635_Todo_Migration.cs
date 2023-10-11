using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APItodoList.Migrations
{
    /// <inheritdoc />
    public partial class Todo_Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "itensLista",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeTarefa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescricaoTarefa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_itensLista", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "itensLista");
        }
    }
}
