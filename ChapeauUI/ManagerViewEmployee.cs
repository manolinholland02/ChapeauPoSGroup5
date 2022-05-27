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
using ChapeauModel;
using ChapeauLogic;

namespace ChapeauUI
{
    public partial class ManagerViewEmployee : Form
    {
        public ManagerViewEmployee()
        {
            InitializeComponent();
            button_Edit_Employee.Enabled = false;
            button_Delete_Employee.Enabled = false;
            PrintEmployees();
        }

        private void listView_Employees_Management_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_Employees_Management.SelectedItems.Count > 0)
            {
                button_Delete_Employee.Enabled = true;
                button_Edit_Employee.Enabled = true;
            }
            else
            {
                button_Edit_Employee.Enabled = false;
                button_Delete_Employee.Enabled = false;
            }
        }

        private void button_Delete_Employee_Click(object sender, EventArgs e)
        {
            var itemToDelete = int.Parse(listView_Employees_Management.SelectedItems[0].SubItems[0].Text);
            EmployeeService employee = new EmployeeService();
            employee.DeleteEmployee(itemToDelete);
            PrintEmployees();

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

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the employees: " + e.Message);
            }
        }

        private void ManagerView_Load(object sender, EventArgs e)
        {

        }

        private void button_Add_Employee_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
            this.Hide();
        }

        private void button_Edit_Employee_Click(object sender, EventArgs e)
        {
            int employeeToEditID = int.Parse(listView_Employees_Management.SelectedItems[0].SubItems[0].Text);
            EmployeeService employeeService = new EmployeeService();
            List<Employee> employeesList = employeeService.GetAllEmployees();
            foreach (Employee employee in employeesList)
            {
                if(employee.EmployeeID == employeeToEditID)
                {
                    EditEmployee edit = new EditEmployee(employee);
                    edit.Show();
                    this.Hide();
                }
            }
        }

    }
}
