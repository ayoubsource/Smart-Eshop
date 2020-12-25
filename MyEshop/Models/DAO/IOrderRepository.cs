using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyEshop.Models.Entities;

namespace MyEshop.Models.DAO
{
    interface IOrderRepository
    {
        IEnumerable<Order> GetAllOrders();
        Order GetById(int id);
        void Create(Order order);
        void Update(Order oldOrderInfo, Order newOrderInfo);
        void Delete(Order order);
    }

    public class OrderManager : IOrderRepository
    {
        private readonly SmartEshopDbContext _smartEshopDbContext;

        public OrderManager(SmartEshopDbContext smartEshopDbContext)
        {
            _smartEshopDbContext = smartEshopDbContext;
        }
        
        public IEnumerable<Order> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public Order GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Create(Order order)
        {
            throw new NotImplementedException();
        }

        public void Update(Order oldOrderInfo, Order newOrderInfo)
        {
            throw new NotImplementedException();
        }

        public void Delete(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
