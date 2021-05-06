using System;
using Microsoft.EntityFrameworkCore.Migrations;

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
                    Id = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    Yeast = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Beers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
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
                    VolumeValue = table.Column<float>(type: "float", nullable: false),
                    VolumeUnit = table.Column<int>(type: "int", nullable: false),
                    BoilVolumeValue = table.Column<float>(type: "float", nullable: false),
                    BoilVolumeUnit = table.Column<int>(type: "int", nullable: false),
                    IngredientsId = table.Column<string>(type: "varchar(150)", nullable: true),
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
                });

            migrationBuilder.CreateTable(
                name: "Malt",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    IngredientId = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    AmountValue = table.Column<float>(type: "float", nullable: false),
                    AmountUnit = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    IngredientsId = table.Column<string>(type: "varchar(150)", nullable: true),
                    Add = table.Column<string>(type: "text", nullable: true),
                    Attribute = table.Column<string>(type: "text", nullable: true),
                    IngredientsId1 = table.Column<string>(type: "varchar(150)", nullable: true)
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
                });

            migrationBuilder.CreateTable(
                name: "FoodDescription",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    BeerId = table.Column<string>(type: "varchar(150)", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "Method",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    BeerId = table.Column<string>(type: "varchar(150)", nullable: true),
                    Twist = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Method", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Method_Beers_BeerId",
                        column: x => x.BeerId,
                        principalTable: "Beers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fermentation",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    MethodId = table.Column<string>(type: "varchar(150)", nullable: true),
                    TempValue = table.Column<float>(type: "float", nullable: false),
                    TempUnit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fermentation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fermentation_Method_MethodId",
                        column: x => x.MethodId,
                        principalTable: "Method",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TempDuration",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    MethodId = table.Column<string>(type: "varchar(150)", nullable: true),
                    TempValue = table.Column<float>(type: "float", nullable: false),
                    TempUnit = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<float>(type: "float", nullable: false)
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
                });

            migrationBuilder.InsertData(
                table: "Beers",
                columns: new[] { "Id", "Abv", "AttenuationLevel", "BoilVolumeUnit", "BoilVolumeValue", "BrewerTips", "ContributedBy", "Description", "Ebc", "FirstBrewed", "Ibu", "ImageUrl", "IngredientsId", "Name", "Ph", "Tagline", "TargetFG", "TargetOG", "VolumeUnit", "VolumeValue" },
                values: new object[] { "cb762cd6-c0dd-4fc5-9144-d56422fce527", 0f, 0f, 3, 0f, "", "John Doe", "", 0f, new DateTime(2007, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0f, "", null, "Aguila", 0f, "", 0f, 0f, 3, 0f });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Yeast" },
                values: new object[] { "e06a5498-a6f8-4f80-8948-54633cee46ed", "Blah Blah Blah" });

            migrationBuilder.InsertData(
                table: "Malt",
                columns: new[] { "Id", "Add", "AmountUnit", "AmountValue", "Attribute", "Discriminator", "IngredientId", "IngredientsId", "IngredientsId1", "Name" },
                values: new object[] { "580b63e8-c3d8-4e06-80f1-1857a526fbe0", "start", 1, 0f, "glitter", "Hop", "e06a5498-a6f8-4f80-8948-54633cee46ed", null, null, "Dorp" });

            migrationBuilder.InsertData(
                table: "Malt",
                columns: new[] { "Id", "AmountUnit", "AmountValue", "Discriminator", "IngredientId", "IngredientsId", "Name" },
                values: new object[] { "631e6f64-2942-4034-b000-300fb38916cf", 1, 0f, "Malt", "e06a5498-a6f8-4f80-8948-54633cee46ed", null, "Derp" });

            migrationBuilder.InsertData(
                table: "FoodDescription",
                columns: new[] { "Id", "BeerId", "Description" },
                values: new object[] { "9a466668-0810-4508-91ff-ba577e98553b", "cb762cd6-c0dd-4fc5-9144-d56422fce527", "Lorem ipsum Dolor Sit Amet" });

            migrationBuilder.InsertData(
                table: "Method",
                columns: new[] { "Id", "BeerId", "Twist" },
                values: new object[] { "69a5396f-09c5-44f6-87ad-6a84d9ee1380", "cb762cd6-c0dd-4fc5-9144-d56422fce527", "Yaddah yaddah yaddah" });

            migrationBuilder.InsertData(
                table: "Fermentation",
                columns: new[] { "Id", "MethodId", "TempUnit", "TempValue" },
                values: new object[] { "cee0f379-8395-4731-9344-ebf520f22bd7", "69a5396f-09c5-44f6-87ad-6a84d9ee1380", 6, 3f });

            migrationBuilder.InsertData(
                table: "TempDuration",
                columns: new[] { "Id", "Duration", "MethodId", "TempUnit", "TempValue" },
                values: new object[] { "4988c517-864d-4b0a-a5ab-0aac5a25cd26", 4f, "69a5396f-09c5-44f6-87ad-6a84d9ee1380", 6, 1f });

            migrationBuilder.CreateIndex(
                name: "IX_Beers_IngredientsId",
                table: "Beers",
                column: "IngredientsId");

            migrationBuilder.CreateIndex(
                name: "IX_Fermentation_MethodId",
                table: "Fermentation",
                column: "MethodId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FoodDescription_BeerId",
                table: "FoodDescription",
                column: "BeerId");

            migrationBuilder.CreateIndex(
                name: "IX_Malt_IngredientsId",
                table: "Malt",
                column: "IngredientsId");

            migrationBuilder.CreateIndex(
                name: "IX_Malt_IngredientsId1",
                table: "Malt",
                column: "IngredientsId1");

            migrationBuilder.CreateIndex(
                name: "IX_Method_BeerId",
                table: "Method",
                column: "BeerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TempDuration_MethodId",
                table: "TempDuration",
                column: "MethodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fermentation");

            migrationBuilder.DropTable(
                name: "FoodDescription");

            migrationBuilder.DropTable(
                name: "Malt");

            migrationBuilder.DropTable(
                name: "TempDuration");

            migrationBuilder.DropTable(
                name: "Method");

            migrationBuilder.DropTable(
                name: "Beers");

            migrationBuilder.DropTable(
                name: "Ingredients");
        }
    }
}
