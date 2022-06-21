
namespace ChapeauUI
{
    partial class RestaurantOverview
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTable1 = new System.Windows.Forms.Button();
            this.btnTable2 = new System.Windows.Forms.Button();
            this.btnTable3 = new System.Windows.Forms.Button();
            this.btnTable8 = new System.Windows.Forms.Button();
            this.btnTable7 = new System.Windows.Forms.Button();
            this.btnTable6 = new System.Windows.Forms.Button();
            this.btnTable5 = new System.Windows.Forms.Button();
            this.btnTable10 = new System.Windows.Forms.Button();
            this.btnTable9 = new System.Windows.Forms.Button();
            this.btnTable4 = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlDisplayOrderItems = new System.Windows.Forms.Panel();
            this.orderItemsListView = new System.Windows.Forms.ListView();
            this.orderItemId = new System.Windows.Forms.ColumnHeader();
            this.orderItemName = new System.Windows.Forms.ColumnHeader();
            this.orderItemStatus = new System.Windows.Forms.ColumnHeader();
            this.btnAddOrderItems = new System.Windows.Forms.Button();
            this.btnSetItemAsServed = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblTable = new System.Windows.Forms.Label();
            this.pnlDisplayOrderItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(149, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restaurant Overview";
            // 
            // btnTable1
            // 
            this.btnTable1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTable1.Location = new System.Drawing.Point(31, 154);
            this.btnTable1.Name = "btnTable1";
            this.btnTable1.Size = new System.Drawing.Size(61, 61);
            this.btnTable1.TabIndex = 1;
            this.btnTable1.Text = "Table 1";
            this.btnTable1.UseVisualStyleBackColor = false;
            this.btnTable1.Click += new System.EventHandler(this.btnTable1_Click);
            // 
            // btnTable2
            // 
            this.btnTable2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTable2.Location = new System.Drawing.Point(437, 154);
            this.btnTable2.Name = "btnTable2";
            this.btnTable2.Size = new System.Drawing.Size(61, 61);
            this.btnTable2.TabIndex = 2;
            this.btnTable2.Text = "Table 2";
            this.btnTable2.UseVisualStyleBackColor = false;
            this.btnTable2.Click += new System.EventHandler(this.btnTable2_Click);
            // 
            // btnTable3
            // 
            this.btnTable3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTable3.Location = new System.Drawing.Point(31, 238);
            this.btnTable3.Name = "btnTable3";
            this.btnTable3.Size = new System.Drawing.Size(61, 61);
            this.btnTable3.TabIndex = 3;
            this.btnTable3.Text = "Table 3";
            this.btnTable3.UseVisualStyleBackColor = false;
            this.btnTable3.Click += new System.EventHandler(this.btnTable3_Click);
            // 
            // btnTable8
            // 
            this.btnTable8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTable8.Location = new System.Drawing.Point(437, 398);
            this.btnTable8.Name = "btnTable8";
            this.btnTable8.Size = new System.Drawing.Size(61, 61);
            this.btnTable8.TabIndex = 8;
            this.btnTable8.Text = "Table 8";
            this.btnTable8.UseVisualStyleBackColor = false;
            this.btnTable8.Click += new System.EventHandler(this.btnTable8_Click);
            // 
            // btnTable7
            // 
            this.btnTable7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTable7.Location = new System.Drawing.Point(31, 398);
            this.btnTable7.Name = "btnTable7";
            this.btnTable7.Size = new System.Drawing.Size(61, 61);
            this.btnTable7.TabIndex = 7;
            this.btnTable7.Text = "Table 7";
            this.btnTable7.UseVisualStyleBackColor = false;
            this.btnTable7.Click += new System.EventHandler(this.btnTable7_Click);
            // 
            // btnTable6
            // 
            this.btnTable6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTable6.Location = new System.Drawing.Point(437, 317);
            this.btnTable6.Name = "btnTable6";
            this.btnTable6.Size = new System.Drawing.Size(61, 61);
            this.btnTable6.TabIndex = 6;
            this.btnTable6.Text = "Table 6";
            this.btnTable6.UseVisualStyleBackColor = false;
            this.btnTable6.Click += new System.EventHandler(this.btnTable6_Click);
            // 
            // btnTable5
            // 
            this.btnTable5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTable5.Location = new System.Drawing.Point(31, 317);
            this.btnTable5.Name = "btnTable5";
            this.btnTable5.Size = new System.Drawing.Size(61, 61);
            this.btnTable5.TabIndex = 5;
            this.btnTable5.Text = "Table 5";
            this.btnTable5.UseVisualStyleBackColor = false;
            this.btnTable5.Click += new System.EventHandler(this.btnTable5_Click);
            // 
            // btnTable10
            // 
            this.btnTable10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTable10.Location = new System.Drawing.Point(437, 478);
            this.btnTable10.Name = "btnTable10";
            this.btnTable10.Size = new System.Drawing.Size(61, 61);
            this.btnTable10.TabIndex = 10;
            this.btnTable10.Text = "Table 10";
            this.btnTable10.UseVisualStyleBackColor = false;
            this.btnTable10.Click += new System.EventHandler(this.btnTable10_Click);
            // 
            // btnTable9
            // 
            this.btnTable9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTable9.Location = new System.Drawing.Point(31, 478);
            this.btnTable9.Name = "btnTable9";
            this.btnTable9.Size = new System.Drawing.Size(61, 61);
            this.btnTable9.TabIndex = 9;
            this.btnTable9.Text = "Table 9";
            this.btnTable9.UseVisualStyleBackColor = false;
            this.btnTable9.Click += new System.EventHandler(this.btnTable9_Click);
            // 
            // btnTable4
            // 
            this.btnTable4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTable4.Location = new System.Drawing.Point(437, 238);
            this.btnTable4.Name = "btnTable4";
            this.btnTable4.Size = new System.Drawing.Size(61, 61);
            this.btnTable4.TabIndex = 13;
            this.btnTable4.Text = "Table 4";
            this.btnTable4.UseVisualStyleBackColor = false;
            this.btnTable4.Click += new System.EventHandler(this.btnTable4_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(322, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 25);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // pnlDisplayOrderItems
            // 
            this.pnlDisplayOrderItems.Controls.Add(this.orderItemsListView);
            this.pnlDisplayOrderItems.Controls.Add(this.btnAddOrderItems);
            this.pnlDisplayOrderItems.Controls.Add(this.btnSetItemAsServed);
            this.pnlDisplayOrderItems.Controls.Add(this.btnDeleteOrder);
            this.pnlDisplayOrderItems.Controls.Add(this.btnPay);
            this.pnlDisplayOrderItems.Controls.Add(this.lblTable);
            this.pnlDisplayOrderItems.Location = new System.Drawing.Point(98, 154);
            this.pnlDisplayOrderItems.Name = "pnlDisplayOrderItems";
            this.pnlDisplayOrderItems.Size = new System.Drawing.Size(333, 444);
            this.pnlDisplayOrderItems.TabIndex = 15;
            // 
            // orderItemsListView
            // 
            this.orderItemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderItemId,
            this.orderItemName,
            this.orderItemStatus});
            this.orderItemsListView.HideSelection = false;
            this.orderItemsListView.Location = new System.Drawing.Point(10, 35);
            this.orderItemsListView.Name = "orderItemsListView";
            this.orderItemsListView.Size = new System.Drawing.Size(311, 330);
            this.orderItemsListView.TabIndex = 0;
            this.orderItemsListView.UseCompatibleStateImageBehavior = false;
            this.orderItemsListView.View = System.Windows.Forms.View.Details;
            // 
            // orderItemId
            // 
            this.orderItemId.Text = "ID";
            this.orderItemId.Width = 0;
            // 
            // orderItemName
            // 
            this.orderItemName.Text = "Item";
            this.orderItemName.Width = 200;
            // 
            // orderItemStatus
            // 
            this.orderItemStatus.Text = "Status";
            this.orderItemStatus.Width = 105;
            // 
            // btnAddOrderItems
            // 
            this.btnAddOrderItems.Location = new System.Drawing.Point(118, 371);
            this.btnAddOrderItems.Name = "btnAddOrderItems";
            this.btnAddOrderItems.Size = new System.Drawing.Size(95, 70);
            this.btnAddOrderItems.TabIndex = 5;
            this.btnAddOrderItems.Text = "Add new items to the order";
            this.btnAddOrderItems.UseVisualStyleBackColor = true;
            this.btnAddOrderItems.Click += new System.EventHandler(this.btnAddOrderItems_Click);
            // 
            // btnSetItemAsServed
            // 
            this.btnSetItemAsServed.Location = new System.Drawing.Point(10, 371);
            this.btnSetItemAsServed.Name = "btnSetItemAsServed";
            this.btnSetItemAsServed.Size = new System.Drawing.Size(95, 70);
            this.btnSetItemAsServed.TabIndex = 4;
            this.btnSetItemAsServed.Text = "Set item as served";
            this.btnSetItemAsServed.UseVisualStyleBackColor = true;
            this.btnSetItemAsServed.Click += new System.EventHandler(this.btnSetItemAsServed_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Location = new System.Drawing.Point(10, 371);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(95, 70);
            this.btnDeleteOrder.TabIndex = 1;
            this.btnDeleteOrder.Text = "Set table free";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(226, 371);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(95, 70);
            this.btnPay.TabIndex = 3;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTable.Location = new System.Drawing.Point(71, 0);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(0, 31);
            this.lblTable.TabIndex = 2;
            // 
            // RestaurantOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(220)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(532, 753);
            this.Controls.Add(this.pnlDisplayOrderItems);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnTable4);
            this.Controls.Add(this.btnTable10);
            this.Controls.Add(this.btnTable9);
            this.Controls.Add(this.btnTable8);
            this.Controls.Add(this.btnTable7);
            this.Controls.Add(this.btnTable6);
            this.Controls.Add(this.btnTable5);
            this.Controls.Add(this.btnTable3);
            this.Controls.Add(this.btnTable2);
            this.Controls.Add(this.btnTable1);
            this.Controls.Add(this.label1);
            this.Name = "RestaurantOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RestaurantOverview";
            this.pnlDisplayOrderItems.ResumeLayout(false);
            this.pnlDisplayOrderItems.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTable1;
        private System.Windows.Forms.Button btnTable2;
        //private System.Windows.Forms.Button btnTable4;
        private System.Windows.Forms.Button btnTable3;
        private System.Windows.Forms.Button btnTable8;
        private System.Windows.Forms.Button btnTable7;
        private System.Windows.Forms.Button btnTable6;
        private System.Windows.Forms.Button btnTable5;
        private System.Windows.Forms.Button btnTable10;
        private System.Windows.Forms.Button btnTable9;
        private System.Windows.Forms.Button btnTable4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlDisplayOrderItems;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.ListView orderItemsListView;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.ColumnHeader orderItemId;
        private System.Windows.Forms.ColumnHeader orderItemName;
        private System.Windows.Forms.ColumnHeader orderItemStatus;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnSetItemAsServed;
        private System.Windows.Forms.Button btnAddOrderItems;
    }
}