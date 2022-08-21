using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Plan
    {
        [Key]
        public int PlanID { get; set; }
        public string PlanTitle { get; set; }
        public string PlanContent { get; set; }
        public DateTime PlanCreateDate { get; set; }
        public DateTime PlanDay { get; set; }
        public bool PlanStatus { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
       



    }
}
