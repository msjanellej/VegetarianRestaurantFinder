using Microsoft.EntityFrameworkCore.Migrations;

namespace VeggieRestaurantApp.Data.Migrations
{
    public partial class adLikdRcips : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bace946-2214-4fa1-8c0d-b8749451c2a1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b20c714a-fb5e-4e55-9db3-a3d584f1b081");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "67a3433b-9544-4688-8a31-488d45ce5f3e", "2acacfa5-de7b-4de3-9796-d32a32e8cee7", "Restaurant", "RESTAURANT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "33f98674-d091-4717-b77e-d5c553598013", "998d6d5d-22df-4db7-9442-a2f3f6fa9cdc", "Diner", "DINER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "b20c714a-fb5e-4e55-9db3-a3d584f1b081", "4f436aa7-33d6-46cf-9652-9c9c4040de3c", "Restaurant", "RESTAURANT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7bace946-2214-4fa1-8c0d-b8749451c2a1", "01057cf6-82d0-4be1-8e9d-b46031bdef0d", "Diner", "DINER" });
        }
    }
}
