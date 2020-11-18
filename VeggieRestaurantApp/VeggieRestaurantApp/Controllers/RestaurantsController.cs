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
            return View(restaurants);
        }

        // GET: RestaurantsController/Details/5
        public ActionResult Details(int id)
        {
            var restaurantsOnList = _context.Restaurants.ToList();
            var restaurant = _context.Restaurants.Where(c => c.Id == id).SingleOrDefault();
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
            return View(restaurant);
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

                return RedirectToAction("Details", restaurant);
            }
            catch
            {
                return View();
            }
        }

        // GET: RestaurantsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RestaurantsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
