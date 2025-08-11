using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuestAnswerApi.Migrations
{
    /// <inheritdoc />
    public partial class CategoryCollumInCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Cards",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Cards");
        }
    }
}
