using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauLogic;
using ChapeauModel;

namespace ChapeauUI
{
    public partial class FeedbackForm : Form
    {
        public FeedbackForm()
        {
            InitializeComponent();
        }

        private void enterFeedback_btn_Click(object sender, EventArgs e)
        {
            string note;
            FeedbackService feedbackService = new FeedbackService();
            note = feedback_txt.Text;

            Feedback feedback = new Feedback()
            {
                Note = note
            };

            feedbackService.AddFeedback(feedback);
        }
    }
}
