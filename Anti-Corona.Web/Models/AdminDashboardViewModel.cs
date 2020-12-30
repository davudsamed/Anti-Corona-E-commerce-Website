using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anti_Corona.Web.Models
{
    public class AdminDashboardViewModel
    {
        public int UserCount { get; set; }
        public double Revenue { get; set; }
        public int ProductCount { get; set; }
        public List<OrderItemModel> lastSalersProduct { get; set; }
    }
}
