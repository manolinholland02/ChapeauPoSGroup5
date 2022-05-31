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
        private List<Orders> _currentOrders;
        private int TableID;
        private Employee Waiter;
        public DrinksMenuForm(List<Orders> currentorders, int TableID, Employee waiter)
        {
            InitializeComponent();
            _category = MenuItemCategory.softdrink;
            _listViews =  new List<ListView>();
            _currentOrders = currentorders;
            _listViews.Add(SoftDrinksListView);
            _listViews.Add(BeersListView);
            _listViews.Add(WineListView);
            _listViews.Add(SpiritsListView);
            _listViews.Add(CoffeeTeaListView);
            PopulateDrinkMenus();
            this.TableID = TableID;
            this.Waiter = waiter;
        }

        private void AddDrinksbtn_Click(object sender, EventArgs e)
        {
            //check if only one is selected
            Orders order = CheckSelectedItems();
            if (order != null)
            {
                MenuItemService menuservice = new MenuItemService();
                List<MenuItem> menuItems = menuservice.GetMenuItems();
                order.OrderComment = DrinksCommentSection.Text;
                foreach (MenuItem item in menuItems)
                {
                    if (item.MenuItemID == order.MenuItem.MenuItemID)
                    {
                        
                        order.MenuItem.MenuItemName = item.MenuItemName;
                        order.OrderStatus = Status.processing;
                    }
                }
                //order.table
                //order waiter
                //order preparer
                //order payment

                _currentOrders.Add(order);
                //order counter +1
            }

            DrinksCommentSection.Clear();
            foreach (ListView listView in _listViews)
            {
                listView.SelectedItems.Clear();
            }
        }
        private Orders CheckSelectedItems()
        {
            int count = 0;
            Orders item = new Orders();
            Orders emptyitem = new Orders();
            foreach (ListView listViews in _listViews)
            {

                if (listViews.SelectedItems.Count == 1)
                {
                    count++;
                    item.MenuItem.MenuItemID = int.Parse(listViews.SelectedItems[0].Text);
                }

            }
            if (count == 1)
            {
                return item;
            }
            else
            {
                MessageBox.Show("Select only one item");
                return emptyitem;
            }

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
                listView.FullRowSelect = true;
            }
        }

        private void BeersListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DrinksTableOverview_Click(object sender, EventArgs e)
        {
            OrderOverviewForm orderOverview = new OrderOverviewForm(_currentOrders, Waiter);
            orderOverview.Show();
            this.Hide();
        }
    }
}
