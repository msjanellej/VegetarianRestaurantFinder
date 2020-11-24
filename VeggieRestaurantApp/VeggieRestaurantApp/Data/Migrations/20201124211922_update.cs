using Microsoft.EntityFrameworkCore.Migrations;

namespace VeggieRestaurantApp.Data.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28a7ab6d-e575-48db-b2cd-d9dd12b17094");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea223090-c6ae-4a20-9f07-ac4b27ee7453");

            migrationBuilder.CreateTable(
                name: "RestaurantDinerRestaurantReviewVM",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantVMId = table.Column<int>(nullable: true),
                    DinerVMId = table.Column<int>(nullable: true),
                    RestaurantReviewVMId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantDinerRestaurantReviewVM", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RestaurantDinerRestaurantReviewVM_Diners_DinerVMId",
                        column: x => x.DinerVMId,
                        principalTable: "Diners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RestaurantDinerRestaurantReviewVM_RestaurantReviews_RestaurantReviewVMId",
                        column: x => x.RestaurantReviewVMId,
                        principalTable: "RestaurantReviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RestaurantDinerRestaurantReviewVM_Restaurants_RestaurantVMId",
                        column: x => x.RestaurantVMId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c92d1b1-94ec-4f9c-86d0-94e34ca099ba", "82528aba-fa08-4086-9008-ad569ddc3b2c", "Restaurant", "RESTAURANT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "877e37f8-acd2-4313-ad3e-985399f8a7b2", "d1c5052f-d710-4801-a2a6-a049da5837ad", "Diner", "DINER" });

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantDinerRestaurantReviewVM_DinerVMId",
                table: "RestaurantDinerRestaurantReviewVM",
                column: "DinerVMId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantDinerRestaurantReviewVM_RestaurantReviewVMId",
                table: "RestaurantDinerRestaurantReviewVM",
                column: "RestaurantReviewVMId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantDinerRestaurantReviewVM_RestaurantVMId",
                table: "RestaurantDinerRestaurantReviewVM",
                column: "RestaurantVMId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RestaurantDinerRestaurantReviewVM");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c92d1b1-94ec-4f9c-86d0-94e34ca099ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "877e37f8-acd2-4313-ad3e-985399f8a7b2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ea223090-c6ae-4a20-9f07-ac4b27ee7453", "2cec3826-d97b-43b5-8fd7-cc7db8caf159", "Restaurant", "RESTAURANT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "28a7ab6d-e575-48db-b2cd-d9dd12b17094", "d3e4f74e-794e-406b-a95c-b0165b114115", "Diner", "DINER" });
        }
    }
}
