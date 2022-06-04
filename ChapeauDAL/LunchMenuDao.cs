using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ChapeauModel;

namespace ChapeauDAL
{
    public class LunchMenuDao : BaseDao
    {
        public List<LunchMenu> GetLunchMenuItems()
        {
            string query = @"
            SELECT lunchItemId, LunchMenu.menuItemId, menuItemName
            FROM [dbo].LunchMenu
            JOIN [dbo].MenuItems ON LunchMenu.menuItemId = MenuItems.menuItemId;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<LunchMenu> GetSpecificLunchMenu(MenuItemCategory menuItemCategory)
        {
            string query = @$"
            SELECT lunchItemId, LunchMenu.menuItemId, menuItemName
            FROM [dbo].LunchMenu
            JOIN [dbo].MenuItems ON LunchMenu.menuItemId = MenuItems.menuItemId
			WHERE MenuItems.menuItemCategory = @Category;";
            SqlParameter[] sqlParameters = { new SqlParameter("@Category", menuItemCategory.ToString()) };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<LunchMenu> ReadTables(DataTable dataTable)
        {
            List<LunchMenu> lunchMenus = new List<LunchMenu>();

            foreach (DataRow dr in dataTable.Rows)
            {
                LunchMenu lunchMenu = new LunchMenu()
                {
                    LunchMenuId = (int)dr["lunchItemId"],
                    MenuItemId = (int)dr["menuItemId"],
                    MenuItemName = dr["menuItemName"].ToString()
                };
                lunchMenus.Add(lunchMenu);
            }
            return lunchMenus;
        }
    }
}
