using Microsoft.EntityFrameworkCore.Migrations;

namespace VeggieRestaurantApp.Data.Migrations
{
    public partial class AddEmailTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03bc84e1-2dbd-4eaa-9aaf-baef1f7f2a3a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cfe4c937-505a-4c2b-b3c2-5d36a3961aab");

            migrationBuilder.CreateTable(
                name: "EmailLists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    DinerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailLists_Diners_DinerId",
                        column: x => x.DinerId,
                        principalTable: "Diners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6190b051-2359-4b57-a816-ef911610ccb4", "042f011d-2776-42f6-8fb6-2b7deba6a41b", "Restaurant", "RESTAURANT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a9051750-94d5-4565-891b-3008dac37eb5", "fb4fdae2-9854-443e-b91c-18b084c42ce2", "Diner", "DINER" });

            migrationBuilder.CreateIndex(
                name: "IX_EmailLists_DinerId",
                table: "EmailLists",
                column: "DinerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailLists");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6190b051-2359-4b57-a816-ef911610ccb4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9051750-94d5-4565-891b-3008dac37eb5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "03bc84e1-2dbd-4eaa-9aaf-baef1f7f2a3a", "bc13eacc-2a32-42e4-bd88-70b5da4080be", "Restaurant", "RESTAURANT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cfe4c937-505a-4c2b-b3c2-5d36a3961aab", "73e9bbd1-2758-4f26-8ffe-8038c96eaa46", "Diner", "DINER" });
        }
    }
}
