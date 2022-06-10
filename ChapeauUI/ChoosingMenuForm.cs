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
        private int TableID { get; }
        private Employee Waiter { get; }
        private RestaurantOverview restaurantOverview;
        private OrderOverviewForm orderOverview;
        private OrderService orderService;

        public ChoosingMenuForm(int TableID, Employee employee, OrderService orderService, RestaurantOverview restaurantOverview)
        {
            InitializeComponent();
            this.TableID = TableID;
            this.Waiter = employee;
            this.orderService = orderService;
            this.restaurantOverview = restaurantOverview;
            // new order overview for table
            this.orderOverview = new OrderOverviewForm(Waiter, this.TableID, this, restaurantOverview);
            GetvariablesandFormat();
        }
        public void GetvariablesandFormat()
        {
            //lunch or dinner menu
            CheckMenuTime();
            // fill in labels on form
            EmployeeNamelbl.Text = $"{this.Waiter.EmployeeFirstName} {this.Waiter.EmployeeLastName}";
            tableNumberlbl.Text = $"Table {TableID}";
            //count of items in current order
            totalOrderCountlbl.Text = $"Total items in the order: {orderOverview.GetCountOfAllOrderItems()}";
            //set background colour
            this.BackColor = ColorTranslator.FromHtml("#E8DCCA");
        }

        public void UpdateTotalTotalOrderCount() //changes count to the number of items in current order
        {
            totalOrderCountlbl.Text = $"Total items in the order: {orderOverview.GetCountOfAllOrderItems()}";
        }

        private void LunchMenubtn_Click(object sender, EventArgs e)
        {
            try
            {
                LunchMenuForm lunch = new LunchMenuForm(orderService, TableID, this, Waiter, orderOverview);
                this.Hide();
                lunch.Show();
            }
            catch
            {
                MessageBox.Show("Issue loading form");
            }
        }

        private void DinnerMenubtn_Click(object sender, EventArgs e)
        {
            try
            {
                DinnerMenuForm dinner = new DinnerMenuForm(orderService, TableID, this, Waiter, orderOverview);
                this.Hide();
                dinner.Show();
            }
            catch
            {
                MessageBox.Show("Issue loading form");
            }
        }

        private void DrinksMenubtn_Click(object sender, EventArgs e)
        {
            try
            {
                DrinksMenuForm drink = new DrinksMenuForm(orderService, TableID, this, Waiter, orderOverview);
                this.Hide();
                drink.Show();
            }
            catch
            {
                MessageBox.Show("Issue loading form");
            }
        }

        private void MenuPageTableViewbtn_Click(object sender, EventArgs e) //checks if user wants to leave (if there are orders)
        {
            try
            {
                if (orderOverview.GetCountOfAllOrderItems() != 0)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Leaving the order will delete all added items, are you sure you want to leave?", "Table View", buttons);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }
                this.Close();
                restaurantOverview.Show();
            }
            catch
            {
                MessageBox.Show("Issue loading form");
            }
        }

        private void OrderOverviewbtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                orderOverview.FillListViewWithOrderItems();
                orderOverview.Show();
            }
            catch
            {
                MessageBox.Show("Issue loading form");
            }
        }

        private void CheckMenuTime() //changes the colour of the buttons according to the time - lunch or dinner time
        {
            DateTime DinnerTime = DateTime.Now.Date.AddHours(18);
            if (DateTime.Now <= DinnerTime)
            {
                LunchMenubtn.BackColor = Color.SkyBlue;
                DinnerMenubtn.BackColor = Color.LightGray;
            }
            else
            {
                LunchMenubtn.BackColor = Color.LightGray;
                DinnerMenubtn.BackColor = Color.SkyBlue;
            }
            DrinksMenubtn.BackColor = Color.SkyBlue;
        }

        private void EmployeeNamelbl_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messageBoxButtons;
            DialogResult result;
            messageBoxButtons = MessageBoxButtons.YesNo;
            string message = "Are you sure you want to Logout?";
            string title = "Logout";
            result = MessageBox.Show(message, title, messageBoxButtons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                LogIn login = new LogIn();
                login.Show();
                this.Hide();
            }
        }
    }
}
