using Microsoft.EntityFrameworkCore.Migrations;

namespace VeggieRestaurantApp.Data.Migrations
{
    public partial class addotherdatabases : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Diner_AspNetUsers_IdentityUserId",
                table: "Diner");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Restaurant",
                table: "Restaurant");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Diner",
                table: "Diner");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f9a7111-d409-4769-b6c5-04cd00cab8d1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53d1b175-62f2-461a-b9b2-df89a50754c3");

            migrationBuilder.RenameTable(
                name: "Restaurant",
                newName: "Restaurants");

            migrationBuilder.RenameTable(
                name: "Diner",
                newName: "Diners");

            migrationBuilder.RenameIndex(
                name: "IX_Diner_IdentityUserId",
                table: "Diners",
                newName: "IX_Diners_IdentityUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Restaurants",
                table: "Restaurants",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Diners",
                table: "Diners",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    ImageURL = table.Column<string>(nullable: true),
                    RestaurantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menus_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipeURL = table.Column<string>(nullable: true),
                    Likes = table.Column<int>(nullable: false),
                    DinerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipes_Diners_DinerId",
                        column: x => x.DinerId,
                        principalTable: "Diners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantReviews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Review = table.Column<string>(nullable: true),
                    Likes = table.Column<int>(nullable: false),
                    DinerId = table.Column<int>(nullable: false),
                    RestaurantId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RestaurantReviews_Diners_DinerId",
                        column: x => x.DinerId,
                        principalTable: "Diners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RestaurantReviews_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f51d33be-9078-4d4d-a570-8f07f00d4c3d", "d6f4b21e-a08e-4a3e-82c6-ca01213e8e7b", "Restaurant", "RESTAURANT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9380bbc1-46dd-4e1a-8869-a06cd6bff3f9", "4ded8f9c-cab4-452e-be83-a9a497508474", "Diner", "DINER" });

            migrationBuilder.CreateIndex(
                name: "IX_Menus_RestaurantId",
                table: "Menus",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_DinerId",
                table: "Recipes",
                column: "DinerId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantReviews_DinerId",
                table: "RestaurantReviews",
                column: "DinerId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantReviews_RestaurantId",
                table: "RestaurantReviews",
                column: "RestaurantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Diners_AspNetUsers_IdentityUserId",
                table: "Diners",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Diners_AspNetUsers_IdentityUserId",
                table: "Diners");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "RestaurantReviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Restaurants",
                table: "Restaurants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Diners",
                table: "Diners");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9380bbc1-46dd-4e1a-8869-a06cd6bff3f9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f51d33be-9078-4d4d-a570-8f07f00d4c3d");

            migrationBuilder.RenameTable(
                name: "Restaurants",
                newName: "Restaurant");

            migrationBuilder.RenameTable(
                name: "Diners",
                newName: "Diner");

            migrationBuilder.RenameIndex(
                name: "IX_Diners_IdentityUserId",
                table: "Diner",
                newName: "IX_Diner_IdentityUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Restaurant",
                table: "Restaurant",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Diner",
                table: "Diner",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "53d1b175-62f2-461a-b9b2-df89a50754c3", "793081b1-af0f-4978-a216-c0af9a8672ef", "Restaurant", "RESTAURANT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0f9a7111-d409-4769-b6c5-04cd00cab8d1", "e7f3a040-5532-4be4-8c86-68d2aad42399", "Diner", "DINER" });

            migrationBuilder.AddForeignKey(
                name: "FK_Diner_AspNetUsers_IdentityUserId",
                table: "Diner",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
