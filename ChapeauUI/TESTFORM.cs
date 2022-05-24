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
            MenuItemService menuService = new MenuItemService();
            List<MenuItem> items = new List<MenuItem>();
            items = menuService.GetMenuItems();
            foreach (MenuItem item in items)
            {
                ListViewItem li = new ListViewItem();
                li.SubItems.Add(item.MenuItemID.ToString());
                li.SubItems.Add(item.MenuItemName);

                testlistview.Items.Add(li);
            }
            //testlistview.Items.Clear();
            //LunchMenuLogic LunchService = new LunchMenuLogic();
            //List<LunchMenu> items = new List<LunchMenu>();
            //items = LunchService.GetLunchMenuItems();
            //foreach (LunchMenu item in items)
            //{
            //    ListViewItem li = new ListViewItem();
            //    li.SubItems.Add(item.LunchMenuId.ToString());
            //    li.SubItems.Add(item.MenuItemName);

            //    testlistview.Items.Add(li);
            //}

        }
    }
}
