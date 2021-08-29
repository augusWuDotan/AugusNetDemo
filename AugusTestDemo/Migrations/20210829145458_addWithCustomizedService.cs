using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AugusTestDemo.Migrations
{
    public partial class addWithCustomizedService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DesignerManuscript_DesignerManuscriptMode_DesignerManuscriptModeID",
                table: "DesignerManuscript");

            migrationBuilder.DropColumn(
                name: "DesignerManuscriptID",
                table: "DesignerManuscript");

            migrationBuilder.AddColumn<int>(
                name: "CustomizedServiceID",
                table: "HomePage",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DesignerManuscriptModeID",
                table: "DesignerManuscript",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "CustomizedServiceMode",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModeMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModeRule = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomizedServiceMode", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CustomizedService",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomizedServiceModeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomizedService", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CustomizedService_CustomizedServiceMode_CustomizedServiceModeID",
                        column: x => x.CustomizedServiceModeID,
                        principalTable: "CustomizedServiceMode",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomizedServiceImage",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomizedServiceIndex = table.Column<int>(type: "int", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomizedServiceModeID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomizedServiceImage", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CustomizedServiceImage_CustomizedServiceMode_CustomizedServiceModeID",
                        column: x => x.CustomizedServiceModeID,
                        principalTable: "CustomizedServiceMode",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HomePage_CustomizedServiceID",
                table: "HomePage",
                column: "CustomizedServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomizedService_CustomizedServiceModeID",
                table: "CustomizedService",
                column: "CustomizedServiceModeID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomizedServiceImage_CustomizedServiceModeID",
                table: "CustomizedServiceImage",
                column: "CustomizedServiceModeID");

            migrationBuilder.AddForeignKey(
                name: "FK_DesignerManuscript_DesignerManuscriptMode_DesignerManuscriptModeID",
                table: "DesignerManuscript",
                column: "DesignerManuscriptModeID",
                principalTable: "DesignerManuscriptMode",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HomePage_CustomizedService_CustomizedServiceID",
                table: "HomePage",
                column: "CustomizedServiceID",
                principalTable: "CustomizedService",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DesignerManuscript_DesignerManuscriptMode_DesignerManuscriptModeID",
                table: "DesignerManuscript");

            migrationBuilder.DropForeignKey(
                name: "FK_HomePage_CustomizedService_CustomizedServiceID",
                table: "HomePage");

            migrationBuilder.DropTable(
                name: "CustomizedService");

            migrationBuilder.DropTable(
                name: "CustomizedServiceImage");

            migrationBuilder.DropTable(
                name: "CustomizedServiceMode");

            migrationBuilder.DropIndex(
                name: "IX_HomePage_CustomizedServiceID",
                table: "HomePage");

            migrationBuilder.DropColumn(
                name: "CustomizedServiceID",
                table: "HomePage");

            migrationBuilder.AlterColumn<int>(
                name: "DesignerManuscriptModeID",
                table: "DesignerManuscript",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DesignerManuscriptID",
                table: "DesignerManuscript",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_DesignerManuscript_DesignerManuscriptMode_DesignerManuscriptModeID",
                table: "DesignerManuscript",
                column: "DesignerManuscriptModeID",
                principalTable: "DesignerManuscriptMode",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
