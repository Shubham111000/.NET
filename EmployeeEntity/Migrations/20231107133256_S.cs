using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeEntity.Migrations
{
    /// <inheritdoc />
    public partial class S : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DepartmentSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentSet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeSet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<float>(type: "real", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeparmentID = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeSet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeSet_DepartmentSet_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "DepartmentSet",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeSet_DepartmentId",
                table: "EmployeeSet",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeSet");

            migrationBuilder.DropTable(
                name: "DepartmentSet");
        }
    }
}
