using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    public class PaymentService
    {
        private PaymentDao _paymentdb;

        public PaymentService()
        {
            _paymentdb = new PaymentDao();
        }
        public List<Payment> GetPaymentFromTableId()
        {
            return _paymentdb.GetPaymentFromTableId();
        }
        public void AddAmountPayed(Payment payment)
        {
            //insert amount to be payed

            _paymentdb.AddAmountPayed(payment);
        }

        public void CalcSubTotal(Payment payment)
        {
            //sum of all items in order * quantity

            _paymentdb.CalcSubTotal(payment);
        }

        public void CalcVAT(Payment payment)
        {
            //Calc  VAT if alcholic == *21% else *6%
            _paymentdb.CalcVAT(payment);
            
        }

        public void CalcTip(Payment payment)
        {
            // calc amountPayed - (Subtotal + CalcVAT(6* && 21%))

            _paymentdb.CalcTip(payment);
        }
    }
}
