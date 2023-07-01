using System;
using System.Collections.Generic;
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
        [Route("Index/{employeeID=1}")]
        public ActionResult Index(int? employeeID)
        {
            

            //ViewBag.userId = userId;
            ViewBag.employeeID = employeeID;
            return View();
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
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
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
