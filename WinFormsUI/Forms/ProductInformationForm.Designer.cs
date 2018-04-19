namespace WinFormsUI.Forms {
    partial class ProductInformationForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInformationForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ProductIdLabel = new System.Windows.Forms.Label();
            this.ProductIdText = new System.Windows.Forms.TextBox();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductNameText = new System.Windows.Forms.TextBox();
            this.StockInShopLabel = new System.Windows.Forms.Label();
            this.StockInGodownLabel = new System.Windows.Forms.Label();
            this.TotalStockLabel = new System.Windows.Forms.Label();
            this.AlertAtLabel = new System.Windows.Forms.Label();
            this.PurchasePriceLabel = new System.Windows.Forms.Label();
            this.PurchasePriceText = new System.Windows.Forms.TextBox();
            this.RetailPriceLabel = new System.Windows.Forms.Label();
            this.RetailPriceText = new System.Windows.Forms.TextBox();
            this.WholeSaleLabel = new System.Windows.Forms.Label();
            this.WholeSalePriceText = new System.Windows.Forms.TextBox();
            this.MrpLabel = new System.Windows.Forms.Label();
            this.MrpText = new System.Windows.Forms.TextBox();
            this.AddedOnDateTime = new System.Windows.Forms.DateTimePicker();
            this.AddedOnLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SpecificationLabel = new System.Windows.Forms.Label();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.CategorySelectorCombo = new System.Windows.Forms.ComboBox();
            this.NotesText = new System.Windows.Forms.RichTextBox();
            this.SpecificationSelectorCombo = new System.Windows.Forms.ComboBox();
            this.TotalStockText = new System.Windows.Forms.TextBox();
            this.StockInShopText = new System.Windows.Forms.TextBox();
            this.AlertAtText = new System.Windows.Forms.TextBox();
            this.StockInGodownText = new System.Windows.Forms.TextBox();
            this.ShopSelectorCombo = new System.Windows.Forms.ComboBox();
            this.SelectShopLabel = new System.Windows.Forms.Label();
            this.MoveFromGodownText = new System.Windows.Forms.TextBox();
            this.MoveFromShopText = new System.Windows.Forms.TextBox();
            this.ShopToGodownLabel = new System.Windows.Forms.Label();
            this.MoveButton = new System.Windows.Forms.Button();
            this.GodownToShopLabel = new System.Windows.Forms.Label();
            this.UnitsDataGrid = new System.Windows.Forms.DataGridView();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddUnitButton = new System.Windows.Forms.Button();
            this.UnitNameText = new System.Windows.Forms.TextBox();
            this.WeightText = new System.Windows.Forms.TextBox();
            this.UnitNameLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.DeleteUnitButton = new System.Windows.Forms.Button();
            this.MoveProductsGroupBox = new System.Windows.Forms.GroupBox();
            this.UnitsGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ManufacturerText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UnitsDataGrid)).BeginInit();
            this.MoveProductsGroupBox.SuspendLayout();
            this.UnitsGroupBox.SuspendLayout();
            this.ProductInformationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            resources.ApplyResources(this.TitleLabel, "TitleLabel");
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // ProductIdLabel
            // 
            resources.ApplyResources(this.ProductIdLabel, "ProductIdLabel");
            this.ProductIdLabel.Name = "ProductIdLabel";
            this.ProductIdLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // ProductIdText
            // 
            resources.ApplyResources(this.ProductIdText, "ProductIdText");
            this.ProductIdText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ProductIdText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductIdText.Name = "ProductIdText";
            // 
            // ProductNameLabel
            // 
            resources.ApplyResources(this.ProductNameLabel, "ProductNameLabel");
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // ProductNameText
            // 
            resources.ApplyResources(this.ProductNameText, "ProductNameText");
            this.ProductNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ProductNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductNameText.Name = "ProductNameText";
            // 
            // StockInShopLabel
            // 
            resources.ApplyResources(this.StockInShopLabel, "StockInShopLabel");
            this.StockInShopLabel.Name = "StockInShopLabel";
            this.StockInShopLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // StockInGodownLabel
            // 
            resources.ApplyResources(this.StockInGodownLabel, "StockInGodownLabel");
            this.StockInGodownLabel.Name = "StockInGodownLabel";
            this.StockInGodownLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TotalStockLabel
            // 
            resources.ApplyResources(this.TotalStockLabel, "TotalStockLabel");
            this.TotalStockLabel.Name = "TotalStockLabel";
            this.TotalStockLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // AlertAtLabel
            // 
            resources.ApplyResources(this.AlertAtLabel, "AlertAtLabel");
            this.AlertAtLabel.Name = "AlertAtLabel";
            this.AlertAtLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // PurchasePriceLabel
            // 
            resources.ApplyResources(this.PurchasePriceLabel, "PurchasePriceLabel");
            this.PurchasePriceLabel.Name = "PurchasePriceLabel";
            this.PurchasePriceLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // PurchasePriceText
            // 
            resources.ApplyResources(this.PurchasePriceText, "PurchasePriceText");
            this.PurchasePriceText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PurchasePriceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PurchasePriceText.Name = "PurchasePriceText";
            this.PurchasePriceText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // RetailPriceLabel
            // 
            resources.ApplyResources(this.RetailPriceLabel, "RetailPriceLabel");
            this.RetailPriceLabel.Name = "RetailPriceLabel";
            this.RetailPriceLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // RetailPriceText
            // 
            resources.ApplyResources(this.RetailPriceText, "RetailPriceText");
            this.RetailPriceText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RetailPriceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RetailPriceText.Name = "RetailPriceText";
            this.RetailPriceText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // WholeSaleLabel
            // 
            resources.ApplyResources(this.WholeSaleLabel, "WholeSaleLabel");
            this.WholeSaleLabel.Name = "WholeSaleLabel";
            this.WholeSaleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // WholeSalePriceText
            // 
            resources.ApplyResources(this.WholeSalePriceText, "WholeSalePriceText");
            this.WholeSalePriceText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.WholeSalePriceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WholeSalePriceText.Name = "WholeSalePriceText";
            this.WholeSalePriceText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // MrpLabel
            // 
            resources.ApplyResources(this.MrpLabel, "MrpLabel");
            this.MrpLabel.Name = "MrpLabel";
            this.MrpLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // MrpText
            // 
            resources.ApplyResources(this.MrpText, "MrpText");
            this.MrpText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MrpText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MrpText.Name = "MrpText";
            this.MrpText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // AddedOnDateTime
            // 
            resources.ApplyResources(this.AddedOnDateTime, "AddedOnDateTime");
            this.AddedOnDateTime.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.AddedOnDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AddedOnDateTime.Name = "AddedOnDateTime";
            // 
            // AddedOnLabel
            // 
            resources.ApplyResources(this.AddedOnLabel, "AddedOnLabel");
            this.AddedOnLabel.Name = "AddedOnLabel";
            this.AddedOnLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // CategoryLabel
            // 
            resources.ApplyResources(this.CategoryLabel, "CategoryLabel");
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // SaveButton
            // 
            resources.ApplyResources(this.SaveButton, "SaveButton");
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SpecificationLabel
            // 
            resources.ApplyResources(this.SpecificationLabel, "SpecificationLabel");
            this.SpecificationLabel.Name = "SpecificationLabel";
            this.SpecificationLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // NotesLabel
            // 
            resources.ApplyResources(this.NotesLabel, "NotesLabel");
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // CategorySelectorCombo
            // 
            resources.ApplyResources(this.CategorySelectorCombo, "CategorySelectorCombo");
            this.CategorySelectorCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CategorySelectorCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CategorySelectorCombo.BackColor = System.Drawing.Color.White;
            this.CategorySelectorCombo.FormattingEnabled = true;
            this.CategorySelectorCombo.Name = "CategorySelectorCombo";
            this.CategorySelectorCombo.SelectedIndexChanged += new System.EventHandler(this.CategorySelectorCombo_SelectedIndexChanged);
            // 
            // NotesText
            // 
            resources.ApplyResources(this.NotesText, "NotesText");
            this.NotesText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NotesText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NotesText.Name = "NotesText";
            // 
            // SpecificationSelectorCombo
            // 
            resources.ApplyResources(this.SpecificationSelectorCombo, "SpecificationSelectorCombo");
            this.SpecificationSelectorCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SpecificationSelectorCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SpecificationSelectorCombo.BackColor = System.Drawing.Color.White;
            this.SpecificationSelectorCombo.FormattingEnabled = true;
            this.SpecificationSelectorCombo.Name = "SpecificationSelectorCombo";
            // 
            // TotalStockText
            // 
            resources.ApplyResources(this.TotalStockText, "TotalStockText");
            this.TotalStockText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TotalStockText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalStockText.Name = "TotalStockText";
            this.TotalStockText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // StockInShopText
            // 
            resources.ApplyResources(this.StockInShopText, "StockInShopText");
            this.StockInShopText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StockInShopText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StockInShopText.Name = "StockInShopText";
            this.StockInShopText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            this.StockInShopText.Leave += new System.EventHandler(this.TotalStockUpdate);
            // 
            // AlertAtText
            // 
            resources.ApplyResources(this.AlertAtText, "AlertAtText");
            this.AlertAtText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AlertAtText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AlertAtText.Name = "AlertAtText";
            this.AlertAtText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // StockInGodownText
            // 
            resources.ApplyResources(this.StockInGodownText, "StockInGodownText");
            this.StockInGodownText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StockInGodownText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StockInGodownText.Name = "StockInGodownText";
            this.StockInGodownText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            this.StockInGodownText.Leave += new System.EventHandler(this.TotalStockUpdate);
            // 
            // ShopSelectorCombo
            // 
            resources.ApplyResources(this.ShopSelectorCombo, "ShopSelectorCombo");
            this.ShopSelectorCombo.BackColor = System.Drawing.Color.White;
            this.ShopSelectorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShopSelectorCombo.FormattingEnabled = true;
            this.ShopSelectorCombo.Name = "ShopSelectorCombo";
            // 
            // SelectShopLabel
            // 
            resources.ApplyResources(this.SelectShopLabel, "SelectShopLabel");
            this.SelectShopLabel.Name = "SelectShopLabel";
            this.SelectShopLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // MoveFromGodownText
            // 
            resources.ApplyResources(this.MoveFromGodownText, "MoveFromGodownText");
            this.MoveFromGodownText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MoveFromGodownText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MoveFromGodownText.Name = "MoveFromGodownText";
            this.MoveFromGodownText.TextChanged += new System.EventHandler(this.MoveFromGodownText_TextChanged);
            this.MoveFromGodownText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // MoveFromShopText
            // 
            resources.ApplyResources(this.MoveFromShopText, "MoveFromShopText");
            this.MoveFromShopText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MoveFromShopText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MoveFromShopText.Name = "MoveFromShopText";
            this.MoveFromShopText.TextChanged += new System.EventHandler(this.MoveFromShopText_TextChanged);
            this.MoveFromShopText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // ShopToGodownLabel
            // 
            resources.ApplyResources(this.ShopToGodownLabel, "ShopToGodownLabel");
            this.ShopToGodownLabel.Name = "ShopToGodownLabel";
            this.ShopToGodownLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // MoveButton
            // 
            resources.ApplyResources(this.MoveButton, "MoveButton");
            this.MoveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.MoveButton.FlatAppearance.BorderSize = 0;
            this.MoveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.MoveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            this.MoveButton.ForeColor = System.Drawing.Color.White;
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.UseVisualStyleBackColor = false;
            this.MoveButton.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // GodownToShopLabel
            // 
            resources.ApplyResources(this.GodownToShopLabel, "GodownToShopLabel");
            this.GodownToShopLabel.Name = "GodownToShopLabel";
            this.GodownToShopLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // UnitsDataGrid
            // 
            resources.ApplyResources(this.UnitsDataGrid, "UnitsDataGrid");
            this.UnitsDataGrid.AllowUserToAddRows = false;
            this.UnitsDataGrid.AllowUserToDeleteRows = false;
            this.UnitsDataGrid.AllowUserToOrderColumns = true;
            this.UnitsDataGrid.AllowUserToResizeRows = false;
            this.UnitsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.UnitsDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.UnitsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UnitsDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.UnitsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UnitsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.UnitsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UnitsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Weight,
            this.UnitName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UnitsDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.UnitsDataGrid.GridColor = System.Drawing.Color.WhiteSmoke;
            this.UnitsDataGrid.Name = "UnitsDataGrid";
            this.UnitsDataGrid.ReadOnly = true;
            this.UnitsDataGrid.RowHeadersVisible = false;
            this.UnitsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // Weight
            // 
            this.Weight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Weight.DataPropertyName = "Weight";
            resources.ApplyResources(this.Weight, "Weight");
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            // 
            // UnitName
            // 
            this.UnitName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UnitName.DataPropertyName = "UnitName";
            resources.ApplyResources(this.UnitName, "UnitName");
            this.UnitName.Name = "UnitName";
            this.UnitName.ReadOnly = true;
            // 
            // AddUnitButton
            // 
            resources.ApplyResources(this.AddUnitButton, "AddUnitButton");
            this.AddUnitButton.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Plus_Math_96px_1;
            this.AddUnitButton.FlatAppearance.BorderSize = 0;
            this.AddUnitButton.Name = "AddUnitButton";
            this.AddUnitButton.UseVisualStyleBackColor = true;
            this.AddUnitButton.Click += new System.EventHandler(this.AddUnitButton_Click);
            // 
            // UnitNameText
            // 
            resources.ApplyResources(this.UnitNameText, "UnitNameText");
            this.UnitNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UnitNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UnitNameText.Name = "UnitNameText";
            // 
            // WeightText
            // 
            resources.ApplyResources(this.WeightText, "WeightText");
            this.WeightText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.WeightText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WeightText.Name = "WeightText";
            this.WeightText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // UnitNameLabel
            // 
            resources.ApplyResources(this.UnitNameLabel, "UnitNameLabel");
            this.UnitNameLabel.Name = "UnitNameLabel";
            this.UnitNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // WeightLabel
            // 
            resources.ApplyResources(this.WeightLabel, "WeightLabel");
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // DeleteUnitButton
            // 
            resources.ApplyResources(this.DeleteUnitButton, "DeleteUnitButton");
            this.DeleteUnitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.DeleteUnitButton.FlatAppearance.BorderSize = 0;
            this.DeleteUnitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.DeleteUnitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(135)))));
            this.DeleteUnitButton.ForeColor = System.Drawing.Color.White;
            this.DeleteUnitButton.Name = "DeleteUnitButton";
            this.DeleteUnitButton.UseVisualStyleBackColor = false;
            this.DeleteUnitButton.Click += new System.EventHandler(this.DeleteUnitButton_Click);
            // 
            // MoveProductsGroupBox
            // 
            resources.ApplyResources(this.MoveProductsGroupBox, "MoveProductsGroupBox");
            this.MoveProductsGroupBox.Controls.Add(this.ShopToGodownLabel);
            this.MoveProductsGroupBox.Controls.Add(this.GodownToShopLabel);
            this.MoveProductsGroupBox.Controls.Add(this.MoveButton);
            this.MoveProductsGroupBox.Controls.Add(this.MoveFromShopText);
            this.MoveProductsGroupBox.Controls.Add(this.MoveFromGodownText);
            this.MoveProductsGroupBox.Name = "MoveProductsGroupBox";
            this.MoveProductsGroupBox.TabStop = false;
            // 
            // UnitsGroupBox
            // 
            resources.ApplyResources(this.UnitsGroupBox, "UnitsGroupBox");
            this.UnitsGroupBox.Controls.Add(this.UnitNameLabel);
            this.UnitsGroupBox.Controls.Add(this.UnitsDataGrid);
            this.UnitsGroupBox.Controls.Add(this.DeleteUnitButton);
            this.UnitsGroupBox.Controls.Add(this.AddUnitButton);
            this.UnitsGroupBox.Controls.Add(this.UnitNameText);
            this.UnitsGroupBox.Controls.Add(this.WeightLabel);
            this.UnitsGroupBox.Controls.Add(this.WeightText);
            this.UnitsGroupBox.Name = "UnitsGroupBox";
            this.UnitsGroupBox.TabStop = false;
            // 
            // ProductInformationGroupBox
            // 
            resources.ApplyResources(this.ProductInformationGroupBox, "ProductInformationGroupBox");
            this.ProductInformationGroupBox.Controls.Add(this.ManufacturerLabel);
            this.ProductInformationGroupBox.Controls.Add(this.ManufacturerText);
            this.ProductInformationGroupBox.Controls.Add(this.SelectShopLabel);
            this.ProductInformationGroupBox.Controls.Add(this.WholeSalePriceText);
            this.ProductInformationGroupBox.Controls.Add(this.WholeSaleLabel);
            this.ProductInformationGroupBox.Controls.Add(this.ShopSelectorCombo);
            this.ProductInformationGroupBox.Controls.Add(this.MrpLabel);
            this.ProductInformationGroupBox.Controls.Add(this.RetailPriceText);
            this.ProductInformationGroupBox.Controls.Add(this.MrpText);
            this.ProductInformationGroupBox.Controls.Add(this.StockInGodownText);
            this.ProductInformationGroupBox.Controls.Add(this.RetailPriceLabel);
            this.ProductInformationGroupBox.Controls.Add(this.ProductIdLabel);
            this.ProductInformationGroupBox.Controls.Add(this.AddedOnDateTime);
            this.ProductInformationGroupBox.Controls.Add(this.AlertAtText);
            this.ProductInformationGroupBox.Controls.Add(this.PurchasePriceText);
            this.ProductInformationGroupBox.Controls.Add(this.ProductIdText);
            this.ProductInformationGroupBox.Controls.Add(this.AddedOnLabel);
            this.ProductInformationGroupBox.Controls.Add(this.StockInShopText);
            this.ProductInformationGroupBox.Controls.Add(this.PurchasePriceLabel);
            this.ProductInformationGroupBox.Controls.Add(this.ProductNameLabel);
            this.ProductInformationGroupBox.Controls.Add(this.CategoryLabel);
            this.ProductInformationGroupBox.Controls.Add(this.TotalStockText);
            this.ProductInformationGroupBox.Controls.Add(this.AlertAtLabel);
            this.ProductInformationGroupBox.Controls.Add(this.ProductNameText);
            this.ProductInformationGroupBox.Controls.Add(this.SaveButton);
            this.ProductInformationGroupBox.Controls.Add(this.SpecificationSelectorCombo);
            this.ProductInformationGroupBox.Controls.Add(this.TotalStockLabel);
            this.ProductInformationGroupBox.Controls.Add(this.SpecificationLabel);
            this.ProductInformationGroupBox.Controls.Add(this.NotesText);
            this.ProductInformationGroupBox.Controls.Add(this.StockInGodownLabel);
            this.ProductInformationGroupBox.Controls.Add(this.NotesLabel);
            this.ProductInformationGroupBox.Controls.Add(this.CategorySelectorCombo);
            this.ProductInformationGroupBox.Controls.Add(this.StockInShopLabel);
            this.ProductInformationGroupBox.Name = "ProductInformationGroupBox";
            this.ProductInformationGroupBox.TabStop = false;
            // 
            // ManufacturerLabel
            // 
            resources.ApplyResources(this.ManufacturerLabel, "ManufacturerLabel");
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            // 
            // ManufacturerText
            // 
            resources.ApplyResources(this.ManufacturerText, "ManufacturerText");
            this.ManufacturerText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ManufacturerText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ManufacturerText.Name = "ManufacturerText";
            // 
            // ProductInformationForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ProductInformationGroupBox);
            this.Controls.Add(this.UnitsGroupBox);
            this.Controls.Add(this.MoveProductsGroupBox);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProductInformationForm";
            this.Load += new System.EventHandler(this.ProductInformation_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            ((System.ComponentModel.ISupportInitialize)(this.UnitsDataGrid)).EndInit();
            this.MoveProductsGroupBox.ResumeLayout(false);
            this.MoveProductsGroupBox.PerformLayout();
            this.UnitsGroupBox.ResumeLayout(false);
            this.UnitsGroupBox.PerformLayout();
            this.ProductInformationGroupBox.ResumeLayout(false);
            this.ProductInformationGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label ProductIdLabel;
        private System.Windows.Forms.TextBox ProductIdText;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.TextBox ProductNameText;
        private System.Windows.Forms.Label StockInShopLabel;
        private System.Windows.Forms.Label StockInGodownLabel;
        private System.Windows.Forms.Label TotalStockLabel;
        private System.Windows.Forms.Label AlertAtLabel;
        private System.Windows.Forms.Label PurchasePriceLabel;
        private System.Windows.Forms.TextBox PurchasePriceText;
        private System.Windows.Forms.Label RetailPriceLabel;
        private System.Windows.Forms.TextBox RetailPriceText;
        private System.Windows.Forms.Label WholeSaleLabel;
        private System.Windows.Forms.TextBox WholeSalePriceText;
        private System.Windows.Forms.Label MrpLabel;
        private System.Windows.Forms.TextBox MrpText;
        private System.Windows.Forms.DateTimePicker AddedOnDateTime;
        private System.Windows.Forms.Label AddedOnLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label SpecificationLabel;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.ComboBox CategorySelectorCombo;
        private System.Windows.Forms.RichTextBox NotesText;
        private System.Windows.Forms.ComboBox SpecificationSelectorCombo;
        private System.Windows.Forms.TextBox TotalStockText;
        private System.Windows.Forms.TextBox StockInShopText;
        private System.Windows.Forms.TextBox AlertAtText;
        private System.Windows.Forms.TextBox StockInGodownText;
        private System.Windows.Forms.ComboBox ShopSelectorCombo;
        private System.Windows.Forms.Label SelectShopLabel;
        private System.Windows.Forms.TextBox MoveFromGodownText;
        private System.Windows.Forms.TextBox MoveFromShopText;
        private System.Windows.Forms.Label ShopToGodownLabel;
        private System.Windows.Forms.Button MoveButton;
        private System.Windows.Forms.Label GodownToShopLabel;
        private System.Windows.Forms.DataGridView UnitsDataGrid;
        private System.Windows.Forms.Button AddUnitButton;
        private System.Windows.Forms.TextBox UnitNameText;
        private System.Windows.Forms.TextBox WeightText;
        private System.Windows.Forms.Label UnitNameLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Button DeleteUnitButton;
        private System.Windows.Forms.GroupBox MoveProductsGroupBox;
        private System.Windows.Forms.GroupBox UnitsGroupBox;
        private System.Windows.Forms.GroupBox ProductInformationGroupBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.TextBox ManufacturerText;
    }
}