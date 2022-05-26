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
    public partial class EditEmployee : Form
    {
        private Employee _EmployeeToEdit { get; set; }
        public EditEmployee(Employee employee)
        {
            InitializeComponent();
            _EmployeeToEdit = employee;
            _EmployeeToEdit.EmployeeID = employee.EmployeeID;
            textBox_EditEmployee_FirstName.Text = _EmployeeToEdit.EmployeeFirstName.ToString();
            textBox_EditEmployee_LastName.Text = _EmployeeToEdit.EmployeeLastName.ToString();
            textBox_EditEmployee_Username.Text = _EmployeeToEdit.EmployeeUsername.ToString();
            textBox_EditEmployee_Password.Text = _EmployeeToEdit.EmployeeUserPassword.ToString();
            if(_EmployeeToEdit.EmployeeType == EmployeeType.barman)
            {
                radioButton_EditEmployee_Bartender.Checked = true;
            }
            else if (_EmployeeToEdit.EmployeeType == EmployeeType.waiter)
            {
                radioButton_EditEmployee_Waiter.Checked = true;
            }
            else if (_EmployeeToEdit.EmployeeType == EmployeeType.manager)
            {
                radioButton_EditEmployee_Manager.Checked = true;
            }
            else if (_EmployeeToEdit.EmployeeType == EmployeeType.chef)
            {
                radioButton_EditEmployee_Chef.Checked = true;
            }
        }

        private void button_EditEmployee_Click(object sender, EventArgs e)
        {
            
            _EmployeeToEdit.EmployeeFirstName = textBox_EditEmployee_FirstName.Text;
            _EmployeeToEdit.EmployeeLastName = textBox_EditEmployee_LastName.Text;
            _EmployeeToEdit.EmployeeUsername = textBox_EditEmployee_Username.Text;
            _EmployeeToEdit.EmployeeUserPassword = int.Parse(textBox_EditEmployee_Password.Text);
            if (radioButton_EditEmployee_Bartender.Checked)
            {
                _EmployeeToEdit.EmployeeType = EmployeeType.barman;
            }
            else if (radioButton_EditEmployee_Chef.Checked)
            {
                _EmployeeToEdit.EmployeeType = EmployeeType.chef;
            }
            else if (radioButton_EditEmployee_Manager.Checked)
            {
                _EmployeeToEdit.EmployeeType = EmployeeType.manager;
            }
            else if (radioButton_EditEmployee_Waiter.Checked)
            {
                _EmployeeToEdit.EmployeeType = EmployeeType.waiter;
            }
            EmployeeService employeeService = new EmployeeService();
            employeeService.EditEmployee(_EmployeeToEdit);
            ManagerView managerView = new ManagerView();
            managerView.Show();
            this.Hide();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            ManagerView managerView = new ManagerView();
            managerView.Show();
            this.Hide();
        }
    }
}
