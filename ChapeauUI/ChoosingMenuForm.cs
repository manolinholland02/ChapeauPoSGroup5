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
    public partial class ChoosingMenuForm : Form
    {
        private List<Orders> _currentOrders;
        private int TableID;
        private int WaiterID;

        public ChoosingMenuForm(int TableID, int WaiterID)
        {
            InitializeComponent();
            if (_currentOrders == null)
            {
                _currentOrders = new List<Orders>();
            }
            this.TableID = TableID;
            this.WaiterID = WaiterID;

            
        }

        private void LunchMenubtn_Click(object sender, EventArgs e)
        {
            LunchMenuForm lunch = new LunchMenuForm(_currentOrders, TableID, WaiterID);
            this.Hide();
            lunch.Show(); // or close
        }

        private void DinnerMenubtn_Click(object sender, EventArgs e)
        {
            DinnerMenuForm dinner = new DinnerMenuForm(_currentOrders, TableID, WaiterID);
            this.Hide(); // or close
            dinner.Show();
        }

        private void DrinksMenubtn_Click(object sender, EventArgs e)
        {
            DrinksMenuForm drink = new DrinksMenuForm(_currentOrders, TableID, WaiterID);
            this.Hide();
            drink.Show();
        }

        private void MenuPageTableViewbtn_Click(object sender, EventArgs e)
        {
            // go back to table view
            //table number = none

        }

        private void OrderOverviewbtn_Click(object sender, EventArgs e)
        {
            OrderOverviewForm orderOverview = new OrderOverviewForm();
            orderOverview.Show();
            this.Hide();
        }

        private void Paybtn_Click(object sender, EventArgs e)
        {
            // open new paying form
            //hide this form
        }
    }
}
