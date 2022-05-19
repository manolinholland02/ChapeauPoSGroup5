using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ChapeauDAL
{
    public abstract class BaseDao
    {
        private SqlDataAdapter _adapter;
        private SqlConnection _conn;
        private string _errorMsg;

        public BaseDao()
        {
            _conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ChapeauDatabase"].ConnectionString);
            _adapter = new SqlDataAdapter();
            _errorMsg = "An error with connecting to the database has occured: ";
        }

        protected SqlConnection OpenConnection()
        {
            try
            {
                if (_conn.State == ConnectionState.Closed || _conn.State == ConnectionState.Broken)
                {
                    _conn.Open();
                }
            }
            catch (Exception e)
            {
                throw new Exception(_errorMsg, e);
            }
            return _conn;
        }

        private void CloseConnection()
        {
            _conn.Close();
        }

        /* For Insert/Update/Delete Queries with transaction */
        protected void ExecuteEditTranQuery(string query, SqlParameter[] sqlParameters, SqlTransaction sqlTransaction)
        {
            SqlCommand command = new SqlCommand(query, _conn, sqlTransaction);
            try
            {
                command.Parameters.AddRange(sqlParameters);
                _adapter.InsertCommand = command;
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(_errorMsg, e);
            }
        }

        /* For Insert/Update/Delete Queries */
        protected void ExecuteEditQuery(string query, SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                _adapter.InsertCommand = command;
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                throw new Exception(_errorMsg, e);
            }
            finally
            {
                CloseConnection();
            }
        }

        /* For Select Queries */
        protected DataTable ExecuteSelectQuery(string query, params SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();
            DataTable dataTable;
            DataSet dataSet = new DataSet();

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                command.ExecuteNonQuery();
                _adapter.SelectCommand = command;
                _adapter.Fill(dataSet);
                dataTable = dataSet.Tables[0];
            }
            catch (SqlException e)
            {
                return null;
                throw new Exception(_errorMsg, e);
            }
            finally
            {
                CloseConnection();
            }
            return dataTable;
        }
    }
}

