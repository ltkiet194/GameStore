﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameStore.Controllers
{
    public class ChiTietController : Controller
    {
        // GET: ChiTiet
        public ActionResult Index()
        {
            ViewBag.TrangChu = 1;
            return View();
        }
    }
}