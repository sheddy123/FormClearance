using Microsoft.EntityFrameworkCore.Migrations;

namespace FormClearance.Migrations
{
    public partial class AddUserRoleToFormClearanceDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserRole",
                table: "formClearances",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserRole",
                table: "formClearances");
        }
    }
}
