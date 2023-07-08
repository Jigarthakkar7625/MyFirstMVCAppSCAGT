using MyFirstMVCAppSCAGT.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVCAppSCAGT.Controllers
{
    [RoutePrefix("HelloNewURL")]
    public class UserNewController : Controller
    {
        // Server side validaiton // Controller side 
        // Client side validaiton // HTML level >> using Jquery


        // URL > Controller >> View

        // GET: UserNew
        // HelloNewURL/Index/1
        // HelloNewURL/Index
        //[Route("Index/{employeeID=1}")]
        [NonAction]
        public string Index(int? employeeID)
        {


            return "";
            ////ViewBag.userId = userId;
            //ViewBag.employeeID = employeeID;
            //return View();
        }


        // GET: UserNew/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserNew/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserNew/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index", "User");

                //return Content("Jigar THakkar");
                //return new EmptyResult();// View result
                // TODO: Add insert logic here

                //return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public FileResult ActionResultMethod()
        {

            return File(Url.Content("~/Download/JIGARBIRTHCERTIFICATE.pdf"), "application/pdf", "Name123.pdf");
            //return new EmptyResult();// View result
            // TODO: Add insert logic here

            //return RedirectToAction("Index");

        }

        public FileResult GetReport()
        {
            string ReportURL = "D:\\Jigar FrontEnd\\Jigar .NET fullstack\\SCAGT batch\\MyFirstMVCAppSCAGT\\Download\\JIGARBIRTHCERTIFICATE.pdf";
            byte[] FileBytes = System.IO.File.ReadAllBytes(ReportURL);
            return File(FileBytes, "application/pdf");
        }

        [HttpGet]
        public JavaScriptResult MyMESSSGAE()
        {
            var msg = "alert('Are you sure you want to delete!!')";
            return new JavaScriptResult() { Script = msg };

        }

        [HttpPost]
        public ActionResult JsonResultMethod(UserDemo user)
        {
            MyDBJMAAEntities MyDBJMAAEntities = new MyDBJMAAEntities();

            var getStudents = MyDBJMAAEntities.Users.ToList();

            //return RedirectToAction("","");

            return Json(getStudents, JsonRequestBehavior.AllowGet);

        }


        // GET: UserNew/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserNew/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UserNew/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserNew/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
