using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using ChapeauDAL;

namespace ChapeauLogic
{
    public class LunchMenuLogic
    {
        private LunchMenuDao _lunchMenuDb;

        public LunchMenuLogic()
        {
            _lunchMenuDb = new LunchMenuDao();
        }

        public List<LunchMenu> GetLunchMenuItems()
        {
            List<LunchMenu> lunchMenuItems = _lunchMenuDb.GetLunchMenuItems();
            return lunchMenuItems;
        }

        public List<LunchMenu> GetSpecificLunchMenu(string MenuCategory)
        {
            List<LunchMenu> specificLunchMenu = _lunchMenuDb.GetSpecificLunchMenu(MenuCategory);
            return specificLunchMenu;
        }
    }
}
