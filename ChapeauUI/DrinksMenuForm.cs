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
        private Order _currentOrder;
        private int _tableID;
        private ChoosingMenuForm _choosingMenuForm;
        private Employee _waiter;
        private ListViewItem _selectedItem;
        private OrderItemService _orderItemService;
        private OrderOverviewForm _orderOverview;
        private OrderService _orderService;
        private List<OrderItem> _allDrinkOrderItems;

        public DrinksMenuForm(OrderService orderService, int tableID, ChoosingMenuForm choosingMenuForm, Employee waiter, OrderOverviewForm orderOverview)
        {
            InitializeComponent();
            _category = MenuItemCategory.softdrink;
            _listViews = new List<ListView>();
            this._orderService = orderService;
            _currentOrder = this._orderService.GetLastOrder(tableID);
            _listViews.Add(SoftDrinksListView);
            _listViews.Add(CoffeeTeaListView);
            _listViews.Add(WineListView);
            _listViews.Add(BeersListView);
            _listViews.Add(SpiritsListView);
            PopulateDrinkMenus();
            this._tableID = tableID;
            this._choosingMenuForm = choosingMenuForm;
            this._waiter = waiter;
            _selectedItem = new ListViewItem();
            _orderItemService = new OrderItemService();
            this._orderOverview = orderOverview;
            _allDrinkOrderItems = new List<OrderItem>();
        }

        private void BackbtnDinner_Click(object sender, EventArgs e)
        {
            //show the choosing menu form
            this.Hide();
            _choosingMenuForm.UpdateTotalTotalOrderCount();
            _choosingMenuForm.Show();
        }

        private void AddbtnDrinks_Click(object sender, EventArgs e)
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
                    Comment = DrinksCommentSection.Text,
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
                    _allDrinkOrderItems.Add(orderItem);
                    _orderOverview.AddOrderItemsToOrderOverview(orderItem);
                    orderCountlbl.Text = $"count : {_allDrinkOrderItems.Count}";
                }

                DrinksCommentSection.Clear();

                foreach (ListView listView in _listViews)
                {
                    listView.SelectedItems.Clear();
                }

            }
        }

        private void IncreaseQuantityOfItem(OrderItem selectedOrderItem)
        {
            foreach (OrderItem orderItem in _allDrinkOrderItems)
            {
                if (orderItem.MenuItem.MenuItemID == selectedOrderItem.MenuItem.MenuItemID) orderItem.Quantity++;
            }
        }

        private bool IsItemAlreadyAdded(int menuItemId)
        {
            foreach (OrderItem orderItem in _allDrinkOrderItems)
            {
                if (orderItem.MenuItem.MenuItemID == menuItemId) return true;
            }

            return false;
        }

        private void PopulateDrinkMenus()
        {
            DrinksMenuService drinkMenuService = new DrinksMenuService();
            List<DrinkMenu> drinkMenuItems = new List<DrinkMenu>();

            int i = 0;
            while (_category <= MenuItemCategory.caffeinated)
            {
                _listViews[i].Items.Clear();
                drinkMenuItems = drinkMenuService.GetSpecificDrinksMenu(_category);
                FillMenu(drinkMenuItems, _listViews[i]);
                _category++;
                i++;
            }
        }

        private void FillMenu(List<DrinkMenu> drinkMenuItems, ListView listView)
        {
            foreach (DrinkMenu drinkMenu in drinkMenuItems)
            {
                string[] output = { drinkMenu.DrinkMenuId.ToString(), drinkMenu.MenuItemId.ToString(), drinkMenu.MenuItemName };
                ListViewItem item = new ListViewItem(output);
                listView.Items.Add(item);
                listView.FullRowSelect = true;
            }
            for (int i = 0; i <= listView.Items.Count - 1; i = (i + 2))
            {
                listView.Items[i].BackColor = Color.AliceBlue;
            }
        }

        private void DrinksTableOverview_Click(object sender, EventArgs e)
        {
            this.Hide();
            _orderOverview.FillListViewWithOrderItems();
            _orderOverview.Show();
        }

        private void SoftDrinksListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SoftDrinksListView.SelectedItems.Count == 1)
            {
                _selectedItem = SoftDrinksListView.SelectedItems[0];
            }
        }

        private void CoffeeTeaListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CoffeeTeaListView.SelectedItems.Count == 1)
            {
                _selectedItem = CoffeeTeaListView.SelectedItems[0];
            }
        }

        private void BeersListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BeersListView.SelectedItems.Count == 1)
            {
                _selectedItem = BeersListView.SelectedItems[0];
            }
        }

        private void WineListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WineListView.SelectedItems.Count == 1)
            {
                _selectedItem = WineListView.SelectedItems[0];
            }
        }
        private void SpiritsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SpiritsListView.SelectedItems.Count == 1)
            {
                _selectedItem = SpiritsListView.SelectedItems[0];
            }
        }

        private void BackDrinksbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
