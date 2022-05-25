
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
            this.button_Add_Employee = new System.Windows.Forms.Button();
            this.button_Delete_Employee = new System.Windows.Forms.Button();
            this.button_Edit_Employee = new System.Windows.Forms.Button();
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
            this.listView_Employees_Management.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView_Employees_Management.FullRowSelect = true;
            this.listView_Employees_Management.HideSelection = false;
            this.listView_Employees_Management.Location = new System.Drawing.Point(69, 240);
            this.listView_Employees_Management.MultiSelect = false;
            this.listView_Employees_Management.Name = "listView_Employees_Management";
            this.listView_Employees_Management.Size = new System.Drawing.Size(1200, 420);
            this.listView_Employees_Management.TabIndex = 0;
            this.listView_Employees_Management.UseCompatibleStateImageBehavior = false;
            this.listView_Employees_Management.View = System.Windows.Forms.View.Details;
            this.listView_Employees_Management.SelectedIndexChanged += new System.EventHandler(this.listView_Employees_Management_SelectedIndexChanged);
            // 
            // EmployeeId
            // 
            this.EmployeeId.Text = "Id";
            this.EmployeeId.Width = 0;
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
            // button_Add_Employee
            // 
            this.button_Add_Employee.Location = new System.Drawing.Point(69, 764);
            this.button_Add_Employee.Name = "button_Add_Employee";
            this.button_Add_Employee.Size = new System.Drawing.Size(150, 80);
            this.button_Add_Employee.TabIndex = 1;
            this.button_Add_Employee.Text = "Add Employee";
            this.button_Add_Employee.UseVisualStyleBackColor = true;
            this.button_Add_Employee.Click += new System.EventHandler(this.button_Add_Employee_Click);
            // 
            // button_Delete_Employee
            // 
            this.button_Delete_Employee.Location = new System.Drawing.Point(625, 764);
            this.button_Delete_Employee.Name = "button_Delete_Employee";
            this.button_Delete_Employee.Size = new System.Drawing.Size(150, 80);
            this.button_Delete_Employee.TabIndex = 2;
            this.button_Delete_Employee.Text = "Delete";
            this.button_Delete_Employee.UseVisualStyleBackColor = true;
            this.button_Delete_Employee.Click += new System.EventHandler(this.button_Delete_Employee_Click);
            // 
            // button_Edit_Employee
            // 
            this.button_Edit_Employee.Location = new System.Drawing.Point(1131, 764);
            this.button_Edit_Employee.Name = "button_Edit_Employee";
            this.button_Edit_Employee.Size = new System.Drawing.Size(150, 80);
            this.button_Edit_Employee.TabIndex = 3;
            this.button_Edit_Employee.Text = "Edit";
            this.button_Edit_Employee.UseVisualStyleBackColor = true;
            // 
            // ManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 977);
            this.Controls.Add(this.button_Edit_Employee);
            this.Controls.Add(this.button_Delete_Employee);
            this.Controls.Add(this.button_Add_Employee);
            this.Controls.Add(this.listView_Employees_Management);
            this.Name = "ManagerView";
            this.Text = "ManagerView";
            this.Load += new System.EventHandler(this.ManagerView_Load);
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
        private System.Windows.Forms.Button button_Add_Employee;
        private System.Windows.Forms.Button button_Delete_Employee;
        private System.Windows.Forms.Button button_Edit_Employee;
    }
}