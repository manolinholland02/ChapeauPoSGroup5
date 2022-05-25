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
        private MenuItemCategory _category;
        private List<ListView> _listViews;
        public LunchMenuForm()
        {
            InitializeComponent();
            _category = MenuItemCategory.starter;
            _listViews = new List<ListView>();
            _listViews.Add(LunchStartersListView);
            _listViews.Add(LunchMainListView);
            _listViews.Add(LunchDessertListView);
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
            LunchMenuService lunchMenuService = new LunchMenuService();
            List<LunchMenu> lunchMenuItems = new List<LunchMenu>();

            int i = 0;
            while (_category <= MenuItemCategory.desert)
            {
                _listViews[i].Items.Clear();
                lunchMenuItems = lunchMenuService.GetSpecificLunchMenu(_category);
                FillMenu(lunchMenuItems, _listViews[i]);
                _category++;
                i++;
            }
        }

        private void FillMenu(List<LunchMenu> lunchMenuItems, ListView listView)
        {
            foreach (LunchMenu lunchMenu in lunchMenuItems)
            {
                string[] output = { lunchMenu.LunchMenuId.ToString(), lunchMenu.MenuItemName };
                ListViewItem item = new ListViewItem(output);
                listView.Items.Add(item);
            }
        }
    }
}
