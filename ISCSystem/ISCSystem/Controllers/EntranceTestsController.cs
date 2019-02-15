using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ISCSystem.Controllers
{
    public class EntranceTestsController : Controller
    {
        // GET: EntranceTests
        public ActionResult Index()
        {
            ViewBag.Title = "Entrance Test";
            return View();
        }
    }
}