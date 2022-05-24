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
    public partial class DrinksMenuForm : Form
    {
        public DrinksMenuForm()
        {
            InitializeComponent();
        }

        private void AddDrinksbtn_Click(object sender, EventArgs e)
        {

        }

        private void BackDrinksbtn_Click(object sender, EventArgs e)
        {
            //show choosing order form
            this.Close();
        }
    }
}
