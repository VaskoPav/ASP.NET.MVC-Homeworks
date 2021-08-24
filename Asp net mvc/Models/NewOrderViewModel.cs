using HomeworkClass04.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkClass04.Models
{
    public class NewOrderViewModel
    {
        [Display(Name = "First name of user: ")]
        public string FirstName { get; set; }

        [Display(Name = "Last name of user: ")]
        public string LastName { get; set; }

        [Display(Name = "Name Of the Pizza ")]
        public string NamePizza { get; set; }

        [Display(Name = "Size Of the Pizza ")]
        public Size Size { get; set; }
    }
}
