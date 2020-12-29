using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Anti_Corona.Data.Abstract;
using Anti_Corona.Entity;
using Microsoft.EntityFrameworkCore;

namespace Anti_Corona.Data.Concrete.EFCore
{
    public class EfCoreOrderRepository: EfCoreGenericRepository<OrderItem, AntiCoronaContext>, IOrderRepository
    {
        public List<OrderItem> GetOrders(string userId)
        {
            using (var context = new AntiCoronaContext())
            {
                var orders = context.OrderItems
                    .Include(i => i.Product).AsQueryable();
                if (!string.IsNullOrEmpty(userId))
                {
                    orders = orders.Where(i => i.UserId == userId);
                }
                return orders.ToList();

            }
        }
    }
}
