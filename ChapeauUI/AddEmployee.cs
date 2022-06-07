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
        private Employee _manager;
        public AddEmployee(Employee manager)
        {
            InitializeComponent();
            radioButton_AddEmployee_Bartender.Checked = false;
            radioButton_AddEmployee_Chef.Checked = false;
            radioButton_AddEmployee_Manager.Checked = false;
            radioButton_AddEmployee_Waiter.Checked = false;
            _manager = manager;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            OpenManagerViewEmoloyees();
        }

        private void button_AddEmployee_Click(object sender, EventArgs e)
        {
            try
                
            {
                EmployeeService employeeService = new EmployeeService();
                if(textBox_AddEmployee_FirstName.Text == "")
                {
                    MessageBox.Show("Please fill in first name!");
                }
                else if(textBox_AddEmployee_LastName.Text == null)
                {
                    MessageBox.Show("Please fill in last name!");
                }
                else if(employeeService.AccountExists(textBox_AddEmployee_Username.Text))
                {
                    MessageBox.Show("Username is taken! Please select a new one!");
                }
                else if(!PasswordChecker(textBox_AddEmployee_Password.Text))
                {
                    MessageBox.Show("Password should contain 4 digits!");
                }
                else if(employeeService.AccountExists(int.Parse(textBox_AddEmployee_Password.Text)))
                {
                    MessageBox.Show("Password is taken! Please select a new one!");
                }
                else if(radioButton_AddEmployee_Bartender.Checked == false || radioButton_AddEmployee_Chef.Checked == false || radioButton_AddEmployee_Manager.Checked == false || radioButton_AddEmployee_Waiter.Checked == false)
                {
                    MessageBox.Show("Please select an occupation!");
                }
                else
                {
                    
                    string firstName = textBox_AddEmployee_FirstName.Text;
                    string lastName = textBox_AddEmployee_LastName.Text;
                    string username = textBox_AddEmployee_Username.Text;
                    int password = int.Parse(textBox_AddEmployee_Password.Text);
                    EmployeeType employeeType = new EmployeeType();
                    if (radioButton_AddEmployee_Bartender.Checked)
                    {
                        employeeType = EmployeeType.barman;
                    }
                    else if (radioButton_AddEmployee_Chef.Checked)
                    {
                        employeeType = EmployeeType.chef;
                    }
                    else if (radioButton_AddEmployee_Manager.Checked)
                    {
                        employeeType = EmployeeType.manager;
                    }
                    else if (radioButton_AddEmployee_Waiter.Checked)
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

                    employeeService.AddEmployee(employee);
                    OpenManagerViewEmoloyees();
                }
            }
            catch (Exception _e)
            {

                MessageBox.Show("Something went wrong while adding the employee: " + _e.Message);
                throw;
            }
            
            
        }

        private void OpenManagerViewEmoloyees()
        {
            ManagerViewEmployee viewEmployee = new ManagerViewEmployee(_manager);
            viewEmployee.Show();
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
            else if (password.Any(char.IsUpper) || password.Any(char.IsLower))
            {
                //checks if password contains characters
                return false;
            }
            return true;
        }
    }
}
