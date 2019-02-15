using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ISCSystem.Controllers
{
    public class ExaminationSubjectsController : Controller
    {
        // GET: ExaminationSubjects
        public ActionResult Index()
        {
            ViewBag.Title = "Examination Subjects";
            return View();
        }
    }
}