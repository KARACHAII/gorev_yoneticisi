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
    public class TodayController : Controller
    {
        PlanManager pm = new PlanManager(new EfPlanRepository());
        public IActionResult Index()
        {

            var day = DateTime.Now.Date;
            ViewBag.dayName = day.ToString("D");
            var ua = User.Identity.Name;
            Context c = new Context();
            var ub = c.Userdb.Where(x => x.UserName == ua).Select(y => y.UserID).FirstOrDefault();
            var plans = pm.GetListWithUserIDByPlan(ub);
            List<Plan> vPlans = new List<Plan>();
            foreach (var item in plans) { if (item.PlanDay.Date == day) { vPlans.Add(item); } }
            ViewBag.planListCount = vPlans.Count;
            return View(vPlans);
        }

        
    }
}
