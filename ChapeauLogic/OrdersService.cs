using System;
using System.Collections.Generic;
using System.Text;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    class OrdersService
    {
        private OrdersDao orderDao;

        public OrdersService()
        {
            orderDao = new OrdersDao();
        }

        public List<Orders> GetOrdersFromTableID(int TableNumber)
        {
            return orderDao.GetOrdersFromTableID(TableNumber);
        }

        public void InsertNewOrder(List<Orders> NewOrders)
        {
            orderDao.InsertNewOrder(NewOrders);
        }
    }
}
