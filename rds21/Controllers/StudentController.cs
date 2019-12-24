using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using rds21.Models;

namespace rds21.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        [HttpGet]
        public ActionResult StudentRegistration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult StudentRegistration(Student aStudent)
        {
            #region Password hashing

            aStudent.Password = Crypto.Hash(aStudent.Password);

            #endregion

            #region Save to Database

            using (RDSDatabaseEntities db=new RDSDatabaseEntities())
            {
                db.Students.Add(aStudent);
                db.SaveChanges();
            }
            return View();

            #endregion


            
        }
    }
}