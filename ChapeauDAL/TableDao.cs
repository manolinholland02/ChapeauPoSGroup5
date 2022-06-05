using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;

namespace ChapeauDAL
{
    public class TableDao : BaseDao
    {
        public Table GetTable(int id)
        {
            string query = "SELECT [tableId], [tableStatus] FROM [dbo].[RestaurantTables] WHERE [tableId] = @Id";
            SqlParameter[] parameters = { new SqlParameter("@Id", id) };
            return ReadTable(ExecuteSelectQuery(query, parameters));
        }

        private Table ReadTable(DataTable dataTable)
        {
            Table table = new Table();
            foreach (DataRow dr in dataTable.Rows)
            {
                table.TableId = (int)dr["tableId"];
                table.TableStatus = (TableStatus)Enum.Parse(typeof(TableStatus), dr["tableStatus"].ToString());
            }
            return table;
        }

        public void UpdateTableStatus(Table table)
        {
            string query = "UPDATE [RestaurantTables] SET [tableStatus] = @Status WHERE [tableId] = @Id";
            SqlParameter[] parameters = { new SqlParameter("@Id", table.TableId), new SqlParameter("@Status", table.TableStatus.ToString()) };
            ExecuteEditQuery(query, parameters);
        }


    }
}
