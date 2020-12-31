using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Anti_Corona.Entity
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
