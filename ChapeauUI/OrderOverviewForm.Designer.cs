
namespace ChapeauUI
{
    partial class OrderOverviewForm
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
            this.OrderlistView = new System.Windows.Forms.ListView();
            this.orderItemId = new System.Windows.Forms.ColumnHeader();
            this.OrderItemName = new System.Windows.Forms.ColumnHeader();
            this.OrderItemQuantity = new System.Windows.Forms.ColumnHeader();
            this.OrderComment = new System.Windows.Forms.ColumnHeader();
            this.menuItemStock = new System.Windows.Forms.ColumnHeader();
            this.PlusOrderbtn = new System.Windows.Forms.Button();
            this.MinusOrderbtn = new System.Windows.Forms.Button();
            this.DeleteOrderbtn = new System.Windows.Forms.Button();
            this.PlaceOrderbtn = new System.Windows.Forms.Button();
            this.oderOverviewbackbtn = new System.Windows.Forms.Button();
            this.OrderOverviewPaybtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrderlistView
            // 
            this.OrderlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderItemId,
            this.OrderItemName,
            this.OrderItemQuantity,
            this.OrderComment,
            this.menuItemStock});
            this.OrderlistView.HideSelection = false;
            this.OrderlistView.Location = new System.Drawing.Point(0, 119);
            this.OrderlistView.MultiSelect = false;
            this.OrderlistView.Name = "OrderlistView";
            this.OrderlistView.Size = new System.Drawing.Size(398, 369);
            this.OrderlistView.TabIndex = 0;
            this.OrderlistView.UseCompatibleStateImageBehavior = false;
            this.OrderlistView.View = System.Windows.Forms.View.Details;
            // 
            // orderItemId
            // 
            this.orderItemId.Text = "ID";
            this.orderItemId.Width = 0;
            // 
            // OrderItemName
            // 
            this.OrderItemName.Text = "Item Name";
            this.OrderItemName.Width = 150;
            // 
            // OrderItemQuantity
            // 
            this.OrderItemQuantity.Text = "Quantity";
            this.OrderItemQuantity.Width = 75;
            // 
            // OrderComment
            // 
            this.OrderComment.Text = "Comment";
            this.OrderComment.Width = 250;
            // 
            // menuItemStock
            // 
            this.menuItemStock.Text = "Availability";
            // 
            // PlusOrderbtn
            // 
            this.PlusOrderbtn.Location = new System.Drawing.Point(400, 119);
            this.PlusOrderbtn.Name = "PlusOrderbtn";
            this.PlusOrderbtn.Size = new System.Drawing.Size(128, 114);
            this.PlusOrderbtn.TabIndex = 1;
            this.PlusOrderbtn.Text = "+";
            this.PlusOrderbtn.UseVisualStyleBackColor = true;
            this.PlusOrderbtn.Click += new System.EventHandler(this.PlusOrderbtn_Click);
            // 
            // MinusOrderbtn
            // 
            this.MinusOrderbtn.Location = new System.Drawing.Point(400, 247);
            this.MinusOrderbtn.Name = "MinusOrderbtn";
            this.MinusOrderbtn.Size = new System.Drawing.Size(128, 114);
            this.MinusOrderbtn.TabIndex = 2;
            this.MinusOrderbtn.Text = "-";
            this.MinusOrderbtn.UseVisualStyleBackColor = true;
            this.MinusOrderbtn.Click += new System.EventHandler(this.MinusOrderbtn_Click);
            // 
            // DeleteOrderbtn
            // 
            this.DeleteOrderbtn.Location = new System.Drawing.Point(400, 374);
            this.DeleteOrderbtn.Name = "DeleteOrderbtn";
            this.DeleteOrderbtn.Size = new System.Drawing.Size(128, 114);
            this.DeleteOrderbtn.TabIndex = 3;
            this.DeleteOrderbtn.Text = "Delete Whole Order";
            this.DeleteOrderbtn.UseVisualStyleBackColor = true;
            this.DeleteOrderbtn.Click += new System.EventHandler(this.DeleteOrderbtn_Click);
            // 
            // PlaceOrderbtn
            // 
            this.PlaceOrderbtn.Location = new System.Drawing.Point(169, 551);
            this.PlaceOrderbtn.Name = "PlaceOrderbtn";
            this.PlaceOrderbtn.Size = new System.Drawing.Size(200, 77);
            this.PlaceOrderbtn.TabIndex = 4;
            this.PlaceOrderbtn.Text = "Place Order";
            this.PlaceOrderbtn.UseVisualStyleBackColor = true;
            this.PlaceOrderbtn.Click += new System.EventHandler(this.PlaceOrderbtn_Click);
            // 
            // oderOverviewbackbtn
            // 
            this.oderOverviewbackbtn.Location = new System.Drawing.Point(12, 663);
            this.oderOverviewbackbtn.Name = "oderOverviewbackbtn";
            this.oderOverviewbackbtn.Size = new System.Drawing.Size(200, 77);
            this.oderOverviewbackbtn.TabIndex = 5;
            this.oderOverviewbackbtn.Text = "Back";
            this.oderOverviewbackbtn.UseVisualStyleBackColor = true;
            this.oderOverviewbackbtn.Click += new System.EventHandler(this.oderOverviewbackbtn_Click);
            // 
            // OrderOverviewPaybtn
            // 
            this.OrderOverviewPaybtn.Location = new System.Drawing.Point(325, 663);
            this.OrderOverviewPaybtn.Name = "OrderOverviewPaybtn";
            this.OrderOverviewPaybtn.Size = new System.Drawing.Size(200, 77);
            this.OrderOverviewPaybtn.TabIndex = 6;
            this.OrderOverviewPaybtn.Text = "Pay";
            this.OrderOverviewPaybtn.UseVisualStyleBackColor = true;
            // 
            // OrderOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 752);
            this.Controls.Add(this.OrderOverviewPaybtn);
            this.Controls.Add(this.oderOverviewbackbtn);
            this.Controls.Add(this.PlaceOrderbtn);
            this.Controls.Add(this.DeleteOrderbtn);
            this.Controls.Add(this.MinusOrderbtn);
            this.Controls.Add(this.PlusOrderbtn);
            this.Controls.Add(this.OrderlistView);
            this.Name = "OrderOverviewForm";
            this.Text = "OrderOverviewForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView OrderlistView;
        private System.Windows.Forms.Button PlusOrderbtn;
        private System.Windows.Forms.Button MinusOrderbtn;
        private System.Windows.Forms.Button DeleteOrderbtn;
        private System.Windows.Forms.Button PlaceOrderbtn;
        private System.Windows.Forms.Button oderOverviewbackbtn;
        private System.Windows.Forms.Button OrderOverviewPaybtn;
        private System.Windows.Forms.ColumnHeader OrderItemName;
        private System.Windows.Forms.ColumnHeader OrderItemQuantity;
        private System.Windows.Forms.ColumnHeader OrderComment;
        private System.Windows.Forms.ColumnHeader orderItemId;
        private System.Windows.Forms.ColumnHeader menuItemStock;
    }
}