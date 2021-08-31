using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AugusTestDemo.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "ProductType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isShowProductInfo = table.Column<bool>(type: "bit", nullable: false),
                    isConnectStore = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Todo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todo", x => x.ID);
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

            migrationBuilder.CreateTable(
                name: "DesignerManuscript",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DesignerManuscriptModeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesignerManuscript", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DesignerManuscript_DesignerManuscriptMode_DesignerManuscriptModeID",
                        column: x => x.DesignerManuscriptModeID,
                        principalTable: "DesignerManuscriptMode",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductRule = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductTypeID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Product_ProductType_ProductTypeID",
                        column: x => x.ProductTypeID,
                        principalTable: "ProductType",
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
                        name: "FK_HomePage_BrandStory_BrandStoryID",
                        column: x => x.BrandStoryID,
                        principalTable: "BrandStory",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HomePage_ColorOfTheSeason_ColorOfTheSeasonID",
                        column: x => x.ColorOfTheSeasonID,
                        principalTable: "ColorOfTheSeason",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HomePage_CustomizedService_CustomizedServiceID",
                        column: x => x.CustomizedServiceID,
                        principalTable: "CustomizedService",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HomePage_DesignerManuscript_DesignerManuscriptID",
                        column: x => x.DesignerManuscriptID,
                        principalTable: "DesignerManuscript",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HomePage_LatestEvents_LatestEventsID",
                        column: x => x.LatestEventsID,
                        principalTable: "LatestEvents",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FeatherImage",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatherImage", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FeatherImage_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_CustomizedService_CustomizedServiceModeID",
                table: "CustomizedService",
                column: "CustomizedServiceModeID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomizedServiceImage_CustomizedServiceModeID",
                table: "CustomizedServiceImage",
                column: "CustomizedServiceModeID");

            migrationBuilder.CreateIndex(
                name: "IX_DesignerManuscript_DesignerManuscriptModeID",
                table: "DesignerManuscript",
                column: "DesignerManuscriptModeID");

            migrationBuilder.CreateIndex(
                name: "IX_DesignerManuscriptImage_DesignerManuscriptModeID",
                table: "DesignerManuscriptImage",
                column: "DesignerManuscriptModeID");

            migrationBuilder.CreateIndex(
                name: "IX_FeatherImage_ProductID",
                table: "FeatherImage",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_HomePage_BrandStoryID",
                table: "HomePage",
                column: "BrandStoryID");

            migrationBuilder.CreateIndex(
                name: "IX_HomePage_ColorOfTheSeasonID",
                table: "HomePage",
                column: "ColorOfTheSeasonID");

            migrationBuilder.CreateIndex(
                name: "IX_HomePage_CustomizedServiceID",
                table: "HomePage",
                column: "CustomizedServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_HomePage_DesignerManuscriptID",
                table: "HomePage",
                column: "DesignerManuscriptID");

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

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductTypeID",
                table: "Product",
                column: "ProductTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ColorOfTheSeasonImage");

            migrationBuilder.DropTable(
                name: "CustomizedServiceImage");

            migrationBuilder.DropTable(
                name: "DesignerManuscriptImage");

            migrationBuilder.DropTable(
                name: "FeatherImage");

            migrationBuilder.DropTable(
                name: "HomePage");

            migrationBuilder.DropTable(
                name: "LatestEventsImage");

            migrationBuilder.DropTable(
                name: "Todo");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "BrandStory");

            migrationBuilder.DropTable(
                name: "ColorOfTheSeason");

            migrationBuilder.DropTable(
                name: "CustomizedService");

            migrationBuilder.DropTable(
                name: "DesignerManuscript");

            migrationBuilder.DropTable(
                name: "LatestEvents");

            migrationBuilder.DropTable(
                name: "ProductType");

            migrationBuilder.DropTable(
                name: "ColorOfTheSeasonMode");

            migrationBuilder.DropTable(
                name: "CustomizedServiceMode");

            migrationBuilder.DropTable(
                name: "DesignerManuscriptMode");

            migrationBuilder.DropTable(
                name: "LatestEventsMode");
        }
    }
}
