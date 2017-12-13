using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Juliusz_Final.Context;
using Juliusz_Final.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace Juliusz_Final.Controllers
{
    public class ItemController : Controller
    {
        private EFCDbContext _context { get; }

        public ItemController(EFCDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var items = _context.Items.Include(x => x.Category).ToList();
            return View("Items", items);
        }

        public IActionResult ShowSelected(int id)
        {
            var items = _context.Items.Where(x => x.CategoryID == id).Include(x => x.Category);
            return View("Items", items);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var categories = _context.Categories.ToList();
            var selectListCategories = categories.Select(x => new SelectListItem()
            {
                Text = $"{x.Type}",
                Value = x.ID.ToString()
            });
            ViewBag.CategoryList = selectListCategories;
            return View();
        }

        [HttpPost]
        public IActionResult Add(Item item)
        {
            if (ModelState.IsValid)
            {
                _context.Items.Add(item);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(item);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var items = _context.Items.Single(x => x.ID == id);
            return View(items);
        }

        [HttpPost]
        public IActionResult Edit(Item item)
        {
            if (ModelState.IsValid)
            {
                _context.Update(item);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(item);
        }

        [HttpGet]
        public IActionResult Remove(int id)
        {
            var item = _context.Items.Include(x => x.Category).Single(x => x.ID == id);
            return View(item);
        }

        [HttpPost]
        public IActionResult ConfirmRemove(int id)
        {
            var item = _context.Items.Single(x => x.ID == id);
            _context.Remove(item);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
