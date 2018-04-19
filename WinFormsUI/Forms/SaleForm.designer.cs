using ShopLibrary.Models;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.SaleUnitPriceText = new System.Windows.Forms.TextBox();
            this.NetPriceLabel = new System.Windows.Forms.Label();
            this.UnitPriceLabel = new System.Windows.Forms.Label();
            this.BasicInfoGroup = new System.Windows.Forms.GroupBox();
            this.DealDateTime = new System.Windows.Forms.DateTimePicker();
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
            this.RemoveSelectedButton = new System.Windows.Forms.Button();
            this.CartDataGrid = new System.Windows.Forms.DataGridView();
            this.ProductIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerGroup.SuspendLayout();
            this.ProductGroup.SuspendLayout();
            this.BasicInfoGroup.SuspendLayout();
            this.AmountGroup.SuspendLayout();
            this.SavedMemoGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ShopSelectorCombo
            // 
            resources.ApplyResources(this.ShopSelectorCombo, "ShopSelectorCombo");
            this.ShopSelectorCombo.BackColor = System.Drawing.Color.WhiteSmoke;
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
            // QuantityText
            // 
            resources.ApplyResources(this.QuantityText, "QuantityText");
            this.QuantityText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.QuantityText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuantityText.Name = "QuantityText";
            this.ButtonToolTip.SetToolTip(this.QuantityText, resources.GetString("QuantityText.ToolTip"));
            this.QuantityText.TextChanged += new System.EventHandler(this.QuantityText_TextChanged);
            this.QuantityText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QuantityText_KeyDown);
            this.QuantityText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // ProductSelectorLabel
            // 
            resources.ApplyResources(this.ProductSelectorLabel, "ProductSelectorLabel");
            this.ProductSelectorLabel.Name = "ProductSelectorLabel";
            this.ButtonToolTip.SetToolTip(this.ProductSelectorLabel, resources.GetString("ProductSelectorLabel.ToolTip"));
            this.ProductSelectorLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // CompanyText
            // 
            resources.ApplyResources(this.CompanyText, "CompanyText");
            this.CompanyText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CompanyText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyText.Name = "CompanyText";
            this.ButtonToolTip.SetToolTip(this.CompanyText, resources.GetString("CompanyText.ToolTip"));
            this.CompanyText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CompanyText_KeyDown);
            // 
            // CompanyLabel
            // 
            resources.ApplyResources(this.CompanyLabel, "CompanyLabel");
            this.CompanyLabel.Name = "CompanyLabel";
            this.ButtonToolTip.SetToolTip(this.CompanyLabel, resources.GetString("CompanyLabel.ToolTip"));
            this.CompanyLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // CustomerCombo
            // 
            resources.ApplyResources(this.CustomerCombo, "CustomerCombo");
            this.CustomerCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CustomerCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CustomerCombo.BackColor = System.Drawing.Color.White;
            this.CustomerCombo.FormattingEnabled = true;
            this.CustomerCombo.Name = "CustomerCombo";
            this.ButtonToolTip.SetToolTip(this.CustomerCombo, resources.GetString("CustomerCombo.ToolTip"));
            this.CustomerCombo.SelectedIndexChanged += new System.EventHandler(this.CustomerCombo_SelectedIndexChanged);
            this.CustomerCombo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomerCombo_KeyDown);
            // 
            // ProductSelectorCombo
            // 
            resources.ApplyResources(this.ProductSelectorCombo, "ProductSelectorCombo");
            this.ProductSelectorCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ProductSelectorCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ProductSelectorCombo.BackColor = System.Drawing.Color.White;
            this.ProductSelectorCombo.FormattingEnabled = true;
            this.ProductSelectorCombo.Name = "ProductSelectorCombo";
            this.ButtonToolTip.SetToolTip(this.ProductSelectorCombo, resources.GetString("ProductSelectorCombo.ToolTip"));
            this.ProductSelectorCombo.SelectedIndexChanged += new System.EventHandler(this.ProductSelectorCombo_SelectedIndexChanged);
            this.ProductSelectorCombo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductSelectorCombo_KeyDown);
            // 
            // QuantityLabel
            // 
            resources.ApplyResources(this.QuantityLabel, "QuantityLabel");
            this.QuantityLabel.Name = "QuantityLabel";
            this.ButtonToolTip.SetToolTip(this.QuantityLabel, resources.GetString("QuantityLabel.ToolTip"));
            this.QuantityLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // RetailSaleRadio
            // 
            resources.ApplyResources(this.RetailSaleRadio, "RetailSaleRadio");
            this.RetailSaleRadio.FlatAppearance.BorderSize = 0;
            this.RetailSaleRadio.Name = "RetailSaleRadio";
            this.RetailSaleRadio.TabStop = true;
            this.ButtonToolTip.SetToolTip(this.RetailSaleRadio, resources.GetString("RetailSaleRadio.ToolTip"));
            this.RetailSaleRadio.UseVisualStyleBackColor = true;
            this.RetailSaleRadio.CheckedChanged += new System.EventHandler(this.RetailSaleRadio_CheckedChanged);
            this.RetailSaleRadio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RetailSaleRadio_KeyDown);
            // 
            // WholeSaleRadio
            // 
            resources.ApplyResources(this.WholeSaleRadio, "WholeSaleRadio");
            this.WholeSaleRadio.FlatAppearance.BorderSize = 0;
            this.WholeSaleRadio.Name = "WholeSaleRadio";
            this.WholeSaleRadio.TabStop = true;
            this.ButtonToolTip.SetToolTip(this.WholeSaleRadio, resources.GetString("WholeSaleRadio.ToolTip"));
            this.WholeSaleRadio.UseVisualStyleBackColor = true;
            this.WholeSaleRadio.CheckedChanged += new System.EventHandler(this.WholeSaleRadio_CheckedChanged);
            this.WholeSaleRadio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RetailSaleRadio_KeyDown);
            // 
            // AddToCartButton
            // 
            resources.ApplyResources(this.AddToCartButton, "AddToCartButton");
            this.AddToCartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.AddToCartButton.FlatAppearance.BorderSize = 0;
            this.AddToCartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.AddToCartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            this.AddToCartButton.ForeColor = System.Drawing.Color.White;
            this.AddToCartButton.Name = "AddToCartButton";
            this.ButtonToolTip.SetToolTip(this.AddToCartButton, resources.GetString("AddToCartButton.ToolTip"));
            this.AddToCartButton.UseVisualStyleBackColor = false;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // TotalText
            // 
            resources.ApplyResources(this.TotalText, "TotalText");
            this.TotalText.Name = "TotalText";
            this.ButtonToolTip.SetToolTip(this.TotalText, resources.GetString("TotalText.ToolTip"));
            this.TotalText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TotalLabel
            // 
            resources.ApplyResources(this.TotalLabel, "TotalLabel");
            this.TotalLabel.Name = "TotalLabel";
            this.ButtonToolTip.SetToolTip(this.TotalLabel, resources.GetString("TotalLabel.ToolTip"));
            this.TotalLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // SubmitButton
            // 
            resources.ApplyResources(this.SubmitButton, "SubmitButton");
            this.SubmitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.SubmitButton.FlatAppearance.BorderSize = 0;
            this.SubmitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.SubmitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            this.SubmitButton.ForeColor = System.Drawing.Color.White;
            this.SubmitButton.Name = "SubmitButton";
            this.ButtonToolTip.SetToolTip(this.SubmitButton, resources.GetString("SubmitButton.ToolTip"));
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // DiscountLabel
            // 
            resources.ApplyResources(this.DiscountLabel, "DiscountLabel");
            this.DiscountLabel.Name = "DiscountLabel";
            this.ButtonToolTip.SetToolTip(this.DiscountLabel, resources.GetString("DiscountLabel.ToolTip"));
            this.DiscountLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // DiscountPercentageText
            // 
            resources.ApplyResources(this.DiscountPercentageText, "DiscountPercentageText");
            this.DiscountPercentageText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DiscountPercentageText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiscountPercentageText.Name = "DiscountPercentageText";
            this.ButtonToolTip.SetToolTip(this.DiscountPercentageText, resources.GetString("DiscountPercentageText.ToolTip"));
            this.DiscountPercentageText.TextChanged += new System.EventHandler(this.DiscountPercentageText_TextChanged);
            this.DiscountPercentageText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DiscountPercentageText_KeyDown);
            this.DiscountPercentageText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // AddressText
            // 
            resources.ApplyResources(this.AddressText, "AddressText");
            this.AddressText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddressText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressText.Name = "AddressText";
            this.ButtonToolTip.SetToolTip(this.AddressText, resources.GetString("AddressText.ToolTip"));
            this.AddressText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddressText_KeyDown);
            // 
            // AddressLabel
            // 
            resources.ApplyResources(this.AddressLabel, "AddressLabel");
            this.AddressLabel.Name = "AddressLabel";
            this.ButtonToolTip.SetToolTip(this.AddressLabel, resources.GetString("AddressLabel.ToolTip"));
            this.AddressLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // PayableLabel
            // 
            resources.ApplyResources(this.PayableLabel, "PayableLabel");
            this.PayableLabel.Name = "PayableLabel";
            this.ButtonToolTip.SetToolTip(this.PayableLabel, resources.GetString("PayableLabel.ToolTip"));
            this.PayableLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // PayableText
            // 
            resources.ApplyResources(this.PayableText, "PayableText");
            this.PayableText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PayableText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PayableText.Name = "PayableText";
            this.ButtonToolTip.SetToolTip(this.PayableText, resources.GetString("PayableText.ToolTip"));
            // 
            // PaidAmountLabel
            // 
            resources.ApplyResources(this.PaidAmountLabel, "PaidAmountLabel");
            this.PaidAmountLabel.Name = "PaidAmountLabel";
            this.ButtonToolTip.SetToolTip(this.PaidAmountLabel, resources.GetString("PaidAmountLabel.ToolTip"));
            this.PaidAmountLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // PaidAmountText
            // 
            resources.ApplyResources(this.PaidAmountText, "PaidAmountText");
            this.PaidAmountText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PaidAmountText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PaidAmountText.Name = "PaidAmountText";
            this.ButtonToolTip.SetToolTip(this.PaidAmountText, resources.GetString("PaidAmountText.ToolTip"));
            this.PaidAmountText.TextChanged += new System.EventHandler(this.PaidAmountText_TextChanged);
            this.PaidAmountText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PaidAmountText_KeyDown);
            this.PaidAmountText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // LessAmountText
            // 
            resources.ApplyResources(this.LessAmountText, "LessAmountText");
            this.LessAmountText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LessAmountText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LessAmountText.Name = "LessAmountText";
            this.ButtonToolTip.SetToolTip(this.LessAmountText, resources.GetString("LessAmountText.ToolTip"));
            this.LessAmountText.TextChanged += new System.EventHandler(this.LessAmountText_TextChanged);
            this.LessAmountText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LessAmountText_KeyDown);
            this.LessAmountText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // PercentageLabel
            // 
            resources.ApplyResources(this.PercentageLabel, "PercentageLabel");
            this.PercentageLabel.Name = "PercentageLabel";
            this.ButtonToolTip.SetToolTip(this.PercentageLabel, resources.GetString("PercentageLabel.ToolTip"));
            this.PercentageLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // UnitPriceText
            // 
            resources.ApplyResources(this.UnitPriceText, "UnitPriceText");
            this.UnitPriceText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UnitPriceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UnitPriceText.Name = "UnitPriceText";
            this.ButtonToolTip.SetToolTip(this.UnitPriceText, resources.GetString("UnitPriceText.ToolTip"));
            // 
            // AvailableQuantityText
            // 
            resources.ApplyResources(this.AvailableQuantityText, "AvailableQuantityText");
            this.AvailableQuantityText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AvailableQuantityText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AvailableQuantityText.Name = "AvailableQuantityText";
            this.ButtonToolTip.SetToolTip(this.AvailableQuantityText, resources.GetString("AvailableQuantityText.ToolTip"));
            // 
            // NewDueLabel
            // 
            resources.ApplyResources(this.NewDueLabel, "NewDueLabel");
            this.NewDueLabel.Name = "NewDueLabel";
            this.ButtonToolTip.SetToolTip(this.NewDueLabel, resources.GetString("NewDueLabel.ToolTip"));
            this.NewDueLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // DueText
            // 
            resources.ApplyResources(this.DueText, "DueText");
            this.DueText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DueText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DueText.Name = "DueText";
            this.ButtonToolTip.SetToolTip(this.DueText, resources.GetString("DueText.ToolTip"));
            // 
            // UnitSelectorCombo
            // 
            resources.ApplyResources(this.UnitSelectorCombo, "UnitSelectorCombo");
            this.UnitSelectorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnitSelectorCombo.FormattingEnabled = true;
            this.UnitSelectorCombo.Name = "UnitSelectorCombo";
            this.ButtonToolTip.SetToolTip(this.UnitSelectorCombo, resources.GetString("UnitSelectorCombo.ToolTip"));
            this.UnitSelectorCombo.SelectedIndexChanged += new System.EventHandler(this.UnitSelectorCombo_SelectedIndexChanged);
            // 
            // NotesText
            // 
            resources.ApplyResources(this.NotesText, "NotesText");
            this.NotesText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NotesText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NotesText.Name = "NotesText";
            this.ButtonToolTip.SetToolTip(this.NotesText, resources.GetString("NotesText.ToolTip"));
            // 
            // NotesLabel
            // 
            resources.ApplyResources(this.NotesLabel, "NotesLabel");
            this.NotesLabel.Name = "NotesLabel";
            this.ButtonToolTip.SetToolTip(this.NotesLabel, resources.GetString("NotesLabel.ToolTip"));
            this.NotesLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // CustomerGroup
            // 
            resources.ApplyResources(this.CustomerGroup, "CustomerGroup");
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
            this.CustomerGroup.Name = "CustomerGroup";
            this.CustomerGroup.TabStop = false;
            this.ButtonToolTip.SetToolTip(this.CustomerGroup, resources.GetString("CustomerGroup.ToolTip"));
            // 
            // ViewCustomerButton
            // 
            resources.ApplyResources(this.ViewCustomerButton, "ViewCustomerButton");
            this.ViewCustomerButton.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Eye_96px;
            this.ViewCustomerButton.FlatAppearance.BorderSize = 0;
            this.ViewCustomerButton.Name = "ViewCustomerButton";
            this.ButtonToolTip.SetToolTip(this.ViewCustomerButton, resources.GetString("ViewCustomerButton.ToolTip"));
            this.ViewCustomerButton.UseVisualStyleBackColor = true;
            this.ViewCustomerButton.Click += new System.EventHandler(this.ViewCustomerButton_Click);
            // 
            // CustomerSelectorLabel
            // 
            resources.ApplyResources(this.CustomerSelectorLabel, "CustomerSelectorLabel");
            this.CustomerSelectorLabel.Name = "CustomerSelectorLabel";
            this.ButtonToolTip.SetToolTip(this.CustomerSelectorLabel, resources.GetString("CustomerSelectorLabel.ToolTip"));
            // 
            // CustomerResetButton
            // 
            resources.ApplyResources(this.CustomerResetButton, "CustomerResetButton");
            this.CustomerResetButton.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Reset_512px;
            this.CustomerResetButton.FlatAppearance.BorderSize = 0;
            this.CustomerResetButton.Name = "CustomerResetButton";
            this.ButtonToolTip.SetToolTip(this.CustomerResetButton, resources.GetString("CustomerResetButton.ToolTip"));
            this.CustomerResetButton.UseVisualStyleBackColor = true;
            this.CustomerResetButton.Click += new System.EventHandler(this.CustomerResetButton_Click);
            // 
            // AddCustomerButton
            // 
            resources.ApplyResources(this.AddCustomerButton, "AddCustomerButton");
            this.AddCustomerButton.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Plus_Math_96px_1;
            this.AddCustomerButton.FlatAppearance.BorderSize = 0;
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.ButtonToolTip.SetToolTip(this.AddCustomerButton, resources.GetString("AddCustomerButton.ToolTip"));
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // CustomerNameLabel
            // 
            resources.ApplyResources(this.CustomerNameLabel, "CustomerNameLabel");
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.ButtonToolTip.SetToolTip(this.CustomerNameLabel, resources.GetString("CustomerNameLabel.ToolTip"));
            // 
            // CustomerNameText
            // 
            resources.ApplyResources(this.CustomerNameText, "CustomerNameText");
            this.CustomerNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CustomerNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerNameText.Name = "CustomerNameText";
            this.ButtonToolTip.SetToolTip(this.CustomerNameText, resources.GetString("CustomerNameText.ToolTip"));
            this.CustomerNameText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomerNameText_KeyDown);
            // 
            // ProductGroup
            // 
            resources.ApplyResources(this.ProductGroup, "ProductGroup");
            this.ProductGroup.Controls.Add(this.SearchProductLabel);
            this.ProductGroup.Controls.Add(this.SearchProductText);
            this.ProductGroup.Controls.Add(this.SaleNetPriceText);
            this.ProductGroup.Controls.Add(this.WholeSaleRadio);
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
            this.ProductGroup.Controls.Add(this.UnitPriceLabel);
            this.ProductGroup.Name = "ProductGroup";
            this.ProductGroup.TabStop = false;
            this.ButtonToolTip.SetToolTip(this.ProductGroup, resources.GetString("ProductGroup.ToolTip"));
            // 
            // SearchProductLabel
            // 
            resources.ApplyResources(this.SearchProductLabel, "SearchProductLabel");
            this.SearchProductLabel.Name = "SearchProductLabel";
            this.ButtonToolTip.SetToolTip(this.SearchProductLabel, resources.GetString("SearchProductLabel.ToolTip"));
            // 
            // SearchProductText
            // 
            resources.ApplyResources(this.SearchProductText, "SearchProductText");
            this.SearchProductText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SearchProductText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchProductText.Name = "SearchProductText";
            this.ButtonToolTip.SetToolTip(this.SearchProductText, resources.GetString("SearchProductText.ToolTip"));
            this.SearchProductText.TextChanged += new System.EventHandler(this.SearchProductText_TextChanged);
            this.SearchProductText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchProductText_KeyDown);
            // 
            // SaleNetPriceText
            // 
            resources.ApplyResources(this.SaleNetPriceText, "SaleNetPriceText");
            this.SaleNetPriceText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SaleNetPriceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SaleNetPriceText.Name = "SaleNetPriceText";
            this.ButtonToolTip.SetToolTip(this.SaleNetPriceText, resources.GetString("SaleNetPriceText.ToolTip"));
            this.SaleNetPriceText.TextChanged += new System.EventHandler(this.SaleNetPriceText_TextChanged);
            this.SaleNetPriceText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SaleNetPriceText_KeyDown);
            this.SaleNetPriceText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            this.SaleNetPriceText.Leave += new System.EventHandler(this.SaleNetPriceText_Leave);
            // 
            // SaleUnitPriceText
            // 
            resources.ApplyResources(this.SaleUnitPriceText, "SaleUnitPriceText");
            this.SaleUnitPriceText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SaleUnitPriceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SaleUnitPriceText.Name = "SaleUnitPriceText";
            this.ButtonToolTip.SetToolTip(this.SaleUnitPriceText, resources.GetString("SaleUnitPriceText.ToolTip"));
            this.SaleUnitPriceText.TextChanged += new System.EventHandler(this.SaleUnitPriceText_TextChanged);
            this.SaleUnitPriceText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SaleUnitPriceText_KeyDown);
            this.SaleUnitPriceText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // NetPriceLabel
            // 
            resources.ApplyResources(this.NetPriceLabel, "NetPriceLabel");
            this.NetPriceLabel.Name = "NetPriceLabel";
            this.ButtonToolTip.SetToolTip(this.NetPriceLabel, resources.GetString("NetPriceLabel.ToolTip"));
            // 
            // UnitPriceLabel
            // 
            resources.ApplyResources(this.UnitPriceLabel, "UnitPriceLabel");
            this.UnitPriceLabel.Name = "UnitPriceLabel";
            this.ButtonToolTip.SetToolTip(this.UnitPriceLabel, resources.GetString("UnitPriceLabel.ToolTip"));
            // 
            // BasicInfoGroup
            // 
            resources.ApplyResources(this.BasicInfoGroup, "BasicInfoGroup");
            this.BasicInfoGroup.Controls.Add(this.SelectShopLabel);
            this.BasicInfoGroup.Controls.Add(this.DealDateTime);
            this.BasicInfoGroup.Controls.Add(this.ShopSelectorCombo);
            this.BasicInfoGroup.Name = "BasicInfoGroup";
            this.BasicInfoGroup.TabStop = false;
            this.ButtonToolTip.SetToolTip(this.BasicInfoGroup, resources.GetString("BasicInfoGroup.ToolTip"));
            // 
            // DealDateTime
            // 
            resources.ApplyResources(this.DealDateTime, "DealDateTime");
            this.DealDateTime.CalendarMonthBackground = System.Drawing.Color.White;
            this.DealDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DealDateTime.Name = "DealDateTime";
            this.ButtonToolTip.SetToolTip(this.DealDateTime, resources.GetString("DealDateTime.ToolTip"));
            // 
            // AmountGroup
            // 
            resources.ApplyResources(this.AmountGroup, "AmountGroup");
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
            this.AmountGroup.Name = "AmountGroup";
            this.AmountGroup.TabStop = false;
            this.ButtonToolTip.SetToolTip(this.AmountGroup, resources.GetString("AmountGroup.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.ButtonToolTip.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // PreviousDueText
            // 
            resources.ApplyResources(this.PreviousDueText, "PreviousDueText");
            this.PreviousDueText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PreviousDueText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PreviousDueText.Name = "PreviousDueText";
            this.ButtonToolTip.SetToolTip(this.PreviousDueText, resources.GetString("PreviousDueText.ToolTip"));
            // 
            // FullDueText
            // 
            resources.ApplyResources(this.FullDueText, "FullDueText");
            this.FullDueText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FullDueText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FullDueText.Name = "FullDueText";
            this.ButtonToolTip.SetToolTip(this.FullDueText, resources.GetString("FullDueText.ToolTip"));
            // 
            // FullPayableText
            // 
            resources.ApplyResources(this.FullPayableText, "FullPayableText");
            this.FullPayableText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FullPayableText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FullPayableText.Name = "FullPayableText";
            this.ButtonToolTip.SetToolTip(this.FullPayableText, resources.GetString("FullPayableText.ToolTip"));
            // 
            // SaveButton
            // 
            resources.ApplyResources(this.SaveButton, "SaveButton");
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(170)))));
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Name = "SaveButton";
            this.ButtonToolTip.SetToolTip(this.SaveButton, resources.GetString("SaveButton.ToolTip"));
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // SavedMemoGroup
            // 
            resources.ApplyResources(this.SavedMemoGroup, "SavedMemoGroup");
            this.SavedMemoGroup.Controls.Add(this.LoadSavedMemoButton);
            this.SavedMemoGroup.Controls.Add(this.RemoveSavedMemoButton);
            this.SavedMemoGroup.Controls.Add(this.SavedMemoList);
            this.SavedMemoGroup.Name = "SavedMemoGroup";
            this.SavedMemoGroup.TabStop = false;
            this.ButtonToolTip.SetToolTip(this.SavedMemoGroup, resources.GetString("SavedMemoGroup.ToolTip"));
            // 
            // LoadSavedMemoButton
            // 
            resources.ApplyResources(this.LoadSavedMemoButton, "LoadSavedMemoButton");
            this.LoadSavedMemoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.LoadSavedMemoButton.FlatAppearance.BorderSize = 0;
            this.LoadSavedMemoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.LoadSavedMemoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            this.LoadSavedMemoButton.ForeColor = System.Drawing.Color.White;
            this.LoadSavedMemoButton.Name = "LoadSavedMemoButton";
            this.ButtonToolTip.SetToolTip(this.LoadSavedMemoButton, resources.GetString("LoadSavedMemoButton.ToolTip"));
            this.LoadSavedMemoButton.UseVisualStyleBackColor = false;
            this.LoadSavedMemoButton.Click += new System.EventHandler(this.LoadSavedMemoButton_Click);
            // 
            // RemoveSavedMemoButton
            // 
            resources.ApplyResources(this.RemoveSavedMemoButton, "RemoveSavedMemoButton");
            this.RemoveSavedMemoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.RemoveSavedMemoButton.FlatAppearance.BorderSize = 0;
            this.RemoveSavedMemoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.RemoveSavedMemoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(135)))));
            this.RemoveSavedMemoButton.ForeColor = System.Drawing.Color.White;
            this.RemoveSavedMemoButton.Name = "RemoveSavedMemoButton";
            this.ButtonToolTip.SetToolTip(this.RemoveSavedMemoButton, resources.GetString("RemoveSavedMemoButton.ToolTip"));
            this.RemoveSavedMemoButton.UseVisualStyleBackColor = false;
            this.RemoveSavedMemoButton.Click += new System.EventHandler(this.RemoveSavedMemoButton_Click);
            // 
            // SavedMemoList
            // 
            resources.ApplyResources(this.SavedMemoList, "SavedMemoList");
            this.SavedMemoList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SavedMemoList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SavedMemoList.FormattingEnabled = true;
            this.SavedMemoList.Name = "SavedMemoList";
            this.ButtonToolTip.SetToolTip(this.SavedMemoList, resources.GetString("SavedMemoList.ToolTip"));
            // 
            // ReloadButton
            // 
            resources.ApplyResources(this.ReloadButton, "ReloadButton");
            this.ReloadButton.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Sync_500px;
            this.ReloadButton.FlatAppearance.BorderSize = 0;
            this.ReloadButton.Name = "ReloadButton";
            this.ButtonToolTip.SetToolTip(this.ReloadButton, resources.GetString("ReloadButton.ToolTip"));
            this.ReloadButton.UseVisualStyleBackColor = true;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // RemoveSelectedButton
            // 
            resources.ApplyResources(this.RemoveSelectedButton, "RemoveSelectedButton");
            this.RemoveSelectedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.RemoveSelectedButton.FlatAppearance.BorderSize = 0;
            this.RemoveSelectedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.RemoveSelectedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(135)))));
            this.RemoveSelectedButton.ForeColor = System.Drawing.Color.White;
            this.RemoveSelectedButton.Name = "RemoveSelectedButton";
            this.ButtonToolTip.SetToolTip(this.RemoveSelectedButton, resources.GetString("RemoveSelectedButton.ToolTip"));
            this.RemoveSelectedButton.UseVisualStyleBackColor = false;
            this.RemoveSelectedButton.Click += new System.EventHandler(this.RemoveSelectedButton_Click);
            // 
            // CartDataGrid
            // 
            resources.ApplyResources(this.CartDataGrid, "CartDataGrid");
            this.CartDataGrid.AllowUserToAddRows = false;
            this.CartDataGrid.AllowUserToDeleteRows = false;
            this.CartDataGrid.AllowUserToResizeRows = false;
            this.CartDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.CartDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.CartDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CartDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.CartDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CartDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.CartDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductIdColumn,
            this.ProductNameColumn,
            this.QuantityColumn,
            this.UnitNameColumn,
            this.UnitPriceColumn,
            this.NetPriceColumn});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CartDataGrid.DefaultCellStyle = dataGridViewCellStyle18;
            this.CartDataGrid.GridColor = System.Drawing.Color.WhiteSmoke;
            this.CartDataGrid.Name = "CartDataGrid";
            this.CartDataGrid.ReadOnly = true;
            this.CartDataGrid.RowHeadersVisible = false;
            this.CartDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ButtonToolTip.SetToolTip(this.CartDataGrid, resources.GetString("CartDataGrid.ToolTip"));
            // 
            // ProductIdColumn
            // 
            this.ProductIdColumn.DataPropertyName = "GetProductId";
            resources.ApplyResources(this.ProductIdColumn, "ProductIdColumn");
            this.ProductIdColumn.Name = "ProductIdColumn";
            this.ProductIdColumn.ReadOnly = true;
            // 
            // ProductNameColumn
            // 
            this.ProductNameColumn.DataPropertyName = "ProductName";
            resources.ApplyResources(this.ProductNameColumn, "ProductNameColumn");
            this.ProductNameColumn.Name = "ProductNameColumn";
            this.ProductNameColumn.ReadOnly = true;
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.DataPropertyName = "GetQuantity";
            resources.ApplyResources(this.QuantityColumn, "QuantityColumn");
            this.QuantityColumn.Name = "QuantityColumn";
            this.QuantityColumn.ReadOnly = true;
            // 
            // UnitNameColumn
            // 
            this.UnitNameColumn.DataPropertyName = "GetUnitName";
            resources.ApplyResources(this.UnitNameColumn, "UnitNameColumn");
            this.UnitNameColumn.Name = "UnitNameColumn";
            this.UnitNameColumn.ReadOnly = true;
            // 
            // UnitPriceColumn
            // 
            this.UnitPriceColumn.DataPropertyName = "GetUnitPrice";
            resources.ApplyResources(this.UnitPriceColumn, "UnitPriceColumn");
            this.UnitPriceColumn.Name = "UnitPriceColumn";
            this.UnitPriceColumn.ReadOnly = true;
            // 
            // NetPriceColumn
            // 
            this.NetPriceColumn.DataPropertyName = "GetNetPrice";
            resources.ApplyResources(this.NetPriceColumn, "NetPriceColumn");
            this.NetPriceColumn.Name = "NetPriceColumn";
            this.NetPriceColumn.ReadOnly = true;
            // 
            // SaleForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.CartDataGrid);
            this.Controls.Add(this.RemoveSelectedButton);
            this.Controls.Add(this.ReloadButton);
            this.Controls.Add(this.SavedMemoGroup);
            this.Controls.Add(this.AmountGroup);
            this.Controls.Add(this.BasicInfoGroup);
            this.Controls.Add(this.ProductGroup);
            this.Controls.Add(this.CustomerGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SaleForm";
            this.ButtonToolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.SaleForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            this.CustomerGroup.ResumeLayout(false);
            this.CustomerGroup.PerformLayout();
            this.ProductGroup.ResumeLayout(false);
            this.ProductGroup.PerformLayout();
            this.BasicInfoGroup.ResumeLayout(false);
            this.BasicInfoGroup.PerformLayout();
            this.AmountGroup.ResumeLayout(false);
            this.AmountGroup.PerformLayout();
            this.SavedMemoGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGrid)).EndInit();
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
        private System.Windows.Forms.Label NewDueLabel;
        private System.Windows.Forms.TextBox DueText;
        private System.Windows.Forms.ComboBox UnitSelectorCombo;
        private System.Windows.Forms.RichTextBox NotesText;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.GroupBox CustomerGroup;
        private System.Windows.Forms.GroupBox ProductGroup;
        private System.Windows.Forms.GroupBox BasicInfoGroup;
        private System.Windows.Forms.DateTimePicker DealDateTime;
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
        private System.Windows.Forms.Label SearchProductLabel;
        private System.Windows.Forms.TextBox SearchProductText;
        private System.Windows.Forms.TextBox FullPayableText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PreviousDueText;
        private System.Windows.Forms.TextBox FullDueText;
        private System.Windows.Forms.Button RemoveSelectedButton;
        private System.Windows.Forms.DataGridView CartDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetPriceColumn;
    }
}