﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NFX.Web.Controllers
{
    public class RealTimeMonitorController : Controller
    {
        //
        // GET: /RealTimeMonitor/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HandleException()
        {
            return View();
        }

    }
}
