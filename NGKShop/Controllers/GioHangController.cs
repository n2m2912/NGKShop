﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NGKShop.Models;

namespace NGKShop.Controllers
{
    public class GioHangController : Controller
    {
        
        // GET: GioHang
        public ActionResult Index()
        {
            return View();
        }
    }
}