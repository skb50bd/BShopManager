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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInformationForm));
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
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semi Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(6, 3);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(322, 47);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Product Information";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // ProductIdLabel
            // 
            this.ProductIdLabel.AutoSize = true;
            this.ProductIdLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIdLabel.Location = new System.Drawing.Point(8, 68);
            this.ProductIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductIdLabel.Name = "ProductIdLabel";
            this.ProductIdLabel.Size = new System.Drawing.Size(90, 21);
            this.ProductIdLabel.TabIndex = 2;
            this.ProductIdLabel.Text = "Product ID :";
            this.ProductIdLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // ProductIdText
            // 
            this.ProductIdText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ProductIdText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductIdText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIdText.Location = new System.Drawing.Point(131, 68);
            this.ProductIdText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ProductIdText.Name = "ProductIdText";
            this.ProductIdText.Size = new System.Drawing.Size(273, 22);
            this.ProductIdText.TabIndex = 3;
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLabel.Location = new System.Drawing.Point(8, 102);
            this.ProductNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(117, 21);
            this.ProductNameLabel.TabIndex = 4;
            this.ProductNameLabel.Text = "Product Name :";
            this.ProductNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // ProductNameText
            // 
            this.ProductNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ProductNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductNameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameText.Location = new System.Drawing.Point(131, 102);
            this.ProductNameText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ProductNameText.Name = "ProductNameText";
            this.ProductNameText.Size = new System.Drawing.Size(273, 22);
            this.ProductNameText.TabIndex = 5;
            // 
            // StockInShopLabel
            // 
            this.StockInShopLabel.AutoSize = true;
            this.StockInShopLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockInShopLabel.Location = new System.Drawing.Point(7, 168);
            this.StockInShopLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StockInShopLabel.Name = "StockInShopLabel";
            this.StockInShopLabel.Size = new System.Drawing.Size(111, 21);
            this.StockInShopLabel.TabIndex = 8;
            this.StockInShopLabel.Text = "Stock in Shop :";
            this.StockInShopLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // StockInGodownLabel
            // 
            this.StockInGodownLabel.AutoSize = true;
            this.StockInGodownLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockInGodownLabel.Location = new System.Drawing.Point(236, 168);
            this.StockInGodownLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StockInGodownLabel.Name = "StockInGodownLabel";
            this.StockInGodownLabel.Size = new System.Drawing.Size(76, 21);
            this.StockInGodownLabel.TabIndex = 10;
            this.StockInGodownLabel.Text = "Godown :";
            this.StockInGodownLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TotalStockLabel
            // 
            this.TotalStockLabel.AutoSize = true;
            this.TotalStockLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalStockLabel.Location = new System.Drawing.Point(7, 203);
            this.TotalStockLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalStockLabel.Name = "TotalStockLabel";
            this.TotalStockLabel.Size = new System.Drawing.Size(90, 21);
            this.TotalStockLabel.TabIndex = 12;
            this.TotalStockLabel.Text = "Total Stock :";
            this.TotalStockLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // AlertAtLabel
            // 
            this.AlertAtLabel.AutoSize = true;
            this.AlertAtLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlertAtLabel.Location = new System.Drawing.Point(243, 203);
            this.AlertAtLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AlertAtLabel.Name = "AlertAtLabel";
            this.AlertAtLabel.Size = new System.Drawing.Size(67, 21);
            this.AlertAtLabel.TabIndex = 14;
            this.AlertAtLabel.Text = "Alert at :";
            this.AlertAtLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // PurchasePriceLabel
            // 
            this.PurchasePriceLabel.AutoSize = true;
            this.PurchasePriceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchasePriceLabel.Location = new System.Drawing.Point(7, 238);
            this.PurchasePriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PurchasePriceLabel.Name = "PurchasePriceLabel";
            this.PurchasePriceLabel.Size = new System.Drawing.Size(118, 21);
            this.PurchasePriceLabel.TabIndex = 16;
            this.PurchasePriceLabel.Text = "Purchase Price :";
            this.PurchasePriceLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // PurchasePriceText
            // 
            this.PurchasePriceText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PurchasePriceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PurchasePriceText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchasePriceText.Location = new System.Drawing.Point(131, 238);
            this.PurchasePriceText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.PurchasePriceText.Name = "PurchasePriceText";
            this.PurchasePriceText.Size = new System.Drawing.Size(90, 22);
            this.PurchasePriceText.TabIndex = 17;
            this.PurchasePriceText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // RetailPriceLabel
            // 
            this.RetailPriceLabel.AutoSize = true;
            this.RetailPriceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetailPriceLabel.Location = new System.Drawing.Point(252, 238);
            this.RetailPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RetailPriceLabel.Name = "RetailPriceLabel";
            this.RetailPriceLabel.Size = new System.Drawing.Size(60, 21);
            this.RetailPriceLabel.TabIndex = 18;
            this.RetailPriceLabel.Text = "Retail  :";
            this.RetailPriceLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // RetailPriceText
            // 
            this.RetailPriceText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RetailPriceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RetailPriceText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetailPriceText.Location = new System.Drawing.Point(315, 238);
            this.RetailPriceText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.RetailPriceText.Name = "RetailPriceText";
            this.RetailPriceText.Size = new System.Drawing.Size(89, 22);
            this.RetailPriceText.TabIndex = 19;
            this.RetailPriceText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // WholeSaleLabel
            // 
            this.WholeSaleLabel.AutoSize = true;
            this.WholeSaleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WholeSaleLabel.Location = new System.Drawing.Point(7, 272);
            this.WholeSaleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WholeSaleLabel.Name = "WholeSaleLabel";
            this.WholeSaleLabel.Size = new System.Drawing.Size(95, 21);
            this.WholeSaleLabel.TabIndex = 20;
            this.WholeSaleLabel.Text = "Whole Sale :";
            this.WholeSaleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // WholeSalePriceText
            // 
            this.WholeSalePriceText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.WholeSalePriceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WholeSalePriceText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WholeSalePriceText.Location = new System.Drawing.Point(132, 272);
            this.WholeSalePriceText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.WholeSalePriceText.Name = "WholeSalePriceText";
            this.WholeSalePriceText.Size = new System.Drawing.Size(89, 22);
            this.WholeSalePriceText.TabIndex = 21;
            this.WholeSalePriceText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // MrpLabel
            // 
            this.MrpLabel.AutoSize = true;
            this.MrpLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MrpLabel.Location = new System.Drawing.Point(253, 272);
            this.MrpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MrpLabel.Name = "MrpLabel";
            this.MrpLabel.Size = new System.Drawing.Size(59, 21);
            this.MrpLabel.TabIndex = 22;
            this.MrpLabel.Text = "M.R.P. :";
            this.MrpLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // MrpText
            // 
            this.MrpText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MrpText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MrpText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MrpText.Location = new System.Drawing.Point(315, 272);
            this.MrpText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MrpText.Name = "MrpText";
            this.MrpText.Size = new System.Drawing.Size(89, 22);
            this.MrpText.TabIndex = 23;
            this.MrpText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // AddedOnDateTime
            // 
            this.AddedOnDateTime.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddedOnDateTime.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.AddedOnDateTime.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.AddedOnDateTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddedOnDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AddedOnDateTime.Location = new System.Drawing.Point(132, 300);
            this.AddedOnDateTime.Margin = new System.Windows.Forms.Padding(5);
            this.AddedOnDateTime.Name = "AddedOnDateTime";
            this.AddedOnDateTime.Size = new System.Drawing.Size(271, 29);
            this.AddedOnDateTime.TabIndex = 25;
            // 
            // AddedOnLabel
            // 
            this.AddedOnLabel.AutoSize = true;
            this.AddedOnLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddedOnLabel.Location = new System.Drawing.Point(7, 306);
            this.AddedOnLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddedOnLabel.Name = "AddedOnLabel";
            this.AddedOnLabel.Size = new System.Drawing.Size(84, 21);
            this.AddedOnLabel.TabIndex = 24;
            this.AddedOnLabel.Text = "Added on :";
            this.AddedOnLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLabel.Location = new System.Drawing.Point(7, 341);
            this.CategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(80, 21);
            this.CategoryLabel.TabIndex = 26;
            this.CategoryLabel.Text = "Category :";
            this.CategoryLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveButton.Location = new System.Drawing.Point(11, 487);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(394, 42);
            this.SaveButton.TabIndex = 32;
            this.SaveButton.Text = "Save";
            this.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SpecificationLabel
            // 
            this.SpecificationLabel.AutoSize = true;
            this.SpecificationLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecificationLabel.Location = new System.Drawing.Point(7, 384);
            this.SpecificationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SpecificationLabel.Name = "SpecificationLabel";
            this.SpecificationLabel.Size = new System.Drawing.Size(105, 21);
            this.SpecificationLabel.TabIndex = 28;
            this.SpecificationLabel.Text = "Specification :";
            this.SpecificationLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesLabel.Location = new System.Drawing.Point(6, 422);
            this.NotesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(58, 21);
            this.NotesLabel.TabIndex = 30;
            this.NotesLabel.Text = "Notes :";
            this.NotesLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // CategorySelectorCombo
            // 
            this.CategorySelectorCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CategorySelectorCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CategorySelectorCombo.BackColor = System.Drawing.Color.White;
            this.CategorySelectorCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategorySelectorCombo.FormattingEnabled = true;
            this.CategorySelectorCombo.Location = new System.Drawing.Point(130, 338);
            this.CategorySelectorCombo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.CategorySelectorCombo.Name = "CategorySelectorCombo";
            this.CategorySelectorCombo.Size = new System.Drawing.Size(274, 29);
            this.CategorySelectorCombo.TabIndex = 27;
            this.CategorySelectorCombo.SelectedIndexChanged += new System.EventHandler(this.CategorySelectorCombo_SelectedIndexChanged);
            // 
            // NotesText
            // 
            this.NotesText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NotesText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NotesText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesText.Location = new System.Drawing.Point(132, 422);
            this.NotesText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.NotesText.Name = "NotesText";
            this.NotesText.Size = new System.Drawing.Size(273, 51);
            this.NotesText.TabIndex = 31;
            this.NotesText.Text = "";
            // 
            // SpecificationSelectorCombo
            // 
            this.SpecificationSelectorCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SpecificationSelectorCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SpecificationSelectorCombo.BackColor = System.Drawing.Color.White;
            this.SpecificationSelectorCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecificationSelectorCombo.FormattingEnabled = true;
            this.SpecificationSelectorCombo.Location = new System.Drawing.Point(130, 381);
            this.SpecificationSelectorCombo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.SpecificationSelectorCombo.Name = "SpecificationSelectorCombo";
            this.SpecificationSelectorCombo.Size = new System.Drawing.Size(274, 29);
            this.SpecificationSelectorCombo.TabIndex = 29;
            // 
            // TotalStockText
            // 
            this.TotalStockText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TotalStockText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalStockText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalStockText.Location = new System.Drawing.Point(132, 203);
            this.TotalStockText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.TotalStockText.Name = "TotalStockText";
            this.TotalStockText.Size = new System.Drawing.Size(89, 22);
            this.TotalStockText.TabIndex = 13;
            this.TotalStockText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // StockInShopText
            // 
            this.StockInShopText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StockInShopText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StockInShopText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockInShopText.Location = new System.Drawing.Point(132, 168);
            this.StockInShopText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.StockInShopText.Name = "StockInShopText";
            this.StockInShopText.Size = new System.Drawing.Size(89, 22);
            this.StockInShopText.TabIndex = 9;
            this.StockInShopText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            this.StockInShopText.Leave += new System.EventHandler(this.TotalStockUpdate);
            // 
            // AlertAtText
            // 
            this.AlertAtText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AlertAtText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AlertAtText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlertAtText.Location = new System.Drawing.Point(315, 203);
            this.AlertAtText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.AlertAtText.Name = "AlertAtText";
            this.AlertAtText.Size = new System.Drawing.Size(89, 22);
            this.AlertAtText.TabIndex = 15;
            this.AlertAtText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // StockInGodownText
            // 
            this.StockInGodownText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StockInGodownText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StockInGodownText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockInGodownText.Location = new System.Drawing.Point(315, 168);
            this.StockInGodownText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.StockInGodownText.Name = "StockInGodownText";
            this.StockInGodownText.Size = new System.Drawing.Size(89, 22);
            this.StockInGodownText.TabIndex = 11;
            this.StockInGodownText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            this.StockInGodownText.Leave += new System.EventHandler(this.TotalStockUpdate);
            // 
            // ShopSelectorCombo
            // 
            this.ShopSelectorCombo.BackColor = System.Drawing.Color.White;
            this.ShopSelectorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShopSelectorCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopSelectorCombo.FormattingEnabled = true;
            this.ShopSelectorCombo.Location = new System.Drawing.Point(130, 31);
            this.ShopSelectorCombo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ShopSelectorCombo.Name = "ShopSelectorCombo";
            this.ShopSelectorCombo.Size = new System.Drawing.Size(273, 29);
            this.ShopSelectorCombo.TabIndex = 1;
            // 
            // SelectShopLabel
            // 
            this.SelectShopLabel.AutoSize = true;
            this.SelectShopLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectShopLabel.Location = new System.Drawing.Point(7, 34);
            this.SelectShopLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectShopLabel.Name = "SelectShopLabel";
            this.SelectShopLabel.Size = new System.Drawing.Size(91, 21);
            this.SelectShopLabel.TabIndex = 0;
            this.SelectShopLabel.Text = "Select Shop";
            this.SelectShopLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // MoveFromGodownText
            // 
            this.MoveFromGodownText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MoveFromGodownText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MoveFromGodownText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveFromGodownText.Location = new System.Drawing.Point(146, 62);
            this.MoveFromGodownText.Name = "MoveFromGodownText";
            this.MoveFromGodownText.Size = new System.Drawing.Size(106, 22);
            this.MoveFromGodownText.TabIndex = 3;
            this.MoveFromGodownText.TextChanged += new System.EventHandler(this.MoveFromGodownText_TextChanged);
            this.MoveFromGodownText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // MoveFromShopText
            // 
            this.MoveFromShopText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MoveFromShopText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MoveFromShopText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveFromShopText.Location = new System.Drawing.Point(146, 27);
            this.MoveFromShopText.Name = "MoveFromShopText";
            this.MoveFromShopText.Size = new System.Drawing.Size(106, 22);
            this.MoveFromShopText.TabIndex = 1;
            this.MoveFromShopText.TextChanged += new System.EventHandler(this.MoveFromShopText_TextChanged);
            this.MoveFromShopText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // ShopToGodownLabel
            // 
            this.ShopToGodownLabel.AutoSize = true;
            this.ShopToGodownLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopToGodownLabel.Location = new System.Drawing.Point(7, 27);
            this.ShopToGodownLabel.Name = "ShopToGodownLabel";
            this.ShopToGodownLabel.Size = new System.Drawing.Size(134, 21);
            this.ShopToGodownLabel.TabIndex = 0;
            this.ShopToGodownLabel.Text = "Shop to Godown :";
            this.ShopToGodownLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // MoveButton
            // 
            this.MoveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.MoveButton.FlatAppearance.BorderSize = 0;
            this.MoveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.MoveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            this.MoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveButton.ForeColor = System.Drawing.Color.White;
            this.MoveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MoveButton.Location = new System.Drawing.Point(11, 96);
            this.MoveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(241, 42);
            this.MoveButton.TabIndex = 4;
            this.MoveButton.Text = "Move";
            this.MoveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MoveButton.UseVisualStyleBackColor = false;
            this.MoveButton.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // GodownToShopLabel
            // 
            this.GodownToShopLabel.AutoSize = true;
            this.GodownToShopLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GodownToShopLabel.Location = new System.Drawing.Point(6, 62);
            this.GodownToShopLabel.Name = "GodownToShopLabel";
            this.GodownToShopLabel.Size = new System.Drawing.Size(134, 21);
            this.GodownToShopLabel.TabIndex = 2;
            this.GodownToShopLabel.Text = "Godown to Shop :";
            this.GodownToShopLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // UnitsDataGrid
            // 
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UnitsDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.UnitsDataGrid.GridColor = System.Drawing.Color.WhiteSmoke;
            this.UnitsDataGrid.Location = new System.Drawing.Point(11, 89);
            this.UnitsDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.UnitsDataGrid.Name = "UnitsDataGrid";
            this.UnitsDataGrid.ReadOnly = true;
            this.UnitsDataGrid.RowHeadersVisible = false;
            this.UnitsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UnitsDataGrid.Size = new System.Drawing.Size(239, 135);
            this.UnitsDataGrid.TabIndex = 5;
            // 
            // Weight
            // 
            this.Weight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Weight.DataPropertyName = "Weight";
            this.Weight.HeaderText = "Weightage";
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            this.Weight.Width = 109;
            // 
            // UnitName
            // 
            this.UnitName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UnitName.DataPropertyName = "UnitName";
            this.UnitName.HeaderText = "Unit Name";
            this.UnitName.Name = "UnitName";
            this.UnitName.ReadOnly = true;
            this.UnitName.Width = 110;
            // 
            // AddUnitButton
            // 
            this.AddUnitButton.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Plus_Math_96px_1;
            this.AddUnitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddUnitButton.FlatAppearance.BorderSize = 0;
            this.AddUnitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUnitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUnitButton.Location = new System.Drawing.Point(223, 55);
            this.AddUnitButton.Name = "AddUnitButton";
            this.AddUnitButton.Size = new System.Drawing.Size(29, 29);
            this.AddUnitButton.TabIndex = 4;
            this.AddUnitButton.UseVisualStyleBackColor = true;
            this.AddUnitButton.Click += new System.EventHandler(this.AddUnitButton_Click);
            // 
            // UnitNameText
            // 
            this.UnitNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UnitNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UnitNameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitNameText.Location = new System.Drawing.Point(107, 25);
            this.UnitNameText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.UnitNameText.Name = "UnitNameText";
            this.UnitNameText.Size = new System.Drawing.Size(145, 22);
            this.UnitNameText.TabIndex = 1;
            // 
            // WeightText
            // 
            this.WeightText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.WeightText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WeightText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightText.Location = new System.Drawing.Point(107, 59);
            this.WeightText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.WeightText.Name = "WeightText";
            this.WeightText.Size = new System.Drawing.Size(115, 22);
            this.WeightText.TabIndex = 3;
            this.WeightText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // UnitNameLabel
            // 
            this.UnitNameLabel.AutoSize = true;
            this.UnitNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitNameLabel.Location = new System.Drawing.Point(7, 25);
            this.UnitNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UnitNameLabel.Name = "UnitNameLabel";
            this.UnitNameLabel.Size = new System.Drawing.Size(92, 21);
            this.UnitNameLabel.TabIndex = 0;
            this.UnitNameLabel.Text = "Unit Name :";
            this.UnitNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(7, 59);
            this.WeightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(66, 21);
            this.WeightLabel.TabIndex = 2;
            this.WeightLabel.Text = "Weight :";
            this.WeightLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // DeleteUnitButton
            // 
            this.DeleteUnitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.DeleteUnitButton.FlatAppearance.BorderSize = 0;
            this.DeleteUnitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.DeleteUnitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(135)))));
            this.DeleteUnitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteUnitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUnitButton.ForeColor = System.Drawing.Color.White;
            this.DeleteUnitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteUnitButton.Location = new System.Drawing.Point(11, 230);
            this.DeleteUnitButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.DeleteUnitButton.Name = "DeleteUnitButton";
            this.DeleteUnitButton.Size = new System.Drawing.Size(242, 42);
            this.DeleteUnitButton.TabIndex = 6;
            this.DeleteUnitButton.Text = "Delete Unit";
            this.DeleteUnitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteUnitButton.UseVisualStyleBackColor = false;
            this.DeleteUnitButton.Click += new System.EventHandler(this.DeleteUnitButton_Click);
            // 
            // MoveProductsGroupBox
            // 
            this.MoveProductsGroupBox.Controls.Add(this.ShopToGodownLabel);
            this.MoveProductsGroupBox.Controls.Add(this.GodownToShopLabel);
            this.MoveProductsGroupBox.Controls.Add(this.MoveButton);
            this.MoveProductsGroupBox.Controls.Add(this.MoveFromShopText);
            this.MoveProductsGroupBox.Controls.Add(this.MoveFromGodownText);
            this.MoveProductsGroupBox.Location = new System.Drawing.Point(434, 447);
            this.MoveProductsGroupBox.Name = "MoveProductsGroupBox";
            this.MoveProductsGroupBox.Size = new System.Drawing.Size(263, 150);
            this.MoveProductsGroupBox.TabIndex = 3;
            this.MoveProductsGroupBox.TabStop = false;
            this.MoveProductsGroupBox.Text = "Move products from";
            // 
            // UnitsGroupBox
            // 
            this.UnitsGroupBox.Controls.Add(this.UnitNameLabel);
            this.UnitsGroupBox.Controls.Add(this.UnitsDataGrid);
            this.UnitsGroupBox.Controls.Add(this.DeleteUnitButton);
            this.UnitsGroupBox.Controls.Add(this.AddUnitButton);
            this.UnitsGroupBox.Controls.Add(this.UnitNameText);
            this.UnitsGroupBox.Controls.Add(this.WeightLabel);
            this.UnitsGroupBox.Controls.Add(this.WeightText);
            this.UnitsGroupBox.Location = new System.Drawing.Point(434, 58);
            this.UnitsGroupBox.Name = "UnitsGroupBox";
            this.UnitsGroupBox.Size = new System.Drawing.Size(263, 281);
            this.UnitsGroupBox.TabIndex = 2;
            this.UnitsGroupBox.TabStop = false;
            this.UnitsGroupBox.Text = "Units";
            // 
            // ProductInformationGroupBox
            // 
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
            this.ProductInformationGroupBox.Location = new System.Drawing.Point(12, 58);
            this.ProductInformationGroupBox.Name = "ProductInformationGroupBox";
            this.ProductInformationGroupBox.Size = new System.Drawing.Size(416, 540);
            this.ProductInformationGroupBox.TabIndex = 1;
            this.ProductInformationGroupBox.TabStop = false;
            this.ProductInformationGroupBox.Text = "Product Information";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerLabel.Location = new System.Drawing.Point(7, 136);
            this.ManufacturerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(111, 21);
            this.ManufacturerLabel.TabIndex = 6;
            this.ManufacturerLabel.Text = "Manufacturer :";
            // 
            // ManufacturerText
            // 
            this.ManufacturerText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ManufacturerText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ManufacturerText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufacturerText.Location = new System.Drawing.Point(130, 136);
            this.ManufacturerText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ManufacturerText.Name = "ManufacturerText";
            this.ManufacturerText.Size = new System.Drawing.Size(273, 22);
            this.ManufacturerText.TabIndex = 7;
            // 
            // ProductInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(719, 609);
            this.Controls.Add(this.ProductInformationGroupBox);
            this.Controls.Add(this.UnitsGroupBox);
            this.Controls.Add(this.MoveProductsGroupBox);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductInformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Product Information";
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