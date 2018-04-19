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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenseForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.TitleText = new System.Windows.Forms.TextBox();
            this.ExpenseTitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CartDataGrid)).BeginInit();
            this.ProductInfoGroupBox.SuspendLayout();
            this.SubmissionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            resources.ApplyResources(this.TitleLabel, "TitleLabel");
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // ProductLabel
            // 
            resources.ApplyResources(this.ProductLabel, "ProductLabel");
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
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
            // RemoveSelectedButton
            // 
            resources.ApplyResources(this.RemoveSelectedButton, "RemoveSelectedButton");
            this.RemoveSelectedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.RemoveSelectedButton.FlatAppearance.BorderSize = 0;
            this.RemoveSelectedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.RemoveSelectedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(135)))));
            this.RemoveSelectedButton.ForeColor = System.Drawing.Color.White;
            this.RemoveSelectedButton.Name = "RemoveSelectedButton";
            this.RemoveSelectedButton.UseVisualStyleBackColor = false;
            this.RemoveSelectedButton.Click += new System.EventHandler(this.RemoveSelectedButton_Click);
            // 
            // UnitPriceText
            // 
            resources.ApplyResources(this.UnitPriceText, "UnitPriceText");
            this.UnitPriceText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UnitPriceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UnitPriceText.Name = "UnitPriceText";
            this.UnitPriceText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UnitPriceText_KeyDown);
            this.UnitPriceText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            this.UnitPriceText.Leave += new System.EventHandler(this.UnitPriceText_Leave);
            // 
            // UnitPriceLabel
            // 
            resources.ApplyResources(this.UnitPriceLabel, "UnitPriceLabel");
            this.UnitPriceLabel.Name = "UnitPriceLabel";
            this.UnitPriceLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // QuantityText
            // 
            resources.ApplyResources(this.QuantityText, "QuantityText");
            this.QuantityText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.QuantityText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuantityText.Name = "QuantityText";
            this.QuantityText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QuantityText_KeyDown);
            this.QuantityText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            this.QuantityText.Leave += new System.EventHandler(this.QuantityText_Leave);
            // 
            // QuantityLabel
            // 
            resources.ApplyResources(this.QuantityLabel, "QuantityLabel");
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // AddToListButton
            // 
            resources.ApplyResources(this.AddToListButton, "AddToListButton");
            this.AddToListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.AddToListButton.FlatAppearance.BorderSize = 0;
            this.AddToListButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.AddToListButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            this.AddToListButton.ForeColor = System.Drawing.Color.White;
            this.AddToListButton.Name = "AddToListButton";
            this.AddToListButton.UseVisualStyleBackColor = false;
            this.AddToListButton.Click += new System.EventHandler(this.AddToListButton_Click);
            // 
            // NotesText
            // 
            resources.ApplyResources(this.NotesText, "NotesText");
            this.NotesText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NotesText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NotesText.Name = "NotesText";
            this.NotesText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NotesText_KeyDown);
            // 
            // NotesLabel
            // 
            resources.ApplyResources(this.NotesLabel, "NotesLabel");
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TotalLabel
            // 
            resources.ApplyResources(this.TotalLabel, "TotalLabel");
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TotalText
            // 
            resources.ApplyResources(this.TotalText, "TotalText");
            this.TotalText.Name = "TotalText";
            this.TotalText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
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
            this.ProductNameColumn,
            this.UnitPriceColumn,
            this.QuantityColumn,
            this.NetPriceColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CartDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.CartDataGrid.GridColor = System.Drawing.Color.White;
            this.CartDataGrid.MultiSelect = false;
            this.CartDataGrid.Name = "CartDataGrid";
            this.CartDataGrid.ReadOnly = true;
            this.CartDataGrid.RowHeadersVisible = false;
            this.CartDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // ProductNameColumn
            // 
            this.ProductNameColumn.DataPropertyName = "ProductName";
            resources.ApplyResources(this.ProductNameColumn, "ProductNameColumn");
            this.ProductNameColumn.Name = "ProductNameColumn";
            this.ProductNameColumn.ReadOnly = true;
            // 
            // UnitPriceColumn
            // 
            this.UnitPriceColumn.DataPropertyName = "GetUnitPurchasePrice";
            resources.ApplyResources(this.UnitPriceColumn, "UnitPriceColumn");
            this.UnitPriceColumn.Name = "UnitPriceColumn";
            this.UnitPriceColumn.ReadOnly = true;
            // 
            // QuantityColumn
            // 
            this.QuantityColumn.DataPropertyName = "GetQuantity";
            resources.ApplyResources(this.QuantityColumn, "QuantityColumn");
            this.QuantityColumn.Name = "QuantityColumn";
            this.QuantityColumn.ReadOnly = true;
            // 
            // NetPriceColumn
            // 
            this.NetPriceColumn.DataPropertyName = "GetNetPurhcasePrice";
            resources.ApplyResources(this.NetPriceColumn, "NetPriceColumn");
            this.NetPriceColumn.Name = "NetPriceColumn";
            this.NetPriceColumn.ReadOnly = true;
            // 
            // NetPriceText
            // 
            resources.ApplyResources(this.NetPriceText, "NetPriceText");
            this.NetPriceText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NetPriceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NetPriceText.Name = "NetPriceText";
            this.NetPriceText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NetPriceText_KeyDown);
            this.NetPriceText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            this.NetPriceText.Leave += new System.EventHandler(this.NetPriceText_Leave);
            // 
            // NetPriceLabel
            // 
            resources.ApplyResources(this.NetPriceLabel, "NetPriceLabel");
            this.NetPriceLabel.Name = "NetPriceLabel";
            // 
            // ExpenseDateTime
            // 
            resources.ApplyResources(this.ExpenseDateTime, "ExpenseDateTime");
            this.ExpenseDateTime.CalendarMonthBackground = System.Drawing.Color.White;
            this.ExpenseDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ExpenseDateTime.Name = "ExpenseDateTime";
            this.ExpenseDateTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExpenseDateTime_KeyDown);
            // 
            // ProductText
            // 
            resources.ApplyResources(this.ProductText, "ProductText");
            this.ProductText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ProductText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.ProductText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ProductText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductText.Name = "ProductText";
            this.ProductText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductText_KeyDown);
            // 
            // ProductInfoGroupBox
            // 
            resources.ApplyResources(this.ProductInfoGroupBox, "ProductInfoGroupBox");
            this.ProductInfoGroupBox.Controls.Add(this.ProductText);
            this.ProductInfoGroupBox.Controls.Add(this.AddToListButton);
            this.ProductInfoGroupBox.Controls.Add(this.NetPriceText);
            this.ProductInfoGroupBox.Controls.Add(this.QuantityText);
            this.ProductInfoGroupBox.Controls.Add(this.NetPriceLabel);
            this.ProductInfoGroupBox.Controls.Add(this.QuantityLabel);
            this.ProductInfoGroupBox.Controls.Add(this.UnitPriceText);
            this.ProductInfoGroupBox.Controls.Add(this.UnitPriceLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ProductLabel);
            this.ProductInfoGroupBox.Name = "ProductInfoGroupBox";
            this.ProductInfoGroupBox.TabStop = false;
            // 
            // SubmissionGroupBox
            // 
            resources.ApplyResources(this.SubmissionGroupBox, "SubmissionGroupBox");
            this.SubmissionGroupBox.Controls.Add(this.TitleText);
            this.SubmissionGroupBox.Controls.Add(this.ExpenseTitleLabel);
            this.SubmissionGroupBox.Controls.Add(this.ExpenseDateTime);
            this.SubmissionGroupBox.Controls.Add(this.SubmitButton);
            this.SubmissionGroupBox.Controls.Add(this.NotesLabel);
            this.SubmissionGroupBox.Controls.Add(this.NotesText);
            this.SubmissionGroupBox.Controls.Add(this.TotalText);
            this.SubmissionGroupBox.Controls.Add(this.TotalLabel);
            this.SubmissionGroupBox.Name = "SubmissionGroupBox";
            this.SubmissionGroupBox.TabStop = false;
            // 
            // TitleText
            // 
            resources.ApplyResources(this.TitleText, "TitleText");
            this.TitleText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TitleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleText.Name = "TitleText";
            this.TitleText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TitleText_KeyDown);
            // 
            // ExpenseTitleLabel
            // 
            resources.ApplyResources(this.ExpenseTitleLabel, "ExpenseTitleLabel");
            this.ExpenseTitleLabel.Name = "ExpenseTitleLabel";
            // 
            // ExpenseForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.SubmissionGroupBox);
            this.Controls.Add(this.ProductInfoGroupBox);
            this.Controls.Add(this.CartDataGrid);
            this.Controls.Add(this.RemoveSelectedButton);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ExpenseForm";
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
        private System.Windows.Forms.TextBox TitleText;
        private System.Windows.Forms.Label ExpenseTitleLabel;
    }
}