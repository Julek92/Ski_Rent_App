using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Juliusz_Final.Context;
using Microsoft.AspNetCore.Mvc;


namespace Juliusz_Final.Controllers
{
    public class RentController : Controller
    {
        private EFCDbContext _context { get; }

        public RentController(EFCDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View("Rents");
        }
    }
}
