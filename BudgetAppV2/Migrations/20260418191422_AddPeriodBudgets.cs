using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BudgetAppV2.Migrations
{
    /// <inheritdoc />
    public partial class AddPeriodBudgets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PeriodBudgets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TotalLimit = table.Column<decimal>(type: "TEXT", nullable: false),
                    PeriodStartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PeriodEndDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeriodBudgets", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PeriodBudgets");
        }
    }
}
