using ChapeauLogic;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class ManagerViewMenu : Form
    {
        private Employee _manager;
        public ManagerViewMenu(Employee manager)
        {
            InitializeComponent();
            button_Menu_Form.Enabled = false;
            button_Menu_Form.BackColor = Color.DarkGray;
            button_Menu_Form.ForeColor = Color.Black;
            button_Add_Menu_Item.BackColor = ColorTranslator.FromHtml("#66CCFF");
            button_Delete_MenuItem.Enabled = false;
            button_Edit_MenuItem.Enabled = false;
            DisplayMenu();
            _manager = manager;
            this.BackColor = ColorTranslator.FromHtml("#E8DCCA");
            label_managerName.Text = $"{_manager.EmployeeFirstName}\n{_manager.EmployeeLastName}";
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
            MessageBoxButtons messageBoxButtons;
            DialogResult result;
            messageBoxButtons = MessageBoxButtons.YesNo;
            string message = "Are you sure you want to Logout?";
            string title = "Logout";
            result = MessageBox.Show(message, title, messageBoxButtons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                LogIn logIn = new LogIn();
                logIn.Closed += (ss, ee) => this.Close();
                logIn.Show();
            }
        }
        private void listView_Menu_Management_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Menu_Management.SelectedItems.Count > 0)
            {
                button_Delete_MenuItem.Enabled = true;
                button_Edit_MenuItem.Enabled = true;
                button_Edit_MenuItem.BackColor = ColorTranslator.FromHtml("#66CCFF");
                button_Delete_MenuItem.BackColor = ColorTranslator.FromHtml("#66CCFF");
            }
            else
            {
                button_Edit_MenuItem.Enabled = false;
                button_Delete_MenuItem.Enabled = false;
                button_Edit_MenuItem.BackColor = Color.Gainsboro;
                button_Delete_MenuItem.BackColor = Color.Gainsboro;
            }
        }

        private void button_Edit_MenuItem_Click(object sender, EventArgs e)
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
        private void button_Delete_MenuItem_Click(object sender, EventArgs e)
        {
            string operation = "DeleteMenuItem";
            int itemToDelete = int.Parse(listView_Menu_Management.SelectedItems[0].SubItems[0].Text);
            ManagerConformation managerConformation = new ManagerConformation(_manager, operation, itemToDelete, this);
            managerConformation.Show();
        }
    }
}
