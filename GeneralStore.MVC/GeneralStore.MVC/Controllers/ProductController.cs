﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GeneralStore.MVC.Models;

namespace GeneralStore.MVC.Controllers
{
    public class ProductController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        // Get: Product
        public ActionResult Create()
        {
            return View();
        }

        // Post : Product
        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _db.Products.Add(product);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(product);
        }
    }
}