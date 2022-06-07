using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;

namespace ChapeauDAL
{
    public class DrinksMenuDao : BaseDao
    {
        public List<DrinkMenu> GetDrinkMenuItems()
        {
            string query = @"
            SELECT drinkItemId, menuItemName
            FROM [dbo].DrinkMenu
            JOIN [dbo].MenuItems ON DrinkMenu.menuItemId = MenuItems.menuItemId;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<DrinkMenu> GetSpecificDrinksMenu(MenuItemCategory menuItemCategory)
        {
            string query = @$"
            SELECT drinkItemId, DrinkMenu.menuItemId, menuItemName
            FROM [dbo].DrinkMenu
            JOIN [dbo].MenuItems ON DrinkMenu.menuItemId = MenuItems.menuItemId
			WHERE MenuItems.menuItemCategory = @Category;";
            SqlParameter[] sqlParameters = { new SqlParameter("@Category", menuItemCategory.ToString()) };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<DrinkMenu> ReadTables(DataTable dataTable)
        {
            List<DrinkMenu> drinkMenus = new List<DrinkMenu>();

            foreach (DataRow dr in dataTable.Rows)
            {
                DrinkMenu drinkMenu = new DrinkMenu()
                {
                    DrinkMenuId = (int)dr["drinkItemId"],
                    MenuItemId = (int)dr["menuItemId"],
                    MenuItemName = dr["menuItemName"].ToString()
                };
                drinkMenus.Add(drinkMenu);
            }
            return drinkMenus;
        }
    }
}
