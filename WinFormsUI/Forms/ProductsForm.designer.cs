namespace WinFormsUI.Forms
{
    partial class ProductsForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            this.ShopSelectorCombo = new System.Windows.Forms.ComboBox();
            this.SelectShopLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.SearchProductText = new System.Windows.Forms.TextBox();
            this.PrintButton = new System.Windows.Forms.Button();
            this.LowStockCheck = new System.Windows.Forms.CheckBox();
            this.ProductsDataGrid = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RetailPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WholeSalePriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.EditUpdateButton = new System.Windows.Forms.Button();
            this.SearchIcon = new System.Windows.Forms.PictureBox();
            this.ReloadProducts = new System.Windows.Forms.Button();
            this.ButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // ShopSelectorCombo
            // 
            this.ShopSelectorCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ShopSelectorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShopSelectorCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopSelectorCombo.FormattingEnabled = true;
            this.ShopSelectorCombo.Location = new System.Drawing.Point(111, 69);
            this.ShopSelectorCombo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ShopSelectorCombo.Name = "ShopSelectorCombo";
            this.ShopSelectorCombo.Size = new System.Drawing.Size(504, 29);
            this.ShopSelectorCombo.TabIndex = 2;
            this.ShopSelectorCombo.SelectedIndexChanged += new System.EventHandler(this.ShopSelectorCombo_SelectedIndexChanged);
            // 
            // SelectShopLabel
            // 
            this.SelectShopLabel.AutoSize = true;
            this.SelectShopLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectShopLabel.Location = new System.Drawing.Point(13, 72);
            this.SelectShopLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectShopLabel.Name = "SelectShopLabel";
            this.SelectShopLabel.Size = new System.Drawing.Size(91, 21);
            this.SelectShopLabel.TabIndex = 1;
            this.SelectShopLabel.Text = "Select Shop";
            this.SelectShopLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semi Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(8, 8);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(160, 47);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Inventory";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.DeleteProductButton.FlatAppearance.BorderSize = 0;
            this.DeleteProductButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.DeleteProductButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(135)))));
            this.DeleteProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteProductButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteProductButton.ForeColor = System.Drawing.Color.White;
            this.DeleteProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteProductButton.Location = new System.Drawing.Point(17, 629);
            this.DeleteProductButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(536, 42);
            this.DeleteProductButton.TabIndex = 8;
            this.DeleteProductButton.Text = "Delete Selected Product(s)";
            this.DeleteProductButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteProductButton.UseVisualStyleBackColor = false;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // SearchProductText
            // 
            this.SearchProductText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.SearchProductText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SearchProductText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.SearchProductText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchProductText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchProductText.Location = new System.Drawing.Point(777, 72);
            this.SearchProductText.Margin = new System.Windows.Forms.Padding(4);
            this.SearchProductText.Name = "SearchProductText";
            this.SearchProductText.Size = new System.Drawing.Size(338, 22);
            this.SearchProductText.TabIndex = 4;
            this.SearchProductText.TextChanged += new System.EventHandler(this.SearchProductText_TextChanged);
            // 
            // PrintButton
            // 
            this.PrintButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(149)))), ((int)(((byte)(199)))));
            this.PrintButton.FlatAppearance.BorderSize = 0;
            this.PrintButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.PrintButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(184)))), ((int)(((byte)(217)))));
            this.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintButton.ForeColor = System.Drawing.Color.White;
            this.PrintButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintButton.Location = new System.Drawing.Point(16, 679);
            this.PrintButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(536, 42);
            this.PrintButton.TabIndex = 9;
            this.PrintButton.Text = "Print";
            this.PrintButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PrintButton.UseVisualStyleBackColor = false;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // LowStockCheck
            // 
            this.LowStockCheck.AutoSize = true;
            this.LowStockCheck.Location = new System.Drawing.Point(647, 71);
            this.LowStockCheck.Margin = new System.Windows.Forms.Padding(4);
            this.LowStockCheck.Name = "LowStockCheck";
            this.LowStockCheck.Size = new System.Drawing.Size(99, 25);
            this.LowStockCheck.TabIndex = 3;
            this.LowStockCheck.Text = "Low Stock";
            this.LowStockCheck.UseVisualStyleBackColor = true;
            this.LowStockCheck.CheckedChanged += new System.EventHandler(this.LowStockCheck_CheckedChanged);
            // 
            // ProductsDataGrid
            // 
            this.ProductsDataGrid.AllowUserToAddRows = false;
            this.ProductsDataGrid.AllowUserToDeleteRows = false;
            this.ProductsDataGrid.AllowUserToOrderColumns = true;
            this.ProductsDataGrid.AllowUserToResizeRows = false;
            this.ProductsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ProductsDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ProductsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductsDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ProductsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.NameColumn,
            this.StockColumn,
            this.UnitColumn,
            this.RetailPriceColumn,
            this.WholeSalePriceColumn,
            this.PurchasePriceColumn,
            this.CreatedColumn,
            this.CreatorColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductsDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProductsDataGrid.GridColor = System.Drawing.Color.WhiteSmoke;
            this.ProductsDataGrid.Location = new System.Drawing.Point(17, 104);
            this.ProductsDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.ProductsDataGrid.Name = "ProductsDataGrid";
            this.ProductsDataGrid.ReadOnly = true;
            this.ProductsDataGrid.RowHeadersVisible = false;
            this.ProductsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsDataGrid.Size = new System.Drawing.Size(1098, 515);
            this.ProductsDataGrid.TabIndex = 5;
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "ProductId";
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Width = 48;
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "ProductName";
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 77;
            // 
            // StockColumn
            // 
            this.StockColumn.DataPropertyName = "GetTotalStock";
            this.StockColumn.HeaderText = "Stock";
            this.StockColumn.Name = "StockColumn";
            this.StockColumn.ReadOnly = true;
            this.StockColumn.Width = 72;
            // 
            // UnitColumn
            // 
            this.UnitColumn.DataPropertyName = "GetDefaultUnitName";
            this.UnitColumn.HeaderText = "Unit";
            this.UnitColumn.Name = "UnitColumn";
            this.UnitColumn.ReadOnly = true;
            this.UnitColumn.Width = 64;
            // 
            // RetailPriceColumn
            // 
            this.RetailPriceColumn.DataPropertyName = "GetRetailPrice";
            this.RetailPriceColumn.HeaderText = "Retail P.";
            this.RetailPriceColumn.Name = "RetailPriceColumn";
            this.RetailPriceColumn.ReadOnly = true;
            this.RetailPriceColumn.Width = 90;
            // 
            // WholeSalePriceColumn
            // 
            this.WholeSalePriceColumn.DataPropertyName = "GetWholeSalePrice";
            this.WholeSalePriceColumn.HeaderText = "Whole S. P";
            this.WholeSalePriceColumn.Name = "WholeSalePriceColumn";
            this.WholeSalePriceColumn.ReadOnly = true;
            this.WholeSalePriceColumn.Width = 109;
            // 
            // PurchasePriceColumn
            // 
            this.PurchasePriceColumn.DataPropertyName = "GetPurchasePrice";
            this.PurchasePriceColumn.HeaderText = "Purchase P.";
            this.PurchasePriceColumn.Name = "PurchasePriceColumn";
            this.PurchasePriceColumn.ReadOnly = true;
            this.PurchasePriceColumn.Width = 114;
            // 
            // CreatedColumn
            // 
            this.CreatedColumn.DataPropertyName = "Created";
            this.CreatedColumn.HeaderText = "Added on";
            this.CreatedColumn.Name = "CreatedColumn";
            this.CreatedColumn.ReadOnly = true;
            this.CreatedColumn.Width = 102;
            // 
            // CreatorColumn
            // 
            this.CreatorColumn.DataPropertyName = "Creator";
            this.CreatorColumn.HeaderText = "Added by";
            this.CreatorColumn.Name = "CreatorColumn";
            this.CreatorColumn.ReadOnly = true;
            this.CreatorColumn.Width = 101;
            // 
            // AddProductButton
            // 
            this.AddProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.AddProductButton.FlatAppearance.BorderSize = 0;
            this.AddProductButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(170)))));
            this.AddProductButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.AddProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProductButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductButton.ForeColor = System.Drawing.Color.White;
            this.AddProductButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddProductButton.Location = new System.Drawing.Point(561, 679);
            this.AddProductButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(554, 42);
            this.AddProductButton.TabIndex = 7;
            this.AddProductButton.Text = "+ Add New Product";
            this.AddProductButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddProductButton.UseVisualStyleBackColor = false;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // EditUpdateButton
            // 
            this.EditUpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.EditUpdateButton.FlatAppearance.BorderSize = 0;
            this.EditUpdateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.EditUpdateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            this.EditUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditUpdateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditUpdateButton.ForeColor = System.Drawing.Color.White;
            this.EditUpdateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditUpdateButton.Location = new System.Drawing.Point(561, 629);
            this.EditUpdateButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.EditUpdateButton.Name = "EditUpdateButton";
            this.EditUpdateButton.Size = new System.Drawing.Size(554, 42);
            this.EditUpdateButton.TabIndex = 6;
            this.EditUpdateButton.Text = "Edit / Update Selected Product";
            this.EditUpdateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditUpdateButton.UseVisualStyleBackColor = false;
            this.EditUpdateButton.Click += new System.EventHandler(this.EditUpdateButton_Click);
            // 
            // SearchIcon
            // 
            this.SearchIcon.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Search_96px;
            this.SearchIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchIcon.ErrorImage = null;
            this.SearchIcon.InitialImage = null;
            this.SearchIcon.Location = new System.Drawing.Point(750, 71);
            this.SearchIcon.Margin = new System.Windows.Forms.Padding(4);
            this.SearchIcon.Name = "SearchIcon";
            this.SearchIcon.Size = new System.Drawing.Size(25, 25);
            this.SearchIcon.TabIndex = 89;
            this.SearchIcon.TabStop = false;
            // 
            // ReloadProducts
            // 
            this.ReloadProducts.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Sync_500px;
            this.ReloadProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReloadProducts.FlatAppearance.BorderSize = 0;
            this.ReloadProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReloadProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReloadProducts.Location = new System.Drawing.Point(1099, 3);
            this.ReloadProducts.Name = "ReloadProducts";
            this.ReloadProducts.Size = new System.Drawing.Size(29, 29);
            this.ReloadProducts.TabIndex = 10;
            this.ButtonToolTip.SetToolTip(this.ReloadProducts, "Force refresh products from database");
            this.ReloadProducts.UseVisualStyleBackColor = true;
            this.ReloadProducts.Click += new System.EventHandler(this.ReloadProducts_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1131, 734);
            this.Controls.Add(this.ReloadProducts);
            this.Controls.Add(this.EditUpdateButton);
            this.Controls.Add(this.SearchProductText);
            this.Controls.Add(this.SearchIcon);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.ProductsDataGrid);
            this.Controls.Add(this.LowStockCheck);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.DeleteProductButton);
            this.Controls.Add(this.ShopSelectorCombo);
            this.Controls.Add(this.SelectShopLabel);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ShopSelectorCombo;
        private System.Windows.Forms.Label SelectShopLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.TextBox SearchProductText;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.CheckBox LowStockCheck;
        private System.Windows.Forms.DataGridView ProductsDataGrid;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.PictureBox SearchIcon;
        private System.Windows.Forms.Button EditUpdateButton;
        private System.Windows.Forms.Button ReloadProducts;
        private System.Windows.Forms.ToolTip ButtonToolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RetailPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WholeSalePriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatorColumn;
    }
}