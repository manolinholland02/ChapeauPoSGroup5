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
            txtPassword.PasswordChar = '●';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try 
            {
                // get password & username from user
                string username = txtUsername.Text;
                int password = int.Parse(txtPassword.Text);
                // open the corresponding screens depending on the type of employee
                EmployeeService employeeService = new EmployeeService();
                if (employeeService.AccountExists(username, password))
                {
                    Employee employee = employeeService.GetEmployee(username);

                    // 1) employee type = manager -> Open ManagerViewForm
                    if (employee.EmployeeType == EmployeeType.manager)
                    {
                        this.Close();
                        ManagerViewMenu managerView = new ManagerViewMenu();
                        managerView.Show();
                    }
                    else if (employee.EmployeeType == EmployeeType.waiter)
                    // 2) employee type = waiter -> Open RestaurantOverview
                    {
                        this.Hide();
                        RestaurantOverview restaurantOverview = new RestaurantOverview(employee);
                        restaurantOverview.Show();
                    }
                    // 3) employee type = chef/barman -> Open KitchenBarView
                    else if (employee.EmployeeType == EmployeeType.chef || employee.EmployeeType == EmployeeType.barman)
                    {
                        this.Close();
                        KitchenBarView kitchenBarView = KitchenBarView.GetInstance(employee);
                        kitchenBarView.Show();
                    }
                }
                else
                {
                    MessageBox.Show("No employee found.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }

    }
}

