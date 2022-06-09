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
        private Order _currentOrder;
        private int _tableID;
        private ChoosingMenuForm _choosingMenuForm;
        private Employee _waiter;
        private ListViewItem _selectedItem;
        private OrderItemService _orderItemService;
        private OrderOverviewForm _orderOverview;
        private OrderService _orderService;
        private List<OrderItem> _allDinnerOrderItems;

        public DinnerMenuForm(OrderService orderService, int tableID, ChoosingMenuForm choosingMenuForm, Employee waiter, OrderOverviewForm orderOverview)
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#E8DCCA");
            _category = MenuItemCategory.entremet;
            _listViews = new List<ListView>();
            this._orderService = orderService;
            _currentOrder = this._orderService.GetLastOrder(tableID);
            _listViews.Add(DinnerEntremetsListView);
            _listViews.Add(DinnerStartersListView);
            _listViews.Add(DinnerMainListView);
            _listViews.Add(DinnerDessertsListView); ;
            PopulateDinnerMenus();
            this._tableID = tableID;
            this._choosingMenuForm = choosingMenuForm;
            this._waiter = waiter;
            _selectedItem = new ListViewItem();
            _orderItemService = new OrderItemService();
            this._orderOverview = orderOverview;
            _allDinnerOrderItems = new List<OrderItem>();
        }

        private void BackbtnDinner_Click(object sender, EventArgs e)
        {
            //show the choosing order form
            this.Hide();
            _choosingMenuForm.UpdateTotalTotalOrderCount();
            _choosingMenuForm.Show();
        }

        private void AddbtnDinner_Click(object sender, EventArgs e)
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
                    Comment = DinnerCommentSection.Text,
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
                    _allDinnerOrderItems.Add(orderItem);
                    _orderOverview.AddOrderItemsToOrderOverview(orderItem);
                    orderCounterlbl.Text = $"count : {_allDinnerOrderItems.Count}";
                }

                DinnerCommentSection.Clear();

                foreach (ListView listView in _listViews)
                {
                    listView.SelectedItems.Clear();
                }

            }
        }
        private void IncreaseQuantityOfItem(OrderItem selectedOrderItem)
        {
            foreach (OrderItem orderItem in _allDinnerOrderItems)
            {
                if (orderItem.MenuItem.MenuItemID == selectedOrderItem.MenuItem.MenuItemID) orderItem.Quantity++;
            }
        }

        private bool IsItemAlreadyAdded(int menuItemId)
        {
            foreach (OrderItem orderItem in _allDinnerOrderItems)
            {
                if (orderItem.MenuItem.MenuItemID == menuItemId) return true;
            }

            return false;
        }

        private void PopulateDinnerMenus()
        {
            DinnerMenuService dinnerMenuService = new DinnerMenuService();
            List<DinnerMenu> dinnerMenuItems = new List<DinnerMenu>();

            int i = 0;
            while (_category <= MenuItemCategory.desert)
            {
                _listViews[i].Items.Clear();
                dinnerMenuItems = dinnerMenuService.GetSpecficDinnerMenu(_category);
                FillMenu(dinnerMenuItems, _listViews[i]);
                _category++;
                i++;
            }
        }

        private void FillMenu(List<DinnerMenu> dinnerMenuItems, ListView listView)
        {
            foreach (DinnerMenu dinnerMenu in dinnerMenuItems)
            {
                string[] output = { dinnerMenu.DinnerMenuId.ToString(), dinnerMenu.MenuItemId.ToString(), dinnerMenu.MenuItemName };
                ListViewItem item = new ListViewItem(output);
                listView.Items.Add(item);
                listView.FullRowSelect = true;
            }
            for (int i = 0; i <= listView.Items.Count - 1; i = (i + 2))
            {
                listView.Items[i].BackColor = Color.AliceBlue;
            }
        }

        private void OrderOverviewDinnerbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            _orderOverview.FillListViewWithOrderItems();
            _orderOverview.LoadFormButtonColours();
            _orderOverview.Show();
        }

        private void DinnerStartersListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DinnerStartersListView.SelectedItems.Count == 1)
            {
                _selectedItem = DinnerStartersListView.SelectedItems[0];
                UnselectOtherListViews(DinnerStartersListView);
            }
        }

        private void DinnerEntremetsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DinnerEntremetsListView.SelectedItems.Count == 1)
            {
                _selectedItem = DinnerEntremetsListView.SelectedItems[0];
                UnselectOtherListViews(DinnerEntremetsListView);
            }
        }

        private void DinnerMainListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DinnerMainListView.SelectedItems.Count == 1)
            {
                _selectedItem = DinnerMainListView.SelectedItems[0];
                UnselectOtherListViews(DinnerMainListView);
            }
        }

        private void DinnerDessertsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DinnerDessertsListView.SelectedItems.Count == 1)
            {
                _selectedItem = DinnerDessertsListView.SelectedItems[0];
                UnselectOtherListViews(DinnerDessertsListView);
            }
        }

        private void UnselectOtherListViews(ListView SelectedListView) // ensures only one item from all list views is selected at a time
        {
            foreach (ListView listView in _listViews)
            {
                if (listView != SelectedListView)
                {
                    listView.SelectedItems.Clear();
                }
            }
        }
    }
}
