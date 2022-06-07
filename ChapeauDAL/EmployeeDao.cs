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
                    EmployeeID = (int)dr["EmployeeId"],
                    EmployeeFirstName = dr["firstName"].ToString(),
                    EmployeeLastName = dr["lastName"].ToString(),
                    EmployeeUsername = dr["username"].ToString(),
                    EmployeeUserPassword = (int)dr["userPassword"],
                    EmployeeType = (EmployeeType)Enum.Parse(typeof(EmployeeType), dr["employeeType"].ToString().ToLower()),
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
                    new SqlParameter("@username", employee.EmployeeUsername),
                    new SqlParameter("@password", employee.EmployeeUserPassword),
                    new SqlParameter("@type", (string)employee.EmployeeType.ToString())
                };
                string query = @$"INSERT INTO [dbo].[Employees] 
                                (firstName, lastName, username, userPassword, employeeType) 
                                VALUES (@firstName, @lastName, @username, @password, @type)";
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
                    new SqlParameter("@ID", employee.EmployeeID ),
                    new SqlParameter("@firstName", employee.EmployeeFirstName),
                    new SqlParameter("@lastName", employee.EmployeeLastName),
                    new SqlParameter("@username", employee.EmployeeUsername),
                    new SqlParameter("@password", employee.EmployeeUserPassword),
                    new SqlParameter("@type", employee.EmployeeType.ToString())
                };

                string query = @$"UPDATE[dbo].[Employees] 
                                SET firstName = @firstName, lastName = @lastName, username = @username, userPassword = @password, employeeType = @type 
                                WHERE employeeId = @ID;";
                ExecuteEditQuery(query, parameters);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        // check if account exists in the database
        public bool AccountExists(string username, int password)
        {
            string query = "SELECT COUNT(employeeId) AS Count from [dbo].[Employees] WHERE [username] = @username AND [userPassword] = @password";
            SqlParameter[] sqlParameters = { new SqlParameter("@username", username), new SqlParameter("@password", password) };
            DataTable table = ExecuteSelectQuery(query, sqlParameters);
            DataRow[] dr = table.Select();
            string count = dr[0]["Count"].ToString();
            if (Convert.ToInt32(count) == 0) return false;
            else return true;
        }

        //checks if username is taken
        public bool AccountExists(string username)
        {
            string query = "SELECT COUNT(employeeId) AS Count from [dbo].[Employees] WHERE [username] = @username";
            SqlParameter[] sqlParameters = { new SqlParameter("@username", username)};
            DataTable table = ExecuteSelectQuery(query, sqlParameters);
            DataRow[] dr = table.Select();
            string count = dr[0]["Count"].ToString();
            if (Convert.ToInt32(count) == 0) return false;
            else return true;
        }
        //checks if username is taken
        public bool AccountExists(int password)
        {
            string query = "SELECT COUNT(employeeId) AS Count from [dbo].[Employees] WHERE [userPassword] = @password";
            SqlParameter[] sqlParameters = { new SqlParameter("@password", password) };
            DataTable table = ExecuteSelectQuery(query, sqlParameters);
            DataRow[] dr = table.Select();
            string count = dr[0]["Count"].ToString();
            if (Convert.ToInt32(count) == 0) return false;
            else return true;
        }

        // return the employee type of the employee 
        public string GetEmployeeType(string username)
        {
            string type = "";
            string query = "SELECT employeeType FROM [dbo].[Employees] WHERE [username] = @username";
            SqlParameter[] parameters = { new SqlParameter("@username", username) };
            DataTable table = ExecuteSelectQuery(query, parameters);
            foreach (DataRow dr in table.Rows)
            {
                type = dr["employeeType"].ToString();
            }
            return type;
        }
        public Employee GetEmployee(string username)
        {
            string query = "SELECT employeeId, firstName, lastName, username, userPassword, employeeType FROM [dbo].[Employees] WHERE [username] = @username";
            SqlParameter[] parameters = { new SqlParameter("@username", username) };
            return ReadTable(ExecuteSelectQuery(query, parameters));
        }
        public Employee ReadTable(DataTable dataTable)
        {
            Employee employee = new Employee();
            foreach (DataRow dr in dataTable.Rows)
            {
                employee.EmployeeID = (int)dr["employeeId"];
                employee.EmployeeFirstName = dr["firstName"].ToString();
                employee.EmployeeLastName = dr["lastName"].ToString();
                employee.EmployeeUsername = dr["username"].ToString();
                employee.EmployeeUserPassword = (int)dr["userPassword"];
                employee.EmployeeType = (EmployeeType)Enum.Parse(typeof(EmployeeType), dr["employeeType"].ToString().ToLower());
            }
            return employee;
        }

    }
}
