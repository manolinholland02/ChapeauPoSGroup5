using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauDAL;
using ChapeauLogic;
using ChapeauModel;

namespace ChapeauUI
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // get password & username from user
            string username = txtUsername.Text;
            int password = int.Parse(txtPassword.Text);
            // open the corresponding screens depending on the type of employee
            EmployeeService employeeService = new EmployeeService();
            Employee employee = employeeService.GetEmployee();
            EmployeeType type = employeeService.GetEmployeeType(username);
            bool exists = employeeService.AccountExists(username, password);
            if ( exists == true)
            {
                // 1) employee type = manager -> Open ManagerViewForm
                if (type == EmployeeType.manager)
                {
                    this.Hide();
                    ManagerViewMenu managerView = new ManagerViewMenu();
                    managerView.Show();
                }
                else if (type == EmployeeType.waiter)
                // 2) employee type = waiter -> Open RestaurantOverview
                {
                    this.Hide();
                    RestaurantOverview restaurantOverview = new RestaurantOverview();
                    restaurantOverview.Show();
                }
                // 3) employee type = chef/barman -> Open KitchenBarView
                else if (type == EmployeeType.chef || type == EmployeeType.barman)
                {
                    this.Hide();
                    KitchenBarView barView = new KitchenBarView();
                    barView.Show();
                }
            }
            else
            {
                MessageBox.Show("No employee found");
            }
        }

    }
}

