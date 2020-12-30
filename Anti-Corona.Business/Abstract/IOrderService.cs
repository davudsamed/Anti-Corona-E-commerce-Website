using System;
using System.Collections.Generic;
using System.Text;
using Anti_Corona.Entity;

namespace Anti_Corona.Business.Abstract
{
    public interface IOrderService
    {
        void Create(OrderItem entity);
        void Update(OrderItem entity);
        void Delete(OrderItem entity);
        List<OrderItem> GetOrders(string userId);
        void AddToOrder(OrderItem orderItem);
        double GetTotalGain();
        List<OrderItem> GetLastSalersProduct();
    }
}
