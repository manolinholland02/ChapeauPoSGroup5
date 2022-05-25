using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauLogic;

namespace ChapeauUI
{
    public partial class DrinksMenuForm : Form
    {
        private MenuItemCategory _category;
        private List<ListView> _listViews;

        public DrinksMenuForm()
        {
            InitializeComponent();
            _category = MenuItemCategory.softdrink;
            _listViews =  new List<ListView>();
            _listViews.Add(SoftDrinksListView);
            _listViews.Add(BeersListView);
            _listViews.Add(WineListView);
            _listViews.Add(SpiritsListView);
            _listViews.Add(CoffeeTeaListView);
            PopulateDrinkMenus();
        }

        private void AddDrinksbtn_Click(object sender, EventArgs e)
        {

        }

        private void BackDrinksbtn_Click(object sender, EventArgs e)
        {
            //show choosing order form
            this.Close();
        }

        private void PopulateDrinkMenus()
        {
            DrinksMenuService drinksMenuService = new DrinksMenuService();
            List<DrinkMenu> drinkMenuItems = new List<DrinkMenu>();

            int i = 0;
            while(_category <= MenuItemCategory.caffeinated)
            {
                _listViews[i].Items.Clear();
                drinkMenuItems = drinksMenuService.GetSpecificDrinksMenu(_category);
                FillMenu(drinkMenuItems, _listViews[i]);
                _category++;
                i++;
            }
        }

        private void FillMenu(List<DrinkMenu> drinkMenuItems, ListView listView)
        {
            foreach (DrinkMenu drinkMenu in drinkMenuItems)
            {
                string[] output = { drinkMenu.DrinkMenuId.ToString(), drinkMenu.MenuItemName };
                ListViewItem item = new ListViewItem(output);
                listView.Items.Add(item);
            }
        }
    }
}
