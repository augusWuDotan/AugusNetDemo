using Microsoft.EntityFrameworkCore.Migrations;

namespace AugusTestDemo.Migrations
{
    public partial class addWithBrandStory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BrandStoryID",
                table: "HomePage",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BrandStory",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandStoryImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrandStoryIntroduction = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandStory", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HomePage_BrandStoryID",
                table: "HomePage",
                column: "BrandStoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_HomePage_BrandStory_BrandStoryID",
                table: "HomePage",
                column: "BrandStoryID",
                principalTable: "BrandStory",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HomePage_BrandStory_BrandStoryID",
                table: "HomePage");

            migrationBuilder.DropTable(
                name: "BrandStory");

            migrationBuilder.DropIndex(
                name: "IX_HomePage_BrandStoryID",
                table: "HomePage");

            migrationBuilder.DropColumn(
                name: "BrandStoryID",
                table: "HomePage");
        }
    }
}
