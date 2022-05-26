using System;
using System.Collections.Generic;
using System.Text;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    class OrdersService
    {
        private OrdersDao _orderDao;

        public OrdersService()
        {
            _orderDao = new OrdersDao();
        }

        public List<Orders> GetOrders()
        {
            return _orderDao.GetAllOrders();
        }

        public void InsertNewOrder(List<Orders> NewOrders)
        {
            _orderDao.InsertNewOrder(NewOrders);
        }

        public List<Orders> GetFoodOnlyOrders(List<Orders> orders)
        {
            return _orderDao.GetFoodOnlyOrders(orders);
        }

        public System.Data.DataTable GetFood()
        {
            return _orderDao.GetFood();
        }
    }
}
