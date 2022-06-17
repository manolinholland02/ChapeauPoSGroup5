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
        // get employee password from the database
        public string GetPassword(string username)
        {
            string query = "SELECT userPassword from [dbo].[Employees] WHERE [username] = @username;";
            SqlParameter[] sqlParameters = { new SqlParameter("@username", username) };
            DataTable output = ExecuteSelectQuery(query, sqlParameters);
            return (string)output.Rows[0]["userPassword"];
        }
        // Creates a list with all of the employees in the Database
        public List<Employee> GetAllEmployees()
        {
            try
            {
                string query = "SELECT employeeId, firstName, lastName, username, userPassword, employeeType FROM [dbo].[Employees]";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                return ReadTables(ExecuteSelectQuery(query, sqlParameters));
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong while loading the employees: " + e.Message);
            }
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
                    EmployeeUserPassword = dr["userPassword"].ToString(),
                    EmployeeType = (EmployeeType)Enum.Parse(typeof(EmployeeType), dr["employeeType"].ToString().ToLower()),
                };
                employees.Add(employee);
            }
            return employees;
        }

        // Add employee to the DataBase
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
        // Delete employee from the Database
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

        // Edit employee in the Database
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
        public bool EmployeeExists(string username, string password)
        {
            try
            {

                string query = "SELECT COUNT(employeeId) AS Count from [dbo].[Employees] WHERE [username] = @username AND [userPassword] = @password";
                SqlParameter[] sqlParameters = { new SqlParameter("@username", username), new SqlParameter("@password", password) };
                DataTable table = ExecuteSelectQuery(query, sqlParameters);
                DataRow[] dr = table.Select();
                string count = dr[0]["Count"].ToString();
                if (Convert.ToInt32(count) == 0) return false;
                else return true;
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong while checking if the account exists: " + e.Message);
            }
        }

        //checks if username is taken
        public bool AccountExists(string username)
        {
            try
            {
                string query = "SELECT COUNT(employeeId) AS Count from [dbo].[Employees] WHERE [username] = @username";
                SqlParameter[] sqlParameters = { new SqlParameter("@username", username) };
                DataTable table = ExecuteSelectQuery(query, sqlParameters);
                DataRow[] dr = table.Select();
                string count = dr[0]["Count"].ToString();
                if (Convert.ToInt32(count) == 0) return false;
                else return true;
            }
            catch (Exception e)
            {
                throw new Exception("Something went wrong while checking if the username is taken: " + e.Message);
            }
        }
        //checks if username is taken
        public bool AccountExists(int password)
        {
            try
            {
                string query = "SELECT COUNT(employeeId) AS Count from [dbo].[Employees] WHERE [userPassword] = @password";
                SqlParameter[] sqlParameters = { new SqlParameter("@password", password) };
                DataTable table = ExecuteSelectQuery(query, sqlParameters);
                DataRow[] dr = table.Select();
                string count = dr[0]["Count"].ToString();
                if (Convert.ToInt32(count) == 0) return false;
                else return true;
            }
            catch (Exception e)
            {

                throw new Exception("Something went wrong while checking if the password is taken: " + e.Message);
            }
            
        }

        // return the employee type of the employee 
        public string GetEmployeeType(string username)
        {
            try
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
            catch (Exception e)
            {
                throw new Exception("Something went wrong while retrieving the employee type: " + e.Message);
            }

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
                employee.EmployeeUserPassword = dr["userPassword"].ToString();
                employee.EmployeeType = (EmployeeType)Enum.Parse(typeof(EmployeeType), dr["employeeType"].ToString().ToLower());
            }
            return employee;
        }

    }
}
