﻿
namespace ChapeauUI
{
    partial class LunchMenuForm
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
            this.OrderOverviewLunchbtn = new System.Windows.Forms.Button();
            this.LunchStartersListView = new System.Windows.Forms.ListView();
            this.starterId = new System.Windows.Forms.ColumnHeader();
            this.starterName = new System.Windows.Forms.ColumnHeader();
            this.LunchMainListView = new System.Windows.Forms.ListView();
            this.LunchDessertListView = new System.Windows.Forms.ListView();
            this.backbtnLunch = new System.Windows.Forms.Button();
            this.AddbtnLunch = new System.Windows.Forms.Button();
            this.LunchCommentSection = new System.Windows.Forms.TextBox();
            this.mainId = new System.Windows.Forms.ColumnHeader();
            this.mainName = new System.Windows.Forms.ColumnHeader();
            this.desertId = new System.Windows.Forms.ColumnHeader();
            this.desertName = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // OrderOverviewLunchbtn
            // 
            this.OrderOverviewLunchbtn.Location = new System.Drawing.Point(410, 29);
            this.OrderOverviewLunchbtn.Name = "OrderOverviewLunchbtn";
            this.OrderOverviewLunchbtn.Size = new System.Drawing.Size(115, 82);
            this.OrderOverviewLunchbtn.TabIndex = 0;
            this.OrderOverviewLunchbtn.Text = "See Table\'s Orders";
            this.OrderOverviewLunchbtn.UseVisualStyleBackColor = true;
            // 
            // LunchStartersListView
            // 
            this.LunchStartersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.starterId,
            this.starterName});
            this.LunchStartersListView.HideSelection = false;
            this.LunchStartersListView.Location = new System.Drawing.Point(12, 112);
            this.LunchStartersListView.Name = "LunchStartersListView";
            this.LunchStartersListView.Size = new System.Drawing.Size(265, 145);
            this.LunchStartersListView.TabIndex = 1;
            this.LunchStartersListView.UseCompatibleStateImageBehavior = false;
            this.LunchStartersListView.View = System.Windows.Forms.View.Details;
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
            // LunchMainListView
            // 
            this.LunchMainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mainId,
            this.mainName});
            this.LunchMainListView.HideSelection = false;
            this.LunchMainListView.Location = new System.Drawing.Point(12, 263);
            this.LunchMainListView.Name = "LunchMainListView";
            this.LunchMainListView.Size = new System.Drawing.Size(265, 145);
            this.LunchMainListView.TabIndex = 2;
            this.LunchMainListView.UseCompatibleStateImageBehavior = false;
            this.LunchMainListView.View = System.Windows.Forms.View.Details;
            // 
            // LunchDessertListView
            // 
            this.LunchDessertListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.desertId,
            this.desertName});
            this.LunchDessertListView.HideSelection = false;
            this.LunchDessertListView.Location = new System.Drawing.Point(12, 414);
            this.LunchDessertListView.Name = "LunchDessertListView";
            this.LunchDessertListView.Size = new System.Drawing.Size(265, 145);
            this.LunchDessertListView.TabIndex = 3;
            this.LunchDessertListView.UseCompatibleStateImageBehavior = false;
            this.LunchDessertListView.View = System.Windows.Forms.View.Details;
            // 
            // backbtnLunch
            // 
            this.backbtnLunch.Location = new System.Drawing.Point(12, 663);
            this.backbtnLunch.Name = "backbtnLunch";
            this.backbtnLunch.Size = new System.Drawing.Size(200, 77);
            this.backbtnLunch.TabIndex = 4;
            this.backbtnLunch.Text = "Back";
            this.backbtnLunch.UseVisualStyleBackColor = true;
            this.backbtnLunch.Click += new System.EventHandler(this.backbtnLunch_Click);
            // 
            // AddbtnLunch
            // 
            this.AddbtnLunch.Location = new System.Drawing.Point(325, 663);
            this.AddbtnLunch.Name = "AddbtnLunch";
            this.AddbtnLunch.Size = new System.Drawing.Size(200, 77);
            this.AddbtnLunch.TabIndex = 5;
            this.AddbtnLunch.Text = "Add";
            this.AddbtnLunch.UseVisualStyleBackColor = true;
            this.AddbtnLunch.Click += new System.EventHandler(this.AddbtnLunch_Click);
            // 
            // LunchCommentSection
            // 
            this.LunchCommentSection.Location = new System.Drawing.Point(12, 578);
            this.LunchCommentSection.Name = "LunchCommentSection";
            this.LunchCommentSection.Size = new System.Drawing.Size(513, 27);
            this.LunchCommentSection.TabIndex = 6;
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
            // desertId
            // 
            this.desertId.Text = "ID";
            this.desertId.Width = 0;
            // 
            // desertName
            // 
            this.desertName.Text = "Name";
            this.desertName.Width = 250;
            // 
            // LunchMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 752);
            this.Controls.Add(this.LunchCommentSection);
            this.Controls.Add(this.AddbtnLunch);
            this.Controls.Add(this.backbtnLunch);
            this.Controls.Add(this.LunchDessertListView);
            this.Controls.Add(this.LunchMainListView);
            this.Controls.Add(this.LunchStartersListView);
            this.Controls.Add(this.OrderOverviewLunchbtn);
            this.Name = "LunchMenuForm";
            this.Text = "Lunch Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OrderOverviewLunchbtn;
        private System.Windows.Forms.ListView LunchStartersListView;
        private System.Windows.Forms.ListView LunchMainListView;
        private System.Windows.Forms.ListView LunchDessertListView;
        private System.Windows.Forms.Button backbtnLunch;
        private System.Windows.Forms.Button AddbtnLunch;
        private System.Windows.Forms.TextBox LunchCommentSection;
        private System.Windows.Forms.ColumnHeader starterId;
        private System.Windows.Forms.ColumnHeader starterName;
        private System.Windows.Forms.ColumnHeader mainId;
        private System.Windows.Forms.ColumnHeader mainName;
        private System.Windows.Forms.ColumnHeader desertId;
        private System.Windows.Forms.ColumnHeader desertName;
    }
}