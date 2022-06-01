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
        private List<Orders> CurrentOrders;
        public OrderOverviewForm(List<Orders> currentOrders, Employee waiter)
        {
            InitializeComponent();
            CurrentOrders = new List<Orders>();
            CurrentOrders = currentOrders;
            
        }

        private void PlusOrderbtn_Click(object sender, EventArgs e)
        {
            Orders selectedOrder;
            foreach (Orders order in CurrentOrders)
            {
                if (order.MenuItem.MenuItemID == int.Parse(OrderlistView.SelectedItems[0].Text))
                {
                    selectedOrder = order;
                    selectedOrder.ItemQuantity++;
                }
            }
            OrderlistView.Update();
            
        }
        private void MinusOrderbtn_Click(object sender, EventArgs e)
        {
            Orders selectedOrder;
            foreach (Orders order in CurrentOrders)
            {
                if (order.MenuItem.MenuItemID == int.Parse(OrderlistView.SelectedItems[0].Text))
                {
                    selectedOrder = order;
                    selectedOrder.ItemQuantity--;
                    if (selectedOrder.ItemQuantity <= 0)
                    {
                        CurrentOrders.Remove(selectedOrder);
                    }
                }
            }
            OrderlistView.Update();
        }

        private void PopulateODerOverView(int tableID)
        {
            OrderlistView.Items.Clear();

            foreach (Orders order in CurrentOrders)
            {
                string[] output = { order.MenuItem.MenuItemName, order.ItemQuantity.ToString(), order.OrderComment};
                ListViewItem item = new ListViewItem(output);
                OrderlistView.Items.Add(item);
            }
            
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
            if (result == DialogResult.Yes)
            {
                foreach (Orders order in CurrentOrders)
                {
                    CurrentOrders.Remove(order);
                }


            }  
            OrderlistView.Update();
        }

        private void OrderOverviewPaybtn_Click_1(object sender, EventArgs e)
        {

        }

        private void PlaceOrderbtn_Click(object sender, EventArgs e)
        {
            OrdersService orderService = new OrdersService();
            orderService.InsertNewOrder(CurrentOrders);
        }
    }
}
