using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauLogic;

namespace ChapeauUI
{
    public partial class ManagerViewEmployee : Form
    {
        private Employee _manager;
        public ManagerViewEmployee(Employee manager)
        {
            InitializeComponent();
            button_Edit_Employee.Enabled = false;
            button_Delete_Employee.Enabled = false;
            PrintEmployees();
            button_Employees_Form.Enabled = false;
            button_Employees_Form.BackColor = Color.DarkGray;
            button_Employees_Form.ForeColor = Color.Black;
            _manager = manager;
            label_managerName.Text = $"{_manager.EmployeeFirstName}\n{_manager.EmployeeLastName}";
            this.BackColor = ColorTranslator.FromHtml("#E8DCCA");
            button_Add_Employee.BackColor = ColorTranslator.FromHtml("#66CCFF");
        }
        private void listView_Employees_Management_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView_Employees_Management.SelectedItems.Count > 0)
                {
                    button_Delete_Employee.Enabled = true;
                    button_Edit_Employee.Enabled = true;
                    button_Edit_Employee.BackColor = ColorTranslator.FromHtml("#66CCFF");
                    button_Delete_Employee.BackColor = ColorTranslator.FromHtml("#66CCFF");
                }
                else
                {
                    button_Edit_Employee.Enabled = false;
                    button_Delete_Employee.Enabled = false;
                    button_Edit_Employee.BackColor = Color.Gainsboro;
                    button_Delete_Employee.BackColor = Color.Gainsboro;
                }
            }
            catch (Exception _e)
            {
                MessageBox.Show(_e.Message);
                throw;
            }
            
        }
        private void button_Delete_Employee_Click(object sender, EventArgs e)
        {
            try
            { 
                string operation = "DeleteEmployee";
                var itemToDelete = int.Parse(listView_Employees_Management.SelectedItems[0].SubItems[0].Text);
                ManagerConformation managerConformation = new ManagerConformation(_manager, operation, itemToDelete, this);
                managerConformation.Show();
            }
            catch (Exception _e)
            {
                MessageBox.Show("Something went wrong: " + _e.Message);
                throw;
            }
        }
        private void PrintEmployees()
        {
            try
            {
                EmployeeService employeeService = new EmployeeService();
                List<Employee> employeesList = employeeService.GetAllEmployees(); 
                listView_Employees_Management.Items.Clear();
                foreach (Employee employee in employeesList)
                {
                    string[] output = { employee.EmployeeID.ToString(), employee.EmployeeFirstName, employee.EmployeeLastName,
                                        employee.EmployeeUsername, employee.EmployeeUserPassword.ToString(), employee.EmployeeType.ToString() };
                    ListViewItem list = new ListViewItem(output);
                    listView_Employees_Management.Items.Add(list);
                    for (int i = 0; i <= listView_Employees_Management.Items.Count - 1; i = (i + 2))
                    {
                        listView_Employees_Management.Items[i].BackColor = Color.AliceBlue;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the employees: " + e.Message);
            }
        }
        private void button_Add_Employee_Click(object sender, EventArgs e)
        {
            try
            {
                AddEmployee addEmployee = new AddEmployee(_manager);
                addEmployee.Show();
                this.Hide();
            }
            catch (Exception _e)
            {
                MessageBox.Show("Something went wrong: " + _e.Message);
                throw;
            }
            
        }
        private void button_Edit_Employee_Click(object sender, EventArgs e)
        {
            try
            {
                int employeeToEditID = int.Parse(listView_Employees_Management.SelectedItems[0].SubItems[0].Text);
                EmployeeService employeeService = new EmployeeService();
                List<Employee> employeesList = employeeService.GetAllEmployees();
                foreach (Employee employee in employeesList)
                {
                    if (employee.EmployeeID == employeeToEditID)
                    {
                        EditEmployee edit = new EditEmployee(employee, _manager);
                        edit.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception _e)
            {
                MessageBox.Show("Something went wrong: " + _e.Message);
                throw;
            }
            
        }
        private void label_managerName_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messageBoxButtons;
            DialogResult result;
            messageBoxButtons = MessageBoxButtons.YesNo;
            string message = "Are you sure you want to Logout?";
            string title = "Logout";
            result = MessageBox.Show(message, title, messageBoxButtons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                LogIn logIn = new LogIn();
                logIn.Closed += (ss, ee) => this.Close();
                logIn.Show();
            }
        }
        private void button_Menu_Form_Click(object sender, EventArgs e)
        {
            ManagerViewMenu viewMenu = new ManagerViewMenu(_manager);
            viewMenu.Show();
            this.Hide();
        }
    }
}
