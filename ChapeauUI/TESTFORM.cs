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
    public partial class TESTFORM : Form
    {
        public TESTFORM()
        {
            InitializeComponent();
        }

        private void testformbtn_Click(object sender, EventArgs e)
        {
            testlistview.Items.Clear();
            OrdersService ordersService = new OrdersService();
            List<Orders> foodOrders = ordersService.GetFoodOnlyOrders(ordersService.GetOrders());

            foreach(Orders order in foodOrders)
            {
                string[] output = { order.orderID.ToString(), order.orderItemName, order.ItemQuantity.ToString(), order.orderComment };
                ListViewItem item = new ListViewItem(output);
                testlistview.Items.Add(item);
            }
        }
    }
}
