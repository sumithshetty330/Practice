using MVCDataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCDataAccessLayer.Controllers
{
    public class AuthenticationController : Controller
    {
        // GET: Authentication
        public ActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        public ActionResult DoLogin(UserDetails u)
        {
            EmployeeBusinessLayer bal=new EmployeeBusinessLayer();
            if (bal.IsValidUser(u))
            {
                FormsAuthentication.SetAuthCookie(u.username, false);
                return RedirectToAction("Hello", "Employee");
            }
            else
            {
                ModelState.AddModelError("CredentialError", "Invalid Username or Password");
                return View("Login");
            }
        }
    }
}