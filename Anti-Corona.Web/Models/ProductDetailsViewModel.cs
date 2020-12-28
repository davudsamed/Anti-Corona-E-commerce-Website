using Anti_Corona.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace Anti_Corona.Web.Models
{
    public class ProductDetailsViewModel
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public List<Image> Images { get; set; }
        public List<Comment> Comments { get; set; }

    }
}
