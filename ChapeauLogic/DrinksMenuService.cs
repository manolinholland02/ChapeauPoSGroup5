using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    class DrinksMenuService
    {
        private DrinksMenuDao _drinkMenuDb;

        public DrinksMenuService()
        {
            _drinkMenuDb = new DrinksMenuDao();
        }

        public List<DrinkMenu> GetDrinkMenuItems()
        {
            List<DrinkMenu> drinkMenuItems = _drinkMenuDb.GetDrinkMenuItems();
            return drinkMenuItems;
        }
    }
}
