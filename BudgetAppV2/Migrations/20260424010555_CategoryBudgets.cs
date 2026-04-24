using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BudgetAppV2.Migrations
{
    /// <inheritdoc />
    public partial class CategoryBudgets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryBudgets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PeriodBudgetId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Limit = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryBudgets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryBudgets_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CategoryBudgets_PeriodBudgets_PeriodBudgetId",
                        column: x => x.PeriodBudgetId,
                        principalTable: "PeriodBudgets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryBudgets_CategoryId_PeriodBudgetId",
                table: "CategoryBudgets",
                columns: new[] { "CategoryId", "PeriodBudgetId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CategoryBudgets_PeriodBudgetId",
                table: "CategoryBudgets",
                column: "PeriodBudgetId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryBudgets");
        }
    }
}
