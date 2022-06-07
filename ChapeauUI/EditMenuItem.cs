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
    public partial class EditMenuItem : Form
    {
        private MenuItem _ItemToEdit;
        private Employee _manager;
        private MenuItemService _menuItemService;
        string _operation = "EditMenuItem";
        private MessageBoxButtons messageBoxButtons;
        private DialogResult result;

        public EditMenuItem(MenuItem item, Employee manager)
        {
            InitializeComponent();
            _menuItemService = new MenuItemService();
            _ItemToEdit = item;
            _manager = manager;
            messageBoxButtons = MessageBoxButtons.YesNo;
            label_managerName.Text = $"{_manager.EmployeeFirstName}\n{_manager.EmployeeLastName}";
            textBox_Menu_Name.Text = _ItemToEdit.MenuItemName;
            textBox_Menu_Price.Text = _ItemToEdit.MenuItemPrice.ToString("0.00");
            textBox_Menu_Stock.Text = _ItemToEdit.MenuItemStock.ToString();
            string[] time = _ItemToEdit.AveragePreparationTime.Split(":");
            textBox_Menu_Time_Hours.Text = time[0];
            textBox_Menu_Time_Minutes.Text = time[1];
            textBox_Menu_Time_Seconds.Text = time[2];
            if(_ItemToEdit.isFood)
            {
                radioButton_Menu_Item_Food.Checked = true;
                PrintFoodType();
                PrintFoodCategory();
            }
            else 
            {
                radioButton_Menu_Item_Drink.Checked = true;
                PrintDrinkCategory();
                PrintDrinkType();
            }
            comboBox_Menu_Item_Category.SelectedItem = _ItemToEdit.MenuItemCategory.ToString();
            comboBox_Menu_Item_Type.SelectedItem = _ItemToEdit.MenuItemType.ToString();

            
        }

        private void button_Edit_MenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _ItemToEdit.MenuItemName = textBox_Menu_Name.Text;
                _ItemToEdit.MenuItemPrice = decimal.Parse(textBox_Menu_Price.Text);
                int hours = int.Parse(textBox_Menu_Time_Hours.Text);
                int minutes = int.Parse(textBox_Menu_Time_Minutes.Text);
                int seconds = int.Parse(textBox_Menu_Time_Seconds.Text);
                _ItemToEdit.AveragePreparationTime = $"{hours:00}:{minutes:00}:{seconds:00}";
                _ItemToEdit.MenuItemStock = int.Parse(textBox_Menu_Stock.Text);
                if (comboBox_Menu_Item_Category.Text == "Category")
                {
                    MessageBox.Show("Please select Category!");
                }
                else if (comboBox_Menu_Item_Type.Text == "Type")
                {
                    MessageBox.Show("Please select Type!");
                }
                else
                {
                    _ItemToEdit.MenuItemCategory = (MenuItemCategory)Enum.Parse(typeof(MenuItemCategory), comboBox_Menu_Item_Category.SelectedItem.ToString());
                    _ItemToEdit.MenuItemType = (MenuType)Enum.Parse(typeof(MenuType), comboBox_Menu_Item_Type.SelectedItem.ToString());
                    bool isFood = false;
                    if (radioButton_Menu_Item_Drink.Checked == true)
                    {
                        isFood = false;
                    }
                    if (radioButton_Menu_Item_Food.Checked == true)
                    {
                        isFood = true;
                    }
                    _ItemToEdit.isFood = isFood;
                    
                    ManagerConformation conformation = new ManagerConformation(_manager, _operation, _ItemToEdit, this);
                    conformation.Show();
                }

            }
            catch (Exception _exception)
            {

                MessageBox.Show("Something went wrong while adding the menu item: " + _exception.Message);
            }
        }

        private void PrintDrinkCategory()
        {
            comboBox_Menu_Item_Category.Items.Clear();
            List<string> categories = _menuItemService.GetDrinkCategory();
            //add drink categories
            foreach (string cat in categories)
            {

                comboBox_Menu_Item_Category.Items.Add(cat);
            }
        }
        private void PrintDrinkType()
        {
            comboBox_Menu_Item_Type.Items.Clear();
            List<string> type = _menuItemService.GetDrinkType();
            //add drink types
            foreach (string t in type)
            {
                comboBox_Menu_Item_Type.Items.Add(t);

            }
        }
        private void PrintFoodType()
        {
            comboBox_Menu_Item_Type.Items.Clear();
            List<string> type = _menuItemService.GetFoodType();
            //add food types
            foreach (string t in type)
            {

                comboBox_Menu_Item_Type.Items.Add(t);
            }
        }
        private void PrintFoodCategory()
        {
            comboBox_Menu_Item_Category.Items.Clear();
            List<string> categories = _menuItemService.GetFoodCategory();
            //add food categories
            foreach (string cat in categories)
            {

                comboBox_Menu_Item_Category.Items.Add(cat);
            }
        }

        private void radioButton_Menu_Item_Food_CheckedChanged(object sender, EventArgs e)
        {
            
            PrintFoodCategory();
            PrintFoodType();
        }

        private void radioButton_Menu_Item_Drink_CheckedChanged(object sender, EventArgs e)
        {
            
            PrintDrinkCategory();
            PrintDrinkType();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            ManagerViewMenu viewMenu = new ManagerViewMenu(_manager);
            viewMenu.Show();
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

        private void EditMenuItem_Load(object sender, EventArgs e)
        {

        }
    }
}
