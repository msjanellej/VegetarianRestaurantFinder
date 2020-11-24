﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using VeggieRestaurantApp.Data;
using VeggieRestaurantApp.Models;

namespace VeggieRestaurantApp.Controllers
{
    //[Authorize(Roles = "Diner")]
    public class DinersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DinersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Diners
        public IActionResult Index()
        {
            ViewData["GOOGLE_API_KEY"] = APIKeys.GOOGLE_API_KEY;
            var diners = _context.Diners.ToList();
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var diner = _context.Diners.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            if (diner == null)
            {
                return RedirectToAction("Create");

            }
            return View(diners);
        }

        // GET: Diners/Details/5
        public IActionResult Details(int id)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var diner = _context.Diners.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            return View(diner);
        }

        // GET: Diners/Create
        public IActionResult Create()
        {
            return View();
        }
        // POST: Diners/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Diner diner)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            diner.IdentityUserId = userId;
            _context.Add(diner);
            _context.SaveChanges();
            return View(diner);
        }

        // GET: Diners/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var dinerssOnList = _context.Diners.ToList();
            var diner = _context.Diners.Where(c => c.Id == id).SingleOrDefault();
            if (diner == null)
            {
                return NotFound();
            }
            return View(diner);
        }

        // POST: Diners/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Diner diner)
        {
            try
            {
                _context.Update(diner);
                _context.SaveChanges();

                return RedirectToAction("Details", diner);
            }
            catch
            {
                return View();
            }
        }
        public IActionResult RestaurantIndex()
        {
            var restaurants = _context.Restaurants.ToList();
            var restaurantList = restaurants.OrderByDescending(r => r.Likes);
            return View(restaurantList);
        }
        public IActionResult RecipeIndex()
        {
            var recipes = _context.Recipes.ToList();
            var recipeList = recipes.OrderByDescending(r => r.Likes);
            return View(recipeList);
        }
        public IActionResult RecipeDetails(int id)
        {
            var recipe = _context.Recipes.Where(c => c.Id == id).SingleOrDefault();
            return View(recipe);
        }

        public IActionResult LikeRecipe(int id, Recipe recipe)
        {
            var recipeToLike = _context.Recipes.Single(r => r.Id == recipe.Id);
            recipeToLike.Likes += 1;
            _context.SaveChanges();
            return View("RecipeDetails", recipeToLike);
        }
        public IActionResult RestaurantDetails(int id)
        {
            var restaurant = _context.Restaurants.Where(r => r.Id == id).SingleOrDefault();
            return View(restaurant);
        }
        public IActionResult LikeRestaurant(int id, Restaurant restaurant)
        {
            var restaurantToLike = _context.Recipes.Single(r => r.Id == restaurant.Id);
            restaurantToLike.Likes += 1;
            _context.SaveChanges();
            return View("RestaurantDetails", restaurantToLike);
        }
        public IActionResult ViewMyLikedRecipes(Diner diner)
        {
            var recipes = _context.Recipes.ToList();
            var recipeList = recipes.Where(r => r.DinerId == diner.Id);
            return View(recipeList);

        }
        public IActionResult ReviewIndex(Restaurant restaurant)
        {
            var reviews = _context.RestaurantReviews.Where(r => r.RestaurantId == restaurant.Id).ToList();
            return View(reviews);
        }

        public IActionResult CreateReview(int id)
        {

            // Create view that accepts view model (just one instance)
            // instantiate viewmodel
            // run queries for all properties that are models
            // set viewmodel instance properties equal to query results
            // pass the viewmodel into the view
            RestaurantDinerRestaurantReviewVM newReview = new RestaurantDinerRestaurantReviewVM();
            var restaurant = _context.Restaurants.Where(r => r.Id == id).SingleOrDefault();
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var diner = _context.Diners.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            //var review = "";
            //newReview.RestaurantReviewVM.Review = review;
            newReview.RestaurantVM = restaurant;
            newReview.DinerVM = diner;
            return View(newReview);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateReview(RestaurantDinerRestaurantReviewVM restaurantReview)
        {
            // accept the viewmodel as a parameter
            // run all the Add and SaveChanges logic
            // create new instance of RestaurantReview - then set viewmodel properties = to RestaurantReview properties

            RestaurantReview newReview = new RestaurantReview();
            newReview.RestaurantId = restaurantReview.RestaurantVM.Id;
            newReview.DinerId = restaurantReview.DinerVM.Id;
            newReview.Review = restaurantReview.RestaurantReviewVM.Review;
            _context.Add(newReview);
            _context.SaveChanges();
            return View("RestaurantIndex");
        }
    }
}
