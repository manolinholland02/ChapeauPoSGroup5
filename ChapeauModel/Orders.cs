using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Orders
    {
        public int OrderID { get; set; }
        public int OrderTable { get; set; }
        public MenuItem MenuItem { get; set; }
        public int ItemQuantity { get; set; }
        public string OrderComment { get; set; }
        public decimal OrderPrice { get { return ItemQuantity * MenuItem.MenuItemPrice; } }
        public Status OrderStatus { get; set; }
        public int OrderWaiter { get; set; }
        public int OrderPreparer { get; set; }
        public int OrderPayment { get; set; }
        //this calculated property is purely for design purposes when an order is passed to the Kitchen/Bar view
        public string OrderDesign { get { return ItemQuantity.ToString() + " x " + MenuItem.MenuItemName; } }
    }

}
