﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class RestaurantOverview : Form
    {
        public RestaurantOverview()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // open the taking orders form
            // change color if an order has been taken
            button1.BackColor = Color.Red;
        }

        private void viewManagement_tryButton_Click(object sender, EventArgs e)
        {
            ManagerViewEmployee managerView = new ManagerViewEmployee();
                managerView.Show();
            this.Hide();
        }
    }
}
