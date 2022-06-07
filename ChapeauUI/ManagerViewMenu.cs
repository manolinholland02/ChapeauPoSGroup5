﻿using ChapeauLogic;
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

        public ManagerViewMenu(Employee manager)
        {
            InitializeComponent();
            button_Menu_Form.Enabled = false;
            button_Menu_Form.BackColor = Color.DarkGray;
            button_Menu_Form.ForeColor = Color.Black;
            DisplayMenu();
            _manager = manager;
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
                    for (int i = 0; i <= listView_Menu_Management.Items.Count - 1; i = (i + 2))
                    {
                        listView_Menu_Management.Items[i].BackColor = Color.AliceBlue;
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
    }


}
