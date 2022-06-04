using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using ChapeauDAL;

namespace ChapeauLogic
{
    public class MenuItemService
    {
        private MenuItemDao _menuItemDb;

        public MenuItemService()
        {
            _menuItemDb = new MenuItemDao();
        }

        public List<MenuItem> GetMenuItems()
        {
            List<MenuItem> menuItems = _menuItemDb.GetAllMenuItems();
            return menuItems;
        }

        public void AddMenuItem(MenuItem menuItem)
        {
            _menuItemDb.InsertMenuItem(menuItem);
        }

        public void DeleteMenuItem(int id)
        {
            _menuItemDb.DeleteMenuItem(id);
        }

        public void UpdateMenuItem(MenuItem menuItem)
        {
            _menuItemDb.UpdateMenuItem(menuItem);
        }
        public List<string> GetFoodCategory()
        {
           return _menuItemDb.GetFoodCategory();
        }
        public List<string> GetDrinkCategory()
        {
            return _menuItemDb.GetDrinkCategory();
        }
        public List<string> GetFoodType()
        {
            return _menuItemDb.GetFoodType();
        }
        public List<string> GetDrinkType()
        {
            return _menuItemDb.GetDrinkType();
        }
    }
}
