using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class LunchMenuForm : Form
    {
        public LunchMenuForm()
        {
            InitializeComponent();
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
    }
}
