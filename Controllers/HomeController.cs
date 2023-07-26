using MyFirstMVCAppSCAGT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVCAppSCAGT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // cs + html
            // HTML
            //return PartialView("https://www.showit.tech/");

            User user = new User();
            user.UserId = 10;
            user.UserName = "Jigar";

            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}