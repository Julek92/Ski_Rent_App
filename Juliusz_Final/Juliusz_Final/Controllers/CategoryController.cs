using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Juliusz_Final.Context;
using Juliusz_Final.Models;
using Microsoft.AspNetCore.Mvc;


namespace Juliusz_Final.Controllers
{
    public class CategoryController : Controller
    {
        private EFCDbContext _context { get; }

        public CategoryController(EFCDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var categories = _context.Categories.ToList();
            return View("Categories", categories);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Add(category);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var categories = _context.Categories.Single(x => x.ID == id);
            return View(categories);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Update(category);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }

        [HttpGet]
        public IActionResult Remove(int id)
        {
            var category = _context.Categories.Single(x => x.ID == id);
            return View(category);
        }

        [HttpPost]
        public IActionResult ConfirmRemove(int id)
        {
            var category = _context.Categories.Single(x => x.ID == id);
            _context.Remove(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
