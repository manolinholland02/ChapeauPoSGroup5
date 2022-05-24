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
    public class DinnerMenuDao : BaseDao
    {
        public List<DinnerMenu> GetDinnerMenuItems()
        {
            string query = @"
            SELECT DinnerItemID, menuItemName
            FROM [dbo].DinnerMenu
            JOIN [dbo].MenuItems ON DinnerMenu.menuItemID = MenuItems.menuItemId;
            ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<DinnerMenu> GetSpecificDinnerMenu(string MenuType)
        {
            string query = @$"
            SELECT DinnerItemID, menuItemName
            FROM [dbo].DinnerMenu
            JOIN [dbo].MenuItems ON DinnerMenu.menuItemID = MenuItems.menuItemId
			WHERE MenuItems.menuItemCategory = '{MenuType}';
            ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<DinnerMenu> ReadTables(DataTable dataTable)
        {
            List<DinnerMenu> dinnerMenus = new List<DinnerMenu>();

            foreach (DataRow dr in dataTable.Rows)
            {
                DinnerMenu dinnerMenu = new DinnerMenu()
                {
                    DinnerMenuId = (int)dr["DinnerItemID"],
                    MenuItemName = dr["menuItemName"].ToString()
                };
                dinnerMenus.Add(dinnerMenu);
            }
            return dinnerMenus;
        }
    }
}
