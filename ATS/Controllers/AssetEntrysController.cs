using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATS.Controllers
{
    public class AssetEntrysController : Controller
    {
        // GET: AssetEntrys
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

        public PartialViewResult GetPartial()
        {
            return PartialView("~/Views/Shared/AssetEntry/_Finance.cshtml");
        }
        public PartialViewResult GetServicePartial()
        {
            return PartialView("~/Views/Shared/AssetEntry/_Service.cshtml");
        }

        public PartialViewResult GetAttachmentPartial()
        {
            return PartialView("~/Views/Shared/AssetEntry/_Attachment.cshtml");
        }

        public PartialViewResult GetNotesPartial()
        {
            return PartialView("~/Views/Shared/AssetEntry/_Notes.cshtml");
        }

        public PartialViewResult GetHistoryPartial()
        {
            return PartialView("~/Views/Shared/AssetEntry/_History.cshtml");
        }

        public ActionResult Search()
        {
            return View();
        }
    }
}