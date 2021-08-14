
namespace FormsApp.Forms
{
    partial class CategoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.closeButton = new System.Windows.Forms.Button();
            this.productGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.categoryNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.titleLable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.categoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeButton.ForeColor = System.Drawing.Color.Black;
            this.closeButton.Location = new System.Drawing.Point(1180, 13);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(22, 34);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "x";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // productGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.productGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.productGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productGridView.BackgroundColor = System.Drawing.Color.White;
            this.productGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.productGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.productGridView.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.productGridView.EnableHeadersVisualStyles = false;
            this.productGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.productGridView.Location = new System.Drawing.Point(444, 114);
            this.productGridView.Name = "productGridView";
            this.productGridView.RowHeadersVisible = false;
            this.productGridView.RowHeadersWidth = 51;
            this.productGridView.RowTemplate.Height = 24;
            this.productGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productGridView.Size = new System.Drawing.Size(563, 374);
            this.productGridView.TabIndex = 13;
            this.productGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.productGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.productGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.productGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.productGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.productGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.productGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.productGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.productGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.productGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.productGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.productGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.productGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.productGridView.ThemeStyle.ReadOnly = false;
            this.productGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.productGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.productGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.productGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.productGridView.ThemeStyle.RowsStyle.Height = 24;
            this.productGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.productGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteButton.ForeColor = System.Drawing.Color.Black;
            this.deleteButton.Location = new System.Drawing.Point(282, 454);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(97, 34);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editButton.ForeColor = System.Drawing.Color.Black;
            this.editButton.Location = new System.Drawing.Point(149, 454);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(97, 34);
            this.editButton.TabIndex = 11;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addButton.ForeColor = System.Drawing.Color.Black;
            this.addButton.Location = new System.Drawing.Point(26, 454);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(97, 34);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.categoryNameTextBox.DefaultText = "";
            this.categoryNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.categoryNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.categoryNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categoryNameTextBox.DisabledState.Parent = this.categoryNameTextBox;
            this.categoryNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categoryNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoryNameTextBox.FocusedState.Parent = this.categoryNameTextBox;
            this.categoryNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.categoryNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoryNameTextBox.HoverState.Parent = this.categoryNameTextBox;
            this.categoryNameTextBox.Location = new System.Drawing.Point(126, 177);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.PasswordChar = '\0';
            this.categoryNameTextBox.PlaceholderText = "";
            this.categoryNameTextBox.SelectedText = "";
            this.categoryNameTextBox.ShadowDecoration.Parent = this.categoryNameTextBox;
            this.categoryNameTextBox.Size = new System.Drawing.Size(286, 31);
            this.categoryNameTextBox.TabIndex = 4;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameLabel.Location = new System.Drawing.Point(3, 177);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(76, 23);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name:";
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.titleLable.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleLable.Location = new System.Drawing.Point(394, 18);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(172, 26);
            this.titleLable.TabIndex = 0;
            this.titleLable.Text = "Manage Seller ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.categoryLabel);
            this.panel1.Controls.Add(this.productGridView);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.categoryNameTextBox);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.titleLable);
            this.panel1.Location = new System.Drawing.Point(50, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 508);
            this.panel1.TabIndex = 5;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.categoryLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.categoryLabel.Location = new System.Drawing.Point(144, 69);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(173, 26);
            this.categoryLabel.TabIndex = 14;
            this.categoryLabel.Text = "Category Form";
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 558);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerForm";
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private Guna.UI2.WinForms.Guna2DataGridView productGridView;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private Guna.UI2.WinForms.Guna2TextBox categoryNameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label categoryLabel;
    }
}