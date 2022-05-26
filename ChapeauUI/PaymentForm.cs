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
        PaymentService paymentService = new PaymentService();
        
        
        public PaymentForm()
        {
            InitializeComponent();
            DisplayOrderDetails();

        }

        private void DisplayOrderDetails()
        {
            //change from paymentservice to ordersservice

            
            List<Payment> ordersList = paymentService.GetPaymentFromTableId();

            listViewOrderDetails.Items.Clear();

            foreach (Payment O in ordersList)
            {
                ListViewItem li = new ListViewItem(O.ToString());
                li.SubItems.Add($"{O.PaymentId}");
                li.SubItems.Add($"{O.PaymentPrice}");
                li.SubItems.Add($"{O.TableId}");
                listViewOrderDetails.Items.Add(li);
            }
        }

        private void amountToBePayed_btn_Click(object sender, EventArgs e)
        {
            decimal payedAmount;

            alcVAT_lbl.Text = $"";
            regularVAT_lbl.Text = $"";
            subTotal_lbl.Text = $"";

            
            payedAmount = decimal.Parse(amountToBePayed_txt.Text);

            Payment payment = new Payment()
            {
                PaymentPrice = payedAmount
            };

            tip_lbl.Text = $"";
            total_lbl.Text = $"";

            paymentService.AddAmountPayed(payment);
            
        }
    }
}
