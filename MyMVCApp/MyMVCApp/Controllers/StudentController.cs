using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMVCApp.BLL.BLL;
using MyMVCApp.Models.Models;

namespace MyMVCApp.Controllers
{
    public class StudentController : Controller
    {
        StudentManager _studentManager =new StudentManager();
        private Student _student = new Student();
        
        // GET: Student
        public ActionResult Add()
        {
            _student.ID = 101;
            _student.Name = "Ali";
            _studentManager.Add(_student);

            return View();
        }
    }
}