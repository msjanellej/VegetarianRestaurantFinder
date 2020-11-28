using Microsoft.EntityFrameworkCore.Migrations;

namespace VeggieRestaurantApp.Data.Migrations
{
    public partial class tryingToFigureOutthisLikedRecipeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05a67bb7-1351-406a-b588-01b3772e8e67");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6773fdaa-e499-46d7-9a58-233d7658b9c2");

            migrationBuilder.CreateTable(
                name: "LikedRecipes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    RecipeURL = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    DinerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LikedRecipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LikedRecipes_Diners_DinerId",
                        column: x => x.DinerId,
                        principalTable: "Diners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "03bc84e1-2dbd-4eaa-9aaf-baef1f7f2a3a", "bc13eacc-2a32-42e4-bd88-70b5da4080be", "Restaurant", "RESTAURANT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cfe4c937-505a-4c2b-b3c2-5d36a3961aab", "73e9bbd1-2758-4f26-8ffe-8038c96eaa46", "Diner", "DINER" });

            migrationBuilder.CreateIndex(
                name: "IX_LikedRecipes_DinerId",
                table: "LikedRecipes",
                column: "DinerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LikedRecipes");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03bc84e1-2dbd-4eaa-9aaf-baef1f7f2a3a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cfe4c937-505a-4c2b-b3c2-5d36a3961aab");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6773fdaa-e499-46d7-9a58-233d7658b9c2", "494fd5b3-c76e-4aa6-bbdf-c07971c441c9", "Restaurant", "RESTAURANT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "05a67bb7-1351-406a-b588-01b3772e8e67", "8b014255-8f61-4cc0-94e7-af3067f15d3b", "Diner", "DINER" });
        }
    }
}
