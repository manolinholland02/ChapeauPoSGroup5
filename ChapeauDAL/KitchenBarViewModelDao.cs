using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using ChapeauModel;

namespace ChapeauDAL
{
    //I have already put try-catch block in the BaseDao class on the following methods:
    //OpenConnection()
    //ExecuteEditTranQuery()
    //ExecuteEditQuery()
    //ExecuteSelectQuery()
    //That is why I don't put try-catch in my methods: GetAllIncomingOrderItems(string menuItemType) and GetPastOrderItemsForToday(string menuItemType)
    public class KitchenBarViewModelDao : BaseDao
    {
        //Declaring static object of my Dao class
        private static KitchenBarViewModelDao _uniqueInstance;

        //Set the constructor to private
        private KitchenBarViewModelDao() { }

        //Using the Singleton design pattern I create a static method that ensures only one (unique) instance
        //of class KitchenBarViewModelDao can be created
        public static KitchenBarViewModelDao GetInstance()
        {
            if (_uniqueInstance == null) _uniqueInstance = new KitchenBarViewModelDao();

            return _uniqueInstance;
        }

        //Method to get all incoming (of status "preparing") order items from the database and add them to a list
        public List<KitchenBarViewModel> GetAllIncomingOrderItems(string menuItemType)
        {
            string query = @"
            SELECT orderItemId, CAST(orderItemQuantity AS VARCHAR) + ' x ' + MenuItems.menuItemName AS orderDesign, Orders.orderTable AS orderTable, orderItemComment, MenuItems.averagePreparationTime AS averageTime, orderItemStartTime, orderItemTimeElapsed 
            FROM [dbo].[OrderItems]
            JOIN [dbo].[Orders] ON OrderItems.orderId = Orders.orderId
            JOIN [dbo].[MenuItems] ON OrderItems.menuItem = MenuItems.menuItemId
            WHERE orderItemStatus = @Status
            AND MenuItems.isFoodOrDrink = @Type;";
            SqlParameter[] sqlParameters = {
                new SqlParameter("@Status", Status.preparing.ToString()),
                new SqlParameter("@Type", menuItemType)
            };

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        //Method to get all past (of status "ready" or "finished") order items of todays from the database and add them to a list
        public List<KitchenBarViewModel> GetPastOrderItemsForToday(string menuItemType)
        {
            string query = @"
            SELECT orderItemId, CAST(orderItemQuantity AS VARCHAR) + ' x ' + MenuItems.menuItemName AS orderDesign, Orders.orderTable AS orderTable, orderItemComment, MenuItems.averagePreparationTime AS averageTime, orderItemStartTime, orderItemTimeElapsed
            FROM [dbo].[OrderItems]
            JOIN [dbo].[Orders] ON OrderItems.orderId = Orders.orderId
            JOIN MenuItems ON OrderItems.menuItem = MenuItems.menuItemId
            WHERE MenuItems.isFoodOrDrink = @Type
            AND CAST([orderItemStartTime] AS DATE) = CAST(GETDATE() AS DATE)
            AND NOT [orderItemStatus] = @Status;";
            SqlParameter[] sqlParameters = {
                new SqlParameter("@Type", menuItemType),
                new SqlParameter("@Status", Status.preparing.ToString())
            };

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<KitchenBarViewModel> ReadTables(DataTable dataTable)
        {
            List<KitchenBarViewModel> orderItems = new List<KitchenBarViewModel>();

            foreach (DataRow dr in dataTable.Rows)
            {
                KitchenBarViewModel orderItem = new KitchenBarViewModel()
                {
                    OrderItemId = (int)dr["orderItemId"],
                    Name = dr["orderDesign"].ToString(),
                    TableOfOrder = (int)dr["orderTable"],
                    Comment = dr["orderItemComment"].ToString(),
                    AveragePreparationTime = (TimeSpan)dr["averageTime"],
                    StartTime = (DateTime)dr["orderItemStartTime"],
                    //Converting 
                    TimeElapsed = CheckForTimeSpanRecordInDB(dr["orderItemTimeElapsed"].ToString())
                };
                orderItems.Add(orderItem);
            }

            return orderItems;
        }

        //Method to convert time type from SQL Server to TimeSpan in C# (if there is one)
        private TimeSpan CheckForTimeSpanRecordInDB(string value)
        {
            //Since TimeSpan is non-nullable value type, I cannot return null, so I simply assign a default value of 00:00:00
            if (value == "") return new TimeSpan(00, 00, 00);
            else return TimeSpan.Parse(value);
        }

        //Method that updates the status of an OrderItem in the database and inserts the time elapsed for that order to be cooked
        public void SetOrderItemAsPrepared(int orderItemId, Status status, string timeElapsed)
        {
            string query = @"
            UPDATE [dbo].[OrderItems]
            SET [orderItemStatus] = @Status, [orderItemTimeElapsed] = @TimeElapsed
            WHERE [orderItemId] = @OrderItemId;";
            SqlParameter[] sqlParameters = { 
                new SqlParameter("@Status", status.ToString()), 
                new SqlParameter("@OrderItemId", orderItemId),
                new SqlParameter("@TimeElapsed", timeElapsed)
            };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
