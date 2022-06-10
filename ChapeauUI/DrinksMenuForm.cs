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
        private ChoosingMenuForm choosingMenuForm;
        private ListViewItem selectedItem;
        private OrderOverviewForm orderOverview;
        private OrderService orderService;
        private List<OrderItem> allDrinkOrderItems;
        private int TableID { get; }
        private Employee Waiter { get; }

        public DrinksMenuForm(OrderService orderService, int tableID, ChoosingMenuForm choosingMenuForm, Employee waiter, OrderOverviewForm orderOverview)
        {
            InitializeComponent();
            PopulateDrinkMenus();
            this.orderService = orderService;
            this.TableID = tableID;
            this.choosingMenuForm = choosingMenuForm;
            this.Waiter = waiter;
            selectedItem = new ListViewItem();
            this.orderOverview = orderOverview;
            allDrinkOrderItems = new List<OrderItem>();
            //background colour
            this.BackColor = ColorTranslator.FromHtml("#E8DCCA");
            // fill in labels on form
            EmployeeNamelbl.Text = $"{this.Waiter.EmployeeFirstName} {this.Waiter.EmployeeLastName}";
            tableNumberlbl.Text = $"Table {TableID}";
        }
        public List<ListView> GetListOfListViews()// fills list of listviews
        {
            List<ListView> listViews = new List<ListView>();
            listViews.Add(SoftDrinksListView);
            listViews.Add(CoffeeTeaListView);
            listViews.Add(WineListView);
            listViews.Add(BeersListView);
            listViews.Add(SpiritsListView);
            return listViews;
        }

        private void BackbtnDinner_Click(object sender, EventArgs e)
        {
            //show the choosing menu form
            this.Hide();
            choosingMenuForm.UpdateTotalTotalOrderCount();
            choosingMenuForm.Show();
        }

        private void AddbtnDrinks_Click(object sender, EventArgs e)
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
                    if (result == DialogResult.Yes)
                    {
                        IncreaseQuantityOfItem(orderItem);
                    }
                }
                else
                {
                    allDrinkOrderItems.Add(orderItem);
                    orderOverview.AddOrderItemsToOrderOverview(orderItem);
                    orderCountlbl.Text = $"Drink Items : {allDrinkOrderItems.Count}";
                }

                DrinksCommentSection.Clear();
                List<ListView> listViews = GetListOfListViews();
                foreach (ListView listView in listViews)
                {
                    listView.SelectedItems.Clear();
                }

            }
        }

        private void IncreaseQuantityOfItem(OrderItem selectedOrderItem)// adds 1 to the quantity of that item that will be ordered
        {
            foreach (OrderItem orderItem in allDrinkOrderItems)
            {
                if (orderItem.MenuItem.MenuItemID == selectedOrderItem.MenuItem.MenuItemID) orderItem.Quantity++;
            }
        }

        private bool IsItemAlreadyAdded(int menuItemId)//checks if item is already in the list
        {
            foreach (OrderItem orderItem in allDrinkOrderItems)
            {
                if (orderItem.MenuItem.MenuItemID == menuItemId) return true;
            }

            return false;
        }

        private void PopulateDrinkMenus()
        {
            try
            {
                DrinksMenuService drinkMenuService = new DrinksMenuService();
                List<DrinkMenu> drinkMenuItems;
                MenuItemCategory category = MenuItemCategory.softdrink;
                List<ListView> listViews = GetListOfListViews();
                int i = 0;
                while (category <= MenuItemCategory.caffeinated)
                {
                    listViews[i].Items.Clear();
                    drinkMenuItems = drinkMenuService.GetSpecificDrinksMenu(category);
                    FillMenu(drinkMenuItems, listViews[i]);
                    category++;
                    i++;
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong filling the menus");
            }
        }

        private void FillMenu(List<DrinkMenu> drinkMenuItems, ListView listView)// fills menu with items, alternates their colours for visibility and greys out any item that has no stock
        {
            OrderItemService orderItemService = new OrderItemService();
            MenuItem menuItem;
            int index = 0;
            try
            {
                foreach (DrinkMenu Item in drinkMenuItems)
                {
                    string[] output = { Item.DrinkMenuId.ToString(), Item.MenuItemId.ToString(), Item.MenuItemName };
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
                    Comment = DrinksCommentSection.Text,
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

        private void DrinksTableOverview_Click(object sender, EventArgs e)
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
        private void SoftDrinksListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (SoftDrinksListView.SelectedItems.Count == 1)
            {
                selectedItem = SoftDrinksListView.SelectedItems[0];
                UnselectOtherListViews(SoftDrinksListView);
            }
        }
        private void CoffeeTeaListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (CoffeeTeaListView.SelectedItems.Count == 1)
            {
                selectedItem = CoffeeTeaListView.SelectedItems[0];
                UnselectOtherListViews(CoffeeTeaListView);
            }
        }

        private void BeersListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BeersListView.SelectedItems.Count == 1)
            {
                selectedItem = BeersListView.SelectedItems[0];
                UnselectOtherListViews(BeersListView);
            }
        }

        private void WineListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (WineListView.SelectedItems.Count == 1)
            {
                selectedItem = WineListView.SelectedItems[0];
                UnselectOtherListViews(WineListView);
            }
        }
        private void SpiritsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SpiritsListView.SelectedItems.Count == 1)
            {
                selectedItem = SpiritsListView.SelectedItems[0];
                UnselectOtherListViews(SpiritsListView);
            }
        }

        private void BackDrinksbtn_Click(object sender, EventArgs e)
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

        private void AddDrinksbtn_Click(object sender, EventArgs e)//gets the selected item in listview as menu item from DB and adds it to list of current orders
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
                    if (result == DialogResult.Yes)
                    {
                        IncreaseQuantityOfItem(orderItem);
                    }
                }
                else
                {
                    allDrinkOrderItems.Add(orderItem);
                    orderOverview.AddOrderItemsToOrderOverview(orderItem);
                    orderCountlbl.Text = $"Drink Items: {allDrinkOrderItems.Count}";
                }
                DrinksCommentSection.Clear();
                List<ListView> listViews = GetListOfListViews();
                foreach (ListView listView in listViews)
                {
                    listView.SelectedItems.Clear();
                }
            }
        }

        private void EmployeeNamelbl_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messageBoxButtons;
            DialogResult result;
            messageBoxButtons = MessageBoxButtons.YesNo;
            string message = "Are you sure you want to Logout?";
            string title = "Logout";
            result = MessageBox.Show(message, title, messageBoxButtons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                LogIn login = new LogIn();
                login.Show();
                this.Close();
            }
        }
    }
}
