
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
            this.DrinkSoftDrinkID = new System.Windows.Forms.ColumnHeader();
            this.softdrinkId = new System.Windows.Forms.ColumnHeader();
            this.softdrinkName = new System.Windows.Forms.ColumnHeader();
            this.BeersListView = new System.Windows.Forms.ListView();
            this.DrinksBeerID = new System.Windows.Forms.ColumnHeader();
            this.beerId = new System.Windows.Forms.ColumnHeader();
            this.beerName = new System.Windows.Forms.ColumnHeader();
            this.WineListView = new System.Windows.Forms.ListView();
            this.DrinksWineID = new System.Windows.Forms.ColumnHeader();
            this.wineId = new System.Windows.Forms.ColumnHeader();
            this.wineName = new System.Windows.Forms.ColumnHeader();
            this.SpiritsListView = new System.Windows.Forms.ListView();
            this.DrinksSpiritID = new System.Windows.Forms.ColumnHeader();
            this.spiritId = new System.Windows.Forms.ColumnHeader();
            this.spiritName = new System.Windows.Forms.ColumnHeader();
            this.CoffeeTeaListView = new System.Windows.Forms.ListView();
            this.DrinksCoffeeTeaID = new System.Windows.Forms.ColumnHeader();
            this.caffeinatedId = new System.Windows.Forms.ColumnHeader();
            this.caffeinatedName = new System.Windows.Forms.ColumnHeader();
            this.BackDrinksbtn = new System.Windows.Forms.Button();
            this.AddDrinksbtn = new System.Windows.Forms.Button();
            this.DrinksCommentSection = new System.Windows.Forms.TextBox();
            this.DrinksTableOverview = new System.Windows.Forms.Button();
            this.orderCountlbl = new System.Windows.Forms.Label();
            this.EmployeeNamelbl = new System.Windows.Forms.Label();
            this.tableNumberlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SoftDrinksListView
            // 
            this.SoftDrinksListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DrinkSoftDrinkID,
            this.softdrinkId,
            this.softdrinkName});
            this.SoftDrinksListView.HideSelection = false;
            this.SoftDrinksListView.Location = new System.Drawing.Point(1, 117);
            this.SoftDrinksListView.Name = "SoftDrinksListView";
            this.SoftDrinksListView.Size = new System.Drawing.Size(265, 301);
            this.SoftDrinksListView.TabIndex = 0;
            this.SoftDrinksListView.UseCompatibleStateImageBehavior = false;
            this.SoftDrinksListView.View = System.Windows.Forms.View.Details;
            this.SoftDrinksListView.SelectedIndexChanged += new System.EventHandler(this.SoftDrinksListView_SelectedIndexChanged_1);
            // 
            // DrinkSoftDrinkID
            // 
            this.DrinkSoftDrinkID.Width = 0;
            // 
            // softdrinkId
            // 
            this.softdrinkId.Text = "ID";
            this.softdrinkId.Width = 0;
            // 
            // softdrinkName
            // 
            this.softdrinkName.Text = "Soft Drinks";
            this.softdrinkName.Width = 250;
            // 
            // BeersListView
            // 
            this.BeersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DrinksBeerID,
            this.beerId,
            this.beerName});
            this.BeersListView.HideSelection = false;
            this.BeersListView.Location = new System.Drawing.Point(272, 117);
            this.BeersListView.Name = "BeersListView";
            this.BeersListView.Size = new System.Drawing.Size(265, 180);
            this.BeersListView.TabIndex = 1;
            this.BeersListView.UseCompatibleStateImageBehavior = false;
            this.BeersListView.View = System.Windows.Forms.View.Details;
            this.BeersListView.SelectedIndexChanged += new System.EventHandler(this.BeersListView_SelectedIndexChanged);
            // 
            // DrinksBeerID
            // 
            this.DrinksBeerID.Width = 0;
            // 
            // beerId
            // 
            this.beerId.Text = "ID";
            this.beerId.Width = 0;
            // 
            // beerName
            // 
            this.beerName.Text = "Spirits";
            this.beerName.Width = 250;
            // 
            // WineListView
            // 
            this.WineListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DrinksWineID,
            this.wineId,
            this.wineName});
            this.WineListView.HideSelection = false;
            this.WineListView.Location = new System.Drawing.Point(1, 424);
            this.WineListView.Name = "WineListView";
            this.WineListView.Size = new System.Drawing.Size(265, 181);
            this.WineListView.TabIndex = 2;
            this.WineListView.UseCompatibleStateImageBehavior = false;
            this.WineListView.View = System.Windows.Forms.View.Details;
            this.WineListView.SelectedIndexChanged += new System.EventHandler(this.WineListView_SelectedIndexChanged_1);
            // 
            // DrinksWineID
            // 
            this.DrinksWineID.Width = 0;
            // 
            // wineId
            // 
            this.wineId.Text = "ID";
            this.wineId.Width = 0;
            // 
            // wineName
            // 
            this.wineName.Text = "Wines";
            this.wineName.Width = 250;
            // 
            // SpiritsListView
            // 
            this.SpiritsListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.SpiritsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DrinksSpiritID,
            this.spiritId,
            this.spiritName});
            this.SpiritsListView.HideSelection = false;
            this.SpiritsListView.Location = new System.Drawing.Point(272, 303);
            this.SpiritsListView.Name = "SpiritsListView";
            this.SpiritsListView.Size = new System.Drawing.Size(265, 150);
            this.SpiritsListView.TabIndex = 3;
            this.SpiritsListView.UseCompatibleStateImageBehavior = false;
            this.SpiritsListView.View = System.Windows.Forms.View.Details;
            this.SpiritsListView.SelectedIndexChanged += new System.EventHandler(this.SpiritsListView_SelectedIndexChanged);
            // 
            // DrinksSpiritID
            // 
            this.DrinksSpiritID.Width = 0;
            // 
            // spiritId
            // 
            this.spiritId.Text = "ID";
            this.spiritId.Width = 0;
            // 
            // spiritName
            // 
            this.spiritName.Text = "Coffee and Tea";
            this.spiritName.Width = 250;
            // 
            // CoffeeTeaListView
            // 
            this.CoffeeTeaListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DrinksCoffeeTeaID,
            this.caffeinatedId,
            this.caffeinatedName});
            this.CoffeeTeaListView.HideSelection = false;
            this.CoffeeTeaListView.Location = new System.Drawing.Point(272, 459);
            this.CoffeeTeaListView.Name = "CoffeeTeaListView";
            this.CoffeeTeaListView.Size = new System.Drawing.Size(265, 146);
            this.CoffeeTeaListView.TabIndex = 4;
            this.CoffeeTeaListView.UseCompatibleStateImageBehavior = false;
            this.CoffeeTeaListView.View = System.Windows.Forms.View.Details;
            this.CoffeeTeaListView.SelectedIndexChanged += new System.EventHandler(this.CoffeeTeaListView_SelectedIndexChanged_1);
            // 
            // DrinksCoffeeTeaID
            // 
            this.DrinksCoffeeTeaID.Width = 0;
            // 
            // caffeinatedId
            // 
            this.caffeinatedId.Text = "ID";
            this.caffeinatedId.Width = 0;
            // 
            // caffeinatedName
            // 
            this.caffeinatedName.Text = "Beers";
            this.caffeinatedName.Width = 250;
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
            this.DrinksTableOverview.Click += new System.EventHandler(this.DrinksTableOverview_Click);
            // 
            // orderCountlbl
            // 
            this.orderCountlbl.AutoSize = true;
            this.orderCountlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderCountlbl.Location = new System.Drawing.Point(1, 29);
            this.orderCountlbl.Name = "orderCountlbl";
            this.orderCountlbl.Size = new System.Drawing.Size(115, 25);
            this.orderCountlbl.TabIndex = 9;
            this.orderCountlbl.Text = "Drink Items:";
            // 
            // EmployeeNamelbl
            // 
            this.EmployeeNamelbl.AutoSize = true;
            this.EmployeeNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmployeeNamelbl.Location = new System.Drawing.Point(384, 7);
            this.EmployeeNamelbl.Name = "EmployeeNamelbl";
            this.EmployeeNamelbl.Size = new System.Drawing.Size(156, 25);
            this.EmployeeNamelbl.TabIndex = 10;
            this.EmployeeNamelbl.Text = "Employee Name";
            // 
            // tableNumberlbl
            // 
            this.tableNumberlbl.AutoSize = true;
            this.tableNumberlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tableNumberlbl.Location = new System.Drawing.Point(1, 4);
            this.tableNumberlbl.Name = "tableNumberlbl";
            this.tableNumberlbl.Size = new System.Drawing.Size(136, 25);
            this.tableNumberlbl.TabIndex = 11;
            this.tableNumberlbl.Text = "Table Number";
            // 
            // DrinksMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 752);
            this.Controls.Add(this.tableNumberlbl);
            this.Controls.Add(this.EmployeeNamelbl);
            this.Controls.Add(this.orderCountlbl);
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
        private System.Windows.Forms.ColumnHeader softdrinkId;
        private System.Windows.Forms.ColumnHeader softdrinkName;
        private System.Windows.Forms.ColumnHeader beerId;
        private System.Windows.Forms.ColumnHeader beerName;
        private System.Windows.Forms.ColumnHeader wineId;
        private System.Windows.Forms.ColumnHeader wineName;
        private System.Windows.Forms.ColumnHeader spiritId;
        private System.Windows.Forms.ColumnHeader spiritName;
        private System.Windows.Forms.ColumnHeader caffeinatedId;
        private System.Windows.Forms.ColumnHeader caffeinatedName;
        private System.Windows.Forms.Label orderCountlbl;
        private System.Windows.Forms.ColumnHeader DrinkSoftDrinkID;
        private System.Windows.Forms.ColumnHeader DrinksBeerID;
        private System.Windows.Forms.ColumnHeader DrinksWineID;
        private System.Windows.Forms.ColumnHeader DrinksSpiritID;
        private System.Windows.Forms.ColumnHeader DrinksCoffeeTeaID;
        private System.Windows.Forms.Label EmployeeNamelbl;
        private System.Windows.Forms.Label tableNumberlbl;
    }
}