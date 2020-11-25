using Microsoft.EntityFrameworkCore.Migrations;

namespace VeggieRestaurantApp.Data.Migrations
{
    public partial class addLatLong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c92d1b1-94ec-4f9c-86d0-94e34ca099ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "877e37f8-acd2-4313-ad3e-985399f8a7b2");

            migrationBuilder.AddColumn<double>(
                name: "latitude",
                table: "Restaurants",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "longitude",
                table: "Restaurants",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b20c714a-fb5e-4e55-9db3-a3d584f1b081", "4f436aa7-33d6-46cf-9652-9c9c4040de3c", "Restaurant", "RESTAURANT" },
                    { "7bace946-2214-4fa1-8c0d-b8749451c2a1", "01057cf6-82d0-4be1-8e9d-b46031bdef0d", "Diner", "DINER" }
                });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "latitude", "longitude" },
                values: new object[] { 43.058049099999998, -87.898650099999998 });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "latitude", "longitude" },
                values: new object[] { 43.059898500000003, -87.8866917 });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "latitude", "longitude" },
                values: new object[] { 43.036569180291508, -87.906729319708504 });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "latitude", "longitude" },
                values: new object[] { 43.056616899999987, -87.888475700000001 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bace946-2214-4fa1-8c0d-b8749451c2a1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b20c714a-fb5e-4e55-9db3-a3d584f1b081");

            migrationBuilder.DropColumn(
                name: "latitude",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "longitude",
                table: "Restaurants");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c92d1b1-94ec-4f9c-86d0-94e34ca099ba", "82528aba-fa08-4086-9008-ad569ddc3b2c", "Restaurant", "RESTAURANT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "877e37f8-acd2-4313-ad3e-985399f8a7b2", "d1c5052f-d710-4801-a2a6-a049da5837ad", "Diner", "DINER" });
        }
    }
}
