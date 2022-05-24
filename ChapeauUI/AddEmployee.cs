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
            ManagerView managerView = new ManagerView();
            managerView.Show();
            managerView.Hide();
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
                employeeType = EmployeeType.bartender;
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
            Employee employee = new Employee();
            employee.EmployeeFirstName = firstName;
            employee.EmployeeLastName = lastName;
            employee.EmployeeUsername = username;
            employee.EmployeeUserPassword = password;
            employee.EmployeeType = employeeType;
            EmployeeService employeeService = new EmployeeService();
            employeeService.AddEmployee(employee);
            ManagerView mv = new ManagerView();
            mv.Show();
            this.Hide();
        }
    }
}
