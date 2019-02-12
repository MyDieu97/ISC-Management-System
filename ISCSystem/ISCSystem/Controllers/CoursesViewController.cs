using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ISCSystem.Controllers
{
    public class CoursesViewController : Controller
    {
        // GET: CoursesView
        public ActionResult Index()
        {
            return View();
        }
    }
}