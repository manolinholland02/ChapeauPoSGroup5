using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauModel
{
    public class Feedback
    {
        
        public int FeedbackId { get; set; }
        public int TableId { get; set; }
        public TypeOfFeedback TypeOfFeedback { get; set; }
        public string Note { get; set; }
        public DateTime DateOfFeedback { get; set; }
    }
}
