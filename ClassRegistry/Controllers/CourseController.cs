using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassRegistry.Controllers
{
    public class CourseController : Controller
    {
        // GET: Courses
        public ActionResult Index()
        {
            return View();
        }
    }
}