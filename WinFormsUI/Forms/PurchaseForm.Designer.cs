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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseForm));
            this.DealDateTime = new System.Windows.Forms.DateTimePicker();
            this.SavedVoucharGroup = new System.Windows.Forms.GroupBox();
            this.LoadSavedVoucharButton = new System.Windows.Forms.Button();
            this.RemoveSavedVoucharButton = new System.Windows.Forms.Button();
            this.SavedVoucharList = new System.Windows.Forms.ListBox();
            this.AmountGroup = new System.Windows.Forms.GroupBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalText = new System.Windows.Forms.Label();
            this.LessAmountText = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.PayableLabel = new System.Windows.Forms.Label();
            this.PaidAmountText = new System.Windows.Forms.TextBox();
            this.PaidAmountLabel = new System.Windows.Forms.Label();
            this.DiscountPercentageText = new System.Windows.Forms.TextBox();
            this.ProductGroup = new System.Windows.Forms.GroupBox();
            this.NetPriceText = new System.Windows.Forms.TextBox();
            this.NetPriceLabel = new System.Windows.Forms.Label();
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
            this.label5 = new System.Windows.Forms.Label();
            this.PreviousDueText = new System.Windows.Forms.TextBox();
            this.FullDueText = new System.Windows.Forms.TextBox();
            this.FullPayableText = new System.Windows.Forms.TextBox();
            this.PayableText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DueText = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SavedVoucharGroup.SuspendLayout();
            this.AmountGroup.SuspendLayout();
            this.ProductGroup.SuspendLayout();
            this.CustomerGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DealDateTime
            // 
            this.DealDateTime.CalendarMonthBackground = System.Drawing.Color.White;
            this.DealDateTime.CustomFormat = "dd MMMM yyyy - hh:mm tt";
            this.DealDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DealDateTime.Location = new System.Drawing.Point(349, 58);
            this.DealDateTime.Name = "DealDateTime";
            this.DealDateTime.Size = new System.Drawing.Size(362, 29);
            this.DealDateTime.TabIndex = 2;
            // 
            // SavedVoucharGroup
            // 
            this.SavedVoucharGroup.Controls.Add(this.LoadSavedVoucharButton);
            this.SavedVoucharGroup.Controls.Add(this.RemoveSavedVoucharButton);
            this.SavedVoucharGroup.Controls.Add(this.SavedVoucharList);
            this.SavedVoucharGroup.Location = new System.Drawing.Point(716, 344);
            this.SavedVoucharGroup.Name = "SavedVoucharGroup";
            this.SavedVoucharGroup.Size = new System.Drawing.Size(292, 317);
            this.SavedVoucharGroup.TabIndex = 8;
            this.SavedVoucharGroup.TabStop = false;
            this.SavedVoucharGroup.Text = "Saved Vouchar";
            // 
            // LoadSavedVoucharButton
            // 
            this.LoadSavedVoucharButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.LoadSavedVoucharButton.FlatAppearance.BorderSize = 0;
            this.LoadSavedVoucharButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.LoadSavedVoucharButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            this.LoadSavedVoucharButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadSavedVoucharButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadSavedVoucharButton.ForeColor = System.Drawing.Color.White;
            this.LoadSavedVoucharButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadSavedVoucharButton.Location = new System.Drawing.Point(11, 219);
            this.LoadSavedVoucharButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.LoadSavedVoucharButton.Name = "LoadSavedVoucharButton";
            this.LoadSavedVoucharButton.Size = new System.Drawing.Size(272, 42);
            this.LoadSavedVoucharButton.TabIndex = 1;
            this.LoadSavedVoucharButton.Text = "Load";
            this.LoadSavedVoucharButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.LoadSavedVoucharButton.UseVisualStyleBackColor = false;
            this.LoadSavedVoucharButton.Click += new System.EventHandler(this.LoadSavedVoucharButton_Click);
            // 
            // RemoveSavedVoucharButton
            // 
            this.RemoveSavedVoucharButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.RemoveSavedVoucharButton.FlatAppearance.BorderSize = 0;
            this.RemoveSavedVoucharButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.RemoveSavedVoucharButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(135)))));
            this.RemoveSavedVoucharButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveSavedVoucharButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveSavedVoucharButton.ForeColor = System.Drawing.Color.White;
            this.RemoveSavedVoucharButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveSavedVoucharButton.Location = new System.Drawing.Point(10, 266);
            this.RemoveSavedVoucharButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.RemoveSavedVoucharButton.Name = "RemoveSavedVoucharButton";
            this.RemoveSavedVoucharButton.Size = new System.Drawing.Size(272, 42);
            this.RemoveSavedVoucharButton.TabIndex = 2;
            this.RemoveSavedVoucharButton.Text = "Delete";
            this.RemoveSavedVoucharButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RemoveSavedVoucharButton.UseVisualStyleBackColor = false;
            this.RemoveSavedVoucharButton.Click += new System.EventHandler(this.RemoveSavedVoucharButton_Click);
            // 
            // SavedVoucharList
            // 
            this.SavedVoucharList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SavedVoucharList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SavedVoucharList.FormattingEnabled = true;
            this.SavedVoucharList.ItemHeight = 21;
            this.SavedVoucharList.Location = new System.Drawing.Point(10, 24);
            this.SavedVoucharList.Name = "SavedVoucharList";
            this.SavedVoucharList.Size = new System.Drawing.Size(274, 189);
            this.SavedVoucharList.TabIndex = 0;
            // 
            // AmountGroup
            // 
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
            this.AmountGroup.Location = new System.Drawing.Point(716, 46);
            this.AmountGroup.Name = "AmountGroup";
            this.AmountGroup.Size = new System.Drawing.Size(292, 297);
            this.AmountGroup.TabIndex = 7;
            this.AmountGroup.TabStop = false;
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
            this.SaveButton.Location = new System.Drawing.Point(10, 247);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(273, 42);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Save";
            this.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // DiscountLabel
            // 
            this.DiscountLabel.AutoSize = true;
            this.DiscountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountLabel.Location = new System.Drawing.Point(7, 47);
            this.DiscountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.Size = new System.Drawing.Size(78, 21);
            this.DiscountLabel.TabIndex = 2;
            this.DiscountLabel.Text = "Discount :";
            this.DiscountLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(5, 20);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(49, 21);
            this.TotalLabel.TabIndex = 0;
            this.TotalLabel.Text = "Total :";
            this.TotalLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TotalText
            // 
            this.TotalText.AutoSize = true;
            this.TotalText.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalText.Location = new System.Drawing.Point(93, 14);
            this.TotalText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalText.Name = "TotalText";
            this.TotalText.Size = new System.Drawing.Size(63, 28);
            this.TotalText.TabIndex = 1;
            this.TotalText.Text = "0.0 Tk";
            this.TotalText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // LessAmountText
            // 
            this.LessAmountText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LessAmountText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LessAmountText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LessAmountText.Location = new System.Drawing.Point(194, 47);
            this.LessAmountText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.LessAmountText.Name = "LessAmountText";
            this.LessAmountText.Size = new System.Drawing.Size(89, 22);
            this.LessAmountText.TabIndex = 5;
            this.LessAmountText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            this.LessAmountText.Leave += new System.EventHandler(this.LessAmountText_TextChanged);
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
            this.SubmitButton.Location = new System.Drawing.Point(10, 198);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(273, 42);
            this.SubmitButton.TabIndex = 12;
            this.SubmitButton.Text = "Purchase";
            this.SubmitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // PayableLabel
            // 
            this.PayableLabel.AutoSize = true;
            this.PayableLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayableLabel.Location = new System.Drawing.Point(7, 108);
            this.PayableLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PayableLabel.Name = "PayableLabel";
            this.PayableLabel.Size = new System.Drawing.Size(70, 21);
            this.PayableLabel.TabIndex = 6;
            this.PayableLabel.Text = "Payable :";
            this.PayableLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // PaidAmountText
            // 
            this.PaidAmountText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PaidAmountText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PaidAmountText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaidAmountText.Location = new System.Drawing.Point(98, 138);
            this.PaidAmountText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.PaidAmountText.Name = "PaidAmountText";
            this.PaidAmountText.Size = new System.Drawing.Size(185, 22);
            this.PaidAmountText.TabIndex = 9;
            this.PaidAmountText.TextChanged += new System.EventHandler(this.PaidAmountText_TextChanged_1);
            this.PaidAmountText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            this.PaidAmountText.Leave += new System.EventHandler(this.PaidAmountText_TextChanged);
            // 
            // PaidAmountLabel
            // 
            this.PaidAmountLabel.AutoSize = true;
            this.PaidAmountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaidAmountLabel.Location = new System.Drawing.Point(7, 138);
            this.PaidAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PaidAmountLabel.Name = "PaidAmountLabel";
            this.PaidAmountLabel.Size = new System.Drawing.Size(46, 21);
            this.PaidAmountLabel.TabIndex = 8;
            this.PaidAmountLabel.Text = "Paid :";
            this.PaidAmountLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // DiscountPercentageText
            // 
            this.DiscountPercentageText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DiscountPercentageText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiscountPercentageText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountPercentageText.Location = new System.Drawing.Point(98, 47);
            this.DiscountPercentageText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.DiscountPercentageText.Name = "DiscountPercentageText";
            this.DiscountPercentageText.Size = new System.Drawing.Size(56, 22);
            this.DiscountPercentageText.TabIndex = 3;
            this.DiscountPercentageText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            this.DiscountPercentageText.Leave += new System.EventHandler(this.DiscountPercentageText_TextChanged);
            // 
            // ProductGroup
            // 
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
            this.ProductGroup.Location = new System.Drawing.Point(349, 79);
            this.ProductGroup.Name = "ProductGroup";
            this.ProductGroup.Size = new System.Drawing.Size(362, 265);
            this.ProductGroup.TabIndex = 3;
            this.ProductGroup.TabStop = false;
            // 
            // NetPriceText
            // 
            this.NetPriceText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NetPriceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NetPriceText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetPriceText.Location = new System.Drawing.Point(256, 185);
            this.NetPriceText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.NetPriceText.Name = "NetPriceText";
            this.NetPriceText.Size = new System.Drawing.Size(100, 22);
            this.NetPriceText.TabIndex = 19;
            this.NetPriceText.TextChanged += new System.EventHandler(this.NetPriceText_TextChanged);
            this.NetPriceText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // NetPriceLabel
            // 
            this.NetPriceLabel.AutoSize = true;
            this.NetPriceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetPriceLabel.Location = new System.Drawing.Point(207, 185);
            this.NetPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NetPriceLabel.Name = "NetPriceLabel";
            this.NetPriceLabel.Size = new System.Drawing.Size(45, 21);
            this.NetPriceLabel.TabIndex = 18;
            this.NetPriceLabel.Text = "Total:";
            this.NetPriceLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // UnitPriceText
            // 
            this.UnitPriceText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UnitPriceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UnitPriceText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitPriceText.Location = new System.Drawing.Point(98, 185);
            this.UnitPriceText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.UnitPriceText.Name = "UnitPriceText";
            this.UnitPriceText.Size = new System.Drawing.Size(100, 22);
            this.UnitPriceText.TabIndex = 17;
            this.UnitPriceText.TextChanged += new System.EventHandler(this.UnitPriceText_TextChanged);
            this.UnitPriceText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // QuantityText
            // 
            this.QuantityText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.QuantityText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuantityText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityText.Location = new System.Drawing.Point(98, 153);
            this.QuantityText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.QuantityText.Name = "QuantityText";
            this.QuantityText.Size = new System.Drawing.Size(100, 22);
            this.QuantityText.TabIndex = 14;
            this.QuantityText.TextChanged += new System.EventHandler(this.QuantityText_TextChanged);
            this.QuantityText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // ViewProductButton
            // 
            this.ViewProductButton.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Eye_96px;
            this.ViewProductButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ViewProductButton.FlatAppearance.BorderSize = 0;
            this.ViewProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewProductButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewProductButton.Location = new System.Drawing.Point(327, 111);
            this.ViewProductButton.Name = "ViewProductButton";
            this.ViewProductButton.Size = new System.Drawing.Size(29, 29);
            this.ViewProductButton.TabIndex = 10;
            this.buttonsInfo.SetToolTip(this.ViewProductButton, "View and edit the selected product information");
            this.ViewProductButton.UseVisualStyleBackColor = true;
            this.ViewProductButton.Click += new System.EventHandler(this.ViewProductButton_Click);
            // 
            // ResetProductButton
            // 
            this.ResetProductButton.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Reset_96px__2_;
            this.ResetProductButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ResetProductButton.FlatAppearance.BorderSize = 0;
            this.ResetProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetProductButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetProductButton.Location = new System.Drawing.Point(257, 111);
            this.ResetProductButton.Name = "ResetProductButton";
            this.ResetProductButton.Size = new System.Drawing.Size(29, 29);
            this.ResetProductButton.TabIndex = 12;
            this.buttonsInfo.SetToolTip(this.ResetProductButton, "Reset product related fields");
            this.ResetProductButton.UseVisualStyleBackColor = true;
            this.ResetProductButton.Click += new System.EventHandler(this.ResetProductButton_Click);
            // 
            // UnitPriceLabel
            // 
            this.UnitPriceLabel.AutoSize = true;
            this.UnitPriceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitPriceLabel.Location = new System.Drawing.Point(7, 185);
            this.UnitPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UnitPriceLabel.Name = "UnitPriceLabel";
            this.UnitPriceLabel.Size = new System.Drawing.Size(84, 21);
            this.UnitPriceLabel.TabIndex = 16;
            this.UnitPriceLabel.Text = "Unit Price :";
            this.UnitPriceLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "W:";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // AddProductButton
            // 
            this.AddProductButton.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Plus_Math_96px_1;
            this.AddProductButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddProductButton.FlatAppearance.BorderSize = 0;
            this.AddProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProductButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductButton.Location = new System.Drawing.Point(292, 111);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(29, 29);
            this.AddProductButton.TabIndex = 11;
            this.buttonsInfo.SetToolTip(this.AddProductButton, "Add a new product");
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // WholeSalePriceText
            // 
            this.WholeSalePriceText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.WholeSalePriceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WholeSalePriceText.Enabled = false;
            this.WholeSalePriceText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WholeSalePriceText.Location = new System.Drawing.Point(256, 84);
            this.WholeSalePriceText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.WholeSalePriceText.Name = "WholeSalePriceText";
            this.WholeSalePriceText.Size = new System.Drawing.Size(100, 22);
            this.WholeSalePriceText.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "R:";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // RetailPriceText
            // 
            this.RetailPriceText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RetailPriceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RetailPriceText.Enabled = false;
            this.RetailPriceText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetailPriceText.Location = new System.Drawing.Point(98, 84);
            this.RetailPriceText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.RetailPriceText.Name = "RetailPriceText";
            this.RetailPriceText.Size = new System.Drawing.Size(100, 22);
            this.RetailPriceText.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "G:";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // GodownStockText
            // 
            this.GodownStockText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GodownStockText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GodownStockText.Enabled = false;
            this.GodownStockText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GodownStockText.Location = new System.Drawing.Point(256, 56);
            this.GodownStockText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.GodownStockText.Name = "GodownStockText";
            this.GodownStockText.Size = new System.Drawing.Size(100, 22);
            this.GodownStockText.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "S:";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // ShopStockText
            // 
            this.ShopStockText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ShopStockText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShopStockText.Enabled = false;
            this.ShopStockText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopStockText.Location = new System.Drawing.Point(98, 56);
            this.ShopStockText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ShopStockText.Name = "ShopStockText";
            this.ShopStockText.Size = new System.Drawing.Size(100, 22);
            this.ShopStockText.TabIndex = 3;
            // 
            // ProductSelectorLabel
            // 
            this.ProductSelectorLabel.AutoSize = true;
            this.ProductSelectorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductSelectorLabel.Location = new System.Drawing.Point(7, 24);
            this.ProductSelectorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductSelectorLabel.Name = "ProductSelectorLabel";
            this.ProductSelectorLabel.Size = new System.Drawing.Size(71, 21);
            this.ProductSelectorLabel.TabIndex = 0;
            this.ProductSelectorLabel.Text = "Product :";
            this.ProductSelectorLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // ProductSelectorCombo
            // 
            this.ProductSelectorCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ProductSelectorCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ProductSelectorCombo.BackColor = System.Drawing.Color.White;
            this.ProductSelectorCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductSelectorCombo.FormattingEnabled = true;
            this.ProductSelectorCombo.Location = new System.Drawing.Point(98, 17);
            this.ProductSelectorCombo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ProductSelectorCombo.Name = "ProductSelectorCombo";
            this.ProductSelectorCombo.Size = new System.Drawing.Size(258, 29);
            this.ProductSelectorCombo.TabIndex = 1;
            this.ProductSelectorCombo.SelectedIndexChanged += new System.EventHandler(this.ProductSelectorCombo_SelectedIndexChanged);
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(7, 153);
            this.QuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(77, 21);
            this.QuantityLabel.TabIndex = 13;
            this.QuantityLabel.Text = "Quantity :";
            this.QuantityLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
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
            this.AddToCartButton.Location = new System.Drawing.Point(98, 215);
            this.AddToCartButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(258, 42);
            this.AddToCartButton.TabIndex = 20;
            this.AddToCartButton.Text = "Add";
            this.AddToCartButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonsInfo.SetToolTip(this.AddToCartButton, "Add the product to purchase cart");
            this.AddToCartButton.UseVisualStyleBackColor = false;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // UnitSelectorCombo
            // 
            this.UnitSelectorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnitSelectorCombo.FormattingEnabled = true;
            this.UnitSelectorCombo.Location = new System.Drawing.Point(205, 150);
            this.UnitSelectorCombo.Name = "UnitSelectorCombo";
            this.UnitSelectorCombo.Size = new System.Drawing.Size(151, 29);
            this.UnitSelectorCombo.TabIndex = 15;
            this.UnitSelectorCombo.SelectedIndexChanged += new System.EventHandler(this.UnitSelectorCombo_SelectedIndexChanged);
            // 
            // CustomerGroup
            // 
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
            this.CustomerGroup.Location = new System.Drawing.Point(13, 46);
            this.CustomerGroup.Name = "CustomerGroup";
            this.CustomerGroup.Size = new System.Drawing.Size(333, 297);
            this.CustomerGroup.TabIndex = 1;
            this.CustomerGroup.TabStop = false;
            // 
            // ViewSupplierButton
            // 
            this.ViewSupplierButton.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Eye_96px;
            this.ViewSupplierButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ViewSupplierButton.FlatAppearance.BorderSize = 0;
            this.ViewSupplierButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewSupplierButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewSupplierButton.Location = new System.Drawing.Point(294, 158);
            this.ViewSupplierButton.Name = "ViewSupplierButton";
            this.ViewSupplierButton.Size = new System.Drawing.Size(29, 29);
            this.ViewSupplierButton.TabIndex = 11;
            this.buttonsInfo.SetToolTip(this.ViewSupplierButton, "View selected supplier");
            this.ViewSupplierButton.UseVisualStyleBackColor = true;
            this.ViewSupplierButton.Click += new System.EventHandler(this.ViewSupplierButton_Click);
            // 
            // ResetSupplierButton
            // 
            this.ResetSupplierButton.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Reset_96px__2_;
            this.ResetSupplierButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ResetSupplierButton.FlatAppearance.BorderSize = 0;
            this.ResetSupplierButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetSupplierButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetSupplierButton.Location = new System.Drawing.Point(225, 158);
            this.ResetSupplierButton.Name = "ResetSupplierButton";
            this.ResetSupplierButton.Size = new System.Drawing.Size(29, 29);
            this.ResetSupplierButton.TabIndex = 13;
            this.buttonsInfo.SetToolTip(this.ResetSupplierButton, "Clears the supplier relaed fields");
            this.ResetSupplierButton.UseVisualStyleBackColor = true;
            this.ResetSupplierButton.Click += new System.EventHandler(this.ResetSupplierButton_Click);
            // 
            // AddSupplierButton
            // 
            this.AddSupplierButton.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Plus_Math_96px_1;
            this.AddSupplierButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddSupplierButton.FlatAppearance.BorderSize = 0;
            this.AddSupplierButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSupplierButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSupplierButton.Location = new System.Drawing.Point(260, 158);
            this.AddSupplierButton.Name = "AddSupplierButton";
            this.AddSupplierButton.Size = new System.Drawing.Size(29, 29);
            this.AddSupplierButton.TabIndex = 12;
            this.buttonsInfo.SetToolTip(this.AddSupplierButton, "Add a new supplier");
            this.AddSupplierButton.UseVisualStyleBackColor = true;
            this.AddSupplierButton.Click += new System.EventHandler(this.AddSupplierButton_Click);
            // 
            // SupplierSelectorLabel
            // 
            this.SupplierSelectorLabel.AutoSize = true;
            this.SupplierSelectorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierSelectorLabel.Location = new System.Drawing.Point(3, 26);
            this.SupplierSelectorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SupplierSelectorLabel.Name = "SupplierSelectorLabel";
            this.SupplierSelectorLabel.Size = new System.Drawing.Size(75, 21);
            this.SupplierSelectorLabel.TabIndex = 0;
            this.SupplierSelectorLabel.Text = "Supplier :";
            this.SupplierSelectorLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // SupplierNameLabel
            // 
            this.SupplierNameLabel.AutoSize = true;
            this.SupplierNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierNameLabel.Location = new System.Drawing.Point(3, 60);
            this.SupplierNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SupplierNameLabel.Name = "SupplierNameLabel";
            this.SupplierNameLabel.Size = new System.Drawing.Size(88, 21);
            this.SupplierNameLabel.TabIndex = 4;
            this.SupplierNameLabel.Text = "Full Name :";
            this.SupplierNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // SupplierNameText
            // 
            this.SupplierNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SupplierNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SupplierNameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierNameText.Location = new System.Drawing.Point(91, 60);
            this.SupplierNameText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.SupplierNameText.Name = "SupplierNameText";
            this.SupplierNameText.Size = new System.Drawing.Size(233, 22);
            this.SupplierNameText.TabIndex = 5;
            // 
            // SupplierCombo
            // 
            this.SupplierCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SupplierCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SupplierCombo.BackColor = System.Drawing.Color.White;
            this.SupplierCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierCombo.FormattingEnabled = true;
            this.SupplierCombo.Location = new System.Drawing.Point(91, 23);
            this.SupplierCombo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.SupplierCombo.Name = "SupplierCombo";
            this.SupplierCombo.Size = new System.Drawing.Size(233, 29);
            this.SupplierCombo.TabIndex = 1;
            this.SupplierCombo.SelectedIndexChanged += new System.EventHandler(this.SupplierCombo_SelectedIndexChanged);
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.AutoSize = true;
            this.CompanyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyLabel.Location = new System.Drawing.Point(3, 93);
            this.CompanyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(84, 21);
            this.CompanyLabel.TabIndex = 7;
            this.CompanyLabel.Text = "Company :";
            this.CompanyLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // CompanyText
            // 
            this.CompanyText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CompanyText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyText.Location = new System.Drawing.Point(90, 93);
            this.CompanyText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.CompanyText.Name = "CompanyText";
            this.CompanyText.Size = new System.Drawing.Size(233, 22);
            this.CompanyText.TabIndex = 8;
            // 
            // NotesText
            // 
            this.NotesText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NotesText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NotesText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesText.Location = new System.Drawing.Point(90, 196);
            this.NotesText.Margin = new System.Windows.Forms.Padding(4);
            this.NotesText.Name = "NotesText";
            this.NotesText.Size = new System.Drawing.Size(234, 94);
            this.NotesText.TabIndex = 0;
            this.NotesText.Text = "";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(3, 126);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(73, 21);
            this.AddressLabel.TabIndex = 9;
            this.AddressLabel.Text = "Address :";
            this.AddressLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesLabel.Location = new System.Drawing.Point(4, 198);
            this.NotesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(62, 21);
            this.NotesLabel.TabIndex = 14;
            this.NotesLabel.Text = "Notes : ";
            this.NotesLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // AddressText
            // 
            this.AddressText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddressText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressText.Location = new System.Drawing.Point(90, 126);
            this.AddressText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(233, 22);
            this.AddressText.TabIndex = 10;
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
            this.CartDataGrid.Location = new System.Drawing.Point(13, 348);
            this.CartDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.CartDataGrid.Name = "CartDataGrid";
            this.CartDataGrid.ReadOnly = true;
            this.CartDataGrid.RowHeadersVisible = false;
            this.CartDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CartDataGrid.Size = new System.Drawing.Size(698, 265);
            this.CartDataGrid.TabIndex = 4;
            this.CartDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CartDataGrid_CellContentClick);
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
            this.UnitPriceColumn.DataPropertyName = "GetUnitPurchasePrice";
            this.UnitPriceColumn.HeaderText = "Unit Price";
            this.UnitPriceColumn.Name = "UnitPriceColumn";
            this.UnitPriceColumn.ReadOnly = true;
            this.UnitPriceColumn.Width = 102;
            // 
            // NetPriceColumn
            // 
            this.NetPriceColumn.DataPropertyName = "GetNetPurchasePrice";
            this.NetPriceColumn.HeaderText = "Net Price";
            this.NetPriceColumn.Name = "NetPriceColumn";
            this.NetPriceColumn.ReadOnly = true;
            this.NetPriceColumn.Width = 98;
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
            this.RemoveSelectedButton.Location = new System.Drawing.Point(13, 619);
            this.RemoveSelectedButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.RemoveSelectedButton.Name = "RemoveSelectedButton";
            this.RemoveSelectedButton.Size = new System.Drawing.Size(698, 42);
            this.RemoveSelectedButton.TabIndex = 5;
            this.RemoveSelectedButton.Text = "Remove Selected";
            this.RemoveSelectedButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RemoveSelectedButton.UseVisualStyleBackColor = false;
            this.RemoveSelectedButton.Click += new System.EventHandler(this.RemoveSelectedButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semi Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(5, 4);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(155, 47);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Purchase";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // ReloadSuppliersProducts
            // 
            this.ReloadSuppliersProducts.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Sync_500px;
            this.ReloadSuppliersProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReloadSuppliersProducts.FlatAppearance.BorderSize = 0;
            this.ReloadSuppliersProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReloadSuppliersProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReloadSuppliersProducts.Location = new System.Drawing.Point(979, 22);
            this.ReloadSuppliersProducts.Name = "ReloadSuppliersProducts";
            this.ReloadSuppliersProducts.Size = new System.Drawing.Size(29, 29);
            this.ReloadSuppliersProducts.TabIndex = 6;
            this.buttonsInfo.SetToolTip(this.ReloadSuppliersProducts, "Force refresh the list of Suppliers and Products");
            this.ReloadSuppliersProducts.UseVisualStyleBackColor = true;
            this.ReloadSuppliersProducts.Click += new System.EventHandler(this.ReloadSuppliersProducts_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 32;
            this.label5.Text = "Prev. Due :";
            // 
            // PreviousDueText
            // 
            this.PreviousDueText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PreviousDueText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PreviousDueText.Enabled = false;
            this.PreviousDueText.Font = new System.Drawing.Font("Segoe UI Semi Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousDueText.Location = new System.Drawing.Point(97, 78);
            this.PreviousDueText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.PreviousDueText.Name = "PreviousDueText";
            this.PreviousDueText.Size = new System.Drawing.Size(186, 22);
            this.PreviousDueText.TabIndex = 33;
            // 
            // FullDueText
            // 
            this.FullDueText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FullDueText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FullDueText.Enabled = false;
            this.FullDueText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullDueText.Location = new System.Drawing.Point(193, 167);
            this.FullDueText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.FullDueText.Name = "FullDueText";
            this.FullDueText.Size = new System.Drawing.Size(90, 22);
            this.FullDueText.TabIndex = 31;
            // 
            // FullPayableText
            // 
            this.FullPayableText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FullPayableText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FullPayableText.Enabled = false;
            this.FullPayableText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullPayableText.Location = new System.Drawing.Point(193, 108);
            this.FullPayableText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.FullPayableText.Name = "FullPayableText";
            this.FullPayableText.Size = new System.Drawing.Size(90, 22);
            this.FullPayableText.TabIndex = 30;
            // 
            // PayableText
            // 
            this.PayableText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PayableText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PayableText.Enabled = false;
            this.PayableText.Font = new System.Drawing.Font("Segoe UI Semi Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayableText.Location = new System.Drawing.Point(97, 108);
            this.PayableText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.PayableText.Name = "PayableText";
            this.PayableText.Size = new System.Drawing.Size(88, 22);
            this.PayableText.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 168);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 21);
            this.label10.TabIndex = 28;
            this.label10.Text = "Curr. Due :";
            // 
            // DueText
            // 
            this.DueText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DueText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DueText.Enabled = false;
            this.DueText.Font = new System.Drawing.Font("Segoe UI Semi Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueText.Location = new System.Drawing.Point(98, 168);
            this.DueText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.DueText.Name = "DueText";
            this.DueText.Size = new System.Drawing.Size(87, 22);
            this.DueText.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(153, 47);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 21);
            this.label12.TabIndex = 22;
            this.label12.Text = "%";
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1021, 674);
            this.Controls.Add(this.ReloadSuppliersProducts);
            this.Controls.Add(this.DealDateTime);
            this.Controls.Add(this.SavedVoucharGroup);
            this.Controls.Add(this.AmountGroup);
            this.Controls.Add(this.ProductGroup);
            this.Controls.Add(this.CustomerGroup);
            this.Controls.Add(this.RemoveSelectedButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.CartDataGrid);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PurchaseForm";
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.PurchaseForm_Load);
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