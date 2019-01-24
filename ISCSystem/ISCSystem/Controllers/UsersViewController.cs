using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ISCSystem.Controllers
{
    public class UsersViewController : Controller
    {
        // GET: UsersView
        public ActionResult Index()
        {
            return View();
        }
    }
}