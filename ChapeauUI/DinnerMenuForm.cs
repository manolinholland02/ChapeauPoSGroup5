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
        private OrderOverviewForm orderOverview;
        private OrderService orderService;
        private ChoosingMenuForm choosingMenuForm;
        private ListViewItem selectedItem;
        List<OrderItem> allDinnerOrderItems;
        private int TableID { get; }
        private Employee Waiter { get; }

        public DinnerMenuForm(OrderService orderService, int tableID, ChoosingMenuForm choosingMenuForm, Employee waiter, OrderOverviewForm orderOverview)
        {
            InitializeComponent();
            PopulateDinnerMenus();
            this.orderService = orderService;
            this.TableID = tableID;
            this.choosingMenuForm = choosingMenuForm;
            this.Waiter = waiter;
            this.orderOverview = orderOverview;
            this.BackColor = ColorTranslator.FromHtml("#E8DCCA");
            selectedItem = new ListViewItem();
            allDinnerOrderItems = new List<OrderItem>();
        }


        public List<ListView> GetListOfListViews()// fills list of listviews
        {
            List<ListView> listViews = new List<ListView>();
            listViews.Add(DinnerEntremetsListView);
            listViews.Add(DinnerStartersListView);
            listViews.Add(DinnerMainListView);
            listViews.Add(DinnerDessertsListView);
            return listViews;
        }

        private void AddbtnDinner_Click(object sender, EventArgs e) //gets the selected item in listview as menu item from DB and adds it to list of current orders
        {
            if (selectedItem == null)
            {
                MessageBox.Show("Please select an item first.");
            }
            else
            {
                OrderItem orderItem = GetOrderItem();

                if (IsItemAlreadyAdded(orderItem.MenuItem.MenuItemID))
                {
                    DialogResult result = MessageBox.Show($"{orderItem.MenuItem.MenuItemName} has already been added to the order once. Do you want to add it again?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes) {IncreaseQuantityOfItem(orderItem);}
                }
                else
                {
                    allDinnerOrderItems.Add(orderItem);
                    orderOverview.AddOrderItemsToOrderOverview(orderItem);
                    orderCounterlbl.Text = $"count : {allDinnerOrderItems.Count}";
                }
                DinnerCommentSection.Clear();
                List<ListView> listViews = GetListOfListViews();
                foreach (ListView listView in listViews)
                {
                    listView.SelectedItems.Clear();
                }
            }
        }
        private OrderItem GetOrderItem()//gets menu item from db and turns it into order item
        {
            Order currentOrder = this.orderService.GetLastOrder(TableID);
            OrderItemService orderItemService = new OrderItemService();
            OrderItem orderItem = null;
            try
            {
                orderItem = new OrderItem()
                {
                    MenuItem = orderItemService.GetCorrespondingMenuItem(int.Parse(selectedItem.SubItems[1].Text)),
                    Comment = DinnerCommentSection.Text,
                    Quantity = 1,
                    Order = currentOrder.OrderId,
                    Status = Status.preparing
                };
                return orderItem;
            }
            catch
            {
                MessageBox.Show("could not get menu item from database");
                return orderItem;
            }

        }
        private void IncreaseQuantityOfItem(OrderItem selectedOrderItem) // adds 1 to the quantity of that item that will be ordered
        {
            foreach (OrderItem orderItem in allDinnerOrderItems)
            {
                if (orderItem.MenuItem.MenuItemID == selectedOrderItem.MenuItem.MenuItemID) orderItem.Quantity++;
            }
        }

        private bool IsItemAlreadyAdded(int menuItemId) //checks if item is already in the list
        {
            foreach (OrderItem orderItem in allDinnerOrderItems)
            {
                if (orderItem.MenuItem.MenuItemID == menuItemId) return true;
            }

            return false;
        }

        private void PopulateDinnerMenus()
        {
            try
            {
                DinnerMenuService dinnerMenuService = new DinnerMenuService();
                List<DinnerMenu> dinnerMenuItems;
                MenuItemCategory category = MenuItemCategory.entremet;
                List<ListView> listViews = GetListOfListViews();
                int i = 0;
                while (category <= MenuItemCategory.desert)
                {
                    listViews[i].Items.Clear();
                    dinnerMenuItems = dinnerMenuService.GetSpecficDinnerMenu(category);
                    FillMenu(dinnerMenuItems, listViews[i]);
                    category++;
                    i++;
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong filling the menus");
            }
        }

        private void FillMenu(List<DinnerMenu> dinnerMenuItems, ListView listView)// fills menu with items, alternates their colours for visibility and greys out any item that has no stock
        {
            OrderItemService orderItemService = new OrderItemService();
            MenuItem menuItem;
            int index = 0;
            try
            {
                foreach (DinnerMenu Item in dinnerMenuItems)
                {
                    string[] output = { Item.DinnerMenuId.ToString(), Item.MenuItemId.ToString(), Item.MenuItemName };
                    ListViewItem item = new ListViewItem(output);
                    listView.Items.Add(item);
                    listView.FullRowSelect = true;
                    menuItem = orderItemService.GetCorrespondingMenuItem(Item.MenuItemId);
                    if (menuItem.MenuItemStock < 1)
                    {
                        listView.Items[index].BackColor = Color.LightGray;
                    }
                    index++;
                }
                for (int i = 0; i <= listView.Items.Count - 1; i = (i + 2))
                {
                    if (listView.Items[i].BackColor != Color.LightGray)
                    {
                        listView.Items[i].BackColor = Color.AliceBlue;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong trying to get the menu items from the database");
            }

        }

        private void OrderOverviewDinnerbtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                orderOverview.FillListViewWithOrderItems();
                orderOverview.LoadFormButtonColours();
                orderOverview.Show();
            }
            catch
            {
                MessageBox.Show("Issue loading form");
            }

        }
        private void BackbtnDinner_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                choosingMenuForm.UpdateTotalTotalOrderCount();
                choosingMenuForm.Show();
            }
            catch
            {
                MessageBox.Show("Issue loading form");
            }
        }

        private void DinnerStartersListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DinnerStartersListView.SelectedItems.Count == 1)
            {
                selectedItem = DinnerStartersListView.SelectedItems[0];
                UnselectOtherListViews(DinnerStartersListView);
            }
        }

        private void DinnerEntremetsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DinnerEntremetsListView.SelectedItems.Count == 1)
            {
                selectedItem = DinnerEntremetsListView.SelectedItems[0];
                UnselectOtherListViews(DinnerEntremetsListView);
            }
        }

        private void DinnerMainListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DinnerMainListView.SelectedItems.Count == 1)
            {
                selectedItem = DinnerMainListView.SelectedItems[0];
                UnselectOtherListViews(DinnerMainListView);
            }
        }

        private void DinnerDessertsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DinnerDessertsListView.SelectedItems.Count == 1)
            {
                selectedItem = DinnerDessertsListView.SelectedItems[0];
                UnselectOtherListViews(DinnerDessertsListView);
            }
        }

        private void UnselectOtherListViews(ListView SelectedListView) // ensures only one item from all list views is selected at a time
        {
            List<ListView> listViews = GetListOfListViews();
            foreach (ListView listView in listViews)
            {
                if (listView != SelectedListView)
                {
                    listView.SelectedItems.Clear();
                }
            }
        }
    }
}
