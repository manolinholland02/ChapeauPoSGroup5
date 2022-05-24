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
    public partial class DinnerMenuForm : Form
    {
        public DinnerMenuForm()
        {
            InitializeComponent();
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
    }
}
