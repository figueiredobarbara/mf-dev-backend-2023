using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mf_dev_backend_2023.Migrations
{
    /// <inheritdoc />
    public partial class M03AddTableUsuarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "km",
                table: "Consumos",
                newName: "Km");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Consumos",
                newName: "Id");

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Perfil = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "Km",
                table: "Consumos",
                newName: "km");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Consumos",
                newName: "Id");
        }
    }
}
