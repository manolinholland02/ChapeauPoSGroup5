using ChapeauLogic;
using ChapeauModel;
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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
            radioButton_AddEmployee_Bartender.Checked = false;
            radioButton_AddEmployee_Chef.Checked = false;
            radioButton_AddEmployee_Manager.Checked = false;
            radioButton_AddEmployee_Waiter.Checked = false;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            OpenManagerViewEmoloyees();
        }

        private void button_AddEmployee_Click(object sender, EventArgs e)
        {
            string firstName = textBox_AddEmployee_FirstName.Text;
            string lastName = textBox_AddEmployee_LastName.Text;
            string username = textBox_AddEmployee_Username.Text;
            int password = int.Parse(textBox_AddEmployee_Password.Text);
            EmployeeType employeeType = new EmployeeType();
            if(radioButton_AddEmployee_Bartender.Checked)
            {
                employeeType = EmployeeType.barman;
            }
            else if(radioButton_AddEmployee_Chef.Checked)
            {
                employeeType = EmployeeType.chef;
            }
            else if(radioButton_AddEmployee_Manager.Checked)
            {
                employeeType = EmployeeType.manager;
            }
            else if(radioButton_AddEmployee_Waiter.Checked)
            {
                employeeType = EmployeeType.waiter;
            }
            Employee employee = new Employee()
            {
                EmployeeFirstName = firstName,
                EmployeeLastName = lastName,
                EmployeeUsername = username,
                EmployeeUserPassword = password,
                EmployeeType = employeeType
            };
            
            EmployeeService employeeService = new EmployeeService();
            employeeService.AddEmployee(employee);
            OpenManagerViewEmoloyees();
            
        }

        private void OpenManagerViewEmoloyees()
        {
            ManagerViewEmployee viewEmployee = new ManagerViewEmployee();
            viewEmployee.Show();
            this.Hide();
        }

    }
}
