using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace campany.Migrations
{
    /// <inheritdoc />
    public partial class v11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Office_office_ID",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "office_ID",
                table: "Employees",
                newName: "off_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_office_ID",
                table: "Employees",
                newName: "IX_Employees_off_ID");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Office_off_ID",
                table: "Employees",
                column: "off_ID",
                principalTable: "Office",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Office_off_ID",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "off_ID",
                table: "Employees",
                newName: "office_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_off_ID",
                table: "Employees",
                newName: "IX_Employees_office_ID");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Office_office_ID",
                table: "Employees",
                column: "office_ID",
                principalTable: "Office",
                principalColumn: "Id");
        }
    }
}
