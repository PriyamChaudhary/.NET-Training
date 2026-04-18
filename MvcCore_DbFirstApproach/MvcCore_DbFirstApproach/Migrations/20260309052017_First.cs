using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcCore_DbFirstApproach.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DeptNo = table.Column<int>(type: "int", nullable: false),
                    Dname = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Location = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    No_of_Emp = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Departme__0148CAAED886853E", x => x.DeptNo);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmpNo = table.Column<int>(type: "int", nullable: false),
                    EName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Mgr = table.Column<int>(type: "int", nullable: true),
                    Salary = table.Column<int>(type: "int", nullable: true),
                    DeptNo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Employee__AF2D66D3A6705BB5", x => x.EmpNo);
                    table.ForeignKey(
                        name: "FK__Employee__DeptNo__2B0A656D",
                        column: x => x.DeptNo,
                        principalTable: "Department",
                        principalColumn: "DeptNo");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DeptNo",
                table: "Employee",
                column: "DeptNo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
