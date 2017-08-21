using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TestProject.Models.Account
{
    public class UpdateRestaurantEmployeeModel
    {
        [Required]
        public string employeeName { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        public string phoneContactNum { get; set; }

        [Required]
        public string homeContactNum { get; set; }

        [Required]
        public string status { get; set; }

    }
}