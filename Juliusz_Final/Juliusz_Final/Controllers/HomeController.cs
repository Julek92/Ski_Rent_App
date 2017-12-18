using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Juliusz_Final.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string Time = DateTime.Now.ToString("F");
            return View("Index", Time);
        }

    }
}
