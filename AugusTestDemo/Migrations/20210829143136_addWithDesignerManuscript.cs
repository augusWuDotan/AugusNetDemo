using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AugusTestDemo.Migrations
{
    public partial class addWithDesignerManuscript : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrandStoryID",
                table: "HomePage");

            migrationBuilder.DropColumn(
                name: "CustomizedServiceID",
                table: "HomePage");

            migrationBuilder.DropColumn(
                name: "LatestEventsID",
                table: "HomePage");

            migrationBuilder.CreateTable(
                name: "DesignerManuscriptMode",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModeMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModeRule = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesignerManuscriptMode", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DesignerManuscript",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignerManuscriptID = table.Column<int>(type: "int", nullable: false),
                    DesignerManuscriptModeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesignerManuscript", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DesignerManuscript_DesignerManuscriptMode_DesignerManuscriptModeID",
                        column: x => x.DesignerManuscriptModeID,
                        principalTable: "DesignerManuscriptMode",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DesignerManuscriptImage",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignerManuscriptIndex = table.Column<int>(type: "int", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DesignerManuscriptModeID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesignerManuscriptImage", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DesignerManuscriptImage_DesignerManuscriptMode_DesignerManuscriptModeID",
                        column: x => x.DesignerManuscriptModeID,
                        principalTable: "DesignerManuscriptMode",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HomePage_DesignerManuscriptID",
                table: "HomePage",
                column: "DesignerManuscriptID");

            migrationBuilder.CreateIndex(
                name: "IX_DesignerManuscript_DesignerManuscriptModeID",
                table: "DesignerManuscript",
                column: "DesignerManuscriptModeID");

            migrationBuilder.CreateIndex(
                name: "IX_DesignerManuscriptImage_DesignerManuscriptModeID",
                table: "DesignerManuscriptImage",
                column: "DesignerManuscriptModeID");

            migrationBuilder.AddForeignKey(
                name: "FK_HomePage_DesignerManuscript_DesignerManuscriptID",
                table: "HomePage",
                column: "DesignerManuscriptID",
                principalTable: "DesignerManuscript",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HomePage_DesignerManuscript_DesignerManuscriptID",
                table: "HomePage");

            migrationBuilder.DropTable(
                name: "DesignerManuscript");

            migrationBuilder.DropTable(
                name: "DesignerManuscriptImage");

            migrationBuilder.DropTable(
                name: "DesignerManuscriptMode");

            migrationBuilder.DropIndex(
                name: "IX_HomePage_DesignerManuscriptID",
                table: "HomePage");

            migrationBuilder.AddColumn<int>(
                name: "BrandStoryID",
                table: "HomePage",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomizedServiceID",
                table: "HomePage",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LatestEventsID",
                table: "HomePage",
                type: "int",
                nullable: true);
        }
    }
}
