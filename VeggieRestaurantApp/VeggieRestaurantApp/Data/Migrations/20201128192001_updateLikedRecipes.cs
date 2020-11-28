using Microsoft.EntityFrameworkCore.Migrations;

namespace VeggieRestaurantApp.Data.Migrations
{
    public partial class updateLikedRecipes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33f98674-d091-4717-b77e-d5c553598013");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67a3433b-9544-4688-8a31-488d45ce5f3e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6773fdaa-e499-46d7-9a58-233d7658b9c2", "494fd5b3-c76e-4aa6-bbdf-c07971c441c9", "Restaurant", "RESTAURANT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "05a67bb7-1351-406a-b588-01b3772e8e67", "8b014255-8f61-4cc0-94e7-af3067f15d3b", "Diner", "DINER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05a67bb7-1351-406a-b588-01b3772e8e67");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6773fdaa-e499-46d7-9a58-233d7658b9c2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "67a3433b-9544-4688-8a31-488d45ce5f3e", "2acacfa5-de7b-4de3-9796-d32a32e8cee7", "Restaurant", "RESTAURANT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "33f98674-d091-4717-b77e-d5c553598013", "998d6d5d-22df-4db7-9442-a2f3f6fa9cdc", "Diner", "DINER" });
        }
    }
}
