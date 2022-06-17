using System;
using System.Collections.Generic;
using System.Security.Cryptography;
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
        // method user for login -> verifying both username and password
        public bool EmployeeExists(string username, string password)
        {
            return _employeedb.EmployeeExists(username, password);
        }
        public bool AccountExists(string username)
        {
            return _employeedb.AccountExists(username);
        }
        public bool AccountExists(int password)
        {
            return _employeedb.AccountExists(password);
        }
        public EmployeeType GetEmployeeType(string username)
        {
            // convert string to EmployeeType
            return (EmployeeType)Enum.Parse(typeof(EmployeeType), _employeedb.GetEmployeeType(username));
        }
        public Employee GetEmployee(string username)
        {
            return _employeedb.GetEmployee(username);
        }
        //public int GetPassword(string username) => _employeedb.GetPassword(password);
        //public bool CredentialValidator(Employee employee)
        //{
        //    //Run password through hasher
        //    //Find hashed password and username in database
        //    //If it's in, return true
        //    int hashedPassword = GetPassword(employee.EmployeeUsername);
        //    int storedPassword = PasswordTosha256(employee.EmployeeUserPassword);
        //    if (hashedPassword == storedPassword) return true;
        //    else return false;
        //}
        // convert the password to sha256
        public string PasswordToSHA256(string password)
        {
            var crypt = new SHA256Managed();
            string hash = String.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(password));
            foreach (byte theByte in crypto)
            {
                hash += theByte.ToString("x2");
            }
            return hash;
        }

    }
}
