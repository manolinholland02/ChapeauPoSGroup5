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
using ChapeauModel;

namespace ChapeauUI
{
    public partial class LunchMenuForm : Form
    {
        const string starter = "starter";
        const string main = "main";
        const string dessert = "desert";
        public LunchMenuForm()
        {
            InitializeComponent();
            PopulateLunchMenus();
        }

        private void backbtnLunch_Click(object sender, EventArgs e)
        {
            //show the choosing order form
            this.Close(); // or hide
        }

        private void AddbtnLunch_Click(object sender, EventArgs e)
        {
            // add selected item to orders to temporary list with new orders
        }

        private void PopulateLunchMenus()
        {
            LunchStartersListView.Items.Clear();
            LunchMainListView.Items.Clear();
            LunchDessertListView.Items.Clear();
            LunchMenuLogic LunchService = new LunchMenuLogic();
            //Starters
            FillMenu(LunchService, starter, LunchStartersListView, "Starters");

            //Main
            FillMenu(LunchService, main, LunchMainListView, "Mains");

            //Dessert
            FillMenu(LunchService, dessert, LunchDessertListView, "Desserts");
        }


        private void FillMenu(LunchMenuLogic LunchService, string category, ListView listview, string Title)
        {
            listview.Columns.Add("ID", 30);
            listview.Columns.Add(Title, 200);
            List<LunchMenu> items = new List<LunchMenu>();
            items = LunchService.GetSpecificLunchMenu(category);
            foreach (LunchMenu item in items)
            {
                string[] output = { item.LunchMenuId.ToString(), item.MenuItemName };
                ListViewItem list = new ListViewItem(output);
                listview.Items.Add(list);
            }
        }

    }
}
