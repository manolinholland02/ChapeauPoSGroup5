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
        public Table GetTable(string id)
        {
            string query = "SELECT [tableId], [tableStatus] FROM [dbo].[RestaurantTables] WHERE [tableId] = @id";
            SqlParameter[] parameters = { new SqlParameter("@id", id) };
            return ReadTable(ExecuteSelectQuery(query, parameters));
        }
        public Table ReadTable(DataTable dataTable)
        {
            Table table = new Table();
            foreach (DataRow dr in dataTable.Rows)
            {
                table.TableId = (int)dr["tableId"];
                table.TableStatus = dr["tableStatus"].ToString();
            }
            return table;
        }
    }
}
