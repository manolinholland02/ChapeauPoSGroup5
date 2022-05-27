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
        List<Orders> currentOrders;
        public OrderOverviewForm()
        {
            InitializeComponent();
            
        }

        private void PlusOrderbtn_Click(object sender, EventArgs e)
        {

        }

        private void PopulateODerOverView(int tableID)
        {
            OrderlistView.Items.Clear();

            foreach (Orders order in currentOrders)
            {
                string[] output = { order.MenuItem.MenuItemName, order.ItemQuantity.ToString(), order.OrderComment};
                ListViewItem item = new ListViewItem(output);
                OrderlistView.Items.Add(item);
            }
            
        }
    }
}
