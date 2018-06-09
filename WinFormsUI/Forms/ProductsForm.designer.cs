using ShopLibrary.Models;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            resources.ApplyResources(this.ShopSelectorCombo, "ShopSelectorCombo");
            this.ShopSelectorCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.ShopSelectorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShopSelectorCombo.FormattingEnabled = true;
            this.ShopSelectorCombo.Name = "ShopSelectorCombo";
            this.ButtonToolTip.SetToolTip(this.ShopSelectorCombo, resources.GetString("ShopSelectorCombo.ToolTip"));
            this.ShopSelectorCombo.SelectedIndexChanged += new System.EventHandler(this.ShopSelectorCombo_SelectedIndexChanged);
            // 
            // SelectShopLabel
            // 
            resources.ApplyResources(this.SelectShopLabel, "SelectShopLabel");
            this.SelectShopLabel.Name = "SelectShopLabel";
            this.ButtonToolTip.SetToolTip(this.SelectShopLabel, resources.GetString("SelectShopLabel.ToolTip"));
            this.SelectShopLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TitleLabel
            // 
            resources.ApplyResources(this.TitleLabel, "TitleLabel");
            this.TitleLabel.Name = "TitleLabel";
            this.ButtonToolTip.SetToolTip(this.TitleLabel, resources.GetString("TitleLabel.ToolTip"));
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // DeleteProductButton
            // 
            resources.ApplyResources(this.DeleteProductButton, "DeleteProductButton");
            this.DeleteProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.DeleteProductButton.FlatAppearance.BorderSize = 0;
            this.DeleteProductButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.DeleteProductButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(135)))));
            this.DeleteProductButton.ForeColor = System.Drawing.Color.White;
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.ButtonToolTip.SetToolTip(this.DeleteProductButton, resources.GetString("DeleteProductButton.ToolTip"));
            this.DeleteProductButton.UseVisualStyleBackColor = false;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // SearchProductText
            // 
            resources.ApplyResources(this.SearchProductText, "SearchProductText");
            this.SearchProductText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.SearchProductText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SearchProductText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.SearchProductText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchProductText.Name = "SearchProductText";
            this.ButtonToolTip.SetToolTip(this.SearchProductText, resources.GetString("SearchProductText.ToolTip"));
            this.SearchProductText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchProductText_KeyDown);
            // 
            // PrintButton
            // 
            resources.ApplyResources(this.PrintButton, "PrintButton");
            this.PrintButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(149)))), ((int)(((byte)(199)))));
            this.PrintButton.FlatAppearance.BorderSize = 0;
            this.PrintButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.PrintButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(184)))), ((int)(((byte)(217)))));
            this.PrintButton.ForeColor = System.Drawing.Color.White;
            this.PrintButton.Name = "PrintButton";
            this.ButtonToolTip.SetToolTip(this.PrintButton, resources.GetString("PrintButton.ToolTip"));
            this.PrintButton.UseVisualStyleBackColor = false;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // LowStockCheck
            // 
            resources.ApplyResources(this.LowStockCheck, "LowStockCheck");
            this.LowStockCheck.Name = "LowStockCheck";
            this.ButtonToolTip.SetToolTip(this.LowStockCheck, resources.GetString("LowStockCheck.ToolTip"));
            this.LowStockCheck.UseVisualStyleBackColor = true;
            this.LowStockCheck.CheckedChanged += new System.EventHandler(this.LowStockCheck_CheckedChanged);
            // 
            // ProductsDataGrid
            // 
            resources.ApplyResources(this.ProductsDataGrid, "ProductsDataGrid");
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductsDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProductsDataGrid.GridColor = System.Drawing.Color.WhiteSmoke;
            this.ProductsDataGrid.Name = "ProductsDataGrid";
            this.ProductsDataGrid.ReadOnly = true;
            this.ProductsDataGrid.RowHeadersVisible = false;
            this.ProductsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ButtonToolTip.SetToolTip(this.ProductsDataGrid, resources.GetString("ProductsDataGrid.ToolTip"));
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "ProductId";
            resources.ApplyResources(this.IdColumn, "IdColumn");
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "ProductName";
            resources.ApplyResources(this.NameColumn, "NameColumn");
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // StockColumn
            // 
            this.StockColumn.DataPropertyName = "GetTotalStock";
            resources.ApplyResources(this.StockColumn, "StockColumn");
            this.StockColumn.Name = "StockColumn";
            this.StockColumn.ReadOnly = true;
            // 
            // UnitColumn
            // 
            this.UnitColumn.DataPropertyName = "DefaultUnitName";
            resources.ApplyResources(this.UnitColumn, "UnitColumn");
            this.UnitColumn.Name = "UnitColumn";
            this.UnitColumn.ReadOnly = true;
            // 
            // RetailPriceColumn
            // 
            this.RetailPriceColumn.DataPropertyName = "GetRetailPrice";
            resources.ApplyResources(this.RetailPriceColumn, "RetailPriceColumn");
            this.RetailPriceColumn.Name = "RetailPriceColumn";
            this.RetailPriceColumn.ReadOnly = true;
            // 
            // WholeSalePriceColumn
            // 
            this.WholeSalePriceColumn.DataPropertyName = "GetWholeSalePrice";
            resources.ApplyResources(this.WholeSalePriceColumn, "WholeSalePriceColumn");
            this.WholeSalePriceColumn.Name = "WholeSalePriceColumn";
            this.WholeSalePriceColumn.ReadOnly = true;
            // 
            // PurchasePriceColumn
            // 
            this.PurchasePriceColumn.DataPropertyName = "GetPurchasePrice";
            resources.ApplyResources(this.PurchasePriceColumn, "PurchasePriceColumn");
            this.PurchasePriceColumn.Name = "PurchasePriceColumn";
            this.PurchasePriceColumn.ReadOnly = true;
            // 
            // CreatedColumn
            // 
            this.CreatedColumn.DataPropertyName = "Created";
            resources.ApplyResources(this.CreatedColumn, "CreatedColumn");
            this.CreatedColumn.Name = "CreatedColumn";
            this.CreatedColumn.ReadOnly = true;
            // 
            // CreatorColumn
            // 
            this.CreatorColumn.DataPropertyName = "Creator";
            resources.ApplyResources(this.CreatorColumn, "CreatorColumn");
            this.CreatorColumn.Name = "CreatorColumn";
            this.CreatorColumn.ReadOnly = true;
            // 
            // AddProductButton
            // 
            resources.ApplyResources(this.AddProductButton, "AddProductButton");
            this.AddProductButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.AddProductButton.FlatAppearance.BorderSize = 0;
            this.AddProductButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(170)))));
            this.AddProductButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.AddProductButton.ForeColor = System.Drawing.Color.White;
            this.AddProductButton.Name = "AddProductButton";
            this.ButtonToolTip.SetToolTip(this.AddProductButton, resources.GetString("AddProductButton.ToolTip"));
            this.AddProductButton.UseVisualStyleBackColor = false;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // EditUpdateButton
            // 
            resources.ApplyResources(this.EditUpdateButton, "EditUpdateButton");
            this.EditUpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.EditUpdateButton.FlatAppearance.BorderSize = 0;
            this.EditUpdateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.EditUpdateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            this.EditUpdateButton.ForeColor = System.Drawing.Color.White;
            this.EditUpdateButton.Name = "EditUpdateButton";
            this.ButtonToolTip.SetToolTip(this.EditUpdateButton, resources.GetString("EditUpdateButton.ToolTip"));
            this.EditUpdateButton.UseVisualStyleBackColor = false;
            this.EditUpdateButton.Click += new System.EventHandler(this.EditUpdateButton_Click);
            // 
            // SearchIcon
            // 
            resources.ApplyResources(this.SearchIcon, "SearchIcon");
            this.SearchIcon.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Search_96px;
            this.SearchIcon.Name = "SearchIcon";
            this.SearchIcon.TabStop = false;
            this.ButtonToolTip.SetToolTip(this.SearchIcon, resources.GetString("SearchIcon.ToolTip"));
            // 
            // ReloadProducts
            // 
            resources.ApplyResources(this.ReloadProducts, "ReloadProducts");
            this.ReloadProducts.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Sync_500px;
            this.ReloadProducts.FlatAppearance.BorderSize = 0;
            this.ReloadProducts.Name = "ReloadProducts";
            this.ButtonToolTip.SetToolTip(this.ReloadProducts, resources.GetString("ReloadProducts.ToolTip"));
            this.ReloadProducts.UseVisualStyleBackColor = true;
            this.ReloadProducts.Click += new System.EventHandler(this.ReloadProducts_Click);
            // 
            // ProductsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ProductsForm";
            this.ButtonToolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
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