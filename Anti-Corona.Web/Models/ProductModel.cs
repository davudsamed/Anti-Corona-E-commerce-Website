using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anti_Corona.Web.Models
{
    public class ProductModel
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public int ProductId { get; set; }
    }
}