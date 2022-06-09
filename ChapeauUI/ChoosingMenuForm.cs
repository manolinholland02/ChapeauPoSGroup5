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
        private Order _currentOrder;
        private int tableID;
        private Employee waiter;
        private RestaurantOverview restaurantOverview;
        private OrderOverviewForm orderOverview;
        private OrderService orderService;

        public ChoosingMenuForm(int TableID, Employee employee, OrderService orderService, RestaurantOverview restaurantOverview)
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#E8DCCA");
            CheckMenuTime();
            this.tableID = TableID;
            this.waiter = employee;
            this.orderService = orderService;
            _currentOrder = this.orderService.GetLastOrder(tableID);
            EmployeeNamelbl.Text = $"{this.waiter.EmployeeFirstName} {this.waiter.EmployeeLastName}";
            tableNumberlbl.Text = $"Table {tableID}";
            this.restaurantOverview = restaurantOverview;
            this.orderOverview = new OrderOverviewForm(this.orderService, waiter, tableID, this, restaurantOverview);
            totalOrderCountlbl.Text = $"Total items in the order: {orderOverview.GetCountOfAllOrderItems()}";
        }

        public void UpdateTotalTotalOrderCount()
        {
            totalOrderCountlbl.Text = $"Total items in the order: {orderOverview.GetCountOfAllOrderItems()}";
        }

        private void LunchMenubtn_Click(object sender, EventArgs e)
        {
            LunchMenuForm lunch = new LunchMenuForm(orderService, tableID, this, waiter, orderOverview);
            this.Hide();
            lunch.Show(); // or close
        }

        private void DinnerMenubtn_Click(object sender, EventArgs e)
        {
            DinnerMenuForm dinner = new DinnerMenuForm(orderService, tableID, this, waiter, orderOverview);
            this.Hide(); // or close
            dinner.Show();
        }

        private void DrinksMenubtn_Click(object sender, EventArgs e)
        {
            DrinksMenuForm drink = new DrinksMenuForm(orderService, tableID, this, waiter, orderOverview);
            this.Hide();
            drink.Show();
        }

        private void MenuPageTableViewbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            restaurantOverview.Show();

        }

        private void OrderOverviewbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            orderOverview.FillListViewWithOrderItems();
            orderOverview.Show();

        }

        private void Paybtn_Click(object sender, EventArgs e)
        {
            // open new paying form
            //hide this form
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
    }
}
