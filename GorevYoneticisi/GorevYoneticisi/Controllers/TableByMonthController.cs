using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace GorevYoneticisi.Controllers
{
    public class TableByMonthController : Controller
    {
        PlanManager pm = new PlanManager(new EfPlanRepository());
        public IActionResult Index()
        {
           
            return View();
        }
        public IActionResult MonthList(DateTime datee)
        {
            DateTime tt = datee;
            TimeSpan ts = datee.AddMonths(1) - tt;
            var day = datee.Date;
            ViewBag.MonthName = datee.ToString("MMM");
            var ua = User.Identity.Name;
            Context c = new Context();
            var ub = c.Userdb.Where(x => x.UserName == ua).Select(y => y.UserID).FirstOrDefault();
            var plans = pm.GetListWithUserIDByPlan(ub);
            List<Plan> vPlans = new List<Plan>();
            for (int i = 0; i < ts.Days; i++)
            {
                foreach (var item in plans) { if (item.PlanDay.Date == day) { vPlans.Add(item); } }

                day = day.AddDays(1);
            }
            return View("MonthList", vPlans);
        }

       
    }
}
