using Microsoft.EntityFrameworkCore.Migrations;

namespace VeggieRestaurantApp.Data.Migrations
{
    public partial class updatedModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4af04411-f4f1-4e0c-b612-567d038701f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7e4c216d-0161-4de6-acfb-7cbee80b50f3");

            migrationBuilder.CreateTable(
                name: "Diner",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    BirthMonth = table.Column<string>(nullable: true),
                    AnniversaryMonth = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diner", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Diner_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Restaurant",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Likes = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurant", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "53d1b175-62f2-461a-b9b2-df89a50754c3", "793081b1-af0f-4978-a216-c0af9a8672ef", "Restaurant", "RESTAURANT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0f9a7111-d409-4769-b6c5-04cd00cab8d1", "e7f3a040-5532-4be4-8c86-68d2aad42399", "Diner", "DINER" });

            migrationBuilder.CreateIndex(
                name: "IX_Diner_IdentityUserId",
                table: "Diner",
                column: "IdentityUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Diner");

            migrationBuilder.DropTable(
                name: "Restaurant");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0f9a7111-d409-4769-b6c5-04cd00cab8d1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53d1b175-62f2-461a-b9b2-df89a50754c3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4af04411-f4f1-4e0c-b612-567d038701f3", "b4c817a1-3fd4-40e9-816a-7d34a65f19d7", "Restaurant", "RESTAURANT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7e4c216d-0161-4de6-acfb-7cbee80b50f3", "9749b4b0-ee46-473e-ad95-32d60a622d18", "Diner", "DINER" });
        }
    }
}
