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
    public partial class OccupyDialogBox : Form
    {
        private static OccupyDialogBox uniqueInstance;

        private OccupyDialogBox()
        {
            InitializeComponent();
            lblMessage.Text = "Do you want to occupy \nthis table?";
        }

        public static OccupyDialogBox GetInstance()
        {
            if (uniqueInstance == null) uniqueInstance = new OccupyDialogBox();

            return uniqueInstance;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
