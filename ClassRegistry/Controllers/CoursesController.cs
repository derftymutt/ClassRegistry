using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassRegistry.Controllers
{
    [RoutePrefix("courses")]
    public class CoursesController : Controller
    {
        [Route]
        public ActionResult Index()
        {
            return View();
        }
    }
}