
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
            this.TableOverviewbtn = new System.Windows.Forms.Button();
            this.EmployeeNamelbl = new System.Windows.Forms.Label();
            this.tableNumberlbl = new System.Windows.Forms.Label();
            this.OrderAddedlbl = new System.Windows.Forms.Label();
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
            this.OrderlistView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.OrderItemQuantity.Text = "Q";
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
            this.PlusOrderbtn.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.MinusOrderbtn.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.DeleteOrderbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteOrderbtn.Location = new System.Drawing.Point(0, 494);
            this.DeleteOrderbtn.Name = "DeleteOrderbtn";
            this.DeleteOrderbtn.Size = new System.Drawing.Size(113, 81);
            this.DeleteOrderbtn.TabIndex = 3;
            this.DeleteOrderbtn.Text = "Delete Whole Order";
            this.DeleteOrderbtn.UseVisualStyleBackColor = true;
            this.DeleteOrderbtn.Click += new System.EventHandler(this.DeleteOrderbtn_Click);
            // 
            // PlaceOrderbtn
            // 
            this.PlaceOrderbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlaceOrderbtn.Location = new System.Drawing.Point(173, 571);
            this.PlaceOrderbtn.Name = "PlaceOrderbtn";
            this.PlaceOrderbtn.Size = new System.Drawing.Size(200, 77);
            this.PlaceOrderbtn.TabIndex = 4;
            this.PlaceOrderbtn.Text = "Place Order";
            this.PlaceOrderbtn.UseVisualStyleBackColor = true;
            this.PlaceOrderbtn.Click += new System.EventHandler(this.PlaceOrderbtn_Click);
            // 
            // oderOverviewbackbtn
            // 
            this.oderOverviewbackbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oderOverviewbackbtn.Location = new System.Drawing.Point(12, 663);
            this.oderOverviewbackbtn.Name = "oderOverviewbackbtn";
            this.oderOverviewbackbtn.Size = new System.Drawing.Size(200, 77);
            this.oderOverviewbackbtn.TabIndex = 5;
            this.oderOverviewbackbtn.Text = "Back";
            this.oderOverviewbackbtn.UseVisualStyleBackColor = true;
            this.oderOverviewbackbtn.Click += new System.EventHandler(this.oderOverviewbackbtn_Click_1);
            // 
            // TableOverviewbtn
            // 
            this.TableOverviewbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TableOverviewbtn.Location = new System.Drawing.Point(330, 663);
            this.TableOverviewbtn.Name = "TableOverviewbtn";
            this.TableOverviewbtn.Size = new System.Drawing.Size(197, 78);
            this.TableOverviewbtn.TabIndex = 6;
            this.TableOverviewbtn.Text = "Table View";
            this.TableOverviewbtn.UseVisualStyleBackColor = true;
            this.TableOverviewbtn.Click += new System.EventHandler(this.TableOverviewbtn_Click);
            // 
            // EmployeeNamelbl
            // 
            this.EmployeeNamelbl.AutoSize = true;
            this.EmployeeNamelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EmployeeNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmployeeNamelbl.Location = new System.Drawing.Point(369, 5);
            this.EmployeeNamelbl.Name = "EmployeeNamelbl";
            this.EmployeeNamelbl.Size = new System.Drawing.Size(158, 27);
            this.EmployeeNamelbl.TabIndex = 7;
            this.EmployeeNamelbl.Text = "Employee Name";
            this.EmployeeNamelbl.Click += new System.EventHandler(this.EmployeeNamelbl_Click);
            // 
            // tableNumberlbl
            // 
            this.tableNumberlbl.AutoSize = true;
            this.tableNumberlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tableNumberlbl.Location = new System.Drawing.Point(12, 9);
            this.tableNumberlbl.Name = "tableNumberlbl";
            this.tableNumberlbl.Size = new System.Drawing.Size(136, 25);
            this.tableNumberlbl.TabIndex = 8;
            this.tableNumberlbl.Text = "Table Number";
            // 
            // OrderAddedlbl
            // 
            this.OrderAddedlbl.AutoSize = true;
            this.OrderAddedlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrderAddedlbl.ForeColor = System.Drawing.Color.Green;
            this.OrderAddedlbl.Location = new System.Drawing.Point(161, 87);
            this.OrderAddedlbl.Name = "OrderAddedlbl";
            this.OrderAddedlbl.Size = new System.Drawing.Size(171, 29);
            this.OrderAddedlbl.TabIndex = 9;
            this.OrderAddedlbl.Text = "Order Added!";
            // 
            // OrderOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 752);
            this.Controls.Add(this.OrderAddedlbl);
            this.Controls.Add(this.tableNumberlbl);
            this.Controls.Add(this.EmployeeNamelbl);
            this.Controls.Add(this.TableOverviewbtn);
            this.Controls.Add(this.oderOverviewbackbtn);
            this.Controls.Add(this.PlaceOrderbtn);
            this.Controls.Add(this.DeleteOrderbtn);
            this.Controls.Add(this.MinusOrderbtn);
            this.Controls.Add(this.PlusOrderbtn);
            this.Controls.Add(this.OrderlistView);
            this.Name = "OrderOverviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderOverviewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView OrderlistView;
        private System.Windows.Forms.Button PlusOrderbtn;
        private System.Windows.Forms.Button MinusOrderbtn;
        private System.Windows.Forms.Button DeleteOrderbtn;
        private System.Windows.Forms.Button PlaceOrderbtn;
        private System.Windows.Forms.Button oderOverviewbackbtn;
        private System.Windows.Forms.ColumnHeader OrderItemName;
        private System.Windows.Forms.ColumnHeader OrderItemQuantity;
        private System.Windows.Forms.ColumnHeader OrderComment;
        private System.Windows.Forms.ColumnHeader orderItemId;
        private System.Windows.Forms.ColumnHeader menuItemStock;
        private System.Windows.Forms.Button TableOverviewbtn;
        private System.Windows.Forms.Label EmployeeNamelbl;
        private System.Windows.Forms.Label tableNumberlbl;
        private System.Windows.Forms.Label OrderAddedlbl;
    }
}