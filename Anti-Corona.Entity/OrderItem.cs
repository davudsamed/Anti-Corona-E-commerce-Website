using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Anti_Corona.Entity
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Note { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
