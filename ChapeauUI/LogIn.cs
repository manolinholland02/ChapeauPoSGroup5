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
            //MessageBox.Show($"{employeeService.GetEmployeeType(username)}");

            if (employeeService.AccountExists(username, password) == true)
            {
                EmployeeType type = employeeService.GetEmployeeType(username);
                // 1) employee type = manager -> Open ManagerViewForm
                if (type == EmployeeType.manager)
                {
                    ManagerView mv = new ManagerView();
                    mv.Show();
                }
                else if (type == EmployeeType.waiter)
                // 2) employee type = waiter -> Open RestaurantOverview
                {
                    RestaurantOverview ro = new RestaurantOverview();
                    ro.Show();
                }
                // 3) employee type = chef -> Open KitchenView
                else if (type == EmployeeType.chef)
                {
                    //...
                }
                // 4) employee type = bartender -> Open BarView
                else if (type == EmployeeType.barman)
                {
                    //
                }
            }
            else MessageBox.Show("No employee found");
        }

    }
}

