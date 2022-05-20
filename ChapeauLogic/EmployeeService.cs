using System;
using System.Collections.Generic;
using System.Text;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    class EmployeeService
    {
        private EmployeeDao _employeedb;

        public EmployeeService()
        {
            _employeedb = new EmployeeDao();
        }

        public List<Feedback> GetAllEmployees()
        {
            return _employeedb.GetAllEmployees();
        }

        public void AddEmployee(Feedback employee)
        {
            _employeedb.AddEmployee(employee);
        }
        public void DeleteEmployee(int EmployeeId)
        {
            _employeedb.DeleteEmployee(EmployeeId);
        }
        public void EditEmployee(Feedback employee)
        {
            _employeedb.EditEmployee(employee);
        }
    }
}
