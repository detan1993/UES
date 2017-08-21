
using UES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UES.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult createRestaurantAccount()
        {
            CreateRestaurantModel create = new CreateRestaurantModel();
           // create.dropDownListRegion = "West Region";

            return View();
        }

        public ActionResult createRestaurantEmployee()
        {
            CreateRestaurantEmployee createrestaurantemployee = new CreateRestaurantEmployee();
            return View();
        }
    }
}