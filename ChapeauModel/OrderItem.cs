using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ChapeauModel
{
    public class OrderItem
    {
        public int OrderItemID { get; set; } 
        public MenuItem MenuItem { get; set; }
        public string Comment { get; set; }
        public int Quantity { get; set; }
        public int Order { get; set; }
        public Status Status { get; set; }
        public DateTime StartTime { get; set; }

        //calculates menu item stock - quantity
        public int Availability { get { return MenuItem.MenuItemStock - Quantity; } }

        public string OrderDesign { get { return Quantity.ToString() + "x" + MenuItem.MenuItemName; } }


    }
}
