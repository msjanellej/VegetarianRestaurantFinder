using Microsoft.EntityFrameworkCore.Migrations;

namespace VeggieRestaurantApp.Data.Migrations
{
    public partial class addedseededdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5582b5f-3ab6-4e5d-a4d4-b271e3562f3a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1baa542-cacf-46db-8abc-388e14bb9fe4");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Menus");

            migrationBuilder.AlterColumn<int>(
                name: "ZipCode",
                table: "Restaurants",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Restaurants",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Website",
                table: "Restaurants",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Recipes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Recipes",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "951ccaa6-3089-4605-a47a-508b2f30e8a1", "d308cfd4-7b47-4549-9e1e-5849be6ddb4c", "Restaurant", "RESTAURANT" },
                    { "d6f4f603-26fc-491e-8c45-528dbabb53b7", "ae0941e4-92e0-42f5-a4ab-b2a7a38a0d90", "Diner", "DINER" }
                });

            migrationBuilder.InsertData(
                table: "Diners",
                columns: new[] { "Id", "Age", "AnniversaryMonth", "BirthMonth", "EmailAddress", "IdentityUserId", "Name" },
                values: new object[] { 25, 19, "October", "March", "luffy@strawhats.com", null, "Monkey D. Luffy" });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "City", "Description", "IdentityUserId", "Image", "Likes", "Name", "PhoneNumber", "State", "StreetAddress", "Website", "ZipCode" },
                values: new object[,]
                {
                    { 1, "Milwaukee", "Buzzy joint serving vegetarian and vegan options plus coffee & tea in a bright and spacious setting.", null, "https://revelup-images-other.s3.amazonaws.com/beerlinecafe/aed2dccc0e80a23ca6a00a81d1ebedd1519fd2cf41c70b21bf3e0928bbc9bd278ad886651915ad113bbc736eaceab6837553325ba69795557c2c59567d4332c6_166x166.jpg", 10, "Beerline Cafe", "414-265-5644", "WI", "2076 N Commerce St", "http://beerlinecafe.com", 53212 },
                    { 2, "Milwaukee", "Health-conscious breakfast fare & sandwiches in airy, cheerful digs with a deli & organic market.", null, "https://www.beansandbarley.com/wp-content/uploads/2018/06/Beans_Script_GrnShadow_285x80.png", 15, "Beans & Barley", "414-278-7878", "WI", "1901 E North Ave", "http://beansandbarley.com", 53202 },
                    { 3, "Milwaukee", "Counter service menu of vegan sandwiches, smoothies, bowls, & desserts in a modern food market.", null, "https://uploads-ssl.webflow.com/598a208f22e8860001acd449/59af43df41e98c000100f572_OnTheBusLogo.jpg", 5, "On The Bus", "414-265-5644", "WI", "400 N Water St", "n/a", 53202 },
                    { 4, "Milwaukee", "Closed on Mondays", null, "https://static1.squarespace.com/static/5848978a414fb5fbd40f2e72/t/5ad3a7b188251b90ed50c36b/1606087398797/?format=1500w", 12, "Celesta", "414-231-3030", "WI", "1978 N Farwell Ave", "http://celesta.restaurant", 53202 }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Details", "Name", "Price", "RestaurantId" },
                values: new object[,]
                {
                    { 1, "An all-in-one breakfast crepe with roasted rosemary potatoes, tempeh maple bacon, eggs or tofu & cheddar", "Classic Breakfast Crepe", 9.25, 1 },
                    { 2, "Panko encrusted portobella, barley and potato burger pattie on toasted focaccia bun with caramelized onions, crunchy romaine, roma tomatoes, alfalfa sprouts and vegan rosemary aioli. Add avocade, cheese and/or vegan Cheese", "Mushroom Barley Burger", 8.9499999999999993, 1 },
                    { 4, "#1 Favorite Patty, Cheddar Cheese, Pickles, Crispy Onions, Tomatoes, Spring Mix, Housemade Bus Russian Sauce", "Original Bus Burger", 9.9499999999999993, 3 },
                    { 5, "Tofu eggless patty, housemade hollandaise & Tempeh bacun served grilled on a bagel", "Breakfast Bagel Sandwich", 6.9500000000000002, 3 },
                    { 3, "BBQ Soy Curls, Jalapenos & Cornbread Crutons with Scallion", "This Week's Special", 12.0, 4 }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "DinerId", "Image", "Likes", "Name", "RecipeURL" },
                values: new object[,]
                {
                    { 1, 25, "https://cdn.loveandlemons.com/wp-content/uploads/2015/09/vegetarian-tacos.jpg", 7, "Vegetarian Tacos", "http://https://www.loveandlemons.com/vegetarian-tacos/" },
                    { 2, 25, "https://cookieandkate.com/images/2015/11/vegetarian-chili-recipe-6-768x1154.jpg", 15, "Homeade Vegetarian Chili", "https://cookieandkate.com/vegetarian-chili-recipe/" },
                    { 3, 25, "https://www.inspiredtaste.net/wp-content/uploads/2019/02/Vegetable-Spaghetti-Recipe-1200.jpg", 10, "Fresh & Easy Veggie Spaghetti", "https://www.inspiredtaste.net/38662/veggie-spaghetti-recipe/" },
                    { 4, 25, "https://minimalistbaker.com/wp-content/uploads/2014/06/THEE-BEST-Vegan-Pizza-Sauteed-veggies-simple-tomato-sauce-loads-of-vegan-parmesan-cheese.-Pizza-perfection-vegan-pizza.jpg", 5, "My Favorite Vegan Pizza", "https://minimalistbaker.com/my-favorite-vegan-pizza/" },
                    { 5, 25, "https://minimalistbaker.com/wp-content/uploads/2014/02/The-Best-Damn-Vegan-Mashed-Potatoes-So-simple-fast-SUPER-FLUFFY-and-delicious.jpg", 2, "The Best Damn Vegan Mashed Potatoes", "https://minimalistbaker.com/the-best-damn-vegan-mashed-potatoes/" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "951ccaa6-3089-4605-a47a-508b2f30e8a1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6f4f603-26fc-491e-8c45-528dbabb53b7");

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Diners",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "Website",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Recipes");

            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Latitude",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Longitude",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Menus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e1baa542-cacf-46db-8abc-388e14bb9fe4", "14d5799d-f99c-4066-8ca0-0062feda19f4", "Restaurant", "RESTAURANT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b5582b5f-3ab6-4e5d-a4d4-b271e3562f3a", "d883883b-a6f2-4682-9009-2c7c2312aa57", "Diner", "DINER" });
        }
    }
}
