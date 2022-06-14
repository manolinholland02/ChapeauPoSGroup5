using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class DinnerMenuService
    {
        private S _dinnerMenuDb;

        public DinnerMenuService()
        {
            _dinnerMenuDb = new S();
        }

        public List<DinnerMenu> GetDinnerMenuItems()
        {
            List<DinnerMenu> dinnerMenuItems = _dinnerMenuDb.GetDinnerMenuItems();
            return dinnerMenuItems;
        }

        public List<DinnerMenu> GetSpecficDinnerMenu(MenuItemCategory menuItemCategory)
        {
            List<DinnerMenu> specificDinnerMenu = _dinnerMenuDb.GetSpecificDinnerMenu(menuItemCategory);
            return specificDinnerMenu;
        }
    }
}

