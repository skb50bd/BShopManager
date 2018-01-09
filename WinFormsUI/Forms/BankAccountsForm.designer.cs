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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankAccountsForm));
            this.DeleteTransactionButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AccountLabel = new System.Windows.Forms.Label();
            this.TransactionsLabel = new System.Windows.Forms.Label();
            this.TransactionTypeSelectorCombo = new System.Windows.Forms.ComboBox();
            this.TransactionsDataGrid = new System.Windows.Forms.DataGridView();
            this.ButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AddAccountButton = new System.Windows.Forms.Button();
            this.EditAccountButton = new System.Windows.Forms.Button();
            this.DeleteAccountButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.AddTransactionButton = new System.Windows.Forms.Button();
            this.AccountSelectorCombo = new System.Windows.Forms.ComboBox();
            this.ViewEditEmployeeButton = new System.Windows.Forms.Button();
            this.BankAccountIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankAccountNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IndividualColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteTransactionButton
            // 
            this.DeleteTransactionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.DeleteTransactionButton.FlatAppearance.BorderSize = 0;
            this.DeleteTransactionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.DeleteTransactionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(135)))));
            this.DeleteTransactionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteTransactionButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteTransactionButton.ForeColor = System.Drawing.Color.White;
            this.DeleteTransactionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteTransactionButton.Location = new System.Drawing.Point(214, 487);
            this.DeleteTransactionButton.Name = "DeleteTransactionButton";
            this.DeleteTransactionButton.Size = new System.Drawing.Size(194, 42);
            this.DeleteTransactionButton.TabIndex = 11;
            this.DeleteTransactionButton.Text = "Delete Selected";
            this.DeleteTransactionButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonToolTip.SetToolTip(this.DeleteTransactionButton, "Deletes the selected transaction(s)");
            this.DeleteTransactionButton.UseVisualStyleBackColor = false;
            this.DeleteTransactionButton.Click += new System.EventHandler(this.DeleteTransactionButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semi Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(2, 6);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(240, 47);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Bank Accounts";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // AccountLabel
            // 
            this.AccountLabel.AutoSize = true;
            this.AccountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountLabel.Location = new System.Drawing.Point(6, 63);
            this.AccountLabel.Name = "AccountLabel";
            this.AccountLabel.Size = new System.Drawing.Size(73, 21);
            this.AccountLabel.TabIndex = 1;
            this.AccountLabel.Text = "Account :";
            this.AccountLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TransactionsLabel
            // 
            this.TransactionsLabel.AutoSize = true;
            this.TransactionsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionsLabel.Location = new System.Drawing.Point(569, 63);
            this.TransactionsLabel.Name = "TransactionsLabel";
            this.TransactionsLabel.Size = new System.Drawing.Size(103, 21);
            this.TransactionsLabel.TabIndex = 6;
            this.TransactionsLabel.Text = "Transactions :";
            this.TransactionsLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TransactionTypeSelectorCombo
            // 
            this.TransactionTypeSelectorCombo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TransactionTypeSelectorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TransactionTypeSelectorCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionTypeSelectorCombo.FormattingEnabled = true;
            this.TransactionTypeSelectorCombo.Items.AddRange(new object[] {
            "All",
            "Deposit",
            "Withdrawal"});
            this.TransactionTypeSelectorCombo.Location = new System.Drawing.Point(679, 59);
            this.TransactionTypeSelectorCombo.Name = "TransactionTypeSelectorCombo";
            this.TransactionTypeSelectorCombo.Size = new System.Drawing.Size(135, 29);
            this.TransactionTypeSelectorCombo.TabIndex = 7;
            this.ButtonToolTip.SetToolTip(this.TransactionTypeSelectorCombo, "Filter the list according to the transaction type");
            this.TransactionTypeSelectorCombo.SelectedIndexChanged += new System.EventHandler(this.TransactionTypeSelectorCombo_SelectedIndexChanged);
            // 
            // TransactionsDataGrid
            // 
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TransactionsDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.TransactionsDataGrid.GridColor = System.Drawing.Color.WhiteSmoke;
            this.TransactionsDataGrid.Location = new System.Drawing.Point(10, 95);
            this.TransactionsDataGrid.Name = "TransactionsDataGrid";
            this.TransactionsDataGrid.ReadOnly = true;
            this.TransactionsDataGrid.RowHeadersVisible = false;
            this.TransactionsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TransactionsDataGrid.Size = new System.Drawing.Size(804, 383);
            this.TransactionsDataGrid.TabIndex = 8;
            // 
            // ButtonToolTip
            // 
            this.ButtonToolTip.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ButtonToolTip.ToolTipTitle = "Button Information";
            // 
            // AddAccountButton
            // 
            this.AddAccountButton.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Plus_Math_96px_1;
            this.AddAccountButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddAccountButton.FlatAppearance.BorderSize = 0;
            this.AddAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAccountButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAccountButton.Location = new System.Drawing.Point(512, 58);
            this.AddAccountButton.Name = "AddAccountButton";
            this.AddAccountButton.Size = new System.Drawing.Size(29, 29);
            this.AddAccountButton.TabIndex = 5;
            this.ButtonToolTip.SetToolTip(this.AddAccountButton, "Add a new Bank Account");
            this.AddAccountButton.UseVisualStyleBackColor = true;
            this.AddAccountButton.Click += new System.EventHandler(this.AddAccountButton_Click);
            // 
            // EditAccountButton
            // 
            this.EditAccountButton.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Edit_96px;
            this.EditAccountButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EditAccountButton.FlatAppearance.BorderSize = 0;
            this.EditAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditAccountButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditAccountButton.Location = new System.Drawing.Point(477, 58);
            this.EditAccountButton.Name = "EditAccountButton";
            this.EditAccountButton.Size = new System.Drawing.Size(29, 29);
            this.EditAccountButton.TabIndex = 4;
            this.ButtonToolTip.SetToolTip(this.EditAccountButton, "Edit the selected Bank Account");
            this.EditAccountButton.UseVisualStyleBackColor = true;
            this.EditAccountButton.Click += new System.EventHandler(this.EditAccountButton_Click);
            // 
            // DeleteAccountButton
            // 
            this.DeleteAccountButton.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Delete_96px;
            this.DeleteAccountButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeleteAccountButton.FlatAppearance.BorderSize = 0;
            this.DeleteAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteAccountButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAccountButton.Location = new System.Drawing.Point(442, 59);
            this.DeleteAccountButton.Name = "DeleteAccountButton";
            this.DeleteAccountButton.Size = new System.Drawing.Size(29, 29);
            this.DeleteAccountButton.TabIndex = 3;
            this.ButtonToolTip.SetToolTip(this.DeleteAccountButton, "Delete the selected Bank Account");
            this.DeleteAccountButton.UseVisualStyleBackColor = true;
            this.DeleteAccountButton.Click += new System.EventHandler(this.DeleteAccountButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(149)))), ((int)(((byte)(199)))));
            this.PrintButton.FlatAppearance.BorderSize = 0;
            this.PrintButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.PrintButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(184)))), ((int)(((byte)(217)))));
            this.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintButton.ForeColor = System.Drawing.Color.White;
            this.PrintButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintButton.Location = new System.Drawing.Point(12, 487);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(194, 42);
            this.PrintButton.TabIndex = 12;
            this.PrintButton.Text = "Print List";
            this.PrintButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonToolTip.SetToolTip(this.PrintButton, "Print the current list of transactions");
            this.PrintButton.UseVisualStyleBackColor = false;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // AddTransactionButton
            // 
            this.AddTransactionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.AddTransactionButton.FlatAppearance.BorderSize = 0;
            this.AddTransactionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(170)))));
            this.AddTransactionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.AddTransactionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTransactionButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTransactionButton.ForeColor = System.Drawing.Color.White;
            this.AddTransactionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddTransactionButton.Location = new System.Drawing.Point(618, 487);
            this.AddTransactionButton.Name = "AddTransactionButton";
            this.AddTransactionButton.Size = new System.Drawing.Size(194, 42);
            this.AddTransactionButton.TabIndex = 9;
            this.AddTransactionButton.Text = "+ Add New Transaction";
            this.AddTransactionButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonToolTip.SetToolTip(this.AddTransactionButton, "Add a new transaction");
            this.AddTransactionButton.UseVisualStyleBackColor = false;
            this.AddTransactionButton.Click += new System.EventHandler(this.AddTransactionButton_Click);
            // 
            // AccountSelectorCombo
            // 
            this.AccountSelectorCombo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AccountSelectorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccountSelectorCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountSelectorCombo.FormattingEnabled = true;
            this.AccountSelectorCombo.Location = new System.Drawing.Point(85, 60);
            this.AccountSelectorCombo.Name = "AccountSelectorCombo";
            this.AccountSelectorCombo.Size = new System.Drawing.Size(353, 29);
            this.AccountSelectorCombo.TabIndex = 2;
            this.ButtonToolTip.SetToolTip(this.AccountSelectorCombo, "Select the account you want");
            this.AccountSelectorCombo.SelectedIndexChanged += new System.EventHandler(this.AccountSelectorCombo_SelectedIndexChanged);
            // 
            // ViewEditEmployeeButton
            // 
            this.ViewEditEmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.ViewEditEmployeeButton.FlatAppearance.BorderSize = 0;
            this.ViewEditEmployeeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.ViewEditEmployeeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            this.ViewEditEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewEditEmployeeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewEditEmployeeButton.ForeColor = System.Drawing.Color.White;
            this.ViewEditEmployeeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewEditEmployeeButton.Location = new System.Drawing.Point(416, 487);
            this.ViewEditEmployeeButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ViewEditEmployeeButton.Name = "ViewEditEmployeeButton";
            this.ViewEditEmployeeButton.Size = new System.Drawing.Size(194, 42);
            this.ViewEditEmployeeButton.TabIndex = 10;
            this.ViewEditEmployeeButton.Text = "View Transaction";
            this.ViewEditEmployeeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonToolTip.SetToolTip(this.ViewEditEmployeeButton, "View the selected transaction");
            this.ViewEditEmployeeButton.UseVisualStyleBackColor = false;
            this.ViewEditEmployeeButton.Click += new System.EventHandler(this.ViewEditEmployeeButton_Click);
            // 
            // BankAccountIdColumn
            // 
            this.BankAccountIdColumn.DataPropertyName = "GetAccountId";
            this.BankAccountIdColumn.HeaderText = "Account Id";
            this.BankAccountIdColumn.Name = "BankAccountIdColumn";
            this.BankAccountIdColumn.ReadOnly = true;
            this.BankAccountIdColumn.Width = 94;
            // 
            // BankAccountNameColumn
            // 
            this.BankAccountNameColumn.DataPropertyName = "BankAccountName";
            this.BankAccountNameColumn.HeaderText = "Account Name";
            this.BankAccountNameColumn.Name = "BankAccountNameColumn";
            this.BankAccountNameColumn.ReadOnly = true;
            this.BankAccountNameColumn.Width = 118;
            // 
            // TransactionTypeColumn
            // 
            this.TransactionTypeColumn.DataPropertyName = "GetTransactionType";
            this.TransactionTypeColumn.HeaderText = "Type";
            this.TransactionTypeColumn.Name = "TransactionTypeColumn";
            this.TransactionTypeColumn.ReadOnly = true;
            this.TransactionTypeColumn.Width = 60;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "GetAmount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 78;
            // 
            // TransactionCodeColumn
            // 
            this.TransactionCodeColumn.DataPropertyName = "TransactionCode";
            this.TransactionCodeColumn.HeaderText = "Trx. Code";
            this.TransactionCodeColumn.Name = "TransactionCodeColumn";
            this.TransactionCodeColumn.ReadOnly = true;
            this.TransactionCodeColumn.Width = 88;
            // 
            // CheckNumberColumn
            // 
            this.CheckNumberColumn.DataPropertyName = "CheckNumber";
            this.CheckNumberColumn.HeaderText = "Check #";
            this.CheckNumberColumn.Name = "CheckNumberColumn";
            this.CheckNumberColumn.ReadOnly = true;
            this.CheckNumberColumn.Width = 79;
            // 
            // IndividualColumn
            // 
            this.IndividualColumn.DataPropertyName = "Individual";
            this.IndividualColumn.HeaderText = "Individual";
            this.IndividualColumn.Name = "IndividualColumn";
            this.IndividualColumn.ReadOnly = true;
            this.IndividualColumn.Width = 88;
            // 
            // CreatedColumn
            // 
            this.CreatedColumn.DataPropertyName = "Created";
            this.CreatedColumn.HeaderText = "Added on";
            this.CreatedColumn.Name = "CreatedColumn";
            this.CreatedColumn.ReadOnly = true;
            this.CreatedColumn.Width = 91;
            // 
            // CreatorColumn
            // 
            this.CreatorColumn.DataPropertyName = "Creator";
            this.CreatorColumn.HeaderText = "Added by";
            this.CreatorColumn.Name = "CreatorColumn";
            this.CreatorColumn.ReadOnly = true;
            this.CreatorColumn.Width = 90;
            // 
            // BankAccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 539);
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
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BankAccountsForm";
            this.Text = "Bank Accounts";
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