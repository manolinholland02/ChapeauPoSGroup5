using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    class PaymentService
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
        
    }
}
