using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LegacyECommerce.Web.Controllers
{
    public class BackendController : Controller
    {
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult ManageCategory()
        {
            return View();
        }
    }
}