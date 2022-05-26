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
            List<Orders> foodOrders = ordersService.GetFoodOnlyOrders(ordersService.GetOrders());
            ordersDataGridView.DataSource = foodOrders.Select(o => new KitchenBarViewModel()
            { Id = o.orderID, Name = o.orderItemName, Quantity = o.ItemQuantity, Comment = o.orderComment }).ToList();
            ordersDataGridView.Columns[1].Visible = false;


            //ordersDataGridView.AutoGenerateColumns = false;
            //ordersDataGridView.DataSource = ordersService.GetFood();

            //ordersDataGridView.DataSource = foodOrders;
        }
    }
}
