using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauLogic;
using ChapeauModel;

namespace ChapeauUI
{
    public partial class LunchMenuForm : Form
    {
        private MenuItemCategory _category;
        private List<ListView> _listViews;
        private List<Orders> _currentOrders;
        private int TableID;
        private Employee Waiter;
        
        public LunchMenuForm(List<Orders> currentorders, int TableID, Employee waiter)
        {
            InitializeComponent();
            _category = MenuItemCategory.starter;
            _listViews = new List<ListView>();
            _currentOrders = currentorders;
            _listViews.Add(LunchStartersListView);
            _listViews.Add(LunchMainListView);
            _listViews.Add(LunchDessertListView);
            PopulateLunchMenus();
            this.TableID = TableID;
            this.Waiter = waiter;
        }

        private void backbtnLunch_Click(object sender, EventArgs e)
        {
            //show the choosing order form
            ChoosingMenuForm choosingMenuForm = new ChoosingMenuForm(TableID, Waiter);
            choosingMenuForm.Show();
            this.Hide(); // or close
        }

        private void AddbtnLunch_Click(object sender, EventArgs e)
        {
            //check if only one is selected
            Orders order = CheckSelectedItems();
            if (order != null)
            {
                MenuItemService menuservice = new MenuItemService();
                List<MenuItem> menuItems = menuservice.GetMenuItems();
                order.OrderComment = LunchCommentSection.Text;
                foreach (MenuItem item in menuItems)
                {
                    if (item.MenuItemID == order.MenuItem.MenuItemID)
                    {
                        
                        order.MenuItem.MenuItemName= item.MenuItemName;
                        order.OrderStatus = Status.processing;
                    }
                }
                //order.table
                //order waiter
                //order preparer
                //order payment
                
                _currentOrders.Add(order);
                orderCounterlbl.Text = $"count : {_currentOrders.Count}";
                //order counter +1
            }

            LunchCommentSection.Clear();
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

        private void PopulateLunchMenus()
        {
            LunchMenuService lunchMenuService = new LunchMenuService();
            List<LunchMenu> lunchMenuItems = new List<LunchMenu>();

            int i = 0;
            while (_category <= MenuItemCategory.desert)
            {
                _listViews[i].Items.Clear();
                lunchMenuItems = lunchMenuService.GetSpecificLunchMenu(_category);
                FillMenu(lunchMenuItems, _listViews[i]);
                _category++;
                i++;
            }
        }

        private void FillMenu(List<LunchMenu> lunchMenuItems, ListView listView)
        {
            foreach (LunchMenu lunchMenu in lunchMenuItems)
            {
                string[] output = { lunchMenu.LunchMenuId.ToString(), lunchMenu.MenuItemName };
                ListViewItem item = new ListViewItem(output);
                listView.Items.Add(item);
                listView.FullRowSelect = true;
            }
            for (int i = 0; i <= listView.Items.Count - 1; i = (i + 2))
            {
                listView.Items[i].BackColor = Color.AliceBlue;
            }
        }

        private void LunchCommentSection_TextChanged(object sender, EventArgs e)
        {

        }

        private void LunchDessertListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OrderOverviewLunchbtn_Click(object sender, EventArgs e)
        {
            OrderOverviewForm orderOverview = new OrderOverviewForm(_currentOrders, Waiter);
            orderOverview.Show();
            this.Hide();
        }
    }
}
