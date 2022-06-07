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
        private Employee _EmployeeToEdit;
        private Employee _manager;
        public EditEmployee(Employee employee, Employee manager)
        {
            InitializeComponent();
            _EmployeeToEdit = employee;
            _manager = manager;
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
            if(PasswordChecker(textBox_EditEmployee_Password.Text))
            {

                _EmployeeToEdit.EmployeeUserPassword = int.Parse(textBox_EditEmployee_Password.Text);
                EmployeeService employeeService = new EmployeeService();
                employeeService.EditEmployee(_EmployeeToEdit);
                ManagerViewEmployee managerView = new ManagerViewEmployee(_manager);
                managerView.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Password must contaion 4 digits!");
            }
            
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            ManagerViewEmployee managerView = new ManagerViewEmployee(_manager);
            managerView.Show();
            this.Hide();
        }
        private bool PasswordChecker(string password)
        {
            string specialCharacter = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            foreach (char ch in specialCharacter)
            {
                //checks if password contains special characters
                if (password.Contains(ch))
                    return false;
            }
            if (password.ToString().Length != 4)
            {
                //checks if password is more or less than 4 symbols
                return false;
            }
            else if ( password.Any(char.IsUpper) || password.Any(char.IsLower))
            {
                //checks if password contains characters
                return false;
            }
            return true;
        }
    }
}
