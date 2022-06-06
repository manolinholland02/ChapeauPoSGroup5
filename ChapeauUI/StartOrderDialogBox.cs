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
    public partial class StartOrderDialogBox : Form
    {
        private static StartOrderDialogBox uniqueInstance;

        private StartOrderDialogBox()
        {
            InitializeComponent();
            lblMessage.Text = "Do you want to add an order \n to this table?";
        }

        public static StartOrderDialogBox GetInstance()
        {
            if (uniqueInstance == null) uniqueInstance = new StartOrderDialogBox();

            return uniqueInstance;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.Close();
        }

        private void btnSetTableFree_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
