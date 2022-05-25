using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauLogic;

namespace ChapeauUI
{
    public partial class PaymentForm : Form
    {
        
        public PaymentForm()
        {
            InitializeComponent();
            DisplayOrderDetails();

        }

        private void DisplayOrderDetails()
        {
            PaymentService paymentService = new PaymentService();
            List<Payment> paymentList = paymentService.GetPaymentFromTableId();

            listViewOrderDetails.Items.Clear();

            foreach (Payment p in paymentList)
            {
                ListViewItem li = new ListViewItem(p.ToString());
                //li.SubItems.Add();
                //li.SubItems.Add();
                //li.SubItems.Add();
                listViewOrderDetails.Items.Add(li);
            }
        }

        private void amountToBePayed_btn_Click(object sender, EventArgs e)
        {
            decimal payedAmount;
            

            PaymentService paymentService = new PaymentService();
            payedAmount = decimal.Parse(amountToBePayed_txt.Text);

            Payment payment = new Payment()
            {
                PaymentPrice = payedAmount
            };

            paymentService.AddAmountPayedAndTip(payment);
            
        }
    }
}
