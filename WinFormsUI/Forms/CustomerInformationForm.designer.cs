namespace WinFormsUI.Forms
{
    partial class CustomerInformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerInformationForm));
            this.FullNameText = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.CashReceivedText = new System.Windows.Forms.TextBox();
            this.CurrentDueLabelBig = new System.Windows.Forms.Label();
            this.EmailAddressText = new System.Windows.Forms.TextBox();
            this.EmailAddressLabel = new System.Windows.Forms.Label();
            this.NickNameText = new System.Windows.Forms.TextBox();
            this.NickNameLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.ContactNumberText = new System.Windows.Forms.TextBox();
            this.ContactNumberLabel = new System.Windows.Forms.Label();
            this.CompanyText = new System.Windows.Forms.TextBox();
            this.CompanyLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CurrentDueTextBig = new System.Windows.Forms.Label();
            this.CashRecivedLabel = new System.Windows.Forms.Label();
            this.DepositButton = new System.Windows.Forms.Button();
            this.CurrentDueText = new System.Windows.Forms.TextBox();
            this.CurrentDueLabel = new System.Windows.Forms.Label();
            this.NotesText = new System.Windows.Forms.RichTextBox();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.DueCollectionGroupBox = new System.Windows.Forms.GroupBox();
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.DueCollectionGroupBox.SuspendLayout();
            this.InfoGroupBox.SuspendLayout();
            this.SuspendLayout();
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
            // CashReceivedText
            // 
            resources.ApplyResources(this.CashReceivedText, "CashReceivedText");
            this.CashReceivedText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CashReceivedText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CashReceivedText.Name = "CashReceivedText";
            this.CashReceivedText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // CurrentDueLabelBig
            // 
            resources.ApplyResources(this.CurrentDueLabelBig, "CurrentDueLabelBig");
            this.CurrentDueLabelBig.Name = "CurrentDueLabelBig";
            this.CurrentDueLabelBig.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
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
            // TitleLabel
            // 
            resources.ApplyResources(this.TitleLabel, "TitleLabel");
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
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
            // CompanyText
            // 
            resources.ApplyResources(this.CompanyText, "CompanyText");
            this.CompanyText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CompanyText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyText.Name = "CompanyText";
            // 
            // CompanyLabel
            // 
            resources.ApplyResources(this.CompanyLabel, "CompanyLabel");
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
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
            // CurrentDueTextBig
            // 
            resources.ApplyResources(this.CurrentDueTextBig, "CurrentDueTextBig");
            this.CurrentDueTextBig.Name = "CurrentDueTextBig";
            // 
            // CashRecivedLabel
            // 
            resources.ApplyResources(this.CashRecivedLabel, "CashRecivedLabel");
            this.CashRecivedLabel.Name = "CashRecivedLabel";
            // 
            // DepositButton
            // 
            resources.ApplyResources(this.DepositButton, "DepositButton");
            this.DepositButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.DepositButton.FlatAppearance.BorderSize = 0;
            this.DepositButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.DepositButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            this.DepositButton.ForeColor = System.Drawing.Color.White;
            this.DepositButton.Name = "DepositButton";
            this.DepositButton.UseVisualStyleBackColor = false;
            this.DepositButton.Click += new System.EventHandler(this.DepositButton_Click);
            // 
            // CurrentDueText
            // 
            resources.ApplyResources(this.CurrentDueText, "CurrentDueText");
            this.CurrentDueText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CurrentDueText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrentDueText.Name = "CurrentDueText";
            this.CurrentDueText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // CurrentDueLabel
            // 
            resources.ApplyResources(this.CurrentDueLabel, "CurrentDueLabel");
            this.CurrentDueLabel.Name = "CurrentDueLabel";
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
            // 
            // DueCollectionGroupBox
            // 
            resources.ApplyResources(this.DueCollectionGroupBox, "DueCollectionGroupBox");
            this.DueCollectionGroupBox.Controls.Add(this.CurrentDueLabelBig);
            this.DueCollectionGroupBox.Controls.Add(this.CashReceivedText);
            this.DueCollectionGroupBox.Controls.Add(this.CurrentDueTextBig);
            this.DueCollectionGroupBox.Controls.Add(this.CashRecivedLabel);
            this.DueCollectionGroupBox.Controls.Add(this.DepositButton);
            this.DueCollectionGroupBox.Name = "DueCollectionGroupBox";
            this.DueCollectionGroupBox.TabStop = false;
            // 
            // InfoGroupBox
            // 
            resources.ApplyResources(this.InfoGroupBox, "InfoGroupBox");
            this.InfoGroupBox.Controls.Add(this.FullNameLabel);
            this.InfoGroupBox.Controls.Add(this.NickNameLabel);
            this.InfoGroupBox.Controls.Add(this.NotesText);
            this.InfoGroupBox.Controls.Add(this.NickNameText);
            this.InfoGroupBox.Controls.Add(this.NotesLabel);
            this.InfoGroupBox.Controls.Add(this.EmailAddressLabel);
            this.InfoGroupBox.Controls.Add(this.CurrentDueText);
            this.InfoGroupBox.Controls.Add(this.EmailAddressText);
            this.InfoGroupBox.Controls.Add(this.CurrentDueLabel);
            this.InfoGroupBox.Controls.Add(this.FullNameText);
            this.InfoGroupBox.Controls.Add(this.SaveButton);
            this.InfoGroupBox.Controls.Add(this.AddressLabel);
            this.InfoGroupBox.Controls.Add(this.CompanyText);
            this.InfoGroupBox.Controls.Add(this.AddressText);
            this.InfoGroupBox.Controls.Add(this.CompanyLabel);
            this.InfoGroupBox.Controls.Add(this.ContactNumberLabel);
            this.InfoGroupBox.Controls.Add(this.ContactNumberText);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.TabStop = false;
            // 
            // CustomerInformationForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.InfoGroupBox);
            this.Controls.Add(this.DueCollectionGroupBox);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CustomerInformationForm";
            this.Load += new System.EventHandler(this.CustomerInformationForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            this.DueCollectionGroupBox.ResumeLayout(false);
            this.DueCollectionGroupBox.PerformLayout();
            this.InfoGroupBox.ResumeLayout(false);
            this.InfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FullNameText;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.TextBox CashReceivedText;
        private System.Windows.Forms.Label CurrentDueLabelBig;
        private System.Windows.Forms.TextBox EmailAddressText;
        private System.Windows.Forms.Label EmailAddressLabel;
        private System.Windows.Forms.TextBox NickNameText;
        private System.Windows.Forms.Label NickNameLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox AddressText;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox ContactNumberText;
        private System.Windows.Forms.Label ContactNumberLabel;
        private System.Windows.Forms.TextBox CompanyText;
        private System.Windows.Forms.Label CompanyLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label CurrentDueTextBig;
        private System.Windows.Forms.Label CashRecivedLabel;
        private System.Windows.Forms.Button DepositButton;
        private System.Windows.Forms.TextBox CurrentDueText;
        private System.Windows.Forms.Label CurrentDueLabel;
        private System.Windows.Forms.RichTextBox NotesText;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.GroupBox DueCollectionGroupBox;
        private System.Windows.Forms.GroupBox InfoGroupBox;
    }
}