using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using ChapeauModel;


namespace ChapeauDAL
{
    public class MenuItemDao : BaseDao
    {
        public List<MenuItem> GetAllMenuItems()
        {
            string query = @"
            SELECT [menuItemId]
            ,[menuItemName]
            ,[menuItemPrice]
            ,[isFoodOrDrink]
            ,[menuItemStock]
            ,[menuItemType]
            ,[menuItemCategory]
            FROM [dbo].[MenuItems]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private bool CheckMenuType(Object value)
        {
            if (value.ToString() == "food") return true;
            else
            {
                return false;
            }
        }

        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem menuItem = new MenuItem()
                {
                    MenuItemID = (int)dr["menuItemId"],
                    MenuItemName = dr["menuItemName"].ToString(),
                    MenuItemPrice = (decimal)dr["menuItemPrice"],
                    isFood = CheckMenuType(dr["isFoodOrDrink"]),
                    MenuItemStock = (int)dr["menuItemStock"],
                    MenuItemType = (MenuType)dr["menuItemType"],
                    MenuItemCategory = (MenuItemCategory)dr["menuItemCategory"]
                };
                menuItems.Add(menuItem);
            }
            return menuItems;
        }

        public void InsertMenuItem(MenuItem menuItem)
        {
            int drinkType = (drink.Type) ? 1 : 0;
            string query = $"INSERT INTO [dbo].[MenuItems] (menuItemId, menuItemName, menuItemPrice, isFoodOrDrink, menuItemStock, menuItemType, menuItemCategory) VALUES ('{drink.Name}', {drink.Price}, {drink.Stock}, {drinkType})";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
