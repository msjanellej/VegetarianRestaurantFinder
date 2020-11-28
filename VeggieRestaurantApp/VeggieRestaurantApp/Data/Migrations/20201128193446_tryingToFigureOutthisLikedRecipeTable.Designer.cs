﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VeggieRestaurantApp.Data;

namespace VeggieRestaurantApp.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201128193446_tryingToFigureOutthisLikedRecipeTable")]
    partial class tryingToFigureOutthisLikedRecipeTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "03bc84e1-2dbd-4eaa-9aaf-baef1f7f2a3a",
                            ConcurrencyStamp = "bc13eacc-2a32-42e4-bd88-70b5da4080be",
                            Name = "Restaurant",
                            NormalizedName = "RESTAURANT"
                        },
                        new
                        {
                            Id = "cfe4c937-505a-4c2b-b3c2-5d36a3961aab",
                            ConcurrencyStamp = "73e9bbd1-2758-4f26-8ffe-8038c96eaa46",
                            Name = "Diner",
                            NormalizedName = "DINER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("VeggieRestaurantApp.Models.Diner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("AnniversaryMonth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BirthMonth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdentityUserId");

                    b.ToTable("Diners");

                    b.HasData(
                        new
                        {
                            Id = 25,
                            Age = 19,
                            AnniversaryMonth = "October",
                            BirthMonth = "March",
                            EmailAddress = "luffy@strawhats.com",
                            Name = "Monkey D. Luffy"
                        });
                });

            modelBuilder.Entity("VeggieRestaurantApp.Models.LikedRecipes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DinerId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecipeURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DinerId");

                    b.ToTable("LikedRecipes");
                });

            modelBuilder.Entity("VeggieRestaurantApp.Models.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Menus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Details = "An all-in-one breakfast crepe with roasted rosemary potatoes, tempeh maple bacon, eggs or tofu & cheddar",
                            Name = "Classic Breakfast Crepe",
                            Price = 9.25,
                            RestaurantId = 1
                        },
                        new
                        {
                            Id = 2,
                            Details = "Panko encrusted portobella, barley and potato burger pattie on toasted focaccia bun with caramelized onions, crunchy romaine, roma tomatoes, alfalfa sprouts and vegan rosemary aioli. Add avocade, cheese and/or vegan Cheese",
                            Name = "Mushroom Barley Burger",
                            Price = 8.9499999999999993,
                            RestaurantId = 1
                        },
                        new
                        {
                            Id = 3,
                            Details = "BBQ Soy Curls, Jalapenos & Cornbread Crutons with Scallion",
                            Name = "This Week's Special",
                            Price = 12.0,
                            RestaurantId = 4
                        },
                        new
                        {
                            Id = 4,
                            Details = "#1 Favorite Patty, Cheddar Cheese, Pickles, Crispy Onions, Tomatoes, Spring Mix, Housemade Bus Russian Sauce",
                            Name = "Original Bus Burger",
                            Price = 9.9499999999999993,
                            RestaurantId = 3
                        },
                        new
                        {
                            Id = 5,
                            Details = "Tofu eggless patty, housemade hollandaise & Tempeh bacun served grilled on a bagel",
                            Name = "Breakfast Bagel Sandwich",
                            Price = 6.9500000000000002,
                            RestaurantId = 3
                        });
                });

            modelBuilder.Entity("VeggieRestaurantApp.Models.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DinerId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecipeURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DinerId");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DinerId = 25,
                            Image = "https://cdn.loveandlemons.com/wp-content/uploads/2015/09/vegetarian-tacos.jpg",
                            Likes = 7,
                            Name = "Vegetarian Tacos",
                            RecipeURL = "http://https://www.loveandlemons.com/vegetarian-tacos/"
                        },
                        new
                        {
                            Id = 2,
                            DinerId = 25,
                            Image = "https://cookieandkate.com/images/2015/11/vegetarian-chili-recipe-6-768x1154.jpg",
                            Likes = 15,
                            Name = "Homeade Vegetarian Chili",
                            RecipeURL = "https://cookieandkate.com/vegetarian-chili-recipe/"
                        },
                        new
                        {
                            Id = 3,
                            DinerId = 25,
                            Image = "https://www.inspiredtaste.net/wp-content/uploads/2019/02/Vegetable-Spaghetti-Recipe-1200.jpg",
                            Likes = 10,
                            Name = "Fresh & Easy Veggie Spaghetti",
                            RecipeURL = "https://www.inspiredtaste.net/38662/veggie-spaghetti-recipe/"
                        },
                        new
                        {
                            Id = 4,
                            DinerId = 25,
                            Image = "https://minimalistbaker.com/wp-content/uploads/2014/06/THEE-BEST-Vegan-Pizza-Sauteed-veggies-simple-tomato-sauce-loads-of-vegan-parmesan-cheese.-Pizza-perfection-vegan-pizza.jpg",
                            Likes = 5,
                            Name = "My Favorite Vegan Pizza",
                            RecipeURL = "https://minimalistbaker.com/my-favorite-vegan-pizza/"
                        },
                        new
                        {
                            Id = 5,
                            DinerId = 25,
                            Image = "https://minimalistbaker.com/wp-content/uploads/2014/02/The-Best-Damn-Vegan-Mashed-Potatoes-So-simple-fast-SUPER-FLUFFY-and-delicious.jpg",
                            Likes = 2,
                            Name = "The Best Damn Vegan Mashed Potatoes",
                            RecipeURL = "https://minimalistbaker.com/the-best-damn-vegan-mashed-potatoes/"
                        });
                });

            modelBuilder.Entity("VeggieRestaurantApp.Models.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.Property<double>("latitude")
                        .HasColumnType("float");

                    b.Property<double>("longitude")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("IdentityUserId");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Milwaukee",
                            Description = "Buzzy joint serving vegetarian and vegan options plus coffee & tea in a bright and spacious setting.",
                            Image = "https://revelup-images-other.s3.amazonaws.com/beerlinecafe/aed2dccc0e80a23ca6a00a81d1ebedd1519fd2cf41c70b21bf3e0928bbc9bd278ad886651915ad113bbc736eaceab6837553325ba69795557c2c59567d4332c6_166x166.jpg",
                            Likes = 10,
                            Name = "Beerline Cafe",
                            PhoneNumber = "414-265-5644",
                            State = "WI",
                            StreetAddress = "2076 N Commerce St",
                            Website = "http://beerlinecafe.com",
                            ZipCode = 53212,
                            latitude = 43.058049099999998,
                            longitude = -87.898650099999998
                        },
                        new
                        {
                            Id = 2,
                            City = "Milwaukee",
                            Description = "Health-conscious breakfast fare & sandwiches in airy, cheerful digs with a deli & organic market.",
                            Image = "https://www.beansandbarley.com/wp-content/uploads/2018/06/Beans_Script_GrnShadow_285x80.png",
                            Likes = 15,
                            Name = "Beans & Barley",
                            PhoneNumber = "414-278-7878",
                            State = "WI",
                            StreetAddress = "1901 E North Ave",
                            Website = "http://beansandbarley.com",
                            ZipCode = 53202,
                            latitude = 43.059898500000003,
                            longitude = -87.8866917
                        },
                        new
                        {
                            Id = 3,
                            City = "Milwaukee",
                            Description = "Counter service menu of vegan sandwiches, smoothies, bowls, & desserts in a modern food market.",
                            Image = "https://uploads-ssl.webflow.com/598a208f22e8860001acd449/59af43df41e98c000100f572_OnTheBusLogo.jpg",
                            Likes = 5,
                            Name = "On The Bus",
                            PhoneNumber = "414-265-5644",
                            State = "WI",
                            StreetAddress = "400 N Water St",
                            Website = "n/a",
                            ZipCode = 53202,
                            latitude = 43.036569180291508,
                            longitude = -87.906729319708504
                        },
                        new
                        {
                            Id = 4,
                            City = "Milwaukee",
                            Description = "Closed on Mondays",
                            Image = "https://static1.squarespace.com/static/5848978a414fb5fbd40f2e72/t/5ad3a7b188251b90ed50c36b/1606087398797/?format=1500w",
                            Likes = 12,
                            Name = "Celesta",
                            PhoneNumber = "414-231-3030",
                            State = "WI",
                            StreetAddress = "1978 N Farwell Ave",
                            Website = "http://celesta.restaurant",
                            ZipCode = 53202,
                            latitude = 43.056616899999987,
                            longitude = -87.888475700000001
                        });
                });

            modelBuilder.Entity("VeggieRestaurantApp.Models.RestaurantDinerRestaurantReviewVM", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DinerVMId")
                        .HasColumnType("int");

                    b.Property<int?>("RestaurantReviewVMId")
                        .HasColumnType("int");

                    b.Property<int?>("RestaurantVMId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("DinerVMId");

                    b.HasIndex("RestaurantReviewVMId");

                    b.HasIndex("RestaurantVMId");

                    b.ToTable("RestaurantDinerRestaurantReviewVM");
                });

            modelBuilder.Entity("VeggieRestaurantApp.Models.RestaurantReview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DinerId")
                        .HasColumnType("int");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<string>("Review")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DinerId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("RestaurantReviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DinerId = 25,
                            Likes = 0,
                            RestaurantId = 1,
                            Review = "The food was delicious"
                        },
                        new
                        {
                            Id = 2,
                            DinerId = 25,
                            Likes = 0,
                            RestaurantId = 1,
                            Review = "Great Service"
                        },
                        new
                        {
                            Id = 3,
                            DinerId = 25,
                            Likes = 0,
                            RestaurantId = 1,
                            Review = "yummy!"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VeggieRestaurantApp.Models.Diner", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserId");
                });

            modelBuilder.Entity("VeggieRestaurantApp.Models.LikedRecipes", b =>
                {
                    b.HasOne("VeggieRestaurantApp.Models.Diner", "diner")
                        .WithMany()
                        .HasForeignKey("DinerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VeggieRestaurantApp.Models.Menu", b =>
                {
                    b.HasOne("VeggieRestaurantApp.Models.Restaurant", "restaurant")
                        .WithMany()
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VeggieRestaurantApp.Models.Recipe", b =>
                {
                    b.HasOne("VeggieRestaurantApp.Models.Diner", "diner")
                        .WithMany()
                        .HasForeignKey("DinerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VeggieRestaurantApp.Models.Restaurant", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserId");
                });

            modelBuilder.Entity("VeggieRestaurantApp.Models.RestaurantDinerRestaurantReviewVM", b =>
                {
                    b.HasOne("VeggieRestaurantApp.Models.Diner", "DinerVM")
                        .WithMany()
                        .HasForeignKey("DinerVMId");

                    b.HasOne("VeggieRestaurantApp.Models.RestaurantReview", "RestaurantReviewVM")
                        .WithMany()
                        .HasForeignKey("RestaurantReviewVMId");

                    b.HasOne("VeggieRestaurantApp.Models.Restaurant", "RestaurantVM")
                        .WithMany()
                        .HasForeignKey("RestaurantVMId");
                });

            modelBuilder.Entity("VeggieRestaurantApp.Models.RestaurantReview", b =>
                {
                    b.HasOne("VeggieRestaurantApp.Models.Diner", "diner")
                        .WithMany()
                        .HasForeignKey("DinerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VeggieRestaurantApp.Models.Restaurant", "restaurant")
                        .WithMany()
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
