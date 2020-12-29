using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anti_Corona.Web.Models
{
    public class OrderItemModel : ProductModel
    {
        public int Quantity { get; set; }
    }

    public class OrderItemsViewModel
    {
        public List<OrderItemModel> orderItems;
        public double total { get; set; }
    }

}
