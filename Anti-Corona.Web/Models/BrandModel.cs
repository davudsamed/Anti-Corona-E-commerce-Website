using Anti_Corona.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anti_Corona.Web.Models
{
    public class BrandModel
    {
        public int BrandId { get; set; }
        public string Name { get; set; }
        public List<Product> products { get; set; }
    }
}
