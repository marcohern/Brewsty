using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Brewsty.DataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Yeast = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitValue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Unit = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitValue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fermentation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TempId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fermentation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fermentation_UnitValue_TempId",
                        column: x => x.TempId,
                        principalTable: "UnitValue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Malt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    AmountId = table.Column<int>(type: "int", nullable: true),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    IngredientsId = table.Column<int>(type: "int", nullable: true),
                    Add = table.Column<string>(type: "text", nullable: true),
                    Attribute = table.Column<string>(type: "text", nullable: true),
                    IngredientsId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Malt", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Malt_Ingredients_IngredientsId",
                        column: x => x.IngredientsId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Malt_Ingredients_IngredientsId1",
                        column: x => x.IngredientsId1,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Malt_UnitValue_AmountId",
                        column: x => x.AmountId,
                        principalTable: "UnitValue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Method",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FermentationId = table.Column<int>(type: "int", nullable: true),
                    Twist = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Method", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Method_Fermentation_FermentationId",
                        column: x => x.FermentationId,
                        principalTable: "Fermentation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Beers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Tagline = table.Column<string>(type: "text", nullable: true),
                    FirstBrewed = table.Column<DateTime>(type: "datetime", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    Abv = table.Column<float>(type: "float", nullable: false),
                    Ibu = table.Column<float>(type: "float", nullable: false),
                    TargetFG = table.Column<float>(type: "float", nullable: false),
                    TargetOG = table.Column<float>(type: "float", nullable: false),
                    Ebc = table.Column<float>(type: "float", nullable: false),
                    Ph = table.Column<float>(type: "float", nullable: false),
                    AttenuationLevel = table.Column<float>(type: "float", nullable: false),
                    VolumeId = table.Column<int>(type: "int", nullable: true),
                    BoilVolumeId = table.Column<int>(type: "int", nullable: true),
                    MethodId = table.Column<int>(type: "int", nullable: true),
                    IngredientsId = table.Column<int>(type: "int", nullable: true),
                    BrewerTips = table.Column<string>(type: "text", nullable: true),
                    ContributedBy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Beers_Ingredients_IngredientsId",
                        column: x => x.IngredientsId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Beers_Method_MethodId",
                        column: x => x.MethodId,
                        principalTable: "Method",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Beers_UnitValue_BoilVolumeId",
                        column: x => x.BoilVolumeId,
                        principalTable: "UnitValue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Beers_UnitValue_VolumeId",
                        column: x => x.VolumeId,
                        principalTable: "UnitValue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TempDuration",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TempId = table.Column<int>(type: "int", nullable: true),
                    Duration = table.Column<float>(type: "float", nullable: false),
                    MethodId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempDuration", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TempDuration_Method_MethodId",
                        column: x => x.MethodId,
                        principalTable: "Method",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TempDuration_UnitValue_TempId",
                        column: x => x.TempId,
                        principalTable: "UnitValue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FoodDescription",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "text", nullable: true),
                    BeerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodDescription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodDescription_Beers_BeerId",
                        column: x => x.BeerId,
                        principalTable: "Beers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Beers_BoilVolumeId",
                table: "Beers",
                column: "BoilVolumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Beers_IngredientsId",
                table: "Beers",
                column: "IngredientsId");

            migrationBuilder.CreateIndex(
                name: "IX_Beers_MethodId",
                table: "Beers",
                column: "MethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Beers_VolumeId",
                table: "Beers",
                column: "VolumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Fermentation_TempId",
                table: "Fermentation",
                column: "TempId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodDescription_BeerId",
                table: "FoodDescription",
                column: "BeerId");

            migrationBuilder.CreateIndex(
                name: "IX_Malt_AmountId",
                table: "Malt",
                column: "AmountId");

            migrationBuilder.CreateIndex(
                name: "IX_Malt_IngredientsId",
                table: "Malt",
                column: "IngredientsId");

            migrationBuilder.CreateIndex(
                name: "IX_Malt_IngredientsId1",
                table: "Malt",
                column: "IngredientsId1");

            migrationBuilder.CreateIndex(
                name: "IX_Method_FermentationId",
                table: "Method",
                column: "FermentationId");

            migrationBuilder.CreateIndex(
                name: "IX_TempDuration_MethodId",
                table: "TempDuration",
                column: "MethodId");

            migrationBuilder.CreateIndex(
                name: "IX_TempDuration_TempId",
                table: "TempDuration",
                column: "TempId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodDescription");

            migrationBuilder.DropTable(
                name: "Malt");

            migrationBuilder.DropTable(
                name: "TempDuration");

            migrationBuilder.DropTable(
                name: "Beers");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Method");

            migrationBuilder.DropTable(
                name: "Fermentation");

            migrationBuilder.DropTable(
                name: "UnitValue");
        }
    }
}
