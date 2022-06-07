using ChapeauLogic;
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
    public partial class AddMenuItem : Form
    {
        private MenuItemService _menuItemService;
        private Employee _manager;
        public AddMenuItem(Employee manager)
        {
            InitializeComponent();
            comboBox_Menu_Item_Category.Visible = false;
            comboBox_Menu_Item_Category.Text = "Category";
            comboBox_Menu_Item_Type.Visible = false;
            comboBox_Menu_Item_Type.Text = "Type";
            radioButton_Menu_Item_Drink.Checked = false;
            radioButton_Menu_Item_Food.Checked = false;
            textBox_Menu_Time_Hours.Text = "00";
            textBox_Menu_Time_Minutes.Text = "00";
            textBox_Menu_Time_Seconds.Text = "00";
            _menuItemService = new MenuItemService();
            _manager = manager;

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
            //add drink types
            foreach (string t in type)
            {

                comboBox_Menu_Item_Type.Items.Add(t);
            }
        }
        private void radioButton_Menu_Item_Food_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_Menu_Item_Category.Visible = true;
            comboBox_Menu_Item_Type.Visible = true;
            PrintFoodCategory();
            PrintFoodType();
        }
        private void radioButton_Menu_Item_Drink_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_Menu_Item_Category.Visible = true;
            comboBox_Menu_Item_Type.Visible = true;
            PrintDrinkCategory();
            PrintDrinkType();
        }

        private void comboBox_Menu_Item_Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            OpenManagerViewMenu();
        }

        private void button_Add_MenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                string Name = textBox_Menu_Name.Text;
                int price = int.Parse(textBox_Menu_Price.Text);
                int hours = int.Parse(textBox_Menu_Time_Hours.Text);
                int minutes = int.Parse(textBox_Menu_Time_Minutes.Text);
                int seconds = int.Parse(textBox_Menu_Time_Seconds.Text);
                string AverageTime = $"{hours:00}:{minutes:00}:{seconds:00}";
                int stock = int.Parse(textBox_Menu_Stock.Text);
                while (comboBox_Menu_Item_Category.Text == "Category")
                {
                    MessageBox.Show("znaeh si");
                }
                if(comboBox_Menu_Item_Category.Text== "Category")
                {
                    MessageBox.Show("Please select Category!");
                }
                else if (comboBox_Menu_Item_Type.Text == "Type")
                {
                    MessageBox.Show("Please select Type!");
                }

                MenuItemCategory menuItemCategory = (MenuItemCategory)Enum.Parse(typeof(MenuItemCategory), comboBox_Menu_Item_Category.SelectedItem.ToString());
                MenuType menuType = (MenuType)Enum.Parse(typeof(MenuType), comboBox_Menu_Item_Type.SelectedItem.ToString());
                bool isFood = false;
                if (radioButton_Menu_Item_Drink.Checked== true)
                {
                    isFood = false;
                }
                if (radioButton_Menu_Item_Food.Checked == true)
                {
                    isFood = true;
                }

                MenuItem item = new MenuItem()
                {
                    MenuItemName = Name,
                    MenuItemPrice = price,
                    isFood = isFood,
                    MenuItemStock = stock,
                    MenuItemType = menuType,
                    MenuItemCategory = menuItemCategory,
                    AveragePreparationTime = AverageTime
                };
                _menuItemService.AddMenuItem(item);
                OpenManagerViewMenu();
            }
            catch (Exception _exception)
            {

                MessageBox.Show("Something went wrong while adding the menu item: " + _exception.Message);
            }
            

        }
        private void OpenManagerViewMenu()
        {
            ManagerViewMenu viewMenu = new ManagerViewMenu(_manager);
            viewMenu.Show();
            this.Hide();
        }
    }
}
