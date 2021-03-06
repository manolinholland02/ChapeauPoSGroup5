
namespace ChapeauUI
{
    partial class ManagerViewEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerViewEmployee));
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
            this.button_Employees_Form = new System.Windows.Forms.Button();
            this.button_Menu_Form = new System.Windows.Forms.Button();
            this.panel_Manager = new System.Windows.Forms.Panel();
            this.label_managerName = new System.Windows.Forms.Label();
            this.pictureBox_Manager = new System.Windows.Forms.PictureBox();
            this.panel_Manager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Manager)).BeginInit();
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
            this.listView_Employees_Management.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView_Employees_Management.ForeColor = System.Drawing.Color.Black;
            this.listView_Employees_Management.FullRowSelect = true;
            this.listView_Employees_Management.HideSelection = false;
            this.listView_Employees_Management.Location = new System.Drawing.Point(12, 205);
            this.listView_Employees_Management.MultiSelect = false;
            this.listView_Employees_Management.Name = "listView_Employees_Management";
            this.listView_Employees_Management.Size = new System.Drawing.Size(1398, 420);
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
            this.EmployeeFirstName.Width = 300;
            // 
            // EmployeeLastName
            // 
            this.EmployeeLastName.Text = "Last Name";
            this.EmployeeLastName.Width = 300;
            // 
            // EmployeeUsername
            // 
            this.EmployeeUsername.Text = "Username";
            this.EmployeeUsername.Width = 300;
            // 
            // EmployeePassword
            // 
            this.EmployeePassword.Text = "Password";
            this.EmployeePassword.Width = 260;
            // 
            // EmployeeType
            // 
            this.EmployeeType.Text = "Occupation";
            this.EmployeeType.Width = 230;
            // 
            // button_Add_Employee
            // 
            this.button_Add_Employee.BackColor = System.Drawing.Color.Gainsboro;
            this.button_Add_Employee.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Add_Employee.Location = new System.Drawing.Point(69, 764);
            this.button_Add_Employee.Name = "button_Add_Employee";
            this.button_Add_Employee.Size = new System.Drawing.Size(200, 85);
            this.button_Add_Employee.TabIndex = 1;
            this.button_Add_Employee.Text = "Add Employee";
            this.button_Add_Employee.UseVisualStyleBackColor = false;
            this.button_Add_Employee.Click += new System.EventHandler(this.button_Add_Employee_Click);
            // 
            // button_Delete_Employee
            // 
            this.button_Delete_Employee.BackColor = System.Drawing.Color.Gainsboro;
            this.button_Delete_Employee.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Delete_Employee.ForeColor = System.Drawing.Color.Black;
            this.button_Delete_Employee.Location = new System.Drawing.Point(1131, 764);
            this.button_Delete_Employee.Name = "button_Delete_Employee";
            this.button_Delete_Employee.Size = new System.Drawing.Size(200, 85);
            this.button_Delete_Employee.TabIndex = 2;
            this.button_Delete_Employee.Text = "Delete";
            this.button_Delete_Employee.UseVisualStyleBackColor = false;
            this.button_Delete_Employee.Click += new System.EventHandler(this.button_Delete_Employee_Click);
            // 
            // button_Edit_Employee
            // 
            this.button_Edit_Employee.BackColor = System.Drawing.Color.Gainsboro;
            this.button_Edit_Employee.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Edit_Employee.ForeColor = System.Drawing.Color.Black;
            this.button_Edit_Employee.Location = new System.Drawing.Point(625, 764);
            this.button_Edit_Employee.Name = "button_Edit_Employee";
            this.button_Edit_Employee.Size = new System.Drawing.Size(200, 85);
            this.button_Edit_Employee.TabIndex = 3;
            this.button_Edit_Employee.Text = "Edit";
            this.button_Edit_Employee.UseVisualStyleBackColor = false;
            this.button_Edit_Employee.Click += new System.EventHandler(this.button_Edit_Employee_Click);
            // 
            // button_Employees_Form
            // 
            this.button_Employees_Form.BackColor = System.Drawing.Color.Gainsboro;
            this.button_Employees_Form.Enabled = false;
            this.button_Employees_Form.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Employees_Form.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Employees_Form.Location = new System.Drawing.Point(30, 127);
            this.button_Employees_Form.Name = "button_Employees_Form";
            this.button_Employees_Form.Size = new System.Drawing.Size(164, 63);
            this.button_Employees_Form.TabIndex = 4;
            this.button_Employees_Form.Text = "Employees";
            this.button_Employees_Form.UseVisualStyleBackColor = false;
            // 
            // button_Menu_Form
            // 
            this.button_Menu_Form.BackColor = System.Drawing.Color.Gainsboro;
            this.button_Menu_Form.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Menu_Form.Location = new System.Drawing.Point(190, 127);
            this.button_Menu_Form.Name = "button_Menu_Form";
            this.button_Menu_Form.Size = new System.Drawing.Size(164, 63);
            this.button_Menu_Form.TabIndex = 5;
            this.button_Menu_Form.Text = "Menu Items";
            this.button_Menu_Form.UseVisualStyleBackColor = false;
            this.button_Menu_Form.Click += new System.EventHandler(this.button_Menu_Form_Click);
            // 
            // panel_Manager
            // 
            this.panel_Manager.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_Manager.Controls.Add(this.label_managerName);
            this.panel_Manager.Controls.Add(this.pictureBox_Manager);
            this.panel_Manager.Location = new System.Drawing.Point(0, 0);
            this.panel_Manager.Name = "panel_Manager";
            this.panel_Manager.Size = new System.Drawing.Size(1422, 99);
            this.panel_Manager.TabIndex = 6;
            // 
            // label_managerName
            // 
            this.label_managerName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_managerName.ForeColor = System.Drawing.Color.Black;
            this.label_managerName.Location = new System.Drawing.Point(1187, 9);
            this.label_managerName.Name = "label_managerName";
            this.label_managerName.Size = new System.Drawing.Size(223, 88);
            this.label_managerName.TabIndex = 14;
            this.label_managerName.Text = "label1";
            this.label_managerName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label_managerName.Click += new System.EventHandler(this.label_managerName_Click);
            // 
            // pictureBox_Manager
            // 
            this.pictureBox_Manager.BackColor = System.Drawing.Color.White;
            this.pictureBox_Manager.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_Manager.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Manager.Image")));
            this.pictureBox_Manager.Location = new System.Drawing.Point(616, 0);
            this.pictureBox_Manager.Name = "pictureBox_Manager";
            this.pictureBox_Manager.Size = new System.Drawing.Size(188, 99);
            this.pictureBox_Manager.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Manager.TabIndex = 13;
            this.pictureBox_Manager.TabStop = false;
            // 
            // ManagerViewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1422, 977);
            this.Controls.Add(this.panel_Manager);
            this.Controls.Add(this.button_Menu_Form);
            this.Controls.Add(this.button_Employees_Form);
            this.Controls.Add(this.button_Edit_Employee);
            this.Controls.Add(this.button_Delete_Employee);
            this.Controls.Add(this.button_Add_Employee);
            this.Controls.Add(this.listView_Employees_Management);
            this.Name = "ManagerViewEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerView";
            this.panel_Manager.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Manager)).EndInit();
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
        private System.Windows.Forms.Button button_Employees_Form;
        private System.Windows.Forms.Button button_Menu_Form;
        private System.Windows.Forms.Panel panel_Manager;
        private System.Windows.Forms.PictureBox pictureBox_Manager;
        private System.Windows.Forms.Label label_managerName;
    }
}