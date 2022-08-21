using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class PlanManager : IPlanService
    {
        IPlanDal _planDal;

        public PlanManager(IPlanDal planDal)
        {
            _planDal = planDal;
        }
        public List<Plan> GetList()
        {
            return _planDal.GetListAll();
        }

        public void TAdd(Plan t)
        {
            _planDal.Insert(t);
        }

        public void TDelete(Plan t)
        {
            _planDal.Delete(t);
        }

        public Plan TGetById(int id)
        {
            return _planDal.GetByID(id);
        }

        public void TUpdate(Plan t)
        {
            _planDal.Update(t);
        }



        public void TWeekAdd(Plan t)
        {
            for (var i = 0; i < 7; i++)
            {
                if (DayOfWeek.Monday == t.PlanDay.DayOfWeek) { break; }
                else { t.PlanDay=t.PlanDay.AddDays(-1); }
            }
            for (var i = 0; i < 7; i++)
            {
                if (i == 0) { t.PlanDay = t.PlanDay; }
                else { t.PlanDay = t.PlanDay.AddDays(1); }
                _planDal.Insert(t);
                t.PlanID = 0;
            }
        }

        public void TMonthAdd(Plan t)
        {
            DateTime tt = t.PlanDay;
            TimeSpan ts = t.PlanDay.AddMonths(1) - tt;

            for (var i = 0; i < ts.Days; i++)
            {
                if (i == 0) { t.PlanDay = t.PlanDay; }
                else { t.PlanDay = t.PlanDay.AddDays(1); }
                _planDal.Insert(t);
                t.PlanID = 0;
            }
        }

        public List<Plan> GetListWithUserIDByPlan(int id)
        {
            return _planDal.GetListWithUserIDByPlan(id);
        }
    }
}
