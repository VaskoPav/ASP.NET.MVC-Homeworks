using HomeworkClass04.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkClass04.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            var user = new NewOrderViewModel();

            user.FirstName = "";
            user.LastName = "";
            user.NamePizza = "";
            user.Size = 0;

            

            return View(user);
        }

        [HttpPost]
        public IActionResult Register(NewOrderViewModel user)
        {
            

            return RedirectToAction("Index", "Home");
        }
    }
}
