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


        private void viewManagement_tryButton_Click(object sender, EventArgs e)
        {
            ManagerViewEmployee managerView = new ManagerViewEmployee();
                managerView.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to Logout?";
            string title = "Logout";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                LogIn login = new LogIn();
                login.Show();
            }
            else
            {
                //
            }
        }
        private void btnTable1_Click(object sender, EventArgs e)
        {
            string message = btnTable1.Text;
            string title = btnTable1.Text;
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                LogIn login = new LogIn();
                login.Show();
            }
            else
            {
                //
            }
        }

    }
}
