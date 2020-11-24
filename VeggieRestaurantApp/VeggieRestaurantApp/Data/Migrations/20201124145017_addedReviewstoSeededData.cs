using Microsoft.EntityFrameworkCore.Migrations;

namespace VeggieRestaurantApp.Data.Migrations
{
    public partial class addedReviewstoSeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "951ccaa6-3089-4605-a47a-508b2f30e8a1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6f4f603-26fc-491e-8c45-528dbabb53b7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ea223090-c6ae-4a20-9f07-ac4b27ee7453", "2cec3826-d97b-43b5-8fd7-cc7db8caf159", "Restaurant", "RESTAURANT" },
                    { "28a7ab6d-e575-48db-b2cd-d9dd12b17094", "d3e4f74e-794e-406b-a95c-b0165b114115", "Diner", "DINER" }
                });

            migrationBuilder.InsertData(
                table: "RestaurantReviews",
                columns: new[] { "Id", "DinerId", "Likes", "RestaurantId", "Review" },
                values: new object[,]
                {
                    { 1, 25, 0, 1, "The food was delicious" },
                    { 2, 25, 0, 1, "Great Service" },
                    { 3, 25, 0, 1, "yummy!" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28a7ab6d-e575-48db-b2cd-d9dd12b17094");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea223090-c6ae-4a20-9f07-ac4b27ee7453");

            migrationBuilder.DeleteData(
                table: "RestaurantReviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RestaurantReviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RestaurantReviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "951ccaa6-3089-4605-a47a-508b2f30e8a1", "d308cfd4-7b47-4549-9e1e-5849be6ddb4c", "Restaurant", "RESTAURANT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d6f4f603-26fc-491e-8c45-528dbabb53b7", "ae0941e4-92e0-42f5-a4ab-b2a7a38a0d90", "Diner", "DINER" });
        }
    }
}
