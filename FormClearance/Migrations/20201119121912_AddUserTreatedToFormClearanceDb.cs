using Microsoft.EntityFrameworkCore.Migrations;

namespace FormClearance.Migrations
{
    public partial class AddUserTreatedToFormClearanceDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NetworkEngineer",
                table: "formClearances",
                newName: "UserTreated");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserTreated",
                table: "formClearances",
                newName: "NetworkEngineer");
        }
    }
}
