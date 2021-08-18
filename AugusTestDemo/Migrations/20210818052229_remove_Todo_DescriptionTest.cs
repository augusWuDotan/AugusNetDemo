using Microsoft.EntityFrameworkCore.Migrations;

namespace AugusTestDemo.Migrations
{
    public partial class remove_Todo_DescriptionTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescriptionTest",
                table: "Todo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescriptionTest",
                table: "Todo",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
