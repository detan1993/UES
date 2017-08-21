using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UES.Models.Account
{
    public class CreateUpgrownEmployeeModel
    {
        [Required]
        public int employeedId { get; set; }

        [Required]
        public string employeeName { get; set; }

        [Required]
        public string passwordHashed { get; set; }

        [Required]
        public char gender { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string email { get; set; }

        [Required]
        public string phoneContactNo { get; set; }

        [Required]
        public string homeContactNo { get; set; }

        public string nextOfKinName { get; set; }
        public string nextOfKinContact { get; set; }
        public string nextOfKinRS { get; set; }

        [Required]
        public string role { get; set; }

        [Required]
        public string status { get; set; }

        [Required]
        public DateTime updatedDate { get; set; }

        [Required]
        public string updatedBy { get; set; }
    }
}