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
        private Order currentOrder;
        private Employee waiter;
        private int tableId;
        private ChoosingMenuForm choosingMenuForm;
        private RestaurantOverview restaurantOverview;
        private OrderService orderService;
        private OrderItem selectedOrderItem;
        private OrderItemService orderItemService;
        private List<OrderItem> allOrderItems;

        public OrderOverviewForm(OrderService orderService, Employee waiter, int tableId, ChoosingMenuForm choosingMenu,RestaurantOverview restaurantOverview)
        {
            InitializeComponent();
            this.orderService = orderService;
            this.currentOrder = this.orderService.GetLastOrder(tableId);
            this.waiter = waiter;
            this.tableId = tableId;
            choosingMenuForm = choosingMenu;
            this.restaurantOverview = restaurantOverview;
            orderItemService = new OrderItemService();
            allOrderItems = new List<OrderItem>();
            LoadFormButtonColours();
        }

        public void LoadFormButtonColours()
        {
            if (allOrderItems.Count == 0)
            {
                TableOverviewbtn.BackColor = Color.SkyBlue;
                DeleteOrderbtn.BackColor = default(Color);
                PlusOrderbtn.BackColor = default(Color);
                MinusOrderbtn.BackColor = default(Color);
                PlaceOrderbtn.BackColor = default(Color);
            }
            else
            {
                TableOverviewbtn.BackColor = default(Color);
                DeleteOrderbtn.BackColor = Color.Tomato;
                PlusOrderbtn.BackColor = Color.SkyBlue;
                MinusOrderbtn.BackColor = Color.SkyBlue;
                PlaceOrderbtn.BackColor = Color.Lime;
            }
        }

        private void PlusOrderbtn_Click(object sender, EventArgs e)
        {
            selectedOrderItem = GetOrderItemFromListView(OrderlistView.SelectedItems[0].SubItems[1].Text);
            if (OrderlistView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item first.");
            }
            else if (selectedOrderItem.Availability < 1)// check the availability
            {
                MessageBox.Show($"{selectedOrderItem.MenuItem.MenuItemName} is out of stock");
            }
            else
            {
                if (selectedOrderItem.Availability == 0)
                {
                    MessageBox.Show("Stock limit has been reached!");
                }
                else
                {
                    selectedOrderItem.Quantity += 1;
                    
                    string[] output = { selectedOrderItem.OrderItemID.ToString(), selectedOrderItem.MenuItem.MenuItemName, selectedOrderItem.Quantity.ToString(), selectedOrderItem.Comment, selectedOrderItem.Availability.ToString() };
                    ListViewItem item = new ListViewItem(output);
                    for (int i = 0; i < OrderlistView.Items.Count; i++)
                    {
                        if (OrderlistView.Items[i].SubItems[1].ToString() == item.SubItems[1].ToString())
                        {
                            //replace item in list
                            OrderlistView.Items[i] = (ListViewItem)item.Clone();
                            // keep order selected
                            OrderlistView.Items[i].Selected = true;
                        }
                    }

                    UpdateAllOrderItemsList(selectedOrderItem);
                }
            }
        }

        private void MinusOrderbtn_Click(object sender, EventArgs e)
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
                }
                else
                {
                    selectedOrderItem.Quantity -= 1;

                    string[] output = { selectedOrderItem.OrderItemID.ToString(), selectedOrderItem.MenuItem.MenuItemName, selectedOrderItem.Quantity.ToString(), selectedOrderItem.Comment, selectedOrderItem.Availability.ToString() };
                    ListViewItem item = new ListViewItem(output);
                    for (int i = 0; i < OrderlistView.Items.Count; i++)
                    {
                        if (OrderlistView.Items[i].SubItems[1].ToString() == item.SubItems[1].ToString())
                        {
                            OrderlistView.Items[i] = (ListViewItem)item.Clone();
                            OrderlistView.Items[i].Selected = true;
                        }
                        UpdateAllOrderItemsList(selectedOrderItem);
                    }
                }
                
            }
        }

        public void FillListViewWithOrderItems()
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

        private OrderItem GetOrderItemFromListView(string menuItemName)
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

        public void AddOrderItemsToOrderOverview(OrderItem orderItem)
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
         
        private void OrderOverviewForm_Load(object sender, EventArgs e)
        {

        }

        private void DeleteOrderbtn_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure you want to delete the whole order?", "deleting order", buttons);
            //check if order list is empty
            if (result == DialogResult.Yes)
            {
                allOrderItems.Clear();
            }
            FillListViewWithOrderItems();
        }


        private void PlaceOrderbtn_Click(object sender, EventArgs e)
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

        private void oderOverviewbackbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            choosingMenuForm.UpdateTotalTotalOrderCount();
            choosingMenuForm.Show();
        }

        private void TableOverviewbtn_Click(object sender, EventArgs e)
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

        private void UpdateStockOfItems()
        {
            foreach (OrderItem item in allOrderItems)
            {
                item.MenuItem.MenuItemStock = item.Availability;
            }
        }
    }
}
