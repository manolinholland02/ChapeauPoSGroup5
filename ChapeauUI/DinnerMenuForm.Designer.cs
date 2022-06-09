
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
            this.dinnerDeserId = new System.Windows.Forms.ColumnHeader();
            this.deserId = new System.Windows.Forms.ColumnHeader();
            this.desertName = new System.Windows.Forms.ColumnHeader();
            this.DinnerStartersListView = new System.Windows.Forms.ListView();
            this.dinnerStarterId = new System.Windows.Forms.ColumnHeader();
            this.starterId = new System.Windows.Forms.ColumnHeader();
            this.starterName = new System.Windows.Forms.ColumnHeader();
            this.DinnerMainListView = new System.Windows.Forms.ListView();
            this.dinnerMainId = new System.Windows.Forms.ColumnHeader();
            this.mainId = new System.Windows.Forms.ColumnHeader();
            this.mainName = new System.Windows.Forms.ColumnHeader();
            this.DinnerEntremetsListView = new System.Windows.Forms.ListView();
            this.dinnerEntrementId = new System.Windows.Forms.ColumnHeader();
            this.entremetId = new System.Windows.Forms.ColumnHeader();
            this.entremetName = new System.Windows.Forms.ColumnHeader();
            this.BackbtnDinner = new System.Windows.Forms.Button();
            this.AddbtnDinner = new System.Windows.Forms.Button();
            this.DinnerCommentSection = new System.Windows.Forms.TextBox();
            this.OrderOverviewDinnerbtn = new System.Windows.Forms.Button();
            this.orderCounterlbl = new System.Windows.Forms.Label();
            this.EmployeeNamelbl = new System.Windows.Forms.Label();
            this.tableNumberlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DinnerDessertsListView
            // 
            this.DinnerDessertsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dinnerDeserId,
            this.deserId,
            this.desertName});
            this.DinnerDessertsListView.HideSelection = false;
            this.DinnerDessertsListView.Location = new System.Drawing.Point(274, 338);
            this.DinnerDessertsListView.Name = "DinnerDessertsListView";
            this.DinnerDessertsListView.Size = new System.Drawing.Size(265, 212);
            this.DinnerDessertsListView.TabIndex = 0;
            this.DinnerDessertsListView.UseCompatibleStateImageBehavior = false;
            this.DinnerDessertsListView.View = System.Windows.Forms.View.Details;
            this.DinnerDessertsListView.SelectedIndexChanged += new System.EventHandler(this.DinnerDessertsListView_SelectedIndexChanged);
            // 
            // dinnerDeserId
            // 
            this.dinnerDeserId.Text = "ID";
            this.dinnerDeserId.Width = 0;
            // 
            // deserId
            // 
            this.deserId.Text = "ID";
            this.deserId.Width = 0;
            // 
            // desertName
            // 
            this.desertName.Text = "Desserts";
            this.desertName.Width = 250;
            // 
            // DinnerStartersListView
            // 
            this.DinnerStartersListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dinnerStarterId,
            this.starterId,
            this.starterName});
            this.DinnerStartersListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DinnerStartersListView.HideSelection = false;
            this.DinnerStartersListView.Location = new System.Drawing.Point(3, 120);
            this.DinnerStartersListView.Name = "DinnerStartersListView";
            this.DinnerStartersListView.Size = new System.Drawing.Size(265, 212);
            this.DinnerStartersListView.TabIndex = 1;
            this.DinnerStartersListView.UseCompatibleStateImageBehavior = false;
            this.DinnerStartersListView.View = System.Windows.Forms.View.Details;
            this.DinnerStartersListView.SelectedIndexChanged += new System.EventHandler(this.DinnerStartersListView_SelectedIndexChanged);
            // 
            // dinnerStarterId
            // 
            this.dinnerStarterId.Text = "ID";
            this.dinnerStarterId.Width = 0;
            // 
            // starterId
            // 
            this.starterId.Text = "ID";
            this.starterId.Width = 0;
            // 
            // starterName
            // 
            this.starterName.Text = "Starters";
            this.starterName.Width = 250;
            // 
            // DinnerMainListView
            // 
            this.DinnerMainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dinnerMainId,
            this.mainId,
            this.mainName});
            this.DinnerMainListView.HideSelection = false;
            this.DinnerMainListView.Location = new System.Drawing.Point(3, 338);
            this.DinnerMainListView.Name = "DinnerMainListView";
            this.DinnerMainListView.Size = new System.Drawing.Size(265, 212);
            this.DinnerMainListView.TabIndex = 2;
            this.DinnerMainListView.UseCompatibleStateImageBehavior = false;
            this.DinnerMainListView.View = System.Windows.Forms.View.Details;
            this.DinnerMainListView.SelectedIndexChanged += new System.EventHandler(this.DinnerMainListView_SelectedIndexChanged);
            // 
            // dinnerMainId
            // 
            this.dinnerMainId.Text = "ID";
            this.dinnerMainId.Width = 0;
            // 
            // mainId
            // 
            this.mainId.Text = "ID";
            this.mainId.Width = 0;
            // 
            // mainName
            // 
            this.mainName.Text = "Mains";
            this.mainName.Width = 250;
            // 
            // DinnerEntremetsListView
            // 
            this.DinnerEntremetsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dinnerEntrementId,
            this.entremetId,
            this.entremetName});
            this.DinnerEntremetsListView.HideSelection = false;
            this.DinnerEntremetsListView.Location = new System.Drawing.Point(274, 120);
            this.DinnerEntremetsListView.Name = "DinnerEntremetsListView";
            this.DinnerEntremetsListView.Size = new System.Drawing.Size(265, 212);
            this.DinnerEntremetsListView.TabIndex = 3;
            this.DinnerEntremetsListView.UseCompatibleStateImageBehavior = false;
            this.DinnerEntremetsListView.View = System.Windows.Forms.View.Details;
            this.DinnerEntremetsListView.SelectedIndexChanged += new System.EventHandler(this.DinnerEntremetsListView_SelectedIndexChanged);
            // 
            // dinnerEntrementId
            // 
            this.dinnerEntrementId.Text = "ID";
            this.dinnerEntrementId.Width = 0;
            // 
            // entremetId
            // 
            this.entremetId.Text = "ID";
            this.entremetId.Width = 0;
            // 
            // entremetName
            // 
            this.entremetName.Text = "Entremets";
            this.entremetName.Width = 250;
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
            // OrderOverviewDinnerbtn
            // 
            this.OrderOverviewDinnerbtn.Location = new System.Drawing.Point(410, 29);
            this.OrderOverviewDinnerbtn.Name = "OrderOverviewDinnerbtn";
            this.OrderOverviewDinnerbtn.Size = new System.Drawing.Size(115, 82);
            this.OrderOverviewDinnerbtn.TabIndex = 7;
            this.OrderOverviewDinnerbtn.Text = "See Table\'s Order";
            this.OrderOverviewDinnerbtn.UseVisualStyleBackColor = true;
            this.OrderOverviewDinnerbtn.Click += new System.EventHandler(this.OrderOverviewDinnerbtn_Click);
            // 
            // orderCounterlbl
            // 
            this.orderCounterlbl.AutoSize = true;
            this.orderCounterlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderCounterlbl.Location = new System.Drawing.Point(3, 29);
            this.orderCounterlbl.Name = "orderCounterlbl";
            this.orderCounterlbl.Size = new System.Drawing.Size(127, 25);
            this.orderCounterlbl.TabIndex = 8;
            this.orderCounterlbl.Text = "Dinner Items:";
            // 
            // EmployeeNamelbl
            // 
            this.EmployeeNamelbl.AutoSize = true;
            this.EmployeeNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmployeeNamelbl.Location = new System.Drawing.Point(369, 9);
            this.EmployeeNamelbl.Name = "EmployeeNamelbl";
            this.EmployeeNamelbl.Size = new System.Drawing.Size(156, 25);
            this.EmployeeNamelbl.TabIndex = 9;
            this.EmployeeNamelbl.Text = "Employee Name";
            // 
            // tableNumberlbl
            // 
            this.tableNumberlbl.AutoSize = true;
            this.tableNumberlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tableNumberlbl.Location = new System.Drawing.Point(3, 4);
            this.tableNumberlbl.Name = "tableNumberlbl";
            this.tableNumberlbl.Size = new System.Drawing.Size(136, 25);
            this.tableNumberlbl.TabIndex = 10;
            this.tableNumberlbl.Text = "Table Number";
            // 
            // DinnerMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 752);
            this.Controls.Add(this.tableNumberlbl);
            this.Controls.Add(this.EmployeeNamelbl);
            this.Controls.Add(this.orderCounterlbl);
            this.Controls.Add(this.OrderOverviewDinnerbtn);
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
        private System.Windows.Forms.Button OrderOverviewDinnerbtn;
        private System.Windows.Forms.ColumnHeader starterId;
        private System.Windows.Forms.ColumnHeader starterName;
        private System.Windows.Forms.ColumnHeader deserId;
        private System.Windows.Forms.ColumnHeader desertName;
        private System.Windows.Forms.ColumnHeader mainId;
        private System.Windows.Forms.ColumnHeader mainName;
        private System.Windows.Forms.ColumnHeader entremetId;
        private System.Windows.Forms.ColumnHeader entremetName;
        private System.Windows.Forms.Label orderCounterlbl;
        private System.Windows.Forms.ColumnHeader dinnerStarterId;
        private System.Windows.Forms.ColumnHeader dinnerEntrementId;
        private System.Windows.Forms.ColumnHeader dinnerDeserId;
        private System.Windows.Forms.ColumnHeader dinnerMainId;
        private System.Windows.Forms.Label EmployeeNamelbl;
        private System.Windows.Forms.Label tableNumberlbl;
    }
}