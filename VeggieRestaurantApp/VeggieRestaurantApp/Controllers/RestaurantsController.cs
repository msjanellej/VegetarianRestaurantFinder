using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using VeggieRestaurantApp.Data;
using VeggieRestaurantApp.Models;

namespace VeggieRestaurantApp.Controllers
{
    //[Authorize(Roles = "Restaurant")]
    public class RestaurantsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RestaurantsController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: RestaurantsController
        public ActionResult Index()
        {
            var restaurants = _context.Restaurants.ToList();
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var restaurant = _context.Restaurants.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            if (restaurant == null)
            {
                return RedirectToAction("Create");
            }
            return View(restaurant);
        }
        // GET: RestaurantsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RestaurantsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Restaurant restaurant)
        {
            var newRestaurant = GetCoordinates(restaurant);
            restaurant.latitude = 0;
            restaurant.longitude = 0;
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            restaurant.IdentityUserId = userId;
            _context.Add(restaurant);
            _context.SaveChanges();
            return View("Index", restaurant);
        }

        // GET: RestaurantsController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var restaurantsOnList = _context.Restaurants.ToList();
            var restaurant = _context.Restaurants.Where(c => c.Id == id).SingleOrDefault();
            if (restaurant == null)
            {
                return NotFound();
            }
            return View(restaurant);
        }

        // POST: RestaurantsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Restaurant restaurant)
        {
            try
            {
                _context.Update(restaurant);
                _context.SaveChanges();

                return RedirectToAction("Index", restaurant);
            }
            catch
            {
                return View();
            }
        }
        public IActionResult SpecialsIndex()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var restaurant = _context.Restaurants.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            var specials = _context.Menus.Where(r => r.RestaurantId == restaurant.Id).ToList();
            return View(specials);
        }
        public IActionResult EditSpecials(int id)
        {

            var specialItem = _context.Menus.Where(c => c.Id == id).SingleOrDefault();
            return View(specialItem);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditSpecials(Menu specialItem)
        {
            try
            {
                _context.Update(specialItem);
                _context.SaveChanges();

            return RedirectToAction("SpecialsIndex");
            }
            catch
            {
                return View();
            }
        }
        // GET: RestaurantsController/Create
        public ActionResult CreateSpecials()
        {
            return View();
        }

        // POST: RestaurantsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateSpecials(Menu menu)
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var restaurant = _context.Restaurants.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            menu.RestaurantId = restaurant.Id;
            _context.Menus.Add(menu);
            _context.SaveChanges();
            return RedirectToAction("SpecialsIndex");
        }
        public IActionResult DeleteSpecial(int id)
        {
            var menuItem = _context.Menus.Find(id);
            return View(menuItem);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteSpecial(Menu menu)
        {
            
            _context.Menus.Remove(menu);
            _context.SaveChanges();
            return RedirectToAction("SpecialsIndex");
        }

        public IActionResult ReviewsIndex()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var restaurant = _context.Restaurants.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            var reviews = _context.RestaurantReviews.Where(r => r.RestaurantId == restaurant.Id).ToList();
            
            return View(reviews);
        }
        public IActionResult ReviewerDetails(int id)
        {
            var review = _context.RestaurantReviews.Where(r => r.Id == id).SingleOrDefault();
            var reviewer = _context.Diners.Where(d => d.Id == review.DinerId).SingleOrDefault();
            return View(reviewer);
        }
        static async Task<Restaurant> GetCoordinates(Restaurant restaurant)
        {
            HttpClient httpClient = new HttpClient();
            var URL = $"https://maps.googleapis.com/maps/api/geocode/json?address={restaurant.StreetAddress}+{restaurant.City}+{restaurant.State}&key={APIKeys.GOOGLE_API_KEY}";
            HttpResponseMessage response = await httpClient.GetAsync(URL);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            Newtonsoft.Json.Linq.JObject result = JsonConvert.DeserializeObject<JObject>(responseBody);
            var partOfObject = result["results"];
            var secondPartOfObject = partOfObject[0];
            var thirdPartOfObject = secondPartOfObject["geometry"];
            var fourthPartOfObject = thirdPartOfObject["location"];
            var latitude = fourthPartOfObject["lat"].ToString();
            var longitude = fourthPartOfObject["lng"].ToString();
            restaurant.latitude = double.Parse(latitude);
            restaurant.longitude = double.Parse(longitude);
            return restaurant;

        }


    }
}
