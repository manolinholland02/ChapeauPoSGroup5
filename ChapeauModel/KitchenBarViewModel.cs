using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class KitchenBarViewModel
    {
        public int OrderItemId { get; set; }
        public string Name { get; set; }
        public int TableOfOrder { get; set; }
        public string Comment { get; set; }
        public TimeSpan AveragePreparationTime { get; set; }
        public DateTime StartTime { get; set; }
        public TimeSpan TimeElapsed { get; set; }
    }
}
