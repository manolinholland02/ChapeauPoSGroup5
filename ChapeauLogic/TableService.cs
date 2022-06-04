using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class TableService
    {
        private TableDao _tabledb;

        public TableService()
        {
            _tabledb = new TableDao();
        }

        public Table GetTable(int id)
        {
            return _tabledb.GetTable(id);
        }

        public void UpdateTableStatus(Table table)
        {
            _tabledb.UpdateTableStatus(table);
        }
    }
}
