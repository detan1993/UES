using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UES.Models.Account;

namespace UES.Controllers
{
    public class CreateUpgrownEmployeeController : Controller
    {
        // GET: CreateUpgrownEmployee
        public ActionResult CreateUpgrownEmployee()
        {
            return View();
        }

        [HttpPost]

        public ActionResult CreateUpgrownEmployee(CreateUpgrownEmployeeModel createUpgrownEmployeeModel)
        {
         
            //Check against model data annotation
            if (ModelState.IsValid)
            {
                //Can now be stored in database
            }
            else
            {
                //at least 1 data annotation failed in Model.DemoUser
            }

            return View(createUpgrownEmployeeModel);
        }
    }
}