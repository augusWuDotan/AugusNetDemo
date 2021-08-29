using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AugusTestDemo.Migrations
{
    public partial class addWithLatestEvents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LatestEventsID",
                table: "HomePage",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LatestEventsMode",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModeMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModeRule = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LatestEventsMode", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LatestEvents",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LatestEventsModeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LatestEvents", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LatestEvents_LatestEventsMode_LatestEventsModeID",
                        column: x => x.LatestEventsModeID,
                        principalTable: "LatestEventsMode",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LatestEventsImage",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LatestEventsModeID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LatestEventsImage", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LatestEventsImage_LatestEventsMode_LatestEventsModeID",
                        column: x => x.LatestEventsModeID,
                        principalTable: "LatestEventsMode",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HomePage_LatestEventsID",
                table: "HomePage",
                column: "LatestEventsID");

            migrationBuilder.CreateIndex(
                name: "IX_LatestEvents_LatestEventsModeID",
                table: "LatestEvents",
                column: "LatestEventsModeID");

            migrationBuilder.CreateIndex(
                name: "IX_LatestEventsImage_LatestEventsModeID",
                table: "LatestEventsImage",
                column: "LatestEventsModeID");

            migrationBuilder.AddForeignKey(
                name: "FK_HomePage_LatestEvents_LatestEventsID",
                table: "HomePage",
                column: "LatestEventsID",
                principalTable: "LatestEvents",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HomePage_LatestEvents_LatestEventsID",
                table: "HomePage");

            migrationBuilder.DropTable(
                name: "LatestEvents");

            migrationBuilder.DropTable(
                name: "LatestEventsImage");

            migrationBuilder.DropTable(
                name: "LatestEventsMode");

            migrationBuilder.DropIndex(
                name: "IX_HomePage_LatestEventsID",
                table: "HomePage");

            migrationBuilder.DropColumn(
                name: "LatestEventsID",
                table: "HomePage");
        }
    }
}
