using ChapeauModel;
using System;
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
        Employee employee1;
        public RestaurantOverview(Employee employee)
        {
            InitializeComponent();
            employee1 = employee;
        }

        Table table = new Table();
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
                this.Hide();
            }
        }
        private void btnTable1_Click(object sender, EventArgs e)
        {
            table.TableId = 1;
            string message = btnTable1.Text;
            string title = btnTable1.Text;
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                LogIn login = new LogIn();
                login.Show();
                // mip delete the following AND the parameters of this whole form - also in the login form where this is called -also the gloabl variable and the one inside the ctor
                ChoosingMenuForm menu = new ChoosingMenuForm(table.TableId, employee1);
                menu.Show();
            }
            else
            {
                //
            }
        }

        private void btnTable2_Click(object sender, EventArgs e)
        {
            // code
        }
    }
}
