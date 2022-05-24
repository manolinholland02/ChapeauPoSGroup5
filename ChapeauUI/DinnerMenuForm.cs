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
            FillStarters(DinnerService);
            //entremets
            FillEntremets(DinnerService);
            //mains
            FillMains(DinnerService);
            //desserts
            FillDesserts(DinnerService);

        }

        private void FillStarters(DinnerMenuService DinnerService)
        {
            DinnerStartersListView.Columns.Add("ID", 30);
            DinnerStartersListView.Columns.Add("Starters", 200);
            List<DinnerMenu> starteritems = new List<DinnerMenu>();
            starteritems = DinnerService.GetspecficDinnerMenu(starter);
            foreach (DinnerMenu item in starteritems)
            {
                string[] output = { item.DinnerMenuId.ToString(), item.MenuItemName };
                ListViewItem list = new ListViewItem(output);
                DinnerStartersListView.Items.Add(list);
            }
        }

        private void FillEntremets(DinnerMenuService DinnerService)
        {
            DinnerEntremetsListView.Columns.Add("ID", 30);
            DinnerEntremetsListView.Columns.Add("Entremets", 200);
            List<DinnerMenu> entremetitems = new List<DinnerMenu>();
            entremetitems = DinnerService.GetspecficDinnerMenu(entremets);
            foreach (DinnerMenu item in entremetitems)
            {
                string[] output = { item.DinnerMenuId.ToString(), item.MenuItemName };
                ListViewItem list = new ListViewItem(output);
                DinnerEntremetsListView.Items.Add(list);
            }
        }
        private void FillMains(DinnerMenuService DinnerService)
        {
            DinnerMainListView.Columns.Add("ID", 30);
            DinnerMainListView.Columns.Add("Mains", 200);
            List<DinnerMenu> mainitems = new List<DinnerMenu>();
            mainitems = DinnerService.GetspecficDinnerMenu(main);
            foreach (DinnerMenu item in mainitems)
            {
                string[] output = { item.DinnerMenuId.ToString(), item.MenuItemName };
                ListViewItem list = new ListViewItem(output);
                DinnerMainListView.Items.Add(list);
            }
        }
        private void FillDesserts(DinnerMenuService DinnerService)
        {
            DinnerDessertsListView.Columns.Add("ID", 30);
            DinnerDessertsListView.Columns.Add("Desserts", 200);
            List<DinnerMenu> dessertitems = new List<DinnerMenu>();
            dessertitems = DinnerService.GetspecficDinnerMenu(dessert);
            foreach (DinnerMenu item in dessertitems)
            {
                string[] output = { item.DinnerMenuId.ToString(), item.MenuItemName };
                ListViewItem list = new ListViewItem(output);
                DinnerDessertsListView.Items.Add(list);
            }
        }
    }
}
