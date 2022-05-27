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
        OrdersService ordersService = new OrdersService();
        
        public PaymentForm()
        {
            InitializeComponent();
            //DisplayOrderDetails();

        }

        //private void DisplayOrderDetails()
        //{
        //    //change from paymentservice to ordersservice

            
        //    List<Orders> ordersList = ordersService.GetOrdersFromTableID();

        //    listViewOrderDetails.Items.Clear();

        //    foreach (Orders O in ordersList)
        //    {
        //        ListViewItem li = new ListViewItem(O.ToString());
        //        li.SubItems.Add(O.orderItemName);
        //        li.SubItems.Add($"{O.ItemQuantity}");
        //        li.SubItems.Add($"{O.orderPrice}");
        //        listViewOrderDetails.Items.Add(li);
        //    }
        //}

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
