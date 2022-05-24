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
            testlistview.Columns.Add("ID", 20);
            testlistview.Columns.Add("Name", 20);
            MenuItemService menuService = new MenuItemService();
            List<MenuItem> items = new List<MenuItem>();
            items = menuService.GetMenuItems();
            foreach (MenuItem item in items)
            {
                string[] output = { item.MenuItemID.ToString(), item.MenuItemName };
                ListViewItem list = new ListViewItem(output);
                testlistview.Items.Add(list);
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
