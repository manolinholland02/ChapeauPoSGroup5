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
        public int orderItem { get; set; }
        public string orderItemName { get; set; }
        public int ItemQuantity { get; set; }
        public string orderComment { get; set; }
        public decimal orderPrice { get; set; }
        public Status orderStatus { get; set; }
        public int orderWaiter { get; set; }
        public int orderPreparer { get; set; }
        public int orderPayment { get; set; }
        public string FoodOrDrink { get; set; }
    }

}
