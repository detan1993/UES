using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TestProject.Models.Account
{
    public class UpdateRestaurantEmployeeModel
    {
        
        public string employeeName { get; set; }

        
        public string email { get; set; }

        
        public string phoneContactNum { get; set; }

        
        public string homeContactNum { get; set; }

        public string status { get; set; }

    }
}