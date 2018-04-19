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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            resources.ApplyResources(this.TitleLabel, "TitleLabel");
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // ReceiptNumberCombo
            // 
            resources.ApplyResources(this.ReceiptNumberCombo, "ReceiptNumberCombo");
            this.ReceiptNumberCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ReceiptNumberCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ReceiptNumberCombo.BackColor = System.Drawing.Color.White;
            this.ReceiptNumberCombo.FormattingEnabled = true;
            this.ReceiptNumberCombo.Name = "ReceiptNumberCombo";
            this.ReceiptNumberCombo.SelectedIndexChanged += new System.EventHandler(this.ReceiptNumberCombo_SelectedIndexChanged);
            // 
            // ReceiptNumberLabel
            // 
            resources.ApplyResources(this.ReceiptNumberLabel, "ReceiptNumberLabel");
            this.ReceiptNumberLabel.Name = "ReceiptNumberLabel";
            this.ReceiptNumberLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // ProductSelectorCombo
            // 
            resources.ApplyResources(this.ProductSelectorCombo, "ProductSelectorCombo");
            this.ProductSelectorCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ProductSelectorCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ProductSelectorCombo.BackColor = System.Drawing.Color.White;
            this.ProductSelectorCombo.FormattingEnabled = true;
            this.ProductSelectorCombo.Name = "ProductSelectorCombo";
            this.ProductSelectorCombo.SelectedIndexChanged += new System.EventHandler(this.ProductSelectorCombo_SelectedIndexChanged);
            // 
            // ProductLabel
            // 
            resources.ApplyResources(this.ProductLabel, "ProductLabel");
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // QuantityLabel
            // 
            resources.ApplyResources(this.QuantityLabel, "QuantityLabel");
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // CutPercentageText
            // 
            resources.ApplyResources(this.CutPercentageText, "CutPercentageText");
            this.CutPercentageText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CutPercentageText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CutPercentageText.Name = "CutPercentageText";
            this.CutPercentageText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            this.CutPercentageText.Leave += new System.EventHandler(this.CutPercentageText_Leave);
            // 
            // CutAmountText
            // 
            resources.ApplyResources(this.CutAmountText, "CutAmountText");
            this.CutAmountText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CutAmountText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CutAmountText.Name = "CutAmountText";
            this.CutAmountText.TextChanged += new System.EventHandler(this.CutAmountText_TextChanged);
            this.CutAmountText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // AddButton
            // 
            resources.ApplyResources(this.AddButton, "AddButton");
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(170)))));
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Name = "AddButton";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RefundCutLabel
            // 
            resources.ApplyResources(this.RefundCutLabel, "RefundCutLabel");
            this.RefundCutLabel.Name = "RefundCutLabel";
            this.RefundCutLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // PercentageOrLabel
            // 
            resources.ApplyResources(this.PercentageOrLabel, "PercentageOrLabel");
            this.PercentageOrLabel.Name = "PercentageOrLabel";
            this.PercentageOrLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // AvailableQuantityText
            // 
            resources.ApplyResources(this.AvailableQuantityText, "AvailableQuantityText");
            this.AvailableQuantityText.Name = "AvailableQuantityText";
            this.AvailableQuantityText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TotalAmountTextLabel
            // 
            resources.ApplyResources(this.TotalAmountTextLabel, "TotalAmountTextLabel");
            this.TotalAmountTextLabel.Name = "TotalAmountTextLabel";
            this.TotalAmountTextLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // RemoveItemButton
            // 
            resources.ApplyResources(this.RemoveItemButton, "RemoveItemButton");
            this.RemoveItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.RemoveItemButton.FlatAppearance.BorderSize = 0;
            this.RemoveItemButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.RemoveItemButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(135)))));
            this.RemoveItemButton.ForeColor = System.Drawing.Color.White;
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.UseVisualStyleBackColor = false;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
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
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ReturnedProductsGroupBox
            // 
            resources.ApplyResources(this.ReturnedProductsGroupBox, "ReturnedProductsGroupBox");
            this.ReturnedProductsGroupBox.Controls.Add(this.ViewReceiptButton);
            this.ReturnedProductsGroupBox.Controls.Add(this.ResetReceiptButton);
            this.ReturnedProductsGroupBox.Controls.Add(this.ReceiptNumberLabel);
            this.ReturnedProductsGroupBox.Controls.Add(this.ReceiptNumberCombo);
            this.ReturnedProductsGroupBox.Controls.Add(this.SelectProductForRefundGroup);
            this.ReturnedProductsGroupBox.Controls.Add(this.CartDataGrid);
            this.ReturnedProductsGroupBox.Controls.Add(this.RemoveItemButton);
            this.ReturnedProductsGroupBox.Controls.Add(this.TotalAmountTextLabel);
            this.ReturnedProductsGroupBox.Name = "ReturnedProductsGroupBox";
            this.ReturnedProductsGroupBox.TabStop = false;
            // 
            // ViewReceiptButton
            // 
            resources.ApplyResources(this.ViewReceiptButton, "ViewReceiptButton");
            this.ViewReceiptButton.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Eye_96px;
            this.ViewReceiptButton.FlatAppearance.BorderSize = 0;
            this.ViewReceiptButton.Name = "ViewReceiptButton";
            this.ViewReceiptButton.UseVisualStyleBackColor = true;
            this.ViewReceiptButton.Click += new System.EventHandler(this.ViewReceiptButton_Click);
            // 
            // ResetReceiptButton
            // 
            resources.ApplyResources(this.ResetReceiptButton, "ResetReceiptButton");
            this.ResetReceiptButton.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Reset_96px__2_;
            this.ResetReceiptButton.FlatAppearance.BorderSize = 0;
            this.ResetReceiptButton.Name = "ResetReceiptButton";
            this.ResetReceiptButton.UseVisualStyleBackColor = true;
            this.ResetReceiptButton.Click += new System.EventHandler(this.ResetReceiptButton_Click);
            // 
            // SelectProductForRefundGroup
            // 
            resources.ApplyResources(this.SelectProductForRefundGroup, "SelectProductForRefundGroup");
            this.SelectProductForRefundGroup.Controls.Add(this.QuantityText);
            this.SelectProductForRefundGroup.Controls.Add(this.ProductLabel);
            this.SelectProductForRefundGroup.Controls.Add(this.AvailableQuantityText);
            this.SelectProductForRefundGroup.Controls.Add(this.ProductSelectorCombo);
            this.SelectProductForRefundGroup.Controls.Add(this.QuantityLabel);
            this.SelectProductForRefundGroup.Controls.Add(this.AddButton);
            this.SelectProductForRefundGroup.Name = "SelectProductForRefundGroup";
            this.SelectProductForRefundGroup.TabStop = false;
            // 
            // QuantityText
            // 
            resources.ApplyResources(this.QuantityText, "QuantityText");
            this.QuantityText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.QuantityText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuantityText.Name = "QuantityText";
            this.QuantityText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
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
            this.CartDataGrid.RowHeadersVisible = false;
            this.CartDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CartDataGrid.TabStop = false;
            // 
            // ProductIdColumn
            // 
            this.ProductIdColumn.DataPropertyName = "GetProductId";
            resources.ApplyResources(this.ProductIdColumn, "ProductIdColumn");
            this.ProductIdColumn.Name = "ProductIdColumn";
            // 
            // ProductNameColumn
            // 
            this.ProductNameColumn.DataPropertyName = "ProductName";
            resources.ApplyResources(this.ProductNameColumn, "ProductNameColumn");
            this.ProductNameColumn.Name = "ProductNameColumn";
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.DataPropertyName = "GetQuantity";
            resources.ApplyResources(this.QuantityColumn, "QuantityColumn");
            this.QuantityColumn.Name = "QuantityColumn";
            // 
            // UnitNameColumn
            // 
            this.UnitNameColumn.DataPropertyName = "GetUnitName";
            resources.ApplyResources(this.UnitNameColumn, "UnitNameColumn");
            this.UnitNameColumn.Name = "UnitNameColumn";
            // 
            // NetPriceColumn
            // 
            this.NetPriceColumn.DataPropertyName = "GetNetPrice";
            resources.ApplyResources(this.NetPriceColumn, "NetPriceColumn");
            this.NetPriceColumn.Name = "NetPriceColumn";
            // 
            // NotesText
            // 
            resources.ApplyResources(this.NotesText, "NotesText");
            this.NotesText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NotesText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NotesText.Name = "NotesText";
            // 
            // NotesLabel
            // 
            resources.ApplyResources(this.NotesLabel, "NotesLabel");
            this.NotesLabel.Name = "NotesLabel";
            // 
            // ReturnedAmountText
            // 
            resources.ApplyResources(this.ReturnedAmountText, "ReturnedAmountText");
            this.ReturnedAmountText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ReturnedAmountText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReturnedAmountText.Name = "ReturnedAmountText";
            this.ReturnedAmountText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // RefundAmountLabel
            // 
            resources.ApplyResources(this.RefundAmountLabel, "RefundAmountLabel");
            this.RefundAmountLabel.Name = "RefundAmountLabel";
            // 
            // RefundAmountGroupBox
            // 
            resources.ApplyResources(this.RefundAmountGroupBox, "RefundAmountGroupBox");
            this.RefundAmountGroupBox.Controls.Add(this.ReturnedAmountText);
            this.RefundAmountGroupBox.Controls.Add(this.RefundAmountLabel);
            this.RefundAmountGroupBox.Controls.Add(this.CutPercentageText);
            this.RefundAmountGroupBox.Controls.Add(this.CutAmountText);
            this.RefundAmountGroupBox.Controls.Add(this.NotesText);
            this.RefundAmountGroupBox.Controls.Add(this.RefundCutLabel);
            this.RefundAmountGroupBox.Controls.Add(this.NotesLabel);
            this.RefundAmountGroupBox.Controls.Add(this.PercentageOrLabel);
            this.RefundAmountGroupBox.Controls.Add(this.SubmitButton);
            this.RefundAmountGroupBox.Name = "RefundAmountGroupBox";
            this.RefundAmountGroupBox.TabStop = false;
            // 
            // ReturnForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ReturnedProductsGroupBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.RefundAmountGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReturnForm";
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