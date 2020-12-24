using System;
using System.Collections.Generic;
using System.Text;

namespace Anti_Corona.Entity
{
    public class Image
    {
        public int ImageId { get; set; }
        public string ImageUrl { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
