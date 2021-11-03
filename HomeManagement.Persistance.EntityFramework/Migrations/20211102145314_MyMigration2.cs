using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeManagement.Persistance.EntityFramework.Migrations
{
    public partial class MyMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HomeMemberId",
                schema: "HomeManagement",
                table: "Incomes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HomeMemberId",
                schema: "HomeManagement",
                table: "Incomes");
        }
    }
}
