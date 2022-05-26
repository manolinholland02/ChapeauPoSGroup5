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

namespace ChapeauUI
{
    public partial class ChoosingMenuForm : Form
    {
        public ChoosingMenuForm()
        {
            InitializeComponent();
            this.Show();
        }

        private void LunchMenubtn_Click(object sender, EventArgs e)
        {
            LunchMenuForm lunch = new LunchMenuForm();
            this.Hide();
            lunch.Show(); // or close
        }

        private void DinnerMenubtn_Click(object sender, EventArgs e)
        {
            DinnerMenuForm dinner = new DinnerMenuForm();
            this.Hide(); // or close
            dinner.Show();
        }

        private void DrinksMenubtn_Click(object sender, EventArgs e)
        {
            //DrinksMenuForm drink = new DrinksMenuForm();
            this.Hide();
            //drink.Show();
        }

        private void MenuPageTableViewbtn_Click(object sender, EventArgs e)
        {
            // go back to table view
            //table number = none

        }

        private void OrderOverviewbtn_Click(object sender, EventArgs e)
        {
            OrderOverviewForm orderOverview = new OrderOverviewForm();
            this.Hide();
            orderOverview.Show();
        }

        private void Paybtn_Click(object sender, EventArgs e)
        {
            // open new paying form
            //hide this form
        }
    }
}
