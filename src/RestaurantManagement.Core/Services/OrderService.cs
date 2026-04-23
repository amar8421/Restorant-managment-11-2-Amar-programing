using RestaurantManagement.Core.Models;
using RestaurantManagement.Data;
using RestaurantManagement.Data.Repositories;
using System;
using System.Collections.Generic;

namespace RestaurantManagement.Core.Services
{
    /// <summary>
    /// Shërbimi për menaxhimin e porosive
    /// </summary>
    public class OrderService
    {
        private OrderRepository _orderRepository;

        public OrderService()
        {
            var context = new DatabaseContext();
            _orderRepository = new OrderRepository(context);
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _orderRepository.GetAll();
        }

        public Order GetOrder(int orderId)
        {
            return _orderRepository.GetById(orderId);
        }

        public void CreateOrder(Order order)
        {
            if (order.TableId <= 0)
                throw new ArgumentException("Duhet të zgjidhet një tavolë");
            
            if (order.WaiterId <= 0)
                throw new ArgumentException("Duhet të zgjidhet një kamarieri");
            
            // Gjeneroni numrin e porosise
            order.OrderNumber = GenerateOrderNumber();
            order.Status = 1;  // New
            order.OrderDate = DateTime.Now;
            
            _orderRepository.Add(order);
        }

        public void UpdateOrder(Order order)
        {
            _orderRepository.Update(order);
        }

        public void CancelOrder(int orderId)
        {
            var order = _orderRepository.GetById(orderId);
            if (order != null)
            {
                order.Status = 5;  // Cancelled
                _orderRepository.Update(order);
            }
        }

        private string GenerateOrderNumber()
        {
            // Format: ORD-YYYYMMDD-HHMMSS
            return $"ORD-{DateTime.Now:yyyyMMdd-HHmmss}";
        }
    }
}
