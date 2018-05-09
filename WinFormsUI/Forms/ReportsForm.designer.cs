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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Filter1Label = new System.Windows.Forms.Label();
            this.Filter2Label = new System.Windows.Forms.Label();
            this.Filter1Combo = new System.Windows.Forms.ComboBox();
            this.Filter2Combo = new System.Windows.Forms.ComboBox();
            this.ReportTypeSelectorCombo = new System.Windows.Forms.ComboBox();
            this.PrintButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.DateGroupBox = new System.Windows.Forms.GroupBox();
            this.LoadButton = new System.Windows.Forms.Button();
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
            resources.ApplyResources(this.Filter1Label, "Filter1Label");
            this.Filter1Label.Name = "Filter1Label";
            this.Filter1Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // Filter2Label
            // 
            resources.ApplyResources(this.Filter2Label, "Filter2Label");
            this.Filter2Label.Name = "Filter2Label";
            this.Filter2Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // Filter1Combo
            // 
            this.Filter1Combo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Filter1Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.Filter1Combo, "Filter1Combo");
            this.Filter1Combo.FormattingEnabled = true;
            this.Filter1Combo.Name = "Filter1Combo";
            this.Filter1Combo.SelectedIndexChanged += new System.EventHandler(this.Filter1Combo_SelectedIndexChanged);
            // 
            // Filter2Combo
            // 
            this.Filter2Combo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.Filter2Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.Filter2Combo, "Filter2Combo");
            this.Filter2Combo.FormattingEnabled = true;
            this.Filter2Combo.Name = "Filter2Combo";
            this.Filter2Combo.SelectedIndexChanged += new System.EventHandler(this.Filter2Combo_SelectedIndexChanged);
            // 
            // ReportTypeSelectorCombo
            // 
            this.ReportTypeSelectorCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ReportTypeSelectorCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ReportTypeSelectorCombo.BackColor = System.Drawing.Color.White;
            this.ReportTypeSelectorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.ReportTypeSelectorCombo, "ReportTypeSelectorCombo");
            this.ReportTypeSelectorCombo.FormattingEnabled = true;
            this.ReportTypeSelectorCombo.Items.AddRange(new object[] {
            resources.GetString("ReportTypeSelectorCombo.Items"),
            resources.GetString("ReportTypeSelectorCombo.Items1"),
            resources.GetString("ReportTypeSelectorCombo.Items2"),
            resources.GetString("ReportTypeSelectorCombo.Items3"),
            resources.GetString("ReportTypeSelectorCombo.Items4"),
            resources.GetString("ReportTypeSelectorCombo.Items5"),
            resources.GetString("ReportTypeSelectorCombo.Items6"),
            resources.GetString("ReportTypeSelectorCombo.Items7"),
            resources.GetString("ReportTypeSelectorCombo.Items8"),
            resources.GetString("ReportTypeSelectorCombo.Items9"),
            resources.GetString("ReportTypeSelectorCombo.Items10"),
            resources.GetString("ReportTypeSelectorCombo.Items11"),
            resources.GetString("ReportTypeSelectorCombo.Items12"),
            resources.GetString("ReportTypeSelectorCombo.Items13")});
            this.ReportTypeSelectorCombo.Name = "ReportTypeSelectorCombo";
            this.ReportTypeSelectorCombo.SelectedIndexChanged += new System.EventHandler(this.ReportTypeSelectorCombo_SelectedIndexChanged);
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
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(135)))));
            resources.ApplyResources(this.DeleteButton, "DeleteButton");
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ViewButton
            // 
            this.ViewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.ViewButton.FlatAppearance.BorderSize = 0;
            this.ViewButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.ViewButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            resources.ApplyResources(this.ViewButton, "ViewButton");
            this.ViewButton.ForeColor = System.Drawing.Color.White;
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.UseVisualStyleBackColor = false;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // DateGroupBox
            // 
            this.DateGroupBox.Controls.Add(this.LoadButton);
            this.DateGroupBox.Controls.Add(this.ToDateTime);
            this.DateGroupBox.Controls.Add(this.FromLabel);
            this.DateGroupBox.Controls.Add(this.FromDateTime);
            this.DateGroupBox.Controls.Add(this.ToLabel);
            resources.ApplyResources(this.DateGroupBox, "DateGroupBox");
            this.DateGroupBox.Name = "DateGroupBox";
            this.DateGroupBox.TabStop = false;
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.LoadButton.FlatAppearance.BorderSize = 0;
            this.LoadButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.LoadButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            this.LoadButton.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.LoadButton, "LoadButton");
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // ToDateTime
            // 
            resources.ApplyResources(this.ToDateTime, "ToDateTime");
            this.ToDateTime.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.ToDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDateTime.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.ToDateTime.Name = "ToDateTime";
            this.ToDateTime.Value = new System.DateTime(2018, 12, 25, 0, 0, 0, 0);
            this.ToDateTime.ValueChanged += new System.EventHandler(this.ToDateTime_ValueChanged);
            // 
            // FromLabel
            // 
            resources.ApplyResources(this.FromLabel, "FromLabel");
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // FromDateTime
            // 
            resources.ApplyResources(this.FromDateTime, "FromDateTime");
            this.FromDateTime.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.FromDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromDateTime.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.FromDateTime.Name = "FromDateTime";
            this.FromDateTime.Value = new System.DateTime(2018, 12, 25, 0, 0, 0, 0);
            this.FromDateTime.ValueChanged += new System.EventHandler(this.FromDateTime_ValueChanged);
            // 
            // ToLabel
            // 
            resources.ApplyResources(this.ToLabel, "ToLabel");
            this.ToLabel.Name = "ToLabel";
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReportsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ReportsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReportsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.ReportsGrid.GridColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.ReportsGrid, "ReportsGrid");
            this.ReportsGrid.Name = "ReportsGrid";
            this.ReportsGrid.RowHeadersVisible = false;
            this.ReportsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            resources.ApplyResources(this.StatsGroupBox, "StatsGroupBox");
            this.StatsGroupBox.Name = "StatsGroupBox";
            this.StatsGroupBox.TabStop = false;
            // 
            // StatPropText10
            // 
            this.StatPropText10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.StatPropText10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.StatPropText10, "StatPropText10");
            this.StatPropText10.Name = "StatPropText10";
            this.StatPropText10.ReadOnly = true;
            // 
            // StatPropLabel10
            // 
            resources.ApplyResources(this.StatPropLabel10, "StatPropLabel10");
            this.StatPropLabel10.Name = "StatPropLabel10";
            this.StatPropLabel10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // StatPropText9
            // 
            this.StatPropText9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.StatPropText9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.StatPropText9, "StatPropText9");
            this.StatPropText9.Name = "StatPropText9";
            this.StatPropText9.ReadOnly = true;
            // 
            // StatPropLabel9
            // 
            resources.ApplyResources(this.StatPropLabel9, "StatPropLabel9");
            this.StatPropLabel9.Name = "StatPropLabel9";
            this.StatPropLabel9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // StatPropText8
            // 
            this.StatPropText8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.StatPropText8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.StatPropText8, "StatPropText8");
            this.StatPropText8.Name = "StatPropText8";
            this.StatPropText8.ReadOnly = true;
            // 
            // StatPropLabel8
            // 
            resources.ApplyResources(this.StatPropLabel8, "StatPropLabel8");
            this.StatPropLabel8.Name = "StatPropLabel8";
            this.StatPropLabel8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // StatPropText7
            // 
            this.StatPropText7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.StatPropText7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.StatPropText7, "StatPropText7");
            this.StatPropText7.Name = "StatPropText7";
            this.StatPropText7.ReadOnly = true;
            // 
            // StatPropLabel7
            // 
            resources.ApplyResources(this.StatPropLabel7, "StatPropLabel7");
            this.StatPropLabel7.Name = "StatPropLabel7";
            this.StatPropLabel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // StatPropText6
            // 
            this.StatPropText6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.StatPropText6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.StatPropText6, "StatPropText6");
            this.StatPropText6.Name = "StatPropText6";
            this.StatPropText6.ReadOnly = true;
            // 
            // StatPropLabel6
            // 
            resources.ApplyResources(this.StatPropLabel6, "StatPropLabel6");
            this.StatPropLabel6.Name = "StatPropLabel6";
            this.StatPropLabel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // StatPropText5
            // 
            this.StatPropText5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.StatPropText5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.StatPropText5, "StatPropText5");
            this.StatPropText5.Name = "StatPropText5";
            this.StatPropText5.ReadOnly = true;
            // 
            // StatPropLabel5
            // 
            resources.ApplyResources(this.StatPropLabel5, "StatPropLabel5");
            this.StatPropLabel5.Name = "StatPropLabel5";
            this.StatPropLabel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // StatPropText4
            // 
            this.StatPropText4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.StatPropText4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.StatPropText4, "StatPropText4");
            this.StatPropText4.Name = "StatPropText4";
            this.StatPropText4.ReadOnly = true;
            // 
            // StatPropLabel4
            // 
            resources.ApplyResources(this.StatPropLabel4, "StatPropLabel4");
            this.StatPropLabel4.Name = "StatPropLabel4";
            this.StatPropLabel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // StatPropText3
            // 
            this.StatPropText3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.StatPropText3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.StatPropText3, "StatPropText3");
            this.StatPropText3.Name = "StatPropText3";
            this.StatPropText3.ReadOnly = true;
            // 
            // StatPropLabel3
            // 
            resources.ApplyResources(this.StatPropLabel3, "StatPropLabel3");
            this.StatPropLabel3.Name = "StatPropLabel3";
            this.StatPropLabel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // StatPropText2
            // 
            this.StatPropText2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.StatPropText2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.StatPropText2, "StatPropText2");
            this.StatPropText2.Name = "StatPropText2";
            this.StatPropText2.ReadOnly = true;
            // 
            // StatPropLabel2
            // 
            resources.ApplyResources(this.StatPropLabel2, "StatPropLabel2");
            this.StatPropLabel2.Name = "StatPropLabel2";
            this.StatPropLabel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // StatPropText1
            // 
            this.StatPropText1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.StatPropText1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.StatPropText1, "StatPropText1");
            this.StatPropText1.Name = "StatPropText1";
            this.StatPropText1.ReadOnly = true;
            // 
            // StatPropLabel1
            // 
            resources.ApplyResources(this.StatPropLabel1, "StatPropLabel1");
            this.StatPropLabel1.Name = "StatPropLabel1";
            this.StatPropLabel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // ReportsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReportsForm";
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
        private System.Windows.Forms.Button LoadButton;
    }
}