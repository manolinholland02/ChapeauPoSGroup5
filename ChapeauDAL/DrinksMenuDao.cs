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
    class DrinksMenuDao : BaseDao
    {
        public List<DrinkMenu> GetDrinkMenuItems()
        {
            string query = @"
            SELECT DrinkItemID, menuItemName
            FROM [dbo].DrinkMenu
            JOIN [dbo].MenuItems ON DrinkMenu.menuItemID = MenuItems.menuItemId;
            ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<DrinkMenu> ReadTables(DataTable dataTable)
        {
            List<DrinkMenu> drinkMenus = new List<DrinkMenu>();

            foreach (DataRow dr in dataTable.Rows)
            {
                DrinkMenu drinkMenu = new DrinkMenu()
                {
                    DrinkMenuId = (int)dr["DrinkItemID"],
                    MenuItemName = dr["menuItemName"].ToString()
                };
                drinkMenus.Add(drinkMenu);
            }
            return drinkMenus;
        }
    }
}
