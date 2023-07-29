using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVCAppSCAGT.Areas.admin.Controllers
{

    public class UserManagementController : Controller
    {
        // GET: admin/UserManagement
        public ActionResult Index()
        {
            return View();
        }

        // GET: admin/UserManagement/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: admin/UserManagement/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: admin/UserManagement/Create
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

        // GET: admin/UserManagement/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: admin/UserManagement/Edit/5
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

        // GET: admin/UserManagement/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: admin/UserManagement/Delete/5
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
