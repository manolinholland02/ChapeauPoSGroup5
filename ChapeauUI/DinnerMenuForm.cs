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
    public partial class DinnerMenuForm : Form
    {
        private MenuItemCategory _category;
        private List<ListView> _listViews;
        private List<Orders> _currentOrders;
        private int TableID;
        private Employee Waiter;

        public DinnerMenuForm(List<Orders> currentorders, int TableID, Employee waiter)
        {
            InitializeComponent();
            _category = MenuItemCategory.entremet;
            _listViews = new List<ListView>();
            _currentOrders = currentorders;
            _listViews.Add(DinnerEntremetsListView);
            _listViews.Add(DinnerStartersListView);
            _listViews.Add(DinnerMainListView);
            _listViews.Add(DinnerDessertsListView);
            PopulateDinnerMenus();
            this.TableID = TableID;
            this.Waiter = waiter;
        }

        private void BackbtnDinner_Click(object sender, EventArgs e)
        {
            ChoosingMenuForm choosingForm = new ChoosingMenuForm(TableID, Waiter);
            this.Close();
        }

        private void AddbtnDinner_Click(object sender, EventArgs e)
        {
            //check if only one is selected
            List<MenuItem> OrderedItem = CheckSelectedItems();
            if (OrderedItem != null)
            {
                Orders order = new Orders();
                order.OrderComment = DinnerCommentSection.Text;
                order.OrderTable = TableID;
                order.OrderWaiter = Waiter.EmployeeID;
                order.ItemQuantity += 1;
                //order.MenuItem.MenuItemID = OrderedItem[0].MenuItemID;
                order.MenuItem = OrderedItem[0];

                _currentOrders.Add(order);
                //order counter +1
            }

            DinnerCommentSection.Clear();
            foreach (ListView listView in _listViews)
            {
                listView.SelectedItems.Clear();
            }
        }
        private List<MenuItem> CheckSelectedItems()
        {
            int count = 0;
            List<MenuItem> item = new List<MenuItem>();
            MenuItemService menuItemService = new MenuItemService();
            Orders orderedItem = new Orders();
            foreach (ListView listViews in _listViews)
            {

                if (listViews.SelectedItems.Count == 1)
                {
                    count++;
                    item = menuItemService.GetMenuItemByID(int.Parse(listViews.SelectedItems[0].Text));
                    

                }

            }
            if (count == 1)
            {
                return item;
            }
            else if (count > 1)
            {
                MessageBox.Show("Select only one item");
                return null;
            }
            else
            {
                MessageBox.Show("Select at least one item");
                return null;
            }

        }

        private void PopulateDinnerMenus()
        {
            DinnerMenuService dinnerMenuService = new DinnerMenuService();
            List<DinnerMenu> dinnerMenuItems = new List<DinnerMenu>();

            int i = 0;
            while (_category <= MenuItemCategory.desert)
            {
                _listViews[i].Items.Clear();
                dinnerMenuItems = dinnerMenuService.GetspecficDinnerMenu(_category);
                FillMenu(dinnerMenuItems, _listViews[i]);
                _category++;
                i++;
            }
        }

        private void FillMenu(List<DinnerMenu> dinnerMenuItems, ListView listView)
        {
            foreach (DinnerMenu dinnerMenu in dinnerMenuItems)
            {
                string[] output = { dinnerMenu.DinnerMenuId.ToString(), dinnerMenu.MenuItemName };
                ListViewItem item = new ListViewItem(output);
                listView.Items.Add(item);
                listView.FullRowSelect = true;
            }
            for (int i = 0; i <= listView.Items.Count - 1; i = (i + 2))
            {
                listView.Items[i].BackColor = Color.AliceBlue;
            }
        }

        private void DinnerTableOverview_Click(object sender, EventArgs e)
        {
            OrderOverviewForm orderOverview = new OrderOverviewForm(_currentOrders, Waiter);
            orderOverview.Show();
            this.Hide();
        }
    }
}
