namespace WinFormsUI.Forms
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SearchCustomerText = new System.Windows.Forms.TextBox();
            this.DeleteCustomerButton = new System.Windows.Forms.Button();
            this.ViewEditCustomerButton = new System.Windows.Forms.Button();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.DeleteEntryButton = new System.Windows.Forms.Button();
            this.HistoryLabel = new System.Windows.Forms.Label();
            this.CustomersDataGrid = new System.Windows.Forms.DataGridView();
            this.CustomerIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentDueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifiedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifierColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerHistoryDataGrid = new System.Windows.Forms.DataGridView();
            this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfitColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordCreatedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordCreatorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchIcon = new System.Windows.Forms.PictureBox();
            this.PrintButton = new System.Windows.Forms.Button();
            this.ViewRecordButton = new System.Windows.Forms.Button();
            this.ReloadCustomers = new System.Windows.Forms.Button();
            this.ButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.PrintCustomerNameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerHistoryDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            resources.ApplyResources(this.TitleLabel, "TitleLabel");
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // SearchCustomerText
            // 
            this.SearchCustomerText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.SearchCustomerText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SearchCustomerText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.SearchCustomerText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.SearchCustomerText, "SearchCustomerText");
            this.SearchCustomerText.Name = "SearchCustomerText";
            this.SearchCustomerText.TextChanged += new System.EventHandler(this.SearchCustomerText_TextChanged);
            // 
            // DeleteCustomerButton
            // 
            this.DeleteCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.DeleteCustomerButton.FlatAppearance.BorderSize = 0;
            this.DeleteCustomerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.DeleteCustomerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(135)))));
            resources.ApplyResources(this.DeleteCustomerButton, "DeleteCustomerButton");
            this.DeleteCustomerButton.ForeColor = System.Drawing.Color.White;
            this.DeleteCustomerButton.Name = "DeleteCustomerButton";
            this.DeleteCustomerButton.UseVisualStyleBackColor = false;
            this.DeleteCustomerButton.Click += new System.EventHandler(this.DeleteCustomerButton_Click);
            // 
            // ViewEditCustomerButton
            // 
            this.ViewEditCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.ViewEditCustomerButton.FlatAppearance.BorderSize = 0;
            this.ViewEditCustomerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.ViewEditCustomerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            resources.ApplyResources(this.ViewEditCustomerButton, "ViewEditCustomerButton");
            this.ViewEditCustomerButton.ForeColor = System.Drawing.Color.White;
            this.ViewEditCustomerButton.Name = "ViewEditCustomerButton";
            this.ViewEditCustomerButton.UseVisualStyleBackColor = false;
            this.ViewEditCustomerButton.Click += new System.EventHandler(this.ViewEditCustomerButton_Click);
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.AddCustomerButton.FlatAppearance.BorderSize = 0;
            this.AddCustomerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(170)))));
            this.AddCustomerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.AddCustomerButton, "AddCustomerButton");
            this.AddCustomerButton.ForeColor = System.Drawing.Color.White;
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.UseVisualStyleBackColor = false;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // DeleteEntryButton
            // 
            this.DeleteEntryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.DeleteEntryButton.FlatAppearance.BorderSize = 0;
            this.DeleteEntryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.DeleteEntryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(135)))));
            resources.ApplyResources(this.DeleteEntryButton, "DeleteEntryButton");
            this.DeleteEntryButton.ForeColor = System.Drawing.Color.White;
            this.DeleteEntryButton.Name = "DeleteEntryButton";
            this.DeleteEntryButton.UseVisualStyleBackColor = false;
            this.DeleteEntryButton.Click += new System.EventHandler(this.DeleteEntryButton_Click);
            // 
            // HistoryLabel
            // 
            resources.ApplyResources(this.HistoryLabel, "HistoryLabel");
            this.HistoryLabel.Name = "HistoryLabel";
            this.HistoryLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // CustomersDataGrid
            // 
            this.CustomersDataGrid.AllowUserToAddRows = false;
            this.CustomersDataGrid.AllowUserToDeleteRows = false;
            this.CustomersDataGrid.AllowUserToOrderColumns = true;
            this.CustomersDataGrid.AllowUserToResizeRows = false;
            this.CustomersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.CustomersDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.CustomersDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomersDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.CustomersDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomersDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.CustomersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerIdColumn,
            this.FullNameColumn,
            this.CurrentDueColumn,
            this.CompanyNameColumn,
            this.CreatedColumn,
            this.CreatorColumn,
            this.ModifiedColumn,
            this.ModifierColumn});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomersDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.CustomersDataGrid.GridColor = System.Drawing.Color.White;
            resources.ApplyResources(this.CustomersDataGrid, "CustomersDataGrid");
            this.CustomersDataGrid.Name = "CustomersDataGrid";
            this.CustomersDataGrid.ReadOnly = true;
            this.CustomersDataGrid.RowHeadersVisible = false;
            this.CustomersDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomersDataGrid.SelectionChanged += new System.EventHandler(this.CustomersDataGrid_SelectionChanged);
            // 
            // CustomerIdColumn
            // 
            this.CustomerIdColumn.DataPropertyName = "CustomerId";
            resources.ApplyResources(this.CustomerIdColumn, "CustomerIdColumn");
            this.CustomerIdColumn.Name = "CustomerIdColumn";
            this.CustomerIdColumn.ReadOnly = true;
            // 
            // FullNameColumn
            // 
            this.FullNameColumn.DataPropertyName = "FullName";
            resources.ApplyResources(this.FullNameColumn, "FullNameColumn");
            this.FullNameColumn.Name = "FullNameColumn";
            this.FullNameColumn.ReadOnly = true;
            // 
            // CurrentDueColumn
            // 
            this.CurrentDueColumn.DataPropertyName = "GetDebt";
            resources.ApplyResources(this.CurrentDueColumn, "CurrentDueColumn");
            this.CurrentDueColumn.Name = "CurrentDueColumn";
            this.CurrentDueColumn.ReadOnly = true;
            // 
            // CompanyNameColumn
            // 
            this.CompanyNameColumn.DataPropertyName = "CompanyName";
            resources.ApplyResources(this.CompanyNameColumn, "CompanyNameColumn");
            this.CompanyNameColumn.Name = "CompanyNameColumn";
            this.CompanyNameColumn.ReadOnly = true;
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
            // ModifiedColumn
            // 
            this.ModifiedColumn.DataPropertyName = "Modified";
            resources.ApplyResources(this.ModifiedColumn, "ModifiedColumn");
            this.ModifiedColumn.Name = "ModifiedColumn";
            this.ModifiedColumn.ReadOnly = true;
            // 
            // ModifierColumn
            // 
            this.ModifierColumn.DataPropertyName = "Modifier";
            resources.ApplyResources(this.ModifierColumn, "ModifierColumn");
            this.ModifierColumn.Name = "ModifierColumn";
            this.ModifierColumn.ReadOnly = true;
            // 
            // CustomerHistoryDataGrid
            // 
            this.CustomerHistoryDataGrid.AllowUserToAddRows = false;
            this.CustomerHistoryDataGrid.AllowUserToDeleteRows = false;
            this.CustomerHistoryDataGrid.AllowUserToOrderColumns = true;
            this.CustomerHistoryDataGrid.AllowUserToResizeRows = false;
            this.CustomerHistoryDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.CustomerHistoryDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.CustomerHistoryDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerHistoryDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.CustomerHistoryDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerHistoryDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.CustomerHistoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerHistoryDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeColumn,
            this.IdColumn2,
            this.AmountColumn,
            this.DueColumn2,
            this.ProfitColumn,
            this.RecordCreatedColumn,
            this.RecordCreatorColumn});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerHistoryDataGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.CustomerHistoryDataGrid.GridColor = System.Drawing.Color.White;
            resources.ApplyResources(this.CustomerHistoryDataGrid, "CustomerHistoryDataGrid");
            this.CustomerHistoryDataGrid.Name = "CustomerHistoryDataGrid";
            this.CustomerHistoryDataGrid.ReadOnly = true;
            this.CustomerHistoryDataGrid.RowHeadersVisible = false;
            this.CustomerHistoryDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // TypeColumn
            // 
            this.TypeColumn.DataPropertyName = "Type";
            resources.ApplyResources(this.TypeColumn, "TypeColumn");
            this.TypeColumn.Name = "TypeColumn";
            this.TypeColumn.ReadOnly = true;
            // 
            // IdColumn2
            // 
            this.IdColumn2.DataPropertyName = "Id";
            resources.ApplyResources(this.IdColumn2, "IdColumn2");
            this.IdColumn2.Name = "IdColumn2";
            this.IdColumn2.ReadOnly = true;
            // 
            // AmountColumn
            // 
            this.AmountColumn.DataPropertyName = "Amount";
            resources.ApplyResources(this.AmountColumn, "AmountColumn");
            this.AmountColumn.Name = "AmountColumn";
            this.AmountColumn.ReadOnly = true;
            // 
            // DueColumn2
            // 
            this.DueColumn2.DataPropertyName = "Due";
            resources.ApplyResources(this.DueColumn2, "DueColumn2");
            this.DueColumn2.Name = "DueColumn2";
            this.DueColumn2.ReadOnly = true;
            // 
            // ProfitColumn
            // 
            this.ProfitColumn.DataPropertyName = "Profit";
            resources.ApplyResources(this.ProfitColumn, "ProfitColumn");
            this.ProfitColumn.Name = "ProfitColumn";
            this.ProfitColumn.ReadOnly = true;
            // 
            // RecordCreatedColumn
            // 
            this.RecordCreatedColumn.DataPropertyName = "Created";
            resources.ApplyResources(this.RecordCreatedColumn, "RecordCreatedColumn");
            this.RecordCreatedColumn.Name = "RecordCreatedColumn";
            this.RecordCreatedColumn.ReadOnly = true;
            // 
            // RecordCreatorColumn
            // 
            this.RecordCreatorColumn.DataPropertyName = "Creator";
            resources.ApplyResources(this.RecordCreatorColumn, "RecordCreatorColumn");
            this.RecordCreatorColumn.Name = "RecordCreatorColumn";
            this.RecordCreatorColumn.ReadOnly = true;
            // 
            // SearchIcon
            // 
            this.SearchIcon.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Search_96px;
            resources.ApplyResources(this.SearchIcon, "SearchIcon");
            this.SearchIcon.Name = "SearchIcon";
            this.SearchIcon.TabStop = false;
            // 
            // PrintButton
            // 
            this.PrintButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(149)))), ((int)(((byte)(199)))));
            this.PrintButton.FlatAppearance.BorderSize = 0;
            this.PrintButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.PrintButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(184)))), ((int)(((byte)(217)))));
            resources.ApplyResources(this.PrintButton, "PrintButton");
            this.PrintButton.ForeColor = System.Drawing.Color.White;
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.UseVisualStyleBackColor = false;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // ViewRecordButton
            // 
            this.ViewRecordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.ViewRecordButton.FlatAppearance.BorderSize = 0;
            this.ViewRecordButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.ViewRecordButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            resources.ApplyResources(this.ViewRecordButton, "ViewRecordButton");
            this.ViewRecordButton.ForeColor = System.Drawing.Color.White;
            this.ViewRecordButton.Name = "ViewRecordButton";
            this.ViewRecordButton.UseVisualStyleBackColor = false;
            this.ViewRecordButton.Click += new System.EventHandler(this.ViewRecordButton_Click);
            // 
            // ReloadCustomers
            // 
            this.ReloadCustomers.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Sync_500px;
            resources.ApplyResources(this.ReloadCustomers, "ReloadCustomers");
            this.ReloadCustomers.FlatAppearance.BorderSize = 0;
            this.ReloadCustomers.Name = "ReloadCustomers";
            this.ButtonToolTip.SetToolTip(this.ReloadCustomers, resources.GetString("ReloadCustomers.ToolTip"));
            this.ReloadCustomers.UseVisualStyleBackColor = true;
            this.ReloadCustomers.Click += new System.EventHandler(this.RefreshCustomersButton_Click);
            // 
            // PrintCustomerNameButton
            // 
            this.PrintCustomerNameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.PrintCustomerNameButton.FlatAppearance.BorderSize = 0;
            this.PrintCustomerNameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.PrintCustomerNameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            resources.ApplyResources(this.PrintCustomerNameButton, "PrintCustomerNameButton");
            this.PrintCustomerNameButton.ForeColor = System.Drawing.Color.White;
            this.PrintCustomerNameButton.Name = "PrintCustomerNameButton";
            this.PrintCustomerNameButton.UseVisualStyleBackColor = false;
            this.PrintCustomerNameButton.Click += new System.EventHandler(this.PrintCustomerNameButton_Click);
            // 
            // CustomerForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PrintCustomerNameButton);
            this.Controls.Add(this.ReloadCustomers);
            this.Controls.Add(this.ViewRecordButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.CustomerHistoryDataGrid);
            this.Controls.Add(this.CustomersDataGrid);
            this.Controls.Add(this.SearchIcon);
            this.Controls.Add(this.HistoryLabel);
            this.Controls.Add(this.DeleteEntryButton);
            this.Controls.Add(this.AddCustomerButton);
            this.Controls.Add(this.DeleteCustomerButton);
            this.Controls.Add(this.ViewEditCustomerButton);
            this.Controls.Add(this.SearchCustomerText);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerHistoryDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox SearchCustomerText;
        private System.Windows.Forms.Button DeleteCustomerButton;
        private System.Windows.Forms.Button ViewEditCustomerButton;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.Button DeleteEntryButton;
        private System.Windows.Forms.Label HistoryLabel;
        private System.Windows.Forms.PictureBox SearchIcon;
        private System.Windows.Forms.DataGridView CustomersDataGrid;
        private System.Windows.Forms.DataGridView CustomerHistoryDataGrid;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button ViewRecordButton;
        private System.Windows.Forms.Button ReloadCustomers;
        private System.Windows.Forms.ToolTip ButtonToolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentDueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifiedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifierColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfitColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordCreatedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordCreatorColumn;
        private System.Windows.Forms.Button PrintCustomerNameButton;
    }
}