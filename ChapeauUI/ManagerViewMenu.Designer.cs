
namespace ChapeauUI
{
    partial class ManagerViewMenu
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
            this.listView_Employees_Management = new System.Windows.Forms.ListView();
            this.MenuItemId = new System.Windows.Forms.ColumnHeader();
            this.EmployeeFirstName = new System.Windows.Forms.ColumnHeader();
            this.EmployeeLastName = new System.Windows.Forms.ColumnHeader();
            this.EmployeeUsername = new System.Windows.Forms.ColumnHeader();
            this.EmployeePassword = new System.Windows.Forms.ColumnHeader();
            this.EmployeeType = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // listView_Employees_Management
            // 
            this.listView_Employees_Management.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MenuItemId,
            this.EmployeeFirstName,
            this.EmployeeLastName,
            this.EmployeeUsername,
            this.EmployeePassword,
            this.EmployeeType});
            this.listView_Employees_Management.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView_Employees_Management.FullRowSelect = true;
            this.listView_Employees_Management.HideSelection = false;
            this.listView_Employees_Management.Location = new System.Drawing.Point(111, 278);
            this.listView_Employees_Management.MultiSelect = false;
            this.listView_Employees_Management.Name = "listView_Employees_Management";
            this.listView_Employees_Management.Size = new System.Drawing.Size(1200, 420);
            this.listView_Employees_Management.TabIndex = 1;
            this.listView_Employees_Management.UseCompatibleStateImageBehavior = false;
            this.listView_Employees_Management.View = System.Windows.Forms.View.Details;
            // 
            // MenuItemId
            // 
            this.MenuItemId.Text = "Id";
            this.MenuItemId.Width = 0;
            // 
            // EmployeeFirstName
            // 
            this.EmployeeFirstName.Text = "First Name";
            this.EmployeeFirstName.Width = 240;
            // 
            // EmployeeLastName
            // 
            this.EmployeeLastName.Text = "Last Name";
            this.EmployeeLastName.Width = 240;
            // 
            // EmployeeUsername
            // 
            this.EmployeeUsername.Text = "Username";
            this.EmployeeUsername.Width = 240;
            // 
            // EmployeePassword
            // 
            this.EmployeePassword.Text = "Password";
            this.EmployeePassword.Width = 240;
            // 
            // EmployeeType
            // 
            this.EmployeeType.Text = "Occupation";
            this.EmployeeType.Width = 230;
            // 
            // ManagerViewMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 977);
            this.Controls.Add(this.listView_Employees_Management);
            this.Name = "ManagerViewMenu";
            this.Text = "ManagerViewMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_Employees_Management;
        private System.Windows.Forms.ColumnHeader MenuItemId;
        private System.Windows.Forms.ColumnHeader EmployeeFirstName;
        private System.Windows.Forms.ColumnHeader EmployeeLastName;
        private System.Windows.Forms.ColumnHeader EmployeeUsername;
        private System.Windows.Forms.ColumnHeader EmployeePassword;
        private System.Windows.Forms.ColumnHeader EmployeeType;
    }
}