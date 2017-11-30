using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Juliusz_Final.Context;
using Juliusz_Final.Models;
using Microsoft.AspNetCore.Mvc;


namespace Juliusz_Final.Controllers
{
    public class CustomerController : Controller
    {
        private EFCDbContext _context { get;}

        public CustomerController(EFCDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var customers = _context.Customers.ToList();
            return View("Customers", customers);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Customers.Add(customer);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var customer = _context.Customers.Single(x => x.ID == id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Update(customer);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        [HttpGet]
        public IActionResult Remove(int id)
        {
            var customer = _context.Customers.Single(x => x.ID == id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult ConfirmRemove(int id)
        {
            var customer = _context.Customers.Single(x => x.ID == id);
            _context.Remove(customer);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
