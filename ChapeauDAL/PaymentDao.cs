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
            //take from orderdao
            string query = $"SELECT [tip], [paymentPrice], [dateOfPayment] FROM Payments WHERE (paymentId = @paymentId AND tableId = @tableId)";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void CalcSubTotal(Payment payment)
        {
            //sum of all items in order * quantity

            string query = $"SELECT SUM ((itemQuantity) * (orderPrice)) FROM Orders WHERE (orderItem = @orderItem AND orderPayment = @orderPayment)";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void CalcVAT(Payment payment)
        {
            //Calc  VAT if alcholic == *21% else *6%
            //change
            string query = $"Select ((orderPrice * itemQuantity)* 0.21) FROM orders INNER JOIN MenuItems ON Orders.orderItem = MenuItems.menuItemId";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void AddAmountPayed(Payment payment)
        {
            //insert amount to be payed

            string query = $"INSERT INTO dbo.Payments (paymentPrice, tip) VALUES ([PaymentPrice], [payment.Tip]) WHERE (paymentId = @paymentId AND tableId = @tableId)";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void CalcTip(Payment payment)
        {
            // calc amountPayed - (Subtotal + VAT(6* && 21%))

            string query = $"";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }


        public List<Payment> ReadTables(DataTable dataTable)
        {
            List<Payment> payment = new List<Payment>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Payment payments = new Payment()
                {

                    PaymentId = (int)dr["paymentId"],
                    TableId = (int)dr["tableTd"],
                    DateOfPayment = (DateTime)dr["dateOfPayment"],
                    PaymentPrice = (decimal)dr["paymentPrice"],
                    Tip = (decimal)dr["tip"],


                };
                payment.Add(payments);
            }
            return payment;
        }
    }
}
