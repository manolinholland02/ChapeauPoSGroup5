using System;
using System.Collections.Generic;
using System.Text;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class OrderService
    {
        private OrderDao _orderDao;

        public OrderService()
        {
            _orderDao = new OrderDao();
        }

        public List<Order> GetOrders()
        {
            return _orderDao.GetAllOrders();
        }

        public void InsertNewOrder(Order order)
        {
            _orderDao.InsertNewOrder(order);
        }

        public void DeleteOrder(int orderId)
        {
            _orderDao.DeleteOrder(orderId);
        }

        public Order GetLastOrder(int tableId)
        {
            return _orderDao.GetLastOrder(tableId);
        }
    }
}
