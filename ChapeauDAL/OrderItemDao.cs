using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauDAL
{
    public class OrderItemDao : BaseDao
    {
        private List<MenuItem> menuItems;

        public OrderItemDao()
        {
            MenuItemDao menuItemDao = new MenuItemDao();
            menuItems = menuItemDao.GetAllMenuItems();
        }

        public List<OrderItem> GetAllOrders(int orderId)
        {
            string query = @$"
            SELECT [orderItemId], [menuItem], [orderItemStatus], [orderItemComment], [orderItemQuantity], [orderId]
            FROM [dbo].[OrderItems]
            WHERE [orderId] = @OrderId;";
            SqlParameter[] sqlParameters = { new SqlParameter("@OrderId", orderId) };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public OrderItem GetSpecificOrder(int orderItemId)
        {
            string query = @$"
            SELECT [orderItemId], [menuItem], [orderItemStatus], [orderItemComment], [orderItemQuantity], [orderId]
            FROM [dbo].[OrderItems]
            WHERE [orderItemId] = @OrderItemId;";
            SqlParameter[] sqlParameters = { new SqlParameter("@OrderItemId", orderItemId) };
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            DataRow[] dr = dataTable.Select();
            OrderItem orderItem = new OrderItem()
            {
                OrderItemID = (int)dr[0]["orderItemId"],
                MenuItem = GetCorrespondingMenuItem((int)dr[0]["menuItem"]),
                Status = (Status)Enum.Parse(typeof(Status), dr[0]["orderItemStatus"].ToString()),
                Comment = CheckForComment(dr[0]["orderItemComment"].ToString()),
                Quantity = (int)dr[0]["orderItemQuantity"],
                Order = (int)dr[0]["orderId"]
            };

            return orderItem;
        }

        public MenuItem GetCorrespondingMenuItem(int menuItemId)
        {
            foreach (MenuItem item in menuItems)
            {
                if (item.MenuItemID == menuItemId) return item;
            }

            throw new Exception("There is no such menu item cooresponding to that order.");
        }

        string CheckForComment(string value)
        {
            if (value == "NULL")
                return "";
            else
                return value;
        }

        private List<OrderItem> ReadTables(DataTable dataTable)
        {
            List<OrderItem> orderItems = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem orderItem = new OrderItem()
                {
                    OrderItemID = (int)dr["orderItemId"],
                    MenuItem = GetCorrespondingMenuItem((int)dr["menuItem"]),
                    Status = (Status)Enum.Parse(typeof(Status), dr["orderItemStatus"].ToString()),
                    Comment = CheckForComment(dr["orderItemComment"].ToString()),
                    Quantity = (int)dr["orderItemQuantity"],
                    Order = (int)dr["orderId"]
                };
                orderItems.Add(orderItem);
            }
            return orderItems;
        }

        public void InsertOrderItem(List<OrderItem> orderItems)
        {
            string query = @"INSERT INTO [dbo].[OrderItems] (menuItem, orderItemStatus, orderItemComment, orderItemQuantity, orderId, orderItemStartTime)
            VALUES (@MenuItem, @Status, @Comment, @Quantity, @OrderId, @StartTime)";

            foreach(OrderItem orderItem in orderItems)
            {
                SqlParameter[] sqlParameters =
                {
                new SqlParameter("@MenuItem", orderItem.MenuItem.MenuItemID),
                new SqlParameter("@Status", orderItem.Status.ToString()),
                new SqlParameter("@Comment", orderItem.Comment),
                new SqlParameter("@Quantity", orderItem.Quantity),
                new SqlParameter("@OrderId", orderItem.Order),
                new SqlParameter("@StartTime", orderItem.StartTime)
                };

                ExecuteEditQuery(query, sqlParameters);
            }
        }

        public int SelectCountOfOrderItems(int orderId)
        {
            int result = 0;
            string query = @"
            SELECT COUNT(orderItemId) AS orderItemsCount
            FROM [dbo].[OrderItems]
            WHERE [orderId] = @OrderId;";
            SqlParameter[] sqlParameters = { new SqlParameter("@OrderId", orderId) };
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);
            foreach(DataRow dr in dataTable.Rows)
            {
                result = (int)dr["orderItemsCount"];
            }

            return result;
        }

        public void UpdateOrderItemStatus(int orderItemId, Status status)
        {
            string query = @"
            UPDATE [dbo].[OrderItems]
            SET [orderItemStatus] = @Status
            WHERE [orderItemId] = @OrderItemId;";
            SqlParameter[] sqlParameters = { new SqlParameter("@Status", status.ToString()), new SqlParameter("@OrderItemId", orderItemId) };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
