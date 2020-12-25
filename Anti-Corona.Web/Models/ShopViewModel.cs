using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anti_Corona.Web.Models
{
    public class ShopViewModel
    {
        public  List<PopularProduct> mostPopularProducts { get; set; }
        public List<Product> products { get; set; }
    }
    public class PopularProduct:Product
    {
        public string CategoryName { get; set; }
    }
    public class Product
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
    }

}
