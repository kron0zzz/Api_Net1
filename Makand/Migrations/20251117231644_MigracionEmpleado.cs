using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Makand.Migrations
{
    /// <inheritdoc />
    public partial class MigracionEmpleado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    Nro_documento = table.Column<int>(type: "int", nullable: false),
                    Tipo_documento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre_completo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.Nro_documento);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empleados");
        }
    }
}
