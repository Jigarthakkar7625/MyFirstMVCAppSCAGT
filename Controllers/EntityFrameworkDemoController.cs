using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVCAppSCAGT.Controllers
{
    public class EntityFrameworkDemoController : Controller
    {

        // GET: EntityFrameworkDemo
        public ActionResult Index()
        {
            //MyDBJMAAEntities MyDBJMAAEntities = new MyDBJMAAEntities();

            //return RedirectToAction("Index");

            //Pagination
            // Pagination : Jquery Datatable

            using (var MyDBJMAAEntitiesobj = new MyDBJMAAEntities()) // Using
            {
                // We are not getting EmpJimmies records

                var abc = MyDBJMAAEntitiesobj.DepartmentIDs.Find(1);

                MyDBJMAAEntitiesobj.DepartmentIDs.Remove(abc);


                // User_Address user = new User_Address();
                //user.Address = "Address new Nw New";
                //user.UserId = 11;
                //MyDBJMAAEntitiesobj.User_Address.Add(user);

                //MyDBJMAAEntitiesobj.SaveChanges();

                var abcd = MyDBJMAAEntitiesobj.ChangeTracker;

                foreach (var item in abcd.Entries())
                {
                    var Name= item.Entity.GetType().Name;
                    var FullName = item.Entity.GetType().FullName; // Table
                    var State = item.State;
                }



                //MyDBJMAAEntitiesobj.SaveChanges();

                //var abc = MyDBJMAAEntitiesobj.Database.ExecuteSqlCommand("insert into [User] values (12,'Thakkar123',1,50,'IT',4)"); // Inline query 


                //var getUser123 = MyDBJMAAEntitiesobj.DepartmentIDs.ToList();

                //var DepartmentIDObj = getUser123[0];

                // Lazy loading
                //var empJimmy = DepartmentIDObj.EmpJimmies;


                var getUser = MyDBJMAAEntitiesobj.Users.ToList();

                //Create


                //User_Address user = new User_Address();
                //user.Address = "Address new Nw New";
                //user.UserId = 11;
                //MyDBJMAAEntitiesobj.User_Address.Add(user);

               

                //MyDBJMAAEntitiesobj.SaveChanges();

                Student student = new Student();
                student.StudentName = "Hello Brother";
                student.CourseId = 6;
                MyDBJMAAEntitiesobj.Students.Add(student);


                MyDBJMAAEntitiesobj.SaveChanges();

                //Console.WriteLine(user.User_Address_ID);

                //Update

                //var getReord = MyDBJMAAEntitiesobj.User_Address.Where(x => x.User_Address_ID == 2002).FirstOrDefault();
                //MyDBJMAAEntitiesobj.User_Address.Remove(getReord);



                MyDBJMAAEntitiesobj.SaveChanges();

            }

            // CRUD : Create, Read, Update, Delete

            // Read




            //EF
            // ASP.NET frmework : 4.8 >>> Database first approach >> EDMX

            // ASP.NET core frmework : 4.8 >>> Database first approach.
            // EFCore : 

            // Entity Framework : 
            // ORM >> Object relational Mapping >> 
            // SQL : 

            // VVVVVMMMMM : 
            // 1. Database first approach
            // We have alrady Database : and then create models based on Database. 





            // 2. Code first approach






            return View();
        }

        // GET: EntityFrameworkDemo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EntityFrameworkDemo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EntityFrameworkDemo/Create
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

        // GET: EntityFrameworkDemo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EntityFrameworkDemo/Edit/5
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

        // GET: EntityFrameworkDemo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EntityFrameworkDemo/Delete/5
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
