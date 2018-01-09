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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeHistoryDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeeHistoryDataGrid.GridColor = System.Drawing.Color.WhiteSmoke;
            this.EmployeeHistoryDataGrid.Location = new System.Drawing.Point(648, 96);
            this.EmployeeHistoryDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.EmployeeHistoryDataGrid.Name = "EmployeeHistoryDataGrid";
            this.EmployeeHistoryDataGrid.RowHeadersVisible = false;
            this.EmployeeHistoryDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeeHistoryDataGrid.Size = new System.Drawing.Size(443, 514);
            this.EmployeeHistoryDataGrid.TabIndex = 8;
            // 
            // IdColumn2
            // 
            this.IdColumn2.DataPropertyName = "PaymentId";
            this.IdColumn2.HeaderText = "Id";
            this.IdColumn2.Name = "IdColumn2";
            this.IdColumn2.Width = 48;
            // 
            // AmountColumn
            // 
            this.AmountColumn.DataPropertyName = "Amount";
            this.AmountColumn.HeaderText = "Amount";
            this.AmountColumn.Name = "AmountColumn";
            this.AmountColumn.Width = 91;
            // 
            // HistoryCreatedColumn
            // 
            this.HistoryCreatedColumn.DataPropertyName = "Created";
            this.HistoryCreatedColumn.HeaderText = "Added on";
            this.HistoryCreatedColumn.Name = "HistoryCreatedColumn";
            this.HistoryCreatedColumn.Width = 102;
            // 
            // HistoryCreatorColumn
            // 
            this.HistoryCreatorColumn.DataPropertyName = "Creator";
            this.HistoryCreatorColumn.HeaderText = "Added by";
            this.HistoryCreatorColumn.Name = "HistoryCreatorColumn";
            this.HistoryCreatorColumn.Width = 101;
            // 
            // EmployeesDataGrid
            // 
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeesDataGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.EmployeesDataGrid.GridColor = System.Drawing.Color.WhiteSmoke;
            this.EmployeesDataGrid.Location = new System.Drawing.Point(13, 96);
            this.EmployeesDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.EmployeesDataGrid.Name = "EmployeesDataGrid";
            this.EmployeesDataGrid.ReadOnly = true;
            this.EmployeesDataGrid.RowHeadersVisible = false;
            this.EmployeesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeesDataGrid.Size = new System.Drawing.Size(618, 514);
            this.EmployeesDataGrid.TabIndex = 2;
            this.EmployeesDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeesDataGrid_CellContentClick);
            // 
            // EmployeeIdColumn
            // 
            this.EmployeeIdColumn.DataPropertyName = "EmployeeId";
            this.EmployeeIdColumn.HeaderText = "Id";
            this.EmployeeIdColumn.Name = "EmployeeIdColumn";
            this.EmployeeIdColumn.ReadOnly = true;
            this.EmployeeIdColumn.Width = 48;
            // 
            // FullNameColumn
            // 
            this.FullNameColumn.DataPropertyName = "FullName";
            this.FullNameColumn.HeaderText = "Name";
            this.FullNameColumn.Name = "FullNameColumn";
            this.FullNameColumn.ReadOnly = true;
            this.FullNameColumn.Width = 77;
            // 
            // DesignationColumn
            // 
            this.DesignationColumn.DataPropertyName = "Designation";
            this.DesignationColumn.HeaderText = "Designation";
            this.DesignationColumn.Name = "DesignationColumn";
            this.DesignationColumn.ReadOnly = true;
            this.DesignationColumn.Width = 118;
            // 
            // BalanceColumn
            // 
            this.BalanceColumn.DataPropertyName = "Balance";
            this.BalanceColumn.HeaderText = "Balance";
            this.BalanceColumn.Name = "BalanceColumn";
            this.BalanceColumn.ReadOnly = true;
            this.BalanceColumn.Width = 88;
            // 
            // MonthlySalaryColumn
            // 
            this.MonthlySalaryColumn.DataPropertyName = "GetMonthlySalary";
            this.MonthlySalaryColumn.HeaderText = "Salary";
            this.MonthlySalaryColumn.Name = "MonthlySalaryColumn";
            this.MonthlySalaryColumn.ReadOnly = true;
            this.MonthlySalaryColumn.Width = 78;
            // 
            // JoinDateColumn
            // 
            this.JoinDateColumn.DataPropertyName = "GetJoinDate";
            this.JoinDateColumn.HeaderText = "Joining Date";
            this.JoinDateColumn.Name = "JoinDateColumn";
            this.JoinDateColumn.ReadOnly = true;
            this.JoinDateColumn.Width = 121;
            // 
            // CreatorColumn
            // 
            this.CreatorColumn.DataPropertyName = "Creator";
            this.CreatorColumn.HeaderText = "Added by";
            this.CreatorColumn.Name = "CreatorColumn";
            this.CreatorColumn.ReadOnly = true;
            this.CreatorColumn.Width = 101;
            // 
            // CreatedColumn
            // 
            this.CreatedColumn.DataPropertyName = "Created";
            this.CreatedColumn.HeaderText = "Added on";
            this.CreatedColumn.Name = "CreatedColumn";
            this.CreatedColumn.ReadOnly = true;
            this.CreatedColumn.Width = 102;
            // 
            // ModifiedColumn
            // 
            this.ModifiedColumn.DataPropertyName = "ModifiedColumn";
            this.ModifiedColumn.HeaderText = "Last modified";
            this.ModifiedColumn.Name = "ModifiedColumn";
            this.ModifiedColumn.ReadOnly = true;
            this.ModifiedColumn.Width = 129;
            // 
            // HistoryLabel
            // 
            this.HistoryLabel.AutoSize = true;
            this.HistoryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryLabel.Location = new System.Drawing.Point(644, 71);
            this.HistoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HistoryLabel.Name = "HistoryLabel";
            this.HistoryLabel.Size = new System.Drawing.Size(60, 21);
            this.HistoryLabel.TabIndex = 7;
            this.HistoryLabel.Text = "History";
            this.HistoryLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
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
            this.DeleteEntryButton.Location = new System.Drawing.Point(648, 621);
            this.DeleteEntryButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.DeleteEntryButton.Name = "DeleteEntryButton";
            this.DeleteEntryButton.Size = new System.Drawing.Size(443, 42);
            this.DeleteEntryButton.TabIndex = 9;
            this.DeleteEntryButton.Text = "Delete Selected Record(s)";
            this.DeleteEntryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteEntryButton.UseVisualStyleBackColor = false;
            this.DeleteEntryButton.Click += new System.EventHandler(this.DeleteEntryButton_Click);
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.AddEmployeeButton.FlatAppearance.BorderSize = 0;
            this.AddEmployeeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(170)))));
            this.AddEmployeeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.AddEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmployeeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeeButton.ForeColor = System.Drawing.Color.White;
            this.AddEmployeeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddEmployeeButton.Location = new System.Drawing.Point(429, 621);
            this.AddEmployeeButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(202, 42);
            this.AddEmployeeButton.TabIndex = 3;
            this.AddEmployeeButton.Text = "+ Add Employee";
            this.AddEmployeeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddEmployeeButton.UseVisualStyleBackColor = false;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // DeleteEmployeeButton
            // 
            this.DeleteEmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.DeleteEmployeeButton.FlatAppearance.BorderSize = 0;
            this.DeleteEmployeeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.DeleteEmployeeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(135)))));
            this.DeleteEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteEmployeeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteEmployeeButton.ForeColor = System.Drawing.Color.White;
            this.DeleteEmployeeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteEmployeeButton.Location = new System.Drawing.Point(13, 621);
            this.DeleteEmployeeButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            this.DeleteEmployeeButton.Size = new System.Drawing.Size(202, 42);
            this.DeleteEmployeeButton.TabIndex = 5;
            this.DeleteEmployeeButton.Text = "Delete Employee(s)";
            this.DeleteEmployeeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteEmployeeButton.UseVisualStyleBackColor = false;
            this.DeleteEmployeeButton.Click += new System.EventHandler(this.DeleteEmployeeButton_Click);
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
            this.ViewEditEmployeeButton.Location = new System.Drawing.Point(221, 621);
            this.ViewEditEmployeeButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ViewEditEmployeeButton.Name = "ViewEditEmployeeButton";
            this.ViewEditEmployeeButton.Size = new System.Drawing.Size(202, 42);
            this.ViewEditEmployeeButton.TabIndex = 4;
            this.ViewEditEmployeeButton.Text = "View / Edit Employee";
            this.ViewEditEmployeeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ViewEditEmployeeButton.UseVisualStyleBackColor = false;
            this.ViewEditEmployeeButton.Click += new System.EventHandler(this.ViewEditEmployeeButton_Click);
            // 
            // SearchEmployeeText
            // 
            this.SearchEmployeeText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SearchEmployeeText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SearchEmployeeText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SearchEmployeeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchEmployeeText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchEmployeeText.Location = new System.Drawing.Point(13, 66);
            this.SearchEmployeeText.Margin = new System.Windows.Forms.Padding(4);
            this.SearchEmployeeText.Name = "SearchEmployeeText";
            this.SearchEmployeeText.Size = new System.Drawing.Size(375, 22);
            this.SearchEmployeeText.TabIndex = 1;
            this.SearchEmployeeText.TextChanged += new System.EventHandler(this.SearchEmployeeText_TextChanged);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semi Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(5, 6);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(181, 47);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Employees";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // SearchIcon
            // 
            this.SearchIcon.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Search_96px;
            this.SearchIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchIcon.ErrorImage = null;
            this.SearchIcon.InitialImage = null;
            this.SearchIcon.Location = new System.Drawing.Point(388, 64);
            this.SearchIcon.Margin = new System.Windows.Forms.Padding(4);
            this.SearchIcon.Name = "SearchIcon";
            this.SearchIcon.Size = new System.Drawing.Size(25, 25);
            this.SearchIcon.TabIndex = 100;
            this.SearchIcon.TabStop = false;
            this.SearchIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // ReloadEmployees
            // 
            this.ReloadEmployees.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Sync_500px;
            this.ReloadEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReloadEmployees.FlatAppearance.BorderSize = 0;
            this.ReloadEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReloadEmployees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReloadEmployees.Location = new System.Drawing.Point(1075, 3);
            this.ReloadEmployees.Name = "ReloadEmployees";
            this.ReloadEmployees.Size = new System.Drawing.Size(29, 29);
            this.ReloadEmployees.TabIndex = 6;
            this.ButtonToolTip.SetToolTip(this.ReloadEmployees, "Force refresh employees from database");
            this.ReloadEmployees.UseVisualStyleBackColor = true;
            this.ReloadEmployees.Click += new System.EventHandler(this.ReloadEmployees_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1107, 677);
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
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EmployeeForm";
            this.Text = "Employees";
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