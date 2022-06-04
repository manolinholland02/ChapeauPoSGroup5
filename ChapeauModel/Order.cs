using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Order
    {
        public int OrderId { get; set; }
        public int WaiterId { get; set; }
        public int TableId { get; set; }
        public int PaymentId { get; set; }
        public bool isPaid { get; set; }
    }
}
