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
            resources.ApplyResources(this.TitleLabel, "TitleLabel");
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // AccountSelectorCombo
            // 
            resources.ApplyResources(this.AccountSelectorCombo, "AccountSelectorCombo");
            this.AccountSelectorCombo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AccountSelectorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccountSelectorCombo.FormattingEnabled = true;
            this.AccountSelectorCombo.Name = "AccountSelectorCombo";
            // 
            // AccountLabel
            // 
            resources.ApplyResources(this.AccountLabel, "AccountLabel");
            this.AccountLabel.Name = "AccountLabel";
            this.AccountLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TransactionDateTime
            // 
            resources.ApplyResources(this.TransactionDateTime, "TransactionDateTime");
            this.TransactionDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TransactionDateTime.Name = "TransactionDateTime";
            // 
            // DateLabel
            // 
            resources.ApplyResources(this.DateLabel, "DateLabel");
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TypeSelectorCombo
            // 
            resources.ApplyResources(this.TypeSelectorCombo, "TypeSelectorCombo");
            this.TypeSelectorCombo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TypeSelectorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeSelectorCombo.FormattingEnabled = true;
            this.TypeSelectorCombo.Items.AddRange(new object[] {
            resources.GetString("TypeSelectorCombo.Items"),
            resources.GetString("TypeSelectorCombo.Items1")});
            this.TypeSelectorCombo.Name = "TypeSelectorCombo";
            // 
            // TypeLabel
            // 
            resources.ApplyResources(this.TypeLabel, "TypeLabel");
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // AmountText
            // 
            resources.ApplyResources(this.AmountText, "AmountText");
            this.AmountText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AmountText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AmountText.Name = "AmountText";
            this.AmountText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // AmountLabel
            // 
            resources.ApplyResources(this.AmountLabel, "AmountLabel");
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // IndividualLabel
            // 
            resources.ApplyResources(this.IndividualLabel, "IndividualLabel");
            this.IndividualLabel.Name = "IndividualLabel";
            this.IndividualLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TransactionCodeText
            // 
            resources.ApplyResources(this.TransactionCodeText, "TransactionCodeText");
            this.TransactionCodeText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TransactionCodeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TransactionCodeText.Name = "TransactionCodeText";
            // 
            // IndividualCombo
            // 
            resources.ApplyResources(this.IndividualCombo, "IndividualCombo");
            this.IndividualCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.IndividualCombo.BackColor = System.Drawing.Color.White;
            this.IndividualCombo.FormattingEnabled = true;
            this.IndividualCombo.Name = "IndividualCombo";
            // 
            // TramsactionCodeLabel
            // 
            resources.ApplyResources(this.TramsactionCodeLabel, "TramsactionCodeLabel");
            this.TramsactionCodeLabel.Name = "TramsactionCodeLabel";
            this.TramsactionCodeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // CheckNoLabel
            // 
            resources.ApplyResources(this.CheckNoLabel, "CheckNoLabel");
            this.CheckNoLabel.Name = "CheckNoLabel";
            this.CheckNoLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // CheckNoText
            // 
            resources.ApplyResources(this.CheckNoText, "CheckNoText");
            this.CheckNoText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CheckNoText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CheckNoText.Name = "CheckNoText";
            // 
            // SaveButton
            // 
            resources.ApplyResources(this.SaveButton, "SaveButton");
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NoteLabel
            // 
            resources.ApplyResources(this.NoteLabel, "NoteLabel");
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // NoteText
            // 
            resources.ApplyResources(this.NoteText, "NoteText");
            this.NoteText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NoteText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NoteText.Name = "NoteText";
            // 
            // ControlsGroupBox
            // 
            resources.ApplyResources(this.ControlsGroupBox, "ControlsGroupBox");
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
            this.ControlsGroupBox.Name = "ControlsGroupBox";
            this.ControlsGroupBox.TabStop = false;
            // 
            // TransactionForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ControlsGroupBox);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TransactionForm";
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