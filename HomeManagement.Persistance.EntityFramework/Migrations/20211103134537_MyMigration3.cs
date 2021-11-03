using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeManagement.Persistance.EntityFramework.Migrations
{
    public partial class MyMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Incomes_HomeMemberId",
                schema: "HomeManagement",
                table: "Incomes",
                column: "HomeMemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Incomes_HomeMembers_HomeMemberId",
                schema: "HomeManagement",
                table: "Incomes",
                column: "HomeMemberId",
                principalSchema: "HomeManagement",
                principalTable: "HomeMembers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incomes_HomeMembers_HomeMemberId",
                schema: "HomeManagement",
                table: "Incomes");

            migrationBuilder.DropIndex(
                name: "IX_Incomes_HomeMemberId",
                schema: "HomeManagement",
                table: "Incomes");
        }
    }
}
