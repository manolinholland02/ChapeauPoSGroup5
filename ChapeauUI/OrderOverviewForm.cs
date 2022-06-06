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
        private ChoosingMenuForm choosingMenu;
        private OrderService orderService;
        private OrderItem selectedOrderItem;
        private OrderItemService orderItemService;
        private List<OrderItem> allOrderItems;

        public OrderOverviewForm(OrderService orderService, Employee waiter, int tableId, ChoosingMenuForm choosingMenu)
        {
            InitializeComponent();
            this.orderService = orderService;
            this.currentOrder = this.orderService.GetLastOrder(tableId);
            this.waiter = waiter;
            this.tableId = tableId;
            this.choosingMenu = choosingMenu;
            orderItemService = new OrderItemService();
            allOrderItems = new List<OrderItem>();
        }

        private void PlusOrderbtn_Click(object sender, EventArgs e)
        {
            if (OrderlistView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item first.");
            }
            else
            {
                selectedOrderItem = GetOrderItemFromListView(OrderlistView.SelectedItems[0].SubItems[1].Text);
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
                    MessageBox.Show("Quantity must be at least 1!");
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
                    }

                    UpdateAllOrderItemsList(selectedOrderItem);
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
        }

        public int GetCountOfAllOrderItems()
        {
            return allOrderItems.Count;
        }

        private void OrderOverviewPaybtn_Click(object sender, EventArgs e)
        {

        }
         
        private void OrderOverviewForm_Load(object sender, EventArgs e)
        {

        }

        private void DeleteOrderbtn_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Are you sure you want to delete the whole order?", "deleting order", buttons);
            //check if order list is empty
            /*if (result == DialogResult.Yes)
            {
                foreach (OrderItem order in currentOrder.OrderItems)
                {
                    currentOrder.OrderItems.Remove(order);
                }


            }  */
            OrderlistView.Update();
        }

        private void oderOverviewbackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            choosingMenu.UpdateTotalTotalOrderCount();
            choosingMenu.Show();
        }

        private void PlaceOrderbtn_Click(object sender, EventArgs e)
        {
            orderItemService.InsertOrderItems(allOrderItems);
            // delete items from current order
            // delete stock
        }

        private void OrderOverviewPaybtn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
