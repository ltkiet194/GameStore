﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameStore.Controllers
{
    public class ForumController : Controller
    {
        // GET: Forum
        public ActionResult Forum()
        {
            ViewBag.TrangChu = 1;
            return View();
        }
    }
}