using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace TestProject.Models.Account
{
    public class CreateRestaurantEmployeeModel
    {
        public IEnumerable<SelectListItem> dropDownListRestaurant { get; set; }

        [Required]
        public int restaurantId { get; set; }

        [Required]
        public int employeeName { get; set; }

        [Required]
        public char gender { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string email { get; set; }

        [Required]
        public string phoneContactNum { get; set; }

        [Required]
        public string homeContactNum { get; set; }

        [Required]
        public string role { get; set; }

    }
}