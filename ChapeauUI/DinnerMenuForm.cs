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
    public partial class DinnerMenuForm : Form
    {
        private MenuItemCategory _category;
        private List<ListView> _listViews;

        public DinnerMenuForm()
        {
            InitializeComponent();
            _category = MenuItemCategory.entremet;
            _listViews = new List<ListView>();
            _listViews.Add(DinnerEntremetsListView);
            _listViews.Add(DinnerStartersListView);
            _listViews.Add(DinnerMainListView);
            _listViews.Add(DinnerDessertsListView);
            PopulateDinnerMenus();
        }

        private void BackbtnDinner_Click(object sender, EventArgs e)
        {
            ChoosingMenuForm choosingForm = new ChoosingMenuForm();
            this.Close();
        }

        private void AddbtnDinner_Click(object sender, EventArgs e)
        {

        }

        private void PopulateDinnerMenus()
        {
            DinnerMenuService dinnerMenuService = new DinnerMenuService();
            List<DinnerMenu> dinnerMenuItems = new List<DinnerMenu>();

            int i = 0;
            while (_category <= MenuItemCategory.desert)
            {
                _listViews[i].Items.Clear();
                dinnerMenuItems = dinnerMenuService.GetspecficDinnerMenu(_category);
                FillMenu(dinnerMenuItems, _listViews[i]);
                _category++;
                i++;
            }
        }

        private void FillMenu(List<DinnerMenu> dinnerMenuItems, ListView listView)
        {
            foreach (DinnerMenu dinnerMenu in dinnerMenuItems)
            {
                string[] output = { dinnerMenu.DinnerMenuId.ToString(), dinnerMenu.MenuItemName };
                ListViewItem item = new ListViewItem(output);
                listView.Items.Add(item);
            }
        }
    }
}
