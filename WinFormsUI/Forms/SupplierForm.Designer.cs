namespace WinFormsUI.Forms {
    partial class SupplierForm {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierForm));
            this.SupplierHistoryDataGrid = new System.Windows.Forms.DataGridView();
            this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordCreatedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordCreatorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuppliersDataGrid = new System.Windows.Forms.DataGridView();
            this.SupplierIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifiedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifierColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HistoryLabel = new System.Windows.Forms.Label();
            this.DeleteRecordsButton = new System.Windows.Forms.Button();
            this.AddSupplierButton = new System.Windows.Forms.Button();
            this.DeleteSupplierButton = new System.Windows.Forms.Button();
            this.ViewEditSupplierButton = new System.Windows.Forms.Button();
            this.SearchSupplierText = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.PrintButton = new System.Windows.Forms.Button();
            this.ViewRecordButton = new System.Windows.Forms.Button();
            this.RefreshSuppliersButton = new System.Windows.Forms.Button();
            this.SearchIcon = new System.Windows.Forms.PictureBox();
            this.ButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SupplierHistoryDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuppliersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // SupplierHistoryDataGrid
            // 
            this.SupplierHistoryDataGrid.AllowUserToAddRows = false;
            this.SupplierHistoryDataGrid.AllowUserToDeleteRows = false;
            this.SupplierHistoryDataGrid.AllowUserToOrderColumns = true;
            this.SupplierHistoryDataGrid.AllowUserToResizeRows = false;
            this.SupplierHistoryDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.SupplierHistoryDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.SupplierHistoryDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SupplierHistoryDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.SupplierHistoryDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SupplierHistoryDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SupplierHistoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupplierHistoryDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeColumn,
            this.RecordIdColumn,
            this.RecordAmountColumn,
            this.DueColumn,
            this.RecordCreatedColumn,
            this.RecordCreatorColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SupplierHistoryDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.SupplierHistoryDataGrid.GridColor = System.Drawing.Color.White;
            this.SupplierHistoryDataGrid.Location = new System.Drawing.Point(688, 93);
            this.SupplierHistoryDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.SupplierHistoryDataGrid.Name = "SupplierHistoryDataGrid";
            this.SupplierHistoryDataGrid.ReadOnly = true;
            this.SupplierHistoryDataGrid.RowHeadersVisible = false;
            this.SupplierHistoryDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SupplierHistoryDataGrid.Size = new System.Drawing.Size(449, 504);
            this.SupplierHistoryDataGrid.TabIndex = 9;
            // 
            // TypeColumn
            // 
            this.TypeColumn.DataPropertyName = "Type";
            this.TypeColumn.HeaderText = "Type";
            this.TypeColumn.Name = "TypeColumn";
            this.TypeColumn.ReadOnly = true;
            this.TypeColumn.Width = 67;
            // 
            // RecordIdColumn
            // 
            this.RecordIdColumn.DataPropertyName = "Id";
            this.RecordIdColumn.HeaderText = "Id";
            this.RecordIdColumn.Name = "RecordIdColumn";
            this.RecordIdColumn.ReadOnly = true;
            this.RecordIdColumn.Width = 48;
            // 
            // RecordAmountColumn
            // 
            this.RecordAmountColumn.DataPropertyName = "Amount";
            this.RecordAmountColumn.HeaderText = "Amount";
            this.RecordAmountColumn.Name = "RecordAmountColumn";
            this.RecordAmountColumn.ReadOnly = true;
            this.RecordAmountColumn.Width = 91;
            // 
            // DueColumn
            // 
            this.DueColumn.DataPropertyName = "Due";
            this.DueColumn.HeaderText = "Due";
            this.DueColumn.Name = "DueColumn";
            this.DueColumn.ReadOnly = true;
            this.DueColumn.Width = 63;
            // 
            // RecordCreatedColumn
            // 
            this.RecordCreatedColumn.DataPropertyName = "Created";
            this.RecordCreatedColumn.HeaderText = "Added on";
            this.RecordCreatedColumn.Name = "RecordCreatedColumn";
            this.RecordCreatedColumn.ReadOnly = true;
            this.RecordCreatedColumn.Width = 102;
            // 
            // RecordCreatorColumn
            // 
            this.RecordCreatorColumn.DataPropertyName = "Creator";
            this.RecordCreatorColumn.HeaderText = "Added by";
            this.RecordCreatorColumn.Name = "RecordCreatorColumn";
            this.RecordCreatorColumn.ReadOnly = true;
            this.RecordCreatorColumn.Width = 101;
            // 
            // SuppliersDataGrid
            // 
            this.SuppliersDataGrid.AllowUserToAddRows = false;
            this.SuppliersDataGrid.AllowUserToDeleteRows = false;
            this.SuppliersDataGrid.AllowUserToOrderColumns = true;
            this.SuppliersDataGrid.AllowUserToResizeRows = false;
            this.SuppliersDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.SuppliersDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.SuppliersDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SuppliersDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.SuppliersDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SuppliersDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.SuppliersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SuppliersDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierIdColumn,
            this.FullNameColumn,
            this.PayableColumn,
            this.CompanyNameColumn,
            this.CreatedColumn,
            this.CreatorColumn,
            this.ModifiedColumn,
            this.ModifierColumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SuppliersDataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.SuppliersDataGrid.GridColor = System.Drawing.Color.White;
            this.SuppliersDataGrid.Location = new System.Drawing.Point(12, 93);
            this.SuppliersDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.SuppliersDataGrid.Name = "SuppliersDataGrid";
            this.SuppliersDataGrid.ReadOnly = true;
            this.SuppliersDataGrid.RowHeadersVisible = false;
            this.SuppliersDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SuppliersDataGrid.Size = new System.Drawing.Size(668, 456);
            this.SuppliersDataGrid.TabIndex = 2;
            this.SuppliersDataGrid.SelectionChanged += new System.EventHandler(this.SuppliersDataGrid_SelectionChanged);
            // 
            // SupplierIdColumn
            // 
            this.SupplierIdColumn.DataPropertyName = "SupplierId";
            this.SupplierIdColumn.HeaderText = "Id";
            this.SupplierIdColumn.Name = "SupplierIdColumn";
            this.SupplierIdColumn.ReadOnly = true;
            this.SupplierIdColumn.Width = 48;
            // 
            // FullNameColumn
            // 
            this.FullNameColumn.DataPropertyName = "FullName";
            this.FullNameColumn.HeaderText = "Name";
            this.FullNameColumn.Name = "FullNameColumn";
            this.FullNameColumn.ReadOnly = true;
            this.FullNameColumn.Width = 77;
            // 
            // PayableColumn
            // 
            this.PayableColumn.DataPropertyName = "GetPayable";
            this.PayableColumn.HeaderText = "Payable";
            this.PayableColumn.Name = "PayableColumn";
            this.PayableColumn.ReadOnly = true;
            this.PayableColumn.Width = 88;
            // 
            // CompanyNameColumn
            // 
            this.CompanyNameColumn.DataPropertyName = "CompanyName";
            this.CompanyNameColumn.HeaderText = "Company";
            this.CompanyNameColumn.Name = "CompanyNameColumn";
            this.CompanyNameColumn.ReadOnly = true;
            this.CompanyNameColumn.Width = 102;
            // 
            // CreatedColumn
            // 
            this.CreatedColumn.DataPropertyName = "Created";
            this.CreatedColumn.HeaderText = "Added on";
            this.CreatedColumn.Name = "CreatedColumn";
            this.CreatedColumn.ReadOnly = true;
            this.CreatedColumn.Width = 102;
            // 
            // CreatorColumn
            // 
            this.CreatorColumn.DataPropertyName = "Creator";
            this.CreatorColumn.HeaderText = "Added by";
            this.CreatorColumn.Name = "CreatorColumn";
            this.CreatorColumn.ReadOnly = true;
            this.CreatorColumn.Width = 101;
            // 
            // ModifiedColumn
            // 
            this.ModifiedColumn.DataPropertyName = "Modified";
            this.ModifiedColumn.HeaderText = "Last modified";
            this.ModifiedColumn.Name = "ModifiedColumn";
            this.ModifiedColumn.ReadOnly = true;
            this.ModifiedColumn.Width = 129;
            // 
            // ModifierColumn
            // 
            this.ModifierColumn.DataPropertyName = "Modifier";
            this.ModifierColumn.HeaderText = "Modified by";
            this.ModifierColumn.Name = "ModifierColumn";
            this.ModifierColumn.ReadOnly = true;
            this.ModifierColumn.Width = 118;
            // 
            // HistoryLabel
            // 
            this.HistoryLabel.AutoSize = true;
            this.HistoryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryLabel.Location = new System.Drawing.Point(684, 68);
            this.HistoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HistoryLabel.Name = "HistoryLabel";
            this.HistoryLabel.Size = new System.Drawing.Size(60, 21);
            this.HistoryLabel.TabIndex = 8;
            this.HistoryLabel.Text = "History";
            this.HistoryLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // DeleteRecordsButton
            // 
            this.DeleteRecordsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.DeleteRecordsButton.FlatAppearance.BorderSize = 0;
            this.DeleteRecordsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.DeleteRecordsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(135)))));
            this.DeleteRecordsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteRecordsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRecordsButton.ForeColor = System.Drawing.Color.White;
            this.DeleteRecordsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteRecordsButton.Location = new System.Drawing.Point(688, 603);
            this.DeleteRecordsButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.DeleteRecordsButton.Name = "DeleteRecordsButton";
            this.DeleteRecordsButton.Size = new System.Drawing.Size(241, 42);
            this.DeleteRecordsButton.TabIndex = 11;
            this.DeleteRecordsButton.Text = "Delete Selected Record(s)";
            this.DeleteRecordsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteRecordsButton.UseVisualStyleBackColor = false;
            this.DeleteRecordsButton.Click += new System.EventHandler(this.DeleteEntryButton_Click);
            // 
            // AddSupplierButton
            // 
            this.AddSupplierButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.AddSupplierButton.FlatAppearance.BorderSize = 0;
            this.AddSupplierButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(170)))));
            this.AddSupplierButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.AddSupplierButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSupplierButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSupplierButton.ForeColor = System.Drawing.Color.White;
            this.AddSupplierButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddSupplierButton.Location = new System.Drawing.Point(355, 600);
            this.AddSupplierButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.AddSupplierButton.Name = "AddSupplierButton";
            this.AddSupplierButton.Size = new System.Drawing.Size(325, 42);
            this.AddSupplierButton.TabIndex = 4;
            this.AddSupplierButton.Text = "+ Add Supplier";
            this.AddSupplierButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddSupplierButton.UseVisualStyleBackColor = false;
            this.AddSupplierButton.Click += new System.EventHandler(this.AddSupplierButton_Click);
            // 
            // DeleteSupplierButton
            // 
            this.DeleteSupplierButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.DeleteSupplierButton.FlatAppearance.BorderSize = 0;
            this.DeleteSupplierButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.DeleteSupplierButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(135)))));
            this.DeleteSupplierButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSupplierButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSupplierButton.ForeColor = System.Drawing.Color.White;
            this.DeleteSupplierButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteSupplierButton.Location = new System.Drawing.Point(12, 554);
            this.DeleteSupplierButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.DeleteSupplierButton.Name = "DeleteSupplierButton";
            this.DeleteSupplierButton.Size = new System.Drawing.Size(336, 42);
            this.DeleteSupplierButton.TabIndex = 5;
            this.DeleteSupplierButton.Text = "Delete Supplier(s)";
            this.DeleteSupplierButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteSupplierButton.UseVisualStyleBackColor = false;
            this.DeleteSupplierButton.Click += new System.EventHandler(this.DeleteSupplierButton_Click);
            // 
            // ViewEditSupplierButton
            // 
            this.ViewEditSupplierButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.ViewEditSupplierButton.FlatAppearance.BorderSize = 0;
            this.ViewEditSupplierButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.ViewEditSupplierButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            this.ViewEditSupplierButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewEditSupplierButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewEditSupplierButton.ForeColor = System.Drawing.Color.White;
            this.ViewEditSupplierButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewEditSupplierButton.Location = new System.Drawing.Point(356, 555);
            this.ViewEditSupplierButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ViewEditSupplierButton.Name = "ViewEditSupplierButton";
            this.ViewEditSupplierButton.Size = new System.Drawing.Size(324, 42);
            this.ViewEditSupplierButton.TabIndex = 3;
            this.ViewEditSupplierButton.Text = "View / Edit Supplier";
            this.ViewEditSupplierButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ViewEditSupplierButton.UseVisualStyleBackColor = false;
            this.ViewEditSupplierButton.Click += new System.EventHandler(this.ViewEditSupplierButton_Click);
            // 
            // SearchSupplierText
            // 
            this.SearchSupplierText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.SearchSupplierText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SearchSupplierText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.SearchSupplierText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchSupplierText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchSupplierText.Location = new System.Drawing.Point(12, 63);
            this.SearchSupplierText.Margin = new System.Windows.Forms.Padding(4);
            this.SearchSupplierText.Name = "SearchSupplierText";
            this.SearchSupplierText.Size = new System.Drawing.Size(375, 22);
            this.SearchSupplierText.TabIndex = 1;
            this.SearchSupplierText.TextChanged += new System.EventHandler(this.SearchSupplierText_TextChanged);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semi Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(4, 3);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(157, 47);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Suppliers";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
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
            this.PrintButton.Location = new System.Drawing.Point(12, 601);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(336, 42);
            this.PrintButton.TabIndex = 6;
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
            this.ViewRecordButton.Location = new System.Drawing.Point(937, 603);
            this.ViewRecordButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ViewRecordButton.Name = "ViewRecordButton";
            this.ViewRecordButton.Size = new System.Drawing.Size(200, 42);
            this.ViewRecordButton.TabIndex = 10;
            this.ViewRecordButton.Text = "View Record";
            this.ViewRecordButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ViewRecordButton.UseVisualStyleBackColor = false;
            this.ViewRecordButton.Click += new System.EventHandler(this.ViewRecordButton_Click);
            // 
            // RefreshSuppliersButton
            // 
            this.RefreshSuppliersButton.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Sync_500px;
            this.RefreshSuppliersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshSuppliersButton.FlatAppearance.BorderSize = 0;
            this.RefreshSuppliersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshSuppliersButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshSuppliersButton.Location = new System.Drawing.Point(1118, 2);
            this.RefreshSuppliersButton.Name = "RefreshSuppliersButton";
            this.RefreshSuppliersButton.Size = new System.Drawing.Size(29, 29);
            this.RefreshSuppliersButton.TabIndex = 7;
            this.ButtonToolTip.SetToolTip(this.RefreshSuppliersButton, "Force refresh suppliers from database");
            this.RefreshSuppliersButton.UseVisualStyleBackColor = true;
            this.RefreshSuppliersButton.Click += new System.EventHandler(this.RefreshSuppliersButton_Click);
            // 
            // SearchIcon
            // 
            this.SearchIcon.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Search_96px;
            this.SearchIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchIcon.ErrorImage = null;
            this.SearchIcon.InitialImage = null;
            this.SearchIcon.Location = new System.Drawing.Point(387, 61);
            this.SearchIcon.Margin = new System.Windows.Forms.Padding(4);
            this.SearchIcon.Name = "SearchIcon";
            this.SearchIcon.Size = new System.Drawing.Size(25, 25);
            this.SearchIcon.TabIndex = 100;
            this.SearchIcon.TabStop = false;
            this.SearchIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 654);
            this.Controls.Add(this.RefreshSuppliersButton);
            this.Controls.Add(this.ViewRecordButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.SupplierHistoryDataGrid);
            this.Controls.Add(this.SuppliersDataGrid);
            this.Controls.Add(this.SearchIcon);
            this.Controls.Add(this.HistoryLabel);
            this.Controls.Add(this.DeleteRecordsButton);
            this.Controls.Add(this.AddSupplierButton);
            this.Controls.Add(this.DeleteSupplierButton);
            this.Controls.Add(this.ViewEditSupplierButton);
            this.Controls.Add(this.SearchSupplierText);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SupplierForm";
            this.Text = "Suppliers";
            this.Load += new System.EventHandler(this.SupplierForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            ((System.ComponentModel.ISupportInitialize)(this.SupplierHistoryDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuppliersDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SupplierHistoryDataGrid;
        private System.Windows.Forms.DataGridView SuppliersDataGrid;
        private System.Windows.Forms.PictureBox SearchIcon;
        private System.Windows.Forms.Label HistoryLabel;
        private System.Windows.Forms.Button DeleteRecordsButton;
        private System.Windows.Forms.Button AddSupplierButton;
        private System.Windows.Forms.Button DeleteSupplierButton;
        private System.Windows.Forms.Button ViewEditSupplierButton;
        private System.Windows.Forms.TextBox SearchSupplierText;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button ViewRecordButton;
        private System.Windows.Forms.Button RefreshSuppliersButton;
        private System.Windows.Forms.ToolTip ButtonToolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordAmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordCreatedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordCreatorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifiedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifierColumn;
    }
}