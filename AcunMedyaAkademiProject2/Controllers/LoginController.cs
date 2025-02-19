﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AcunMedyaAkademiProject2.Context;
using AcunMedyaAkademiProject2.Entities;


namespace AcunMedyaAkademiProject2.Controllers
{
    public class LoginController : Controller
    {
        SweetContext context = new SweetContext();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin p)
        {
            var user = context.Admins.FirstOrDefault(x => x.Username == p.Username && x.Password == p.Password);

            if(user != null)
            {
               FormsAuthentication.SetAuthCookie(user.Username, true);
                Session["userInfo"] = user.Username;
                return RedirectToAction("CategoryList", "AdminCategory");
            }
            return View();
        }
    }
}