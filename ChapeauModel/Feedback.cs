using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauModel
{
    public class Feedback
    {
        
        public int FeedbackId { get; set; }
        public int PaymentId { get; set; }
        public string Note { get; set; }
        public DateTime DateOfFeedback { get; set; }
    }
}
