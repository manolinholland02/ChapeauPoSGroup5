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
using ChapeauLogic;

namespace ChapeauUI
{
    public partial class RestaurantOverview : Form
    {
        public RestaurantOverview()
        {
            InitializeComponent();
        }
        //Table table1 = new Table(1);
        //Table table2 = new Table(2);
        //Table table3 = new Table(3);
        //Table table4 = new Table(4);
        //Table table5 = new Table(5);
        //Table table6 = new Table(6);
        //Table table7 = new Table(7);
        //Table table8 = new Table(8);
        //Table table9 = new Table(9);
        //Table table10 = new Table(10);
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
            // create an instance of the table 
            TableService tableService = new TableService();
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

        private void btnTable2_Click(object sender, EventArgs e)
        {
            // code
        }
    }
}
