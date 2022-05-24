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
        const string starter = "starter";
        const string entremets = "entremet";
        const string main = "main";
        const string dessert = "desert";
        public DinnerMenuForm()
        {
            InitializeComponent();
            PopulateDinnerMenus();
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            DinnerStartersListView.Items.Clear();
            DinnerEntremetsListView.Items.Clear();
            DinnerMainListView.Items.Clear();
            DinnerDessertsListView.Items.Clear();
            

            DinnerMenuService DinnerService = new DinnerMenuService();
            //Starters
            FillMenu(DinnerService, starter, DinnerStartersListView, "Starters");
            //entremets
            FillMenu(DinnerService, entremets, DinnerEntremetsListView, "Entremets");
            //mains
            FillMenu(DinnerService, main, DinnerMainListView, "Mains");
            //desserts
            FillMenu(DinnerService, dessert, DinnerDessertsListView, "Desserts");

        }

        private void FillMenu(DinnerMenuService DinnerService, string category, ListView listview, string Title)
        {
            listview.Columns.Add("ID", 30);
            listview.Columns.Add(Title, 200);
            List<DinnerMenu> items = new List<DinnerMenu>();
            items = DinnerService.GetspecficDinnerMenu(category);
            foreach (DinnerMenu item in items)
            {
                string[] output = { item.DinnerMenuId.ToString(), item.MenuItemName };
                ListViewItem list = new ListViewItem(output);
                listview.Items.Add(list);
            }
        }
    }
}
