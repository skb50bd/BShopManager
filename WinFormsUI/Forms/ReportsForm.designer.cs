namespace WinFormsUI.Forms {
    partial class ReportsForm {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
            this.Filter1Label = new System.Windows.Forms.Label();
            this.Filter2Label = new System.Windows.Forms.Label();
            this.Filter1Combo = new System.Windows.Forms.ComboBox();
            this.Filter2Combo = new System.Windows.Forms.ComboBox();
            this.ReportTypeSelectorCombo = new System.Windows.Forms.ComboBox();
            this.PrintButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.DateGroupBox = new System.Windows.Forms.GroupBox();
            this.ToDateTime = new System.Windows.Forms.DateTimePicker();
            this.FromLabel = new System.Windows.Forms.Label();
            this.FromDateTime = new System.Windows.Forms.DateTimePicker();
            this.ToLabel = new System.Windows.Forms.Label();
            this.ReportsGrid = new System.Windows.Forms.DataGridView();
            this.StatsGroupBox = new System.Windows.Forms.GroupBox();
            this.StatPropText10 = new System.Windows.Forms.TextBox();
            this.StatPropLabel10 = new System.Windows.Forms.Label();
            this.StatPropText9 = new System.Windows.Forms.TextBox();
            this.StatPropLabel9 = new System.Windows.Forms.Label();
            this.StatPropText8 = new System.Windows.Forms.TextBox();
            this.StatPropLabel8 = new System.Windows.Forms.Label();
            this.StatPropText7 = new System.Windows.Forms.TextBox();
            this.StatPropLabel7 = new System.Windows.Forms.Label();
            this.StatPropText6 = new System.Windows.Forms.TextBox();
            this.StatPropLabel6 = new System.Windows.Forms.Label();
            this.StatPropText5 = new System.Windows.Forms.TextBox();
            this.StatPropLabel5 = new System.Windows.Forms.Label();
            this.StatPropText4 = new System.Windows.Forms.TextBox();
            this.StatPropLabel4 = new System.Windows.Forms.Label();
            this.StatPropText3 = new System.Windows.Forms.TextBox();
            this.StatPropLabel3 = new System.Windows.Forms.Label();
            this.StatPropText2 = new System.Windows.Forms.TextBox();
            this.StatPropLabel2 = new System.Windows.Forms.Label();
            this.StatPropText1 = new System.Windows.Forms.TextBox();
            this.StatPropLabel1 = new System.Windows.Forms.Label();
            this.DateGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportsGrid)).BeginInit();
            this.StatsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Filter1Label
            // 
            this.Filter1Label.AutoSize = true;
            this.Filter1Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter1Label.Location = new System.Drawing.Point(7, 74);
            this.Filter1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Filter1Label.Name = "Filter1Label";
            this.Filter1Label.Size = new System.Drawing.Size(58, 21);
            this.Filter1Label.TabIndex = 3;
            this.Filter1Label.Text = "Filter 1";
            this.Filter1Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // Filter2Label
            // 
            this.Filter2Label.AutoSize = true;
            this.Filter2Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter2Label.Location = new System.Drawing.Point(324, 74);
            this.Filter2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Filter2Label.Name = "Filter2Label";
            this.Filter2Label.Size = new System.Drawing.Size(58, 21);
            this.Filter2Label.TabIndex = 5;
            this.Filter2Label.Text = "Filter 2";
            this.Filter2Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // Filter1Combo
            // 
            this.Filter1Combo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Filter1Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Filter1Combo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter1Combo.FormattingEnabled = true;
            this.Filter1Combo.Location = new System.Drawing.Point(11, 97);
            this.Filter1Combo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Filter1Combo.Name = "Filter1Combo";
            this.Filter1Combo.Size = new System.Drawing.Size(289, 29);
            this.Filter1Combo.TabIndex = 4;
            this.Filter1Combo.SelectedIndexChanged += new System.EventHandler(this.Filter1Combo_SelectedIndexChanged);
            // 
            // Filter2Combo
            // 
            this.Filter2Combo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Filter2Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Filter2Combo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter2Combo.FormattingEnabled = true;
            this.Filter2Combo.Location = new System.Drawing.Point(328, 96);
            this.Filter2Combo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Filter2Combo.Name = "Filter2Combo";
            this.Filter2Combo.Size = new System.Drawing.Size(255, 29);
            this.Filter2Combo.TabIndex = 6;
            this.Filter2Combo.SelectedIndexChanged += new System.EventHandler(this.Filter2Combo_SelectedIndexChanged);
            // 
            // ReportTypeSelectorCombo
            // 
            this.ReportTypeSelectorCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ReportTypeSelectorCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ReportTypeSelectorCombo.BackColor = System.Drawing.Color.White;
            this.ReportTypeSelectorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReportTypeSelectorCombo.Font = new System.Drawing.Font("Segoe UI Semi Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportTypeSelectorCombo.FormattingEnabled = true;
            this.ReportTypeSelectorCombo.Items.AddRange(new object[] {
            "Summary",
            "Bank Account ",
            "Customer ",
            "Due Collection ",
            "Employee ",
            "Expense ",
            "Payment ",
            "Purchase ",
            "Purchase Return ",
            "Refund ",
            "Repayment ",
            "Sale ",
            "Supplier ",
            "Transaction "});
            this.ReportTypeSelectorCombo.Location = new System.Drawing.Point(11, 17);
            this.ReportTypeSelectorCombo.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.ReportTypeSelectorCombo.Name = "ReportTypeSelectorCombo";
            this.ReportTypeSelectorCombo.Size = new System.Drawing.Size(572, 53);
            this.ReportTypeSelectorCombo.TabIndex = 2;
            this.ReportTypeSelectorCombo.SelectedIndexChanged += new System.EventHandler(this.ReportTypeSelectorCombo_SelectedIndexChanged);
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
            this.PrintButton.Location = new System.Drawing.Point(13, 673);
            this.PrintButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(227, 42);
            this.PrintButton.TabIndex = 13;
            this.PrintButton.Text = "Print";
            this.PrintButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PrintButton.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(135)))));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteButton.Location = new System.Drawing.Point(248, 673);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(279, 42);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.Text = "Delete Selected Item(s)";
            this.DeleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ViewButton
            // 
            this.ViewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.ViewButton.FlatAppearance.BorderSize = 0;
            this.ViewButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.ViewButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            this.ViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewButton.ForeColor = System.Drawing.Color.White;
            this.ViewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewButton.Location = new System.Drawing.Point(535, 672);
            this.ViewButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(240, 42);
            this.ViewButton.TabIndex = 11;
            this.ViewButton.Text = "View";
            this.ViewButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ViewButton.UseVisualStyleBackColor = false;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // DateGroupBox
            // 
            this.DateGroupBox.Controls.Add(this.ToDateTime);
            this.DateGroupBox.Controls.Add(this.FromLabel);
            this.DateGroupBox.Controls.Add(this.FromDateTime);
            this.DateGroupBox.Controls.Add(this.ToLabel);
            this.DateGroupBox.Location = new System.Drawing.Point(592, 4);
            this.DateGroupBox.Name = "DateGroupBox";
            this.DateGroupBox.Size = new System.Drawing.Size(403, 122);
            this.DateGroupBox.TabIndex = 7;
            this.DateGroupBox.TabStop = false;
            // 
            // ToDateTime
            // 
            this.ToDateTime.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDateTime.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.ToDateTime.CustomFormat = "dddd dd/MM/yyyy hh:mm tt";
            this.ToDateTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDateTime.Location = new System.Drawing.Point(92, 77);
            this.ToDateTime.Margin = new System.Windows.Forms.Padding(5);
            this.ToDateTime.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.ToDateTime.Name = "ToDateTime";
            this.ToDateTime.Size = new System.Drawing.Size(302, 29);
            this.ToDateTime.TabIndex = 3;
            this.ToDateTime.Value = new System.DateTime(2018, 12, 25, 0, 0, 0, 0);
            this.ToDateTime.ValueChanged += new System.EventHandler(this.ToDateTime_ValueChanged);
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromLabel.Location = new System.Drawing.Point(7, 34);
            this.FromLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(76, 21);
            this.FromLabel.TabIndex = 0;
            this.FromLabel.Text = "Start date";
            this.FromLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // FromDateTime
            // 
            this.FromDateTime.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDateTime.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.FromDateTime.CustomFormat = "dddd dd/MM/yyyy hh:mm tt";
            this.FromDateTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromDateTime.Location = new System.Drawing.Point(92, 28);
            this.FromDateTime.Margin = new System.Windows.Forms.Padding(5);
            this.FromDateTime.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.FromDateTime.Name = "FromDateTime";
            this.FromDateTime.Size = new System.Drawing.Size(302, 29);
            this.FromDateTime.TabIndex = 1;
            this.FromDateTime.Value = new System.DateTime(2018, 12, 25, 0, 0, 0, 0);
            this.FromDateTime.ValueChanged += new System.EventHandler(this.FromDateTime_ValueChanged);
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLabel.Location = new System.Drawing.Point(7, 83);
            this.ToLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(70, 21);
            this.ToLabel.TabIndex = 2;
            this.ToLabel.Text = "End date";
            // 
            // ReportsGrid
            // 
            this.ReportsGrid.AllowUserToAddRows = false;
            this.ReportsGrid.AllowUserToDeleteRows = false;
            this.ReportsGrid.AllowUserToResizeRows = false;
            this.ReportsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ReportsGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ReportsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReportsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReportsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ReportsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReportsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.ReportsGrid.GridColor = System.Drawing.Color.WhiteSmoke;
            this.ReportsGrid.Location = new System.Drawing.Point(11, 133);
            this.ReportsGrid.Margin = new System.Windows.Forms.Padding(4);
            this.ReportsGrid.Name = "ReportsGrid";
            this.ReportsGrid.RowHeadersVisible = false;
            this.ReportsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReportsGrid.Size = new System.Drawing.Size(764, 534);
            this.ReportsGrid.TabIndex = 10;
            this.ReportsGrid.SelectionChanged += new System.EventHandler(this.ReportsGrid_SelectionChanged);
            // 
            // StatsGroupBox
            // 
            this.StatsGroupBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StatsGroupBox.Controls.Add(this.StatPropText10);
            this.StatsGroupBox.Controls.Add(this.StatPropLabel10);
            this.StatsGroupBox.Controls.Add(this.StatPropText9);
            this.StatsGroupBox.Controls.Add(this.StatPropLabel9);
            this.StatsGroupBox.Controls.Add(this.StatPropText8);
            this.StatsGroupBox.Controls.Add(this.StatPropLabel8);
            this.StatsGroupBox.Controls.Add(this.StatPropText7);
            this.StatsGroupBox.Controls.Add(this.StatPropLabel7);
            this.StatsGroupBox.Controls.Add(this.StatPropText6);
            this.StatsGroupBox.Controls.Add(this.StatPropLabel6);
            this.StatsGroupBox.Controls.Add(this.StatPropText5);
            this.StatsGroupBox.Controls.Add(this.StatPropLabel5);
            this.StatsGroupBox.Controls.Add(this.StatPropText4);
            this.StatsGroupBox.Controls.Add(this.StatPropLabel4);
            this.StatsGroupBox.Controls.Add(this.StatPropText3);
            this.StatsGroupBox.Controls.Add(this.StatPropLabel3);
            this.StatsGroupBox.Controls.Add(this.StatPropText2);
            this.StatsGroupBox.Controls.Add(this.StatPropLabel2);
            this.StatsGroupBox.Controls.Add(this.StatPropText1);
            this.StatsGroupBox.Controls.Add(this.StatPropLabel1);
            this.StatsGroupBox.Location = new System.Drawing.Point(784, 132);
            this.StatsGroupBox.Name = "StatsGroupBox";
            this.StatsGroupBox.Size = new System.Drawing.Size(211, 582);
            this.StatsGroupBox.TabIndex = 15;
            this.StatsGroupBox.TabStop = false;
            this.StatsGroupBox.Text = "Stats";
            // 
            // StatPropText10
            // 
            this.StatPropText10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.StatPropText10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatPropText10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatPropText10.Location = new System.Drawing.Point(11, 533);
            this.StatPropText10.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.StatPropText10.Name = "StatPropText10";
            this.StatPropText10.ReadOnly = true;
            this.StatPropText10.Size = new System.Drawing.Size(192, 22);
            this.StatPropText10.TabIndex = 34;
            this.StatPropText10.Visible = false;
            // 
            // StatPropLabel10
            // 
            this.StatPropLabel10.AutoSize = true;
            this.StatPropLabel10.Enabled = false;
            this.StatPropLabel10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatPropLabel10.Location = new System.Drawing.Point(7, 512);
            this.StatPropLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatPropLabel10.Name = "StatPropLabel10";
            this.StatPropLabel10.Size = new System.Drawing.Size(64, 21);
            this.StatPropLabel10.TabIndex = 33;
            this.StatPropLabel10.Text = "Entries: ";
            this.StatPropLabel10.Visible = false;
            this.StatPropLabel10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // StatPropText9
            // 
            this.StatPropText9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.StatPropText9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatPropText9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatPropText9.Location = new System.Drawing.Point(11, 480);
            this.StatPropText9.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.StatPropText9.Name = "StatPropText9";
            this.StatPropText9.ReadOnly = true;
            this.StatPropText9.Size = new System.Drawing.Size(192, 22);
            this.StatPropText9.TabIndex = 32;
            this.StatPropText9.Visible = false;
            // 
            // StatPropLabel9
            // 
            this.StatPropLabel9.AutoSize = true;
            this.StatPropLabel9.Enabled = false;
            this.StatPropLabel9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatPropLabel9.Location = new System.Drawing.Point(7, 459);
            this.StatPropLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatPropLabel9.Name = "StatPropLabel9";
            this.StatPropLabel9.Size = new System.Drawing.Size(64, 21);
            this.StatPropLabel9.TabIndex = 31;
            this.StatPropLabel9.Text = "Entries: ";
            this.StatPropLabel9.Visible = false;
            this.StatPropLabel9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // StatPropText8
            // 
            this.StatPropText8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.StatPropText8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatPropText8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatPropText8.Location = new System.Drawing.Point(11, 427);
            this.StatPropText8.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.StatPropText8.Name = "StatPropText8";
            this.StatPropText8.ReadOnly = true;
            this.StatPropText8.Size = new System.Drawing.Size(192, 22);
            this.StatPropText8.TabIndex = 30;
            this.StatPropText8.Visible = false;
            // 
            // StatPropLabel8
            // 
            this.StatPropLabel8.AutoSize = true;
            this.StatPropLabel8.Enabled = false;
            this.StatPropLabel8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatPropLabel8.Location = new System.Drawing.Point(7, 406);
            this.StatPropLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatPropLabel8.Name = "StatPropLabel8";
            this.StatPropLabel8.Size = new System.Drawing.Size(64, 21);
            this.StatPropLabel8.TabIndex = 29;
            this.StatPropLabel8.Text = "Entries: ";
            this.StatPropLabel8.Visible = false;
            this.StatPropLabel8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // StatPropText7
            // 
            this.StatPropText7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.StatPropText7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatPropText7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatPropText7.Location = new System.Drawing.Point(11, 374);
            this.StatPropText7.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.StatPropText7.Name = "StatPropText7";
            this.StatPropText7.ReadOnly = true;
            this.StatPropText7.Size = new System.Drawing.Size(192, 22);
            this.StatPropText7.TabIndex = 28;
            this.StatPropText7.Visible = false;
            // 
            // StatPropLabel7
            // 
            this.StatPropLabel7.AutoSize = true;
            this.StatPropLabel7.Enabled = false;
            this.StatPropLabel7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatPropLabel7.Location = new System.Drawing.Point(7, 353);
            this.StatPropLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatPropLabel7.Name = "StatPropLabel7";
            this.StatPropLabel7.Size = new System.Drawing.Size(64, 21);
            this.StatPropLabel7.TabIndex = 27;
            this.StatPropLabel7.Text = "Entries: ";
            this.StatPropLabel7.Visible = false;
            this.StatPropLabel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // StatPropText6
            // 
            this.StatPropText6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.StatPropText6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatPropText6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatPropText6.Location = new System.Drawing.Point(11, 321);
            this.StatPropText6.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.StatPropText6.Name = "StatPropText6";
            this.StatPropText6.ReadOnly = true;
            this.StatPropText6.Size = new System.Drawing.Size(192, 22);
            this.StatPropText6.TabIndex = 26;
            this.StatPropText6.Visible = false;
            // 
            // StatPropLabel6
            // 
            this.StatPropLabel6.AutoSize = true;
            this.StatPropLabel6.Enabled = false;
            this.StatPropLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatPropLabel6.Location = new System.Drawing.Point(7, 300);
            this.StatPropLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatPropLabel6.Name = "StatPropLabel6";
            this.StatPropLabel6.Size = new System.Drawing.Size(64, 21);
            this.StatPropLabel6.TabIndex = 25;
            this.StatPropLabel6.Text = "Entries: ";
            this.StatPropLabel6.Visible = false;
            this.StatPropLabel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // StatPropText5
            // 
            this.StatPropText5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.StatPropText5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatPropText5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatPropText5.Location = new System.Drawing.Point(11, 268);
            this.StatPropText5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.StatPropText5.Name = "StatPropText5";
            this.StatPropText5.ReadOnly = true;
            this.StatPropText5.Size = new System.Drawing.Size(192, 22);
            this.StatPropText5.TabIndex = 24;
            this.StatPropText5.Visible = false;
            // 
            // StatPropLabel5
            // 
            this.StatPropLabel5.AutoSize = true;
            this.StatPropLabel5.Enabled = false;
            this.StatPropLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatPropLabel5.Location = new System.Drawing.Point(7, 247);
            this.StatPropLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatPropLabel5.Name = "StatPropLabel5";
            this.StatPropLabel5.Size = new System.Drawing.Size(64, 21);
            this.StatPropLabel5.TabIndex = 23;
            this.StatPropLabel5.Text = "Entries: ";
            this.StatPropLabel5.Visible = false;
            this.StatPropLabel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // StatPropText4
            // 
            this.StatPropText4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.StatPropText4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatPropText4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatPropText4.Location = new System.Drawing.Point(11, 215);
            this.StatPropText4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.StatPropText4.Name = "StatPropText4";
            this.StatPropText4.ReadOnly = true;
            this.StatPropText4.Size = new System.Drawing.Size(192, 22);
            this.StatPropText4.TabIndex = 22;
            this.StatPropText4.Visible = false;
            // 
            // StatPropLabel4
            // 
            this.StatPropLabel4.AutoSize = true;
            this.StatPropLabel4.Enabled = false;
            this.StatPropLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatPropLabel4.Location = new System.Drawing.Point(7, 194);
            this.StatPropLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatPropLabel4.Name = "StatPropLabel4";
            this.StatPropLabel4.Size = new System.Drawing.Size(64, 21);
            this.StatPropLabel4.TabIndex = 21;
            this.StatPropLabel4.Text = "Entries: ";
            this.StatPropLabel4.Visible = false;
            this.StatPropLabel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // StatPropText3
            // 
            this.StatPropText3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.StatPropText3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatPropText3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatPropText3.Location = new System.Drawing.Point(11, 162);
            this.StatPropText3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.StatPropText3.Name = "StatPropText3";
            this.StatPropText3.ReadOnly = true;
            this.StatPropText3.Size = new System.Drawing.Size(192, 22);
            this.StatPropText3.TabIndex = 20;
            this.StatPropText3.Visible = false;
            // 
            // StatPropLabel3
            // 
            this.StatPropLabel3.AutoSize = true;
            this.StatPropLabel3.Enabled = false;
            this.StatPropLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatPropLabel3.Location = new System.Drawing.Point(7, 141);
            this.StatPropLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatPropLabel3.Name = "StatPropLabel3";
            this.StatPropLabel3.Size = new System.Drawing.Size(64, 21);
            this.StatPropLabel3.TabIndex = 19;
            this.StatPropLabel3.Text = "Entries: ";
            this.StatPropLabel3.Visible = false;
            this.StatPropLabel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // StatPropText2
            // 
            this.StatPropText2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.StatPropText2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatPropText2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatPropText2.Location = new System.Drawing.Point(11, 109);
            this.StatPropText2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.StatPropText2.Name = "StatPropText2";
            this.StatPropText2.ReadOnly = true;
            this.StatPropText2.Size = new System.Drawing.Size(192, 22);
            this.StatPropText2.TabIndex = 18;
            this.StatPropText2.Visible = false;
            // 
            // StatPropLabel2
            // 
            this.StatPropLabel2.AutoSize = true;
            this.StatPropLabel2.Enabled = false;
            this.StatPropLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatPropLabel2.Location = new System.Drawing.Point(7, 88);
            this.StatPropLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatPropLabel2.Name = "StatPropLabel2";
            this.StatPropLabel2.Size = new System.Drawing.Size(64, 21);
            this.StatPropLabel2.TabIndex = 17;
            this.StatPropLabel2.Text = "Entries: ";
            this.StatPropLabel2.Visible = false;
            this.StatPropLabel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // StatPropText1
            // 
            this.StatPropText1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.StatPropText1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatPropText1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatPropText1.Location = new System.Drawing.Point(11, 56);
            this.StatPropText1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.StatPropText1.Name = "StatPropText1";
            this.StatPropText1.ReadOnly = true;
            this.StatPropText1.Size = new System.Drawing.Size(192, 22);
            this.StatPropText1.TabIndex = 16;
            this.StatPropText1.Visible = false;
            // 
            // StatPropLabel1
            // 
            this.StatPropLabel1.AutoSize = true;
            this.StatPropLabel1.Enabled = false;
            this.StatPropLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatPropLabel1.Location = new System.Drawing.Point(7, 35);
            this.StatPropLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatPropLabel1.Name = "StatPropLabel1";
            this.StatPropLabel1.Size = new System.Drawing.Size(64, 21);
            this.StatPropLabel1.TabIndex = 15;
            this.StatPropLabel1.Text = "Entries: ";
            this.StatPropLabel1.Visible = false;
            this.StatPropLabel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1007, 725);
            this.Controls.Add(this.StatsGroupBox);
            this.Controls.Add(this.Filter2Label);
            this.Controls.Add(this.Filter2Combo);
            this.Controls.Add(this.Filter1Label);
            this.Controls.Add(this.Filter1Combo);
            this.Controls.Add(this.ReportTypeSelectorCombo);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.DateGroupBox);
            this.Controls.Add(this.ReportsGrid);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            this.DateGroupBox.ResumeLayout(false);
            this.DateGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportsGrid)).EndInit();
            this.StatsGroupBox.ResumeLayout(false);
            this.StatsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Filter2Label;
        private System.Windows.Forms.ComboBox Filter2Combo;
        private System.Windows.Forms.Label Filter1Label;
        private System.Windows.Forms.ComboBox Filter1Combo;
        private System.Windows.Forms.ComboBox ReportTypeSelectorCombo;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.GroupBox DateGroupBox;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.DateTimePicker ToDateTime;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.DateTimePicker FromDateTime;
        private System.Windows.Forms.DataGridView ReportsGrid;
        private System.Windows.Forms.GroupBox StatsGroupBox;
        private System.Windows.Forms.Label StatPropLabel1;
        private System.Windows.Forms.TextBox StatPropText7;
        private System.Windows.Forms.Label StatPropLabel7;
        private System.Windows.Forms.TextBox StatPropText6;
        private System.Windows.Forms.Label StatPropLabel6;
        private System.Windows.Forms.TextBox StatPropText5;
        private System.Windows.Forms.Label StatPropLabel5;
        private System.Windows.Forms.TextBox StatPropText4;
        private System.Windows.Forms.Label StatPropLabel4;
        private System.Windows.Forms.TextBox StatPropText3;
        private System.Windows.Forms.Label StatPropLabel3;
        private System.Windows.Forms.TextBox StatPropText2;
        private System.Windows.Forms.Label StatPropLabel2;
        private System.Windows.Forms.TextBox StatPropText1;
        private System.Windows.Forms.TextBox StatPropText10;
        private System.Windows.Forms.Label StatPropLabel10;
        private System.Windows.Forms.TextBox StatPropText9;
        private System.Windows.Forms.Label StatPropLabel9;
        private System.Windows.Forms.TextBox StatPropText8;
        private System.Windows.Forms.Label StatPropLabel8;
    }
}