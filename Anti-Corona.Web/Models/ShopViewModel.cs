using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Anti_Corona.Web.Models;


namespace Anti_Corona.Web.Models
{
    public class ShopViewModel
    {
        public  List<PopularProductModel> mostPopularProducts { get; set; }
        public List<ProductModel> products { get; set; }

    }
    


}
