using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using ChapeauDAL;

namespace ChapeauLogic
{
    public class LunchMenuService
    {
        private LunchMenuDao _lunchMenuDb;

        public LunchMenuService()
        {
            _lunchMenuDb = new LunchMenuDao();
        }

        public List<LunchMenu> GetLunchMenuItems()
        {
            List<LunchMenu> lunchMenuItems = _lunchMenuDb.GetLunchMenuItems();
            return lunchMenuItems;
        }

        public List<LunchMenu> GetSpecificLunchMenu(MenuItemCategory menuItemCategory)
        {
            List<LunchMenu> specificLunchMenu = _lunchMenuDb.GetSpecificLunchMenu(menuItemCategory);
            return specificLunchMenu;
        }
    }
}
