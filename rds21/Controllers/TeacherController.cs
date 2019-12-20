using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using rds21.Models;

namespace rds21.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        [HttpGet]
        public ActionResult TeacherRegistration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult TeacherRegistration(Teacher aTeacher)
        {
            using (RDSDatabaseEntities db = new RDSDatabaseEntities())
            {
                db.Teachers.Add(aTeacher);
                db.SaveChanges();
            }
            return View();
        }
    }
}