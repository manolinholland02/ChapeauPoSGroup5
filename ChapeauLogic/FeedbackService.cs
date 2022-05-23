using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapeauDAL;
using ChapeauModel;

namespace ChapeauLogic
{
    class FeedbackService
    {
        private FeedbackDao _feedbackdb;

        public FeedbackService()
        {
            _feedbackdb = new FeedbackDao();
        }
        public List<Feedback> GetAllFeedback()
        {
            return _feedbackdb.GetAllFeedback();
        }
        public void AddFeedback(Feedback feedback)
        {
            _feedbackdb.AddFeedback(feedback);
        }

        


    }
}
