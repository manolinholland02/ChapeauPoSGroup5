
namespace ChapeauUI
{
    partial class ManagerConformation
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
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_Proceed = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label_Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(88, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 98);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter manager password to proceed";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Password.Location = new System.Drawing.Point(133, 148);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(229, 43);
            this.textBox_Password.TabIndex = 1;
            // 
            // button_Proceed
            // 
            this.button_Proceed.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Proceed.Location = new System.Drawing.Point(41, 240);
            this.button_Proceed.Name = "button_Proceed";
            this.button_Proceed.Size = new System.Drawing.Size(158, 54);
            this.button_Proceed.TabIndex = 2;
            this.button_Proceed.Text = "OK";
            this.button_Proceed.UseVisualStyleBackColor = true;
            this.button_Proceed.Click += new System.EventHandler(this.button_Proceed_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Cancel.Location = new System.Drawing.Point(282, 240);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(158, 54);
            this.button_Cancel.TabIndex = 3;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label_Error
            // 
            this.label_Error.AutoSize = true;
            this.label_Error.ForeColor = System.Drawing.Color.Red;
            this.label_Error.Location = new System.Drawing.Point(169, 194);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(119, 20);
            this.label_Error.TabIndex = 4;
            this.label_Error.Text = "Wrong Password";
            // 
            // ManagerConformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 328);
            this.Controls.Add(this.label_Error);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Proceed);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label1);
            this.Name = "ManagerConformation";
            this.Text = "ManagerConformation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button_Proceed;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label_Error;
    }
}