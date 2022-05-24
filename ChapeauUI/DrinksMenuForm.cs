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
            FillSoftDrinks(DrinkService);
            //beers
            FillBeers(DrinkService);
            //wines
            FillWines(DrinkService);
            //spirits
            FillSpirits(DrinkService);
            //caffeinated
            FillCaffeinated(DrinkService);
        }

        private void FillSoftDrinks(DrinksMenuService DrinkService)
        {
            SoftDrinksListView.Columns.Add("ID", 30);
            SoftDrinksListView.Columns.Add("Soft Dinks", 200);
            List<DrinkMenu> softdrinkitems = new List<DrinkMenu>();
            softdrinkitems = DrinkService.GetSpecificDrinksMenu(softDrinks);
            foreach (DrinkMenu item in softdrinkitems)
            {
                string[] output = { item.DrinkMenuId.ToString(), item.MenuItemName };
                ListViewItem list = new ListViewItem(output);
                SoftDrinksListView.Items.Add(list);
            }
        }

        private void FillBeers(DrinksMenuService DrinkService)
        {
            BeersListView.Columns.Add("ID", 30);
            BeersListView.Columns.Add("Beers", 200);
            List<DrinkMenu> softdrinkitems = new List<DrinkMenu>();
            softdrinkitems = DrinkService.GetSpecificDrinksMenu(beers);
            foreach (DrinkMenu item in softdrinkitems)
            {
                string[] output = { item.DrinkMenuId.ToString(), item.MenuItemName };
                ListViewItem list = new ListViewItem(output);
                BeersListView.Items.Add(list);
            }
        }
        private void FillWines(DrinksMenuService DrinkService)
        {
            WineListView.Columns.Add("ID", 30);
            WineListView.Columns.Add("Wines", 200);
            List<DrinkMenu> softdrinkitems = new List<DrinkMenu>();
            softdrinkitems = DrinkService.GetSpecificDrinksMenu(wines);
            foreach (DrinkMenu item in softdrinkitems)
            {
                string[] output = { item.DrinkMenuId.ToString(), item.MenuItemName };
                ListViewItem list = new ListViewItem(output);
                WineListView.Items.Add(list);
            }
        }
        private void FillSpirits(DrinksMenuService DrinkService)
        {
            SpiritsListView.Columns.Add("ID", 30);
            SpiritsListView.Columns.Add("Spirits", 200);
            List<DrinkMenu> softdrinkitems = new List<DrinkMenu>();
            softdrinkitems = DrinkService.GetSpecificDrinksMenu(spirits);
            foreach (DrinkMenu item in softdrinkitems)
            {
                string[] output = { item.DrinkMenuId.ToString(), item.MenuItemName };
                ListViewItem list = new ListViewItem(output);
                SpiritsListView.Items.Add(list);
            }
        }

        private void FillCaffeinated(DrinksMenuService DrinkService)
        {
            CoffeeTeaListView.Columns.Add("ID", 30);
            CoffeeTeaListView.Columns.Add("Coffee and Tea", 200);
            List<DrinkMenu> softdrinkitems = new List<DrinkMenu>();
            softdrinkitems = DrinkService.GetSpecificDrinksMenu(coffeeTea);
            foreach (DrinkMenu item in softdrinkitems)
            {
                string[] output = { item.DrinkMenuId.ToString(), item.MenuItemName };
                ListViewItem list = new ListViewItem(output);
                CoffeeTeaListView.Items.Add(list);
            }
        }
    }
}
