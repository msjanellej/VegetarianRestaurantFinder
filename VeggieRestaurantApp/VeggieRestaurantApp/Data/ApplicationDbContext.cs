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
  
        }
        public DbSet<VeggieRestaurantApp.Models.Diner> Diners { get; set; }
        public DbSet<VeggieRestaurantApp.Models.Restaurant> Restaurants { get; set; }
        public DbSet<VeggieRestaurantApp.Models.Recipe> Recipes { get; set; }
        public DbSet<VeggieRestaurantApp.Models.Menu> Menus { get; set; }
        public DbSet<VeggieRestaurantApp.Models.RestaurantReview> RestaurantReviews { get; set; }

    }
}
