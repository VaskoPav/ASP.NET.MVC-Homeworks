using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaAppHomework.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaAppHomework.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("razor/{id}")]
        public IActionResult RazorOrder(int? id)
        {
            var person = new User
            {
                Address = "Street 01",
                FirstName = "Vasko",
                LastName = "Vasko",
                Phone = 1234567
            };
            var order = new Order
            {
                Id = 10,
                Pizza = "Kapri",
                Price = 330,
                User = person,
                Delivered = false
            };
            if (id.HasValue)
            {
                return View(order);

            }
            return RedirectToAction("Index");
        }
        
    }
}
