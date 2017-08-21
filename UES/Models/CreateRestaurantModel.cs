﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UES.Models
{
    public class CreateRestaurantModel
    {
        [Required]
        public string restaurantName { get; set; }

        [Required]
        public string personInCharge { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string personInChargeEmail { get; set; }

        [Required]
       // [RegularExpression(@"\d{8}", ErrorMessage = "Phone Number must be 8 digits")]
        public int personInChargeContact { get; set; }

        [Required]
        public string address { get; set; }

        [Required]
        public string region { get; set; }   //need to do in drob down list

        [Required]
        public string postalCode { get; set; }

        [Required]
        public string contactNo { get; set; }

        
        [Required]
        public int accountLimit { get; set; }

    }
}