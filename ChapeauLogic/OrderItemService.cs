using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class OrderItemService
    {
        private OrderItemDao _orderItemDao;

        public OrderItemService()
        {
            _orderItemDao = new OrderItemDao();
        }

        public List<OrderItem> GetAllOrders(int orderId)
        {
            return _orderItemDao.GetAllOrders(orderId);
        }

        public OrderItem GetSpecificOrder(int orderItemId)
        {
            return _orderItemDao.GetSpecificOrder(orderItemId);
        }

        public MenuItem GetCorrespondingMenuItem(int menuItemId)
        {
            return _orderItemDao.GetCorrespondingMenuItem(menuItemId);
        }

        public void InsertOrderItems(List<OrderItem> orderItems)
        {
            _orderItemDao.InsertOrderItem(orderItems);
        }

        public int SelectCountOfOrderItems(int orderId)
        {
            return _orderItemDao.SelectCountOfOrderItems(orderId);
        }

        public void UpdateOrderItemStatus(int orderItemId, Status status)
        {
            _orderItemDao.UpdateOrderItemStatus(orderItemId, status);
        }
    }
}
