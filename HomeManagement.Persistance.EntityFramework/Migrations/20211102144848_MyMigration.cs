using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeManagement.Persistance.EntityFramework.Migrations
{
    public partial class MyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "HomeManagement");

            migrationBuilder.CreateTable(
                name: "HomeMembers",
                schema: "HomeManagement",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    Surname = table.Column<string>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Type = table.Column<string>(nullable: false),
                    Profession = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeMembers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Incomes",
                schema: "HomeManagement",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncomeDate = table.Column<DateTime>(nullable: false),
                    IncomeAmount = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incomes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HomeMembers",
                schema: "HomeManagement");

            migrationBuilder.DropTable(
                name: "Incomes",
                schema: "HomeManagement");
        }
    }
}
