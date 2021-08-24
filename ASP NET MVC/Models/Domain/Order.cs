using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaAppHomework.Models.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public User User { get; set; }
        public double Price { get; set; }
        public string Pizza { get; set; }
        public bool Delivered { get; set; }


        public string GetPriceRange()
        {
            if (Price > 1000)
            {
                return "$$$$";
            }
            else if (Price > 500 && Price < 1000)
            {
                return "$$$";
            }
            else if (Price > 100 && Price < 500)
            {
                return "$$";
            }
            else
            {
                return "$";
            }
        }
    }
}
