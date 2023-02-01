using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaWebEmpleado.Migrations
{
    public partial class arregloTabla : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Título",
                table: "Empleados",
                newName: "Titulo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Titulo",
                table: "Empleados",
                newName: "Título");
        }
    }
}
