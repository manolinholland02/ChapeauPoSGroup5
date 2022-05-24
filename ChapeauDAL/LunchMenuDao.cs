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
            SELECT lunchItemID, menuItemName
            FROM [dbo].LunchMenu
            JOIN [dbo].MenuItems ON LunchMenu.menuItemID = MenuItems.menuItemId;
            ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<LunchMenu> ReadTables(DataTable dataTable)
        {
            List<LunchMenu> lunchMenus = new List<LunchMenu>();

            foreach (DataRow dr in dataTable.Rows)
            {
                LunchMenu lunchMenu = new LunchMenu()
                {
                    LunchMenuId = (int)dr["lunchItemID"],
                    MenuItemName = dr["menuItemName"].ToString()
                };
                lunchMenus.Add(lunchMenu);
            }
            return lunchMenus;
        }
    }
}
