
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
            this.starterId = new System.Windows.Forms.ColumnHeader();
            this.starterName = new System.Windows.Forms.ColumnHeader();
            this.DinnerMainListView = new System.Windows.Forms.ListView();
            this.DinnerEntremetsListView = new System.Windows.Forms.ListView();
            this.BackbtnDinner = new System.Windows.Forms.Button();
            this.AddbtnDinner = new System.Windows.Forms.Button();
            this.DinnerCommentSection = new System.Windows.Forms.TextBox();
            this.DinnerTableOverview = new System.Windows.Forms.Button();
            this.entremetId = new System.Windows.Forms.ColumnHeader();
            this.entremetName = new System.Windows.Forms.ColumnHeader();
            this.mainId = new System.Windows.Forms.ColumnHeader();
            this.mainName = new System.Windows.Forms.ColumnHeader();
            this.deserId = new System.Windows.Forms.ColumnHeader();
            this.desertName = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // DinnerDessertsListView
            // 
            this.DinnerDessertsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.deserId,
            this.desertName});
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
            this.DinnerStartersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.starterId,
            this.starterName});
            this.DinnerStartersListView.HideSelection = false;
            this.DinnerStartersListView.Location = new System.Drawing.Point(3, 187);
            this.DinnerStartersListView.Name = "DinnerStartersListView";
            this.DinnerStartersListView.Size = new System.Drawing.Size(265, 145);
            this.DinnerStartersListView.TabIndex = 1;
            this.DinnerStartersListView.UseCompatibleStateImageBehavior = false;
            this.DinnerStartersListView.View = System.Windows.Forms.View.Details;
            // 
            // starterId
            // 
            this.starterId.Text = "ID";
            this.starterId.Width = 0;
            // 
            // starterName
            // 
            this.starterName.Text = "Name";
            this.starterName.Width = 250;
            // 
            // DinnerMainListView
            // 
            this.DinnerMainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mainId,
            this.mainName});
            this.DinnerMainListView.HideSelection = false;
            this.DinnerMainListView.Location = new System.Drawing.Point(3, 338);
            this.DinnerMainListView.Name = "DinnerMainListView";
            this.DinnerMainListView.Size = new System.Drawing.Size(265, 145);
            this.DinnerMainListView.TabIndex = 2;
            this.DinnerMainListView.UseCompatibleStateImageBehavior = false;
            this.DinnerMainListView.View = System.Windows.Forms.View.Details;
            // 
            // DinnerEntremetsListView
            // 
            this.DinnerEntremetsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.entremetId,
            this.entremetName});
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
            // entremetId
            // 
            this.entremetId.Text = "ID";
            this.entremetId.Width = 0;
            // 
            // entremetName
            // 
            this.entremetName.Text = "Name";
            this.entremetName.Width = 250;
            // 
            // mainId
            // 
            this.mainId.Text = "ID";
            this.mainId.Width = 0;
            // 
            // mainName
            // 
            this.mainName.Text = "Name";
            this.mainName.Width = 250;
            // 
            // deserId
            // 
            this.deserId.Text = "ID";
            this.deserId.Width = 0;
            // 
            // desertName
            // 
            this.desertName.Text = "Name";
            this.desertName.Width = 250;
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
        private System.Windows.Forms.ColumnHeader starterId;
        private System.Windows.Forms.ColumnHeader starterName;
        private System.Windows.Forms.ColumnHeader deserId;
        private System.Windows.Forms.ColumnHeader desertName;
        private System.Windows.Forms.ColumnHeader mainId;
        private System.Windows.Forms.ColumnHeader mainName;
        private System.Windows.Forms.ColumnHeader entremetId;
        private System.Windows.Forms.ColumnHeader entremetName;
    }
}