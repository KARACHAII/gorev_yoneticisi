using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;

namespace GorevYoneticisi.ViewComponents.TableByDay
{
    public class GetDate : ViewComponent
    {
        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }
        //public IViewComponentResult Invoke(DateTime date)
        //{

        //    PlanManager pm = new PlanManager(new EfPlanRepository());
        //    var ua = User.Identity.Name;
        //    Context c = new Context();
        //    var ub = c.Userdb.Where(x => x.UserName == ua).Select(y => y.UserID).FirstOrDefault();
        //    var uc = c.Plandb.Include(x => x.UserID == ub).Select(x => x.PlanDay == date).ToList();
        //    return View();
        //}
    }
}
