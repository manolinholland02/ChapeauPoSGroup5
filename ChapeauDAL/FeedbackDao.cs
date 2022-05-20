using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ChapeauModel;

namespace ChapeauDAL
{
    class FeedbackDao : BaseDao
    {
        public List<Feedback> AddFeedback()
        {
            string query = "SELECT [tableId], [feedbackId], [dateOfFeedback], [typeOfFeedback], [note] FROM [Feedbacks]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Feedback> ReadTables(DataTable dataTable)
        {
            List<Feedback> feedback = new List<Feedback>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Feedback feedbacks = new Feedback()
                {
                    TableId = (int)dr["tableId"],
                    FeedbackId = (int)dr["feedbackId"],
                    DateOfFeedback = (DateTime)dr["dateOfFeedback"],
                    Note = dr["note"].ToString(),
                    TypeOfFeedback = (TypeOfFeedback)dr["typeOfFeedback"]
                };
                feedback.Add(feedbacks);
            }
            return feedback;
        }
    }
}
