using System;
using System.Collections.Generic;
using System.Text;

namespace Anti_Corona.Entity
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Description { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
