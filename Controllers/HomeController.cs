using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstApp.Domain;

namespace FirstApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly KittyContext _context;
        public HomeController(KittyContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var kitty = new Kitty();
            kitty.Name = "Boba";
            _context.Kitties.Add(kitty);
            _context.SaveChanges();

            var first = _context.Kitties.First();
            return Content(first.Name);
        }
    }
}
