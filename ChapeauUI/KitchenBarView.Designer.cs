
namespace ChapeauUI
{
    partial class KitchenBarView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitchenBarView));
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.kitchenBarViewHeader = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.panelLegend = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSufficientTime = new System.Windows.Forms.Label();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.panelFilterButtons = new System.Windows.Forms.Panel();
            this.btnPastOrders = new System.Windows.Forms.Button();
            this.btnIncomingOrders = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.kitchenBarViewHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelLegend.SuspendLayout();
            this.panelFilterButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AllowUserToAddRows = false;
            this.ordersDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.ordersDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ordersDataGridView.ColumnHeadersHeight = 55;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ordersDataGridView.EnableHeadersVisualStyles = false;
            this.ordersDataGridView.Location = new System.Drawing.Point(23, 178);
            this.ordersDataGridView.MultiSelect = false;
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.RowHeadersVisible = false;
            this.ordersDataGridView.RowHeadersWidth = 4;
            this.ordersDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ordersDataGridView.RowTemplate.Height = 53;
            this.ordersDataGridView.Size = new System.Drawing.Size(1376, 754);
            this.ordersDataGridView.TabIndex = 0;
            this.ordersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersDataGridView_CellContentClick);
            this.ordersDataGridView.SelectionChanged += new System.EventHandler(this.ordersDataGridView_SelectionChanged);
            // 
            // kitchenBarViewHeader
            // 
            this.kitchenBarViewHeader.Controls.Add(this.pictureBoxLogo);
            this.kitchenBarViewHeader.Controls.Add(this.lblEmployeeName);
            this.kitchenBarViewHeader.Location = new System.Drawing.Point(0, 0);
            this.kitchenBarViewHeader.Name = "kitchenBarViewHeader";
            this.kitchenBarViewHeader.Size = new System.Drawing.Size(1422, 68);
            this.kitchenBarViewHeader.TabIndex = 1;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(653, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(115, 68);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmployeeName.ForeColor = System.Drawing.Color.Black;
            this.lblEmployeeName.Location = new System.Drawing.Point(1172, 12);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(245, 38);
            this.lblEmployeeName.TabIndex = 0;
            this.lblEmployeeName.Text = "Employee name";
            this.lblEmployeeName.Click += new System.EventHandler(this.lblEmployeeName_Click);
            // 
            // panelLegend
            // 
            this.panelLegend.Controls.Add(this.label1);
            this.panelLegend.Controls.Add(this.lblSufficientTime);
            this.panelLegend.Controls.Add(this.btnRed);
            this.panelLegend.Controls.Add(this.btnGreen);
            this.panelLegend.Location = new System.Drawing.Point(23, 74);
            this.panelLegend.Name = "panelLegend";
            this.panelLegend.Size = new System.Drawing.Size(349, 59);
            this.panelLegend.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order takes more than usual";
            // 
            // lblSufficientTime
            // 
            this.lblSufficientTime.AutoSize = true;
            this.lblSufficientTime.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSufficientTime.ForeColor = System.Drawing.Color.Black;
            this.lblSufficientTime.Location = new System.Drawing.Point(33, 1);
            this.lblSufficientTime.Name = "lblSufficientTime";
            this.lblSufficientTime.Size = new System.Drawing.Size(154, 26);
            this.lblSufficientTime.TabIndex = 2;
            this.lblSufficientTime.Text = "Sufficient time";
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRed.Enabled = false;
            this.btnRed.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRed.FlatAppearance.BorderSize = 2;
            this.btnRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRed.Location = new System.Drawing.Point(0, 32);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(27, 27);
            this.btnRed.TabIndex = 1;
            this.btnRed.UseVisualStyleBackColor = false;
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Green;
            this.btnGreen.Enabled = false;
            this.btnGreen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGreen.FlatAppearance.BorderSize = 2;
            this.btnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGreen.ForeColor = System.Drawing.Color.Black;
            this.btnGreen.Location = new System.Drawing.Point(0, 0);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(27, 27);
            this.btnGreen.TabIndex = 0;
            this.btnGreen.UseVisualStyleBackColor = false;
            // 
            // panelFilterButtons
            // 
            this.panelFilterButtons.Controls.Add(this.btnPastOrders);
            this.panelFilterButtons.Controls.Add(this.btnIncomingOrders);
            this.panelFilterButtons.Location = new System.Drawing.Point(40, 138);
            this.panelFilterButtons.Name = "panelFilterButtons";
            this.panelFilterButtons.Size = new System.Drawing.Size(420, 40);
            this.panelFilterButtons.TabIndex = 3;
            // 
            // btnPastOrders
            // 
            this.btnPastOrders.Location = new System.Drawing.Point(206, 0);
            this.btnPastOrders.Name = "btnPastOrders";
            this.btnPastOrders.Size = new System.Drawing.Size(206, 40);
            this.btnPastOrders.TabIndex = 4;
            this.btnPastOrders.Text = "Past orders";
            this.btnPastOrders.UseVisualStyleBackColor = true;
            this.btnPastOrders.Click += new System.EventHandler(this.btnPastOrders_Click);
            // 
            // btnIncomingOrders
            // 
            this.btnIncomingOrders.Location = new System.Drawing.Point(0, 0);
            this.btnIncomingOrders.Name = "btnIncomingOrders";
            this.btnIncomingOrders.Size = new System.Drawing.Size(206, 40);
            this.btnIncomingOrders.TabIndex = 4;
            this.btnIncomingOrders.Text = "Incoming orders";
            this.btnIncomingOrders.UseVisualStyleBackColor = true;
            this.btnIncomingOrders.Click += new System.EventHandler(this.btnIncomingOrders_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1294, 131);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(105, 36);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // KitchenBarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1422, 977);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panelFilterButtons);
            this.Controls.Add(this.panelLegend);
            this.Controls.Add(this.kitchenBarViewHeader);
            this.Controls.Add(this.ordersDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KitchenBarView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitchenBarView";
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.kitchenBarViewHeader.ResumeLayout(false);
            this.kitchenBarViewHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelLegend.ResumeLayout(false);
            this.panelLegend.PerformLayout();
            this.panelFilterButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.Panel kitchenBarViewHeader;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelLegend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSufficientTime;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Panel panelFilterButtons;
        private System.Windows.Forms.Button btnPastOrders;
        private System.Windows.Forms.Button btnIncomingOrders;
        private System.Windows.Forms.Button btnRefresh;
    }
}