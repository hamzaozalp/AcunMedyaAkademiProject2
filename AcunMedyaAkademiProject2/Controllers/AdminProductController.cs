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

        public ActionResult DeleteProduct(int id)
        {
            var value = context.Products.Find(id);
            context.Products.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ProductList");
        }

        [HttpGet]
        public ActionResult UpdateProduct(int id)
        {
            var value = context.Products.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateProduct(Product product)
        {
            var value = context.Products.Find(product.ProductId);
            value.ProductName = product.ProductName;
            value.Description = product.Description;
            value.Price = product.Price;
            value.ImageUrl = product.ImageUrl;
            context.SaveChanges();
            return RedirectToAction("ProductList");
        }


    }
}