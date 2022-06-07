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
using ChapeauLogic;
using ChapeauModel;

namespace ChapeauUI
{
    public partial class ManagerConformation : Form
    {
        Employee _manager;
        public ManagerConformation(Employee manager)
        {
            InitializeComponent();

            textBox_Password.PasswordChar = '●';
            _manager = manager;
        }

        private void ManagerConformation_Load(object sender, EventArgs e)
        {

        }
    }
}
