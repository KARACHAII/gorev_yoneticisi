using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using GorevYoneticisi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace GorevYoneticisi.Controllers
{
    public class UserController : Controller

    {


        private PlanManager pm = new PlanManager(new EfPlanRepository());

        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult UserNavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult UserNavbarTopPartial()
        {
            return PartialView();
        }
        [HttpGet]
        public IActionResult AddDailySchedule()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddDailySchedule(Plan p)
        {

            var ua = User.Identity.Name;
            Context c = new Context();
            var ub = c.Userdb.Where(x => x.UserName == ua).Select(y => y.UserID).FirstOrDefault();
            p.UserID = ub;
            p.PlanCreateDate = DateTime.Now;
            p.PlanStatus = true;
            pm.TAdd(p);

            return View();
        }
        [HttpGet]
        public IActionResult AddWeeklySchedule()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddWeeklySchedule(Plan p)
        {

            var ua = User.Identity.Name;
            Context c = new Context();
            var ub = c.Userdb.Where(x => x.UserName == ua).Select(y => y.UserID).FirstOrDefault();

            p.UserID = ub;
            p.PlanCreateDate = DateTime.Now;
            p.PlanStatus = true;
            pm.TWeekAdd(p);

            return View();
        }

        [HttpGet]
        public IActionResult AddMonthlySchedule()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMonthlySchedule(Plan p, DateTime timee)
        {

            var ua = User.Identity.Name;
            Context c = new Context();
            var ub = c.Userdb.Where(x => x.UserName == ua).Select(y => y.UserID).FirstOrDefault();

            p.PlanDay = p.PlanDay.AddMinutes(timee.Minute);
            p.PlanDay = p.PlanDay.AddHours(timee.Hour);
            p.UserID = ub;
            p.PlanCreateDate = DateTime.Now;
            p.PlanStatus = true;
            pm.TMonthAdd(p);

            return View();
        }

    }


}


