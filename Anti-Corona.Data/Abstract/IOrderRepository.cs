using System;
using System.Collections.Generic;
using System.Text;
using Anti_Corona.Entity;

namespace Anti_Corona.Data.Abstract
{
    public interface IOrderRepository : IRepository<OrderItem>
    {
        List<OrderItem> GetOrders(string userId);
        void Delete(OrderItem entity);
        void Update(OrderItem entity);
        void Create(OrderItem entity);
    }
}
