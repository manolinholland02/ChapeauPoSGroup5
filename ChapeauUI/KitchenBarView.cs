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
    public partial class KitchenBarView : Form
    {
        public KitchenBarView()
        {
            InitializeComponent();
            OrdersService ordersService = new OrdersService();
            InitializeDataGridView(ordersService.GetFoodOnlyOrders(ordersService.GetOrders()));
        }

        private void InitializeDataGridView(List<Orders> foodOrders)
        {
            DataGridViewTextBoxColumn orderId = new DataGridViewTextBoxColumn();
            orderId.HeaderText = "OrderId";
            orderId.DataPropertyName = "OrderId";
            orderId.Visible = false;

            DataGridViewTextBoxColumn orderItemName = new DataGridViewTextBoxColumn();
            orderItemName.HeaderText = "Order";
            orderItemName.DataPropertyName = "OrderDesign";

            DataGridViewTextBoxColumn orderComment = new DataGridViewTextBoxColumn();
            orderComment.HeaderText = "Price";
            orderComment.DataPropertyName = "OrderPrice";

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Text = "Ready";
            button.UseColumnTextForButtonValue = true;

            ordersDataGridView.AutoGenerateColumns = false;
            ordersDataGridView.Columns.Add(orderId);
            ordersDataGridView.Columns.Add(orderItemName);
            ordersDataGridView.Columns.Add(orderComment);
            ordersDataGridView.DataSource = foodOrders;
            ordersDataGridView.Columns.Add(button);
        }
    }
}
