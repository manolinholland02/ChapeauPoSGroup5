using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using ChapeauModel;

namespace ChapeauDAL
{
    public class OrderDao : BaseDao
    {
        public List<Order> orders;

        public OrderDao()
        {
            orders = new List<Order>();
        }

        public List<Order> GetAllOrders()
        {
            string query = @$"
            SELECT [orderId], [orderTable], [orderWaiter], [orderPayment], [orderPayed]
            FROM [dbo].[Orders]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void InsertNewOrder(Order order)
        {
            string query = "INSERT INTO [dbo].[Orders] (orderTable, orderWaiter, orderPayment, orderPayed) VALUES(@OrderTable, @Waiter, @Payment, @IsPaid)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@OrderTable", order.TableId),
                new SqlParameter("@Waiter", order.WaiterId),
                new SqlParameter("@Payment", order.PaymentId),
                new SqlParameter("@IsPaid", isPaidToInt(order.IsPaid))

            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DeleteOrder(int orderId)
        {
            string query = @"
            DELETE FROM [dbo].[Orders]
            WHERE [orderId] = @OrderId;";
            SqlParameter[] sqlParameters = { new SqlParameter("OrderId", orderId) };
            ExecuteEditQuery(query, sqlParameters);
        }

        public Order GetLastOrder(int tableId)
        {
            string query = @"
            SELECT TOP 1 [orderId], [orderTable], [orderWaiter], [orderPayment], [orderPayed]
            FROM [dbo].[Orders]
            WHERE [orderPayed] = 0 AND [orderTable] = @Table
            ORDER BY [orderId] DESC;";
            SqlParameter[] sqlParameters = { new SqlParameter("@Table", tableId) };
            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }

        private Order ReadTable(DataTable dataTable)
        {
            Order order = new Order();

            foreach (DataRow dr in dataTable.Rows)
            {
                order.OrderId = (int)dr["orderId"];
                order.TableId = (int)dr["orderTable"];
                order.PaymentId = (int)dr["orderPayment"];
                order.WaiterId = (int)dr["orderWaiter"];
                order.IsPaid = (bool)dr["orderPayed"];
            }
            return order;
        }

        //public void Delete

        private int isPaidToInt(bool isPaid)
        {
            if (isPaid) return 1;
            else return 0;
        }

        private List<Order> ReadTables(DataTable dataTable)
        {
            foreach (DataRow dr in dataTable.Rows)
            {
                Order OrderItem = new Order()
                {
                    OrderId = (int)dr["orderId"],
                    TableId = (int)dr["orderTable"],
                    WaiterId = (int)dr["orderWaiter"],
                    PaymentId = (int)dr["orderPayment"],
                    IsPaid = (bool)dr["orderPayed"]
                };
                orders.Add(OrderItem);
            }
            return orders;
        }
    }
}
