using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace campany.Migrations
{
    /// <inheritdoc />
    public partial class v13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Office_off_ID",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "off_ID",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Office_off_ID",
                table: "Employees",
                column: "off_ID",
                principalTable: "Office",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Office_off_ID",
                table: "Employees");

            migrationBuilder.AlterColumn<int>(
                name: "off_ID",
                table: "Employees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Office_off_ID",
                table: "Employees",
                column: "off_ID",
                principalTable: "Office",
                principalColumn: "Id");
        }
    }
}
