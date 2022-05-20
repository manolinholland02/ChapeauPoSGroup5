using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Orders
    {
        public int orderID { get; set; }
        public int orderTable { get; set; }
        public MenuItem orderItem { get; set; }
        public string orderItemName { get; set; }
        public int ItemQuantity { get; set; }
        public string orderComment { get; set; }
        public decimal orderPrice { get; set; }
        public Status orderStatus { get; set; }
        public Employee orderWaiter { get; set; }
        public Employee orderPreparer { get; set; }
        public Payment orderPayment { get; set; }
    }

}
