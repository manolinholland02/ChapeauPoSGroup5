using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauModel;
using System.Data.SqlClient;
using System.Data;

namespace ChapeauDAL
{
    public class PaymentDao : BaseDao
    {
        public List<Payment> GetPaymentFromTableId()
        {
            string query = $"SELECT [tip], [paymentPrice], [dateOfPayment] FROM Payments WHERE (paymentId = @paymentId AND tableId = @tableId)";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void CalcSubTotal(Payment payment)
        {
            //sum of all items in order * quantity
        }

        public void AddAmountPayedAndTip(Payment payment)
        {
                string query = $"INSERT INTO dbo.Payments (paymentPrice, tip) VALUES ({payment.PaymentPrice},{payment.Tip}) WHERE (paymentId = @paymentId AND tableId = @tableId)";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                ExecuteEditQuery(query, sqlParameters); 
        }


        public List<Payment> ReadTables(DataTable dataTable)
        {
            List<Payment> feedback = new List<Payment>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Payment feedbacks = new Payment()
                {

                    PaymentId = (int)dr["paymentId"],
                    TableId = (int)dr["tableTd"],
                    DateOfPayment = (DateTime)dr["dateOfPayment"],
                    PaymentPrice = (decimal)dr["paymentPrice"],
                    Tip = (decimal)dr["tip"],


                };
                feedback.Add(feedbacks);
            }
            return feedback;
        }
    }
}
