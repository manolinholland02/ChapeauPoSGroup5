using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using ChapeauModel;

namespace ChapeauDAL
{
    public class EmployeeDao : BaseDao
    {
        //Creates a list with all of the employees in the Database
        public List<Employee> GetAllEmployees()
        {
            string query = "SELECT employeeId, firstName, lastName, username, userPassword, employeeType FROM [dbo].[Employees]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Employee> ReadTables(DataTable dataTable)
        {
            List<Employee> employees = new List<Employee>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Employee employee = new Employee()
                {
                    EmployeeID = (int)dr["employeeId"],
                    EmployeeFirstName = dr["firstName"].ToString(),
                    EmployeeLastName = dr["lastName"].ToString(),
                    EmployeeUsername = dr["username"].ToString(),
                    EmployeeUserPassword = dr["userPassword"].ToString(),
                    EmployeeType = (EmployeeType)Enum.Parse(typeof(EmployeeType), dr["employeeType"].ToString())
                };
                employees.Add(employee);
            }
            return employees;
        }

        //Add employee to the DataBase
        public void AddEmployee(Employee employee)
        {
            try
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("@firstName", employee.EmployeeFirstName),
                    new SqlParameter("@lastName", employee.EmployeeLastName),
                    new SqlParameter("@userame", employee.EmployeeUsername),
                    new SqlParameter("@password", employee.EmployeeUserPassword),
                    new SqlParameter("@type", (EmployeeType)employee.EmployeeType)
                };
                string query = $"INSERT INTO [dbo].[Employees] (firstName, lastName, username, userPassword, employeeType) VALUES (@firstName, @lastName, @username, @password, @type)";
                ExecuteEditQuery(query, parameters);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        //Deletes employee from the Database
        public void DeleteEmployee(int EmployeeId)
        {
            try
            {
                SqlParameter[] parameters = { new SqlParameter("@employeeId", EmployeeId) };
                string query = "DELETE FROM [dbo].[Employees] WHERE employeeId = @employeeId";
                ExecuteEditQuery(query, parameters);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //Edits employee in the Database
        public void EditEmployee(Employee employee)
        {
            try
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("@firstName", employee.EmployeeFirstName),
                    new SqlParameter("@lastName", employee.EmployeeLastName),
                    new SqlParameter("@userame", employee.EmployeeUsername),
                    new SqlParameter("@password", employee.EmployeeUserPassword),
                    new SqlParameter("@type", (EmployeeType)employee.EmployeeType)
                };
                string query = $"UPDATE INTO [dbo].[Employees] (firstName, lastName, username, userPassword, employeeType) VALUES (@firstName, @lastName, @username, @password, @type)";
                ExecuteEditQuery(query, parameters);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //Checks if and account with such a password exists in the Database
        public bool AccountExists(string username, string password)
        {
            string query = "SELECT COUNT([username]) from [dbo].[Employees] WHERE [username] = @username AND userPassword = @password;";
            SqlParameter[] sqlParameters = { new SqlParameter("@Username", username), new SqlParameter("@password", password) };
            DataTable output = ExecuteSelectQuery(query, sqlParameters);
            if (Convert.ToInt32(output.Rows[0][0]) == 1)
            {
                return true;
            }
            return false;
        }

        //return the employee type of the employee 
        public string GetEmployeeType(string username)
        {
            string query = "SELECT employeeType FROM [dbo].[Employees] WHERE [username] = @username";
            SqlParameter[] parameters = { new SqlParameter("@username", username) };
            return ExecuteSelectQuery(query, parameters).ToString();
        }
        // return the type of employee by password
        public string GetEmployeeTypeByPassword(string password)
        {
            string query = "SELECT employeeType FROM [dbo].[Employees] WHERE [userPassword] = @password";
            SqlParameter[] parameters = { new SqlParameter("@password", password) };
            return ExecuteSelectQuery(query, parameters).ToString();
        }
    }
}
