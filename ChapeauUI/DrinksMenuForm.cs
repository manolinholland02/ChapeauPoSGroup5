using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauLogic;

namespace ChapeauUI
{
    public partial class DrinksMenuForm : Form
    {
        const string softDrinks = "softdrink";
        const string beers = "beer";
        const string wines = "wine";
        const string spirits = "spirit";
        const string coffeeTea = "caffeinated";
        public DrinksMenuForm()
        {
            InitializeComponent();
            PopulateDrinkMenus();
        }

        private void AddDrinksbtn_Click(object sender, EventArgs e)
        {

        }

        private void BackDrinksbtn_Click(object sender, EventArgs e)
        {
            //show choosing order form
            this.Close();
        }

        private void PopulateDrinkMenus()
        {
            SoftDrinksListView.Items.Clear();
            BeersListView.Items.Clear();
            WineListView.Items.Clear();
            SpiritsListView.Items.Clear();
            CoffeeTeaListView.Items.Clear();

            DrinksMenuService DrinkService = new DrinksMenuService();
            //Soft drink
            FillMenu(DrinkService, softDrinks, SoftDrinksListView, "Soft Drinks");
            //beers
            FillMenu(DrinkService, beers, BeersListView, "Beers");
            //wines
            FillMenu(DrinkService, wines, WineListView, "Wines");
            //spirits
            FillMenu(DrinkService, spirits, SpiritsListView, "Spirits");
            //caffeinated
            FillMenu(DrinkService, coffeeTea, CoffeeTeaListView, "Coffee And Tea");
        }

        private void FillMenu(DrinksMenuService DrinkService, string category, ListView listview, string Title)
        {
            listview.Columns.Add("ID", 30);
            listview.Columns.Add(Title, 200);
            List<DrinkMenu> items = new List<DrinkMenu>();
            items = DrinkService.GetSpecificDrinksMenu(category);
            foreach (DrinkMenu item in items)
            {
                string[] output = { item.DrinkMenuId.ToString(), item.MenuItemName };
                ListViewItem list = new ListViewItem(output);
                listview.Items.Add(list);
            }
        }
    }
}
