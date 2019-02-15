using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ISCSystem.Controllers
{
    public class TestResultsController : Controller
    {
        // GET: TestResults
        public ActionResult Index()
        {
            ViewBag.Title = "Test Results";
            return View();
        }
        public ActionResult PageScoreList()
        {
            ViewBag.Title = "PageScoreList";
            return View();
        }
    }
}