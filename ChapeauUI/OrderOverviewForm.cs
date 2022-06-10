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
    public partial class OrderOverviewForm : Form
    {
        private ChoosingMenuForm choosingMenuForm;
        private RestaurantOverview restaurantOverview;
        private OrderItem selectedOrderItem;
        private OrderItemService orderItemService;
        private List<OrderItem> allOrderItems;
        private Employee Waiter { get; }
        private int TableId { get; }

        public OrderOverviewForm(Employee waiter, int tableId, ChoosingMenuForm choosingMenu,RestaurantOverview restaurantOverview)
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#E8DCCA");
            this.Waiter = waiter;
            this.TableId = tableId;
            this.choosingMenuForm = choosingMenu;
            this.restaurantOverview = restaurantOverview;
            orderItemService = new OrderItemService();
            allOrderItems = new List<OrderItem>();
            LoadFormButtonColours();
            // fill in labels on form
            EmployeeNamelbl.Text = $"{this.Waiter.EmployeeFirstName} {this.Waiter.EmployeeLastName}";
            tableNumberlbl.Text = $"Table {TableId}";
        }

        public void LoadFormButtonColours()// loads the colours of the buttons depending on what the clal to action should be
        {
            if (allOrderItems.Count == 0)
            {
                TableOverviewbtn.BackColor = Color.SkyBlue;
                DeleteOrderbtn.BackColor = Color.AliceBlue;
                PlusOrderbtn.BackColor = Color.AliceBlue;
                MinusOrderbtn.BackColor = Color.AliceBlue;
                PlaceOrderbtn.BackColor = Color.AliceBlue;
            }
            else
            {
                TableOverviewbtn.BackColor = Color.AliceBlue;
                DeleteOrderbtn.BackColor = Color.Tomato;
                PlusOrderbtn.BackColor = Color.SkyBlue;
                MinusOrderbtn.BackColor = Color.SkyBlue;
                PlaceOrderbtn.BackColor = Color.Lime;
            }
        }

        private void PlusOrderbtn_Click(object sender, EventArgs e) // adds 1 to quantity of order item
        {
            try
            {
                bool itemSelected = true;
                if (OrderlistView.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select an item first.");
                    itemSelected = false;
                }
                selectedOrderItem = GetOrderItemFromListView(OrderlistView.SelectedItems[0].SubItems[1].Text);
                if (selectedOrderItem.Availability < 1 && itemSelected == true)// check the availability
                {
                    MessageBox.Show($"{selectedOrderItem.MenuItem.MenuItemName} is out of stock");
                }
                else if (itemSelected == true)
                {
                    if (selectedOrderItem.Availability == 0)
                    {
                        MessageBox.Show("Stock limit has been reached!");
                    }
                    else
                    {
                        selectedOrderItem.Quantity += 1;

                        UpdateListView();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Issue adding item");
            }
        }

        private void MinusOrderbtn_Click(object sender, EventArgs e)//subtracts 1 from quantity of order item
        {
            try
            {
                if (OrderlistView.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select an item first.");
                }
                else
                {
                    selectedOrderItem = GetOrderItemFromListView(OrderlistView.SelectedItems[0].SubItems[1].Text);
                    if (selectedOrderItem.Quantity == 1)
                    {
                        allOrderItems.Remove(selectedOrderItem);
                        FillListViewWithOrderItems();
                        if (allOrderItems.Count == 0)
                        {
                            LoadFormButtonColours();
                        }
                    }
                    else
                    {
                        selectedOrderItem.Quantity -= 1;
                        UpdateListView();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Issue removing item");
            }
        }
        public void UpdateListView()//refills list view after item quantity is changed
        {
            string[] output = { selectedOrderItem.OrderItemID.ToString(), selectedOrderItem.MenuItem.MenuItemName, selectedOrderItem.Quantity.ToString(), selectedOrderItem.Comment, selectedOrderItem.Availability.ToString() };
            ListViewItem item = new ListViewItem(output);
            item.Font = new System.Drawing.Font("Microsoft Sans Serif", 11);
            for (int i = 0; i < OrderlistView.Items.Count; i++)
            {
                if (OrderlistView.Items[i].SubItems[1].ToString() == item.SubItems[1].ToString())
                {
                    //replace item in list
                    OrderlistView.Items[i] = (ListViewItem)item.Clone();
                    // keep order selected
                    OrderlistView.Items[i].Selected = true;
                }
                UpdateAllOrderItemsList(selectedOrderItem);
            }
        }

        public void FillListViewWithOrderItems()//fills list view with all order items
        {
            OrderlistView.Items.Clear();

            foreach (OrderItem orderItem in allOrderItems)
            {
                string[] output = {orderItem.OrderItemID.ToString(), orderItem.MenuItem.MenuItemName, orderItem.Quantity.ToString(), orderItem.Comment, orderItem.Availability.ToString() };
                ListViewItem item = new ListViewItem(output);
                OrderlistView.Items.Add(item);
                OrderlistView.FullRowSelect = true;
            }
        }

        private OrderItem GetOrderItemFromListView(string menuItemName)//turns menu item into an order item
        {
            foreach (OrderItem orderItem in allOrderItems)
            {
                if (orderItem.MenuItem.MenuItemName == menuItemName)
                {
                    return orderItem;
                }
            }

            throw new Exception("Menu item was not found.");
        }

        public void AddOrderItemsToOrderOverview(OrderItem orderItem)// adds order to list of orders
        {
            allOrderItems.Add(orderItem);
        }

        public void UpdateAllOrderItemsList(OrderItem orderItem)
        { 
            int index = allOrderItems.IndexOf(GetOrderItemFromListView(OrderlistView.SelectedItems[0].SubItems[1].Text));
            allOrderItems[index] = orderItem;
            LoadFormButtonColours();
        }

        public int GetCountOfAllOrderItems()
        {
            return allOrderItems.Count;
        }
         

        private void DeleteOrderbtn_Click(object sender, EventArgs e) // deletes all items in the current order
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure you want to delete the whole order?", "deleting order", buttons);
            //check if order list is empty
            if (result == DialogResult.Yes)
            {
                allOrderItems.Clear();
            }
            FillListViewWithOrderItems();
            LoadFormButtonColours();
        }


        private void PlaceOrderbtn_Click(object sender, EventArgs e)//puts the order into the DB
        {
            try
            {
                //check if list is empty
                if (allOrderItems.Count == 0)
                {
                    MessageBox.Show("No items to send to kitchen/bar");
                }
                else
                {
                    //update the stock of ordered items
                    UpdateStockOfItems();
                    orderItemService.InsertOrderItems(allOrderItems);
                    // delete items from current order
                    allOrderItems.Clear();
                    FillListViewWithOrderItems();
                    //turn buttons colours
                    LoadFormButtonColours();
                }
            }
            catch
            {
                MessageBox.Show("Could not insert order items into database");
            }
        }

        private void oderOverviewbackbtn_Click_1(object sender, EventArgs e)//goes back to choosing menu form
        {
            this.Hide();
            choosingMenuForm.UpdateTotalTotalOrderCount();
            choosingMenuForm.Show();
        }

        private void TableOverviewbtn_Click(object sender, EventArgs e)//goes to table overview
        {

            if (allOrderItems.Count != 0)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Leaving the order will delete it, are you sure you want to leave?", "Table View", buttons);
                if (result == DialogResult.No)
                {
                    return;
                }
            }
                this.Close();
                restaurantOverview.Show();
        }

        private void UpdateStockOfItems() //stock of ordered items decrease
        {
            foreach (OrderItem item in allOrderItems)
            {
                item.MenuItem.MenuItemStock = item.Availability;
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
                this.Hide();
            }
        }
    }
}
