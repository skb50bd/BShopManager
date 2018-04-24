namespace WinFormsUI.Forms {
    partial class PurchaseForm {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DealDateTime = new System.Windows.Forms.DateTimePicker();
            this.SavedVoucharGroup = new System.Windows.Forms.GroupBox();
            this.LoadSavedVoucharButton = new System.Windows.Forms.Button();
            this.RemoveSavedVoucharButton = new System.Windows.Forms.Button();
            this.SavedVoucharList = new System.Windows.Forms.ListBox();
            this.AmountGroup = new System.Windows.Forms.GroupBox();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PreviousDueText = new System.Windows.Forms.TextBox();
            this.FullDueText = new System.Windows.Forms.TextBox();
            this.LessAmountText = new System.Windows.Forms.TextBox();
            this.FullPayableText = new System.Windows.Forms.TextBox();
            this.PayableText = new System.Windows.Forms.TextBox();
            this.DiscountPercentageText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PayableLabel = new System.Windows.Forms.Label();
            this.DueText = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.PaidAmountText = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.PaidAmountLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalText = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ProductGroup = new System.Windows.Forms.GroupBox();
            this.NetPriceText = new System.Windows.Forms.TextBox();
            this.UnitPriceText = new System.Windows.Forms.TextBox();
            this.QuantityText = new System.Windows.Forms.TextBox();
            this.ViewProductButton = new System.Windows.Forms.Button();
            this.ResetProductButton = new System.Windows.Forms.Button();
            this.UnitPriceLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.WholeSalePriceText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RetailPriceText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GodownStockText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShopStockText = new System.Windows.Forms.TextBox();
            this.ProductSelectorLabel = new System.Windows.Forms.Label();
            this.ProductSelectorCombo = new System.Windows.Forms.ComboBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.UnitSelectorCombo = new System.Windows.Forms.ComboBox();
            this.NetPriceLabel = new System.Windows.Forms.Label();
            this.CustomerGroup = new System.Windows.Forms.GroupBox();
            this.ViewSupplierButton = new System.Windows.Forms.Button();
            this.ResetSupplierButton = new System.Windows.Forms.Button();
            this.AddSupplierButton = new System.Windows.Forms.Button();
            this.SupplierSelectorLabel = new System.Windows.Forms.Label();
            this.SupplierNameLabel = new System.Windows.Forms.Label();
            this.SupplierNameText = new System.Windows.Forms.TextBox();
            this.SupplierCombo = new System.Windows.Forms.ComboBox();
            this.CompanyLabel = new System.Windows.Forms.Label();
            this.CompanyText = new System.Windows.Forms.TextBox();
            this.NotesText = new System.Windows.Forms.RichTextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.CartDataGrid = new System.Windows.Forms.DataGridView();
            this.ProductIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveSelectedButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.buttonsInfo = new System.Windows.Forms.ToolTip(this.components);
            this.ReloadSuppliersProducts = new System.Windows.Forms.Button();
            this.SavedVoucharGroup.SuspendLayout();
            this.AmountGroup.SuspendLayout();
            this.ProductGroup.SuspendLayout();
            this.CustomerGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DealDateTime
            // 
            resources.ApplyResources(this.DealDateTime, "DealDateTime");
            this.DealDateTime.CalendarMonthBackground = System.Drawing.Color.White;
            this.DealDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DealDateTime.Name = "DealDateTime";
            this.buttonsInfo.SetToolTip(this.DealDateTime, resources.GetString("DealDateTime.ToolTip"));
            // 
            // SavedVoucharGroup
            // 
            resources.ApplyResources(this.SavedVoucharGroup, "SavedVoucharGroup");
            this.SavedVoucharGroup.Controls.Add(this.LoadSavedVoucharButton);
            this.SavedVoucharGroup.Controls.Add(this.RemoveSavedVoucharButton);
            this.SavedVoucharGroup.Controls.Add(this.SavedVoucharList);
            this.SavedVoucharGroup.Name = "SavedVoucharGroup";
            this.SavedVoucharGroup.TabStop = false;
            this.buttonsInfo.SetToolTip(this.SavedVoucharGroup, resources.GetString("SavedVoucharGroup.ToolTip"));
            // 
            // LoadSavedVoucharButton
            // 
            resources.ApplyResources(this.LoadSavedVoucharButton, "LoadSavedVoucharButton");
            this.LoadSavedVoucharButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.LoadSavedVoucharButton.FlatAppearance.BorderSize = 0;
            this.LoadSavedVoucharButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.LoadSavedVoucharButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            this.LoadSavedVoucharButton.ForeColor = System.Drawing.Color.White;
            this.LoadSavedVoucharButton.Name = "LoadSavedVoucharButton";
            this.buttonsInfo.SetToolTip(this.LoadSavedVoucharButton, resources.GetString("LoadSavedVoucharButton.ToolTip"));
            this.LoadSavedVoucharButton.UseVisualStyleBackColor = false;
            this.LoadSavedVoucharButton.Click += new System.EventHandler(this.LoadSavedVoucharButton_Click);
            // 
            // RemoveSavedVoucharButton
            // 
            resources.ApplyResources(this.RemoveSavedVoucharButton, "RemoveSavedVoucharButton");
            this.RemoveSavedVoucharButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.RemoveSavedVoucharButton.FlatAppearance.BorderSize = 0;
            this.RemoveSavedVoucharButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.RemoveSavedVoucharButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(135)))));
            this.RemoveSavedVoucharButton.ForeColor = System.Drawing.Color.White;
            this.RemoveSavedVoucharButton.Name = "RemoveSavedVoucharButton";
            this.buttonsInfo.SetToolTip(this.RemoveSavedVoucharButton, resources.GetString("RemoveSavedVoucharButton.ToolTip"));
            this.RemoveSavedVoucharButton.UseVisualStyleBackColor = false;
            this.RemoveSavedVoucharButton.Click += new System.EventHandler(this.RemoveSavedVoucharButton_Click);
            // 
            // SavedVoucharList
            // 
            resources.ApplyResources(this.SavedVoucharList, "SavedVoucharList");
            this.SavedVoucharList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SavedVoucharList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SavedVoucharList.FormattingEnabled = true;
            this.SavedVoucharList.Name = "SavedVoucharList";
            this.buttonsInfo.SetToolTip(this.SavedVoucharList, resources.GetString("SavedVoucharList.ToolTip"));
            // 
            // AmountGroup
            // 
            resources.ApplyResources(this.AmountGroup, "AmountGroup");
            this.AmountGroup.Controls.Add(this.DiscountLabel);
            this.AmountGroup.Controls.Add(this.label5);
            this.AmountGroup.Controls.Add(this.PreviousDueText);
            this.AmountGroup.Controls.Add(this.FullDueText);
            this.AmountGroup.Controls.Add(this.LessAmountText);
            this.AmountGroup.Controls.Add(this.FullPayableText);
            this.AmountGroup.Controls.Add(this.PayableText);
            this.AmountGroup.Controls.Add(this.DiscountPercentageText);
            this.AmountGroup.Controls.Add(this.label10);
            this.AmountGroup.Controls.Add(this.PayableLabel);
            this.AmountGroup.Controls.Add(this.DueText);
            this.AmountGroup.Controls.Add(this.label12);
            this.AmountGroup.Controls.Add(this.PaidAmountText);
            this.AmountGroup.Controls.Add(this.SaveButton);
            this.AmountGroup.Controls.Add(this.PaidAmountLabel);
            this.AmountGroup.Controls.Add(this.TotalLabel);
            this.AmountGroup.Controls.Add(this.TotalText);
            this.AmountGroup.Controls.Add(this.SubmitButton);
            this.AmountGroup.Name = "AmountGroup";
            this.AmountGroup.TabStop = false;
            this.buttonsInfo.SetToolTip(this.AmountGroup, resources.GetString("AmountGroup.ToolTip"));
            // 
            // DiscountLabel
            // 
            resources.ApplyResources(this.DiscountLabel, "DiscountLabel");
            this.DiscountLabel.Name = "DiscountLabel";
            this.buttonsInfo.SetToolTip(this.DiscountLabel, resources.GetString("DiscountLabel.ToolTip"));
            this.DiscountLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.buttonsInfo.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // PreviousDueText
            // 
            resources.ApplyResources(this.PreviousDueText, "PreviousDueText");
            this.PreviousDueText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PreviousDueText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PreviousDueText.Name = "PreviousDueText";
            this.buttonsInfo.SetToolTip(this.PreviousDueText, resources.GetString("PreviousDueText.ToolTip"));
            // 
            // FullDueText
            // 
            resources.ApplyResources(this.FullDueText, "FullDueText");
            this.FullDueText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FullDueText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FullDueText.Name = "FullDueText";
            this.buttonsInfo.SetToolTip(this.FullDueText, resources.GetString("FullDueText.ToolTip"));
            // 
            // LessAmountText
            // 
            resources.ApplyResources(this.LessAmountText, "LessAmountText");
            this.LessAmountText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LessAmountText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LessAmountText.Name = "LessAmountText";
            this.buttonsInfo.SetToolTip(this.LessAmountText, resources.GetString("LessAmountText.ToolTip"));
            this.LessAmountText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LessAmountText_KeyDown);
            this.LessAmountText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            this.LessAmountText.Leave += new System.EventHandler(this.LessAmountText_TextChanged);
            // 
            // FullPayableText
            // 
            resources.ApplyResources(this.FullPayableText, "FullPayableText");
            this.FullPayableText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FullPayableText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FullPayableText.Name = "FullPayableText";
            this.buttonsInfo.SetToolTip(this.FullPayableText, resources.GetString("FullPayableText.ToolTip"));
            // 
            // PayableText
            // 
            resources.ApplyResources(this.PayableText, "PayableText");
            this.PayableText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PayableText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PayableText.Name = "PayableText";
            this.buttonsInfo.SetToolTip(this.PayableText, resources.GetString("PayableText.ToolTip"));
            // 
            // DiscountPercentageText
            // 
            resources.ApplyResources(this.DiscountPercentageText, "DiscountPercentageText");
            this.DiscountPercentageText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DiscountPercentageText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiscountPercentageText.Name = "DiscountPercentageText";
            this.buttonsInfo.SetToolTip(this.DiscountPercentageText, resources.GetString("DiscountPercentageText.ToolTip"));
            this.DiscountPercentageText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DiscountPercentageText_KeyDown);
            this.DiscountPercentageText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            this.DiscountPercentageText.Leave += new System.EventHandler(this.DiscountPercentageText_TextChanged);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            this.buttonsInfo.SetToolTip(this.label10, resources.GetString("label10.ToolTip"));
            this.label10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // PayableLabel
            // 
            resources.ApplyResources(this.PayableLabel, "PayableLabel");
            this.PayableLabel.Name = "PayableLabel";
            this.buttonsInfo.SetToolTip(this.PayableLabel, resources.GetString("PayableLabel.ToolTip"));
            this.PayableLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // DueText
            // 
            resources.ApplyResources(this.DueText, "DueText");
            this.DueText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DueText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DueText.Name = "DueText";
            this.buttonsInfo.SetToolTip(this.DueText, resources.GetString("DueText.ToolTip"));
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            this.buttonsInfo.SetToolTip(this.label12, resources.GetString("label12.ToolTip"));
            this.label12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // PaidAmountText
            // 
            resources.ApplyResources(this.PaidAmountText, "PaidAmountText");
            this.PaidAmountText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PaidAmountText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PaidAmountText.Name = "PaidAmountText";
            this.buttonsInfo.SetToolTip(this.PaidAmountText, resources.GetString("PaidAmountText.ToolTip"));
            this.PaidAmountText.TextChanged += new System.EventHandler(this.PaidAmountText_TextChanged_1);
            this.PaidAmountText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PaidAmountText_KeyDown);
            this.PaidAmountText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            this.PaidAmountText.Leave += new System.EventHandler(this.PaidAmountText_TextChanged);
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
            this.buttonsInfo.SetToolTip(this.SaveButton, resources.GetString("SaveButton.ToolTip"));
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // PaidAmountLabel
            // 
            resources.ApplyResources(this.PaidAmountLabel, "PaidAmountLabel");
            this.PaidAmountLabel.Name = "PaidAmountLabel";
            this.buttonsInfo.SetToolTip(this.PaidAmountLabel, resources.GetString("PaidAmountLabel.ToolTip"));
            this.PaidAmountLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TotalLabel
            // 
            resources.ApplyResources(this.TotalLabel, "TotalLabel");
            this.TotalLabel.Name = "TotalLabel";
            this.buttonsInfo.SetToolTip(this.TotalLabel, resources.GetString("TotalLabel.ToolTip"));
            this.TotalLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TotalText
            // 
            resources.ApplyResources(this.TotalText, "TotalText");
            this.TotalText.Name = "TotalText";
            this.buttonsInfo.SetToolTip(this.TotalText, resources.GetString("TotalText.ToolTip"));
            this.TotalText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
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
            this.buttonsInfo.SetToolTip(this.SubmitButton, resources.GetString("SubmitButton.ToolTip"));
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ProductGroup
            // 
            resources.ApplyResources(this.ProductGroup, "ProductGroup");
            this.ProductGroup.Controls.Add(this.NetPriceText);
            this.ProductGroup.Controls.Add(this.UnitPriceText);
            this.ProductGroup.Controls.Add(this.QuantityText);
            this.ProductGroup.Controls.Add(this.ViewProductButton);
            this.ProductGroup.Controls.Add(this.ResetProductButton);
            this.ProductGroup.Controls.Add(this.UnitPriceLabel);
            this.ProductGroup.Controls.Add(this.label3);
            this.ProductGroup.Controls.Add(this.AddProductButton);
            this.ProductGroup.Controls.Add(this.WholeSalePriceText);
            this.ProductGroup.Controls.Add(this.label4);
            this.ProductGroup.Controls.Add(this.RetailPriceText);
            this.ProductGroup.Controls.Add(this.label2);
            this.ProductGroup.Controls.Add(this.GodownStockText);
            this.ProductGroup.Controls.Add(this.label1);
            this.ProductGroup.Controls.Add(this.ShopStockText);
            this.ProductGroup.Controls.Add(this.ProductSelectorLabel);
            this.ProductGroup.Controls.Add(this.ProductSelectorCombo);
            this.ProductGroup.Controls.Add(this.QuantityLabel);
            this.ProductGroup.Controls.Add(this.AddToCartButton);
            this.ProductGroup.Controls.Add(this.UnitSelectorCombo);
            this.ProductGroup.Controls.Add(this.NetPriceLabel);
            this.ProductGroup.Name = "ProductGroup";
            this.ProductGroup.TabStop = false;
            this.buttonsInfo.SetToolTip(this.ProductGroup, resources.GetString("ProductGroup.ToolTip"));
            // 
            // NetPriceText
            // 
            resources.ApplyResources(this.NetPriceText, "NetPriceText");
            this.NetPriceText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NetPriceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NetPriceText.Name = "NetPriceText";
            this.buttonsInfo.SetToolTip(this.NetPriceText, resources.GetString("NetPriceText.ToolTip"));
            this.NetPriceText.TextChanged += new System.EventHandler(this.NetPriceText_TextChanged);
            this.NetPriceText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NetPriceText_KeyDown);
            this.NetPriceText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // UnitPriceText
            // 
            resources.ApplyResources(this.UnitPriceText, "UnitPriceText");
            this.UnitPriceText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UnitPriceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UnitPriceText.Name = "UnitPriceText";
            this.buttonsInfo.SetToolTip(this.UnitPriceText, resources.GetString("UnitPriceText.ToolTip"));
            this.UnitPriceText.TextChanged += new System.EventHandler(this.UnitPriceText_TextChanged);
            this.UnitPriceText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UnitPriceText_KeyDown);
            this.UnitPriceText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // QuantityText
            // 
            resources.ApplyResources(this.QuantityText, "QuantityText");
            this.QuantityText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.QuantityText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuantityText.Name = "QuantityText";
            this.buttonsInfo.SetToolTip(this.QuantityText, resources.GetString("QuantityText.ToolTip"));
            this.QuantityText.TextChanged += new System.EventHandler(this.QuantityText_TextChanged);
            this.QuantityText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QuantityText_KeyDown);
            this.QuantityText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // ViewProductButton
            // 
            resources.ApplyResources(this.ViewProductButton, "ViewProductButton");
            this.ViewProductButton.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Eye_96px;
            this.ViewProductButton.FlatAppearance.BorderSize = 0;
            this.ViewProductButton.Name = "ViewProductButton";
            this.buttonsInfo.SetToolTip(this.ViewProductButton, resources.GetString("ViewProductButton.ToolTip"));
            this.ViewProductButton.UseVisualStyleBackColor = true;
            this.ViewProductButton.Click += new System.EventHandler(this.ViewProductButton_Click);
            // 
            // ResetProductButton
            // 
            resources.ApplyResources(this.ResetProductButton, "ResetProductButton");
            this.ResetProductButton.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Reset_96px__2_;
            this.ResetProductButton.FlatAppearance.BorderSize = 0;
            this.ResetProductButton.Name = "ResetProductButton";
            this.buttonsInfo.SetToolTip(this.ResetProductButton, resources.GetString("ResetProductButton.ToolTip"));
            this.ResetProductButton.UseVisualStyleBackColor = true;
            this.ResetProductButton.Click += new System.EventHandler(this.ResetProductButton_Click);
            // 
            // UnitPriceLabel
            // 
            resources.ApplyResources(this.UnitPriceLabel, "UnitPriceLabel");
            this.UnitPriceLabel.Name = "UnitPriceLabel";
            this.buttonsInfo.SetToolTip(this.UnitPriceLabel, resources.GetString("UnitPriceLabel.ToolTip"));
            this.UnitPriceLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.buttonsInfo.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // AddProductButton
            // 
            resources.ApplyResources(this.AddProductButton, "AddProductButton");
            this.AddProductButton.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Plus_Math_96px_1;
            this.AddProductButton.FlatAppearance.BorderSize = 0;
            this.AddProductButton.Name = "AddProductButton";
            this.buttonsInfo.SetToolTip(this.AddProductButton, resources.GetString("AddProductButton.ToolTip"));
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // WholeSalePriceText
            // 
            resources.ApplyResources(this.WholeSalePriceText, "WholeSalePriceText");
            this.WholeSalePriceText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.WholeSalePriceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WholeSalePriceText.Name = "WholeSalePriceText";
            this.buttonsInfo.SetToolTip(this.WholeSalePriceText, resources.GetString("WholeSalePriceText.ToolTip"));
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.buttonsInfo.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // RetailPriceText
            // 
            resources.ApplyResources(this.RetailPriceText, "RetailPriceText");
            this.RetailPriceText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RetailPriceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RetailPriceText.Name = "RetailPriceText";
            this.buttonsInfo.SetToolTip(this.RetailPriceText, resources.GetString("RetailPriceText.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.buttonsInfo.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // GodownStockText
            // 
            resources.ApplyResources(this.GodownStockText, "GodownStockText");
            this.GodownStockText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GodownStockText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GodownStockText.Name = "GodownStockText";
            this.buttonsInfo.SetToolTip(this.GodownStockText, resources.GetString("GodownStockText.ToolTip"));
            this.GodownStockText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.buttonsInfo.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // ShopStockText
            // 
            resources.ApplyResources(this.ShopStockText, "ShopStockText");
            this.ShopStockText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ShopStockText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShopStockText.Name = "ShopStockText";
            this.buttonsInfo.SetToolTip(this.ShopStockText, resources.GetString("ShopStockText.ToolTip"));
            this.ShopStockText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // ProductSelectorLabel
            // 
            resources.ApplyResources(this.ProductSelectorLabel, "ProductSelectorLabel");
            this.ProductSelectorLabel.Name = "ProductSelectorLabel";
            this.buttonsInfo.SetToolTip(this.ProductSelectorLabel, resources.GetString("ProductSelectorLabel.ToolTip"));
            this.ProductSelectorLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // ProductSelectorCombo
            // 
            resources.ApplyResources(this.ProductSelectorCombo, "ProductSelectorCombo");
            this.ProductSelectorCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ProductSelectorCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ProductSelectorCombo.BackColor = System.Drawing.Color.White;
            this.ProductSelectorCombo.FormattingEnabled = true;
            this.ProductSelectorCombo.Name = "ProductSelectorCombo";
            this.buttonsInfo.SetToolTip(this.ProductSelectorCombo, resources.GetString("ProductSelectorCombo.ToolTip"));
            this.ProductSelectorCombo.SelectedIndexChanged += new System.EventHandler(this.ProductSelectorCombo_SelectedIndexChanged);
            this.ProductSelectorCombo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductSelectorCombo_KeyDown);
            // 
            // QuantityLabel
            // 
            resources.ApplyResources(this.QuantityLabel, "QuantityLabel");
            this.QuantityLabel.Name = "QuantityLabel";
            this.buttonsInfo.SetToolTip(this.QuantityLabel, resources.GetString("QuantityLabel.ToolTip"));
            this.QuantityLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
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
            this.buttonsInfo.SetToolTip(this.AddToCartButton, resources.GetString("AddToCartButton.ToolTip"));
            this.AddToCartButton.UseVisualStyleBackColor = false;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // UnitSelectorCombo
            // 
            resources.ApplyResources(this.UnitSelectorCombo, "UnitSelectorCombo");
            this.UnitSelectorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnitSelectorCombo.FormattingEnabled = true;
            this.UnitSelectorCombo.Name = "UnitSelectorCombo";
            this.buttonsInfo.SetToolTip(this.UnitSelectorCombo, resources.GetString("UnitSelectorCombo.ToolTip"));
            this.UnitSelectorCombo.SelectedIndexChanged += new System.EventHandler(this.UnitSelectorCombo_SelectedIndexChanged);
            // 
            // NetPriceLabel
            // 
            resources.ApplyResources(this.NetPriceLabel, "NetPriceLabel");
            this.NetPriceLabel.Name = "NetPriceLabel";
            this.buttonsInfo.SetToolTip(this.NetPriceLabel, resources.GetString("NetPriceLabel.ToolTip"));
            this.NetPriceLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // CustomerGroup
            // 
            resources.ApplyResources(this.CustomerGroup, "CustomerGroup");
            this.CustomerGroup.Controls.Add(this.ViewSupplierButton);
            this.CustomerGroup.Controls.Add(this.ResetSupplierButton);
            this.CustomerGroup.Controls.Add(this.AddSupplierButton);
            this.CustomerGroup.Controls.Add(this.SupplierSelectorLabel);
            this.CustomerGroup.Controls.Add(this.SupplierNameLabel);
            this.CustomerGroup.Controls.Add(this.SupplierNameText);
            this.CustomerGroup.Controls.Add(this.SupplierCombo);
            this.CustomerGroup.Controls.Add(this.CompanyLabel);
            this.CustomerGroup.Controls.Add(this.CompanyText);
            this.CustomerGroup.Controls.Add(this.NotesText);
            this.CustomerGroup.Controls.Add(this.AddressLabel);
            this.CustomerGroup.Controls.Add(this.NotesLabel);
            this.CustomerGroup.Controls.Add(this.AddressText);
            this.CustomerGroup.Name = "CustomerGroup";
            this.CustomerGroup.TabStop = false;
            this.buttonsInfo.SetToolTip(this.CustomerGroup, resources.GetString("CustomerGroup.ToolTip"));
            // 
            // ViewSupplierButton
            // 
            resources.ApplyResources(this.ViewSupplierButton, "ViewSupplierButton");
            this.ViewSupplierButton.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Eye_96px;
            this.ViewSupplierButton.FlatAppearance.BorderSize = 0;
            this.ViewSupplierButton.Name = "ViewSupplierButton";
            this.buttonsInfo.SetToolTip(this.ViewSupplierButton, resources.GetString("ViewSupplierButton.ToolTip"));
            this.ViewSupplierButton.UseVisualStyleBackColor = true;
            this.ViewSupplierButton.Click += new System.EventHandler(this.ViewSupplierButton_Click);
            // 
            // ResetSupplierButton
            // 
            resources.ApplyResources(this.ResetSupplierButton, "ResetSupplierButton");
            this.ResetSupplierButton.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Reset_96px__2_;
            this.ResetSupplierButton.FlatAppearance.BorderSize = 0;
            this.ResetSupplierButton.Name = "ResetSupplierButton";
            this.buttonsInfo.SetToolTip(this.ResetSupplierButton, resources.GetString("ResetSupplierButton.ToolTip"));
            this.ResetSupplierButton.UseVisualStyleBackColor = true;
            this.ResetSupplierButton.Click += new System.EventHandler(this.ResetSupplierButton_Click);
            // 
            // AddSupplierButton
            // 
            resources.ApplyResources(this.AddSupplierButton, "AddSupplierButton");
            this.AddSupplierButton.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Plus_Math_96px_1;
            this.AddSupplierButton.FlatAppearance.BorderSize = 0;
            this.AddSupplierButton.Name = "AddSupplierButton";
            this.buttonsInfo.SetToolTip(this.AddSupplierButton, resources.GetString("AddSupplierButton.ToolTip"));
            this.AddSupplierButton.UseVisualStyleBackColor = true;
            this.AddSupplierButton.Click += new System.EventHandler(this.AddSupplierButton_Click);
            // 
            // SupplierSelectorLabel
            // 
            resources.ApplyResources(this.SupplierSelectorLabel, "SupplierSelectorLabel");
            this.SupplierSelectorLabel.Name = "SupplierSelectorLabel";
            this.buttonsInfo.SetToolTip(this.SupplierSelectorLabel, resources.GetString("SupplierSelectorLabel.ToolTip"));
            this.SupplierSelectorLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // SupplierNameLabel
            // 
            resources.ApplyResources(this.SupplierNameLabel, "SupplierNameLabel");
            this.SupplierNameLabel.Name = "SupplierNameLabel";
            this.buttonsInfo.SetToolTip(this.SupplierNameLabel, resources.GetString("SupplierNameLabel.ToolTip"));
            this.SupplierNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // SupplierNameText
            // 
            resources.ApplyResources(this.SupplierNameText, "SupplierNameText");
            this.SupplierNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SupplierNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SupplierNameText.Name = "SupplierNameText";
            this.buttonsInfo.SetToolTip(this.SupplierNameText, resources.GetString("SupplierNameText.ToolTip"));
            this.SupplierNameText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SupplierNameText_KeyDown);
            // 
            // SupplierCombo
            // 
            resources.ApplyResources(this.SupplierCombo, "SupplierCombo");
            this.SupplierCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SupplierCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SupplierCombo.BackColor = System.Drawing.Color.White;
            this.SupplierCombo.FormattingEnabled = true;
            this.SupplierCombo.Name = "SupplierCombo";
            this.buttonsInfo.SetToolTip(this.SupplierCombo, resources.GetString("SupplierCombo.ToolTip"));
            this.SupplierCombo.SelectedIndexChanged += new System.EventHandler(this.SupplierCombo_SelectedIndexChanged);
            this.SupplierCombo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SupplierCombo_KeyDown);
            // 
            // CompanyLabel
            // 
            resources.ApplyResources(this.CompanyLabel, "CompanyLabel");
            this.CompanyLabel.Name = "CompanyLabel";
            this.buttonsInfo.SetToolTip(this.CompanyLabel, resources.GetString("CompanyLabel.ToolTip"));
            this.CompanyLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // CompanyText
            // 
            resources.ApplyResources(this.CompanyText, "CompanyText");
            this.CompanyText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CompanyText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyText.Name = "CompanyText";
            this.buttonsInfo.SetToolTip(this.CompanyText, resources.GetString("CompanyText.ToolTip"));
            this.CompanyText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CompanyText_KeyDown);
            // 
            // NotesText
            // 
            resources.ApplyResources(this.NotesText, "NotesText");
            this.NotesText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NotesText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NotesText.Name = "NotesText";
            this.buttonsInfo.SetToolTip(this.NotesText, resources.GetString("NotesText.ToolTip"));
            this.NotesText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NotesText_KeyDown);
            // 
            // AddressLabel
            // 
            resources.ApplyResources(this.AddressLabel, "AddressLabel");
            this.AddressLabel.Name = "AddressLabel";
            this.buttonsInfo.SetToolTip(this.AddressLabel, resources.GetString("AddressLabel.ToolTip"));
            this.AddressLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // NotesLabel
            // 
            resources.ApplyResources(this.NotesLabel, "NotesLabel");
            this.NotesLabel.Name = "NotesLabel";
            this.buttonsInfo.SetToolTip(this.NotesLabel, resources.GetString("NotesLabel.ToolTip"));
            this.NotesLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // AddressText
            // 
            resources.ApplyResources(this.AddressText, "AddressText");
            this.AddressText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddressText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressText.Name = "AddressText";
            this.buttonsInfo.SetToolTip(this.AddressText, resources.GetString("AddressText.ToolTip"));
            this.AddressText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddressText_KeyDown);
            // 
            // CartDataGrid
            // 
            resources.ApplyResources(this.CartDataGrid, "CartDataGrid");
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CartDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.CartDataGrid.GridColor = System.Drawing.Color.WhiteSmoke;
            this.CartDataGrid.Name = "CartDataGrid";
            this.CartDataGrid.ReadOnly = true;
            this.CartDataGrid.RowHeadersVisible = false;
            this.CartDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.buttonsInfo.SetToolTip(this.CartDataGrid, resources.GetString("CartDataGrid.ToolTip"));
            this.CartDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CartDataGrid_CellContentClick);
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
            this.UnitPriceColumn.DataPropertyName = "GetUnitPurchasePrice";
            resources.ApplyResources(this.UnitPriceColumn, "UnitPriceColumn");
            this.UnitPriceColumn.Name = "UnitPriceColumn";
            this.UnitPriceColumn.ReadOnly = true;
            // 
            // NetPriceColumn
            // 
            this.NetPriceColumn.DataPropertyName = "GetNetPurchasePrice";
            resources.ApplyResources(this.NetPriceColumn, "NetPriceColumn");
            this.NetPriceColumn.Name = "NetPriceColumn";
            this.NetPriceColumn.ReadOnly = true;
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
            this.buttonsInfo.SetToolTip(this.RemoveSelectedButton, resources.GetString("RemoveSelectedButton.ToolTip"));
            this.RemoveSelectedButton.UseVisualStyleBackColor = false;
            this.RemoveSelectedButton.Click += new System.EventHandler(this.RemoveSelectedButton_Click);
            // 
            // TitleLabel
            // 
            resources.ApplyResources(this.TitleLabel, "TitleLabel");
            this.TitleLabel.Name = "TitleLabel";
            this.buttonsInfo.SetToolTip(this.TitleLabel, resources.GetString("TitleLabel.ToolTip"));
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // ReloadSuppliersProducts
            // 
            resources.ApplyResources(this.ReloadSuppliersProducts, "ReloadSuppliersProducts");
            this.ReloadSuppliersProducts.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Sync_500px;
            this.ReloadSuppliersProducts.FlatAppearance.BorderSize = 0;
            this.ReloadSuppliersProducts.Name = "ReloadSuppliersProducts";
            this.buttonsInfo.SetToolTip(this.ReloadSuppliersProducts, resources.GetString("ReloadSuppliersProducts.ToolTip"));
            this.ReloadSuppliersProducts.UseVisualStyleBackColor = true;
            this.ReloadSuppliersProducts.Click += new System.EventHandler(this.ReloadSuppliersProducts_Click);
            // 
            // PurchaseForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ReloadSuppliersProducts);
            this.Controls.Add(this.DealDateTime);
            this.Controls.Add(this.SavedVoucharGroup);
            this.Controls.Add(this.AmountGroup);
            this.Controls.Add(this.ProductGroup);
            this.Controls.Add(this.CustomerGroup);
            this.Controls.Add(this.RemoveSelectedButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.CartDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PurchaseForm";
            this.buttonsInfo.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.PurchaseForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            this.SavedVoucharGroup.ResumeLayout(false);
            this.AmountGroup.ResumeLayout(false);
            this.AmountGroup.PerformLayout();
            this.ProductGroup.ResumeLayout(false);
            this.ProductGroup.PerformLayout();
            this.CustomerGroup.ResumeLayout(false);
            this.CustomerGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DealDateTime;
        private System.Windows.Forms.GroupBox SavedVoucharGroup;
        private System.Windows.Forms.Button LoadSavedVoucharButton;
        private System.Windows.Forms.Button RemoveSavedVoucharButton;
        private System.Windows.Forms.ListBox SavedVoucharList;
        private System.Windows.Forms.GroupBox AmountGroup;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label DiscountLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label TotalText;
        private System.Windows.Forms.TextBox LessAmountText;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label PayableLabel;
        private System.Windows.Forms.TextBox PaidAmountText;
        private System.Windows.Forms.Label PaidAmountLabel;
        private System.Windows.Forms.TextBox DiscountPercentageText;
        private System.Windows.Forms.GroupBox ProductGroup;
        private System.Windows.Forms.Label ProductSelectorLabel;
        private System.Windows.Forms.ComboBox ProductSelectorCombo;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.ComboBox UnitSelectorCombo;
        private System.Windows.Forms.TextBox QuantityText;
        private System.Windows.Forms.GroupBox CustomerGroup;
        private System.Windows.Forms.Label SupplierSelectorLabel;
        private System.Windows.Forms.Label SupplierNameLabel;
        private System.Windows.Forms.TextBox SupplierNameText;
        private System.Windows.Forms.ComboBox SupplierCombo;
        private System.Windows.Forms.Label CompanyLabel;
        private System.Windows.Forms.TextBox CompanyText;
        private System.Windows.Forms.RichTextBox NotesText;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.TextBox AddressText;
        private System.Windows.Forms.DataGridView CartDataGrid;
        private System.Windows.Forms.Button RemoveSelectedButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button ResetProductButton;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button ViewProductButton;
        private System.Windows.Forms.TextBox UnitPriceText;
        private System.Windows.Forms.Label UnitPriceLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox WholeSalePriceText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RetailPriceText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GodownStockText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ShopStockText;
        private System.Windows.Forms.Button ViewSupplierButton;
        private System.Windows.Forms.Button ResetSupplierButton;
        private System.Windows.Forms.Button AddSupplierButton;
        private System.Windows.Forms.TextBox NetPriceText;
        private System.Windows.Forms.Label NetPriceLabel;
        private System.Windows.Forms.ToolTip buttonsInfo;
        private System.Windows.Forms.Button ReloadSuppliersProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetPriceColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PreviousDueText;
        private System.Windows.Forms.TextBox FullDueText;
        private System.Windows.Forms.TextBox FullPayableText;
        private System.Windows.Forms.TextBox PayableText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox DueText;
        private System.Windows.Forms.Label label12;
    }
}