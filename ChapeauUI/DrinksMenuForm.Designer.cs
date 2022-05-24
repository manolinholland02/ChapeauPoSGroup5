
namespace ChapeauUI
{
    partial class DrinksMenuForm
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
            this.SoftDrinksListView = new System.Windows.Forms.ListView();
            this.BeersListView = new System.Windows.Forms.ListView();
            this.WineListView = new System.Windows.Forms.ListView();
            this.SpiritsListView = new System.Windows.Forms.ListView();
            this.CoffeeTeaListView = new System.Windows.Forms.ListView();
            this.BackDrinksbtn = new System.Windows.Forms.Button();
            this.AddDrinksbtn = new System.Windows.Forms.Button();
            this.DrinksCommentSection = new System.Windows.Forms.TextBox();
            this.DrinksTableOverview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SoftDrinksListView
            // 
            this.SoftDrinksListView.HideSelection = false;
            this.SoftDrinksListView.Location = new System.Drawing.Point(1, 117);
            this.SoftDrinksListView.Name = "SoftDrinksListView";
            this.SoftDrinksListView.Size = new System.Drawing.Size(265, 145);
            this.SoftDrinksListView.TabIndex = 0;
            this.SoftDrinksListView.UseCompatibleStateImageBehavior = false;
            this.SoftDrinksListView.View = System.Windows.Forms.View.Details;
            // 
            // BeersListView
            // 
            this.BeersListView.HideSelection = false;
            this.BeersListView.Location = new System.Drawing.Point(272, 117);
            this.BeersListView.Name = "BeersListView";
            this.BeersListView.Size = new System.Drawing.Size(265, 145);
            this.BeersListView.TabIndex = 1;
            this.BeersListView.UseCompatibleStateImageBehavior = false;
            this.BeersListView.View = System.Windows.Forms.View.Details;
            // 
            // WineListView
            // 
            this.WineListView.HideSelection = false;
            this.WineListView.Location = new System.Drawing.Point(1, 268);
            this.WineListView.Name = "WineListView";
            this.WineListView.Size = new System.Drawing.Size(265, 145);
            this.WineListView.TabIndex = 2;
            this.WineListView.UseCompatibleStateImageBehavior = false;
            this.WineListView.View = System.Windows.Forms.View.Details;
            // 
            // SpiritsListView
            // 
            this.SpiritsListView.HideSelection = false;
            this.SpiritsListView.Location = new System.Drawing.Point(272, 268);
            this.SpiritsListView.Name = "SpiritsListView";
            this.SpiritsListView.Size = new System.Drawing.Size(265, 145);
            this.SpiritsListView.TabIndex = 3;
            this.SpiritsListView.UseCompatibleStateImageBehavior = false;
            this.SpiritsListView.View = System.Windows.Forms.View.Details;
            // 
            // CoffeeTeaListView
            // 
            this.CoffeeTeaListView.HideSelection = false;
            this.CoffeeTeaListView.Location = new System.Drawing.Point(135, 419);
            this.CoffeeTeaListView.Name = "CoffeeTeaListView";
            this.CoffeeTeaListView.Size = new System.Drawing.Size(265, 145);
            this.CoffeeTeaListView.TabIndex = 4;
            this.CoffeeTeaListView.UseCompatibleStateImageBehavior = false;
            this.CoffeeTeaListView.View = System.Windows.Forms.View.Details;
            // 
            // BackDrinksbtn
            // 
            this.BackDrinksbtn.Location = new System.Drawing.Point(12, 666);
            this.BackDrinksbtn.Name = "BackDrinksbtn";
            this.BackDrinksbtn.Size = new System.Drawing.Size(200, 77);
            this.BackDrinksbtn.TabIndex = 5;
            this.BackDrinksbtn.Text = "Back";
            this.BackDrinksbtn.UseVisualStyleBackColor = true;
            this.BackDrinksbtn.Click += new System.EventHandler(this.BackDrinksbtn_Click);
            // 
            // AddDrinksbtn
            // 
            this.AddDrinksbtn.Location = new System.Drawing.Point(325, 666);
            this.AddDrinksbtn.Name = "AddDrinksbtn";
            this.AddDrinksbtn.Size = new System.Drawing.Size(200, 77);
            this.AddDrinksbtn.TabIndex = 6;
            this.AddDrinksbtn.Text = "Add";
            this.AddDrinksbtn.UseVisualStyleBackColor = true;
            this.AddDrinksbtn.Click += new System.EventHandler(this.AddDrinksbtn_Click);
            // 
            // DrinksCommentSection
            // 
            this.DrinksCommentSection.Location = new System.Drawing.Point(12, 611);
            this.DrinksCommentSection.Name = "DrinksCommentSection";
            this.DrinksCommentSection.Size = new System.Drawing.Size(513, 27);
            this.DrinksCommentSection.TabIndex = 7;
            // 
            // DrinksTableOverview
            // 
            this.DrinksTableOverview.Location = new System.Drawing.Point(410, 29);
            this.DrinksTableOverview.Name = "DrinksTableOverview";
            this.DrinksTableOverview.Size = new System.Drawing.Size(115, 82);
            this.DrinksTableOverview.TabIndex = 8;
            this.DrinksTableOverview.Text = "See Table\'s Orders";
            this.DrinksTableOverview.UseVisualStyleBackColor = true;
            // 
            // DrinksMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 752);
            this.Controls.Add(this.DrinksTableOverview);
            this.Controls.Add(this.DrinksCommentSection);
            this.Controls.Add(this.AddDrinksbtn);
            this.Controls.Add(this.BackDrinksbtn);
            this.Controls.Add(this.CoffeeTeaListView);
            this.Controls.Add(this.SpiritsListView);
            this.Controls.Add(this.WineListView);
            this.Controls.Add(this.BeersListView);
            this.Controls.Add(this.SoftDrinksListView);
            this.Name = "DrinksMenuForm";
            this.Text = "DrinksMenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView SoftDrinksListView;
        private System.Windows.Forms.ListView BeersListView;
        private System.Windows.Forms.ListView WineListView;
        private System.Windows.Forms.ListView SpiritsListView;
        private System.Windows.Forms.ListView CoffeeTeaListView;
        private System.Windows.Forms.Button BackDrinksbtn;
        private System.Windows.Forms.Button AddDrinksbtn;
        private System.Windows.Forms.TextBox DrinksCommentSection;
        private System.Windows.Forms.Button DrinksTableOverview;
    }
}