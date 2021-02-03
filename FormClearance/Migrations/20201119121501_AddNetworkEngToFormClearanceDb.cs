using Microsoft.EntityFrameworkCore.Migrations;

namespace FormClearance.Migrations
{
    public partial class AddNetworkEngToFormClearanceDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NetworkEngineer",
                table: "formClearances",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NetworkEngineer",
                table: "formClearances");
        }
    }
}
