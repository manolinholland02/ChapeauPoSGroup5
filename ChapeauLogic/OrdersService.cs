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

        public List<Orders> GetOrdersFromTableID(int TableNumber)
        {
            return _orderDao.GetOrdersFromTableID(TableNumber);
        }

        public void InsertNewOrder(List<Orders> NewOrders)
        {
            _orderDao.InsertNewOrder(NewOrders);
        }
    }
}
