
namespace ChapeauUI
{
    partial class ManagerViewMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerViewMenu));
            this.listView_Menu_Management = new System.Windows.Forms.ListView();
            this.menuItemId = new System.Windows.Forms.ColumnHeader();
            this.MenuItemName = new System.Windows.Forms.ColumnHeader();
            this.menuItemType = new System.Windows.Forms.ColumnHeader();
            this.menuItemCategory = new System.Windows.Forms.ColumnHeader();
            this.FoodOrDrink = new System.Windows.Forms.ColumnHeader();
            this.menuItemPrice = new System.Windows.Forms.ColumnHeader();
            this.menuItemStock = new System.Windows.Forms.ColumnHeader();
            this.menuItemPrepatation = new System.Windows.Forms.ColumnHeader();
            this.button_Add_Menu_Item = new System.Windows.Forms.Button();
            this.button_Menu_Form = new System.Windows.Forms.Button();
            this.button_Employees_Form = new System.Windows.Forms.Button();
            this.button_Edit_MenuItem = new System.Windows.Forms.Button();
            this.button_Delete_MenuItem = new System.Windows.Forms.Button();
            this.label_managerName = new System.Windows.Forms.Label();
            this.panel_Manager = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Manager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView_Menu_Management
            // 
            this.listView_Menu_Management.AllowDrop = true;
            this.listView_Menu_Management.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.menuItemId,
            this.MenuItemName,
            this.menuItemType,
            this.menuItemCategory,
            this.FoodOrDrink,
            this.menuItemPrice,
            this.menuItemStock,
            this.menuItemPrepatation});
            this.listView_Menu_Management.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView_Menu_Management.FullRowSelect = true;
            this.listView_Menu_Management.HideSelection = false;
            this.listView_Menu_Management.Location = new System.Drawing.Point(23, 205);
            this.listView_Menu_Management.MultiSelect = false;
            this.listView_Menu_Management.Name = "listView_Menu_Management";
            this.listView_Menu_Management.Size = new System.Drawing.Size(1376, 540);
            this.listView_Menu_Management.TabIndex = 1;
            this.listView_Menu_Management.UseCompatibleStateImageBehavior = false;
            this.listView_Menu_Management.View = System.Windows.Forms.View.Details;
            this.listView_Menu_Management.SelectedIndexChanged += new System.EventHandler(this.listView_Menu_Management_SelectedIndexChanged);
            // 
            // menuItemId
            // 
            this.menuItemId.Text = "Id";
            this.menuItemId.Width = 0;
            // 
            // MenuItemName
            // 
            this.MenuItemName.Text = "Name";
            this.MenuItemName.Width = 650;
            // 
            // menuItemType
            // 
            this.menuItemType.Text = "Type";
            this.menuItemType.Width = 130;
            // 
            // menuItemCategory
            // 
            this.menuItemCategory.Text = "Category";
            this.menuItemCategory.Width = 130;
            // 
            // FoodOrDrink
            // 
            this.FoodOrDrink.Text = "Food/Drink";
            this.FoodOrDrink.Width = 130;
            // 
            // menuItemPrice
            // 
            this.menuItemPrice.Text = "Price";
            this.menuItemPrice.Width = 90;
            // 
            // menuItemStock
            // 
            this.menuItemStock.Text = "Stock";
            this.menuItemStock.Width = 90;
            // 
            // menuItemPrepatation
            // 
            this.menuItemPrepatation.Text = "Prep. Time";
            this.menuItemPrepatation.Width = 150;
            // 
            // button_Add_Menu_Item
            // 
            this.button_Add_Menu_Item.BackColor = System.Drawing.Color.Gainsboro;
            this.button_Add_Menu_Item.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Add_Menu_Item.Location = new System.Drawing.Point(65, 805);
            this.button_Add_Menu_Item.Name = "button_Add_Menu_Item";
            this.button_Add_Menu_Item.Size = new System.Drawing.Size(200, 85);
            this.button_Add_Menu_Item.TabIndex = 2;
            this.button_Add_Menu_Item.Text = "Add To Menu";
            this.button_Add_Menu_Item.UseVisualStyleBackColor = false;
            this.button_Add_Menu_Item.Click += new System.EventHandler(this.button_Add_Menu_Item_Click);
            // 
            // button_Menu_Form
            // 
            this.button_Menu_Form.BackColor = System.Drawing.Color.Gainsboro;
            this.button_Menu_Form.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Menu_Form.Location = new System.Drawing.Point(241, 165);
            this.button_Menu_Form.Name = "button_Menu_Form";
            this.button_Menu_Form.Size = new System.Drawing.Size(206, 40);
            this.button_Menu_Form.TabIndex = 7;
            this.button_Menu_Form.Text = "Menu Items";
            this.button_Menu_Form.UseVisualStyleBackColor = false;
            // 
            // button_Employees_Form
            // 
            this.button_Employees_Form.BackColor = System.Drawing.Color.Gainsboro;
            this.button_Employees_Form.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Employees_Form.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Employees_Form.Location = new System.Drawing.Point(40, 165);
            this.button_Employees_Form.Name = "button_Employees_Form";
            this.button_Employees_Form.Size = new System.Drawing.Size(206, 40);
            this.button_Employees_Form.TabIndex = 6;
            this.button_Employees_Form.Text = "Employees";
            this.button_Employees_Form.UseVisualStyleBackColor = false;
            this.button_Employees_Form.Click += new System.EventHandler(this.button_Employees_Form_Click);
            // 
            // button_Edit_MenuItem
            // 
            this.button_Edit_MenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.button_Edit_MenuItem.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Edit_MenuItem.ForeColor = System.Drawing.Color.Black;
            this.button_Edit_MenuItem.Location = new System.Drawing.Point(620, 805);
            this.button_Edit_MenuItem.Name = "button_Edit_MenuItem";
            this.button_Edit_MenuItem.Size = new System.Drawing.Size(200, 85);
            this.button_Edit_MenuItem.TabIndex = 10;
            this.button_Edit_MenuItem.Text = "Edit";
            this.button_Edit_MenuItem.UseVisualStyleBackColor = false;
            this.button_Edit_MenuItem.Click += new System.EventHandler(this.button_Edit_MenuItem_Click);
            // 
            // button_Delete_MenuItem
            // 
            this.button_Delete_MenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.button_Delete_MenuItem.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Delete_MenuItem.ForeColor = System.Drawing.Color.Black;
            this.button_Delete_MenuItem.Location = new System.Drawing.Point(1125, 805);
            this.button_Delete_MenuItem.Name = "button_Delete_MenuItem";
            this.button_Delete_MenuItem.Size = new System.Drawing.Size(200, 85);
            this.button_Delete_MenuItem.TabIndex = 9;
            this.button_Delete_MenuItem.Text = "Delete";
            this.button_Delete_MenuItem.UseVisualStyleBackColor = false;
            this.button_Delete_MenuItem.Click += new System.EventHandler(this.button_Delete_MenuItem_Click);
            // 
            // label_managerName
            // 
            this.label_managerName.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_managerName.ForeColor = System.Drawing.Color.Black;
            this.label_managerName.Location = new System.Drawing.Point(774, 9);
            this.label_managerName.Name = "label_managerName";
            this.label_managerName.Size = new System.Drawing.Size(636, 59);
            this.label_managerName.TabIndex = 14;
            this.label_managerName.Text = "label1";
            this.label_managerName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label_managerName.Click += new System.EventHandler(this.label_managerName_Click);
            // 
            // panel_Manager
            // 
            this.panel_Manager.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_Manager.Controls.Add(this.pictureBox1);
            this.panel_Manager.Controls.Add(this.label_managerName);
            this.panel_Manager.Location = new System.Drawing.Point(0, 0);
            this.panel_Manager.Name = "panel_Manager";
            this.panel_Manager.Size = new System.Drawing.Size(1422, 68);
            this.panel_Manager.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(653, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // ManagerViewMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1422, 977);
            this.Controls.Add(this.button_Edit_MenuItem);
            this.Controls.Add(this.button_Delete_MenuItem);
            this.Controls.Add(this.panel_Manager);
            this.Controls.Add(this.button_Menu_Form);
            this.Controls.Add(this.button_Employees_Form);
            this.Controls.Add(this.button_Add_Menu_Item);
            this.Controls.Add(this.listView_Menu_Management);
            this.Location = new System.Drawing.Point(625, 764);
            this.Name = "ManagerViewMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerViewMenu";
            this.panel_Manager.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_Menu_Management;
        private System.Windows.Forms.ColumnHeader menuItemId;
        private System.Windows.Forms.ColumnHeader MenuItemName;
        private System.Windows.Forms.ColumnHeader menuItemType;
        private System.Windows.Forms.ColumnHeader menuItemCategory;
        private System.Windows.Forms.ColumnHeader FoodOrDrink;
        private System.Windows.Forms.ColumnHeader menuItemPrice;
        private System.Windows.Forms.ColumnHeader menuItemStock;
        private System.Windows.Forms.ColumnHeader menuItemPrepatation;
        private System.Windows.Forms.Button button_Add_Menu_Item;
        private System.Windows.Forms.Button button_Menu_Form;
        private System.Windows.Forms.Button button_Employees_Form;
        private System.Windows.Forms.Button button_Edit_MenuItem;
        private System.Windows.Forms.Button button_Delete_MenuItem;
        private System.Windows.Forms.Label label_managerName;
        private System.Windows.Forms.Panel panel_Manager;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}