using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauModel
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public DateTime DateOfPayment { get; set; }
        public decimal PaymentPrice { get; set; }
        public decimal Tip { get; set; }
        public int TableId { get; set; }
    }
}
