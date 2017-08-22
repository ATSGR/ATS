using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATS.Controllers
{
    public class DashBoardsController : Controller
    {
        // GET: DashBoards
        public ActionResult Index()
        {
            return View();
        }
    }
}