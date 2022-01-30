﻿using Instagram.DB;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Instagram.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext context;

        public UserController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult UserPanel()
        {
            return View();
        }
    }
}
