using Microsoft.EntityFrameworkCore.Migrations;

namespace AugusTestDemo.Migrations
{
    public partial class AddDescriptionTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescriptionTest",
                table: "Todo",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescriptionTest",
                table: "Todo");
        }
    }
}
