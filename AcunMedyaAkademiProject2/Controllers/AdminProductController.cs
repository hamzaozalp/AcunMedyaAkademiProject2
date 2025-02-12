using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiProject2.Entities;
using AcunMedyaAkademiProject2.Context;

namespace AcunMedyaAkademiProject2.Controllers
{
    public class AdminProductController : Controller
    {
        SweetContext context = new SweetContext();
        public ActionResult ProductList()
        {
            var values = context.Products.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return RedirectToAction("ProductList");
        }
    }
}