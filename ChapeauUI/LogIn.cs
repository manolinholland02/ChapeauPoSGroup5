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
            string password = txtPassword.Text;
            // open the corresponding screens depending on the type of employee
            EmployeeService employeeService = new EmployeeService();
            EmployeeType type = employeeService.GetEmployeeTypeByPassword(password);
            // 1) employee type = manager -> Open ManagerViewForm
            if (type == EmployeeType.manager)
                new ManagerView();
            // 2) employee type = chef -> Open KitchenView
            // 3) employee type = waiter -> Open RestaurantOverview
            // 4) employee type = bartender -> Open BarView
        }
    }
}
