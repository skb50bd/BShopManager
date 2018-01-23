namespace WinFormsUI.Forms {
    partial class SupplierInformationForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierInformationForm));
            this.CurrentPayableText = new System.Windows.Forms.TextBox();
            this.CurrentPayableLabel = new System.Windows.Forms.Label();
            this.RepayButton = new System.Windows.Forms.Button();
            this.RepaymentLabel = new System.Windows.Forms.Label();
            this.CurrentPayableTextBig = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CompanyText = new System.Windows.Forms.TextBox();
            this.CompanyLabel = new System.Windows.Forms.Label();
            this.ContactNumberText = new System.Windows.Forms.TextBox();
            this.ContactNumberLabel = new System.Windows.Forms.Label();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.FullNameText = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.RepayAmountText = new System.Windows.Forms.TextBox();
            this.CurrentPayableLabelBig = new System.Windows.Forms.Label();
            this.EmailAddressText = new System.Windows.Forms.TextBox();
            this.EmailAddressLabel = new System.Windows.Forms.Label();
            this.NickNameText = new System.Windows.Forms.TextBox();
            this.NickNameLabel = new System.Windows.Forms.Label();
            this.NotesText = new System.Windows.Forms.RichTextBox();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.RepaymentGroupBox = new System.Windows.Forms.GroupBox();
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.RepaymentGroupBox.SuspendLayout();
            this.InfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CurrentPayableText
            // 
            this.CurrentPayableText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CurrentPayableText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrentPayableText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPayableText.Location = new System.Drawing.Point(148, 256);
            this.CurrentPayableText.Margin = new System.Windows.Forms.Padding(4);
            this.CurrentPayableText.Name = "CurrentPayableText";
            this.CurrentPayableText.Size = new System.Drawing.Size(201, 22);
            this.CurrentPayableText.TabIndex = 13;
            this.CurrentPayableText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // CurrentPayableLabel
            // 
            this.CurrentPayableLabel.AutoSize = true;
            this.CurrentPayableLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPayableLabel.Location = new System.Drawing.Point(8, 256);
            this.CurrentPayableLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentPayableLabel.Name = "CurrentPayableLabel";
            this.CurrentPayableLabel.Size = new System.Drawing.Size(127, 21);
            this.CurrentPayableLabel.TabIndex = 12;
            this.CurrentPayableLabel.Text = "Current Payable :";
            this.CurrentPayableLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // RepayButton
            // 
            this.RepayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.RepayButton.FlatAppearance.BorderSize = 0;
            this.RepayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.RepayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            this.RepayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RepayButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepayButton.ForeColor = System.Drawing.Color.White;
            this.RepayButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RepayButton.Location = new System.Drawing.Point(11, 144);
            this.RepayButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.RepayButton.Name = "RepayButton";
            this.RepayButton.Size = new System.Drawing.Size(156, 42);
            this.RepayButton.TabIndex = 4;
            this.RepayButton.Text = "Repay";
            this.RepayButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RepayButton.UseVisualStyleBackColor = false;
            this.RepayButton.Click += new System.EventHandler(this.RepayButton_Click);
            // 
            // RepaymentLabel
            // 
            this.RepaymentLabel.AutoSize = true;
            this.RepaymentLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepaymentLabel.Location = new System.Drawing.Point(7, 92);
            this.RepaymentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RepaymentLabel.Name = "RepaymentLabel";
            this.RepaymentLabel.Size = new System.Drawing.Size(147, 21);
            this.RepaymentLabel.TabIndex = 2;
            this.RepaymentLabel.Text = "Repayment amount";
            this.RepaymentLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // CurrentPayableTextBig
            // 
            this.CurrentPayableTextBig.AutoSize = true;
            this.CurrentPayableTextBig.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPayableTextBig.Location = new System.Drawing.Point(4, 49);
            this.CurrentPayableTextBig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentPayableTextBig.Name = "CurrentPayableTextBig";
            this.CurrentPayableTextBig.Size = new System.Drawing.Size(112, 30);
            this.CurrentPayableTextBig.TabIndex = 1;
            this.CurrentPayableTextBig.Text = "<Payable>";
            this.CurrentPayableTextBig.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
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
            this.SaveButton.Location = new System.Drawing.Point(14, 357);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(335, 42);
            this.SaveButton.TabIndex = 16;
            this.SaveButton.Text = "Save";
            this.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CompanyText
            // 
            this.CompanyText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CompanyText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyText.Location = new System.Drawing.Point(148, 100);
            this.CompanyText.Margin = new System.Windows.Forms.Padding(4);
            this.CompanyText.Name = "CompanyText";
            this.CompanyText.Size = new System.Drawing.Size(201, 22);
            this.CompanyText.TabIndex = 5;
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.AutoSize = true;
            this.CompanyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyLabel.Location = new System.Drawing.Point(8, 100);
            this.CompanyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(84, 21);
            this.CompanyLabel.TabIndex = 4;
            this.CompanyLabel.Text = "Company :";
            this.CompanyLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // ContactNumberText
            // 
            this.ContactNumberText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ContactNumberText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContactNumberText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNumberText.Location = new System.Drawing.Point(148, 139);
            this.ContactNumberText.Margin = new System.Windows.Forms.Padding(4);
            this.ContactNumberText.Name = "ContactNumberText";
            this.ContactNumberText.Size = new System.Drawing.Size(201, 22);
            this.ContactNumberText.TabIndex = 7;
            // 
            // ContactNumberLabel
            // 
            this.ContactNumberLabel.AutoSize = true;
            this.ContactNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNumberLabel.Location = new System.Drawing.Point(8, 139);
            this.ContactNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContactNumberLabel.Name = "ContactNumberLabel";
            this.ContactNumberLabel.Size = new System.Drawing.Size(132, 21);
            this.ContactNumberLabel.TabIndex = 6;
            this.ContactNumberLabel.Text = "Contact Number :";
            this.ContactNumberLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // AddressText
            // 
            this.AddressText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddressText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressText.Location = new System.Drawing.Point(148, 217);
            this.AddressText.Margin = new System.Windows.Forms.Padding(4);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(201, 22);
            this.AddressText.TabIndex = 11;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(8, 217);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(73, 21);
            this.AddressLabel.TabIndex = 10;
            this.AddressLabel.Text = "Address :";
            this.AddressLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semi Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(6, 6);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(328, 47);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Supplier Information";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // FullNameText
            // 
            this.FullNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FullNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FullNameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameText.Location = new System.Drawing.Point(148, 22);
            this.FullNameText.Margin = new System.Windows.Forms.Padding(4);
            this.FullNameText.Name = "FullNameText";
            this.FullNameText.Size = new System.Drawing.Size(201, 22);
            this.FullNameText.TabIndex = 1;
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameLabel.Location = new System.Drawing.Point(8, 23);
            this.FullNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(88, 21);
            this.FullNameLabel.TabIndex = 0;
            this.FullNameLabel.Text = "Full Name :";
            this.FullNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // RepayAmountText
            // 
            this.RepayAmountText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RepayAmountText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RepayAmountText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepayAmountText.Location = new System.Drawing.Point(11, 116);
            this.RepayAmountText.Margin = new System.Windows.Forms.Padding(4);
            this.RepayAmountText.Name = "RepayAmountText";
            this.RepayAmountText.Size = new System.Drawing.Size(156, 22);
            this.RepayAmountText.TabIndex = 3;
            this.RepayAmountText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // CurrentPayableLabelBig
            // 
            this.CurrentPayableLabelBig.AutoSize = true;
            this.CurrentPayableLabelBig.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPayableLabelBig.Location = new System.Drawing.Point(7, 24);
            this.CurrentPayableLabelBig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentPayableLabelBig.Name = "CurrentPayableLabelBig";
            this.CurrentPayableLabelBig.Size = new System.Drawing.Size(63, 21);
            this.CurrentPayableLabelBig.TabIndex = 0;
            this.CurrentPayableLabelBig.Text = "Payable";
            this.CurrentPayableLabelBig.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // EmailAddressText
            // 
            this.EmailAddressText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EmailAddressText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailAddressText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAddressText.Location = new System.Drawing.Point(148, 178);
            this.EmailAddressText.Margin = new System.Windows.Forms.Padding(4);
            this.EmailAddressText.Name = "EmailAddressText";
            this.EmailAddressText.Size = new System.Drawing.Size(201, 22);
            this.EmailAddressText.TabIndex = 9;
            // 
            // EmailAddressLabel
            // 
            this.EmailAddressLabel.AutoSize = true;
            this.EmailAddressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAddressLabel.Location = new System.Drawing.Point(8, 178);
            this.EmailAddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailAddressLabel.Name = "EmailAddressLabel";
            this.EmailAddressLabel.Size = new System.Drawing.Size(115, 21);
            this.EmailAddressLabel.TabIndex = 8;
            this.EmailAddressLabel.Text = "Email Address :";
            this.EmailAddressLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // NickNameText
            // 
            this.NickNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NickNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NickNameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NickNameText.Location = new System.Drawing.Point(148, 61);
            this.NickNameText.Margin = new System.Windows.Forms.Padding(4);
            this.NickNameText.Name = "NickNameText";
            this.NickNameText.Size = new System.Drawing.Size(201, 22);
            this.NickNameText.TabIndex = 3;
            // 
            // NickNameLabel
            // 
            this.NickNameLabel.AutoSize = true;
            this.NickNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NickNameLabel.Location = new System.Drawing.Point(8, 61);
            this.NickNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NickNameLabel.Name = "NickNameLabel";
            this.NickNameLabel.Size = new System.Drawing.Size(94, 21);
            this.NickNameLabel.TabIndex = 2;
            this.NickNameLabel.Text = "Nick Name :";
            this.NickNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // NotesText
            // 
            this.NotesText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NotesText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NotesText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesText.Location = new System.Drawing.Point(148, 293);
            this.NotesText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.NotesText.Name = "NotesText";
            this.NotesText.Size = new System.Drawing.Size(201, 51);
            this.NotesText.TabIndex = 15;
            this.NotesText.Text = "";
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesLabel.Location = new System.Drawing.Point(8, 293);
            this.NotesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(58, 21);
            this.NotesLabel.TabIndex = 14;
            this.NotesLabel.Text = "Notes :";
            // 
            // RepaymentGroupBox
            // 
            this.RepaymentGroupBox.Controls.Add(this.CurrentPayableLabelBig);
            this.RepaymentGroupBox.Controls.Add(this.RepayAmountText);
            this.RepaymentGroupBox.Controls.Add(this.CurrentPayableTextBig);
            this.RepaymentGroupBox.Controls.Add(this.RepaymentLabel);
            this.RepaymentGroupBox.Controls.Add(this.RepayButton);
            this.RepaymentGroupBox.Location = new System.Drawing.Point(376, 52);
            this.RepaymentGroupBox.Name = "RepaymentGroupBox";
            this.RepaymentGroupBox.Size = new System.Drawing.Size(176, 196);
            this.RepaymentGroupBox.TabIndex = 2;
            this.RepaymentGroupBox.TabStop = false;
            this.RepaymentGroupBox.Text = "Repayment";
            // 
            // InfoGroupBox
            // 
            this.InfoGroupBox.Controls.Add(this.FullNameLabel);
            this.InfoGroupBox.Controls.Add(this.NickNameLabel);
            this.InfoGroupBox.Controls.Add(this.NotesText);
            this.InfoGroupBox.Controls.Add(this.NickNameText);
            this.InfoGroupBox.Controls.Add(this.NotesLabel);
            this.InfoGroupBox.Controls.Add(this.EmailAddressLabel);
            this.InfoGroupBox.Controls.Add(this.CurrentPayableText);
            this.InfoGroupBox.Controls.Add(this.EmailAddressText);
            this.InfoGroupBox.Controls.Add(this.CurrentPayableLabel);
            this.InfoGroupBox.Controls.Add(this.FullNameText);
            this.InfoGroupBox.Controls.Add(this.SaveButton);
            this.InfoGroupBox.Controls.Add(this.AddressLabel);
            this.InfoGroupBox.Controls.Add(this.CompanyText);
            this.InfoGroupBox.Controls.Add(this.AddressText);
            this.InfoGroupBox.Controls.Add(this.CompanyLabel);
            this.InfoGroupBox.Controls.Add(this.ContactNumberLabel);
            this.InfoGroupBox.Controls.Add(this.ContactNumberText);
            this.InfoGroupBox.Location = new System.Drawing.Point(9, 52);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.Size = new System.Drawing.Size(361, 414);
            this.InfoGroupBox.TabIndex = 1;
            this.InfoGroupBox.TabStop = false;
            // 
            // SupplierInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 473);
            this.Controls.Add(this.InfoGroupBox);
            this.Controls.Add(this.RepaymentGroupBox);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SupplierInformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Supplier Information";
            this.Load += new System.EventHandler(this.SupplierInformationForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            this.RepaymentGroupBox.ResumeLayout(false);
            this.RepaymentGroupBox.PerformLayout();
            this.InfoGroupBox.ResumeLayout(false);
            this.InfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CurrentPayableText;
        private System.Windows.Forms.Label CurrentPayableLabel;
        private System.Windows.Forms.Button RepayButton;
        private System.Windows.Forms.Label RepaymentLabel;
        private System.Windows.Forms.Label CurrentPayableTextBig;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox CompanyText;
        private System.Windows.Forms.Label CompanyLabel;
        private System.Windows.Forms.TextBox ContactNumberText;
        private System.Windows.Forms.Label ContactNumberLabel;
        private System.Windows.Forms.TextBox AddressText;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox FullNameText;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.TextBox RepayAmountText;
        private System.Windows.Forms.Label CurrentPayableLabelBig;
        private System.Windows.Forms.TextBox EmailAddressText;
        private System.Windows.Forms.Label EmailAddressLabel;
        private System.Windows.Forms.TextBox NickNameText;
        private System.Windows.Forms.Label NickNameLabel;
        private System.Windows.Forms.RichTextBox NotesText;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.GroupBox RepaymentGroupBox;
        private System.Windows.Forms.GroupBox InfoGroupBox;
    }
}