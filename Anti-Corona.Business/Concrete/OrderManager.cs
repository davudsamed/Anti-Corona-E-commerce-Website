using System;
using System.Collections.Generic;
using System.Text;
using Anti_Corona.Business.Abstract;
using Anti_Corona.Data.Abstract;
using Anti_Corona.Entity;

namespace Anti_Corona.Business.Concrete
{
    public class OrderManager : IOrderService
    {
        private IOrderRepository _orderRepository;
        public OrderManager(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public void Create(OrderItem entity)
        {
            _orderRepository.Create(entity);
        }

        public void Update(OrderItem entity)
        {
            _orderRepository.Update(entity);
        }

        public void Delete(OrderItem entity)
        {
            _orderRepository.Delete(entity);
        }

        public List<OrderItem> GetOrders(string userId)
        {
            return _orderRepository.GetOrders(userId);
        }

        public void AddToOrder(OrderItem orderItem)
        {
            if (orderItem!=null)
            {
                _orderRepository.Create(orderItem);
            }
        }

        public double GetTotalGain()
        {
            return _orderRepository.GetTotalGain();
        }

        public List<OrderItem> GetLastSalersProduct()
        {
            return _orderRepository.GetLastSalersProduct();
        }
    }
}
