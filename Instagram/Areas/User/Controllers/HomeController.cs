using Instagram.Areas.User.Models;
using Instagram.DB;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Instagram.Areas.User
{
    [Area("User")]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext context;

        public HomeController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            IndexViewModel model = new IndexViewModel()
            {
                Posts = context.Posts.ToList(),
                Users = context.Entities.ToList()
            };
            return View(model);
        }
    }
}
