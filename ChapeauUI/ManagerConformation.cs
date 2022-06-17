using System;
using System.Drawing;
using System.Windows.Forms;
using ChapeauLogic;
using ChapeauModel;

namespace ChapeauUI
{
    public partial class ManagerConformation : Form
    {
        private Employee _manager;
        private string _operation;
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
            this.BackColor = ColorTranslator.FromHtml("#E8DCCA");
            _operation = operation;
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
            previousForm = previous;
            _IdToDelete = Id;
            this.BackColor = ColorTranslator.FromHtml("#E8DCCA");
        }
        public ManagerConformation(Employee manager, string operation, MenuItem menuItem, Form previous)
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#E8DCCA");
            label_Error.Visible = false;
            textBox_Password.PasswordChar = '●';
            _manager = manager;
            _operation = operation;
            _item = menuItem;
            previousForm = previous;
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm.Show();
        }
        private void button_Proceed_Click(object sender, EventArgs e)
        {
            EmployeeService employeeService = new EmployeeService();
            int password = int.Parse(textBox_Password.Text);
            if (/*employeeService.AccountExists(_manager.EmployeeUsername, password)*/ 1==1)
            {
                switch (_operation)
                {
                    case "AddEmployee": AddEmployee(); break;
                    case "DeleteEmployee": DeleteEmployee(); break;
                    case "EditEmployee": EditEmployee(); break;
                    case "AddMenuItem": AddMenuItem(); break;
                    case "EditMenuItem": EditMenuItem(); break;
                    case "DeleteMenuItem": DeleteMenuItem(); break;
                }
            }
            else
            {
                label_Error.Visible = true;
            }
        }
        private void DeleteEmployee()
        {
            EmployeeService employeeService = new EmployeeService();
            employeeService.DeleteEmployee(_IdToDelete);
            OpenEmployeeForm();
            previousForm.Hide();
        }
        private void DeleteMenuItem()
        {
            MenuItemService menuItemService = new MenuItemService();
            menuItemService.DeleteMenuItem(_IdToDelete);
            OpenMenuItemForm();
            previousForm.Hide();
        }
        private void AddEmployee()
        {
            EmployeeService employeeService = new EmployeeService();
            employeeService.AddEmployee(_employee);
            OpenEmployeeForm();
            previousForm.Hide();
        }
        private void AddMenuItem()
        {
            MenuItemService menuItemService = new MenuItemService();
            menuItemService.AddMenuItem(_item);
            previousForm.Hide();
            OpenMenuItemForm();
        }
        private void EditEmployee()
        {
            EmployeeService employeeService = new EmployeeService();
            employeeService.EditEmployee(_employee);
            previousForm.Hide();
            OpenEmployeeForm();
        }
        private void EditMenuItem()
        {
            MenuItemService menuItemService = new MenuItemService();
            menuItemService.UpdateMenuItem(_item);
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
