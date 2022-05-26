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

        public List<Orders> GetAllOrders()
        {
            string query = @$"
            SELECT [orderId], [orderTable], [orderItem], [itemQuantity], [orderComment], [orderPrice], [orderStatus], [orderWaiter], [orderPreparer], [orderPayment], MenuItems.menuItemName AS [orderItemName], MenuItems.isFoodOrDrink AS [FoodOrDrink]
            FROM [dbo].[Orders]
            JOIN MenuItems ON Orders.orderItem = MenuItems.menuItemId";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void InsertNewOrder(List<Orders> NewOrders)
        {
            foreach (Orders Order in NewOrders)
            {
                string query = $"INSERT INTO dbo.Orders (orderTable, orderItem, orderItemName, itemQuantity, orderComment, orderPrice, orderStatus, orderWaiter, orderPreparer, orderPayment) VALUES('{Order.orderTable}', {Order.orderItem}, {Order.orderItemName}, {Order.ItemQuantity}, {Order.orderComment}, {Order.orderPreparer}, {Order.orderStatus}, {Order.orderWaiter}, {Order.orderPreparer},{Order.orderPayment} )";
                SqlParameter[] sqlParameters = new SqlParameter[0];
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
                    orderID = (int)dr["orderId"],
                    orderTable = (int)dr["orderTable"],
                    orderItem = (int)dr["orderItem"],
                    orderItemName = dr["orderItemName"].ToString(),
                    ItemQuantity = (int)dr["itemQuantity"],
                    orderComment = CheckForComment(dr["orderComment"].ToString()),
                    orderPrice = (decimal)dr["orderPrice"],
                    orderStatus = (Status)Enum.Parse(typeof(Status), dr["orderStatus"].ToString()),
                    orderWaiter = (int)dr["orderWaiter"],
                    orderPreparer = (int)dr["orderPreparer"],
                    orderPayment = (int)dr["orderPayment"],
                    FoodOrDrink = dr["FoodOrDrink"].ToString()
                };
                OrderItems.Add(OrderItem);
            }
            return OrderItems;
        }

        public DataTable GetFood()
        {
            string query = @"
            SELECT CAST(Orders.itemQuantity AS VARCHAR) + ' x ' + MenuItems.menuItemName AS [Order] , Orders.orderComment AS [Comment]
            FROM Orders
            JOIN MenuItems ON Orders.orderItem = MenuItems.menuItemId
            WHERE MenuItems.isFoodOrDrink = 'food';";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ExecuteSelectQuery(query, sqlParameters);
        }

        public List<Orders> GetFoodOnlyOrders(List<Orders> orders)
        {
            List<Orders> foodOnlyOrders = new List<Orders>();
            foreach(Orders order in orders)
            {
                if (order.FoodOrDrink == "food")
                    foodOnlyOrders.Add(order);
            }

            return foodOnlyOrders;
        }
    }
}
