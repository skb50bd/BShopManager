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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            resources.ApplyResources(this.SupplierHistoryDataGrid, "SupplierHistoryDataGrid");
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SupplierHistoryDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.SupplierHistoryDataGrid.GridColor = System.Drawing.Color.White;
            this.SupplierHistoryDataGrid.Name = "SupplierHistoryDataGrid";
            this.SupplierHistoryDataGrid.ReadOnly = true;
            this.SupplierHistoryDataGrid.RowHeadersVisible = false;
            this.SupplierHistoryDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ButtonToolTip.SetToolTip(this.SupplierHistoryDataGrid, resources.GetString("SupplierHistoryDataGrid.ToolTip"));
            // 
            // TypeColumn
            // 
            this.TypeColumn.DataPropertyName = "Type";
            resources.ApplyResources(this.TypeColumn, "TypeColumn");
            this.TypeColumn.Name = "TypeColumn";
            this.TypeColumn.ReadOnly = true;
            // 
            // RecordIdColumn
            // 
            this.RecordIdColumn.DataPropertyName = "Id";
            resources.ApplyResources(this.RecordIdColumn, "RecordIdColumn");
            this.RecordIdColumn.Name = "RecordIdColumn";
            this.RecordIdColumn.ReadOnly = true;
            // 
            // RecordAmountColumn
            // 
            this.RecordAmountColumn.DataPropertyName = "Amount";
            resources.ApplyResources(this.RecordAmountColumn, "RecordAmountColumn");
            this.RecordAmountColumn.Name = "RecordAmountColumn";
            this.RecordAmountColumn.ReadOnly = true;
            // 
            // DueColumn
            // 
            this.DueColumn.DataPropertyName = "Due";
            resources.ApplyResources(this.DueColumn, "DueColumn");
            this.DueColumn.Name = "DueColumn";
            this.DueColumn.ReadOnly = true;
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
            // SuppliersDataGrid
            // 
            resources.ApplyResources(this.SuppliersDataGrid, "SuppliersDataGrid");
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
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
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SuppliersDataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.SuppliersDataGrid.GridColor = System.Drawing.Color.White;
            this.SuppliersDataGrid.Name = "SuppliersDataGrid";
            this.SuppliersDataGrid.ReadOnly = true;
            this.SuppliersDataGrid.RowHeadersVisible = false;
            this.SuppliersDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ButtonToolTip.SetToolTip(this.SuppliersDataGrid, resources.GetString("SuppliersDataGrid.ToolTip"));
            this.SuppliersDataGrid.SelectionChanged += new System.EventHandler(this.SuppliersDataGrid_SelectionChanged);
            // 
            // SupplierIdColumn
            // 
            this.SupplierIdColumn.DataPropertyName = "SupplierId";
            resources.ApplyResources(this.SupplierIdColumn, "SupplierIdColumn");
            this.SupplierIdColumn.Name = "SupplierIdColumn";
            this.SupplierIdColumn.ReadOnly = true;
            // 
            // FullNameColumn
            // 
            this.FullNameColumn.DataPropertyName = "FullName";
            resources.ApplyResources(this.FullNameColumn, "FullNameColumn");
            this.FullNameColumn.Name = "FullNameColumn";
            this.FullNameColumn.ReadOnly = true;
            // 
            // PayableColumn
            // 
            this.PayableColumn.DataPropertyName = "GetPayable";
            resources.ApplyResources(this.PayableColumn, "PayableColumn");
            this.PayableColumn.Name = "PayableColumn";
            this.PayableColumn.ReadOnly = true;
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
            // HistoryLabel
            // 
            resources.ApplyResources(this.HistoryLabel, "HistoryLabel");
            this.HistoryLabel.Name = "HistoryLabel";
            this.ButtonToolTip.SetToolTip(this.HistoryLabel, resources.GetString("HistoryLabel.ToolTip"));
            this.HistoryLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // DeleteRecordsButton
            // 
            resources.ApplyResources(this.DeleteRecordsButton, "DeleteRecordsButton");
            this.DeleteRecordsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.DeleteRecordsButton.FlatAppearance.BorderSize = 0;
            this.DeleteRecordsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.DeleteRecordsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(135)))));
            this.DeleteRecordsButton.ForeColor = System.Drawing.Color.White;
            this.DeleteRecordsButton.Name = "DeleteRecordsButton";
            this.ButtonToolTip.SetToolTip(this.DeleteRecordsButton, resources.GetString("DeleteRecordsButton.ToolTip"));
            this.DeleteRecordsButton.UseVisualStyleBackColor = false;
            this.DeleteRecordsButton.Click += new System.EventHandler(this.DeleteEntryButton_Click);
            // 
            // AddSupplierButton
            // 
            resources.ApplyResources(this.AddSupplierButton, "AddSupplierButton");
            this.AddSupplierButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.AddSupplierButton.FlatAppearance.BorderSize = 0;
            this.AddSupplierButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(170)))));
            this.AddSupplierButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.AddSupplierButton.ForeColor = System.Drawing.Color.White;
            this.AddSupplierButton.Name = "AddSupplierButton";
            this.ButtonToolTip.SetToolTip(this.AddSupplierButton, resources.GetString("AddSupplierButton.ToolTip"));
            this.AddSupplierButton.UseVisualStyleBackColor = false;
            this.AddSupplierButton.Click += new System.EventHandler(this.AddSupplierButton_Click);
            // 
            // DeleteSupplierButton
            // 
            resources.ApplyResources(this.DeleteSupplierButton, "DeleteSupplierButton");
            this.DeleteSupplierButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.DeleteSupplierButton.FlatAppearance.BorderSize = 0;
            this.DeleteSupplierButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.DeleteSupplierButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(135)))));
            this.DeleteSupplierButton.ForeColor = System.Drawing.Color.White;
            this.DeleteSupplierButton.Name = "DeleteSupplierButton";
            this.ButtonToolTip.SetToolTip(this.DeleteSupplierButton, resources.GetString("DeleteSupplierButton.ToolTip"));
            this.DeleteSupplierButton.UseVisualStyleBackColor = false;
            this.DeleteSupplierButton.Click += new System.EventHandler(this.DeleteSupplierButton_Click);
            // 
            // ViewEditSupplierButton
            // 
            resources.ApplyResources(this.ViewEditSupplierButton, "ViewEditSupplierButton");
            this.ViewEditSupplierButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.ViewEditSupplierButton.FlatAppearance.BorderSize = 0;
            this.ViewEditSupplierButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.ViewEditSupplierButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            this.ViewEditSupplierButton.ForeColor = System.Drawing.Color.White;
            this.ViewEditSupplierButton.Name = "ViewEditSupplierButton";
            this.ButtonToolTip.SetToolTip(this.ViewEditSupplierButton, resources.GetString("ViewEditSupplierButton.ToolTip"));
            this.ViewEditSupplierButton.UseVisualStyleBackColor = false;
            this.ViewEditSupplierButton.Click += new System.EventHandler(this.ViewEditSupplierButton_Click);
            // 
            // SearchSupplierText
            // 
            resources.ApplyResources(this.SearchSupplierText, "SearchSupplierText");
            this.SearchSupplierText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.SearchSupplierText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SearchSupplierText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.SearchSupplierText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchSupplierText.Name = "SearchSupplierText";
            this.ButtonToolTip.SetToolTip(this.SearchSupplierText, resources.GetString("SearchSupplierText.ToolTip"));
            this.SearchSupplierText.TextChanged += new System.EventHandler(this.SearchSupplierText_TextChanged);
            // 
            // TitleLabel
            // 
            resources.ApplyResources(this.TitleLabel, "TitleLabel");
            this.TitleLabel.Name = "TitleLabel";
            this.ButtonToolTip.SetToolTip(this.TitleLabel, resources.GetString("TitleLabel.ToolTip"));
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
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
            // 
            // ViewRecordButton
            // 
            resources.ApplyResources(this.ViewRecordButton, "ViewRecordButton");
            this.ViewRecordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.ViewRecordButton.FlatAppearance.BorderSize = 0;
            this.ViewRecordButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.ViewRecordButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            this.ViewRecordButton.ForeColor = System.Drawing.Color.White;
            this.ViewRecordButton.Name = "ViewRecordButton";
            this.ButtonToolTip.SetToolTip(this.ViewRecordButton, resources.GetString("ViewRecordButton.ToolTip"));
            this.ViewRecordButton.UseVisualStyleBackColor = false;
            this.ViewRecordButton.Click += new System.EventHandler(this.ViewRecordButton_Click);
            // 
            // RefreshSuppliersButton
            // 
            resources.ApplyResources(this.RefreshSuppliersButton, "RefreshSuppliersButton");
            this.RefreshSuppliersButton.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Sync_500px;
            this.RefreshSuppliersButton.FlatAppearance.BorderSize = 0;
            this.RefreshSuppliersButton.Name = "RefreshSuppliersButton";
            this.ButtonToolTip.SetToolTip(this.RefreshSuppliersButton, resources.GetString("RefreshSuppliersButton.ToolTip"));
            this.RefreshSuppliersButton.UseVisualStyleBackColor = true;
            this.RefreshSuppliersButton.Click += new System.EventHandler(this.RefreshSuppliersButton_Click);
            // 
            // SearchIcon
            // 
            resources.ApplyResources(this.SearchIcon, "SearchIcon");
            this.SearchIcon.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Search_96px;
            this.SearchIcon.Name = "SearchIcon";
            this.SearchIcon.TabStop = false;
            this.ButtonToolTip.SetToolTip(this.SearchIcon, resources.GetString("SearchIcon.ToolTip"));
            this.SearchIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // SupplierForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SupplierForm";
            this.ButtonToolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
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