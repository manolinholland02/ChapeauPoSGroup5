using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using ChapeauLogic;
using ChapeauModel;

namespace ChapeauUI
{
    public partial class LunchMenuForm : Form
    {
        private MenuItemCategory _category;
        private List<ListView> _listViews;
        private Order _currentOrder;
        private int _tableID;
        private ChoosingMenuForm _choosingMenuForm;
        private Employee _waiter;
        private ListViewItem _selectedItem;
        private OrderItemService _orderItemService;
        private OrderOverviewForm _orderOverview;
        private OrderService _orderService;
        private List<OrderItem> _allLunchOrderItems;

        public LunchMenuForm(OrderService orderService, int tableID, ChoosingMenuForm choosingMenuForm, Employee waiter, OrderOverviewForm orderOverview)
        {
            InitializeComponent();
            _category = MenuItemCategory.starter;
            _listViews = new List<ListView>();
            this._orderService = orderService;
            _currentOrder = this._orderService.GetLastOrder(tableID);
            _listViews.Add(LunchStartersListView);
            _listViews.Add(LunchMainListView);
            _listViews.Add(LunchDessertListView);
            PopulateLunchMenus();
            this._tableID = tableID;
            this._choosingMenuForm = choosingMenuForm;
            this._waiter = waiter;
            _selectedItem = new ListViewItem();
            _orderItemService = new OrderItemService();
            this._orderOverview = orderOverview;
            _allLunchOrderItems = new List<OrderItem>();
        }

        private void backbtnLunch_Click(object sender, EventArgs e)
        {
            //show the choosing order form
            this.Hide();
            _choosingMenuForm.UpdateTotalTotalOrderCount();
            _choosingMenuForm.Show();
        }

        private void AddbtnLunch_Click(object sender, EventArgs e)
        {
            if (_selectedItem == null)
            {
                MessageBox.Show("Please select an item first.");
            }
            else
            {
                OrderItem orderItem = new OrderItem()
                {
                    MenuItem = _orderItemService.GetCorrespondingMenuItem(int.Parse(_selectedItem.SubItems[1].Text)),
                    Comment = LunchCommentSection.Text,
                    Quantity = 1,
                    Order = _currentOrder.OrderId,
                    Status = Status.preparing
                };

                if (IsItemAlreadyAdded(orderItem.MenuItem.MenuItemID))
                {
                    DialogResult result = MessageBox.Show($"{orderItem.MenuItem.MenuItemName} has already been added to the order once. Do you want to add it again?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        IncreaseQuantityOfItem(orderItem);
                    }
                }
                else
                {
                    _allLunchOrderItems.Add(orderItem);
                    _orderOverview.AddOrderItemsToOrderOverview(orderItem);
                    orderCounterlbl.Text = $"count : {_allLunchOrderItems.Count}";
                }

                LunchCommentSection.Clear();

                foreach (ListView listView in _listViews)
                {
                    listView.SelectedItems.Clear();
                }

            }
        }

        private void IncreaseQuantityOfItem(OrderItem selectedOrderItem)
        {
            foreach (OrderItem orderItem in _allLunchOrderItems)
            {
                if (orderItem.MenuItem.MenuItemID == selectedOrderItem.MenuItem.MenuItemID) orderItem.Quantity++;
            }
        }

        private bool IsItemAlreadyAdded(int menuItemId)
        {
            foreach (OrderItem orderItem in _allLunchOrderItems)
            {
                if (orderItem.MenuItem.MenuItemID == menuItemId) return true;
            }

            return false;
        }

        private void PopulateLunchMenus()
        {
            LunchMenuService lunchMenuService = new LunchMenuService();
            List<LunchMenu> lunchMenuItems;
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
                string[] output = { lunchMenu.LunchMenuId.ToString(), lunchMenu.MenuItemId.ToString(), lunchMenu.MenuItemName };
                ListViewItem item = new ListViewItem(output);
                listView.Items.Add(item);
                listView.FullRowSelect = true;
            }
        }

        private void OrderOverviewLunchbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            _orderOverview.FillListViewWithOrderItems();
            _orderOverview.Show();
        }

        private void LunchStartersListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LunchStartersListView.SelectedItems.Count == 1)
            {
                _selectedItem = LunchStartersListView.SelectedItems[0];
            }
        }

        private void LunchMainListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LunchMainListView.SelectedItems.Count == 1)
            {
                _selectedItem = LunchMainListView.SelectedItems[0];
            }
        }


        private void LunchDessertListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LunchDessertListView.SelectedItems.Count == 1)
            {
                _selectedItem = LunchDessertListView.SelectedItems[0];
            }
        }
    }
}
