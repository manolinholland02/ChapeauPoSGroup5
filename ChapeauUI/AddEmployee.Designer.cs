﻿
namespace ChapeauUI
{
    partial class AddEmployee
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
            this.label_AddEmployee_FirstName = new System.Windows.Forms.Label();
            this.label_AddEmployee_LastName = new System.Windows.Forms.Label();
            this.label_AddEmploye_Username = new System.Windows.Forms.Label();
            this.label_AddEmployee_Password = new System.Windows.Forms.Label();
            this.groupBox_AddEmployee_Occupation = new System.Windows.Forms.GroupBox();
            this.radioButton_AddEmployee_Bartender = new System.Windows.Forms.RadioButton();
            this.radioButton_AddEmployee_Manager = new System.Windows.Forms.RadioButton();
            this.radioButton_AddEmployee_Waiter = new System.Windows.Forms.RadioButton();
            this.radioButton_AddEmployee_Chef = new System.Windows.Forms.RadioButton();
            this.textBox_AddEmployee_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_AddEmployee_LastName = new System.Windows.Forms.TextBox();
            this.textBox_AddEmployee_Username = new System.Windows.Forms.TextBox();
            this.textBox_AddEmployee_Password = new System.Windows.Forms.TextBox();
            this.button_AddEmployee = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.groupBox_AddEmployee_Occupation.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_AddEmployee_FirstName
            // 
            this.label_AddEmployee_FirstName.AutoSize = true;
            this.label_AddEmployee_FirstName.Location = new System.Drawing.Point(30, 105);
            this.label_AddEmployee_FirstName.Name = "label_AddEmployee_FirstName";
            this.label_AddEmployee_FirstName.Size = new System.Drawing.Size(80, 20);
            this.label_AddEmployee_FirstName.TabIndex = 0;
            this.label_AddEmployee_FirstName.Text = "First Name";
            // 
            // label_AddEmployee_LastName
            // 
            this.label_AddEmployee_LastName.AutoSize = true;
            this.label_AddEmployee_LastName.Location = new System.Drawing.Point(30, 149);
            this.label_AddEmployee_LastName.Name = "label_AddEmployee_LastName";
            this.label_AddEmployee_LastName.Size = new System.Drawing.Size(79, 20);
            this.label_AddEmployee_LastName.TabIndex = 1;
            this.label_AddEmployee_LastName.Text = "Last Name";
            // 
            // label_AddEmploye_Username
            // 
            this.label_AddEmploye_Username.AutoSize = true;
            this.label_AddEmploye_Username.Location = new System.Drawing.Point(30, 195);
            this.label_AddEmploye_Username.Name = "label_AddEmploye_Username";
            this.label_AddEmploye_Username.Size = new System.Drawing.Size(75, 20);
            this.label_AddEmploye_Username.TabIndex = 2;
            this.label_AddEmploye_Username.Text = "Username";
            // 
            // label_AddEmployee_Password
            // 
            this.label_AddEmployee_Password.AutoSize = true;
            this.label_AddEmployee_Password.Location = new System.Drawing.Point(30, 235);
            this.label_AddEmployee_Password.Name = "label_AddEmployee_Password";
            this.label_AddEmployee_Password.Size = new System.Drawing.Size(70, 20);
            this.label_AddEmployee_Password.TabIndex = 4;
            this.label_AddEmployee_Password.Text = "Password";
            // 
            // groupBox_AddEmployee_Occupation
            // 
            this.groupBox_AddEmployee_Occupation.Controls.Add(this.radioButton_AddEmployee_Bartender);
            this.groupBox_AddEmployee_Occupation.Controls.Add(this.radioButton_AddEmployee_Manager);
            this.groupBox_AddEmployee_Occupation.Controls.Add(this.radioButton_AddEmployee_Waiter);
            this.groupBox_AddEmployee_Occupation.Controls.Add(this.radioButton_AddEmployee_Chef);
            this.groupBox_AddEmployee_Occupation.Location = new System.Drawing.Point(30, 291);
            this.groupBox_AddEmployee_Occupation.Name = "groupBox_AddEmployee_Occupation";
            this.groupBox_AddEmployee_Occupation.Size = new System.Drawing.Size(364, 125);
            this.groupBox_AddEmployee_Occupation.TabIndex = 5;
            this.groupBox_AddEmployee_Occupation.TabStop = false;
            this.groupBox_AddEmployee_Occupation.Text = "Occupation";
            // 
            // radioButton_AddEmployee_Bartender
            // 
            this.radioButton_AddEmployee_Bartender.Location = new System.Drawing.Point(175, 37);
            this.radioButton_AddEmployee_Bartender.Name = "radioButton_AddEmployee_Bartender";
            this.radioButton_AddEmployee_Bartender.Size = new System.Drawing.Size(117, 24);
            this.radioButton_AddEmployee_Bartender.TabIndex = 8;
            this.radioButton_AddEmployee_Bartender.Text = "Bartender";
            this.radioButton_AddEmployee_Bartender.UseVisualStyleBackColor = true;
            // 
            // radioButton_AddEmployee_Manager
            // 
            this.radioButton_AddEmployee_Manager.AutoSize = true;
            this.radioButton_AddEmployee_Manager.Location = new System.Drawing.Point(175, 76);
            this.radioButton_AddEmployee_Manager.Name = "radioButton_AddEmployee_Manager";
            this.radioButton_AddEmployee_Manager.Size = new System.Drawing.Size(89, 24);
            this.radioButton_AddEmployee_Manager.TabIndex = 9;
            this.radioButton_AddEmployee_Manager.Text = "Manager";
            this.radioButton_AddEmployee_Manager.UseVisualStyleBackColor = true;
            // 
            // radioButton_AddEmployee_Waiter
            // 
            this.radioButton_AddEmployee_Waiter.AutoSize = true;
            this.radioButton_AddEmployee_Waiter.Location = new System.Drawing.Point(7, 37);
            this.radioButton_AddEmployee_Waiter.Name = "radioButton_AddEmployee_Waiter";
            this.radioButton_AddEmployee_Waiter.Size = new System.Drawing.Size(73, 24);
            this.radioButton_AddEmployee_Waiter.TabIndex = 6;
            this.radioButton_AddEmployee_Waiter.Text = "Waiter";
            this.radioButton_AddEmployee_Waiter.UseVisualStyleBackColor = true;
            // 
            // radioButton_AddEmployee_Chef
            // 
            this.radioButton_AddEmployee_Chef.AutoSize = true;
            this.radioButton_AddEmployee_Chef.Location = new System.Drawing.Point(7, 76);
            this.radioButton_AddEmployee_Chef.Name = "radioButton_AddEmployee_Chef";
            this.radioButton_AddEmployee_Chef.Size = new System.Drawing.Size(60, 24);
            this.radioButton_AddEmployee_Chef.TabIndex = 7;
            this.radioButton_AddEmployee_Chef.Text = "Chef";
            this.radioButton_AddEmployee_Chef.UseVisualStyleBackColor = true;
            // 
            // textBox_AddEmployee_FirstName
            // 
            this.textBox_AddEmployee_FirstName.Location = new System.Drawing.Point(188, 105);
            this.textBox_AddEmployee_FirstName.Name = "textBox_AddEmployee_FirstName";
            this.textBox_AddEmployee_FirstName.Size = new System.Drawing.Size(125, 27);
            this.textBox_AddEmployee_FirstName.TabIndex = 6;
            // 
            // textBox_AddEmployee_LastName
            // 
            this.textBox_AddEmployee_LastName.Location = new System.Drawing.Point(188, 149);
            this.textBox_AddEmployee_LastName.Name = "textBox_AddEmployee_LastName";
            this.textBox_AddEmployee_LastName.Size = new System.Drawing.Size(125, 27);
            this.textBox_AddEmployee_LastName.TabIndex = 7;
            // 
            // textBox_AddEmployee_Username
            // 
            this.textBox_AddEmployee_Username.Location = new System.Drawing.Point(188, 195);
            this.textBox_AddEmployee_Username.Name = "textBox_AddEmployee_Username";
            this.textBox_AddEmployee_Username.Size = new System.Drawing.Size(125, 27);
            this.textBox_AddEmployee_Username.TabIndex = 8;
            // 
            // textBox_AddEmployee_Password
            // 
            this.textBox_AddEmployee_Password.Location = new System.Drawing.Point(188, 235);
            this.textBox_AddEmployee_Password.Name = "textBox_AddEmployee_Password";
            this.textBox_AddEmployee_Password.Size = new System.Drawing.Size(125, 27);
            this.textBox_AddEmployee_Password.TabIndex = 9;
            // 
            // button_AddEmployee
            // 
            this.button_AddEmployee.Location = new System.Drawing.Point(587, 137);
            this.button_AddEmployee.Name = "button_AddEmployee";
            this.button_AddEmployee.Size = new System.Drawing.Size(94, 29);
            this.button_AddEmployee.TabIndex = 10;
            this.button_AddEmployee.Text = "Add Employee";
            this.button_AddEmployee.UseVisualStyleBackColor = true;
            this.button_AddEmployee.Click += new System.EventHandler(this.button_AddEmployee_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(587, 195);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(94, 29);
            this.button_Cancel.TabIndex = 11;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_AddEmployee);
            this.Controls.Add(this.textBox_AddEmployee_Password);
            this.Controls.Add(this.textBox_AddEmployee_Username);
            this.Controls.Add(this.textBox_AddEmployee_LastName);
            this.Controls.Add(this.textBox_AddEmployee_FirstName);
            this.Controls.Add(this.groupBox_AddEmployee_Occupation);
            this.Controls.Add(this.label_AddEmployee_Password);
            this.Controls.Add(this.label_AddEmploye_Username);
            this.Controls.Add(this.label_AddEmployee_LastName);
            this.Controls.Add(this.label_AddEmployee_FirstName);
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            this.groupBox_AddEmployee_Occupation.ResumeLayout(false);
            this.groupBox_AddEmployee_Occupation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_AddEmployee_FirstName;
        private System.Windows.Forms.Label label_AddEmployee_LastName;
        private System.Windows.Forms.Label label_AddEmploye_Username;
        private System.Windows.Forms.Label label_AddEmployee_Password;
        private System.Windows.Forms.GroupBox groupBox_AddEmployee_Occupation;
        private System.Windows.Forms.RadioButton radioButton_AddEmployee_Waiter;
        private System.Windows.Forms.RadioButton radioButton_AddEmployee_Chef;
        private System.Windows.Forms.RadioButton radioButton_AddEmployee_Bartender;
        private System.Windows.Forms.RadioButton radioButton_AddEmployee_Manager;
        private System.Windows.Forms.TextBox textBox_AddEmployee_FirstName;
        private System.Windows.Forms.TextBox textBox_AddEmployee_LastName;
        private System.Windows.Forms.TextBox textBox_AddEmployee_Username;
        private System.Windows.Forms.TextBox textBox_AddEmployee_Password;
        private System.Windows.Forms.Button button_AddEmployee;
        private System.Windows.Forms.Button button_Cancel;
    }
}