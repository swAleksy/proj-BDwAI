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
        public ActionResult Create()
        {
            ViewBag.PriorityList = new SelectList(_context.Priorities.ToList(), "Id", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Bug bug)
        {
            if (ModelState.IsValid)
            {
                bug.CreatedDate = DateTime.Now; 
                _context.Bugs.Add(bug); 
                _context.SaveChanges(); 
                return RedirectToAction("Index"); 
            }
            ViewBag.PriorityList = new SelectList(_context.Priorities.ToList(), "Id", "Name");
            return View(bug); // powrot do formularza 
        }
    }
}
