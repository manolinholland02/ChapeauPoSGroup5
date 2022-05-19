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
        public List<Employee> GetAllEmployees()
        {
            string query = "SELECT employeeId, firstName, lastName, username, userPassword, employeeType FROM [dbo.Employees]";
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
                    EmployeeFirstName = dr["firstName"].ToString(),
                    EmployeeLastName = dr["lastName"].ToString(),
                    EmployeeUsername = dr["username"].ToString(),
                    EmployeeUserPassword = dr["userPassword"].ToString(),
                    EmployeeType = (EmployeeType)dr["employeeType"]
                };
                employees.Add(employee);
            }
            return employees;
        }
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
                    new SqlParameter("@type", (int)employee.EmployeeType)
                };
                string query = $"INSERT INTO [dbo.Employee] (firstName, lastName, username, userPassword, employeeType) VALUES (@firstName, @lastName, @username, @password, @type)";
                ExecuteEditQuery(query, parameters);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void DeleteEmployee(int EmployeeId)
        {
            try
            {
                SqlParameter[] parameters = { new SqlParameter("@employeeId", EmployeeId) };
                string query = "DELETE FROM [dbo.Employee] WHERE employeeId = @employeeId";
                ExecuteEditQuery(query, parameters);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

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
                    new SqlParameter("@type", (int)employee.EmployeeType)
                };
                string query = $"UPDATE INTO [dbo.Employee] (firstName, lastName, username, userPassword, employeeType) VALUES (@firstName, @lastName, @username, @password, @type)";
                ExecuteEditQuery(query, parameters);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
