namespace WinFormsUI.Forms
{
    partial class ExpenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenseForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.RemoveSelectedButton = new System.Windows.Forms.Button();
            this.UnitPriceText = new System.Windows.Forms.TextBox();
            this.UnitPriceLabel = new System.Windows.Forms.Label();
            this.QuantityText = new System.Windows.Forms.TextBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.AddToListButton = new System.Windows.Forms.Button();
            this.NotesText = new System.Windows.Forms.RichTextBox();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalText = new System.Windows.Forms.Label();
            this.CartDataGrid = new System.Windows.Forms.DataGridView();
            this.ProductNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetPriceText = new System.Windows.Forms.TextBox();
            this.NetPriceLabel = new System.Windows.Forms.Label();
            this.ExpenseDateTime = new System.Windows.Forms.DateTimePicker();
            this.ProductText = new System.Windows.Forms.TextBox();
            this.ProductInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.SubmissionGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGrid)).BeginInit();
            this.ProductInfoGroupBox.SuspendLayout();
            this.SubmissionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semi Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(7, 7);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(142, 47);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Expense";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductLabel.Location = new System.Drawing.Point(16, 20);
            this.ProductLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(99, 21);
            this.ProductLabel.TabIndex = 0;
            this.ProductLabel.Text = "Entry Name :";
            this.ProductLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
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
            this.SubmitButton.Location = new System.Drawing.Point(70, 216);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(268, 42);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "Save";
            this.SubmitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            this.RemoveSelectedButton.Location = new System.Drawing.Point(14, 412);
            this.RemoveSelectedButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.RemoveSelectedButton.Name = "RemoveSelectedButton";
            this.RemoveSelectedButton.Size = new System.Drawing.Size(417, 42);
            this.RemoveSelectedButton.TabIndex = 3;
            this.RemoveSelectedButton.Text = "Remove Selected";
            this.RemoveSelectedButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RemoveSelectedButton.UseVisualStyleBackColor = false;
            this.RemoveSelectedButton.Click += new System.EventHandler(this.RemoveSelectedButton_Click);
            // 
            // UnitPriceText
            // 
            this.UnitPriceText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UnitPriceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UnitPriceText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitPriceText.Location = new System.Drawing.Point(129, 51);
            this.UnitPriceText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.UnitPriceText.Name = "UnitPriceText";
            this.UnitPriceText.Size = new System.Drawing.Size(98, 22);
            this.UnitPriceText.TabIndex = 3;
            this.UnitPriceText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            this.UnitPriceText.Leave += new System.EventHandler(this.UnitPriceText_Leave);
            // 
            // UnitPriceLabel
            // 
            this.UnitPriceLabel.AutoSize = true;
            this.UnitPriceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitPriceLabel.Location = new System.Drawing.Point(31, 51);
            this.UnitPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UnitPriceLabel.Name = "UnitPriceLabel";
            this.UnitPriceLabel.Size = new System.Drawing.Size(84, 21);
            this.UnitPriceLabel.TabIndex = 2;
            this.UnitPriceLabel.Text = "Unit Price :";
            this.UnitPriceLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // QuantityText
            // 
            this.QuantityText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.QuantityText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuantityText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityText.Location = new System.Drawing.Point(312, 51);
            this.QuantityText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.QuantityText.Name = "QuantityText";
            this.QuantityText.Size = new System.Drawing.Size(98, 22);
            this.QuantityText.TabIndex = 5;
            this.QuantityText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            this.QuantityText.Leave += new System.EventHandler(this.QuantityText_Leave);
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLabel.Location = new System.Drawing.Point(256, 51);
            this.QuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(42, 21);
            this.QuantityLabel.TabIndex = 4;
            this.QuantityLabel.Text = "Qty :";
            this.QuantityLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // AddToListButton
            // 
            this.AddToListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.AddToListButton.FlatAppearance.BorderSize = 0;
            this.AddToListButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.AddToListButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            this.AddToListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToListButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToListButton.ForeColor = System.Drawing.Color.White;
            this.AddToListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddToListButton.Location = new System.Drawing.Point(239, 83);
            this.AddToListButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.AddToListButton.Name = "AddToListButton";
            this.AddToListButton.Size = new System.Drawing.Size(171, 42);
            this.AddToListButton.TabIndex = 8;
            this.AddToListButton.Text = "Add to List";
            this.AddToListButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AddToListButton.UseVisualStyleBackColor = false;
            this.AddToListButton.Click += new System.EventHandler(this.AddToListButton_Click);
            // 
            // NotesText
            // 
            this.NotesText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NotesText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NotesText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesText.Location = new System.Drawing.Point(70, 102);
            this.NotesText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.NotesText.Name = "NotesText";
            this.NotesText.Size = new System.Drawing.Size(268, 101);
            this.NotesText.TabIndex = 4;
            this.NotesText.Text = "";
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesLabel.Location = new System.Drawing.Point(4, 102);
            this.NotesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(58, 21);
            this.NotesLabel.TabIndex = 3;
            this.NotesLabel.Text = "Notes :";
            this.NotesLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(4, 69);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(49, 21);
            this.TotalLabel.TabIndex = 1;
            this.TotalLabel.Text = "Total :";
            this.TotalLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TotalText
            // 
            this.TotalText.AutoSize = true;
            this.TotalText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalText.Location = new System.Drawing.Point(65, 69);
            this.TotalText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalText.Name = "TotalText";
            this.TotalText.Size = new System.Drawing.Size(90, 25);
            this.TotalText.TabIndex = 2;
            this.TotalText.Text = "<TOTAL>";
            this.TotalText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
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
            this.ProductNameColumn,
            this.UnitPriceColumn,
            this.QuantityColumn,
            this.NetPriceColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CartDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.CartDataGrid.GridColor = System.Drawing.Color.White;
            this.CartDataGrid.Location = new System.Drawing.Point(14, 193);
            this.CartDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.CartDataGrid.MultiSelect = false;
            this.CartDataGrid.Name = "CartDataGrid";
            this.CartDataGrid.ReadOnly = true;
            this.CartDataGrid.RowHeadersVisible = false;
            this.CartDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CartDataGrid.Size = new System.Drawing.Size(417, 210);
            this.CartDataGrid.TabIndex = 0;
            // 
            // ProductNameColumn
            // 
            this.ProductNameColumn.DataPropertyName = "ProductName";
            this.ProductNameColumn.HeaderText = "Product Name";
            this.ProductNameColumn.Name = "ProductNameColumn";
            this.ProductNameColumn.ReadOnly = true;
            this.ProductNameColumn.Width = 135;
            // 
            // UnitPriceColumn
            // 
            this.UnitPriceColumn.DataPropertyName = "GetUnitPurchasePrice";
            this.UnitPriceColumn.HeaderText = "Unit Price";
            this.UnitPriceColumn.Name = "UnitPriceColumn";
            this.UnitPriceColumn.ReadOnly = true;
            this.UnitPriceColumn.Width = 102;
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.DataPropertyName = "GetQuantity";
            this.QuantityColumn.HeaderText = "Qty";
            this.QuantityColumn.Name = "QuantityColumn";
            this.QuantityColumn.ReadOnly = true;
            this.QuantityColumn.Width = 60;
            // 
            // NetPriceColumn
            // 
            this.NetPriceColumn.DataPropertyName = "GetNetPurhcasePrice";
            this.NetPriceColumn.HeaderText = "Net Price";
            this.NetPriceColumn.Name = "NetPriceColumn";
            this.NetPriceColumn.ReadOnly = true;
            this.NetPriceColumn.Width = 98;
            // 
            // NetPriceText
            // 
            this.NetPriceText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NetPriceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NetPriceText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetPriceText.Location = new System.Drawing.Point(129, 83);
            this.NetPriceText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.NetPriceText.Name = "NetPriceText";
            this.NetPriceText.Size = new System.Drawing.Size(98, 22);
            this.NetPriceText.TabIndex = 7;
            this.NetPriceText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            this.NetPriceText.Leave += new System.EventHandler(this.NetPriceText_Leave);
            // 
            // NetPriceLabel
            // 
            this.NetPriceLabel.AutoSize = true;
            this.NetPriceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetPriceLabel.Location = new System.Drawing.Point(35, 83);
            this.NetPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NetPriceLabel.Name = "NetPriceLabel";
            this.NetPriceLabel.Size = new System.Drawing.Size(80, 21);
            this.NetPriceLabel.TabIndex = 6;
            this.NetPriceLabel.Text = "Net Price :";
            // 
            // ExpenseDateTime
            // 
            this.ExpenseDateTime.CalendarMonthBackground = System.Drawing.Color.White;
            this.ExpenseDateTime.CustomFormat = "dd MMMM yyyy - hh:mm tt";
            this.ExpenseDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ExpenseDateTime.Location = new System.Drawing.Point(8, 21);
            this.ExpenseDateTime.Name = "ExpenseDateTime";
            this.ExpenseDateTime.Size = new System.Drawing.Size(330, 29);
            this.ExpenseDateTime.TabIndex = 0;
            // 
            // ProductText
            // 
            this.ProductText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ProductText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductText.Location = new System.Drawing.Point(129, 20);
            this.ProductText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ProductText.Name = "ProductText";
            this.ProductText.Size = new System.Drawing.Size(281, 22);
            this.ProductText.TabIndex = 1;
            // 
            // ProductInfoGroupBox
            // 
            this.ProductInfoGroupBox.Controls.Add(this.ProductText);
            this.ProductInfoGroupBox.Controls.Add(this.AddToListButton);
            this.ProductInfoGroupBox.Controls.Add(this.NetPriceText);
            this.ProductInfoGroupBox.Controls.Add(this.QuantityText);
            this.ProductInfoGroupBox.Controls.Add(this.NetPriceLabel);
            this.ProductInfoGroupBox.Controls.Add(this.QuantityLabel);
            this.ProductInfoGroupBox.Controls.Add(this.UnitPriceText);
            this.ProductInfoGroupBox.Controls.Add(this.UnitPriceLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductLabel);
            this.ProductInfoGroupBox.Location = new System.Drawing.Point(12, 50);
            this.ProductInfoGroupBox.Name = "ProductInfoGroupBox";
            this.ProductInfoGroupBox.Size = new System.Drawing.Size(417, 136);
            this.ProductInfoGroupBox.TabIndex = 1;
            this.ProductInfoGroupBox.TabStop = false;
            // 
            // SubmissionGroupBox
            // 
            this.SubmissionGroupBox.Controls.Add(this.ExpenseDateTime);
            this.SubmissionGroupBox.Controls.Add(this.SubmitButton);
            this.SubmissionGroupBox.Controls.Add(this.NotesLabel);
            this.SubmissionGroupBox.Controls.Add(this.NotesText);
            this.SubmissionGroupBox.Controls.Add(this.TotalText);
            this.SubmissionGroupBox.Controls.Add(this.TotalLabel);
            this.SubmissionGroupBox.Location = new System.Drawing.Point(436, 50);
            this.SubmissionGroupBox.Name = "SubmissionGroupBox";
            this.SubmissionGroupBox.Size = new System.Drawing.Size(347, 268);
            this.SubmissionGroupBox.TabIndex = 4;
            this.SubmissionGroupBox.TabStop = false;
            // 
            // ExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(795, 465);
            this.Controls.Add(this.SubmissionGroupBox);
            this.Controls.Add(this.ProductInfoGroupBox);
            this.Controls.Add(this.CartDataGrid);
            this.Controls.Add(this.RemoveSelectedButton);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ExpenseForm";
            this.Text = "Expense";
            this.Load += new System.EventHandler(this.ExpenseForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGrid)).EndInit();
            this.ProductInfoGroupBox.ResumeLayout(false);
            this.ProductInfoGroupBox.PerformLayout();
            this.SubmissionGroupBox.ResumeLayout(false);
            this.SubmissionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button RemoveSelectedButton;
        private System.Windows.Forms.TextBox UnitPriceText;
        private System.Windows.Forms.Label UnitPriceLabel;
        private System.Windows.Forms.TextBox QuantityText;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Button AddToListButton;
        private System.Windows.Forms.RichTextBox NotesText;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label TotalText;
        private System.Windows.Forms.DataGridView CartDataGrid;
        private System.Windows.Forms.TextBox NetPriceText;
        private System.Windows.Forms.Label NetPriceLabel;
        private System.Windows.Forms.DateTimePicker ExpenseDateTime;
        private System.Windows.Forms.TextBox ProductText;
        private System.Windows.Forms.GroupBox ProductInfoGroupBox;
        private System.Windows.Forms.GroupBox SubmissionGroupBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetPriceColumn;
    }
}