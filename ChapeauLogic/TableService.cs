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
        public Table GetTable(string id)
        {
           return _tabledb.GetTable(id);
        }
    }
}
