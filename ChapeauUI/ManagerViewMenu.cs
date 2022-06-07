using ChapeauLogic;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class ManagerViewMenu : Form
    {
        private Employee _manager;

        private MessageBoxButtons messageBoxButtons;
        private DialogResult result;

        public ManagerViewMenu(Employee manager)
        {
            InitializeComponent();
            button_Menu_Form.Enabled = false;
            button_Menu_Form.BackColor = Color.DarkGray;
            button_Menu_Form.ForeColor = Color.Black;
            button_Add_Menu_Item.BackColor = ColorTranslator.FromHtml("#66CCFF");
            button_Delete_Employee.Enabled = false;
            button_Edit_Employee.Enabled = false;
            DisplayMenu();
            _manager = manager;

            label_managerName.Text = $"{_manager.EmployeeFirstName}\n{_manager.EmployeeLastName}";
            messageBoxButtons = MessageBoxButtons.YesNo;

        }

        private void DisplayMenu()
        {
            try
            {
                MenuItemService menuService = new MenuItemService();
                List<MenuItem> menuList = menuService.GetMenuItems();

                listView_Menu_Management.Items.Clear();
                string foorOrDrink = "";

                foreach (MenuItem item in menuList)
                {

                    if(item.isFood)
                    {
                        foorOrDrink = "Food";
                    }
                    else
                    {
                        foorOrDrink = "Drink";
                    }
                   
                    string[] output = { item.MenuItemID.ToString(), item.MenuItemName, item.MenuItemType.ToString(), item.MenuItemCategory.ToString(),
                                        foorOrDrink, item.MenuItemPrice.ToString("€0.00"), item.MenuItemStock.ToString(), item.AveragePreparationTime.ToString() };
                    ListViewItem list = new ListViewItem(output);
                    listView_Menu_Management.Items.Add(list);

                    
                    for (int i = 0; i <= listView_Menu_Management.Items.Count - 1; i ++)
                    {
                        if(i%2==0)
                        listView_Menu_Management.Items[i].BackColor = Color.AliceBlue;
                        if (int.Parse(listView_Menu_Management.Items[i].SubItems[6].Text) < 10)
                        {
                            listView_Menu_Management.Items[i].UseItemStyleForSubItems = false;
                            listView_Menu_Management.Items[i].SubItems[6].ForeColor = Color.Red;
                        }
                        else
                        {
                            listView_Menu_Management.Items[i].SubItems[6].ForeColor = Color.Black;
                        }
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the menu: " + e.Message);
            }
        }

        private void ManagerViewMenu_Load(object sender, EventArgs e)
        {

        }

        private void button_Add_Menu_Item_Click(object sender, EventArgs e)
        {
            AddMenuItem addItem = new AddMenuItem(_manager);
            addItem.Show();
            this.Hide();
        }

        private void button_Employees_Form_Click(object sender, EventArgs e)
        {
            ManagerViewEmployee viewEmployee = new ManagerViewEmployee(_manager);
            viewEmployee.Show();
            this.Hide();
        }

        private void label_managerName_Click(object sender, EventArgs e)
        {
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


        private void listView_Menu_Management_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Menu_Management.SelectedItems.Count > 0)
            {
                button_Delete_Employee.Enabled = true;
                button_Edit_Employee.Enabled = true;
                button_Edit_Employee.BackColor = ColorTranslator.FromHtml("#66CCFF");
                button_Delete_Employee.BackColor = ColorTranslator.FromHtml("#66CCFF");
            }
            else
            {
                button_Edit_Employee.Enabled = false;
                button_Delete_Employee.Enabled = false;
            }
        }

        private void button_Edit_Employee_Click(object sender, EventArgs e)
        {
            int itemToEditID = int.Parse(listView_Menu_Management.SelectedItems[0].SubItems[0].Text);
            MenuItemService service = new MenuItemService();
            List<MenuItem> items = service.GetMenuItems();
            foreach (MenuItem item in items)
            {
                if (item.MenuItemID == itemToEditID)
                {
                    EditMenuItem edit = new EditMenuItem(item, _manager);
                    edit.Show();
                    this.Hide();
                }
            }
        }

    }


}
