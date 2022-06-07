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

        public List<MenuItem> GetMenuItemByID(int id)
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
            FROM [dbo].[MenuItems] WHERE [menuItemId] = @Id";
            SqlParameter[] sqlParameters = { new SqlParameter("@Id", id) };
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
                    MenuItemType = (MenuType)Enum.Parse(typeof(MenuType), dr["menuItemType"].ToString()),
                    MenuItemCategory = (MenuItemCategory)Enum.Parse(typeof(MenuItemCategory), dr["menuItemCategory"].ToString()),
                    AveragePreparationTime = dr["averagePreparationTime"].ToString()

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
            SqlParameter[] sqlParameters = {
                new SqlParameter("@Id", menuItem.MenuItemID),
                new SqlParameter("@Name", menuItem.MenuItemName),
                new SqlParameter("@Price", menuItem.MenuItemPrice),
                new SqlParameter("@FoodOrDrink", MenuTypeToString(menuItem.isFood)),
                new SqlParameter("@Stock", menuItem.MenuItemStock),
                new SqlParameter("@Type", menuItem.MenuItemType),
                new SqlParameter("@Category", menuItem.MenuItemCategory),
                new SqlParameter("@AverageTime", menuItem.AveragePreparationTime) };
            return sqlParameters;
        }

        public void InsertMenuItem(MenuItem menuItem)
        {
            string query = "INSERT INTO [dbo].[MenuItems] (menuItemId, menuItemName, menuItemPrice, isFoodOrDrink, menuItemStock, menuItemType, menuItemCategory, averagePreparationTime) VALUES (@Id, @Name, @Price, @FoodOrDrink, @Stock, @Type, @Category, @AverageTime)";
            ExecuteEditQuery(query, GetParametersForMenuItem(menuItem));
        }

        public void DeleteMenuItem(int id)
        {
            string query = $"DELETE FROM [dbo].[MenuItems] WHERE menuItemId = @Id";
            SqlParameter[] sqlParameters = { new SqlParameter("@Id", id) };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateMenuItem(MenuItem menuItem)
        {
            string query = $"UPDATE [dbo].[MenuItems] SET menuItemName = @Name, menuItemPrice = @Price, isFoodOrDrink = @FoodOrDrink, menuItemStock = @Stock, menuItemType = @Type, menuItemCategory = @Category, averagePreparationTime = @AverageTime WHERE menuItemId = @Id";
            ExecuteEditQuery(query, GetParametersForMenuItem(menuItem));
        }
        public List<string> GetFoodCategory()
        {
            string query = "SELECT DISTINCT menuItemCategory FROM [dbo].[MenuItems] WHERE isFoodOrDrink = 'food';";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return GetCategory(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<string> GetDrinkCategory()
        {
            string query = "SELECT DISTINCT menuItemCategory FROM [dbo].[MenuItems] WHERE isFoodOrDrink = 'drink';";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return GetCategory(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<string> GetFoodType()
        {
            string query = "SELECT DISTINCT menuItemType FROM [dbo].[MenuItems] WHERE isFoodOrDrink = 'food';";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return GetType(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<string> GetDrinkType()
        {
            string query = "SELECT DISTINCT menuItemType FROM [dbo].[MenuItems] WHERE isFoodOrDrink = 'drink';";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return GetType(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<string> GetCategory(DataTable dataTable)
        {
            List<string> categories = new List<string>();
            string menuItemCategory = "";

            foreach (DataRow dr in dataTable.Rows)
            {

                menuItemCategory = dr["menuItemCategory"].ToString();
                categories.Add(menuItemCategory);

            }
            return categories;
        }
        private List<string> GetType(DataTable dataTable)
        {
            List<string> types = new List<string>();
            string menuItemType = "";

            foreach (DataRow dr in dataTable.Rows)
            {

                menuItemType = dr["menuItemType"].ToString();
                types.Add(menuItemType);

            }
            return types;
        }
    }
}
