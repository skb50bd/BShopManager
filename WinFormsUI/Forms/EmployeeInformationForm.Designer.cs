namespace WinFormsUI.Forms {
    partial class EmployeeInformationForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeInformationForm));
            this.CurrentBalanceText = new System.Windows.Forms.TextBox();
            this.CurrentBalanceLabel = new System.Windows.Forms.Label();
            this.PayButton = new System.Windows.Forms.Button();
            this.PaySalaryLabel = new System.Windows.Forms.Label();
            this.CurrentBalanceTextBig = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DesignationText = new System.Windows.Forms.TextBox();
            this.DesignationLabel = new System.Windows.Forms.Label();
            this.ContactNumberText = new System.Windows.Forms.TextBox();
            this.ContactNumberLabel = new System.Windows.Forms.Label();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.FullNameText = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.SalaryAmountText = new System.Windows.Forms.TextBox();
            this.CurrentBalanceLabelBig = new System.Windows.Forms.Label();
            this.EmailAddressText = new System.Windows.Forms.TextBox();
            this.EmailAddressLabel = new System.Windows.Forms.Label();
            this.NickNameText = new System.Windows.Forms.TextBox();
            this.NickNameLabel = new System.Windows.Forms.Label();
            this.NotesText = new System.Windows.Forms.RichTextBox();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.NidText = new System.Windows.Forms.TextBox();
            this.NidLabel = new System.Windows.Forms.Label();
            this.MonthlySalaryText = new System.Windows.Forms.TextBox();
            this.MonthlySalaryLabel = new System.Windows.Forms.Label();
            this.JoinDateLabel = new System.Windows.Forms.Label();
            this.JoinDateTime = new System.Windows.Forms.DateTimePicker();
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.PaymentGroupBox = new System.Windows.Forms.GroupBox();
            this.InfoGroupBox.SuspendLayout();
            this.PaymentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CurrentBalanceText
            // 
            resources.ApplyResources(this.CurrentBalanceText, "CurrentBalanceText");
            this.CurrentBalanceText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CurrentBalanceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrentBalanceText.Name = "CurrentBalanceText";
            this.CurrentBalanceText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // CurrentBalanceLabel
            // 
            resources.ApplyResources(this.CurrentBalanceLabel, "CurrentBalanceLabel");
            this.CurrentBalanceLabel.Name = "CurrentBalanceLabel";
            this.CurrentBalanceLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // PayButton
            // 
            resources.ApplyResources(this.PayButton, "PayButton");
            this.PayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.PayButton.FlatAppearance.BorderSize = 0;
            this.PayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.PayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            this.PayButton.ForeColor = System.Drawing.Color.White;
            this.PayButton.Name = "PayButton";
            this.PayButton.UseVisualStyleBackColor = false;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // PaySalaryLabel
            // 
            resources.ApplyResources(this.PaySalaryLabel, "PaySalaryLabel");
            this.PaySalaryLabel.Name = "PaySalaryLabel";
            this.PaySalaryLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // CurrentBalanceTextBig
            // 
            resources.ApplyResources(this.CurrentBalanceTextBig, "CurrentBalanceTextBig");
            this.CurrentBalanceTextBig.Name = "CurrentBalanceTextBig";
            this.CurrentBalanceTextBig.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
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
            // DesignationText
            // 
            resources.ApplyResources(this.DesignationText, "DesignationText");
            this.DesignationText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DesignationText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DesignationText.Name = "DesignationText";
            // 
            // DesignationLabel
            // 
            resources.ApplyResources(this.DesignationLabel, "DesignationLabel");
            this.DesignationLabel.Name = "DesignationLabel";
            this.DesignationLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // ContactNumberText
            // 
            resources.ApplyResources(this.ContactNumberText, "ContactNumberText");
            this.ContactNumberText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ContactNumberText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContactNumberText.Name = "ContactNumberText";
            // 
            // ContactNumberLabel
            // 
            resources.ApplyResources(this.ContactNumberLabel, "ContactNumberLabel");
            this.ContactNumberLabel.Name = "ContactNumberLabel";
            this.ContactNumberLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // AddressText
            // 
            resources.ApplyResources(this.AddressText, "AddressText");
            this.AddressText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddressText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressText.Name = "AddressText";
            // 
            // AddressLabel
            // 
            resources.ApplyResources(this.AddressLabel, "AddressLabel");
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TitleLabel
            // 
            resources.ApplyResources(this.TitleLabel, "TitleLabel");
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // FullNameText
            // 
            resources.ApplyResources(this.FullNameText, "FullNameText");
            this.FullNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FullNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FullNameText.Name = "FullNameText";
            // 
            // FullNameLabel
            // 
            resources.ApplyResources(this.FullNameLabel, "FullNameLabel");
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // SalaryAmountText
            // 
            resources.ApplyResources(this.SalaryAmountText, "SalaryAmountText");
            this.SalaryAmountText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SalaryAmountText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SalaryAmountText.Name = "SalaryAmountText";
            this.SalaryAmountText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // CurrentBalanceLabelBig
            // 
            resources.ApplyResources(this.CurrentBalanceLabelBig, "CurrentBalanceLabelBig");
            this.CurrentBalanceLabelBig.Name = "CurrentBalanceLabelBig";
            this.CurrentBalanceLabelBig.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // EmailAddressText
            // 
            resources.ApplyResources(this.EmailAddressText, "EmailAddressText");
            this.EmailAddressText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EmailAddressText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailAddressText.Name = "EmailAddressText";
            // 
            // EmailAddressLabel
            // 
            resources.ApplyResources(this.EmailAddressLabel, "EmailAddressLabel");
            this.EmailAddressLabel.Name = "EmailAddressLabel";
            this.EmailAddressLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // NickNameText
            // 
            resources.ApplyResources(this.NickNameText, "NickNameText");
            this.NickNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NickNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NickNameText.Name = "NickNameText";
            // 
            // NickNameLabel
            // 
            resources.ApplyResources(this.NickNameLabel, "NickNameLabel");
            this.NickNameLabel.Name = "NickNameLabel";
            this.NickNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // NotesText
            // 
            resources.ApplyResources(this.NotesText, "NotesText");
            this.NotesText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NotesText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NotesText.Name = "NotesText";
            // 
            // NotesLabel
            // 
            resources.ApplyResources(this.NotesLabel, "NotesLabel");
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // NidText
            // 
            resources.ApplyResources(this.NidText, "NidText");
            this.NidText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NidText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NidText.Name = "NidText";
            // 
            // NidLabel
            // 
            resources.ApplyResources(this.NidLabel, "NidLabel");
            this.NidLabel.Name = "NidLabel";
            this.NidLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // MonthlySalaryText
            // 
            resources.ApplyResources(this.MonthlySalaryText, "MonthlySalaryText");
            this.MonthlySalaryText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MonthlySalaryText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MonthlySalaryText.Name = "MonthlySalaryText";
            this.MonthlySalaryText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // MonthlySalaryLabel
            // 
            resources.ApplyResources(this.MonthlySalaryLabel, "MonthlySalaryLabel");
            this.MonthlySalaryLabel.Name = "MonthlySalaryLabel";
            this.MonthlySalaryLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // JoinDateLabel
            // 
            resources.ApplyResources(this.JoinDateLabel, "JoinDateLabel");
            this.JoinDateLabel.Name = "JoinDateLabel";
            this.JoinDateLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // JoinDateTime
            // 
            resources.ApplyResources(this.JoinDateTime, "JoinDateTime");
            this.JoinDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.JoinDateTime.Name = "JoinDateTime";
            // 
            // InfoGroupBox
            // 
            resources.ApplyResources(this.InfoGroupBox, "InfoGroupBox");
            this.InfoGroupBox.Controls.Add(this.JoinDateTime);
            this.InfoGroupBox.Controls.Add(this.JoinDateLabel);
            this.InfoGroupBox.Controls.Add(this.MonthlySalaryText);
            this.InfoGroupBox.Controls.Add(this.MonthlySalaryLabel);
            this.InfoGroupBox.Controls.Add(this.NidText);
            this.InfoGroupBox.Controls.Add(this.NidLabel);
            this.InfoGroupBox.Controls.Add(this.NotesText);
            this.InfoGroupBox.Controls.Add(this.NotesLabel);
            this.InfoGroupBox.Controls.Add(this.CurrentBalanceText);
            this.InfoGroupBox.Controls.Add(this.CurrentBalanceLabel);
            this.InfoGroupBox.Controls.Add(this.SaveButton);
            this.InfoGroupBox.Controls.Add(this.DesignationText);
            this.InfoGroupBox.Controls.Add(this.DesignationLabel);
            this.InfoGroupBox.Controls.Add(this.ContactNumberText);
            this.InfoGroupBox.Controls.Add(this.ContactNumberLabel);
            this.InfoGroupBox.Controls.Add(this.AddressText);
            this.InfoGroupBox.Controls.Add(this.AddressLabel);
            this.InfoGroupBox.Controls.Add(this.FullNameText);
            this.InfoGroupBox.Controls.Add(this.FullNameLabel);
            this.InfoGroupBox.Controls.Add(this.EmailAddressText);
            this.InfoGroupBox.Controls.Add(this.EmailAddressLabel);
            this.InfoGroupBox.Controls.Add(this.NickNameText);
            this.InfoGroupBox.Controls.Add(this.NickNameLabel);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.TabStop = false;
            // 
            // PaymentGroupBox
            // 
            resources.ApplyResources(this.PaymentGroupBox, "PaymentGroupBox");
            this.PaymentGroupBox.Controls.Add(this.CurrentBalanceLabelBig);
            this.PaymentGroupBox.Controls.Add(this.PayButton);
            this.PaymentGroupBox.Controls.Add(this.SalaryAmountText);
            this.PaymentGroupBox.Controls.Add(this.PaySalaryLabel);
            this.PaymentGroupBox.Controls.Add(this.CurrentBalanceTextBig);
            this.PaymentGroupBox.Name = "PaymentGroupBox";
            this.PaymentGroupBox.TabStop = false;
            // 
            // EmployeeInformationForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PaymentGroupBox);
            this.Controls.Add(this.InfoGroupBox);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EmployeeInformationForm";
            this.Load += new System.EventHandler(this.EmployeeInformationForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            this.InfoGroupBox.ResumeLayout(false);
            this.InfoGroupBox.PerformLayout();
            this.PaymentGroupBox.ResumeLayout(false);
            this.PaymentGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CurrentBalanceText;
        private System.Windows.Forms.Label CurrentBalanceLabel;
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.Label PaySalaryLabel;
        private System.Windows.Forms.Label CurrentBalanceTextBig;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox DesignationText;
        private System.Windows.Forms.Label DesignationLabel;
        private System.Windows.Forms.TextBox ContactNumberText;
        private System.Windows.Forms.Label ContactNumberLabel;
        private System.Windows.Forms.TextBox AddressText;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox FullNameText;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.TextBox SalaryAmountText;
        private System.Windows.Forms.Label CurrentBalanceLabelBig;
        private System.Windows.Forms.TextBox EmailAddressText;
        private System.Windows.Forms.Label EmailAddressLabel;
        private System.Windows.Forms.TextBox NickNameText;
        private System.Windows.Forms.Label NickNameLabel;
        private System.Windows.Forms.RichTextBox NotesText;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.TextBox NidText;
        private System.Windows.Forms.Label NidLabel;
        private System.Windows.Forms.TextBox MonthlySalaryText;
        private System.Windows.Forms.Label MonthlySalaryLabel;
        private System.Windows.Forms.Label JoinDateLabel;
        private System.Windows.Forms.DateTimePicker JoinDateTime;
        private System.Windows.Forms.GroupBox InfoGroupBox;
        private System.Windows.Forms.GroupBox PaymentGroupBox;
    }
}