namespace FormsApp.Forms
{
    partial class SellerForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listViewCategory = new System.Windows.Forms.ListView();
            this.ProductColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuantityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AvailableColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filterBox = new System.Windows.Forms.ComboBox();
            this.filterLabel = new System.Windows.Forms.Label();
            this.showItemsCheckBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.showItemsCheckBox1);
            this.panel1.Controls.Add(this.filterLabel);
            this.panel1.Controls.Add(this.filterBox);
            this.panel1.Controls.Add(this.listViewCategory);
            this.panel1.Location = new System.Drawing.Point(55, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 426);
            this.panel1.TabIndex = 0;
            // 
            // listViewCategory
            // 
            this.listViewCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductColumn,
            this.QuantityColumn,
            this.PriceColumn,
            this.AvailableColumn});
            this.listViewCategory.HideSelection = false;
            this.listViewCategory.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewCategory.Location = new System.Drawing.Point(349, 55);
            this.listViewCategory.Name = "listViewCategory";
            this.listViewCategory.Size = new System.Drawing.Size(613, 359);
            this.listViewCategory.TabIndex = 16;
            this.listViewCategory.UseCompatibleStateImageBehavior = false;
            this.listViewCategory.View = System.Windows.Forms.View.Details;
            // 
            // ProductColumn
            // 
            this.ProductColumn.Text = "Product";
            this.ProductColumn.Width = 176;
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.Text = "Quantity";
            this.QuantityColumn.Width = 150;
            // 
            // PriceColumn
            // 
            this.PriceColumn.Text = "Price";
            this.PriceColumn.Width = 130;
            // 
            // AvailableColumn
            // 
            this.AvailableColumn.Text = "Available";
            this.AvailableColumn.Width = 149;
            // 
            // filterBox
            // 
            this.filterBox.FormattingEnabled = true;
            this.filterBox.Location = new System.Drawing.Point(448, 15);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(121, 24);
            this.filterBox.TabIndex = 17;
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filterLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filterLabel.Location = new System.Drawing.Point(369, 15);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(54, 23);
            this.filterLabel.TabIndex = 19;
            this.filterLabel.Text = "Filter";
            // 
            // showItemsCheckBox1
            // 
            this.showItemsCheckBox1.AutoSize = true;
            this.showItemsCheckBox1.Location = new System.Drawing.Point(658, 18);
            this.showItemsCheckBox1.Name = "showItemsCheckBox1";
            this.showItemsCheckBox1.Size = new System.Drawing.Size(169, 20);
            this.showItemsCheckBox1.TabIndex = 20;
            this.showItemsCheckBox1.Text = "Display available items";
            this.showItemsCheckBox1.UseVisualStyleBackColor = true;
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 548);
            this.Controls.Add(this.panel1);
            this.Name = "SellerForm";
            this.Text = "SellerForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listViewCategory;
        private System.Windows.Forms.ColumnHeader ProductColumn;
        private System.Windows.Forms.ColumnHeader QuantityColumn;
        private System.Windows.Forms.ColumnHeader PriceColumn;
        private System.Windows.Forms.ComboBox filterBox;
        private System.Windows.Forms.ColumnHeader AvailableColumn;
        private System.Windows.Forms.CheckBox showItemsCheckBox1;
        private System.Windows.Forms.Label filterLabel;
    }
}