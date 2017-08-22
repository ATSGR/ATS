using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATS.Controllers
{
    public class CheekInsController : Controller
    {
        // GET: CheekIns
        public ActionResult Create()
        {
            return View();
        }
    }
}