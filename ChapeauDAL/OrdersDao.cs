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
        public List<Orders> GetOrdersFromTableID(int TableNumber)
        {
            List<Orders> OrderFromTable = new List<Orders>();

            string query = @$"
            SELECT [orderId], [orderTable], [orderItem], [orderItemName], [itemQuantity], [orderComment], [orderPrice],
            FROM [dbo].[Orders]
            WHERE [orderTable] = {TableNumber}";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Orders> ReadTables(DataTable dataTable)
        {
            List<Orders> OrderItems = new List<Orders>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Orders OrderItem = new Orders()
                {
                    orderID = (int)dr["orderId"],
                    orderTable = (int)dr["orderTable"],
                    orderItem = (MenuItem)dr["orderItem"],
                    orderItemName = dr["orderItemName"].ToString(),
                    ItemQuantity = (int)dr["itemQuantity"],
                    orderComment = dr["orderComment"].ToString(),
                    orderPrice = (decimal)dr["orderPrice"],
                    orderStatus = (Status)dr["orderStatus"],
                    orderWaiter = (Employee)dr["orderWaiter"],
                    orderPreparer = (Employee)dr["orderPreparer"],
                    orderPayment = (Payment)dr["orderPayment"],
                };
                OrderItems.Add(OrderItem);
            }
            return OrderItems;
        }
    }
}
