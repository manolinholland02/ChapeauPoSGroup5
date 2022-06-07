﻿
namespace ChapeauUI
{
    partial class EditEmployee
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
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_EditEmployee = new System.Windows.Forms.Button();
            this.textBox_EditEmployee_Password = new System.Windows.Forms.TextBox();
            this.textBox_EditEmployee_Username = new System.Windows.Forms.TextBox();
            this.textBox_EditEmployee_LastName = new System.Windows.Forms.TextBox();
            this.textBox_EditEmployee_FirstName = new System.Windows.Forms.TextBox();
            this.groupBox_EditEmployee_Occupation = new System.Windows.Forms.GroupBox();
            this.radioButton_EditEmployee_Bartender = new System.Windows.Forms.RadioButton();
            this.radioButton_EditEmployee_Manager = new System.Windows.Forms.RadioButton();
            this.radioButton_EditEmployee_Waiter = new System.Windows.Forms.RadioButton();
            this.radioButton_EditEmployee_Chef = new System.Windows.Forms.RadioButton();
            this.label_EditEmployee_Password = new System.Windows.Forms.Label();
            this.label_EditEmploye_Username = new System.Windows.Forms.Label();
            this.label_EditEmployee_LastName = new System.Windows.Forms.Label();
            this.label_EditEmployee_FirstName = new System.Windows.Forms.Label();
            this.groupBox_EditEmployee_Occupation.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Cancel.Location = new System.Drawing.Point(971, 607);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(219, 80);
            this.button_Cancel.TabIndex = 22;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_EditEmployee
            // 
            this.button_EditEmployee.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_EditEmployee.Location = new System.Drawing.Point(177, 607);
            this.button_EditEmployee.Name = "button_EditEmployee";
            this.button_EditEmployee.Size = new System.Drawing.Size(219, 80);
            this.button_EditEmployee.TabIndex = 21;
            this.button_EditEmployee.Text = "Edit Employee";
            this.button_EditEmployee.UseVisualStyleBackColor = true;
            this.button_EditEmployee.Click += new System.EventHandler(this.button_EditEmployee_Click);
            // 
            // textBox_EditEmployee_Password
            // 
            this.textBox_EditEmployee_Password.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_EditEmployee_Password.Location = new System.Drawing.Point(657, 299);
            this.textBox_EditEmployee_Password.Name = "textBox_EditEmployee_Password";
            this.textBox_EditEmployee_Password.Size = new System.Drawing.Size(273, 43);
            this.textBox_EditEmployee_Password.TabIndex = 20;
            // 
            // textBox_EditEmployee_Username
            // 
            this.textBox_EditEmployee_Username.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_EditEmployee_Username.Location = new System.Drawing.Point(657, 246);
            this.textBox_EditEmployee_Username.Name = "textBox_EditEmployee_Username";
            this.textBox_EditEmployee_Username.Size = new System.Drawing.Size(273, 43);
            this.textBox_EditEmployee_Username.TabIndex = 19;
            // 
            // textBox_EditEmployee_LastName
            // 
            this.textBox_EditEmployee_LastName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_EditEmployee_LastName.Location = new System.Drawing.Point(657, 190);
            this.textBox_EditEmployee_LastName.Name = "textBox_EditEmployee_LastName";
            this.textBox_EditEmployee_LastName.Size = new System.Drawing.Size(273, 43);
            this.textBox_EditEmployee_LastName.TabIndex = 18;
            // 
            // textBox_EditEmployee_FirstName
            // 
            this.textBox_EditEmployee_FirstName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_EditEmployee_FirstName.Location = new System.Drawing.Point(657, 131);
            this.textBox_EditEmployee_FirstName.Name = "textBox_EditEmployee_FirstName";
            this.textBox_EditEmployee_FirstName.Size = new System.Drawing.Size(273, 43);
            this.textBox_EditEmployee_FirstName.TabIndex = 17;
            // 
            // groupBox_EditEmployee_Occupation
            // 
            this.groupBox_EditEmployee_Occupation.Controls.Add(this.radioButton_EditEmployee_Bartender);
            this.groupBox_EditEmployee_Occupation.Controls.Add(this.radioButton_EditEmployee_Manager);
            this.groupBox_EditEmployee_Occupation.Controls.Add(this.radioButton_EditEmployee_Waiter);
            this.groupBox_EditEmployee_Occupation.Controls.Add(this.radioButton_EditEmployee_Chef);
            this.groupBox_EditEmployee_Occupation.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_EditEmployee_Occupation.Location = new System.Drawing.Point(499, 355);
            this.groupBox_EditEmployee_Occupation.Name = "groupBox_EditEmployee_Occupation";
            this.groupBox_EditEmployee_Occupation.Size = new System.Drawing.Size(431, 167);
            this.groupBox_EditEmployee_Occupation.TabIndex = 16;
            this.groupBox_EditEmployee_Occupation.TabStop = false;
            this.groupBox_EditEmployee_Occupation.Text = "Occupation";
            // 
            // radioButton_EditEmployee_Bartender
            // 
            this.radioButton_EditEmployee_Bartender.Location = new System.Drawing.Point(236, 42);
            this.radioButton_EditEmployee_Bartender.Name = "radioButton_EditEmployee_Bartender";
            this.radioButton_EditEmployee_Bartender.Size = new System.Drawing.Size(171, 35);
            this.radioButton_EditEmployee_Bartender.TabIndex = 8;
            this.radioButton_EditEmployee_Bartender.Text = "Barman";
            this.radioButton_EditEmployee_Bartender.UseVisualStyleBackColor = true;
            // 
            // radioButton_EditEmployee_Manager
            // 
            this.radioButton_EditEmployee_Manager.AutoSize = true;
            this.radioButton_EditEmployee_Manager.Location = new System.Drawing.Point(236, 99);
            this.radioButton_EditEmployee_Manager.Name = "radioButton_EditEmployee_Manager";
            this.radioButton_EditEmployee_Manager.Size = new System.Drawing.Size(144, 41);
            this.radioButton_EditEmployee_Manager.TabIndex = 9;
            this.radioButton_EditEmployee_Manager.Text = "Manager";
            this.radioButton_EditEmployee_Manager.UseVisualStyleBackColor = true;
            // 
            // radioButton_EditEmployee_Waiter
            // 
            this.radioButton_EditEmployee_Waiter.AutoSize = true;
            this.radioButton_EditEmployee_Waiter.Location = new System.Drawing.Point(7, 42);
            this.radioButton_EditEmployee_Waiter.Name = "radioButton_EditEmployee_Waiter";
            this.radioButton_EditEmployee_Waiter.Size = new System.Drawing.Size(115, 41);
            this.radioButton_EditEmployee_Waiter.TabIndex = 6;
            this.radioButton_EditEmployee_Waiter.Text = "Waiter";
            this.radioButton_EditEmployee_Waiter.UseVisualStyleBackColor = true;
            // 
            // radioButton_EditEmployee_Chef
            // 
            this.radioButton_EditEmployee_Chef.AutoSize = true;
            this.radioButton_EditEmployee_Chef.Location = new System.Drawing.Point(7, 99);
            this.radioButton_EditEmployee_Chef.Name = "radioButton_EditEmployee_Chef";
            this.radioButton_EditEmployee_Chef.Size = new System.Drawing.Size(92, 41);
            this.radioButton_EditEmployee_Chef.TabIndex = 7;
            this.radioButton_EditEmployee_Chef.Text = "Chef";
            this.radioButton_EditEmployee_Chef.UseVisualStyleBackColor = true;
            // 
            // label_EditEmployee_Password
            // 
            this.label_EditEmployee_Password.AutoSize = true;
            this.label_EditEmployee_Password.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_EditEmployee_Password.Location = new System.Drawing.Point(499, 299);
            this.label_EditEmployee_Password.Name = "label_EditEmployee_Password";
            this.label_EditEmployee_Password.Size = new System.Drawing.Size(128, 37);
            this.label_EditEmployee_Password.TabIndex = 15;
            this.label_EditEmployee_Password.Text = "Password";
            // 
            // label_EditEmploye_Username
            // 
            this.label_EditEmploye_Username.AutoSize = true;
            this.label_EditEmploye_Username.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_EditEmploye_Username.Location = new System.Drawing.Point(499, 246);
            this.label_EditEmploye_Username.Name = "label_EditEmploye_Username";
            this.label_EditEmploye_Username.Size = new System.Drawing.Size(136, 37);
            this.label_EditEmploye_Username.TabIndex = 14;
            this.label_EditEmploye_Username.Text = "Username";
            // 
            // label_EditEmployee_LastName
            // 
            this.label_EditEmployee_LastName.AutoSize = true;
            this.label_EditEmployee_LastName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_EditEmployee_LastName.Location = new System.Drawing.Point(499, 190);
            this.label_EditEmployee_LastName.Name = "label_EditEmployee_LastName";
            this.label_EditEmployee_LastName.Size = new System.Drawing.Size(142, 37);
            this.label_EditEmployee_LastName.TabIndex = 13;
            this.label_EditEmployee_LastName.Text = "Last Name";
            // 
            // label_EditEmployee_FirstName
            // 
            this.label_EditEmployee_FirstName.AutoSize = true;
            this.label_EditEmployee_FirstName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_EditEmployee_FirstName.Location = new System.Drawing.Point(499, 131);
            this.label_EditEmployee_FirstName.Name = "label_EditEmployee_FirstName";
            this.label_EditEmployee_FirstName.Size = new System.Drawing.Size(144, 37);
            this.label_EditEmployee_FirstName.TabIndex = 12;
            this.label_EditEmployee_FirstName.Text = "First Name";
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 1055);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_EditEmployee);
            this.Controls.Add(this.textBox_EditEmployee_Password);
            this.Controls.Add(this.textBox_EditEmployee_Username);
            this.Controls.Add(this.textBox_EditEmployee_LastName);
            this.Controls.Add(this.textBox_EditEmployee_FirstName);
            this.Controls.Add(this.groupBox_EditEmployee_Occupation);
            this.Controls.Add(this.label_EditEmployee_Password);
            this.Controls.Add(this.label_EditEmploye_Username);
            this.Controls.Add(this.label_EditEmployee_LastName);
            this.Controls.Add(this.label_EditEmployee_FirstName);
            this.Name = "EditEmployee";
            this.Text = "EditEmployee";
            this.groupBox_EditEmployee_Occupation.ResumeLayout(false);
            this.groupBox_EditEmployee_Occupation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_EditEmployee;
        private System.Windows.Forms.TextBox textBox_EditEmployee_Password;
        private System.Windows.Forms.TextBox textBox_EditEmployee_Username;
        private System.Windows.Forms.TextBox textBox_EditEmployee_LastName;
        private System.Windows.Forms.TextBox textBox_EditEmployee_FirstName;
        private System.Windows.Forms.GroupBox groupBox_EditEmployee_Occupation;
        private System.Windows.Forms.RadioButton radioButton_EditEmployee_Bartender;
        private System.Windows.Forms.RadioButton radioButton_EditEmployee_Manager;
        private System.Windows.Forms.RadioButton radioButton_EditEmployee_Waiter;
        private System.Windows.Forms.RadioButton radioButton_EditEmployee_Chef;
        private System.Windows.Forms.Label label_EditEmployee_Password;
        private System.Windows.Forms.Label label_EditEmploye_Username;
        private System.Windows.Forms.Label label_EditEmployee_LastName;
        private System.Windows.Forms.Label label_EditEmployee_FirstName;
    }
}