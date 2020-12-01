using Microsoft.EntityFrameworkCore.Migrations;

namespace VeggieRestaurantApp.Data.Migrations
{
    public partial class updateEmailModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "305119d8-ee48-421e-b866-e1ec26a1cf5d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cf607bef-4676-402d-b066-141e0df9ad4a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "21d7ad11-1e25-46c1-88b7-e2041837e222", "189954b2-0266-431c-b76d-19d0d3a6ec06", "Restaurant", "RESTAURANT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f9acf962-bc6f-46e9-a411-afe9942c37ca", "172a1b2e-a98e-4782-bd4d-4bf3c3e94fa4", "Diner", "DINER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21d7ad11-1e25-46c1-88b7-e2041837e222");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9acf962-bc6f-46e9-a411-afe9942c37ca");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "305119d8-ee48-421e-b866-e1ec26a1cf5d", "e5b41ce5-5a80-4798-b588-4ed5ad86497f", "Restaurant", "RESTAURANT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cf607bef-4676-402d-b066-141e0df9ad4a", "156897e0-9f85-4a71-9dee-2581f01d6910", "Diner", "DINER" });
        }
    }
}
