
namespace ChapeauUI
{
    partial class ChoosingMenuForm
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
            this.LunchMenubtn = new System.Windows.Forms.Button();
            this.DinnerMenubtn = new System.Windows.Forms.Button();
            this.DrinksMenubtn = new System.Windows.Forms.Button();
            this.MenuPageTableViewbtn = new System.Windows.Forms.Button();
            this.OrderOverviewbtn = new System.Windows.Forms.Button();
            this.totalOrderCountlbl = new System.Windows.Forms.Label();
            this.tableNumberlbl = new System.Windows.Forms.Label();
            this.EmployeeNamelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LunchMenubtn
            // 
            this.LunchMenubtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LunchMenubtn.Location = new System.Drawing.Point(86, 209);
            this.LunchMenubtn.Name = "LunchMenubtn";
            this.LunchMenubtn.Size = new System.Drawing.Size(360, 77);
            this.LunchMenubtn.TabIndex = 0;
            this.LunchMenubtn.Text = "Lunch Menu";
            this.LunchMenubtn.UseVisualStyleBackColor = true;
            this.LunchMenubtn.Click += new System.EventHandler(this.LunchMenubtn_Click);
            // 
            // DinnerMenubtn
            // 
            this.DinnerMenubtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DinnerMenubtn.Location = new System.Drawing.Point(86, 351);
            this.DinnerMenubtn.Name = "DinnerMenubtn";
            this.DinnerMenubtn.Size = new System.Drawing.Size(360, 77);
            this.DinnerMenubtn.TabIndex = 1;
            this.DinnerMenubtn.Text = "Dinner Menu";
            this.DinnerMenubtn.UseVisualStyleBackColor = true;
            this.DinnerMenubtn.Click += new System.EventHandler(this.DinnerMenubtn_Click);
            // 
            // DrinksMenubtn
            // 
            this.DrinksMenubtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DrinksMenubtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DrinksMenubtn.Location = new System.Drawing.Point(86, 493);
            this.DrinksMenubtn.Name = "DrinksMenubtn";
            this.DrinksMenubtn.Size = new System.Drawing.Size(360, 77);
            this.DrinksMenubtn.TabIndex = 2;
            this.DrinksMenubtn.Text = "Drinks Menu";
            this.DrinksMenubtn.UseVisualStyleBackColor = false;
            this.DrinksMenubtn.Click += new System.EventHandler(this.DrinksMenubtn_Click);
            // 
            // MenuPageTableViewbtn
            // 
            this.MenuPageTableViewbtn.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MenuPageTableViewbtn.Location = new System.Drawing.Point(12, 661);
            this.MenuPageTableViewbtn.Name = "MenuPageTableViewbtn";
            this.MenuPageTableViewbtn.Size = new System.Drawing.Size(200, 77);
            this.MenuPageTableViewbtn.TabIndex = 4;
            this.MenuPageTableViewbtn.Text = "Table View";
            this.MenuPageTableViewbtn.UseVisualStyleBackColor = true;
            this.MenuPageTableViewbtn.Click += new System.EventHandler(this.MenuPageTableViewbtn_Click);
            // 
            // OrderOverviewbtn
            // 
            this.OrderOverviewbtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrderOverviewbtn.Location = new System.Drawing.Point(410, 29);
            this.OrderOverviewbtn.Name = "OrderOverviewbtn";
            this.OrderOverviewbtn.Size = new System.Drawing.Size(115, 82);
            this.OrderOverviewbtn.TabIndex = 5;
            this.OrderOverviewbtn.Text = "See Table\'s Orders";
            this.OrderOverviewbtn.UseVisualStyleBackColor = true;
            this.OrderOverviewbtn.Click += new System.EventHandler(this.OrderOverviewbtn_Click);
            // 
            // totalOrderCountlbl
            // 
            this.totalOrderCountlbl.AutoSize = true;
            this.totalOrderCountlbl.Location = new System.Drawing.Point(12, 49);
            this.totalOrderCountlbl.Name = "totalOrderCountlbl";
            this.totalOrderCountlbl.Size = new System.Drawing.Size(170, 20);
            this.totalOrderCountlbl.TabIndex = 6;
            this.totalOrderCountlbl.Text = "Total items in the order: ";
            // 
            // tableNumberlbl
            // 
            this.tableNumberlbl.AutoSize = true;
            this.tableNumberlbl.Location = new System.Drawing.Point(12, 9);
            this.tableNumberlbl.Name = "tableNumberlbl";
            this.tableNumberlbl.Size = new System.Drawing.Size(109, 20);
            this.tableNumberlbl.TabIndex = 7;
            this.tableNumberlbl.Text = "Table Number: ";
            // 
            // EmployeeNamelbl
            // 
            this.EmployeeNamelbl.AutoSize = true;
            this.EmployeeNamelbl.Location = new System.Drawing.Point(12, 29);
            this.EmployeeNamelbl.Name = "EmployeeNamelbl";
            this.EmployeeNamelbl.Size = new System.Drawing.Size(119, 20);
            this.EmployeeNamelbl.TabIndex = 8;
            this.EmployeeNamelbl.Text = "Employee Name";
            // 
            // ChoosingMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 752);
            this.Controls.Add(this.EmployeeNamelbl);
            this.Controls.Add(this.tableNumberlbl);
            this.Controls.Add(this.totalOrderCountlbl);
            this.Controls.Add(this.OrderOverviewbtn);
            this.Controls.Add(this.MenuPageTableViewbtn);
            this.Controls.Add(this.DrinksMenubtn);
            this.Controls.Add(this.DinnerMenubtn);
            this.Controls.Add(this.LunchMenubtn);
            this.Name = "ChoosingMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChoosingMenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LunchMenubtn;
        private System.Windows.Forms.Button DinnerMenubtn;
        private System.Windows.Forms.Button DrinksMenubtn;
        private System.Windows.Forms.Button MenuPageTableViewbtn;
        private System.Windows.Forms.Button OrderOverviewbtn;
        private System.Windows.Forms.Label totalOrderCountlbl;
        private System.Windows.Forms.Label tableNumberlbl;
        private System.Windows.Forms.Label EmployeeNamelbl;
    }
}