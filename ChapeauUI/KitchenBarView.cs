using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using ChapeauModel;
using ChapeauLogic;

namespace ChapeauUI
{
    public partial class KitchenBarView : Form
    {
        private static KitchenBarView uniqueInstance;

        //Dictionary<int, System.Windows.Forms.Timer> _timers = new Dictionary<int, System.Windows.Forms.Timer>();
        List<Timer> timers = new List<Timer> { new Timer(), new Timer()};
        private KitchenBarView()
        {
            InitializeComponent();
            OrdersService ordersService = new OrdersService();
            InitializeDataGridView(ordersService.GetFoodOnlyOrders(ordersService.GetOrders()));
        }

        public static KitchenBarView GetInstance()
        {
            if (uniqueInstance == null) uniqueInstance = new KitchenBarView();

            return uniqueInstance;
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
            orderComment.HeaderText = "Comment";
            orderComment.DataPropertyName = "OrderComment";

            DataGridViewTextBoxColumn orderTime = new DataGridViewTextBoxColumn();
            orderTime.HeaderText = "Time";
            orderTime.DataPropertyName = "timer";
            orderTime.ReadOnly = true;

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            /*Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            ordersDataGridView[3, 1].Value = stopwatch.ToString();*/
            timer.Tick += (ss, ee) => { ordersDataGridView[3, 1].Value = DateTime.Now.ToLongTimeString(); };
            timer.Interval = 1000;
            timer.Start();

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Text = "Ready";
            button.UseColumnTextForButtonValue = true;

            ordersDataGridView.AutoGenerateColumns = false;
            ordersDataGridView.Columns.Add(orderId);
            ordersDataGridView.Columns.Add(orderItemName);
            ordersDataGridView.Columns.Add(orderComment);
            ordersDataGridView.DataSource = foodOrders;
            ordersDataGridView.Columns.Add(orderTime);
            ordersDataGridView.Columns.Add(button);
            ordersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
