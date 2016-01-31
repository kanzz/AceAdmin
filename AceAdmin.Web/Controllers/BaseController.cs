﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AceAdmin.Web.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        public ActionResult NavigatorBar()
        {
            return PartialView("NavigatorBarContainer");
        }

        public ActionResult NavigatorBarList()
        {
            return PartialView("NavigatorBarList");
        }
    }
}