using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AugusTestDemo.Migrations
{
    public partial class addddWithColorOfTheSeason : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ColorOfTheSeasonMode",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModeMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModeRule = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorOfTheSeasonMode", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ColorOfTheSeason",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorOfTheSeasonModeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorOfTheSeason", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ColorOfTheSeason_ColorOfTheSeasonMode_ColorOfTheSeasonModeID",
                        column: x => x.ColorOfTheSeasonModeID,
                        principalTable: "ColorOfTheSeasonMode",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ColorOfTheSeasonImage",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorOfTheSeasonIndex = table.Column<int>(type: "int", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorOfTheSeasonModeID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorOfTheSeasonImage", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ColorOfTheSeasonImage_ColorOfTheSeasonMode_ColorOfTheSeasonModeID",
                        column: x => x.ColorOfTheSeasonModeID,
                        principalTable: "ColorOfTheSeasonMode",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HomePage",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorOfTheSeasonID = table.Column<int>(type: "int", nullable: true),
                    DesignerManuscriptID = table.Column<int>(type: "int", nullable: true),
                    CustomizedServiceID = table.Column<int>(type: "int", nullable: true),
                    LatestEventsID = table.Column<int>(type: "int", nullable: true),
                    BrandStoryID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePage", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HomePage_ColorOfTheSeason_ColorOfTheSeasonID",
                        column: x => x.ColorOfTheSeasonID,
                        principalTable: "ColorOfTheSeason",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ColorOfTheSeason_ColorOfTheSeasonModeID",
                table: "ColorOfTheSeason",
                column: "ColorOfTheSeasonModeID");

            migrationBuilder.CreateIndex(
                name: "IX_ColorOfTheSeasonImage_ColorOfTheSeasonModeID",
                table: "ColorOfTheSeasonImage",
                column: "ColorOfTheSeasonModeID");

            migrationBuilder.CreateIndex(
                name: "IX_HomePage_ColorOfTheSeasonID",
                table: "HomePage",
                column: "ColorOfTheSeasonID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ColorOfTheSeasonImage");

            migrationBuilder.DropTable(
                name: "HomePage");

            migrationBuilder.DropTable(
                name: "ColorOfTheSeason");

            migrationBuilder.DropTable(
                name: "ColorOfTheSeasonMode");
        }
    }
}
