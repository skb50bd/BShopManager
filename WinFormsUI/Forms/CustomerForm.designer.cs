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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
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
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerHistoryDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semi Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(3, 5);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(179, 47);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Customers";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // SearchCustomerText
            // 
            this.SearchCustomerText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.SearchCustomerText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SearchCustomerText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.SearchCustomerText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchCustomerText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCustomerText.Location = new System.Drawing.Point(11, 56);
            this.SearchCustomerText.Margin = new System.Windows.Forms.Padding(4);
            this.SearchCustomerText.Name = "SearchCustomerText";
            this.SearchCustomerText.Size = new System.Drawing.Size(375, 22);
            this.SearchCustomerText.TabIndex = 1;
            this.SearchCustomerText.TextChanged += new System.EventHandler(this.SearchCustomerText_TextChanged);
            // 
            // DeleteCustomerButton
            // 
            this.DeleteCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.DeleteCustomerButton.FlatAppearance.BorderSize = 0;
            this.DeleteCustomerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.DeleteCustomerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(135)))));
            this.DeleteCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteCustomerButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteCustomerButton.ForeColor = System.Drawing.Color.White;
            this.DeleteCustomerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteCustomerButton.Location = new System.Drawing.Point(11, 578);
            this.DeleteCustomerButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.DeleteCustomerButton.Name = "DeleteCustomerButton";
            this.DeleteCustomerButton.Size = new System.Drawing.Size(336, 42);
            this.DeleteCustomerButton.TabIndex = 6;
            this.DeleteCustomerButton.Text = "Delete Customer(s)";
            this.DeleteCustomerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteCustomerButton.UseVisualStyleBackColor = false;
            this.DeleteCustomerButton.Click += new System.EventHandler(this.DeleteCustomerButton_Click);
            // 
            // ViewEditCustomerButton
            // 
            this.ViewEditCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.ViewEditCustomerButton.FlatAppearance.BorderSize = 0;
            this.ViewEditCustomerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.ViewEditCustomerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            this.ViewEditCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewEditCustomerButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewEditCustomerButton.ForeColor = System.Drawing.Color.White;
            this.ViewEditCustomerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewEditCustomerButton.Location = new System.Drawing.Point(354, 580);
            this.ViewEditCustomerButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ViewEditCustomerButton.Name = "ViewEditCustomerButton";
            this.ViewEditCustomerButton.Size = new System.Drawing.Size(347, 42);
            this.ViewEditCustomerButton.TabIndex = 3;
            this.ViewEditCustomerButton.Text = "View / Edit Customer";
            this.ViewEditCustomerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ViewEditCustomerButton.UseVisualStyleBackColor = false;
            this.ViewEditCustomerButton.Click += new System.EventHandler(this.ViewEditCustomerButton_Click);
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.AddCustomerButton.FlatAppearance.BorderSize = 0;
            this.AddCustomerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(170)))));
            this.AddCustomerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.AddCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCustomerButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustomerButton.ForeColor = System.Drawing.Color.White;
            this.AddCustomerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddCustomerButton.Location = new System.Drawing.Point(354, 626);
            this.AddCustomerButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(347, 42);
            this.AddCustomerButton.TabIndex = 4;
            this.AddCustomerButton.Text = "+ Add Customer";
            this.AddCustomerButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddCustomerButton.UseVisualStyleBackColor = false;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // DeleteEntryButton
            // 
            this.DeleteEntryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.DeleteEntryButton.FlatAppearance.BorderSize = 0;
            this.DeleteEntryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.DeleteEntryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(135)))));
            this.DeleteEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteEntryButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteEntryButton.ForeColor = System.Drawing.Color.White;
            this.DeleteEntryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteEntryButton.Location = new System.Drawing.Point(709, 626);
            this.DeleteEntryButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.DeleteEntryButton.Name = "DeleteEntryButton";
            this.DeleteEntryButton.Size = new System.Drawing.Size(244, 42);
            this.DeleteEntryButton.TabIndex = 11;
            this.DeleteEntryButton.Text = "Delete Selected Record(s)";
            this.DeleteEntryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteEntryButton.UseVisualStyleBackColor = false;
            this.DeleteEntryButton.Click += new System.EventHandler(this.DeleteEntryButton_Click);
            // 
            // HistoryLabel
            // 
            this.HistoryLabel.AutoSize = true;
            this.HistoryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryLabel.Location = new System.Drawing.Point(705, 61);
            this.HistoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HistoryLabel.Name = "HistoryLabel";
            this.HistoryLabel.Size = new System.Drawing.Size(60, 21);
            this.HistoryLabel.TabIndex = 8;
            this.HistoryLabel.Text = "History";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomersDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomersDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.CustomersDataGrid.GridColor = System.Drawing.Color.White;
            this.CustomersDataGrid.Location = new System.Drawing.Point(11, 86);
            this.CustomersDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.CustomersDataGrid.Name = "CustomersDataGrid";
            this.CustomersDataGrid.ReadOnly = true;
            this.CustomersDataGrid.RowHeadersVisible = false;
            this.CustomersDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomersDataGrid.Size = new System.Drawing.Size(690, 486);
            this.CustomersDataGrid.TabIndex = 2;
            this.CustomersDataGrid.SelectionChanged += new System.EventHandler(this.CustomersDataGrid_SelectionChanged);
            // 
            // CustomerIdColumn
            // 
            this.CustomerIdColumn.DataPropertyName = "CustomerId";
            this.CustomerIdColumn.HeaderText = "Id";
            this.CustomerIdColumn.Name = "CustomerIdColumn";
            this.CustomerIdColumn.ReadOnly = true;
            this.CustomerIdColumn.Width = 46;
            // 
            // FullNameColumn
            // 
            this.FullNameColumn.DataPropertyName = "FullName";
            this.FullNameColumn.HeaderText = "Name";
            this.FullNameColumn.Name = "FullNameColumn";
            this.FullNameColumn.ReadOnly = true;
            this.FullNameColumn.Width = 75;
            // 
            // CurrentDueColumn
            // 
            this.CurrentDueColumn.DataPropertyName = "GetDebt";
            this.CurrentDueColumn.HeaderText = "Due";
            this.CurrentDueColumn.Name = "CurrentDueColumn";
            this.CurrentDueColumn.ReadOnly = true;
            this.CurrentDueColumn.Width = 61;
            // 
            // CompanyNameColumn
            // 
            this.CompanyNameColumn.DataPropertyName = "CompanyName";
            this.CompanyNameColumn.HeaderText = "Company";
            this.CompanyNameColumn.Name = "CompanyNameColumn";
            this.CompanyNameColumn.ReadOnly = true;
            // 
            // CreatedColumn
            // 
            this.CreatedColumn.DataPropertyName = "Created";
            this.CreatedColumn.HeaderText = "Added on";
            this.CreatedColumn.Name = "CreatedColumn";
            this.CreatedColumn.ReadOnly = true;
            // 
            // CreatorColumn
            // 
            this.CreatorColumn.DataPropertyName = "Creator";
            this.CreatorColumn.HeaderText = "Added by";
            this.CreatorColumn.Name = "CreatorColumn";
            this.CreatorColumn.ReadOnly = true;
            this.CreatorColumn.Width = 99;
            // 
            // ModifiedColumn
            // 
            this.ModifiedColumn.DataPropertyName = "Modified";
            this.ModifiedColumn.HeaderText = "Last modified";
            this.ModifiedColumn.Name = "ModifiedColumn";
            this.ModifiedColumn.ReadOnly = true;
            this.ModifiedColumn.Width = 127;
            // 
            // ModifierColumn
            // 
            this.ModifierColumn.DataPropertyName = "Modifier";
            this.ModifierColumn.HeaderText = "Modified by";
            this.ModifierColumn.Name = "ModifierColumn";
            this.ModifierColumn.ReadOnly = true;
            this.ModifierColumn.Width = 116;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerHistoryDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CustomerHistoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerHistoryDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeColumn,
            this.IdColumn2,
            this.AmountColumn,
            this.DueColumn2,
            this.ProfitColumn,
            this.RecordCreatedColumn,
            this.RecordCreatorColumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerHistoryDataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.CustomerHistoryDataGrid.GridColor = System.Drawing.Color.White;
            this.CustomerHistoryDataGrid.Location = new System.Drawing.Point(709, 86);
            this.CustomerHistoryDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerHistoryDataGrid.Name = "CustomerHistoryDataGrid";
            this.CustomerHistoryDataGrid.ReadOnly = true;
            this.CustomerHistoryDataGrid.RowHeadersVisible = false;
            this.CustomerHistoryDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerHistoryDataGrid.Size = new System.Drawing.Size(490, 534);
            this.CustomerHistoryDataGrid.TabIndex = 9;
            // 
            // TypeColumn
            // 
            this.TypeColumn.DataPropertyName = "Type";
            this.TypeColumn.HeaderText = "Type";
            this.TypeColumn.Name = "TypeColumn";
            this.TypeColumn.ReadOnly = true;
            this.TypeColumn.Width = 65;
            // 
            // IdColumn2
            // 
            this.IdColumn2.DataPropertyName = "Id";
            this.IdColumn2.HeaderText = "Id";
            this.IdColumn2.Name = "IdColumn2";
            this.IdColumn2.ReadOnly = true;
            this.IdColumn2.Width = 46;
            // 
            // AmountColumn
            // 
            this.AmountColumn.DataPropertyName = "Amount";
            this.AmountColumn.HeaderText = "Amount";
            this.AmountColumn.Name = "AmountColumn";
            this.AmountColumn.ReadOnly = true;
            this.AmountColumn.Width = 89;
            // 
            // DueColumn2
            // 
            this.DueColumn2.DataPropertyName = "Due";
            this.DueColumn2.HeaderText = "Due";
            this.DueColumn2.Name = "DueColumn2";
            this.DueColumn2.ReadOnly = true;
            this.DueColumn2.Width = 61;
            // 
            // ProfitColumn
            // 
            this.ProfitColumn.DataPropertyName = "Profit";
            this.ProfitColumn.HeaderText = "Profit";
            this.ProfitColumn.Name = "ProfitColumn";
            this.ProfitColumn.ReadOnly = true;
            this.ProfitColumn.Width = 71;
            // 
            // RecordCreatedColumn
            // 
            this.RecordCreatedColumn.DataPropertyName = "Created";
            this.RecordCreatedColumn.HeaderText = "Added on";
            this.RecordCreatedColumn.Name = "RecordCreatedColumn";
            this.RecordCreatedColumn.ReadOnly = true;
            // 
            // RecordCreatorColumn
            // 
            this.RecordCreatorColumn.DataPropertyName = "Creator";
            this.RecordCreatorColumn.HeaderText = "Added by";
            this.RecordCreatorColumn.Name = "RecordCreatorColumn";
            this.RecordCreatorColumn.ReadOnly = true;
            this.RecordCreatorColumn.Width = 99;
            // 
            // SearchIcon
            // 
            this.SearchIcon.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Search_96px;
            this.SearchIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchIcon.ErrorImage = null;
            this.SearchIcon.InitialImage = null;
            this.SearchIcon.Location = new System.Drawing.Point(386, 54);
            this.SearchIcon.Margin = new System.Windows.Forms.Padding(4);
            this.SearchIcon.Name = "SearchIcon";
            this.SearchIcon.Size = new System.Drawing.Size(25, 25);
            this.SearchIcon.TabIndex = 88;
            this.SearchIcon.TabStop = false;
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
            this.PrintButton.Location = new System.Drawing.Point(11, 626);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(336, 42);
            this.PrintButton.TabIndex = 5;
            this.PrintButton.Text = "Print List";
            this.PrintButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PrintButton.UseVisualStyleBackColor = false;
            // 
            // ViewRecordButton
            // 
            this.ViewRecordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.ViewRecordButton.FlatAppearance.BorderSize = 0;
            this.ViewRecordButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.ViewRecordButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            this.ViewRecordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewRecordButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewRecordButton.ForeColor = System.Drawing.Color.White;
            this.ViewRecordButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewRecordButton.Location = new System.Drawing.Point(961, 626);
            this.ViewRecordButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ViewRecordButton.Name = "ViewRecordButton";
            this.ViewRecordButton.Size = new System.Drawing.Size(238, 42);
            this.ViewRecordButton.TabIndex = 10;
            this.ViewRecordButton.Text = "View Record";
            this.ViewRecordButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ViewRecordButton.UseVisualStyleBackColor = false;
            this.ViewRecordButton.Click += new System.EventHandler(this.ViewRecordButton_Click);
            // 
            // ReloadCustomers
            // 
            this.ReloadCustomers.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Sync_500px;
            this.ReloadCustomers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReloadCustomers.FlatAppearance.BorderSize = 0;
            this.ReloadCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReloadCustomers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReloadCustomers.Location = new System.Drawing.Point(1181, 3);
            this.ReloadCustomers.Name = "ReloadCustomers";
            this.ReloadCustomers.Size = new System.Drawing.Size(29, 29);
            this.ReloadCustomers.TabIndex = 7;
            this.ButtonToolTip.SetToolTip(this.ReloadCustomers, "Force refresh the customers from database");
            this.ReloadCustomers.UseVisualStyleBackColor = true;
            this.ReloadCustomers.Click += new System.EventHandler(this.RefreshCustomersButton_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1212, 679);
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
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustomerForm";
            this.Text = "Customers";
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
    }
}