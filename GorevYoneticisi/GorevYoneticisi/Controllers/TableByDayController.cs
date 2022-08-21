using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GorevYoneticisi.Controllers
{
    
    public class TableByDayController : Controller
    {

        PlanManager pm = new PlanManager(new EfPlanRepository());
        public IActionResult Index()
        {
            return View();
        }
      
        public IActionResult ToDoList(DateTime datee)
        {
            var day = datee.Date;
            ViewBag.dayName = datee.ToString("D");
            var ua = User.Identity.Name;
            Context c = new Context();
            var ub = c.Userdb.Where(x => x.UserName == ua).Select(y => y.UserID).FirstOrDefault();
            var plans = pm.GetListWithUserIDByPlan(ub);
            List<Plan> vPlans = new List<Plan>();
            foreach (var item in plans) { if (item.PlanDay.Date==day) { vPlans.Add(item); } }

            return View("ToDoList",vPlans);
        }

        public IActionResult DeletePlan(int id)
        {

            var planvalue = pm.TGetById(id);
            pm.TDelete(planvalue);
            var day = planvalue.PlanDay.Date;
            ViewBag.dayName = planvalue.PlanDay.ToString("D");
            var ua = User.Identity.Name;
            Context c = new Context();
            var ub = c.Userdb.Where(x => x.UserName == ua).Select(y => y.UserID).FirstOrDefault();
            var plans = pm.GetListWithUserIDByPlan(ub);
            List<Plan> vPlans = new List<Plan>();
            foreach (var item in plans) { if (item.PlanDay.Date == day) { vPlans.Add(item); } }

            return View("ToDoList",vPlans);
        }
        [HttpGet]
        public IActionResult EditPlan(int id)
        {
            var planvalue=pm.TGetById(id);
            var day = planvalue.PlanDay.Date;
            ViewBag.dayName = planvalue.PlanDay.ToString("D");
            ViewBag.dayTime = planvalue.PlanDay.ToString("t");
            return View(planvalue);
        }
        [HttpPost]
        public IActionResult EditPlan(Plan p)
        {
            var planvalue = pm.TGetById(p.PlanID);
            p.PlanStatus=planvalue.PlanStatus;
            p.PlanCreateDate=planvalue.PlanCreateDate;
            p.PlanID=planvalue.PlanID;
            p.UserID = planvalue.UserID; 
            pm.TUpdate(p);
          
            var day = planvalue.PlanDay.Date;
            ViewBag.dayName = planvalue.PlanDay.ToString("D");
            var plans = pm.GetListWithUserIDByPlan(planvalue.UserID);
            List<Plan> vPlans = new List<Plan>();
            foreach (var item in plans) { if (item.PlanDay.Date == day) { vPlans.Add(item); } }

            return View("ToDoList", vPlans);
        }

    }
}
