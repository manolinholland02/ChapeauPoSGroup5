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
        public AddMenuItem()
        {
            InitializeComponent();
            comboBox_Menu_Item_Category.Visible = false;
            comboBox_Menu_Item_Type.Visible = false;
        }

        private void PrintFoodCategory()
        {
            comboBox_Menu_Item_Category.Items.Clear();
            MenuItemService menuService = new MenuItemService();
            List<string> categories = menuService.GetFoodCategory();
            //add food categories
            foreach (string cat in categories)
            {

                comboBox_Menu_Item_Category.Items.Add(cat);
            }
        }
        private void PrintDrinkCategory()
        {
            comboBox_Menu_Item_Category.Items.Clear();
            MenuItemService menuService = new MenuItemService();
            List<string> categories = menuService.GetDrinkCategory();
            //add drink categories
            foreach (string cat in categories)
            {

                comboBox_Menu_Item_Category.Items.Add(cat);
            }
        }
        private void PrintDrinkType()
        {
            comboBox_Menu_Item_Type.Items.Clear();
            MenuItemService menuService = new MenuItemService();
            List<string> type = menuService.GetDrinkType();
            //add drink categories
            foreach (string cat in type)
            {

                comboBox_Menu_Item_Type.Items.Add(cat);
            }
        }
        private void PrintFoodType()
        {
            comboBox_Menu_Item_Type.Items.Clear();
            MenuItemService menuService = new MenuItemService();
            List<string> type = menuService.GetFoodType();
            //add drink categories
            foreach (string cat in type)
            {

                comboBox_Menu_Item_Type.Items.Add(cat);
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
    }
}
