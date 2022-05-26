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
        private int WaiterID;

        public DinnerMenuForm(List<Orders> currentorders, int TableID, int waiterID)
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
            this.WaiterID = waiterID;
        }

        private void BackbtnDinner_Click(object sender, EventArgs e)
        {
            ChoosingMenuForm choosingForm = new ChoosingMenuForm(TableID, WaiterID);
            this.Close();
        }

        private void AddbtnDinner_Click(object sender, EventArgs e)
        {
            //check if only one is selected
            Orders order = CheckSelectedItems();
            if (order != null)
            {
                MenuItemService menuservice = new MenuItemService();
                List<MenuItem> menuItems = menuservice.GetMenuItems();
                order.orderComment = DinnerCommentSection.Text;

                foreach (MenuItem item in menuItems)
                {
                    if (item.MenuItemID == order.orderID)
                    {
                        order.orderPrice = item.MenuItemPrice;
                        order.orderItemName = item.MenuItemName;
                        order.orderStatus = Status.processing;
                    }
                }
                //order.table
                //order waiter
                //order preparer
                //order payment

                _currentOrders.Add(order);
                //order counter +1
            }

            DinnerCommentSection.Clear();
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
                    item.orderItem = int.Parse(listViews.SelectedItems[0].Text);
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
        }

        private void DinnerTableOverview_Click(object sender, EventArgs e)
        {
            OrderOverviewForm orderOverview = new OrderOverviewForm(_currentOrders, TableID, WaiterID);
            orderOverview.Show();
            this.Hide();
        }
    }
}
