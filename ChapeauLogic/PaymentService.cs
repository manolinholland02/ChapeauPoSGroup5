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
        public void AddAmountPayedAndTip(Payment payment)
        {
            _paymentdb.AddAmountPayedAndTip(payment);
        }
    }
}
