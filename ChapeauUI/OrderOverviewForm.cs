using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauDAL;

namespace ChapeauUI
{
    public partial class OrderOverviewForm : Form
    {
        public OrderOverviewForm()
        {
            InitializeComponent();
            
        }

        private void PlusOrderbtn_Click(object sender, EventArgs e)
        {

        }

        private void PopulateLunchMenus()
        {
            OrderlistView.Items.Clear();
            O LunchService = new LunchMenuLogic();
            
        }
    }
}
