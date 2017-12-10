using SPCS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SPCS.Models;

namespace SPCS.Controllers
{
    [Authorize]
    public class DashboardsController : Controller
    {
        private SPCSContext db = new SPCSContext();

        public ActionResult Index()
        {
            if (User.IsInRole("Admin"))
            {
                return RedirectToAction("Admin");
            }
            else if (User.IsInRole("Manager"))
            {
                return RedirectToAction("Manager");
            }
            else if (User.IsInRole("Staff"))
            {
                return RedirectToAction("Staff");
            } 
            return View();
        }

        [Authorize(Roles = "Staff, Admin")]
        public ActionResult Staff()
        {
            int staffID = Int32.Parse(User.Identity.Name);
            List<ShiftInstance> allMyShiftsToday = db.ShiftInstances.Where(x => x.AssignedStaffID == staffID).ToList();
            ViewBag.NoOfShifts = allMyShiftsToday.Count;

            return View(allMyShiftsToday);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Admin()
        {
            return View();
        }
    }
}