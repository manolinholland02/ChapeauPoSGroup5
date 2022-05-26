﻿using System;
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
    public partial class OrderOverviewForm : Form
    {
        List<Orders> currentOrders;
        public OrderOverviewForm(List<Orders> current_orders)
        {
            InitializeComponent();
            currentOrders = current_orders;


        }

        private void PlusOrderbtn_Click(object sender, EventArgs e)
        {

        }

        private void PopulateODerOverView(int tableID)
        {
            OrderlistView.Items.Clear();

            foreach (Orders order in currentOrders)
            {
                string[] output = { order.orderItemName, order.ItemQuantity.ToString(), order.orderComment };
                ListViewItem item = new ListViewItem(output);
                OrderlistView.Items.Add(item);
            }

        }

        private void OrderOverviewForm_Load(object sender, EventArgs e)
        {

        }
    }
}
