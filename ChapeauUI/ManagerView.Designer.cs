
namespace ChapeauUI
{
    partial class ManagerView
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
            this.EmployeeId = new System.Windows.Forms.ColumnHeader();
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
            this.EmployeeId,
            this.EmployeeFirstName,
            this.EmployeeLastName,
            this.EmployeeUsername,
            this.EmployeePassword,
            this.EmployeeType});
            this.listView_Employees_Management.FullRowSelect = true;
            this.listView_Employees_Management.HideSelection = false;
            this.listView_Employees_Management.Location = new System.Drawing.Point(69, 101);
            this.listView_Employees_Management.MultiSelect = false;
            this.listView_Employees_Management.Name = "listView_Employees_Management";
            this.listView_Employees_Management.Size = new System.Drawing.Size(619, 209);
            this.listView_Employees_Management.TabIndex = 0;
            this.listView_Employees_Management.UseCompatibleStateImageBehavior = false;
            this.listView_Employees_Management.View = System.Windows.Forms.View.Details;
            this.listView_Employees_Management.SelectedIndexChanged += new System.EventHandler(this.listView_Employees_Management_SelectedIndexChanged);
            // 
            // EmployeeId
            // 
            this.EmployeeId.Text = "Id";
            // 
            // EmployeeFirstName
            // 
            this.EmployeeFirstName.Text = "First Name";
            this.EmployeeFirstName.Width = 100;
            // 
            // EmployeeLastName
            // 
            this.EmployeeLastName.Text = "Last Name";
            this.EmployeeLastName.Width = 100;
            // 
            // EmployeeUsername
            // 
            this.EmployeeUsername.Text = "Username";
            this.EmployeeUsername.Width = 100;
            // 
            // EmployeePassword
            // 
            this.EmployeePassword.Text = "Password";
            this.EmployeePassword.Width = 100;
            // 
            // EmployeeType
            // 
            this.EmployeeType.Text = "Occupation";
            this.EmployeeType.Width = 100;
            // 
            // ManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView_Employees_Management);
            this.Name = "ManagerView";
            this.Text = "ManagerView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_Employees_Management;
        private System.Windows.Forms.ColumnHeader EmployeeId;
        private System.Windows.Forms.ColumnHeader EmployeeFirstName;
        private System.Windows.Forms.ColumnHeader EmployeeLastName;
        private System.Windows.Forms.ColumnHeader EmployeeUsername;
        private System.Windows.Forms.ColumnHeader EmployeePassword;
        private System.Windows.Forms.ColumnHeader EmployeeType;
    }
}