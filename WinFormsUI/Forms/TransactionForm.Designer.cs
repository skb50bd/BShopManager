namespace WinFormsUI.Forms
{
    partial class TransactionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AccountSelectorCombo = new System.Windows.Forms.ComboBox();
            this.AccountLabel = new System.Windows.Forms.Label();
            this.TransactionDateTime = new System.Windows.Forms.DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
            this.TypeSelectorCombo = new System.Windows.Forms.ComboBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.AmountText = new System.Windows.Forms.TextBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.IndividualLabel = new System.Windows.Forms.Label();
            this.TransactionCodeText = new System.Windows.Forms.TextBox();
            this.IndividualCombo = new System.Windows.Forms.ComboBox();
            this.TramsactionCodeLabel = new System.Windows.Forms.Label();
            this.CheckNoLabel = new System.Windows.Forms.Label();
            this.CheckNoText = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.NoteText = new System.Windows.Forms.RichTextBox();
            this.ControlsGroupBox = new System.Windows.Forms.GroupBox();
            this.ControlsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semi Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(6, 7);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(193, 47);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Transaction";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // AccountSelectorCombo
            // 
            this.AccountSelectorCombo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AccountSelectorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccountSelectorCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountSelectorCombo.FormattingEnabled = true;
            this.AccountSelectorCombo.Location = new System.Drawing.Point(154, 56);
            this.AccountSelectorCombo.Margin = new System.Windows.Forms.Padding(5);
            this.AccountSelectorCombo.Name = "AccountSelectorCombo";
            this.AccountSelectorCombo.Size = new System.Drawing.Size(260, 29);
            this.AccountSelectorCombo.TabIndex = 3;
            // 
            // AccountLabel
            // 
            this.AccountLabel.AutoSize = true;
            this.AccountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountLabel.Location = new System.Drawing.Point(8, 59);
            this.AccountLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AccountLabel.Name = "AccountLabel";
            this.AccountLabel.Size = new System.Drawing.Size(73, 21);
            this.AccountLabel.TabIndex = 2;
            this.AccountLabel.Text = "Account :";
            this.AccountLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TransactionDateTime
            // 
            this.TransactionDateTime.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.TransactionDateTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TransactionDateTime.Location = new System.Drawing.Point(154, 21);
            this.TransactionDateTime.Margin = new System.Windows.Forms.Padding(5);
            this.TransactionDateTime.Name = "TransactionDateTime";
            this.TransactionDateTime.Size = new System.Drawing.Size(260, 29);
            this.TransactionDateTime.TabIndex = 1;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(8, 27);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(49, 21);
            this.DateLabel.TabIndex = 0;
            this.DateLabel.Text = "Date :";
            this.DateLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TypeSelectorCombo
            // 
            this.TypeSelectorCombo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TypeSelectorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeSelectorCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeSelectorCombo.FormattingEnabled = true;
            this.TypeSelectorCombo.Items.AddRange(new object[] {
            "Deposit",
            "Withdrawal"});
            this.TypeSelectorCombo.Location = new System.Drawing.Point(154, 88);
            this.TypeSelectorCombo.Margin = new System.Windows.Forms.Padding(5);
            this.TypeSelectorCombo.Name = "TypeSelectorCombo";
            this.TypeSelectorCombo.Size = new System.Drawing.Size(260, 29);
            this.TypeSelectorCombo.TabIndex = 5;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.Location = new System.Drawing.Point(8, 91);
            this.TypeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(49, 21);
            this.TypeLabel.TabIndex = 4;
            this.TypeLabel.Text = "Type :";
            this.TypeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // AmountText
            // 
            this.AmountText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AmountText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AmountText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountText.Location = new System.Drawing.Point(153, 123);
            this.AmountText.Margin = new System.Windows.Forms.Padding(5);
            this.AmountText.Name = "AmountText";
            this.AmountText.Size = new System.Drawing.Size(261, 22);
            this.AmountText.TabIndex = 7;
            this.AmountText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.Location = new System.Drawing.Point(8, 123);
            this.AmountLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(73, 21);
            this.AmountLabel.TabIndex = 6;
            this.AmountLabel.Text = "Amount :";
            this.AmountLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // IndividualLabel
            // 
            this.IndividualLabel.AutoSize = true;
            this.IndividualLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndividualLabel.Location = new System.Drawing.Point(8, 155);
            this.IndividualLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.IndividualLabel.Name = "IndividualLabel";
            this.IndividualLabel.Size = new System.Drawing.Size(85, 21);
            this.IndividualLabel.TabIndex = 8;
            this.IndividualLabel.Text = "Individual :";
            this.IndividualLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TransactionCodeText
            // 
            this.TransactionCodeText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TransactionCodeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TransactionCodeText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionCodeText.Location = new System.Drawing.Point(153, 187);
            this.TransactionCodeText.Margin = new System.Windows.Forms.Padding(5);
            this.TransactionCodeText.Name = "TransactionCodeText";
            this.TransactionCodeText.Size = new System.Drawing.Size(261, 22);
            this.TransactionCodeText.TabIndex = 11;
            // 
            // IndividualCombo
            // 
            this.IndividualCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.IndividualCombo.BackColor = System.Drawing.Color.White;
            this.IndividualCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndividualCombo.FormattingEnabled = true;
            this.IndividualCombo.Location = new System.Drawing.Point(154, 152);
            this.IndividualCombo.Margin = new System.Windows.Forms.Padding(5);
            this.IndividualCombo.Name = "IndividualCombo";
            this.IndividualCombo.Size = new System.Drawing.Size(260, 29);
            this.IndividualCombo.TabIndex = 9;
            // 
            // TramsactionCodeLabel
            // 
            this.TramsactionCodeLabel.AutoSize = true;
            this.TramsactionCodeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TramsactionCodeLabel.Location = new System.Drawing.Point(8, 187);
            this.TramsactionCodeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TramsactionCodeLabel.Name = "TramsactionCodeLabel";
            this.TramsactionCodeLabel.Size = new System.Drawing.Size(136, 21);
            this.TramsactionCodeLabel.TabIndex = 10;
            this.TramsactionCodeLabel.Text = "Transaction Code :";
            this.TramsactionCodeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // CheckNoLabel
            // 
            this.CheckNoLabel.AutoSize = true;
            this.CheckNoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckNoLabel.Location = new System.Drawing.Point(8, 219);
            this.CheckNoLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CheckNoLabel.Name = "CheckNoLabel";
            this.CheckNoLabel.Size = new System.Drawing.Size(87, 21);
            this.CheckNoLabel.TabIndex = 12;
            this.CheckNoLabel.Text = "Check No. :";
            this.CheckNoLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // CheckNoText
            // 
            this.CheckNoText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CheckNoText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CheckNoText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckNoText.Location = new System.Drawing.Point(154, 219);
            this.CheckNoText.Margin = new System.Windows.Forms.Padding(5);
            this.CheckNoText.Name = "CheckNoText";
            this.CheckNoText.Size = new System.Drawing.Size(261, 22);
            this.CheckNoText.TabIndex = 13;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveButton.Location = new System.Drawing.Point(12, 342);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(403, 42);
            this.SaveButton.TabIndex = 16;
            this.SaveButton.Text = "Submit";
            this.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteLabel.Location = new System.Drawing.Point(8, 251);
            this.NoteLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(51, 21);
            this.NoteLabel.TabIndex = 14;
            this.NoteLabel.Text = "Note :";
            this.NoteLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // NoteText
            // 
            this.NoteText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NoteText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NoteText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteText.Location = new System.Drawing.Point(153, 251);
            this.NoteText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.NoteText.Name = "NoteText";
            this.NoteText.Size = new System.Drawing.Size(261, 78);
            this.NoteText.TabIndex = 15;
            this.NoteText.Text = "";
            // 
            // ControlsGroupBox
            // 
            this.ControlsGroupBox.Controls.Add(this.NoteText);
            this.ControlsGroupBox.Controls.Add(this.NoteLabel);
            this.ControlsGroupBox.Controls.Add(this.SaveButton);
            this.ControlsGroupBox.Controls.Add(this.CheckNoLabel);
            this.ControlsGroupBox.Controls.Add(this.CheckNoText);
            this.ControlsGroupBox.Controls.Add(this.TramsactionCodeLabel);
            this.ControlsGroupBox.Controls.Add(this.IndividualCombo);
            this.ControlsGroupBox.Controls.Add(this.TransactionCodeText);
            this.ControlsGroupBox.Controls.Add(this.IndividualLabel);
            this.ControlsGroupBox.Controls.Add(this.AmountLabel);
            this.ControlsGroupBox.Controls.Add(this.AmountText);
            this.ControlsGroupBox.Controls.Add(this.TypeSelectorCombo);
            this.ControlsGroupBox.Controls.Add(this.TypeLabel);
            this.ControlsGroupBox.Controls.Add(this.DateLabel);
            this.ControlsGroupBox.Controls.Add(this.TransactionDateTime);
            this.ControlsGroupBox.Controls.Add(this.AccountSelectorCombo);
            this.ControlsGroupBox.Controls.Add(this.AccountLabel);
            this.ControlsGroupBox.Location = new System.Drawing.Point(3, 46);
            this.ControlsGroupBox.Name = "ControlsGroupBox";
            this.ControlsGroupBox.Size = new System.Drawing.Size(427, 395);
            this.ControlsGroupBox.TabIndex = 1;
            this.ControlsGroupBox.TabStop = false;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(433, 442);
            this.Controls.Add(this.ControlsGroupBox);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TransactionForm";
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            this.ControlsGroupBox.ResumeLayout(false);
            this.ControlsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ComboBox AccountSelectorCombo;
        private System.Windows.Forms.Label AccountLabel;
        private System.Windows.Forms.DateTimePicker TransactionDateTime;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.ComboBox TypeSelectorCombo;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.TextBox AmountText;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label IndividualLabel;
        private System.Windows.Forms.TextBox TransactionCodeText;
        private System.Windows.Forms.ComboBox IndividualCombo;
        private System.Windows.Forms.Label TramsactionCodeLabel;
        private System.Windows.Forms.Label CheckNoLabel;
        private System.Windows.Forms.TextBox CheckNoText;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label NoteLabel;
        private System.Windows.Forms.RichTextBox NoteText;
        private System.Windows.Forms.GroupBox ControlsGroupBox;
    }
}