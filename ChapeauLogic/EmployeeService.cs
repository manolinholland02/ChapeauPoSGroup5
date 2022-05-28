using System;
using System.Collections.Generic;
using System.Text;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class EmployeeService
    {
        private EmployeeDao _employeedb;

        public EmployeeService()
        {
            _employeedb = new EmployeeDao();
        }

        public List<Employee> GetAllEmployees()
        {
            return _employeedb.GetAllEmployees();
        }

        public void AddEmployee(Employee employee)
        {
            _employeedb.AddEmployee(employee);
        }
        public void DeleteEmployee(int EmployeeId)
        {
            _employeedb.DeleteEmployee(EmployeeId);
        }
        public void EditEmployee(Employee employee)
        {
            _employeedb.EditEmployee(employee);
        }
        public bool AccountExists(string username, int password)
        {
            return _employeedb.AccountExists(username, password);
        }
        public EmployeeType GetEmployeeType(string username)
        {
            // convert string to EmployeeType
            return (EmployeeType)Enum.Parse(typeof(EmployeeType), _employeedb.GetEmployeeType(username));
        }
        public Employee GetEmployee()
        {
            return _employeedb.GetEmployee();
        }


    }
}
