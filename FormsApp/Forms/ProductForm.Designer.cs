
namespace FormsApp.Forms
{
    partial class ProductForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.panel1 = new System.Windows.Forms.Panel();
            this.availableLbl = new System.Windows.Forms.Label();
            this.availableComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.productsListView = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Available = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.categoriesComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.priceTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.productNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.titleLable = new System.Windows.Forms.Label();
            this.sellerButton = new System.Windows.Forms.Button();
            this.categoryButton = new System.Windows.Forms.Button();
            this.sellingButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.availableLbl);
            this.panel1.Controls.Add(this.availableComboBox1);
            this.panel1.Controls.Add(this.productsListView);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.categoriesComboBox);
            this.panel1.Controls.Add(this.categoryLabel);
            this.panel1.Controls.Add(this.quantityTextBox);
            this.panel1.Controls.Add(this.priceTextBox);
            this.panel1.Controls.Add(this.quantityLabel);
            this.panel1.Controls.Add(this.priceLabel);
            this.panel1.Controls.Add(this.productNameTextBox);
            this.panel1.Controls.Add(this.productNameLabel);
            this.panel1.Controls.Add(this.titleLable);
            this.panel1.Location = new System.Drawing.Point(153, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1277, 508);
            this.panel1.TabIndex = 0;
            // 
            // availableLbl
            // 
            this.availableLbl.AutoSize = true;
            this.availableLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.availableLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.availableLbl.Location = new System.Drawing.Point(13, 386);
            this.availableLbl.Name = "availableLbl";
            this.availableLbl.Size = new System.Drawing.Size(111, 23);
            this.availableLbl.TabIndex = 18;
            this.availableLbl.Text = "Available:";
            // 
            // availableComboBox1
            // 
            this.availableComboBox1.BackColor = System.Drawing.Color.Black;
            this.availableComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.availableComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.availableComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.availableComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.availableComboBox1.FocusedState.Parent = this.availableComboBox1;
            this.availableComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.availableComboBox1.ForeColor = System.Drawing.Color.Black;
            this.availableComboBox1.HoverState.Parent = this.availableComboBox1;
            this.availableComboBox1.ItemHeight = 30;
            this.availableComboBox1.ItemsAppearance.Parent = this.availableComboBox1;
            this.availableComboBox1.Location = new System.Drawing.Point(145, 373);
            this.availableComboBox1.Name = "availableComboBox1";
            this.availableComboBox1.ShadowDecoration.Parent = this.availableComboBox1;
            this.availableComboBox1.Size = new System.Drawing.Size(262, 36);
            this.availableComboBox1.TabIndex = 17;
            // 
            // productsListView
            // 
            this.productsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Price,
            this.quantity,
            this.Category,
            this.productId,
            this.Available});
            this.productsListView.HideSelection = false;
            this.productsListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.productsListView.Location = new System.Drawing.Point(453, 104);
            this.productsListView.Name = "productsListView";
            this.productsListView.Size = new System.Drawing.Size(721, 391);
            this.productsListView.TabIndex = 16;
            this.productsListView.UseCompatibleStateImageBehavior = false;
            this.productsListView.View = System.Windows.Forms.View.Details;
            this.productsListView.Click += new System.EventHandler(this.productsListView_SelectedItem);
            // 
            // Name
            // 
            this.Name.Text = "Product";
            this.Name.Width = 118;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 102;
            // 
            // quantity
            // 
            this.quantity.Text = "Quantity";
            this.quantity.Width = 158;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 98;
            // 
            // productId
            // 
            this.productId.Text = "ProductId";
            this.productId.Width = 111;
            // 
            // Available
            // 
            this.Available.Text = "AvailableHeader";
            this.Available.Width = 115;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(851, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteButton.ForeColor = System.Drawing.Color.Black;
            this.deleteButton.Location = new System.Drawing.Point(282, 438);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(97, 34);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editButton.ForeColor = System.Drawing.Color.Black;
            this.editButton.Location = new System.Drawing.Point(145, 438);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(97, 34);
            this.editButton.TabIndex = 11;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addButton.ForeColor = System.Drawing.Color.Black;
            this.addButton.Location = new System.Drawing.Point(17, 438);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(97, 34);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // categoriesComboBox
            // 
            this.categoriesComboBox.BackColor = System.Drawing.Color.Black;
            this.categoriesComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.categoriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriesComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoriesComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoriesComboBox.FocusedState.Parent = this.categoriesComboBox;
            this.categoriesComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.categoriesComboBox.ForeColor = System.Drawing.Color.Black;
            this.categoriesComboBox.HoverState.Parent = this.categoriesComboBox;
            this.categoriesComboBox.ItemHeight = 30;
            this.categoriesComboBox.ItemsAppearance.Parent = this.categoriesComboBox;
            this.categoriesComboBox.Location = new System.Drawing.Point(141, 300);
            this.categoriesComboBox.Name = "categoriesComboBox";
            this.categoriesComboBox.ShadowDecoration.Parent = this.categoriesComboBox;
            this.categoriesComboBox.Size = new System.Drawing.Size(262, 36);
            this.categoriesComboBox.TabIndex = 10;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.categoryLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.categoryLabel.Location = new System.Drawing.Point(6, 313);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(108, 23);
            this.categoryLabel.TabIndex = 9;
            this.categoryLabel.Text = "Category:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantityTextBox.DefaultText = "";
            this.quantityTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.quantityTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.quantityTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantityTextBox.DisabledState.Parent = this.quantityTextBox;
            this.quantityTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quantityTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantityTextBox.FocusedState.Parent = this.quantityTextBox;
            this.quantityTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quantityTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quantityTextBox.HoverState.Parent = this.quantityTextBox;
            this.quantityTextBox.Location = new System.Drawing.Point(117, 240);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.PasswordChar = '\0';
            this.quantityTextBox.PlaceholderText = "";
            this.quantityTextBox.SelectedText = "";
            this.quantityTextBox.ShadowDecoration.Parent = this.quantityTextBox;
            this.quantityTextBox.Size = new System.Drawing.Size(286, 31);
            this.quantityTextBox.TabIndex = 8;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceTextBox.DefaultText = "";
            this.priceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.priceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.priceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceTextBox.DisabledState.Parent = this.priceTextBox;
            this.priceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceTextBox.FocusedState.Parent = this.priceTextBox;
            this.priceTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.priceTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceTextBox.HoverState.Parent = this.priceTextBox;
            this.priceTextBox.Location = new System.Drawing.Point(117, 169);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.PasswordChar = '\0';
            this.priceTextBox.PlaceholderText = "";
            this.priceTextBox.SelectedText = "";
            this.priceTextBox.ShadowDecoration.Parent = this.priceTextBox;
            this.priceTextBox.Size = new System.Drawing.Size(286, 31);
            this.priceTextBox.TabIndex = 7;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.quantityLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quantityLabel.Location = new System.Drawing.Point(13, 240);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(98, 23);
            this.quantityLabel.TabIndex = 6;
            this.quantityLabel.Text = "Quantity:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.priceLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.priceLabel.Location = new System.Drawing.Point(13, 177);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(62, 23);
            this.priceLabel.TabIndex = 5;
            this.priceLabel.Text = "Price:";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productNameTextBox.DefaultText = "";
            this.productNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.productNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.productNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productNameTextBox.DisabledState.Parent = this.productNameTextBox;
            this.productNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productNameTextBox.FocusedState.Parent = this.productNameTextBox;
            this.productNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.productNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productNameTextBox.HoverState.Parent = this.productNameTextBox;
            this.productNameTextBox.Location = new System.Drawing.Point(117, 104);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.PasswordChar = '\0';
            this.productNameTextBox.PlaceholderText = "";
            this.productNameTextBox.SelectedText = "";
            this.productNameTextBox.ShadowDecoration.Parent = this.productNameTextBox;
            this.productNameTextBox.Size = new System.Drawing.Size(286, 31);
            this.productNameTextBox.TabIndex = 4;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.productNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productNameLabel.Location = new System.Drawing.Point(13, 112);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(76, 23);
            this.productNameLabel.TabIndex = 3;
            this.productNameLabel.Text = "Name:";
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.titleLable.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleLable.Location = new System.Drawing.Point(394, 18);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(202, 26);
            this.titleLable.TabIndex = 0;
            this.titleLable.Text = "Manage Products";
            // 
            // sellerButton
            // 
            this.sellerButton.FlatAppearance.BorderSize = 0;
            this.sellerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellerButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sellerButton.ForeColor = System.Drawing.Color.Black;
            this.sellerButton.Location = new System.Drawing.Point(23, 72);
            this.sellerButton.Name = "sellerButton";
            this.sellerButton.Size = new System.Drawing.Size(97, 34);
            this.sellerButton.TabIndex = 1;
            this.sellerButton.Text = "Sellers";
            this.sellerButton.UseVisualStyleBackColor = true;
            // 
            // categoryButton
            // 
            this.categoryButton.FlatAppearance.BorderSize = 0;
            this.categoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.categoryButton.ForeColor = System.Drawing.Color.Black;
            this.categoryButton.Location = new System.Drawing.Point(12, 139);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(135, 34);
            this.categoryButton.TabIndex = 2;
            this.categoryButton.Text = "Categories";
            this.categoryButton.UseVisualStyleBackColor = true;
            this.categoryButton.Click += new System.EventHandler(this.categoryButton_Click);
            // 
            // sellingButton
            // 
            this.sellingButton.FlatAppearance.BorderSize = 0;
            this.sellingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellingButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sellingButton.ForeColor = System.Drawing.Color.Black;
            this.sellingButton.Location = new System.Drawing.Point(23, 202);
            this.sellingButton.Name = "sellingButton";
            this.sellingButton.Size = new System.Drawing.Size(97, 34);
            this.sellingButton.TabIndex = 3;
            this.sellingButton.Text = "Selling";
            this.sellingButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeButton.ForeColor = System.Drawing.Color.Black;
            this.closeButton.Location = new System.Drawing.Point(1357, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(22, 34);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "x";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 558);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.sellingButton);
            this.Controls.Add(this.categoryButton);
            this.Controls.Add(this.sellerButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button sellerButton;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.Button sellingButton;
        private System.Windows.Forms.Button closeButton;
        private Guna.UI2.WinForms.Guna2TextBox productNameTextBox;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label priceLabel;
        private Guna.UI2.WinForms.Guna2TextBox quantityTextBox;
        private Guna.UI2.WinForms.Guna2TextBox priceTextBox;
        private System.Windows.Forms.Label categoryLabel;
        private Guna.UI2.WinForms.Guna2ComboBox categoriesComboBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView productsListView;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader productId;
        private System.Windows.Forms.ColumnHeader Available;
        private System.Windows.Forms.Label availableLbl;
        private Guna.UI2.WinForms.Guna2ComboBox availableComboBox1;
    }
}