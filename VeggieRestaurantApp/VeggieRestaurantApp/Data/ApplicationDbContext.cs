using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VeggieRestaurantApp.Models;

namespace VeggieRestaurantApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>()
            .HasData(
            new IdentityRole
            {
                Name = "Restaurant",
                NormalizedName = "RESTAURANT"
            }
            );
            builder.Entity<IdentityRole>()
            .HasData(
            new IdentityRole
            {
                Name = "Diner",
                NormalizedName = "DINER"
            }
            );
            base.OnModelCreating(builder);
            builder.Entity<Restaurant>()
              .HasData(
                 new Restaurant { Id = 1, Name = "Beerline Cafe", StreetAddress = "2076 N Commerce St", City = "Milwaukee", State = "WI", ZipCode = 53212, Website = "http://beerlinecafe.com", PhoneNumber = "414-265-5644", Description = "Buzzy joint serving vegetarian and vegan options plus coffee & tea in a bright and spacious setting.", Image = "https://revelup-images-other.s3.amazonaws.com/beerlinecafe/aed2dccc0e80a23ca6a00a81d1ebedd1519fd2cf41c70b21bf3e0928bbc9bd278ad886651915ad113bbc736eaceab6837553325ba69795557c2c59567d4332c6_166x166.jpg", Likes = 10 },
                 new Restaurant { Id = 2, Name = "Beans & Barley", StreetAddress = "1901 E North Ave", City = "Milwaukee", State = "WI", ZipCode = 53202, Website = "http://beansandbarley.com", PhoneNumber = "414-278-7878", Description = "Health-conscious breakfast fare & sandwiches in airy, cheerful digs with a deli & organic market.", Image = "https://www.beansandbarley.com/wp-content/uploads/2018/06/Beans_Script_GrnShadow_285x80.png", Likes = 15 },
                 new Restaurant { Id = 3, Name = "On The Bus", StreetAddress = "400 N Water St", City = "Milwaukee", State = "WI", ZipCode = 53202, Website= "n/a", PhoneNumber= "414-265-5644", Description = "Counter service menu of vegan sandwiches, smoothies, bowls, & desserts in a modern food market.", Image = "https://uploads-ssl.webflow.com/598a208f22e8860001acd449/59af43df41e98c000100f572_OnTheBusLogo.jpg", Likes = 5 },
                 new Restaurant { Id = 4, Name = "Celesta", StreetAddress = "1978 N Farwell Ave", City = "Milwaukee", State = "WI", ZipCode = 53202, Website = "http://celesta.restaurant", PhoneNumber = "414-231-3030", Description = "Closed on Mondays", Image = "https://static1.squarespace.com/static/5848978a414fb5fbd40f2e72/t/5ad3a7b188251b90ed50c36b/1606087398797/?format=1500w", Likes = 12 });
            base.OnModelCreating(builder);
            builder.Entity<Recipe>()
              .HasData(
                 new Recipe { Id = 1, Name = "Vegetarian Tacos", RecipeURL = "http://https://www.loveandlemons.com/vegetarian-tacos/", Image= "https://cdn.loveandlemons.com/wp-content/uploads/2015/09/vegetarian-tacos.jpg", Likes = 7, DinerId = 25 },
                    new Recipe { Id = 2, Name = "Homeade Vegetarian Chili", RecipeURL = "https://cookieandkate.com/vegetarian-chili-recipe/", Image= "https://cookieandkate.com/images/2015/11/vegetarian-chili-recipe-6-768x1154.jpg", Likes = 15, DinerId = 25 },
                    new Recipe { Id = 3, Name = "Fresh & Easy Veggie Spaghetti", RecipeURL = "https://www.inspiredtaste.net/38662/veggie-spaghetti-recipe/", Image= "https://www.inspiredtaste.net/wp-content/uploads/2019/02/Vegetable-Spaghetti-Recipe-1200.jpg", Likes = 10, DinerId = 25 },
                    new Recipe { Id = 4, Name = "My Favorite Vegan Pizza", RecipeURL = "https://minimalistbaker.com/my-favorite-vegan-pizza/", Image= "https://minimalistbaker.com/wp-content/uploads/2014/06/THEE-BEST-Vegan-Pizza-Sauteed-veggies-simple-tomato-sauce-loads-of-vegan-parmesan-cheese.-Pizza-perfection-vegan-pizza.jpg", Likes = 5, DinerId = 25 },
                    new Recipe { Id = 5, Name = "The Best Damn Vegan Mashed Potatoes", RecipeURL = "https://minimalistbaker.com/the-best-damn-vegan-mashed-potatoes/", Image= "https://minimalistbaker.com/wp-content/uploads/2014/02/The-Best-Damn-Vegan-Mashed-Potatoes-So-simple-fast-SUPER-FLUFFY-and-delicious.jpg", Likes = 2, DinerId = 25 });
            base.OnModelCreating(builder);
            builder.Entity<Menu>()
              .HasData(
                    new Menu { Id = 1, Name = "Classic Breakfast Crepe", Details = "An all-in-one breakfast crepe with roasted rosemary potatoes, tempeh maple bacon, eggs or tofu & cheddar", Price = 9.25, RestaurantId = 1 },
                    new Menu { Id = 2, Name = "Mushroom Barley Burger", Details = "Panko encrusted portobella, barley and potato burger pattie on toasted focaccia bun with caramelized onions, crunchy romaine, roma tomatoes, alfalfa sprouts and vegan rosemary aioli. Add avocade, cheese and/or vegan Cheese", Price = 8.95, RestaurantId = 1 },
                    new Menu { Id = 3, Name = "This Week's Special", Details = "BBQ Soy Curls, Jalapenos & Cornbread Crutons with Scallion", Price = 12.00, RestaurantId = 4},
                    new Menu { Id = 4, Name = "Original Bus Burger", Details = "#1 Favorite Patty, Cheddar Cheese, Pickles, Crispy Onions, Tomatoes, Spring Mix, Housemade Bus Russian Sauce", Price = 9.95, RestaurantId = 3},
                    new Menu { Id = 5, Name = "Breakfast Bagel Sandwich", Details = "Tofu eggless patty, housemade hollandaise & Tempeh bacun served grilled on a bagel", Price = 6.95, RestaurantId = 3});
            base.OnModelCreating(builder);
            builder.Entity<Diner>()
              .HasData(
                 new Diner { Id = 25, Name = "Monkey D. Luffy", Age = 19, BirthMonth = "March", AnniversaryMonth = "October", EmailAddress = "luffy@strawhats.com" });
                   


        }
        public DbSet<VeggieRestaurantApp.Models.Diner> Diners { get; set; }
        public DbSet<VeggieRestaurantApp.Models.Restaurant> Restaurants { get; set; }
        public DbSet<VeggieRestaurantApp.Models.Recipe> Recipes { get; set; }
        public DbSet<VeggieRestaurantApp.Models.Menu> Menus { get; set; }
        public DbSet<VeggieRestaurantApp.Models.RestaurantReview> RestaurantReviews { get; set; }

    }
}
