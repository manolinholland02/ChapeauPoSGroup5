
namespace ChapeauUI
{
    partial class DinnerMenuForm
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
            this.DinnerDessertsListView = new System.Windows.Forms.ListView();
            this.DinnerStartersListView = new System.Windows.Forms.ListView();
            this.DinnerMainListView = new System.Windows.Forms.ListView();
            this.DinnerEntremetsListView = new System.Windows.Forms.ListView();
            this.BackbtnDinner = new System.Windows.Forms.Button();
            this.AddbtnDinner = new System.Windows.Forms.Button();
            this.DinnerCommentSection = new System.Windows.Forms.TextBox();
            this.DinnerTableOverview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DinnerDessertsListView
            // 
            this.DinnerDessertsListView.HideSelection = false;
            this.DinnerDessertsListView.Location = new System.Drawing.Point(274, 338);
            this.DinnerDessertsListView.Name = "DinnerDessertsListView";
            this.DinnerDessertsListView.Size = new System.Drawing.Size(265, 145);
            this.DinnerDessertsListView.TabIndex = 0;
            this.DinnerDessertsListView.UseCompatibleStateImageBehavior = false;
            this.DinnerDessertsListView.View = System.Windows.Forms.View.Details;
            // 
            // DinnerStartersListView
            // 
            this.DinnerStartersListView.HideSelection = false;
            this.DinnerStartersListView.Location = new System.Drawing.Point(3, 187);
            this.DinnerStartersListView.Name = "DinnerStartersListView";
            this.DinnerStartersListView.Size = new System.Drawing.Size(265, 145);
            this.DinnerStartersListView.TabIndex = 1;
            this.DinnerStartersListView.UseCompatibleStateImageBehavior = false;
            this.DinnerStartersListView.View = System.Windows.Forms.View.Details;
            // 
            // DinnerMainListView
            // 
            this.DinnerMainListView.HideSelection = false;
            this.DinnerMainListView.Location = new System.Drawing.Point(3, 338);
            this.DinnerMainListView.Name = "DinnerMainListView";
            this.DinnerMainListView.Size = new System.Drawing.Size(265, 145);
            this.DinnerMainListView.TabIndex = 2;
            this.DinnerMainListView.UseCompatibleStateImageBehavior = false;
            this.DinnerMainListView.View = System.Windows.Forms.View.Details;
            this.DinnerMainListView.SelectedIndexChanged += new System.EventHandler(this.listView3_SelectedIndexChanged);
            // 
            // DinnerEntremetsListView
            // 
            this.DinnerEntremetsListView.HideSelection = false;
            this.DinnerEntremetsListView.Location = new System.Drawing.Point(274, 187);
            this.DinnerEntremetsListView.Name = "DinnerEntremetsListView";
            this.DinnerEntremetsListView.Size = new System.Drawing.Size(265, 145);
            this.DinnerEntremetsListView.TabIndex = 3;
            this.DinnerEntremetsListView.UseCompatibleStateImageBehavior = false;
            this.DinnerEntremetsListView.View = System.Windows.Forms.View.Details;
            // 
            // BackbtnDinner
            // 
            this.BackbtnDinner.Location = new System.Drawing.Point(12, 663);
            this.BackbtnDinner.Name = "BackbtnDinner";
            this.BackbtnDinner.Size = new System.Drawing.Size(200, 77);
            this.BackbtnDinner.TabIndex = 4;
            this.BackbtnDinner.Text = "Back";
            this.BackbtnDinner.UseVisualStyleBackColor = true;
            this.BackbtnDinner.Click += new System.EventHandler(this.BackbtnDinner_Click);
            // 
            // AddbtnDinner
            // 
            this.AddbtnDinner.Location = new System.Drawing.Point(325, 663);
            this.AddbtnDinner.Name = "AddbtnDinner";
            this.AddbtnDinner.Size = new System.Drawing.Size(200, 77);
            this.AddbtnDinner.TabIndex = 5;
            this.AddbtnDinner.Text = "Add";
            this.AddbtnDinner.UseVisualStyleBackColor = true;
            this.AddbtnDinner.Click += new System.EventHandler(this.AddbtnDinner_Click);
            // 
            // DinnerCommentSection
            // 
            this.DinnerCommentSection.Location = new System.Drawing.Point(12, 600);
            this.DinnerCommentSection.Name = "DinnerCommentSection";
            this.DinnerCommentSection.Size = new System.Drawing.Size(513, 27);
            this.DinnerCommentSection.TabIndex = 6;
            // 
            // DinnerTableOverview
            // 
            this.DinnerTableOverview.Location = new System.Drawing.Point(410, 29);
            this.DinnerTableOverview.Name = "DinnerTableOverview";
            this.DinnerTableOverview.Size = new System.Drawing.Size(115, 82);
            this.DinnerTableOverview.TabIndex = 7;
            this.DinnerTableOverview.Text = "See Table\'s Order";
            this.DinnerTableOverview.UseVisualStyleBackColor = true;
            // 
            // DinnerMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 752);
            this.Controls.Add(this.DinnerTableOverview);
            this.Controls.Add(this.DinnerCommentSection);
            this.Controls.Add(this.AddbtnDinner);
            this.Controls.Add(this.BackbtnDinner);
            this.Controls.Add(this.DinnerEntremetsListView);
            this.Controls.Add(this.DinnerMainListView);
            this.Controls.Add(this.DinnerStartersListView);
            this.Controls.Add(this.DinnerDessertsListView);
            this.Name = "DinnerMenuForm";
            this.Text = "DinnerMenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView DinnerDessertsListView;
        private System.Windows.Forms.ListView DinnerStartersListView;
        private System.Windows.Forms.ListView DinnerMainListView;
        private System.Windows.Forms.ListView DinnerEntremetsListView;
        private System.Windows.Forms.Button BackbtnDinner;
        private System.Windows.Forms.Button AddbtnDinner;
        private System.Windows.Forms.TextBox DinnerCommentSection;
        private System.Windows.Forms.Button DinnerTableOverview;
    }
}