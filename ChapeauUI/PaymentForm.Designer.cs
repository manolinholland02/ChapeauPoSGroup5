
namespace ChapeauUI
{
    partial class PaymentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewOrderDetails = new System.Windows.Forms.ListView();
            this.itemName = new System.Windows.Forms.ColumnHeader();
            this.orderQuantity = new System.Windows.Forms.ColumnHeader();
            this.orderPrice = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.amountToBePayed_btn = new System.Windows.Forms.Button();
            this.amountToBePayed_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.regularVAT_lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.alcVAT_lbl = new System.Windows.Forms.Label();
            this.subTotal_lbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tip_lbl = new System.Windows.Forms.Label();
            this.total_lbl = new System.Windows.Forms.Label();
            this.cashPayment_btn = new System.Windows.Forms.Button();
            this.pinPayment_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewOrderDetails
            // 
            this.listViewOrderDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemName,
            this.orderQuantity,
            this.orderPrice});
            this.listViewOrderDetails.HideSelection = false;
            this.listViewOrderDetails.Location = new System.Drawing.Point(21, 73);
            this.listViewOrderDetails.Name = "listViewOrderDetails";
            this.listViewOrderDetails.Size = new System.Drawing.Size(488, 228);
            this.listViewOrderDetails.TabIndex = 0;
            this.listViewOrderDetails.UseCompatibleStateImageBehavior = false;
            this.listViewOrderDetails.View = System.Windows.Forms.View.Details;
            // 
            // itemName
            // 
            this.itemName.Text = "Item Name";
            this.itemName.Width = 100;
            // 
            // orderQuantity
            // 
            this.orderQuantity.Text = "Quantity";
            this.orderQuantity.Width = 100;
            // 
            // orderPrice
            // 
            this.orderPrice.Text = "Price";
            this.orderPrice.Width = 180;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Details";
            // 
            // amountToBePayed_btn
            // 
            this.amountToBePayed_btn.Location = new System.Drawing.Point(394, 541);
            this.amountToBePayed_btn.Name = "amountToBePayed_btn";
            this.amountToBePayed_btn.Size = new System.Drawing.Size(94, 29);
            this.amountToBePayed_btn.TabIndex = 2;
            this.amountToBePayed_btn.Text = "Enter";
            this.amountToBePayed_btn.UseVisualStyleBackColor = true;
            this.amountToBePayed_btn.Click += new System.EventHandler(this.amountToBePayed_btn_Click);
            // 
            // amountToBePayed_txt
            // 
            this.amountToBePayed_txt.Location = new System.Drawing.Point(39, 543);
            this.amountToBePayed_txt.Name = "amountToBePayed_txt";
            this.amountToBePayed_txt.Size = new System.Drawing.Size(270, 27);
            this.amountToBePayed_txt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Amount To Be Payed";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.regularVAT_lbl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.alcVAT_lbl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.subTotal_lbl, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(39, 330);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(449, 164);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // regularVAT_lbl
            // 
            this.regularVAT_lbl.AutoSize = true;
            this.regularVAT_lbl.Location = new System.Drawing.Point(227, 54);
            this.regularVAT_lbl.Name = "regularVAT_lbl";
            this.regularVAT_lbl.Size = new System.Drawing.Size(52, 20);
            this.regularVAT_lbl.TabIndex = 4;
            this.regularVAT_lbl.Text = "€00.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "VAT(6%)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "VAT(Alc. 21%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sub-Total";
            // 
            // alcVAT_lbl
            // 
            this.alcVAT_lbl.AutoSize = true;
            this.alcVAT_lbl.Location = new System.Drawing.Point(227, 0);
            this.alcVAT_lbl.Name = "alcVAT_lbl";
            this.alcVAT_lbl.Size = new System.Drawing.Size(52, 20);
            this.alcVAT_lbl.TabIndex = 5;
            this.alcVAT_lbl.Text = "€00.00";
            // 
            // subTotal_lbl
            // 
            this.subTotal_lbl.AutoSize = true;
            this.subTotal_lbl.Location = new System.Drawing.Point(227, 108);
            this.subTotal_lbl.Name = "subTotal_lbl";
            this.subTotal_lbl.Size = new System.Drawing.Size(52, 20);
            this.subTotal_lbl.TabIndex = 3;
            this.subTotal_lbl.Text = "€00.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tip";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tip_lbl, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.total_lbl, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(39, 593);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(449, 90);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total";
            // 
            // tip_lbl
            // 
            this.tip_lbl.AutoSize = true;
            this.tip_lbl.Location = new System.Drawing.Point(227, 0);
            this.tip_lbl.Name = "tip_lbl";
            this.tip_lbl.Size = new System.Drawing.Size(52, 20);
            this.tip_lbl.TabIndex = 11;
            this.tip_lbl.Text = "€00.00";
            // 
            // total_lbl
            // 
            this.total_lbl.AutoSize = true;
            this.total_lbl.Location = new System.Drawing.Point(227, 45);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(52, 20);
            this.total_lbl.TabIndex = 12;
            this.total_lbl.Text = "€00.00";
            // 
            // cashPayment_btn
            // 
            this.cashPayment_btn.Location = new System.Drawing.Point(104, 711);
            this.cashPayment_btn.Name = "cashPayment_btn";
            this.cashPayment_btn.Size = new System.Drawing.Size(94, 29);
            this.cashPayment_btn.TabIndex = 11;
            this.cashPayment_btn.Text = "Cash";
            this.cashPayment_btn.UseVisualStyleBackColor = true;
            // 
            // pinPayment_btn
            // 
            this.pinPayment_btn.Location = new System.Drawing.Point(331, 711);
            this.pinPayment_btn.Name = "pinPayment_btn";
            this.pinPayment_btn.Size = new System.Drawing.Size(94, 29);
            this.pinPayment_btn.TabIndex = 12;
            this.pinPayment_btn.Text = "PIN";
            this.pinPayment_btn.UseVisualStyleBackColor = true;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 752);
            this.Controls.Add(this.pinPayment_btn);
            this.Controls.Add(this.cashPayment_btn);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amountToBePayed_txt);
            this.Controls.Add(this.amountToBePayed_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewOrderDetails);
            this.Name = "PaymentForm";
            this.Text = "Payment";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewOrderDetails;
        private System.Windows.Forms.ColumnHeader itemName;
        private System.Windows.Forms.ColumnHeader orderQuantity;
        private System.Windows.Forms.ColumnHeader orderPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button amountToBePayed_btn;
        private System.Windows.Forms.TextBox amountToBePayed_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cashPayment_btn;
        private System.Windows.Forms.Button pinPayment_btn;
        private System.Windows.Forms.Label subTotal_lbl;
        private System.Windows.Forms.Label regularVAT_lbl;
        private System.Windows.Forms.Label alcVAT_lbl;
        private System.Windows.Forms.Label tip_lbl;
        private System.Windows.Forms.Label total_lbl;
    }
}