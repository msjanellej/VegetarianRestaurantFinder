using Microsoft.EntityFrameworkCore.Migrations;



namespace VeggieRestaurantApp.Data.Migrations
{
    public partial class AddModelTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b01839d-8b00-440d-8253-2afbadcc3844");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9f5c5f3-d81b-4895-89f2-cb6897e818b6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4af04411-f4f1-4e0c-b612-567d038701f3", "b4c817a1-3fd4-40e9-816a-7d34a65f19d7", "Restaurant", "RESTAURANT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7e4c216d-0161-4de6-acfb-7cbee80b50f3", "9749b4b0-ee46-473e-ad95-32d60a622d18", "Diner", "DINER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4af04411-f4f1-4e0c-b612-567d038701f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e4c216d-0161-4de6-acfb-7cbee80b50f3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5b01839d-8b00-440d-8253-2afbadcc3844", "dc2e5513-e89f-4fc9-a99c-f8e77a82c5ac", "Restaurant", "RESTAURANT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a9f5c5f3-d81b-4895-89f2-cb6897e818b6", "782956d0-6971-4b0a-af9c-7e3cacd757e2", "Diner", "DINER" });
        }
    }
}
