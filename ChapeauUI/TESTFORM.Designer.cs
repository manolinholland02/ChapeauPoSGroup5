
namespace ChapeauUI
{
    partial class TESTFORM
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
            this.testlistview = new System.Windows.Forms.ListView();
            this.TestformID = new System.Windows.Forms.ColumnHeader();
            this.TestFormName = new System.Windows.Forms.ColumnHeader();
            this.testformbtn = new System.Windows.Forms.Button();
            this.TestFormComment = new System.Windows.Forms.ColumnHeader();
            this.TestOrderQuantity = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // testlistview
            // 
            this.testlistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TestformID,
            this.TestOrderQuantity,
            this.TestFormName,
            this.TestFormComment});
            this.testlistview.HideSelection = false;
            this.testlistview.Location = new System.Drawing.Point(149, 75);
            this.testlistview.Name = "testlistview";
            this.testlistview.Size = new System.Drawing.Size(473, 235);
            this.testlistview.TabIndex = 0;
            this.testlistview.UseCompatibleStateImageBehavior = false;
            this.testlistview.View = System.Windows.Forms.View.Details;
            // 
            // TestformID
            // 
            this.TestformID.Text = "ID";
            this.TestformID.Width = 0;
            // 
            // TestFormName
            // 
            this.TestFormName.DisplayIndex = 1;
            this.TestFormName.Text = "Name";
            this.TestFormName.Width = 100;
            // 
            // testformbtn
            // 
            this.testformbtn.Location = new System.Drawing.Point(633, 364);
            this.testformbtn.Name = "testformbtn";
            this.testformbtn.Size = new System.Drawing.Size(152, 74);
            this.testformbtn.TabIndex = 1;
            this.testformbtn.Text = "test";
            this.testformbtn.UseVisualStyleBackColor = true;
            // 
            // TestFormComment
            // 
            this.TestFormComment.DisplayIndex = 2;
            this.TestFormComment.Text = "Comment";
            // 
            // TestOrderQuantity
            // 
            this.TestOrderQuantity.DisplayIndex = 3;
            this.TestOrderQuantity.Text = "Quantity";
            // 
            // TESTFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.testformbtn);
            this.Controls.Add(this.testlistview);
            this.Name = "TESTFORM";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView testlistview;
        private System.Windows.Forms.Button testformbtn;
        private System.Windows.Forms.ColumnHeader TestformID;
        private System.Windows.Forms.ColumnHeader TestFormName;
        private System.Windows.Forms.ColumnHeader TestOrderQuantity;
        private System.Windows.Forms.ColumnHeader TestFormComment;
    }
}