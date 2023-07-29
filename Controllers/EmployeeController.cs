using MyFirstMVCAppSCAGT.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace MyFirstMVCAppSCAGT.Controllers
{

    public class EmployeeController : Controller
    {


        // ASP.NET MVC Filter >> 

        // 1. Authenticaiton Filters >> Credential is valid or not >>
        // 2. Authorization Filters >> Roles (Permissions) >>
        // 3. Action Filters >> Contoller level or Action level
        // 4. Error Filters >> 
        // 5. Result Filters >> 

        // Authorize()
        // OutputCache()
        // handleError()










        // Multiple inharitacne
        // Security
        // Reusablitity
        // Overriding


        // GET: Employee
        public ActionResult Index()
        {
            //int Male = (int)GENDER.Female;

            //int Female = (int)GENDER.Female;
            //string MaleString = GENDER.Female.ToString()   ;


            //int enumDesc = (int)GENDER.Female;
            //string enumName = GENDER.Female.ToString();

            //string enumDesc1 = GENDER.Female.DescriptionAttr();







            int b = 10; // Value data types
            UserDemo userDemo = new UserDemo();
            userDemo.UserName = "Jigar"; // Referece type



            var a = Session["USerId"].ToString();
            return View();
        }

        [HttpGet]
        public ActionResult CreateNew1(int UserId)
        {

            try
            {


                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult CreateNew(int UserId, UserDemo userDemo)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

    }
}