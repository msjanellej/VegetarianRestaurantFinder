using Microsoft.EntityFrameworkCore.Migrations;

namespace VeggieRestaurantApp.Data.Migrations
{
    public partial class addIdentityUserToRestaurants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9380bbc1-46dd-4e1a-8869-a06cd6bff3f9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f51d33be-9078-4d4d-a570-8f07f00d4c3d");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Restaurants",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e1baa542-cacf-46db-8abc-388e14bb9fe4", "14d5799d-f99c-4066-8ca0-0062feda19f4", "Restaurant", "RESTAURANT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b5582b5f-3ab6-4e5d-a4d4-b271e3562f3a", "d883883b-a6f2-4682-9009-2c7c2312aa57", "Diner", "DINER" });

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_IdentityUserId",
                table: "Restaurants",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurants_AspNetUsers_IdentityUserId",
                table: "Restaurants",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurants_AspNetUsers_IdentityUserId",
                table: "Restaurants");

            migrationBuilder.DropIndex(
                name: "IX_Restaurants_IdentityUserId",
                table: "Restaurants");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5582b5f-3ab6-4e5d-a4d4-b271e3562f3a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1baa542-cacf-46db-8abc-388e14bb9fe4");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Restaurants");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f51d33be-9078-4d4d-a570-8f07f00d4c3d", "d6f4b21e-a08e-4a3e-82c6-ca01213e8e7b", "Restaurant", "RESTAURANT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9380bbc1-46dd-4e1a-8869-a06cd6bff3f9", "4ded8f9c-cab4-452e-be83-a9a497508474", "Diner", "DINER" });
        }
    }
}
