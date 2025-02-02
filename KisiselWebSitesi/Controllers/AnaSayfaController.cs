﻿using KisiselWebSitesi.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KisiselWebSitesi.Controllers
{
    public class AnaSayfaController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.AnaSayfa.ToList();
            return View(deger);
        }

        public PartialViewResult ikonlar()
        {
            var deger = c.ikonlar.ToList();
            return PartialView(deger);
        }
    }
}