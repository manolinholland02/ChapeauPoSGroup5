
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMenuItem));
            this.label_menu_Item_Name = new System.Windows.Forms.Label();
            this.label_Menu_Item_Price = new System.Windows.Forms.Label();
            this.label_Menu_Item_Time = new System.Windows.Forms.Label();
            this.label_Menu_Item_Stock = new System.Windows.Forms.Label();
            this.groupBox_Food_Or_Drink = new System.Windows.Forms.GroupBox();
            this.radioButton_Menu_Item_Drink = new System.Windows.Forms.RadioButton();
            this.radioButton_Menu_Item_Food = new System.Windows.Forms.RadioButton();
            this.comboBox_Menu_Item_Category = new System.Windows.Forms.ComboBox();
            this.comboBox_Menu_Item_Type = new System.Windows.Forms.ComboBox();
            this.textBox_Menu_Name = new System.Windows.Forms.TextBox();
            this.textBox_Menu_Price = new System.Windows.Forms.TextBox();
            this.textBox_Menu_Stock = new System.Windows.Forms.TextBox();
            this.textBox_Menu_Time_Hours = new System.Windows.Forms.TextBox();
            this.button_Add_MenuItem = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.textBox_Menu_Time_Minutes = new System.Windows.Forms.TextBox();
            this.textBox_Menu_Time_Seconds = new System.Windows.Forms.TextBox();
            this.label_points2 = new System.Windows.Forms.Label();
            this.label_points = new System.Windows.Forms.Label();
            this.label_managerName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox_Food_Or_Drink.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_menu_Item_Name
            // 
            this.label_menu_Item_Name.AutoSize = true;
            this.label_menu_Item_Name.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_menu_Item_Name.Location = new System.Drawing.Point(421, 217);
            this.label_menu_Item_Name.Name = "label_menu_Item_Name";
            this.label_menu_Item_Name.Size = new System.Drawing.Size(88, 37);
            this.label_menu_Item_Name.TabIndex = 0;
            this.label_menu_Item_Name.Text = "Name";
            // 
            // label_Menu_Item_Price
            // 
            this.label_Menu_Item_Price.AutoSize = true;
            this.label_Menu_Item_Price.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Menu_Item_Price.Location = new System.Drawing.Point(421, 274);
            this.label_Menu_Item_Price.Name = "label_Menu_Item_Price";
            this.label_Menu_Item_Price.Size = new System.Drawing.Size(74, 37);
            this.label_Menu_Item_Price.TabIndex = 1;
            this.label_Menu_Item_Price.Text = "Price";
            // 
            // label_Menu_Item_Time
            // 
            this.label_Menu_Item_Time.AutoSize = true;
            this.label_Menu_Item_Time.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Menu_Item_Time.Location = new System.Drawing.Point(421, 326);
            this.label_Menu_Item_Time.Name = "label_Menu_Item_Time";
            this.label_Menu_Item_Time.Size = new System.Drawing.Size(178, 37);
            this.label_Menu_Item_Time.TabIndex = 2;
            this.label_Menu_Item_Time.Text = "Average Time";
            // 
            // label_Menu_Item_Stock
            // 
            this.label_Menu_Item_Stock.AutoSize = true;
            this.label_Menu_Item_Stock.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Menu_Item_Stock.Location = new System.Drawing.Point(421, 380);
            this.label_Menu_Item_Stock.Name = "label_Menu_Item_Stock";
            this.label_Menu_Item_Stock.Size = new System.Drawing.Size(80, 37);
            this.label_Menu_Item_Stock.TabIndex = 4;
            this.label_Menu_Item_Stock.Text = "Stock";
            // 
            // groupBox_Food_Or_Drink
            // 
            this.groupBox_Food_Or_Drink.Controls.Add(this.radioButton_Menu_Item_Drink);
            this.groupBox_Food_Or_Drink.Controls.Add(this.radioButton_Menu_Item_Food);
            this.groupBox_Food_Or_Drink.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox_Food_Or_Drink.Location = new System.Drawing.Point(421, 454);
            this.groupBox_Food_Or_Drink.Name = "groupBox_Food_Or_Drink";
            this.groupBox_Food_Or_Drink.Size = new System.Drawing.Size(563, 143);
            this.groupBox_Food_Or_Drink.TabIndex = 5;
            this.groupBox_Food_Or_Drink.TabStop = false;
            this.groupBox_Food_Or_Drink.Text = "Food Or Drink";
            // 
            // radioButton_Menu_Item_Drink
            // 
            this.radioButton_Menu_Item_Drink.AutoSize = true;
            this.radioButton_Menu_Item_Drink.Location = new System.Drawing.Point(405, 56);
            this.radioButton_Menu_Item_Drink.Name = "radioButton_Menu_Item_Drink";
            this.radioButton_Menu_Item_Drink.Size = new System.Drawing.Size(101, 41);
            this.radioButton_Menu_Item_Drink.TabIndex = 1;
            this.radioButton_Menu_Item_Drink.TabStop = true;
            this.radioButton_Menu_Item_Drink.Text = "Drink";
            this.radioButton_Menu_Item_Drink.UseVisualStyleBackColor = true;
            this.radioButton_Menu_Item_Drink.CheckedChanged += new System.EventHandler(this.radioButton_Menu_Item_Drink_CheckedChanged);
            // 
            // radioButton_Menu_Item_Food
            // 
            this.radioButton_Menu_Item_Food.AutoSize = true;
            this.radioButton_Menu_Item_Food.Location = new System.Drawing.Point(53, 56);
            this.radioButton_Menu_Item_Food.Name = "radioButton_Menu_Item_Food";
            this.radioButton_Menu_Item_Food.Size = new System.Drawing.Size(99, 41);
            this.radioButton_Menu_Item_Food.TabIndex = 0;
            this.radioButton_Menu_Item_Food.TabStop = true;
            this.radioButton_Menu_Item_Food.Text = "Food";
            this.radioButton_Menu_Item_Food.UseVisualStyleBackColor = true;
            this.radioButton_Menu_Item_Food.CheckedChanged += new System.EventHandler(this.radioButton_Menu_Item_Food_CheckedChanged);
            // 
            // comboBox_Menu_Item_Category
            // 
            this.comboBox_Menu_Item_Category.BackColor = System.Drawing.Color.AliceBlue;
            this.comboBox_Menu_Item_Category.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_Menu_Item_Category.FormattingEnabled = true;
            this.comboBox_Menu_Item_Category.Location = new System.Drawing.Point(421, 657);
            this.comboBox_Menu_Item_Category.Name = "comboBox_Menu_Item_Category";
            this.comboBox_Menu_Item_Category.Size = new System.Drawing.Size(241, 45);
            this.comboBox_Menu_Item_Category.TabIndex = 0;
            // 
            // comboBox_Menu_Item_Type
            // 
            this.comboBox_Menu_Item_Type.BackColor = System.Drawing.Color.AliceBlue;
            this.comboBox_Menu_Item_Type.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_Menu_Item_Type.FormattingEnabled = true;
            this.comboBox_Menu_Item_Type.Location = new System.Drawing.Point(749, 657);
            this.comboBox_Menu_Item_Type.Name = "comboBox_Menu_Item_Type";
            this.comboBox_Menu_Item_Type.Size = new System.Drawing.Size(235, 45);
            this.comboBox_Menu_Item_Type.TabIndex = 6;
            this.comboBox_Menu_Item_Type.SelectedIndexChanged += new System.EventHandler(this.comboBox_Menu_Item_Type_SelectedIndexChanged);
            // 
            // textBox_Menu_Name
            // 
            this.textBox_Menu_Name.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Menu_Name.Location = new System.Drawing.Point(657, 211);
            this.textBox_Menu_Name.Name = "textBox_Menu_Name";
            this.textBox_Menu_Name.Size = new System.Drawing.Size(327, 43);
            this.textBox_Menu_Name.TabIndex = 7;
            // 
            // textBox_Menu_Price
            // 
            this.textBox_Menu_Price.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Menu_Price.Location = new System.Drawing.Point(657, 268);
            this.textBox_Menu_Price.Name = "textBox_Menu_Price";
            this.textBox_Menu_Price.Size = new System.Drawing.Size(327, 43);
            this.textBox_Menu_Price.TabIndex = 8;
            // 
            // textBox_Menu_Stock
            // 
            this.textBox_Menu_Stock.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Menu_Stock.Location = new System.Drawing.Point(657, 383);
            this.textBox_Menu_Stock.Name = "textBox_Menu_Stock";
            this.textBox_Menu_Stock.Size = new System.Drawing.Size(327, 43);
            this.textBox_Menu_Stock.TabIndex = 9;
            this.textBox_Menu_Stock.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_Menu_Time_Hours
            // 
            this.textBox_Menu_Time_Hours.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Menu_Time_Hours.Location = new System.Drawing.Point(657, 326);
            this.textBox_Menu_Time_Hours.Name = "textBox_Menu_Time_Hours";
            this.textBox_Menu_Time_Hours.Size = new System.Drawing.Size(82, 43);
            this.textBox_Menu_Time_Hours.TabIndex = 10;
            // 
            // button_Add_MenuItem
            // 
            this.button_Add_MenuItem.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Add_MenuItem.Location = new System.Drawing.Point(290, 803);
            this.button_Add_MenuItem.Name = "button_Add_MenuItem";
            this.button_Add_MenuItem.Size = new System.Drawing.Size(200, 85);
            this.button_Add_MenuItem.TabIndex = 11;
            this.button_Add_MenuItem.Text = "Add";
            this.button_Add_MenuItem.UseVisualStyleBackColor = true;
            this.button_Add_MenuItem.Click += new System.EventHandler(this.button_Add_MenuItem_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Cancel.Location = new System.Drawing.Point(900, 803);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(200, 85);
            this.button_Cancel.TabIndex = 12;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // textBox_Menu_Time_Minutes
            // 
            this.textBox_Menu_Time_Minutes.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Menu_Time_Minutes.Location = new System.Drawing.Point(782, 326);
            this.textBox_Menu_Time_Minutes.Name = "textBox_Menu_Time_Minutes";
            this.textBox_Menu_Time_Minutes.Size = new System.Drawing.Size(82, 43);
            this.textBox_Menu_Time_Minutes.TabIndex = 13;
            // 
            // textBox_Menu_Time_Seconds
            // 
            this.textBox_Menu_Time_Seconds.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Menu_Time_Seconds.Location = new System.Drawing.Point(902, 326);
            this.textBox_Menu_Time_Seconds.Name = "textBox_Menu_Time_Seconds";
            this.textBox_Menu_Time_Seconds.Size = new System.Drawing.Size(82, 43);
            this.textBox_Menu_Time_Seconds.TabIndex = 14;
            // 
            // label_points2
            // 
            this.label_points2.AutoSize = true;
            this.label_points2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_points2.Location = new System.Drawing.Point(749, 326);
            this.label_points2.Name = "label_points2";
            this.label_points2.Size = new System.Drawing.Size(23, 37);
            this.label_points2.TabIndex = 15;
            this.label_points2.Text = ":";
            // 
            // label_points
            // 
            this.label_points.AutoSize = true;
            this.label_points.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_points.Location = new System.Drawing.Point(873, 326);
            this.label_points.Name = "label_points";
            this.label_points.Size = new System.Drawing.Size(23, 37);
            this.label_points.TabIndex = 16;
            this.label_points.Text = ":";
            // 
            // label_managerName
            // 
            this.label_managerName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_managerName.ForeColor = System.Drawing.Color.Black;
            this.label_managerName.Location = new System.Drawing.Point(1187, 9);
            this.label_managerName.Name = "label_managerName";
            this.label_managerName.Size = new System.Drawing.Size(223, 88);
            this.label_managerName.TabIndex = 14;
            this.label_managerName.Text = "label1";
            this.label_managerName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label_managerName.Click += new System.EventHandler(this.label_managerName_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(616, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label_managerName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1422, 99);
            this.panel1.TabIndex = 17;
            // 
            // AddMenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 977);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_points);
            this.Controls.Add(this.label_points2);
            this.Controls.Add(this.textBox_Menu_Time_Seconds);
            this.Controls.Add(this.textBox_Menu_Time_Minutes);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Add_MenuItem);
            this.Controls.Add(this.textBox_Menu_Time_Hours);
            this.Controls.Add(this.textBox_Menu_Stock);
            this.Controls.Add(this.textBox_Menu_Price);
            this.Controls.Add(this.textBox_Menu_Name);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox textBox_Menu_Name;
        private System.Windows.Forms.TextBox textBox_Menu_Price;
        private System.Windows.Forms.TextBox textBox_Menu_Stock;
        private System.Windows.Forms.TextBox textBox_Menu_Time_Hours;
        private System.Windows.Forms.Button button_Add_MenuItem;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.TextBox textBox_Menu_Time_Minutes;
        private System.Windows.Forms.TextBox textBox_Menu_Time_Seconds;
        private System.Windows.Forms.Label label_points2;
        private System.Windows.Forms.Label label_points;
        private System.Windows.Forms.Label label_managerName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}