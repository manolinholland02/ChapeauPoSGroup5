using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using ChapeauModel;

namespace ChapeauDAL
{
    public class OrdersDao : BaseDao
    {
        public List<Orders> OrderItems = new List<Orders>();
        private List<MenuItem> menuItems;

        public OrdersDao()
        {
            MenuItemDao menuItemDao = new MenuItemDao();
            menuItems = menuItemDao.GetAllMenuItems();
        }

        public List<Orders> GetAllOrders()
        {
            string query = @$"
            SELECT [orderId], [orderTable], [orderItem], [itemQuantity], [orderComment], [orderPrice], [orderStatus], [orderWaiter], [orderPreparer], [orderPayment]
            FROM [dbo].[Orders]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void InsertNewOrder(List<Orders> NewOrders)
        {
            foreach (Orders order in NewOrders)
            {
                string query = $"INSERT INTO dbo.Orders (orderTable, orderItem, itemQuantity, orderComment, orderPrice, orderStatus, orderWaiter, orderPreparer, orderPayment) VALUES(@OrderTable, @OrderItem, @Quantity, @Comment, @Price, @Status, @Waiter, @Preparer, @Payment)";
                SqlParameter[] sqlParameters =
                {
                    new SqlParameter("@OrderTable", order.OrderTable),
                    new SqlParameter("@OrderItem", order.MenuItem.MenuItemID),
                    new SqlParameter("@Quantity", order.ItemQuantity),
                    new SqlParameter("@Comment", order.OrderComment),
                    new SqlParameter("@Price", order.OrderPrice),
                    new SqlParameter("@Status", order.OrderStatus),
                    new SqlParameter("@Waiter", order.OrderWaiter),
                    new SqlParameter("@Preparer", order.OrderPreparer),
                    new SqlParameter("@Payment", order.OrderPayment)

                };
                ExecuteEditQuery(query, sqlParameters);
            }
        }

        string CheckForComment(string value)
        {
            if (value == "NULL")
                return "";
            else
                return value;
        }

        private List<Orders> ReadTables(DataTable dataTable)
        {
            foreach (DataRow dr in dataTable.Rows)
            {
                Orders OrderItem = new Orders()
                {
                    OrderID = (int)dr["orderId"],
                    OrderTable = (int)dr["orderTable"],
                    ItemQuantity = (int)dr["itemQuantity"],
                    OrderComment = CheckForComment(dr["orderComment"].ToString()),
                    OrderStatus = (Status)Enum.Parse(typeof(Status), dr["orderStatus"].ToString()),
                    OrderWaiter = (int)dr["orderWaiter"],
                    OrderPreparer = (int)dr["orderPreparer"],
                    OrderPayment = (int)dr["orderPayment"],
                    MenuItem = GetCorrespondingMenuItem((int)dr["orderItem"])
                };
                OrderItems.Add(OrderItem);
            }
            return OrderItems;
        }

        private MenuItem GetCorrespondingMenuItem(int menuItemId)
        {
            foreach(MenuItem item in menuItems)
            {
                if (item.MenuItemID == menuItemId) return item;
            }

            throw new Exception("There is no such menu item cooresponding to that order.");
        }

        /*public DataTable GetFood()
        {
            string query = @"
            SELECT CAST(Orders.itemQuantity AS VARCHAR) + ' x ' + MenuItems.menuItemName AS [Order] , Orders.orderComment AS [Comment]
            FROM Orders
            JOIN MenuItems ON Orders.orderItem = MenuItems.menuItemId
            WHERE MenuItems.isFoodOrDrink = 'food';";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ExecuteSelectQuery(query, sqlParameters);
        }*/

        public List<Orders> GetFoodOnlyOrders(List<Orders> orders)
        {
            List<Orders> foodOnlyOrders = new List<Orders>();
            foreach(Orders order in orders)
            {
                if (order.MenuItem.isFood)
                    foodOnlyOrders.Add(order);
            }

            return foodOnlyOrders;
        }
    }
}
