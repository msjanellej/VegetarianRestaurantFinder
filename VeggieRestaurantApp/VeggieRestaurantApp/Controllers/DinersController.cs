using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
            var diners = _context.Diners;
            var id = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var diner = diners.Where(c => c.IdentityUserId == id).SingleOrDefault();

            if (diner == null)
            {
                return RedirectToAction("Create");

            }
            return View(diner);
        }

        // GET: Diners/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diner = _context.Diners.Where(d => d.Id == id).SingleOrDefault();
            if (diner == null)
            {
                return NotFound();
            }

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
            var dinersOnList = _context.Diners.ToList();
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var veganDiner = _context.Diners.Where(c => c.IdentityUserId ==
            userId).SingleOrDefault();
            if (diner == null)
            {
                return NotFound();
            }
            dinersOnList.Add(veganDiner);
            return View("Index"); ;
        }

        // GET: Diners/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var dinerssOnList = _context.Diners.ToList();
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var diner = _context.Diners.Where(c => c.IdentityUserId ==
            userId).SingleOrDefault();
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

                return RedirectToAction("Details", "Diners");
            }
            catch
            {
                return View();
            }
        }

        // GET: Diners/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var diner = _context.Diners.Where(d => d.Id == id).SingleOrDefault();
            if (diner == null)
            {
                return NotFound();
            }

            return View(diner);
        }

        // POST: Diners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id, Diner diner)
        {
            try
            {
                _context.Remove(diner);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
            
        }

    }
}
