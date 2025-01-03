using Microsoft.AspNetCore.Mvc;
using projBDwAI.Models.Context;
using projBDwAI.Models;
using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace projBDwAI.Controllers
{
    public class BugsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BugsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.PriorityList = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(_context.Priorities.ToList(), "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Bug bug)
        {
            if (!ModelState.IsValid)
            {
                System.Diagnostics.Debug.WriteLine("ModelState is invalid.");
                foreach (var entry in ModelState)
                {
                    System.Diagnostics.Debug.WriteLine($"Key: {entry.Key}, State: {entry.Value.ValidationState}");
                    foreach (var error in entry.Value.Errors)
                    {
                        System.Diagnostics.Debug.WriteLine($"Error: {error.ErrorMessage}");
                    }
                }

                // Repopulate the dropdown
                ViewBag.PriorityList = new SelectList(_context.Priorities.ToList(), "Id", "Name");
                return View(bug);
            }

            bug.CreatedDate = DateTime.Now;
            _context.Bugs.Add(bug);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
