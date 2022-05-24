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
    public partial class TESTFORM : Form
    {
        public TESTFORM()
        {
            InitializeComponent();
        }

        private void testformbtn_Click(object sender, EventArgs e)
        {
            testlistview.Items.Clear();
            MenuItemService menuitemsService = new MenuItemService();
            List<MenuItem> items = menuitemsService.GetMenuItems();
            foreach (MenuItem item in items)
            {
                ListViewItem li = new ListViewItem();
                li.SubItems.Add(item.MenuItemID.ToString());
                li.SubItems.Add(item.MenuItemName.ToString());
                li.SubItems.Add(item.MenuItemPrice.ToString());
                li.SubItems.Add(item.MenuItemStock.ToString());
                li.SubItems.Add(item.MenuItemType.ToString());
                li.SubItems.Add(item.MenuItemCategory.ToString());
                li.SubItems.Add(item.AveragePreparationTime);
                li.SubItems.Add(item.isFood.ToString());
                testlistview.Items.Add(li);
            }

        }
    }
}
