
namespace ChapeauUI
{
    partial class AddMenuItem
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
            this.label_menu_Item_Name = new System.Windows.Forms.Label();
            this.label_Menu_Item_Price = new System.Windows.Forms.Label();
            this.label_Menu_Item_Time = new System.Windows.Forms.Label();
            this.label_Menu_Item_Stock = new System.Windows.Forms.Label();
            this.groupBox_Food_Or_Drink = new System.Windows.Forms.GroupBox();
            this.radioButton_Menu_Item_Drink = new System.Windows.Forms.RadioButton();
            this.radioButton_Menu_Item_Food = new System.Windows.Forms.RadioButton();
            this.comboBox_Menu_Item_Category = new System.Windows.Forms.ComboBox();
            this.comboBox_Menu_Item_Type = new System.Windows.Forms.ComboBox();
            this.groupBox_Food_Or_Drink.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_menu_Item_Name
            // 
            this.label_menu_Item_Name.AutoSize = true;
            this.label_menu_Item_Name.Location = new System.Drawing.Point(46, 124);
            this.label_menu_Item_Name.Name = "label_menu_Item_Name";
            this.label_menu_Item_Name.Size = new System.Drawing.Size(49, 20);
            this.label_menu_Item_Name.TabIndex = 0;
            this.label_menu_Item_Name.Text = "Name";
            // 
            // label_Menu_Item_Price
            // 
            this.label_Menu_Item_Price.AutoSize = true;
            this.label_Menu_Item_Price.Location = new System.Drawing.Point(46, 175);
            this.label_Menu_Item_Price.Name = "label_Menu_Item_Price";
            this.label_Menu_Item_Price.Size = new System.Drawing.Size(41, 20);
            this.label_Menu_Item_Price.TabIndex = 1;
            this.label_Menu_Item_Price.Text = "Price";
            // 
            // label_Menu_Item_Time
            // 
            this.label_Menu_Item_Time.AutoSize = true;
            this.label_Menu_Item_Time.Location = new System.Drawing.Point(46, 233);
            this.label_Menu_Item_Time.Name = "label_Menu_Item_Time";
            this.label_Menu_Item_Time.Size = new System.Drawing.Size(101, 20);
            this.label_Menu_Item_Time.TabIndex = 2;
            this.label_Menu_Item_Time.Text = "Average Time";
            // 
            // label_Menu_Item_Stock
            // 
            this.label_Menu_Item_Stock.AutoSize = true;
            this.label_Menu_Item_Stock.Location = new System.Drawing.Point(46, 287);
            this.label_Menu_Item_Stock.Name = "label_Menu_Item_Stock";
            this.label_Menu_Item_Stock.Size = new System.Drawing.Size(45, 20);
            this.label_Menu_Item_Stock.TabIndex = 4;
            this.label_Menu_Item_Stock.Text = "Stock";
            // 
            // groupBox_Food_Or_Drink
            // 
            this.groupBox_Food_Or_Drink.Controls.Add(this.radioButton_Menu_Item_Drink);
            this.groupBox_Food_Or_Drink.Controls.Add(this.radioButton_Menu_Item_Food);
            this.groupBox_Food_Or_Drink.Location = new System.Drawing.Point(46, 339);
            this.groupBox_Food_Or_Drink.Name = "groupBox_Food_Or_Drink";
            this.groupBox_Food_Or_Drink.Size = new System.Drawing.Size(329, 125);
            this.groupBox_Food_Or_Drink.TabIndex = 5;
            this.groupBox_Food_Or_Drink.TabStop = false;
            this.groupBox_Food_Or_Drink.Text = "Food Or Drink";
            // 
            // radioButton_Menu_Item_Drink
            // 
            this.radioButton_Menu_Item_Drink.AutoSize = true;
            this.radioButton_Menu_Item_Drink.Location = new System.Drawing.Point(18, 86);
            this.radioButton_Menu_Item_Drink.Name = "radioButton_Menu_Item_Drink";
            this.radioButton_Menu_Item_Drink.Size = new System.Drawing.Size(65, 24);
            this.radioButton_Menu_Item_Drink.TabIndex = 1;
            this.radioButton_Menu_Item_Drink.TabStop = true;
            this.radioButton_Menu_Item_Drink.Text = "Drink";
            this.radioButton_Menu_Item_Drink.UseVisualStyleBackColor = true;
            this.radioButton_Menu_Item_Drink.CheckedChanged += new System.EventHandler(this.radioButton_Menu_Item_Drink_CheckedChanged);
            // 
            // radioButton_Menu_Item_Food
            // 
            this.radioButton_Menu_Item_Food.AutoSize = true;
            this.radioButton_Menu_Item_Food.Location = new System.Drawing.Point(18, 45);
            this.radioButton_Menu_Item_Food.Name = "radioButton_Menu_Item_Food";
            this.radioButton_Menu_Item_Food.Size = new System.Drawing.Size(64, 24);
            this.radioButton_Menu_Item_Food.TabIndex = 0;
            this.radioButton_Menu_Item_Food.TabStop = true;
            this.radioButton_Menu_Item_Food.Text = "Food";
            this.radioButton_Menu_Item_Food.UseVisualStyleBackColor = true;
            this.radioButton_Menu_Item_Food.CheckedChanged += new System.EventHandler(this.radioButton_Menu_Item_Food_CheckedChanged);
            // 
            // comboBox_Menu_Item_Category
            // 
            this.comboBox_Menu_Item_Category.FormattingEnabled = true;
            this.comboBox_Menu_Item_Category.Location = new System.Drawing.Point(30, 503);
            this.comboBox_Menu_Item_Category.Name = "comboBox_Menu_Item_Category";
            this.comboBox_Menu_Item_Category.Size = new System.Drawing.Size(151, 28);
            this.comboBox_Menu_Item_Category.TabIndex = 0;
            // 
            // comboBox_Menu_Item_Type
            // 
            this.comboBox_Menu_Item_Type.FormattingEnabled = true;
            this.comboBox_Menu_Item_Type.Location = new System.Drawing.Point(259, 503);
            this.comboBox_Menu_Item_Type.Name = "comboBox_Menu_Item_Type";
            this.comboBox_Menu_Item_Type.Size = new System.Drawing.Size(151, 28);
            this.comboBox_Menu_Item_Type.TabIndex = 6;
            // 
            // AddMenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 977);
            this.Controls.Add(this.comboBox_Menu_Item_Type);
            this.Controls.Add(this.comboBox_Menu_Item_Category);
            this.Controls.Add(this.groupBox_Food_Or_Drink);
            this.Controls.Add(this.label_Menu_Item_Stock);
            this.Controls.Add(this.label_Menu_Item_Time);
            this.Controls.Add(this.label_Menu_Item_Price);
            this.Controls.Add(this.label_menu_Item_Name);
            this.Name = "AddMenuItem";
            this.Text = " ";
            this.groupBox_Food_Or_Drink.ResumeLayout(false);
            this.groupBox_Food_Or_Drink.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_menu_Item_Name;
        private System.Windows.Forms.Label label_Menu_Item_Price;
        private System.Windows.Forms.Label label_Menu_Item_Time;
        private System.Windows.Forms.Label label_Menu_Item_Stock;
        private System.Windows.Forms.GroupBox groupBox_Food_Or_Drink;
        private System.Windows.Forms.ComboBox comboBox_Menu_Item_Category;
        private System.Windows.Forms.RadioButton radioButton_Menu_Item_Drink;
        private System.Windows.Forms.RadioButton radioButton_Menu_Item_Food;
        private System.Windows.Forms.ComboBox comboBox_Menu_Item_Type;
    }
}