﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCJJ.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult result (ProductsController model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }


            return RedirectToAction("Index");

        }

           
    }
}