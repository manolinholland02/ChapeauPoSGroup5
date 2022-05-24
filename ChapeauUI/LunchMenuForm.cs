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
        const string starterMenu = "starter";
        const string mainMenu = "main";
        const string dessertMenu = "desert";
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
            FillStarters(LunchService);

            //Main
            FillMain(LunchService);

            //Dessert
            FillDessert(LunchService);
        }

        private void FillStarters(LunchMenuLogic LunchService)
        {
            LunchStartersListView.Columns.Add("ID", 30);
            LunchStartersListView.Columns.Add("Starters", 200);
            List<LunchMenu> starteritems = new List<LunchMenu>();
            starteritems = LunchService.GetSpecificLunchMenu(starterMenu);
            foreach (LunchMenu item in starteritems)
            {
                string[] output = { item.LunchMenuId.ToString(), item.MenuItemName };
                ListViewItem list = new ListViewItem(output);
                LunchStartersListView.Items.Add(list);
            }
        }

        private void FillMain(LunchMenuLogic LunchService)
        {
            LunchMainListView.Columns.Add("ID", 30);
            LunchMainListView.Columns.Add("Main", 200);
            List<LunchMenu> mainitems = new List<LunchMenu>();
            mainitems = LunchService.GetSpecificLunchMenu(mainMenu);
            foreach (LunchMenu item in mainitems)
            {
                string[] output = { item.LunchMenuId.ToString(), item.MenuItemName };
                ListViewItem list = new ListViewItem(output);
                LunchMainListView.Items.Add(list);
            }
        }

        private void FillDessert(LunchMenuLogic LunchService)
        {
            LunchDessertListView.Columns.Add("ID", 30);
            LunchDessertListView.Columns.Add("Dessert", 200);
            List<LunchMenu> dessertitems = new List<LunchMenu>();
            dessertitems = LunchService.GetSpecificLunchMenu(dessertMenu);
            foreach (LunchMenu item in dessertitems)
            {
                string[] output = { item.LunchMenuId.ToString(), item.MenuItemName };
                ListViewItem list = new ListViewItem(output);
                LunchDessertListView.Items.Add(list);
            }
        }

    }
}
