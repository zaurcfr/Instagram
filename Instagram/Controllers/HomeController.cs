using Instagram.DB;
using Instagram.Entities;
using Instagram.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Instagram.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            //context.Entities.Add(new Admin
            //{
            //    Name = "Zaur",
            //    Surname = "Cafarov",
            //    Username = "zaurcfr",
            //    Email = "zaur@gmail.com",
            //    Password = "zaur"
            //});
            //context.Entities.Add(new User
            //{
            //    Name = "Ayxan",
            //    Surname = "Axundov",
            //    Username = "ayxan",
            //    Email = "ayxan@gmail.com",
            //    Password = "ayxan"
            //});
            //context.SaveChanges();
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
