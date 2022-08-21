using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfPlanRepository : GenericRepository<Plan>, IPlanDal
    {
        public List<Plan> GetListWithUserIDByPlan(int id)
        {
            using (var c = new Context())
            {
                return c.Plandb.Where(x => x.UserID == id).ToList();
            }
        }
    }
}
