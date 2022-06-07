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
        private Employee _manager;
        private string _operation;
        private EmployeeService _employeeService;
        private MenuItemService _menuItemService;
        private int _IdToDelete;
        private Employee _employee;
        private MenuItem _item;
        Form previousForm;
        public ManagerConformation(Employee manager, string operation, Employee employee,Form previous)
        {
            InitializeComponent();
            label_Error.Visible = false;
            textBox_Password.PasswordChar = '●';
            _manager = manager;
            _operation = operation;
            _menuItemService = new MenuItemService();
            _employeeService = new EmployeeService();
            _employee = employee;
            previousForm = previous;
            
        }
        public ManagerConformation(Employee manager, string operation, int Id, Form previous)
        {
            InitializeComponent();
            label_Error.Visible = false;
            textBox_Password.PasswordChar = '●';
            _manager = manager;
            _operation = operation;
            _menuItemService = new MenuItemService();
            _employeeService = new EmployeeService();
            previousForm = previous;
            _IdToDelete = Id;
        }
        public ManagerConformation(Employee manager, string operation, MenuItem menuItem, Form previous)
        {
            InitializeComponent();
            label_Error.Visible = false;
            textBox_Password.PasswordChar = '●';
            _manager = manager;
            _operation = operation;
            _menuItemService = new MenuItemService();
            _employeeService = new EmployeeService();
            _item = menuItem;
            previousForm = previous;
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_Proceed_Click(object sender, EventArgs e)
        {

            int password = int.Parse(textBox_Password.Text);
            if (_employeeService.AccountExists(_manager.EmployeeUsername, password))
            {
                switch (_operation)
                {
                    case "AddEmployee": AddEmployee(); break ;
                    case "DeleteEmployee": DeleteEmployee(); break; 
                    case "EditEmployee": EditEmployee(); break;
                    case "AddMenuItem": AddMenuItem();  break;
                    case "EditMenuItem": EditMenuItem(); break;
                    case "DeleteMenuItem":DeleteMenuItem(); break;
                }
            }
            else
            {
                label_Error.Visible = true;
            }
        }

        private void DeleteEmployee()
        {
            _employeeService.DeleteEmployee(_IdToDelete);
            OpenEmployeeForm();
            previousForm.Hide();
        }
        private void DeleteMenuItem()
        {
            _menuItemService.DeleteMenuItem(_IdToDelete);
            OpenMenuItemForm();
            previousForm.Hide();
        }
        
        private void AddEmployee()
        {
            _employeeService.AddEmployee(_employee);
            OpenEmployeeForm();
            previousForm.Hide();
        }
        private void AddMenuItem()
        {
            _menuItemService.AddMenuItem(_item);
            previousForm.Hide();
            OpenMenuItemForm();
        }
        private void EditEmployee()
        {
            _employeeService.EditEmployee(_employee);
            previousForm.Hide();
            OpenEmployeeForm();
        }
        private void EditMenuItem()
        {
            _menuItemService.UpdateMenuItem(_item);
            previousForm.Hide();
            OpenMenuItemForm();
        }
        private void OpenMenuItemForm()
        {
            ManagerViewMenu viewMenu = new ManagerViewMenu(_manager);
            viewMenu.Show();
            this.Hide();
        }
        private void OpenEmployeeForm()
        {
            ManagerViewEmployee viewEmployee = new ManagerViewEmployee(_manager);
            viewEmployee.Show();
            this.Hide();
        }
    }
}
