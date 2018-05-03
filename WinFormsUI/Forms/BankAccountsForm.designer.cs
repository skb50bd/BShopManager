namespace WinFormsUI.Forms
{
    partial class BankAccountsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankAccountsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DeleteTransactionButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AccountLabel = new System.Windows.Forms.Label();
            this.TransactionsLabel = new System.Windows.Forms.Label();
            this.TransactionTypeSelectorCombo = new System.Windows.Forms.ComboBox();
            this.TransactionsDataGrid = new System.Windows.Forms.DataGridView();
            this.BankAccountIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankAccountNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IndividualColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AddAccountButton = new System.Windows.Forms.Button();
            this.EditAccountButton = new System.Windows.Forms.Button();
            this.DeleteAccountButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.AddTransactionButton = new System.Windows.Forms.Button();
            this.AccountSelectorCombo = new System.Windows.Forms.ComboBox();
            this.ViewEditEmployeeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteTransactionButton
            // 
            resources.ApplyResources(this.DeleteTransactionButton, "DeleteTransactionButton");
            this.DeleteTransactionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.DeleteTransactionButton.FlatAppearance.BorderSize = 0;
            this.DeleteTransactionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.DeleteTransactionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(135)))));
            this.DeleteTransactionButton.ForeColor = System.Drawing.Color.White;
            this.DeleteTransactionButton.Name = "DeleteTransactionButton";
            this.ButtonToolTip.SetToolTip(this.DeleteTransactionButton, resources.GetString("DeleteTransactionButton.ToolTip"));
            this.DeleteTransactionButton.UseVisualStyleBackColor = false;
            this.DeleteTransactionButton.Click += new System.EventHandler(this.DeleteTransactionButton_Click);
            // 
            // TitleLabel
            // 
            resources.ApplyResources(this.TitleLabel, "TitleLabel");
            this.TitleLabel.Name = "TitleLabel";
            this.ButtonToolTip.SetToolTip(this.TitleLabel, resources.GetString("TitleLabel.ToolTip"));
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // AccountLabel
            // 
            resources.ApplyResources(this.AccountLabel, "AccountLabel");
            this.AccountLabel.Name = "AccountLabel";
            this.ButtonToolTip.SetToolTip(this.AccountLabel, resources.GetString("AccountLabel.ToolTip"));
            this.AccountLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TransactionsLabel
            // 
            resources.ApplyResources(this.TransactionsLabel, "TransactionsLabel");
            this.TransactionsLabel.Name = "TransactionsLabel";
            this.ButtonToolTip.SetToolTip(this.TransactionsLabel, resources.GetString("TransactionsLabel.ToolTip"));
            this.TransactionsLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TransactionTypeSelectorCombo
            // 
            resources.ApplyResources(this.TransactionTypeSelectorCombo, "TransactionTypeSelectorCombo");
            this.TransactionTypeSelectorCombo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TransactionTypeSelectorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TransactionTypeSelectorCombo.FormattingEnabled = true;
            this.TransactionTypeSelectorCombo.Items.AddRange(new object[] {
            resources.GetString("TransactionTypeSelectorCombo.Items"),
            resources.GetString("TransactionTypeSelectorCombo.Items1"),
            resources.GetString("TransactionTypeSelectorCombo.Items2")});
            this.TransactionTypeSelectorCombo.Name = "TransactionTypeSelectorCombo";
            this.ButtonToolTip.SetToolTip(this.TransactionTypeSelectorCombo, resources.GetString("TransactionTypeSelectorCombo.ToolTip"));
            this.TransactionTypeSelectorCombo.SelectedIndexChanged += new System.EventHandler(this.TransactionTypeSelectorCombo_SelectedIndexChanged);
            // 
            // TransactionsDataGrid
            // 
            resources.ApplyResources(this.TransactionsDataGrid, "TransactionsDataGrid");
            this.TransactionsDataGrid.AllowUserToAddRows = false;
            this.TransactionsDataGrid.AllowUserToDeleteRows = false;
            this.TransactionsDataGrid.AllowUserToOrderColumns = true;
            this.TransactionsDataGrid.AllowUserToResizeRows = false;
            this.TransactionsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TransactionsDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.TransactionsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TransactionsDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TransactionsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TransactionsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TransactionsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BankAccountIdColumn,
            this.BankAccountNameColumn,
            this.TransactionTypeColumn,
            this.Amount,
            this.TransactionCodeColumn,
            this.CheckNumberColumn,
            this.IndividualColumn,
            this.CreatedColumn,
            this.CreatorColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TransactionsDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.TransactionsDataGrid.GridColor = System.Drawing.Color.WhiteSmoke;
            this.TransactionsDataGrid.Name = "TransactionsDataGrid";
            this.TransactionsDataGrid.ReadOnly = true;
            this.TransactionsDataGrid.RowHeadersVisible = false;
            this.TransactionsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ButtonToolTip.SetToolTip(this.TransactionsDataGrid, resources.GetString("TransactionsDataGrid.ToolTip"));
            // 
            // BankAccountIdColumn
            // 
            this.BankAccountIdColumn.DataPropertyName = "GetAccountId";
            resources.ApplyResources(this.BankAccountIdColumn, "BankAccountIdColumn");
            this.BankAccountIdColumn.Name = "BankAccountIdColumn";
            this.BankAccountIdColumn.ReadOnly = true;
            // 
            // BankAccountNameColumn
            // 
            this.BankAccountNameColumn.DataPropertyName = "BankAccountName";
            resources.ApplyResources(this.BankAccountNameColumn, "BankAccountNameColumn");
            this.BankAccountNameColumn.Name = "BankAccountNameColumn";
            this.BankAccountNameColumn.ReadOnly = true;
            // 
            // TransactionTypeColumn
            // 
            this.TransactionTypeColumn.DataPropertyName = "GetTransactionType";
            resources.ApplyResources(this.TransactionTypeColumn, "TransactionTypeColumn");
            this.TransactionTypeColumn.Name = "TransactionTypeColumn";
            this.TransactionTypeColumn.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "GetAmount";
            resources.ApplyResources(this.Amount, "Amount");
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // TransactionCodeColumn
            // 
            this.TransactionCodeColumn.DataPropertyName = "TransactionCode";
            resources.ApplyResources(this.TransactionCodeColumn, "TransactionCodeColumn");
            this.TransactionCodeColumn.Name = "TransactionCodeColumn";
            this.TransactionCodeColumn.ReadOnly = true;
            // 
            // CheckNumberColumn
            // 
            this.CheckNumberColumn.DataPropertyName = "CheckNumber";
            resources.ApplyResources(this.CheckNumberColumn, "CheckNumberColumn");
            this.CheckNumberColumn.Name = "CheckNumberColumn";
            this.CheckNumberColumn.ReadOnly = true;
            // 
            // IndividualColumn
            // 
            this.IndividualColumn.DataPropertyName = "Individual";
            resources.ApplyResources(this.IndividualColumn, "IndividualColumn");
            this.IndividualColumn.Name = "IndividualColumn";
            this.IndividualColumn.ReadOnly = true;
            // 
            // CreatedColumn
            // 
            this.CreatedColumn.DataPropertyName = "Created";
            resources.ApplyResources(this.CreatedColumn, "CreatedColumn");
            this.CreatedColumn.Name = "CreatedColumn";
            this.CreatedColumn.ReadOnly = true;
            // 
            // CreatorColumn
            // 
            this.CreatorColumn.DataPropertyName = "Creator";
            resources.ApplyResources(this.CreatorColumn, "CreatorColumn");
            this.CreatorColumn.Name = "CreatorColumn";
            this.CreatorColumn.ReadOnly = true;
            // 
            // ButtonToolTip
            // 
            this.ButtonToolTip.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ButtonToolTip.ToolTipTitle = "Button Information";
            // 
            // AddAccountButton
            // 
            resources.ApplyResources(this.AddAccountButton, "AddAccountButton");
            this.AddAccountButton.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Plus_Math_96px_1;
            this.AddAccountButton.FlatAppearance.BorderSize = 0;
            this.AddAccountButton.Name = "AddAccountButton";
            this.ButtonToolTip.SetToolTip(this.AddAccountButton, resources.GetString("AddAccountButton.ToolTip"));
            this.AddAccountButton.UseVisualStyleBackColor = true;
            this.AddAccountButton.Click += new System.EventHandler(this.AddAccountButton_Click);
            // 
            // EditAccountButton
            // 
            resources.ApplyResources(this.EditAccountButton, "EditAccountButton");
            this.EditAccountButton.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Edit_96px;
            this.EditAccountButton.FlatAppearance.BorderSize = 0;
            this.EditAccountButton.Name = "EditAccountButton";
            this.ButtonToolTip.SetToolTip(this.EditAccountButton, resources.GetString("EditAccountButton.ToolTip"));
            this.EditAccountButton.UseVisualStyleBackColor = true;
            this.EditAccountButton.Click += new System.EventHandler(this.EditAccountButton_Click);
            // 
            // DeleteAccountButton
            // 
            resources.ApplyResources(this.DeleteAccountButton, "DeleteAccountButton");
            this.DeleteAccountButton.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Delete_96px;
            this.DeleteAccountButton.FlatAppearance.BorderSize = 0;
            this.DeleteAccountButton.Name = "DeleteAccountButton";
            this.ButtonToolTip.SetToolTip(this.DeleteAccountButton, resources.GetString("DeleteAccountButton.ToolTip"));
            this.DeleteAccountButton.UseVisualStyleBackColor = true;
            this.DeleteAccountButton.Click += new System.EventHandler(this.DeleteAccountButton_ClickAsync);
            // 
            // PrintButton
            // 
            resources.ApplyResources(this.PrintButton, "PrintButton");
            this.PrintButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(149)))), ((int)(((byte)(199)))));
            this.PrintButton.FlatAppearance.BorderSize = 0;
            this.PrintButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.PrintButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(184)))), ((int)(((byte)(217)))));
            this.PrintButton.ForeColor = System.Drawing.Color.White;
            this.PrintButton.Name = "PrintButton";
            this.ButtonToolTip.SetToolTip(this.PrintButton, resources.GetString("PrintButton.ToolTip"));
            this.PrintButton.UseVisualStyleBackColor = false;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // AddTransactionButton
            // 
            resources.ApplyResources(this.AddTransactionButton, "AddTransactionButton");
            this.AddTransactionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.AddTransactionButton.FlatAppearance.BorderSize = 0;
            this.AddTransactionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(170)))));
            this.AddTransactionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.AddTransactionButton.ForeColor = System.Drawing.Color.White;
            this.AddTransactionButton.Name = "AddTransactionButton";
            this.ButtonToolTip.SetToolTip(this.AddTransactionButton, resources.GetString("AddTransactionButton.ToolTip"));
            this.AddTransactionButton.UseVisualStyleBackColor = false;
            this.AddTransactionButton.Click += new System.EventHandler(this.AddTransactionButton_Click);
            // 
            // AccountSelectorCombo
            // 
            resources.ApplyResources(this.AccountSelectorCombo, "AccountSelectorCombo");
            this.AccountSelectorCombo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AccountSelectorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccountSelectorCombo.FormattingEnabled = true;
            this.AccountSelectorCombo.Name = "AccountSelectorCombo";
            this.ButtonToolTip.SetToolTip(this.AccountSelectorCombo, resources.GetString("AccountSelectorCombo.ToolTip"));
            this.AccountSelectorCombo.SelectedIndexChanged += new System.EventHandler(this.AccountSelectorCombo_SelectedIndexChanged);
            // 
            // ViewEditEmployeeButton
            // 
            resources.ApplyResources(this.ViewEditEmployeeButton, "ViewEditEmployeeButton");
            this.ViewEditEmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.ViewEditEmployeeButton.FlatAppearance.BorderSize = 0;
            this.ViewEditEmployeeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.ViewEditEmployeeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            this.ViewEditEmployeeButton.ForeColor = System.Drawing.Color.White;
            this.ViewEditEmployeeButton.Name = "ViewEditEmployeeButton";
            this.ButtonToolTip.SetToolTip(this.ViewEditEmployeeButton, resources.GetString("ViewEditEmployeeButton.ToolTip"));
            this.ViewEditEmployeeButton.UseVisualStyleBackColor = false;
            this.ViewEditEmployeeButton.Click += new System.EventHandler(this.ViewEditEmployeeButton_Click);
            // 
            // BankAccountsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ViewEditEmployeeButton);
            this.Controls.Add(this.AccountSelectorCombo);
            this.Controls.Add(this.AddTransactionButton);
            this.Controls.Add(this.AddAccountButton);
            this.Controls.Add(this.EditAccountButton);
            this.Controls.Add(this.DeleteAccountButton);
            this.Controls.Add(this.TransactionsDataGrid);
            this.Controls.Add(this.TransactionTypeSelectorCombo);
            this.Controls.Add(this.TransactionsLabel);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.AccountLabel);
            this.Controls.Add(this.DeleteTransactionButton);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BankAccountsForm";
            this.ButtonToolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.BankAccountsForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteTransactionButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label AccountLabel;
        private System.Windows.Forms.Label TransactionsLabel;
        private System.Windows.Forms.ComboBox TransactionTypeSelectorCombo;
        private System.Windows.Forms.DataGridView TransactionsDataGrid;
        private System.Windows.Forms.Button DeleteAccountButton;
        private System.Windows.Forms.Button EditAccountButton;
        private System.Windows.Forms.Button AddAccountButton;
        private System.Windows.Forms.ToolTip ButtonToolTip;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button AddTransactionButton;
        private System.Windows.Forms.ComboBox AccountSelectorCombo;
        private System.Windows.Forms.Button ViewEditEmployeeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankAccountIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankAccountNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionTypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndividualColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatorColumn;
    }
}