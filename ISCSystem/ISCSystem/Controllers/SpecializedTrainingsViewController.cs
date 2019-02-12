using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ISCSystem.Controllers
{
    public class SpecializedTrainingsViewController : Controller
    {
        // GET: SpecializedTraingsView
        public ActionResult Index()
        {
            ViewBag.Title = "Specialized Trainings";

            return View();
        }
    }
}