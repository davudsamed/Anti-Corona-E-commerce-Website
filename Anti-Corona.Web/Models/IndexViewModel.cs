using Anti_Corona.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anti_Corona.Web.Models
{
    public class IndexViewModel
    {
        public List<Anti_Corona.Entity.Product> products { get; set; }
        public List<Category> categories { get; set; }

    }
}
