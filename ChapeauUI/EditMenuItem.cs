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
        public EditMenuItem(MenuItem item, Employee manager)
        {
            InitializeComponent();
            _ItemToEdit = item;
            _manager = manager;
            textBox_Menu_Name.Text = _ItemToEdit.MenuItemName;
            textBox_Menu_Price.Text = _ItemToEdit.MenuItemPrice.ToString();
            textBox_Menu_Stock.Text = _ItemToEdit.MenuItemStock.ToString();
            string[] time = _ItemToEdit.AveragePreparationTime.Split(":");
            textBox_Menu_Time_Hours.Text = time[0];
            textBox_Menu_Time_Minutes.Text = time[1];
            textBox_Menu_Time_Seconds.Text = time[2];
            if(_ItemToEdit.isFood)
            {
                radioButton_Menu_Item_Food.Checked = true;
                
            }
            else 
            {
                radioButton_Menu_Item_Drink.Checked = true;
            }
            comboBox_Menu_Item_Category.SelectedItem = _ItemToEdit.MenuItemCategory.ToString();
            comboBox_Menu_Item_Type.SelectedItem = _ItemToEdit.MenuItemType.ToString();

            
        }

        private void button_Edit_MenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
