using MyFirstMVCAppSCAGT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace MyFirstMVCAppSCAGT.Controllers
{
    public class UserController : Controller
    {
        // GET: User

        MyDBJMAAEntities MyDBJMAAEntities = new MyDBJMAAEntities();

        public ActionResult Index()
        {

            UserDemo userDemo = new UserDemo();

            ViewData["UserId"] = 2;

            var a = TempData["EmailId"];

            TempData.Keep("EmailId");


            //if (TempData.Keys["EmailId"])
            //{

            //}

            var getStudents = MyDBJMAAEntities.Students.ToList();

            //List<User> users = new List<User>()
            //{
            //    new User(){ UserId = 10, UserName = "Jigar" },
            //    new User(){ UserId = 11, UserName = "Jigar12" },
            //    new User(){ UserId = 12, UserName = "Jigar12" },
            //    new User(){ UserId = 13, UserName = "Jigar122" }

            //};    

            return View(getStudents);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {

            UserDemo users = new UserDemo();
            users.UserId = 1;
            users.UserName = "Avinash";

            List<SelectListItem> selectListItems = new List<SelectListItem>();

            selectListItems.Add(new SelectListItem
            {
                Text = "Jigar",
                Value = "1",
            });

            selectListItems.Add(new SelectListItem
            {
                Text = "Sandeep",
                Value = "2",
            });

            users.UserList = selectListItems;
            var getStudents = MyDBJMAAEntities.Students.ToList();

            ViewBag.UserList = getStudents;
            ViewBag.UserName = "Jigar";
            ViewBag.UserId = 2;
            ViewBag.Employee = "dasda";

            ViewData["UserList"] = getStudents;



            //ViewBag => Pass data controller to view without any casting
            //ViewData => Pass data controller to view you can do casting
            //TempData  => Pass data Controller to controller OR you can access the data in view as well



            return View(users);
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(UserDemo userDemo)
        {
            try
            {
                TempData["EmailId"] = userDemo.EmailId;
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        
        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
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

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
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
