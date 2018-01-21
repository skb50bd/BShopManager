namespace WinFormsUI.Forms
{
    partial class SaleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleForm));
            this.ShopSelectorCombo = new System.Windows.Forms.ComboBox();
            this.SelectShopLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.QuantityText = new System.Windows.Forms.TextBox();
            this.ProductSelectorLabel = new System.Windows.Forms.Label();
            this.CompanyText = new System.Windows.Forms.TextBox();
            this.CompanyLabel = new System.Windows.Forms.Label();
            this.CustomerCombo = new System.Windows.Forms.ComboBox();
            this.ProductSelectorCombo = new System.Windows.Forms.ComboBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.RetailSaleRadio = new System.Windows.Forms.RadioButton();
            this.WholeSaleRadio = new System.Windows.Forms.RadioButton();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.TotalText = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.RemoveSelectedButton = new System.Windows.Forms.Button();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.DiscountPercentageText = new System.Windows.Forms.TextBox();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.PayableLabel = new System.Windows.Forms.Label();
            this.PayableText = new System.Windows.Forms.TextBox();
            this.PaidAmountLabel = new System.Windows.Forms.Label();
            this.PaidAmountText = new System.Windows.Forms.TextBox();
            this.LessAmountText = new System.Windows.Forms.TextBox();
            this.PercentageLabel = new System.Windows.Forms.Label();
            this.UnitPriceText = new System.Windows.Forms.TextBox();
            this.AvailableQuantityText = new System.Windows.Forms.TextBox();
            this.CartDataGrid = new System.Windows.Forms.DataGridView();
            this.ProductIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewDueLabel = new System.Windows.Forms.Label();
            this.DueText = new System.Windows.Forms.TextBox();
            this.UnitSelectorCombo = new System.Windows.Forms.ComboBox();
            this.NotesText = new System.Windows.Forms.RichTextBox();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.CustomerGroup = new System.Windows.Forms.GroupBox();
            this.ViewCustomerButton = new System.Windows.Forms.Button();
            this.CustomerSelectorLabel = new System.Windows.Forms.Label();
            this.CustomerResetButton = new System.Windows.Forms.Button();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.CustomerNameText = new System.Windows.Forms.TextBox();
            this.ProductGroup = new System.Windows.Forms.GroupBox();
            this.SearchProductLabel = new System.Windows.Forms.Label();
            this.SearchProductText = new System.Windows.Forms.TextBox();
            this.SaleNetPriceText = new System.Windows.Forms.TextBox();
            this.UnitPriceLabel = new System.Windows.Forms.Label();
            this.SaleUnitPriceText = new System.Windows.Forms.TextBox();
            this.NetPriceLabel = new System.Windows.Forms.Label();
            this.BasicInfoGroup = new System.Windows.Forms.GroupBox();
            this.SaleDateTime = new System.Windows.Forms.DateTimePicker();
            this.AmountGroup = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PreviousDueText = new System.Windows.Forms.TextBox();
            this.FullDueText = new System.Windows.Forms.TextBox();
            this.FullPayableText = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SavedMemoGroup = new System.Windows.Forms.GroupBox();
            this.LoadSavedMemoButton = new System.Windows.Forms.Button();
            this.RemoveSavedMemoButton = new System.Windows.Forms.Button();
            this.SavedMemoList = new System.Windows.Forms.ListBox();
            this.ButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ReloadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGrid)).BeginInit();
            this.CustomerGroup.SuspendLayout();
            this.ProductGroup.SuspendLayout();
            this.BasicInfoGroup.SuspendLayout();
            this.AmountGroup.SuspendLayout();
            this.SavedMemoGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShopSelectorCombo
            // 
            this.ShopSelectorCombo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ShopSelectorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShopSelectorCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopSelectorCombo.FormattingEnabled = true;
            this.ShopSelectorCombo.Location = new System.Drawing.Point(92, 22);
            this.ShopSelectorCombo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ShopSelectorCombo.Name = "ShopSelectorCombo";
            this.ShopSelectorCombo.Size = new System.Drawing.Size(260, 29);
            this.ShopSelectorCombo.TabIndex = 1;
            this.ShopSelectorCombo.SelectedIndexChanged += new System.EventHandler(this.ShopSelectorCombo_SelectedIndexChanged);
            // 
            // SelectShopLabel
            // 
            this.SelectShopLabel.AutoSize = true;
            this.SelectShopLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectShopLabel.Location = new System.Drawing.Point(3, 25);
            this.SelectShopLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectShopLabel.Name = "SelectShopLabel";
            this.SelectShopLabel.Size = new System.Drawing.Size(46, 21);
            this.SelectShopLabel.TabIndex = 0;
            this.SelectShopLabel.Text = "Shop";
            this.SelectShopLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semi Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(7, 4);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(117, 47);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Memo";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // QuantityText
            // 
            this.QuantityText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.QuantityText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuantityText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityText.Location = new System.Drawing.Point(87, 151);
            this.QuantityText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.QuantityText.Name = "QuantityText";
            this.QuantityText.Size = new System.Drawing.Size(135, 22);
            this.QuantityText.TabIndex = 11;
            this.QuantityText.TextChanged += new System.EventHandler(this.QuantityText_TextChanged);
            this.QuantityText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QuantityText_KeyDown);
            this.QuantityText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // ProductSelectorLabel
            // 
            this.ProductSelectorLabel.AutoSize = true;
            this.ProductSelectorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductSelectorLabel.Location = new System.Drawing.Point(4, 85);
            this.ProductSelectorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductSelectorLabel.Name = "ProductSelectorLabel";
            this.ProductSelectorLabel.Size = new System.Drawing.Size(71, 21);
            this.ProductSelectorLabel.TabIndex = 6;
            this.ProductSelectorLabel.Text = "Product :";
            this.ProductSelectorLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // CompanyText
            // 
            this.CompanyText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CompanyText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyText.Location = new System.Drawing.Point(91, 94);
            this.CompanyText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.CompanyText.Name = "CompanyText";
            this.CompanyText.Size = new System.Drawing.Size(261, 22);
            this.CompanyText.TabIndex = 7;
            this.CompanyText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CompanyText_KeyDown);
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.AutoSize = true;
            this.CompanyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyLabel.Location = new System.Drawing.Point(3, 94);
            this.CompanyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(84, 21);
            this.CompanyLabel.TabIndex = 6;
            this.CompanyLabel.Text = "Company :";
            this.CompanyLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // CustomerCombo
            // 
            this.CustomerCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CustomerCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CustomerCombo.BackColor = System.Drawing.Color.White;
            this.CustomerCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerCombo.FormattingEnabled = true;
            this.CustomerCombo.Location = new System.Drawing.Point(91, 23);
            this.CustomerCombo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.CustomerCombo.Name = "CustomerCombo";
            this.CustomerCombo.Size = new System.Drawing.Size(260, 29);
            this.CustomerCombo.TabIndex = 1;
            this.CustomerCombo.SelectedIndexChanged += new System.EventHandler(this.CustomerCombo_SelectedIndexChanged);
            this.CustomerCombo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomerCombo_KeyDown);
            this.CustomerCombo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.CustomerCombo_MouseDoubleClick);
            // 
            // ProductSelectorCombo
            // 
            this.ProductSelectorCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ProductSelectorCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ProductSelectorCombo.BackColor = System.Drawing.Color.White;
            this.ProductSelectorCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductSelectorCombo.FormattingEnabled = true;
            this.ProductSelectorCombo.Location = new System.Drawing.Point(87, 82);
            this.ProductSelectorCombo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ProductSelectorCombo.Name = "ProductSelectorCombo";
            this.ProductSelectorCombo.Size = new System.Drawing.Size(279, 29);
            this.ProductSelectorCombo.TabIndex = 7;
            this.ProductSelectorCombo.SelectedIndexChanged += new System.EventHandler(this.ProductSelectorCombo_SelectedIndexChanged);
            this.ProductSelectorCombo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductSelectorCombo_KeyDown);
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(4, 151);
            this.QuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(77, 21);
            this.QuantityLabel.TabIndex = 10;
            this.QuantityLabel.Text = "Quantity :";
            this.QuantityLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // RetailSaleRadio
            // 
            this.RetailSaleRadio.AutoSize = true;
            this.RetailSaleRadio.FlatAppearance.BorderSize = 0;
            this.RetailSaleRadio.Location = new System.Drawing.Point(105, 18);
            this.RetailSaleRadio.Margin = new System.Windows.Forms.Padding(4);
            this.RetailSaleRadio.Name = "RetailSaleRadio";
            this.RetailSaleRadio.Size = new System.Drawing.Size(100, 25);
            this.RetailSaleRadio.TabIndex = 3;
            this.RetailSaleRadio.TabStop = true;
            this.RetailSaleRadio.Text = "Retail Sale";
            this.RetailSaleRadio.UseVisualStyleBackColor = true;
            this.RetailSaleRadio.CheckedChanged += new System.EventHandler(this.RetailSaleRadio_CheckedChanged);
            this.RetailSaleRadio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RetailSaleRadio_KeyDown);
            // 
            // WholeSaleRadio
            // 
            this.WholeSaleRadio.AutoSize = true;
            this.WholeSaleRadio.FlatAppearance.BorderSize = 0;
            this.WholeSaleRadio.Location = new System.Drawing.Point(213, 18);
            this.WholeSaleRadio.Margin = new System.Windows.Forms.Padding(4);
            this.WholeSaleRadio.Name = "WholeSaleRadio";
            this.WholeSaleRadio.Size = new System.Drawing.Size(106, 25);
            this.WholeSaleRadio.TabIndex = 4;
            this.WholeSaleRadio.TabStop = true;
            this.WholeSaleRadio.Text = "Whole Sale";
            this.WholeSaleRadio.UseVisualStyleBackColor = true;
            this.WholeSaleRadio.CheckedChanged += new System.EventHandler(this.WholeSaleRadio_CheckedChanged);
            this.WholeSaleRadio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RetailSaleRadio_KeyDown);
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.AddToCartButton.FlatAppearance.BorderSize = 0;
            this.AddToCartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.AddToCartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            this.AddToCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToCartButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToCartButton.ForeColor = System.Drawing.Color.White;
            this.AddToCartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddToCartButton.Location = new System.Drawing.Point(87, 213);
            this.AddToCartButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(279, 42);
            this.AddToCartButton.TabIndex = 17;
            this.AddToCartButton.Text = "Add";
            this.AddToCartButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonToolTip.SetToolTip(this.AddToCartButton, "Add the product to the cart");
            this.AddToCartButton.UseVisualStyleBackColor = false;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            this.AddToCartButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddToCartButton_KeyDown);
            // 
            // TotalText
            // 
            this.TotalText.AutoSize = true;
            this.TotalText.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalText.Location = new System.Drawing.Point(95, 18);
            this.TotalText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalText.Name = "TotalText";
            this.TotalText.Size = new System.Drawing.Size(63, 28);
            this.TotalText.TabIndex = 1;
            this.TotalText.Text = "0.0 Tk";
            this.TotalText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(9, 24);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(49, 21);
            this.TotalLabel.TabIndex = 0;
            this.TotalLabel.Text = "Total :";
            this.TotalLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.SubmitButton.FlatAppearance.BorderSize = 0;
            this.SubmitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.SubmitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.Color.White;
            this.SubmitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubmitButton.Location = new System.Drawing.Point(13, 207);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(274, 42);
            this.SubmitButton.TabIndex = 12;
            this.SubmitButton.Text = "Sell";
            this.SubmitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonToolTip.SetToolTip(this.SubmitButton, "Execute the sale");
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // RemoveSelectedButton
            // 
            this.RemoveSelectedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.RemoveSelectedButton.FlatAppearance.BorderSize = 0;
            this.RemoveSelectedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.RemoveSelectedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(135)))));
            this.RemoveSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveSelectedButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveSelectedButton.ForeColor = System.Drawing.Color.White;
            this.RemoveSelectedButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveSelectedButton.Location = new System.Drawing.Point(15, 647);
            this.RemoveSelectedButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.RemoveSelectedButton.Name = "RemoveSelectedButton";
            this.RemoveSelectedButton.Size = new System.Drawing.Size(742, 42);
            this.RemoveSelectedButton.TabIndex = 7;
            this.RemoveSelectedButton.Text = "Remove Selected";
            this.RemoveSelectedButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonToolTip.SetToolTip(this.RemoveSelectedButton, "Remove the selected product from cart");
            this.RemoveSelectedButton.UseVisualStyleBackColor = false;
            this.RemoveSelectedButton.Click += new System.EventHandler(this.RemoveSelectedButton_Click);
            // 
            // DiscountLabel
            // 
            this.DiscountLabel.AutoSize = true;
            this.DiscountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountLabel.Location = new System.Drawing.Point(9, 54);
            this.DiscountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.Size = new System.Drawing.Size(78, 21);
            this.DiscountLabel.TabIndex = 2;
            this.DiscountLabel.Text = "Discount :";
            this.DiscountLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // DiscountPercentageText
            // 
            this.DiscountPercentageText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DiscountPercentageText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiscountPercentageText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountPercentageText.Location = new System.Drawing.Point(100, 54);
            this.DiscountPercentageText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.DiscountPercentageText.Name = "DiscountPercentageText";
            this.DiscountPercentageText.Size = new System.Drawing.Size(57, 22);
            this.DiscountPercentageText.TabIndex = 3;
            this.DiscountPercentageText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DiscountPercentageText_KeyDown);
            this.DiscountPercentageText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            this.DiscountPercentageText.Leave += new System.EventHandler(this.DiscountText_Leave);
            // 
            // AddressText
            // 
            this.AddressText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddressText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressText.Location = new System.Drawing.Point(91, 127);
            this.AddressText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(261, 22);
            this.AddressText.TabIndex = 9;
            this.AddressText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddressText_KeyDown);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(3, 127);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(73, 21);
            this.AddressLabel.TabIndex = 8;
            this.AddressLabel.Text = "Address :";
            this.AddressLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // PayableLabel
            // 
            this.PayableLabel.AutoSize = true;
            this.PayableLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayableLabel.Location = new System.Drawing.Point(9, 114);
            this.PayableLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PayableLabel.Name = "PayableLabel";
            this.PayableLabel.Size = new System.Drawing.Size(70, 21);
            this.PayableLabel.TabIndex = 6;
            this.PayableLabel.Text = "Payable :";
            this.PayableLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // PayableText
            // 
            this.PayableText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PayableText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PayableText.Enabled = false;
            this.PayableText.Font = new System.Drawing.Font("Segoe UI Semi Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayableText.Location = new System.Drawing.Point(100, 114);
            this.PayableText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.PayableText.Name = "PayableText";
            this.PayableText.Size = new System.Drawing.Size(88, 22);
            this.PayableText.TabIndex = 7;
            this.PayableText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // PaidAmountLabel
            // 
            this.PaidAmountLabel.AutoSize = true;
            this.PaidAmountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaidAmountLabel.Location = new System.Drawing.Point(9, 144);
            this.PaidAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PaidAmountLabel.Name = "PaidAmountLabel";
            this.PaidAmountLabel.Size = new System.Drawing.Size(46, 21);
            this.PaidAmountLabel.TabIndex = 8;
            this.PaidAmountLabel.Text = "Paid :";
            this.PaidAmountLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // PaidAmountText
            // 
            this.PaidAmountText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PaidAmountText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PaidAmountText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaidAmountText.Location = new System.Drawing.Point(100, 144);
            this.PaidAmountText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.PaidAmountText.Name = "PaidAmountText";
            this.PaidAmountText.Size = new System.Drawing.Size(186, 22);
            this.PaidAmountText.TabIndex = 9;
            this.PaidAmountText.TextChanged += new System.EventHandler(this.PaidAmountText_TextChanged);
            this.PaidAmountText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PaidAmountText_KeyDown);
            this.PaidAmountText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            this.PaidAmountText.Leave += new System.EventHandler(this.DiscountText_Leave);
            // 
            // LessAmountText
            // 
            this.LessAmountText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LessAmountText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LessAmountText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LessAmountText.Location = new System.Drawing.Point(197, 53);
            this.LessAmountText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.LessAmountText.Name = "LessAmountText";
            this.LessAmountText.Size = new System.Drawing.Size(89, 22);
            this.LessAmountText.TabIndex = 5;
            this.LessAmountText.TextChanged += new System.EventHandler(this.LessAmountText_TextChanged);
            this.LessAmountText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LessAmountText_KeyDown);
            this.LessAmountText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            this.LessAmountText.Leave += new System.EventHandler(this.DiscountText_Leave);
            // 
            // PercentageLabel
            // 
            this.PercentageLabel.AutoSize = true;
            this.PercentageLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentageLabel.Location = new System.Drawing.Point(156, 53);
            this.PercentageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PercentageLabel.Name = "PercentageLabel";
            this.PercentageLabel.Size = new System.Drawing.Size(23, 21);
            this.PercentageLabel.TabIndex = 4;
            this.PercentageLabel.Text = "%";
            this.PercentageLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // UnitPriceText
            // 
            this.UnitPriceText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UnitPriceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UnitPriceText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitPriceText.Location = new System.Drawing.Point(87, 120);
            this.UnitPriceText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.UnitPriceText.Name = "UnitPriceText";
            this.UnitPriceText.Size = new System.Drawing.Size(135, 22);
            this.UnitPriceText.TabIndex = 8;
            // 
            // AvailableQuantityText
            // 
            this.AvailableQuantityText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AvailableQuantityText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AvailableQuantityText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableQuantityText.Location = new System.Drawing.Point(230, 120);
            this.AvailableQuantityText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.AvailableQuantityText.Name = "AvailableQuantityText";
            this.AvailableQuantityText.Size = new System.Drawing.Size(136, 22);
            this.AvailableQuantityText.TabIndex = 9;
            // 
            // CartDataGrid
            // 
            this.CartDataGrid.AllowUserToAddRows = false;
            this.CartDataGrid.AllowUserToDeleteRows = false;
            this.CartDataGrid.AllowUserToOrderColumns = true;
            this.CartDataGrid.AllowUserToResizeRows = false;
            this.CartDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.CartDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.CartDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CartDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.CartDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CartDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CartDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductIdColumn,
            this.ProductNameColumn,
            this.QuantityColumn,
            this.UnitNameColumn,
            this.UnitPriceColumn,
            this.NetPriceColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CartDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.CartDataGrid.GridColor = System.Drawing.Color.WhiteSmoke;
            this.CartDataGrid.Location = new System.Drawing.Point(15, 375);
            this.CartDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.CartDataGrid.Name = "CartDataGrid";
            this.CartDataGrid.ReadOnly = true;
            this.CartDataGrid.RowHeadersVisible = false;
            this.CartDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CartDataGrid.Size = new System.Drawing.Size(742, 266);
            this.CartDataGrid.TabIndex = 6;
            // 
            // ProductIdColumn
            // 
            this.ProductIdColumn.DataPropertyName = "GetProductId";
            this.ProductIdColumn.HeaderText = "Product ID";
            this.ProductIdColumn.Name = "ProductIdColumn";
            this.ProductIdColumn.ReadOnly = true;
            this.ProductIdColumn.Width = 108;
            // 
            // ProductNameColumn
            // 
            this.ProductNameColumn.DataPropertyName = "ProductName";
            this.ProductNameColumn.HeaderText = "Product Name";
            this.ProductNameColumn.Name = "ProductNameColumn";
            this.ProductNameColumn.ReadOnly = true;
            this.ProductNameColumn.Width = 135;
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.DataPropertyName = "GetQuantity";
            this.QuantityColumn.HeaderText = "Qty";
            this.QuantityColumn.Name = "QuantityColumn";
            this.QuantityColumn.ReadOnly = true;
            this.QuantityColumn.Width = 60;
            // 
            // UnitNameColumn
            // 
            this.UnitNameColumn.DataPropertyName = "GetUnitName";
            this.UnitNameColumn.HeaderText = "Unit";
            this.UnitNameColumn.Name = "UnitNameColumn";
            this.UnitNameColumn.ReadOnly = true;
            this.UnitNameColumn.Width = 64;
            // 
            // UnitPriceColumn
            // 
            this.UnitPriceColumn.DataPropertyName = "GetUnitPrice";
            this.UnitPriceColumn.HeaderText = "Unit Price";
            this.UnitPriceColumn.Name = "UnitPriceColumn";
            this.UnitPriceColumn.ReadOnly = true;
            this.UnitPriceColumn.Width = 102;
            // 
            // NetPriceColumn
            // 
            this.NetPriceColumn.DataPropertyName = "GetNetPrice";
            this.NetPriceColumn.HeaderText = "Net Price";
            this.NetPriceColumn.Name = "NetPriceColumn";
            this.NetPriceColumn.ReadOnly = true;
            this.NetPriceColumn.Width = 98;
            // 
            // NewDueLabel
            // 
            this.NewDueLabel.AutoSize = true;
            this.NewDueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewDueLabel.Location = new System.Drawing.Point(9, 174);
            this.NewDueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NewDueLabel.Name = "NewDueLabel";
            this.NewDueLabel.Size = new System.Drawing.Size(83, 21);
            this.NewDueLabel.TabIndex = 10;
            this.NewDueLabel.Text = "Curr. Due :";
            this.NewDueLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // DueText
            // 
            this.DueText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DueText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DueText.Enabled = false;
            this.DueText.Font = new System.Drawing.Font("Segoe UI Semi Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueText.Location = new System.Drawing.Point(101, 174);
            this.DueText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.DueText.Name = "DueText";
            this.DueText.Size = new System.Drawing.Size(87, 22);
            this.DueText.TabIndex = 11;
            this.DueText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // UnitSelectorCombo
            // 
            this.UnitSelectorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnitSelectorCombo.FormattingEnabled = true;
            this.UnitSelectorCombo.Location = new System.Drawing.Point(230, 148);
            this.UnitSelectorCombo.Name = "UnitSelectorCombo";
            this.UnitSelectorCombo.Size = new System.Drawing.Size(136, 29);
            this.UnitSelectorCombo.TabIndex = 12;
            this.UnitSelectorCombo.SelectedIndexChanged += new System.EventHandler(this.UnitSelectorCombo_SelectedIndexChanged);
            this.UnitSelectorCombo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UnitSelectorCombo_KeyDown);
            // 
            // NotesText
            // 
            this.NotesText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NotesText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NotesText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesText.Location = new System.Drawing.Point(92, 196);
            this.NotesText.Margin = new System.Windows.Forms.Padding(4);
            this.NotesText.Name = "NotesText";
            this.NotesText.Size = new System.Drawing.Size(261, 59);
            this.NotesText.TabIndex = 14;
            this.NotesText.Text = "";
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesLabel.Location = new System.Drawing.Point(4, 196);
            this.NotesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(62, 21);
            this.NotesLabel.TabIndex = 13;
            this.NotesLabel.Text = "Notes : ";
            this.NotesLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // CustomerGroup
            // 
            this.CustomerGroup.Controls.Add(this.ViewCustomerButton);
            this.CustomerGroup.Controls.Add(this.CustomerSelectorLabel);
            this.CustomerGroup.Controls.Add(this.CustomerResetButton);
            this.CustomerGroup.Controls.Add(this.AddCustomerButton);
            this.CustomerGroup.Controls.Add(this.CustomerNameLabel);
            this.CustomerGroup.Controls.Add(this.CustomerNameText);
            this.CustomerGroup.Controls.Add(this.CustomerCombo);
            this.CustomerGroup.Controls.Add(this.CompanyLabel);
            this.CustomerGroup.Controls.Add(this.CompanyText);
            this.CustomerGroup.Controls.Add(this.NotesText);
            this.CustomerGroup.Controls.Add(this.AddressLabel);
            this.CustomerGroup.Controls.Add(this.NotesLabel);
            this.CustomerGroup.Controls.Add(this.AddressText);
            this.CustomerGroup.Location = new System.Drawing.Point(15, 103);
            this.CustomerGroup.Name = "CustomerGroup";
            this.CustomerGroup.Size = new System.Drawing.Size(361, 265);
            this.CustomerGroup.TabIndex = 2;
            this.CustomerGroup.TabStop = false;
            // 
            // ViewCustomerButton
            // 
            this.ViewCustomerButton.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Eye_96px;
            this.ViewCustomerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ViewCustomerButton.FlatAppearance.BorderSize = 0;
            this.ViewCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewCustomerButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCustomerButton.Location = new System.Drawing.Point(324, 160);
            this.ViewCustomerButton.Name = "ViewCustomerButton";
            this.ViewCustomerButton.Size = new System.Drawing.Size(29, 29);
            this.ViewCustomerButton.TabIndex = 10;
            this.ButtonToolTip.SetToolTip(this.ViewCustomerButton, "View or Edit the selected customer");
            this.ViewCustomerButton.UseVisualStyleBackColor = true;
            this.ViewCustomerButton.Click += new System.EventHandler(this.ViewCustomerButton_Click);
            // 
            // CustomerSelectorLabel
            // 
            this.CustomerSelectorLabel.AutoSize = true;
            this.CustomerSelectorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerSelectorLabel.Location = new System.Drawing.Point(3, 26);
            this.CustomerSelectorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerSelectorLabel.Name = "CustomerSelectorLabel";
            this.CustomerSelectorLabel.Size = new System.Drawing.Size(85, 21);
            this.CustomerSelectorLabel.TabIndex = 0;
            this.CustomerSelectorLabel.Text = "Customer :";
            // 
            // CustomerResetButton
            // 
            this.CustomerResetButton.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Reset_512px;
            this.CustomerResetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CustomerResetButton.FlatAppearance.BorderSize = 0;
            this.CustomerResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerResetButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerResetButton.Location = new System.Drawing.Point(256, 160);
            this.CustomerResetButton.Name = "CustomerResetButton";
            this.CustomerResetButton.Size = new System.Drawing.Size(29, 29);
            this.CustomerResetButton.TabIndex = 12;
            this.ButtonToolTip.SetToolTip(this.CustomerResetButton, "Reset Customer");
            this.CustomerResetButton.UseVisualStyleBackColor = true;
            this.CustomerResetButton.Click += new System.EventHandler(this.CustomerResetButton_Click);
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Plus_Math_96px_1;
            this.AddCustomerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddCustomerButton.FlatAppearance.BorderSize = 0;
            this.AddCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCustomerButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustomerButton.Location = new System.Drawing.Point(288, 160);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(29, 29);
            this.AddCustomerButton.TabIndex = 11;
            this.ButtonToolTip.SetToolTip(this.AddCustomerButton, "Add new customer");
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLabel.Location = new System.Drawing.Point(3, 61);
            this.CustomerNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(88, 21);
            this.CustomerNameLabel.TabIndex = 4;
            this.CustomerNameLabel.Text = "Full Name :";
            // 
            // CustomerNameText
            // 
            this.CustomerNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CustomerNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerNameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameText.Location = new System.Drawing.Point(91, 61);
            this.CustomerNameText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.CustomerNameText.Name = "CustomerNameText";
            this.CustomerNameText.Size = new System.Drawing.Size(260, 22);
            this.CustomerNameText.TabIndex = 5;
            this.CustomerNameText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomerNameText_KeyDown);
            // 
            // ProductGroup
            // 
            this.ProductGroup.Controls.Add(this.SearchProductLabel);
            this.ProductGroup.Controls.Add(this.SearchProductText);
            this.ProductGroup.Controls.Add(this.SaleNetPriceText);
            this.ProductGroup.Controls.Add(this.WholeSaleRadio);
            this.ProductGroup.Controls.Add(this.UnitPriceLabel);
            this.ProductGroup.Controls.Add(this.SaleUnitPriceText);
            this.ProductGroup.Controls.Add(this.ProductSelectorLabel);
            this.ProductGroup.Controls.Add(this.RetailSaleRadio);
            this.ProductGroup.Controls.Add(this.ProductSelectorCombo);
            this.ProductGroup.Controls.Add(this.QuantityLabel);
            this.ProductGroup.Controls.Add(this.AddToCartButton);
            this.ProductGroup.Controls.Add(this.UnitPriceText);
            this.ProductGroup.Controls.Add(this.UnitSelectorCombo);
            this.ProductGroup.Controls.Add(this.AvailableQuantityText);
            this.ProductGroup.Controls.Add(this.QuantityText);
            this.ProductGroup.Controls.Add(this.NetPriceLabel);
            this.ProductGroup.Location = new System.Drawing.Point(382, 103);
            this.ProductGroup.Name = "ProductGroup";
            this.ProductGroup.Size = new System.Drawing.Size(375, 265);
            this.ProductGroup.TabIndex = 5;
            this.ProductGroup.TabStop = false;
            // 
            // SearchProductLabel
            // 
            this.SearchProductLabel.AutoSize = true;
            this.SearchProductLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchProductLabel.Location = new System.Drawing.Point(4, 49);
            this.SearchProductLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchProductLabel.Name = "SearchProductLabel";
            this.SearchProductLabel.Size = new System.Drawing.Size(64, 21);
            this.SearchProductLabel.TabIndex = 18;
            this.SearchProductLabel.Text = "Search :";
            // 
            // SearchProductText
            // 
            this.SearchProductText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SearchProductText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchProductText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchProductText.Location = new System.Drawing.Point(87, 51);
            this.SearchProductText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.SearchProductText.Name = "SearchProductText";
            this.SearchProductText.Size = new System.Drawing.Size(279, 22);
            this.SearchProductText.TabIndex = 19;
            this.SearchProductText.TextChanged += new System.EventHandler(this.SearchProductText_TextChanged);
            this.SearchProductText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchProductText_KeyDown);
            // 
            // SaleNetPriceText
            // 
            this.SaleNetPriceText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SaleNetPriceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SaleNetPriceText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleNetPriceText.Location = new System.Drawing.Point(267, 182);
            this.SaleNetPriceText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.SaleNetPriceText.Name = "SaleNetPriceText";
            this.SaleNetPriceText.Size = new System.Drawing.Size(99, 22);
            this.SaleNetPriceText.TabIndex = 16;
            this.SaleNetPriceText.TextChanged += new System.EventHandler(this.SaleNetPriceText_TextChanged);
            this.SaleNetPriceText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SaleNetPriceText_KeyDown);
            this.SaleNetPriceText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // UnitPriceLabel
            // 
            this.UnitPriceLabel.AutoSize = true;
            this.UnitPriceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitPriceLabel.Location = new System.Drawing.Point(4, 182);
            this.UnitPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UnitPriceLabel.Name = "UnitPriceLabel";
            this.UnitPriceLabel.Size = new System.Drawing.Size(84, 21);
            this.UnitPriceLabel.TabIndex = 13;
            this.UnitPriceLabel.Text = "Unit Price :";
            // 
            // SaleUnitPriceText
            // 
            this.SaleUnitPriceText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SaleUnitPriceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SaleUnitPriceText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleUnitPriceText.Location = new System.Drawing.Point(87, 182);
            this.SaleUnitPriceText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.SaleUnitPriceText.Name = "SaleUnitPriceText";
            this.SaleUnitPriceText.Size = new System.Drawing.Size(103, 22);
            this.SaleUnitPriceText.TabIndex = 14;
            this.SaleUnitPriceText.TextChanged += new System.EventHandler(this.SaleUnitPriceText_TextChanged);
            this.SaleUnitPriceText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SaleUnitPriceText_KeyDown);
            this.SaleUnitPriceText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // NetPriceLabel
            // 
            this.NetPriceLabel.AutoSize = true;
            this.NetPriceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetPriceLabel.Location = new System.Drawing.Point(198, 182);
            this.NetPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NetPriceLabel.Name = "NetPriceLabel";
            this.NetPriceLabel.Size = new System.Drawing.Size(71, 21);
            this.NetPriceLabel.TabIndex = 15;
            this.NetPriceLabel.Text = "Net Prc. :";
            // 
            // BasicInfoGroup
            // 
            this.BasicInfoGroup.Controls.Add(this.SelectShopLabel);
            this.BasicInfoGroup.Controls.Add(this.SaleDateTime);
            this.BasicInfoGroup.Controls.Add(this.ShopSelectorCombo);
            this.BasicInfoGroup.Location = new System.Drawing.Point(15, 46);
            this.BasicInfoGroup.Name = "BasicInfoGroup";
            this.BasicInfoGroup.Size = new System.Drawing.Size(742, 61);
            this.BasicInfoGroup.TabIndex = 1;
            this.BasicInfoGroup.TabStop = false;
            // 
            // SaleDateTime
            // 
            this.SaleDateTime.CalendarMonthBackground = System.Drawing.Color.White;
            this.SaleDateTime.CustomFormat = "dddd dd MMMM yyyy - hh:mm tt";
            this.SaleDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SaleDateTime.Location = new System.Drawing.Point(367, 19);
            this.SaleDateTime.Name = "SaleDateTime";
            this.SaleDateTime.Size = new System.Drawing.Size(366, 29);
            this.SaleDateTime.TabIndex = 2;
            this.ButtonToolTip.SetToolTip(this.SaleDateTime, "Time and Date of the sale");
            // 
            // AmountGroup
            // 
            this.AmountGroup.Controls.Add(this.DiscountPercentageText);
            this.AmountGroup.Controls.Add(this.label2);
            this.AmountGroup.Controls.Add(this.PreviousDueText);
            this.AmountGroup.Controls.Add(this.FullDueText);
            this.AmountGroup.Controls.Add(this.FullPayableText);
            this.AmountGroup.Controls.Add(this.SaveButton);
            this.AmountGroup.Controls.Add(this.DiscountLabel);
            this.AmountGroup.Controls.Add(this.TotalLabel);
            this.AmountGroup.Controls.Add(this.TotalText);
            this.AmountGroup.Controls.Add(this.PayableText);
            this.AmountGroup.Controls.Add(this.LessAmountText);
            this.AmountGroup.Controls.Add(this.SubmitButton);
            this.AmountGroup.Controls.Add(this.PayableLabel);
            this.AmountGroup.Controls.Add(this.NewDueLabel);
            this.AmountGroup.Controls.Add(this.PaidAmountText);
            this.AmountGroup.Controls.Add(this.DueText);
            this.AmountGroup.Controls.Add(this.PaidAmountLabel);
            this.AmountGroup.Controls.Add(this.PercentageLabel);
            this.AmountGroup.Location = new System.Drawing.Point(763, 46);
            this.AmountGroup.Name = "AmountGroup";
            this.AmountGroup.Size = new System.Drawing.Size(295, 312);
            this.AmountGroup.TabIndex = 8;
            this.AmountGroup.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Prev. Due :";
            // 
            // PreviousDueText
            // 
            this.PreviousDueText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PreviousDueText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PreviousDueText.Enabled = false;
            this.PreviousDueText.Font = new System.Drawing.Font("Segoe UI Semi Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousDueText.Location = new System.Drawing.Point(100, 84);
            this.PreviousDueText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.PreviousDueText.Name = "PreviousDueText";
            this.PreviousDueText.Size = new System.Drawing.Size(186, 22);
            this.PreviousDueText.TabIndex = 17;
            // 
            // FullDueText
            // 
            this.FullDueText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FullDueText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FullDueText.Enabled = false;
            this.FullDueText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullDueText.Location = new System.Drawing.Point(196, 173);
            this.FullDueText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.FullDueText.Name = "FullDueText";
            this.FullDueText.Size = new System.Drawing.Size(90, 22);
            this.FullDueText.TabIndex = 15;
            // 
            // FullPayableText
            // 
            this.FullPayableText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FullPayableText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FullPayableText.Enabled = false;
            this.FullPayableText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullPayableText.Location = new System.Drawing.Point(196, 114);
            this.FullPayableText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.FullPayableText.Name = "FullPayableText";
            this.FullPayableText.Size = new System.Drawing.Size(90, 22);
            this.FullPayableText.TabIndex = 14;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(170)))));
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveButton.Location = new System.Drawing.Point(12, 256);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(275, 42);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Save";
            this.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonToolTip.SetToolTip(this.SaveButton, "Save the memo for future use");
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // SavedMemoGroup
            // 
            this.SavedMemoGroup.Controls.Add(this.LoadSavedMemoButton);
            this.SavedMemoGroup.Controls.Add(this.RemoveSavedMemoButton);
            this.SavedMemoGroup.Controls.Add(this.SavedMemoList);
            this.SavedMemoGroup.Location = new System.Drawing.Point(763, 364);
            this.SavedMemoGroup.Name = "SavedMemoGroup";
            this.SavedMemoGroup.Size = new System.Drawing.Size(295, 325);
            this.SavedMemoGroup.TabIndex = 10;
            this.SavedMemoGroup.TabStop = false;
            this.SavedMemoGroup.Text = "Saved Memo";
            // 
            // LoadSavedMemoButton
            // 
            this.LoadSavedMemoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.LoadSavedMemoButton.FlatAppearance.BorderSize = 0;
            this.LoadSavedMemoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.LoadSavedMemoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            this.LoadSavedMemoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadSavedMemoButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadSavedMemoButton.ForeColor = System.Drawing.Color.White;
            this.LoadSavedMemoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadSavedMemoButton.Location = new System.Drawing.Point(13, 223);
            this.LoadSavedMemoButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.LoadSavedMemoButton.Name = "LoadSavedMemoButton";
            this.LoadSavedMemoButton.Size = new System.Drawing.Size(273, 42);
            this.LoadSavedMemoButton.TabIndex = 1;
            this.LoadSavedMemoButton.Text = "Load";
            this.LoadSavedMemoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonToolTip.SetToolTip(this.LoadSavedMemoButton, "Load the selected memo");
            this.LoadSavedMemoButton.UseVisualStyleBackColor = false;
            this.LoadSavedMemoButton.Click += new System.EventHandler(this.LoadSavedMemoButton_Click);
            // 
            // RemoveSavedMemoButton
            // 
            this.RemoveSavedMemoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.RemoveSavedMemoButton.FlatAppearance.BorderSize = 0;
            this.RemoveSavedMemoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.RemoveSavedMemoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(135)))));
            this.RemoveSavedMemoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveSavedMemoButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveSavedMemoButton.ForeColor = System.Drawing.Color.White;
            this.RemoveSavedMemoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveSavedMemoButton.Location = new System.Drawing.Point(12, 272);
            this.RemoveSavedMemoButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.RemoveSavedMemoButton.Name = "RemoveSavedMemoButton";
            this.RemoveSavedMemoButton.Size = new System.Drawing.Size(274, 42);
            this.RemoveSavedMemoButton.TabIndex = 2;
            this.RemoveSavedMemoButton.Text = "Delete";
            this.RemoveSavedMemoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonToolTip.SetToolTip(this.RemoveSavedMemoButton, "Delete the selected memo");
            this.RemoveSavedMemoButton.UseVisualStyleBackColor = false;
            this.RemoveSavedMemoButton.Click += new System.EventHandler(this.RemoveSavedMemoButton_Click);
            // 
            // SavedMemoList
            // 
            this.SavedMemoList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SavedMemoList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SavedMemoList.FormattingEnabled = true;
            this.SavedMemoList.ItemHeight = 21;
            this.SavedMemoList.Location = new System.Drawing.Point(12, 25);
            this.SavedMemoList.Name = "SavedMemoList";
            this.SavedMemoList.Size = new System.Drawing.Size(274, 189);
            this.SavedMemoList.TabIndex = 0;
            // 
            // ReloadButton
            // 
            this.ReloadButton.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Sync_500px;
            this.ReloadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReloadButton.FlatAppearance.BorderSize = 0;
            this.ReloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReloadButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReloadButton.Location = new System.Drawing.Point(1026, 22);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(29, 29);
            this.ReloadButton.TabIndex = 9;
            this.ReloadButton.UseVisualStyleBackColor = true;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1070, 702);
            this.Controls.Add(this.ReloadButton);
            this.Controls.Add(this.SavedMemoGroup);
            this.Controls.Add(this.AmountGroup);
            this.Controls.Add(this.BasicInfoGroup);
            this.Controls.Add(this.ProductGroup);
            this.Controls.Add(this.CustomerGroup);
            this.Controls.Add(this.CartDataGrid);
            this.Controls.Add(this.RemoveSelectedButton);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sell";
            this.Load += new System.EventHandler(this.SaleForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGrid)).EndInit();
            this.CustomerGroup.ResumeLayout(false);
            this.CustomerGroup.PerformLayout();
            this.ProductGroup.ResumeLayout(false);
            this.ProductGroup.PerformLayout();
            this.BasicInfoGroup.ResumeLayout(false);
            this.BasicInfoGroup.PerformLayout();
            this.AmountGroup.ResumeLayout(false);
            this.AmountGroup.PerformLayout();
            this.SavedMemoGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ShopSelectorCombo;
        private System.Windows.Forms.Label SelectShopLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox QuantityText;
        private System.Windows.Forms.Label ProductSelectorLabel;
        private System.Windows.Forms.TextBox CompanyText;
        private System.Windows.Forms.Label CompanyLabel;
        private System.Windows.Forms.ComboBox CustomerCombo;
        private System.Windows.Forms.ComboBox ProductSelectorCombo;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.RadioButton RetailSaleRadio;
        private System.Windows.Forms.RadioButton WholeSaleRadio;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.Label TotalText;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button RemoveSelectedButton;
        private System.Windows.Forms.Label DiscountLabel;
        private System.Windows.Forms.TextBox DiscountPercentageText;
        private System.Windows.Forms.TextBox AddressText;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label PayableLabel;
        private System.Windows.Forms.TextBox PayableText;
        private System.Windows.Forms.Label PaidAmountLabel;
        private System.Windows.Forms.TextBox PaidAmountText;
        private System.Windows.Forms.TextBox LessAmountText;
        private System.Windows.Forms.Label PercentageLabel;
        private System.Windows.Forms.TextBox UnitPriceText;
        private System.Windows.Forms.TextBox AvailableQuantityText;
        private System.Windows.Forms.DataGridView CartDataGrid;
        private System.Windows.Forms.Label NewDueLabel;
        private System.Windows.Forms.TextBox DueText;
        private System.Windows.Forms.ComboBox UnitSelectorCombo;
        private System.Windows.Forms.RichTextBox NotesText;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.GroupBox CustomerGroup;
        private System.Windows.Forms.GroupBox ProductGroup;
        private System.Windows.Forms.GroupBox BasicInfoGroup;
        private System.Windows.Forms.DateTimePicker SaleDateTime;
        private System.Windows.Forms.GroupBox AmountGroup;
        private System.Windows.Forms.GroupBox SavedMemoGroup;
        private System.Windows.Forms.Button LoadSavedMemoButton;
        private System.Windows.Forms.Button RemoveSavedMemoButton;
        private System.Windows.Forms.ListBox SavedMemoList;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.TextBox CustomerNameText;
        private System.Windows.Forms.Button CustomerResetButton;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.Label CustomerSelectorLabel;
        private System.Windows.Forms.ToolTip ButtonToolTip;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ViewCustomerButton;
        private System.Windows.Forms.TextBox SaleNetPriceText;
        private System.Windows.Forms.Label UnitPriceLabel;
        private System.Windows.Forms.TextBox SaleUnitPriceText;
        private System.Windows.Forms.Label NetPriceLabel;
        private System.Windows.Forms.Button ReloadButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetPriceColumn;
        private System.Windows.Forms.Label SearchProductLabel;
        private System.Windows.Forms.TextBox SearchProductText;
        private System.Windows.Forms.TextBox FullPayableText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PreviousDueText;
        private System.Windows.Forms.TextBox FullDueText;
    }
}