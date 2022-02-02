using Instagram.DB;
using Instagram.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Instagram.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext context;

        public LoginController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Entity entity)
        {
            var ent = context.Entities.FirstOrDefault(i => i.Email == entity.Email && i.Password == entity.Password);
            if (ent != null)
            {
                if (ent.Discriminator == "Admin") return Redirect("/Admin/Admin/Index");
                else if (ent.Discriminator == "User") return Redirect("/User/Home/Index");
            }
            return RedirectToAction(nameof(Login));
        }
    }
}
