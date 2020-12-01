using Microsoft.EntityFrameworkCore.Migrations;

namespace VeggieRestaurantApp.Data.Migrations
{
    public partial class addForeignKeyToEmailList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6190b051-2359-4b57-a816-ef911610ccb4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9051750-94d5-4565-891b-3008dac37eb5");

            migrationBuilder.AddColumn<int>(
                name: "RestaurantId",
                table: "EmailLists",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "305119d8-ee48-421e-b866-e1ec26a1cf5d", "e5b41ce5-5a80-4798-b588-4ed5ad86497f", "Restaurant", "RESTAURANT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cf607bef-4676-402d-b066-141e0df9ad4a", "156897e0-9f85-4a71-9dee-2581f01d6910", "Diner", "DINER" });

            migrationBuilder.CreateIndex(
                name: "IX_EmailLists_RestaurantId",
                table: "EmailLists",
                column: "RestaurantId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmailLists_Restaurants_RestaurantId",
                table: "EmailLists",
                column: "RestaurantId",
                principalTable: "Restaurants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmailLists_Restaurants_RestaurantId",
                table: "EmailLists");

            migrationBuilder.DropIndex(
                name: "IX_EmailLists_RestaurantId",
                table: "EmailLists");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "305119d8-ee48-421e-b866-e1ec26a1cf5d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf607bef-4676-402d-b066-141e0df9ad4a");

            migrationBuilder.DropColumn(
                name: "RestaurantId",
                table: "EmailLists");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6190b051-2359-4b57-a816-ef911610ccb4", "042f011d-2776-42f6-8fb6-2b7deba6a41b", "Restaurant", "RESTAURANT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a9051750-94d5-4565-891b-3008dac37eb5", "fb4fdae2-9854-443e-b91c-18b084c42ce2", "Diner", "DINER" });
        }
    }
}
