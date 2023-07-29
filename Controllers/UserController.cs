using MyFirstMVCAppSCAGT.Auth;
using MyFirstMVCAppSCAGT.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization.Json;
using System.Web;
using System.Web.Mvc;
using static System.Net.Mime.MediaTypeNames;



namespace MyFirstMVCAppSCAGT.Controllers
{
    
    public class User123Controller : Controller
    {
        // GET: User

        MyDBJMAAEntities1 MyDBJMAAEntities = new MyDBJMAAEntities1();

        public ActionResult Index()
        {

            // Entity Framework : 

            int numberOfObjectsPerPage = 2;
            int pageNumber = 5;


            //Skip(2 * (1-1)) // Skip(0)


            //var queryResultPage12 = MyDBJMAAEntities.Users.AsQueryable()
            //  .OrderBy(x => x.UserId).Skip(numberOfObjectsPerPage * (pageNumber - 1))
            //  .Take(numberOfObjectsPerPage);

            //var queryResultPage = MyDBJMAAEntities.Users.AsQueryable()
            //  .OrderBy(x => x.UserId).Skip(numberOfObjectsPerPage * (pageNumber - 1))
            //  .Take(numberOfObjectsPerPage).ToList();

            //IEnumerable<User> users1 = MyDBJMAAEntities.Users.
            //    Where(x => x.Department == "IT");  //this one is filter
            //users1 = users1.Take(3); // Filter

            //IQueryable<User> users2 = MyDBJMAAEntities.Users.AsQueryable().Where(x => x.Department == "IT");
            //users2 = users2.Take(3);




            // Partition Operator

            // Take
            // Skip
            // TakeWhile
            // SkipWhile


            var GetUserListALl = MyDBJMAAEntities.Users.ToList();

            //var GetUserList = MyDBJMAAEntities.Users.Where(x => x.Salary > 100).OrderByDescending(x => x.UserName).Take(4).ToList();

            var GetUserList = MyDBJMAAEntities.Users.AsEnumerable().TakeWhile(x => x.Salary > 50).ToList();

            var GetUserList232 = MyDBJMAAEntities.Users.OrderBy(x => x.UserName).Skip(4).ToList();

            var GetUserList323323 = MyDBJMAAEntities.Users.AsEnumerable().Where(x => x.Salary > 50).SkipWhile(x => x.Salary > 1999).ToList();



            //var getResult = (from U in MyDBJMAAEntities.Users
            //                 join UA in MyDBJMAAEntities.User_Address
            //                 on U.UserId equals UA.UserId
            //                 group U by new { U.Department } into g
            //                 select new
            //                 {
            //                     Department = g.Key.Department,
            //                     TotalSalary = g.Sum(t3 => t3.Salary)
            //                 }
            //                 ).ToList();

            //10 table
            //1 >> 
            //    2 >>

            //      3 >>
            //      3 >>


            //          4 >>
            //          4 >>


            // LINQ TO Entity Framework
            // 

            // linq >> entity >> DB >> Entity >> LINQ >> getResult
            var getResult = (from U in MyDBJMAAEntities.Users

                             join UA in MyDBJMAAEntities.User_Address
                             on U.UserId equals UA.UserId // Inner join

                             into RightTable //Temp table
                             from RightTableTemp in RightTable.DefaultIfEmpty()

                             select new
                             {
                                 Username = U.UserName,
                                 UserId = U.UserId,
                             }
                        ).ToList();







            //ALL() and ANy() : Bool >> True or False

            //List<string> auditLogs = new List<string>();

            //auditLogs.Add("jigar");
            //auditLogs.Add("Avinash");
            //auditLogs.Add("GAGAN");
            //auditLogs.Add("Sandip");

            //bool checkValue = auditLogs.Any(x => x.Contains("i"));





            List<User> users = new List<User>();

            User user = new User();
            user.Department = "ASP.NET";
            user.UserId = 1;
            user.UserName = "ASP.NET";
            user.Salary = 50000;

            //index = 0
            users.Add(user);

            User user1 = new User();
            user1.Department = "ASP.NET";
            user1.UserId = 1;
            user1.UserName = "ASP.NET";
            user1.Salary = 50000;


            users.Add(user1);

            User user2 = new User();
            user2.Department = "ASP.NET22";
            user2.UserId = 2;
            user2.UserName = "ASP.NET2";
            user2.Salary = 1200;

            //index = 1
            users.Add(user2);

            var disctictValue = (from s in users
                                 select s).Distinct();


            var WithOutdistict = users.ToList();
            var distict = users.Select(x => new { x.Department, x.UserId }).Distinct().ToList();


            List<int> salary = new List<int>() { 10, 50, 60, 600, 601, 602 };
            List<int> salary22 = new List<int>() { 10, 100, 120, 99, 601, 600 };
            salary22.Append(20).ToList();


            var except = salary22.Union(salary).ToList();



            var listofSalary = salary.ToList();
            var listofSalaryDistict = salary.Distinct().ToList();

            //var elementAt1 = salary.ElementAtOrDefault(10);
            //var elementAt = salary.ElementAt(10);


            // LINQ : Language-Integrated Query

            DataSet dataSet = new DataSet();

            // Collection : 
            MyDBJMAAEntities.AuditLogs.ToList();

            // Query Syntex
            //List<string> auditLogs = new List<string>();

            //auditLogs.Add("jigar");
            //auditLogs.Add("Avinash");
            //auditLogs.Add("GAGAN");
            //auditLogs.Add("Sandip");


            //var a = auditLogs.Contains("jigar");

            // QUery syntext
            // LINQ

            // then by is only possible in Method syntext
            //var result = (from s in MyDBJMAAEntities.AuditLogs
            //              orderby s.AuditLogId ascending
            //              select s).ToList();

            //var result = (from s in MyDBJMAAEntities.Users
            //              group s by s.Department).ToList();


            var result = (from s in MyDBJMAAEntities.Users
                          select new { UserId = s.UserId, UserName = s.UserName }).ToList();




            // SQL
            // Select * from auditLogs as sandeep where username like '%jig%'

            // Select * from auditLogs as sandeep where username like '%jig%'


            //var resultMethodSyntex = MyDBJMAAEntities.AuditLogs.Where(x=>x.abc123 == "jgar").ToList();
            //var resultMethodSyntex = MyDBJMAAEntities.AuditLogs.OrderByDescending(x => x.AuditLogId).ThenByDescending(x => x.Text).ToList();

            //var grpBy = MyDBJMAAEntities.Users.GroupBy(x => x.Department).ToList();

            // Iquery > 
            // IEnumarable > in Memory 


            //var abcd = MyDBJMAAEntities.Students.Where(x => x.StudentId == 4 && x.StudentName == "Anisha").OrderByDescending(x => x.StudentId).ThenBy(x => x.StudentName).Select(x => new { x.CourseId }).ToList();

            //var jkjkjk = true ? 0 : false;





            var getFirst12 = salary.LastOrDefault(); // 0

            var getFirst = salary.Last(); // ERROR



            //var count12344 = salary.Sum();

            //var count123445 = salary.Where(s => s % 2 == 0).Sum();


            var count = MyDBJMAAEntities.Users.Count(x => x.Department == "IT");
            var count123 = MyDBJMAAEntities.Users.Where(x => x.Department == "IT").Count();


            Student student = new Student() { StudentId = 4, StudentName = "Anisha" };

            var abc = MyDBJMAAEntities.Students.ToList();

            var A = abc.Contains(student, new StudentComparer());


            var userList = MyDBJMAAEntities.Users.Select(s => new { UserId = s.UserId, UserName = s.UserName }).ToList();

            //foreach (var group in grpBy)
            //{
            //    var getResult = group.ToList();

            //}

            // Method Syntex



            UserDemo userDemo = new UserDemo();

            ViewData["UserId"] = 2;

            var cc = TempData["EmailId"];

            TempData.Keep("EmailId");

            Session.Abandon();
            Session.Clear();

            Session["USerId"] = "10";

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

            //IEnumerable<User> users1 = MyDBJMAAEntities.Users.Where(x => x.UserName == "Jigar");
            //users1 = users1.ToList();  

            //IQueryable<User> users2 = MyDBJMAAEntities.Users.Where(x => x.UserName == "Jigar");
            //List<User> abcdd = users2.ToList();

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

            throw new Exception("My custom error");

            Session["USerId"] = "10";

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


        public ActionResult PartialViewRender()
        {

            Student student = new Student();
            student.Address = "JKigar Thafdfjds";

            return PartialView("_PartialVIew", student);
        }



        class StudentComparer : IEqualityComparer<Student>
        {
            public bool Equals(Student x, Student y)
            {
                if (x.StudentId == y.StudentId &&
                            x.StudentName.ToLower() == y.StudentName.ToLower())
                    return true;

                return false;
            }

            public int GetHashCode(Student obj)
            {
                return obj.GetHashCode();
            }
        }

    }
}
