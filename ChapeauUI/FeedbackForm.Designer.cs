
namespace ChapeauUI
{
    partial class FeedbackForm
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
            this.feedback_txt = new System.Windows.Forms.TextBox();
            this.enterFeedback_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // feedback_txt
            // 
            this.feedback_txt.Location = new System.Drawing.Point(66, 142);
            this.feedback_txt.Multiline = true;
            this.feedback_txt.Name = "feedback_txt";
            this.feedback_txt.Size = new System.Drawing.Size(400, 157);
            this.feedback_txt.TabIndex = 0;
            // 
            // enterFeedback_btn
            // 
            this.enterFeedback_btn.Location = new System.Drawing.Point(215, 322);
            this.enterFeedback_btn.Name = "enterFeedback_btn";
            this.enterFeedback_btn.Size = new System.Drawing.Size(94, 29);
            this.enterFeedback_btn.TabIndex = 1;
            this.enterFeedback_btn.Text = "Enter";
            this.enterFeedback_btn.UseVisualStyleBackColor = true;
            this.enterFeedback_btn.Click += new System.EventHandler(this.enterFeedback_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Feedback here:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Feedback";
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 752);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterFeedback_btn);
            this.Controls.Add(this.feedback_txt);
            this.Name = "FeedbackForm";
            this.Text = "Feedback";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox feedback_txt;
        private System.Windows.Forms.Button enterFeedback_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}