
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
            this.productNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.productIdTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.idLable = new System.Windows.Forms.Label();
            this.titleLable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.descriptionTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
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
            this.productNameTextBox.Location = new System.Drawing.Point(126, 177);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.PasswordChar = '\0';
            this.productNameTextBox.PlaceholderText = "";
            this.productNameTextBox.SelectedText = "";
            this.productNameTextBox.ShadowDecoration.Parent = this.productNameTextBox;
            this.productNameTextBox.Size = new System.Drawing.Size(286, 31);
            this.productNameTextBox.TabIndex = 4;
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
            // productIdTextBox
            // 
            this.productIdTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productIdTextBox.DefaultText = "";
            this.productIdTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.productIdTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.productIdTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productIdTextBox.DisabledState.Parent = this.productIdTextBox;
            this.productIdTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productIdTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productIdTextBox.FocusedState.Parent = this.productIdTextBox;
            this.productIdTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.productIdTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.productIdTextBox.HoverState.Parent = this.productIdTextBox;
            this.productIdTextBox.Location = new System.Drawing.Point(93, 119);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.PasswordChar = '\0';
            this.productIdTextBox.PlaceholderText = "";
            this.productIdTextBox.SelectedText = "";
            this.productIdTextBox.ShadowDecoration.Parent = this.productIdTextBox;
            this.productIdTextBox.Size = new System.Drawing.Size(286, 31);
            this.productIdTextBox.TabIndex = 2;
            // 
            // idLable
            // 
            this.idLable.AutoSize = true;
            this.idLable.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idLable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.idLable.Location = new System.Drawing.Point(22, 119);
            this.idLable.Name = "idLable";
            this.idLable.Size = new System.Drawing.Size(34, 23);
            this.idLable.TabIndex = 1;
            this.idLable.Text = "Id:";
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
            this.panel1.Controls.Add(this.productGridView);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Controls.Add(this.descriptionLabel);
            this.panel1.Controls.Add(this.productNameTextBox);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.productIdTextBox);
            this.panel1.Controls.Add(this.idLable);
            this.panel1.Controls.Add(this.titleLable);
            this.panel1.Location = new System.Drawing.Point(50, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 508);
            this.panel1.TabIndex = 5;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descriptionTextBox.DefaultText = "";
            this.descriptionTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.descriptionTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.descriptionTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descriptionTextBox.DisabledState.Parent = this.descriptionTextBox;
            this.descriptionTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.descriptionTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.descriptionTextBox.FocusedState.Parent = this.descriptionTextBox;
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.descriptionTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.descriptionTextBox.HoverState.Parent = this.descriptionTextBox;
            this.descriptionTextBox.Location = new System.Drawing.Point(126, 239);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.PasswordChar = '\0';
            this.descriptionTextBox.PlaceholderText = "";
            this.descriptionTextBox.SelectedText = "";
            this.descriptionTextBox.ShadowDecoration.Parent = this.descriptionTextBox;
            this.descriptionTextBox.Size = new System.Drawing.Size(286, 31);
            this.descriptionTextBox.TabIndex = 7;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.descriptionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.descriptionLabel.Location = new System.Drawing.Point(3, 239);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(117, 23);
            this.descriptionLabel.TabIndex = 5;
            this.descriptionLabel.Text = "Description";
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 558);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellerForm";
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
        private Guna.UI2.WinForms.Guna2TextBox productNameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private Guna.UI2.WinForms.Guna2TextBox productIdTextBox;
        private System.Windows.Forms.Label idLable;
        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox descriptionTextBox;
        private System.Windows.Forms.Label descriptionLabel;
    }
}