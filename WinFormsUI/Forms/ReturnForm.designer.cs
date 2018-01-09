namespace WinFormsUI.Forms
{
    partial class ReturnForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ReceiptNumberCombo = new System.Windows.Forms.ComboBox();
            this.ReceiptNumberLabel = new System.Windows.Forms.Label();
            this.ProductSelectorCombo = new System.Windows.Forms.ComboBox();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.CutPercentageText = new System.Windows.Forms.TextBox();
            this.CutAmountText = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.RefundCutLabel = new System.Windows.Forms.Label();
            this.PercentageOrLabel = new System.Windows.Forms.Label();
            this.AvailableQuantityText = new System.Windows.Forms.Label();
            this.TotalAmountTextLabel = new System.Windows.Forms.Label();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ReturnedProductsGroupBox = new System.Windows.Forms.GroupBox();
            this.ViewReceiptButton = new System.Windows.Forms.Button();
            this.ResetReceiptButton = new System.Windows.Forms.Button();
            this.SelectProductForRefundGroup = new System.Windows.Forms.GroupBox();
            this.QuantityText = new System.Windows.Forms.TextBox();
            this.CartDataGrid = new System.Windows.Forms.DataGridView();
            this.ProductIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotesText = new System.Windows.Forms.RichTextBox();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.ReturnedAmountText = new System.Windows.Forms.TextBox();
            this.RefundAmountLabel = new System.Windows.Forms.Label();
            this.RefundAmountGroupBox = new System.Windows.Forms.GroupBox();
            this.ReturnedProductsGroupBox.SuspendLayout();
            this.SelectProductForRefundGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGrid)).BeginInit();
            this.RefundAmountGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semi Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(13, 4);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(126, 47);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Refund";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // ReceiptNumberCombo
            // 
            this.ReceiptNumberCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ReceiptNumberCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ReceiptNumberCombo.BackColor = System.Drawing.Color.White;
            this.ReceiptNumberCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiptNumberCombo.FormattingEnabled = true;
            this.ReceiptNumberCombo.Location = new System.Drawing.Point(96, 27);
            this.ReceiptNumberCombo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ReceiptNumberCombo.Name = "ReceiptNumberCombo";
            this.ReceiptNumberCombo.Size = new System.Drawing.Size(357, 29);
            this.ReceiptNumberCombo.TabIndex = 1;
            this.ReceiptNumberCombo.SelectedIndexChanged += new System.EventHandler(this.ReceiptNumberCombo_SelectedIndexChanged);
            // 
            // ReceiptNumberLabel
            // 
            this.ReceiptNumberLabel.AutoSize = true;
            this.ReceiptNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiptNumberLabel.Location = new System.Drawing.Point(14, 30);
            this.ReceiptNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReceiptNumberLabel.Name = "ReceiptNumberLabel";
            this.ReceiptNumberLabel.Size = new System.Drawing.Size(74, 21);
            this.ReceiptNumberLabel.TabIndex = 0;
            this.ReceiptNumberLabel.Text = "Receipt #";
            this.ReceiptNumberLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // ProductSelectorCombo
            // 
            this.ProductSelectorCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ProductSelectorCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ProductSelectorCombo.BackColor = System.Drawing.Color.White;
            this.ProductSelectorCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductSelectorCombo.FormattingEnabled = true;
            this.ProductSelectorCombo.Location = new System.Drawing.Point(89, 30);
            this.ProductSelectorCombo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ProductSelectorCombo.Name = "ProductSelectorCombo";
            this.ProductSelectorCombo.Size = new System.Drawing.Size(423, 29);
            this.ProductSelectorCombo.TabIndex = 1;
            this.ProductSelectorCombo.SelectedIndexChanged += new System.EventHandler(this.ProductSelectorCombo_SelectedIndexChanged);
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductLabel.Location = new System.Drawing.Point(7, 33);
            this.ProductLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(71, 21);
            this.ProductLabel.TabIndex = 0;
            this.ProductLabel.Text = "Product :";
            this.ProductLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(7, 66);
            this.QuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(77, 21);
            this.QuantityLabel.TabIndex = 2;
            this.QuantityLabel.Text = "Quantity :";
            this.QuantityLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // CutPercentageText
            // 
            this.CutPercentageText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CutPercentageText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CutPercentageText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CutPercentageText.Location = new System.Drawing.Point(86, 27);
            this.CutPercentageText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.CutPercentageText.Name = "CutPercentageText";
            this.CutPercentageText.Size = new System.Drawing.Size(52, 22);
            this.CutPercentageText.TabIndex = 1;
            this.CutPercentageText.Leave += new System.EventHandler(this.CutPercentageText_Leave);
            this.CutPercentageText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // CutAmountText
            // 
            this.CutAmountText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CutAmountText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CutAmountText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CutAmountText.Location = new System.Drawing.Point(207, 27);
            this.CutAmountText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.CutAmountText.Name = "CutAmountText";
            this.CutAmountText.Size = new System.Drawing.Size(83, 22);
            this.CutAmountText.TabIndex = 3;
            this.CutAmountText.TextChanged += new System.EventHandler(this.CutAmountText_TextChanged);
            this.CutAmountText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(170)))));
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(347, 63);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(165, 42);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RefundCutLabel
            // 
            this.RefundCutLabel.AutoSize = true;
            this.RefundCutLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefundCutLabel.Location = new System.Drawing.Point(7, 27);
            this.RefundCutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RefundCutLabel.Name = "RefundCutLabel";
            this.RefundCutLabel.Size = new System.Drawing.Size(41, 21);
            this.RefundCutLabel.TabIndex = 0;
            this.RefundCutLabel.Text = "Cut :";
            this.RefundCutLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // PercentageOrLabel
            // 
            this.PercentageOrLabel.AutoSize = true;
            this.PercentageOrLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentageOrLabel.Location = new System.Drawing.Point(142, 27);
            this.PercentageOrLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PercentageOrLabel.Name = "PercentageOrLabel";
            this.PercentageOrLabel.Size = new System.Drawing.Size(62, 21);
            this.PercentageOrLabel.TabIndex = 2;
            this.PercentageOrLabel.Text = "%   -or-";
            this.PercentageOrLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // AvailableQuantityText
            // 
            this.AvailableQuantityText.AutoSize = true;
            this.AvailableQuantityText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableQuantityText.Location = new System.Drawing.Point(146, 66);
            this.AvailableQuantityText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AvailableQuantityText.Name = "AvailableQuantityText";
            this.AvailableQuantityText.Size = new System.Drawing.Size(56, 21);
            this.AvailableQuantityText.TabIndex = 4;
            this.AvailableQuantityText.Text = "of QTY";
            this.AvailableQuantityText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TotalAmountTextLabel
            // 
            this.TotalAmountTextLabel.AutoSize = true;
            this.TotalAmountTextLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmountTextLabel.Location = new System.Drawing.Point(7, 439);
            this.TotalAmountTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalAmountTextLabel.Name = "TotalAmountTextLabel";
            this.TotalAmountTextLabel.Size = new System.Drawing.Size(51, 30);
            this.TotalAmountTextLabel.TabIndex = 6;
            this.TotalAmountTextLabel.Text = "0 Tk";
            this.TotalAmountTextLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.RemoveItemButton.FlatAppearance.BorderSize = 0;
            this.RemoveItemButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.RemoveItemButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(135)))));
            this.RemoveItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveItemButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveItemButton.ForeColor = System.Drawing.Color.White;
            this.RemoveItemButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveItemButton.Location = new System.Drawing.Point(375, 436);
            this.RemoveItemButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(151, 42);
            this.RemoveItemButton.TabIndex = 7;
            this.RemoveItemButton.Text = "Remove Item";
            this.RemoveItemButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RemoveItemButton.UseVisualStyleBackColor = false;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
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
            this.SubmitButton.Location = new System.Drawing.Point(375, 56);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(151, 42);
            this.SubmitButton.TabIndex = 8;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ReturnedProductsGroupBox
            // 
            this.ReturnedProductsGroupBox.Controls.Add(this.ViewReceiptButton);
            this.ReturnedProductsGroupBox.Controls.Add(this.ResetReceiptButton);
            this.ReturnedProductsGroupBox.Controls.Add(this.ReceiptNumberLabel);
            this.ReturnedProductsGroupBox.Controls.Add(this.ReceiptNumberCombo);
            this.ReturnedProductsGroupBox.Controls.Add(this.SelectProductForRefundGroup);
            this.ReturnedProductsGroupBox.Controls.Add(this.CartDataGrid);
            this.ReturnedProductsGroupBox.Controls.Add(this.RemoveItemButton);
            this.ReturnedProductsGroupBox.Controls.Add(this.TotalAmountTextLabel);
            this.ReturnedProductsGroupBox.Location = new System.Drawing.Point(9, 43);
            this.ReturnedProductsGroupBox.Name = "ReturnedProductsGroupBox";
            this.ReturnedProductsGroupBox.Size = new System.Drawing.Size(533, 487);
            this.ReturnedProductsGroupBox.TabIndex = 1;
            this.ReturnedProductsGroupBox.TabStop = false;
            // 
            // ViewReceiptButton
            // 
            this.ViewReceiptButton.BackgroundImage           = global::WinFormsUI.Properties.Resources.icons8_Eye_96px;
            this.ViewReceiptButton.BackgroundImageLayout     = System.Windows.Forms.ImageLayout.Zoom;
            this.ViewReceiptButton.FlatAppearance.BorderSize = 0;
            this.ViewReceiptButton.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.ViewReceiptButton.Font                      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewReceiptButton.Location                  = new System.Drawing.Point(460, 27);
            this.ViewReceiptButton.Name                      = "ViewReceiptButton";
            this.ViewReceiptButton.Size                      = new System.Drawing.Size(29, 29);
            this.ViewReceiptButton.TabIndex                  = 3;
            this.ViewReceiptButton.UseVisualStyleBackColor   = true;
            this.ViewReceiptButton.Click                    += new System.EventHandler(this.ViewReceiptButton_Click);
            // 
            // ResetReceiptButton
            // 
            this.ResetReceiptButton.BackgroundImage           = global::WinFormsUI.Properties.Resources.icons8_Reset_96px__2_;
            this.ResetReceiptButton.BackgroundImageLayout     = System.Windows.Forms.ImageLayout.Zoom;
            this.ResetReceiptButton.FlatAppearance.BorderSize = 0;
            this.ResetReceiptButton.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.ResetReceiptButton.Font                      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetReceiptButton.Location                  = new System.Drawing.Point(497, 27);
            this.ResetReceiptButton.Name                      = "ResetReceiptButton";
            this.ResetReceiptButton.Size                      = new System.Drawing.Size(29, 29);
            this.ResetReceiptButton.TabIndex                  = 2;
            this.ResetReceiptButton.UseVisualStyleBackColor   = true;
            this.ResetReceiptButton.Click                    += new System.EventHandler(this.ResetReceiptButton_Click);
            // 
            // SelectProductForRefundGroup
            // 
            this.SelectProductForRefundGroup.Controls.Add(this.QuantityText);
            this.SelectProductForRefundGroup.Controls.Add(this.ProductLabel);
            this.SelectProductForRefundGroup.Controls.Add(this.AvailableQuantityText);
            this.SelectProductForRefundGroup.Controls.Add(this.ProductSelectorCombo);
            this.SelectProductForRefundGroup.Controls.Add(this.QuantityLabel);
            this.SelectProductForRefundGroup.Controls.Add(this.AddButton);
            this.SelectProductForRefundGroup.Location = new System.Drawing.Point(7, 61);
            this.SelectProductForRefundGroup.Name = "SelectProductForRefundGroup";
            this.SelectProductForRefundGroup.Size = new System.Drawing.Size(519, 114);
            this.SelectProductForRefundGroup.TabIndex = 4;
            this.SelectProductForRefundGroup.TabStop = false;
            this.SelectProductForRefundGroup.Text = "Select Returned Product(s)";
            // 
            // QuantityText
            // 
            this.QuantityText.BackColor   = System.Drawing.Color.WhiteSmoke;
            this.QuantityText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuantityText.Font        = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityText.Location    = new System.Drawing.Point(89, 66);
            this.QuantityText.Margin      = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.QuantityText.Name        = "QuantityText";
            this.QuantityText.Size        = new System.Drawing.Size(54, 22);
            this.QuantityText.TabIndex    = 3;
            this.QuantityText.KeyPress   += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // CartDataGrid
            // 
            this.CartDataGrid.AllowUserToAddRows            = false;
            this.CartDataGrid.AllowUserToDeleteRows         = false;
            this.CartDataGrid.AllowUserToResizeRows         = false;
            this.CartDataGrid.AutoSizeColumnsMode           = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.CartDataGrid.BackgroundColor               = System.Drawing.Color.WhiteSmoke;
            this.CartDataGrid.BorderStyle                   = System.Windows.Forms.BorderStyle.None;
            this.CartDataGrid.CellBorderStyle               = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment                = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor                = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font                     = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor                = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor       = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor       = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode                 = System.Windows.Forms.DataGridViewTriState.False;
            this.CartDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CartDataGrid.ColumnHeadersHeightSizeMode   = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductIdColumn,
            this.ProductNameColumn,
            this.QuantityColumn,
            this.UnitNameColumn,
            this.NetPriceColumn});
            dataGridViewCellStyle2.Alignment          = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor          = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font               = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor          = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode           = System.Windows.Forms.DataGridViewTriState.False;
            this.CartDataGrid.DefaultCellStyle        = dataGridViewCellStyle2;
            this.CartDataGrid.GridColor               = System.Drawing.Color.WhiteSmoke;
            this.CartDataGrid.Location                = new System.Drawing.Point(7, 182);
            this.CartDataGrid.Margin                  = new System.Windows.Forms.Padding(4);
            this.CartDataGrid.Name                    = "CartDataGrid";
            this.CartDataGrid.RowHeadersVisible       = false;
            this.CartDataGrid.SelectionMode           = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CartDataGrid.Size                    = new System.Drawing.Size(519, 248);
            this.CartDataGrid.TabIndex                = 7;
            this.CartDataGrid.TabStop                 = false;
            // 
            // ProductIdColumn
            // 
            this.ProductIdColumn.DataPropertyName = "GetProductId";
            this.ProductIdColumn.HeaderText = "Product ID";
            this.ProductIdColumn.Name = "ProductIdColumn";
            this.ProductIdColumn.Width = 108;
            // 
            // ProductNameColumn
            // 
            this.ProductNameColumn.DataPropertyName = "ProductName";
            this.ProductNameColumn.HeaderText = "Product Name";
            this.ProductNameColumn.Name = "ProductNameColumn";
            this.ProductNameColumn.Width = 135;
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.DataPropertyName = "GetQuantity";
            this.QuantityColumn.HeaderText = "Qty";
            this.QuantityColumn.Name = "QuantityColumn";
            this.QuantityColumn.Width = 60;
            // 
            // UnitNameColumn
            // 
            this.UnitNameColumn.DataPropertyName = "GetUnitName";
            this.UnitNameColumn.HeaderText = "Unit";
            this.UnitNameColumn.Name = "UnitNameColumn";
            this.UnitNameColumn.Width = 64;
            // 
            // NetPriceColumn
            // 
            this.NetPriceColumn.DataPropertyName = "GetNetPrice";
            this.NetPriceColumn.HeaderText = "Net Price";
            this.NetPriceColumn.Name = "NetPriceColumn";
            this.NetPriceColumn.Width = 98;
            // 
            // NotesText
            // 
            this.NotesText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NotesText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NotesText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesText.Location = new System.Drawing.Point(86, 57);
            this.NotesText.Margin = new System.Windows.Forms.Padding(4);
            this.NotesText.Name = "NotesText";
            this.NotesText.Size = new System.Drawing.Size(269, 42);
            this.NotesText.TabIndex = 7;
            this.NotesText.Text = "";
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesLabel.Location = new System.Drawing.Point(8, 56);
            this.NotesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(62, 21);
            this.NotesLabel.TabIndex = 6;
            this.NotesLabel.Text = "Notes : ";
            // 
            // ReturnedAmountText
            // 
            this.ReturnedAmountText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ReturnedAmountText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReturnedAmountText.Enabled = false;
            this.ReturnedAmountText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnedAmountText.Location = new System.Drawing.Point(430, 27);
            this.ReturnedAmountText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ReturnedAmountText.Name = "ReturnedAmountText";
            this.ReturnedAmountText.Size = new System.Drawing.Size(96, 22);
            this.ReturnedAmountText.TabIndex = 5;
            this.ReturnedAmountText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // RefundAmountLabel
            // 
            this.RefundAmountLabel.AutoSize = true;
            this.RefundAmountLabel.Font = new System.Drawing.Font("Segoe UI Semi Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefundAmountLabel.Location = new System.Drawing.Point(351, 26);
            this.RefundAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RefundAmountLabel.Name = "RefundAmountLabel";
            this.RefundAmountLabel.Size = new System.Drawing.Size(67, 21);
            this.RefundAmountLabel.TabIndex = 4;
            this.RefundAmountLabel.Text = "Refund :";
            // 
            // RefundAmountGroupBox
            // 
            this.RefundAmountGroupBox.Controls.Add(this.ReturnedAmountText);
            this.RefundAmountGroupBox.Controls.Add(this.RefundAmountLabel);
            this.RefundAmountGroupBox.Controls.Add(this.CutPercentageText);
            this.RefundAmountGroupBox.Controls.Add(this.CutAmountText);
            this.RefundAmountGroupBox.Controls.Add(this.NotesText);
            this.RefundAmountGroupBox.Controls.Add(this.RefundCutLabel);
            this.RefundAmountGroupBox.Controls.Add(this.NotesLabel);
            this.RefundAmountGroupBox.Controls.Add(this.PercentageOrLabel);
            this.RefundAmountGroupBox.Controls.Add(this.SubmitButton);
            this.RefundAmountGroupBox.Location = new System.Drawing.Point(9, 536);
            this.RefundAmountGroupBox.Name = "RefundAmountGroupBox";
            this.RefundAmountGroupBox.Size = new System.Drawing.Size(533, 113);
            this.RefundAmountGroupBox.TabIndex = 2;
            this.RefundAmountGroupBox.TabStop = false;
            this.RefundAmountGroupBox.Text = "Enter the deduction amount";
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(552, 661);
            this.Controls.Add(this.ReturnedProductsGroupBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.RefundAmountGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReturnForm";
            this.Text = "Return";
            this.Load += new System.EventHandler(this.ReturnForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            this.ReturnedProductsGroupBox.ResumeLayout(false);
            this.ReturnedProductsGroupBox.PerformLayout();
            this.SelectProductForRefundGroup.ResumeLayout(false);
            this.SelectProductForRefundGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGrid)).EndInit();
            this.RefundAmountGroupBox.ResumeLayout(false);
            this.RefundAmountGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ComboBox ReceiptNumberCombo;
        private System.Windows.Forms.Label ReceiptNumberLabel;
        private System.Windows.Forms.ComboBox ProductSelectorCombo;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.TextBox CutPercentageText;
        private System.Windows.Forms.TextBox CutAmountText;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label RefundCutLabel;
        private System.Windows.Forms.Label PercentageOrLabel;
        private System.Windows.Forms.Label AvailableQuantityText;
        private System.Windows.Forms.Label TotalAmountTextLabel;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.GroupBox ReturnedProductsGroupBox;
        private System.Windows.Forms.RichTextBox NotesText;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.TextBox ReturnedAmountText;
        private System.Windows.Forms.Label RefundAmountLabel;
        private System.Windows.Forms.GroupBox RefundAmountGroupBox;
        private System.Windows.Forms.DataGridView CartDataGrid;
        private System.Windows.Forms.GroupBox SelectProductForRefundGroup;
        private System.Windows.Forms.Button ViewReceiptButton;
        private System.Windows.Forms.Button ResetReceiptButton;
        private System.Windows.Forms.TextBox QuantityText;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetPriceColumn;
    }
}