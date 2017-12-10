using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using SPCS.Models;
using SPCS.DAL;

namespace SPCS.Controllers
{
    public class HomeController : Controller
    {
        private SPCSContext db = new SPCSContext();

        public ActionResult Login()
        {
            if (User.Identity.IsAuthenticated == true)
            {
                return RedirectToAction("Index", "Dashboards");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection form, bool rememberMe = false)
        {
            String username = form["Username"].ToString();
            String password = form["Password"].ToString();

            List<Staff> staffList = new List<Staff>();
            bool usernameFound = false;
            staffList = db.Staffs.ToList();

            foreach (Staff s in staffList)
            {
                if (s.Username == username)
                {
                    if (s.Password == password)
                    {
                        FormsAuthentication.SetAuthCookie(s.StaffID.ToString(), rememberMe);
                        Response.Cookies["firstname"].Value = s.FirstName;
                        Response.Cookies["lastname"].Value = s.LastName;
                        return RedirectToAction("Index", "Dashboards", new { role = s.Role });
                    }
                    else
                    {
                        ViewBag.Message = "Invalid Password.";
                    }
                    usernameFound = true;
                }
            }
            if (usernameFound != true)
            {
                ViewBag.Message = "Username not found.";
            }
            return View();
        }

        [Authorize]
        public ActionResult Logout()
        {
            if (User.Identity.IsAuthenticated == true)
            {
                FormsAuthentication.SignOut();
                return RedirectToAction("Login", "Home");
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
        }

        public ActionResult Unauthorized()
        {
            return View();
        }
    }
}