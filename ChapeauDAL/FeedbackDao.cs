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
        
        public List<Feedback> GetAllFeedback()
        {
            string query = "SELECT [tableId], [feedbackId], [dateOfFeedback], [typeOfFeedback], [note] FROM [Feedbacks]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        

        public void AddFeedback(Feedback feedback)
        {
            try
            {
                SqlParameter[] parameters =
                {
                    new SqlParameter("@tableId", feedback.TableId),
                    new SqlParameter("@feedbackId", feedback.FeedbackId),
                    new SqlParameter("@dateOfFeedback", feedback.DateOfFeedback),
                    new SqlParameter("@typeOfFeedback", feedback.TypeOfFeedback),
                    new SqlParameter("@note", feedback.Note)
                };
                string query = $"INSERT INTO [dbo.Feedbacks] VALUES (@note, @typeOfFeedback) WHERE (tableId = @tableId AND feedbackId = @feedbackId)";
                ExecuteEditQuery(query, parameters);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
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
