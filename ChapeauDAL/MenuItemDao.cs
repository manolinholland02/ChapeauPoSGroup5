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
            SELECT [menuItemId],
            [menuItemName],
            [menuItemPrice],
            [isFoodOrDrink],
            [menuItemStock],
            [menuItemType],
            [menuItemCategory],
            [averagePreparationTime]
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
                    MenuItemType = (MenuType)Enum.Parse(typeof(MenuType), dr["menuItemName"].ToString()),
                    MenuItemCategory = (MenuItemCategory)Enum.Parse(typeof(MenuItemCategory), dr["menuItemCategory"].ToString()),
                   // AveragePreparationTime = dr
                };
                menuItems.Add(menuItem);
            }
            return menuItems;
        }

        private string MenuTypeToString(bool menuItemType)
        {
            if (menuItemType) return "food";
            else return "drink";
        }

        private SqlParameter[] GetParametersForMenuItem(MenuItem menuItem)
        {
            SqlParameter[] sqlParameters = { new SqlParameter("@Id", menuItem.MenuItemID), new SqlParameter("@Name", menuItem.MenuItemName), new SqlParameter("@Price", menuItem.MenuItemPrice), new SqlParameter("@FoodOrDrink", MenuTypeToString(menuItem.isFood)), new SqlParameter("@Stock", menuItem.MenuItemStock), new SqlParameter("@Type", menuItem.MenuItemType), new SqlParameter("@Category", menuItem.MenuItemCategory) };
            return sqlParameters;
        }

        public void InsertMenuItem(MenuItem menuItem)
        {
            string query = "INSERT INTO [dbo].[MenuItems] (menuItemId, menuItemName, menuItemPrice, isFoodOrDrink, menuItemStock, menuItemType, menuItemCategory) VALUES (@Id, @Name, @Price, @FoodOrDrink, @Stock, @Type, @Category)";
            ExecuteEditQuery(query, GetParametersForMenuItem(menuItem));
        }

        public void DeleteMenuItem(int id)
        {
            string query = $"DELETE FROM [dbo].[MenuItems] WHERE menuItemId = @Id";
            SqlParameter[] sqlParameters = { new SqlParameter("@Id", id)};
            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateMenuItem(MenuItem menuItem)
        {
            string query = $"UPDATE [dbo].[MenuItems] SET menuItemName = @Name, menuItemPrice = @Price, isFoodOrDrink = @FoodOrDrink, menuItemStock = @Stock, menuItemType = @Type, menuItemCategory = @Category  WHERE menuItemId = @Id";
            ExecuteEditQuery(query, GetParametersForMenuItem(menuItem));
        }
    }
}
