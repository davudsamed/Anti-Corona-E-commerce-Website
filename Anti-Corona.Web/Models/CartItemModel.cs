using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anti_Corona.Web.Models
{
    public class CartItemModel:ProductModel
    {
        public int Quantity { get; set; }
    }

   public class CartItemsViewModel
    {
        public List<CartItemModel> cartItems;
        public double total { get; set; }

    }
}
