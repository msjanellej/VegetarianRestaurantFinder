using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            restaurant.IdentityUserId = userId;
            _context.Add(restaurant);
            _context.SaveChanges();
            return View("Index");
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
        public IActionResult SpecialsIndex(int id)
        {
            var specials = _context.RestaurantReviews.Where(r => r.RestaurantId == id).ToList();
            return View(specials);
        }
        public IActionResult EditSpecials(int id)
        {
            //var specials = _context.Menus.ToList();
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var restaurant = _context.Restaurants.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            var mySpecials = _context.Menus.Where(r => r.RestaurantId == restaurant.Id).ToList();
            var specialItem = _context.Menus.Where(c => c.Id == id).SingleOrDefault();
            if (specialItem == null)
            {
                return NotFound();
            }
            return View(specialItem);
        }
        // GET: RestaurantsController/Create
        public ActionResult CreateSpecials()
        {
            //var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            //var restaurant = _context.Restaurants.Where(c => c.IdentityUserId == userId).SingleOrDefault();
            //Menu menu = new Menu();
            //menu.RestaurantId = restaurant.Id;
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

            _context.Add(menu);
            _context.SaveChanges();
            return View("SpecialsIndex");
        }
        //public IActionResult ReviewerIndex()
        //{
        //    var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
        //    var restaurant = _context.Restaurants.Where(c => c.IdentityUserId == userId).SingleOrDefault();
        //    var reviews = _context.RestaurantReviews.Where(r => r.RestaurantId == restaurant.Id);
        //    var diners = reviews.Where
        //    return null;
        //}


    }
}
