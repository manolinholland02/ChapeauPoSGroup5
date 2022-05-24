using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    class DinnerMenuService
    {
        private DinnerMenuDao _dinnerMenuDb;

        public DinnerMenuService()
        {
            _dinnerMenuDb = new DinnerMenuDao();
        }

        public List<DinnerMenu> GetDinnerMenuItems()
        {
            List<DinnerMenu> dinnerMenuItems = _dinnerMenuDb.GetDinnerMenuItems();
            return dinnerMenuItems;
        }
    }
}

