namespace WinFormsUI.Forms {
    partial class EmployeeForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EmployeeHistoryDataGrid = new System.Windows.Forms.DataGridView();
            this.IdColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HistoryCreatedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HistoryCreatorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeesDataGrid = new System.Windows.Forms.DataGridView();
            this.EmployeeIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesignationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BalanceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthlySalaryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoinDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifiedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HistoryLabel = new System.Windows.Forms.Label();
            this.DeleteEntryButton = new System.Windows.Forms.Button();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.DeleteEmployeeButton = new System.Windows.Forms.Button();
            this.ViewEditEmployeeButton = new System.Windows.Forms.Button();
            this.SearchEmployeeText = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SearchIcon = new System.Windows.Forms.PictureBox();
            this.ReloadEmployees = new System.Windows.Forms.Button();
            this.ButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeHistoryDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeHistoryDataGrid
            // 
            resources.ApplyResources(this.EmployeeHistoryDataGrid, "EmployeeHistoryDataGrid");
            this.EmployeeHistoryDataGrid.AllowUserToAddRows = false;
            this.EmployeeHistoryDataGrid.AllowUserToDeleteRows = false;
            this.EmployeeHistoryDataGrid.AllowUserToResizeRows = false;
            this.EmployeeHistoryDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.EmployeeHistoryDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.EmployeeHistoryDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeeHistoryDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.EmployeeHistoryDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeHistoryDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.EmployeeHistoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeHistoryDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn2,
            this.AmountColumn,
            this.HistoryCreatedColumn,
            this.HistoryCreatorColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeHistoryDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeeHistoryDataGrid.GridColor = System.Drawing.Color.WhiteSmoke;
            this.EmployeeHistoryDataGrid.Name = "EmployeeHistoryDataGrid";
            this.EmployeeHistoryDataGrid.RowHeadersVisible = false;
            this.EmployeeHistoryDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ButtonToolTip.SetToolTip(this.EmployeeHistoryDataGrid, resources.GetString("EmployeeHistoryDataGrid.ToolTip"));
            // 
            // IdColumn2
            // 
            this.IdColumn2.DataPropertyName = "PaymentId";
            resources.ApplyResources(this.IdColumn2, "IdColumn2");
            this.IdColumn2.Name = "IdColumn2";
            // 
            // AmountColumn
            // 
            this.AmountColumn.DataPropertyName = "Amount";
            resources.ApplyResources(this.AmountColumn, "AmountColumn");
            this.AmountColumn.Name = "AmountColumn";
            // 
            // HistoryCreatedColumn
            // 
            this.HistoryCreatedColumn.DataPropertyName = "Created";
            resources.ApplyResources(this.HistoryCreatedColumn, "HistoryCreatedColumn");
            this.HistoryCreatedColumn.Name = "HistoryCreatedColumn";
            // 
            // HistoryCreatorColumn
            // 
            this.HistoryCreatorColumn.DataPropertyName = "Creator";
            resources.ApplyResources(this.HistoryCreatorColumn, "HistoryCreatorColumn");
            this.HistoryCreatorColumn.Name = "HistoryCreatorColumn";
            // 
            // EmployeesDataGrid
            // 
            resources.ApplyResources(this.EmployeesDataGrid, "EmployeesDataGrid");
            this.EmployeesDataGrid.AllowUserToAddRows = false;
            this.EmployeesDataGrid.AllowUserToDeleteRows = false;
            this.EmployeesDataGrid.AllowUserToOrderColumns = true;
            this.EmployeesDataGrid.AllowUserToResizeRows = false;
            this.EmployeesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.EmployeesDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.EmployeesDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeesDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.EmployeesDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeesDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.EmployeesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeIdColumn,
            this.FullNameColumn,
            this.DesignationColumn,
            this.BalanceColumn,
            this.MonthlySalaryColumn,
            this.JoinDateColumn,
            this.CreatorColumn,
            this.CreatedColumn,
            this.ModifiedColumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeesDataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.EmployeesDataGrid.GridColor = System.Drawing.Color.WhiteSmoke;
            this.EmployeesDataGrid.Name = "EmployeesDataGrid";
            this.EmployeesDataGrid.ReadOnly = true;
            this.EmployeesDataGrid.RowHeadersVisible = false;
            this.EmployeesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ButtonToolTip.SetToolTip(this.EmployeesDataGrid, resources.GetString("EmployeesDataGrid.ToolTip"));
            this.EmployeesDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeesDataGrid_CellContentClick);
            // 
            // EmployeeIdColumn
            // 
            this.EmployeeIdColumn.DataPropertyName = "EmployeeId";
            resources.ApplyResources(this.EmployeeIdColumn, "EmployeeIdColumn");
            this.EmployeeIdColumn.Name = "EmployeeIdColumn";
            this.EmployeeIdColumn.ReadOnly = true;
            // 
            // FullNameColumn
            // 
            this.FullNameColumn.DataPropertyName = "FullName";
            resources.ApplyResources(this.FullNameColumn, "FullNameColumn");
            this.FullNameColumn.Name = "FullNameColumn";
            this.FullNameColumn.ReadOnly = true;
            // 
            // DesignationColumn
            // 
            this.DesignationColumn.DataPropertyName = "Designation";
            resources.ApplyResources(this.DesignationColumn, "DesignationColumn");
            this.DesignationColumn.Name = "DesignationColumn";
            this.DesignationColumn.ReadOnly = true;
            // 
            // BalanceColumn
            // 
            this.BalanceColumn.DataPropertyName = "Balance";
            resources.ApplyResources(this.BalanceColumn, "BalanceColumn");
            this.BalanceColumn.Name = "BalanceColumn";
            this.BalanceColumn.ReadOnly = true;
            // 
            // MonthlySalaryColumn
            // 
            this.MonthlySalaryColumn.DataPropertyName = "GetMonthlySalary";
            resources.ApplyResources(this.MonthlySalaryColumn, "MonthlySalaryColumn");
            this.MonthlySalaryColumn.Name = "MonthlySalaryColumn";
            this.MonthlySalaryColumn.ReadOnly = true;
            // 
            // JoinDateColumn
            // 
            this.JoinDateColumn.DataPropertyName = "GetJoinDate";
            resources.ApplyResources(this.JoinDateColumn, "JoinDateColumn");
            this.JoinDateColumn.Name = "JoinDateColumn";
            this.JoinDateColumn.ReadOnly = true;
            // 
            // CreatorColumn
            // 
            this.CreatorColumn.DataPropertyName = "Creator";
            resources.ApplyResources(this.CreatorColumn, "CreatorColumn");
            this.CreatorColumn.Name = "CreatorColumn";
            this.CreatorColumn.ReadOnly = true;
            // 
            // CreatedColumn
            // 
            this.CreatedColumn.DataPropertyName = "Created";
            resources.ApplyResources(this.CreatedColumn, "CreatedColumn");
            this.CreatedColumn.Name = "CreatedColumn";
            this.CreatedColumn.ReadOnly = true;
            // 
            // ModifiedColumn
            // 
            this.ModifiedColumn.DataPropertyName = "ModifiedColumn";
            resources.ApplyResources(this.ModifiedColumn, "ModifiedColumn");
            this.ModifiedColumn.Name = "ModifiedColumn";
            this.ModifiedColumn.ReadOnly = true;
            // 
            // HistoryLabel
            // 
            resources.ApplyResources(this.HistoryLabel, "HistoryLabel");
            this.HistoryLabel.Name = "HistoryLabel";
            this.ButtonToolTip.SetToolTip(this.HistoryLabel, resources.GetString("HistoryLabel.ToolTip"));
            this.HistoryLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // DeleteEntryButton
            // 
            resources.ApplyResources(this.DeleteEntryButton, "DeleteEntryButton");
            this.DeleteEntryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.DeleteEntryButton.FlatAppearance.BorderSize = 0;
            this.DeleteEntryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.DeleteEntryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(135)))));
            this.DeleteEntryButton.ForeColor = System.Drawing.Color.White;
            this.DeleteEntryButton.Name = "DeleteEntryButton";
            this.ButtonToolTip.SetToolTip(this.DeleteEntryButton, resources.GetString("DeleteEntryButton.ToolTip"));
            this.DeleteEntryButton.UseVisualStyleBackColor = false;
            this.DeleteEntryButton.Click += new System.EventHandler(this.DeleteEntryButton_Click);
            // 
            // AddEmployeeButton
            // 
            resources.ApplyResources(this.AddEmployeeButton, "AddEmployeeButton");
            this.AddEmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.AddEmployeeButton.FlatAppearance.BorderSize = 0;
            this.AddEmployeeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(170)))));
            this.AddEmployeeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.AddEmployeeButton.ForeColor = System.Drawing.Color.White;
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.ButtonToolTip.SetToolTip(this.AddEmployeeButton, resources.GetString("AddEmployeeButton.ToolTip"));
            this.AddEmployeeButton.UseVisualStyleBackColor = false;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // DeleteEmployeeButton
            // 
            resources.ApplyResources(this.DeleteEmployeeButton, "DeleteEmployeeButton");
            this.DeleteEmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.DeleteEmployeeButton.FlatAppearance.BorderSize = 0;
            this.DeleteEmployeeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.DeleteEmployeeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(135)))));
            this.DeleteEmployeeButton.ForeColor = System.Drawing.Color.White;
            this.DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            this.ButtonToolTip.SetToolTip(this.DeleteEmployeeButton, resources.GetString("DeleteEmployeeButton.ToolTip"));
            this.DeleteEmployeeButton.UseVisualStyleBackColor = false;
            this.DeleteEmployeeButton.Click += new System.EventHandler(this.DeleteEmployeeButton_Click);
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
            // SearchEmployeeText
            // 
            resources.ApplyResources(this.SearchEmployeeText, "SearchEmployeeText");
            this.SearchEmployeeText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SearchEmployeeText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SearchEmployeeText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SearchEmployeeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchEmployeeText.Name = "SearchEmployeeText";
            this.ButtonToolTip.SetToolTip(this.SearchEmployeeText, resources.GetString("SearchEmployeeText.ToolTip"));
            this.SearchEmployeeText.TextChanged += new System.EventHandler(this.SearchEmployeeText_TextChanged);
            // 
            // TitleLabel
            // 
            resources.ApplyResources(this.TitleLabel, "TitleLabel");
            this.TitleLabel.Name = "TitleLabel";
            this.ButtonToolTip.SetToolTip(this.TitleLabel, resources.GetString("TitleLabel.ToolTip"));
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
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
            // ReloadEmployees
            // 
            resources.ApplyResources(this.ReloadEmployees, "ReloadEmployees");
            this.ReloadEmployees.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Sync_500px;
            this.ReloadEmployees.FlatAppearance.BorderSize = 0;
            this.ReloadEmployees.Name = "ReloadEmployees";
            this.ButtonToolTip.SetToolTip(this.ReloadEmployees, resources.GetString("ReloadEmployees.ToolTip"));
            this.ReloadEmployees.UseVisualStyleBackColor = true;
            this.ReloadEmployees.Click += new System.EventHandler(this.ReloadEmployees_Click);
            // 
            // EmployeeForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ReloadEmployees);
            this.Controls.Add(this.EmployeeHistoryDataGrid);
            this.Controls.Add(this.EmployeesDataGrid);
            this.Controls.Add(this.SearchIcon);
            this.Controls.Add(this.HistoryLabel);
            this.Controls.Add(this.DeleteEntryButton);
            this.Controls.Add(this.AddEmployeeButton);
            this.Controls.Add(this.DeleteEmployeeButton);
            this.Controls.Add(this.ViewEditEmployeeButton);
            this.Controls.Add(this.SearchEmployeeText);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EmployeeForm";
            this.ButtonToolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeHistoryDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeeHistoryDataGrid;
        private System.Windows.Forms.DataGridView EmployeesDataGrid;
        private System.Windows.Forms.PictureBox SearchIcon;
        private System.Windows.Forms.Label HistoryLabel;
        private System.Windows.Forms.Button DeleteEntryButton;
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.Button DeleteEmployeeButton;
        private System.Windows.Forms.Button ViewEditEmployeeButton;
        private System.Windows.Forms.TextBox SearchEmployeeText;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button ReloadEmployees;
        private System.Windows.Forms.ToolTip ButtonToolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoryCreatedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HistoryCreatorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesignationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BalanceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthlySalaryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn JoinDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModifiedColumn;
    }
}