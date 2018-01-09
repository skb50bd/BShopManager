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
            this.FullNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FullNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FullNameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameText.Location = new System.Drawing.Point(144, 24);
            this.FullNameText.Margin = new System.Windows.Forms.Padding(4);
            this.FullNameText.Name = "FullNameText";
            this.FullNameText.Size = new System.Drawing.Size(207, 22);
            this.FullNameText.TabIndex = 1;
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameLabel.Location = new System.Drawing.Point(4, 25);
            this.FullNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(88, 21);
            this.FullNameLabel.TabIndex = 0;
            this.FullNameLabel.Text = "Full Name :";
            this.FullNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // CashReceivedText
            // 
            this.CashReceivedText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CashReceivedText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CashReceivedText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashReceivedText.Location = new System.Drawing.Point(11, 117);
            this.CashReceivedText.Margin = new System.Windows.Forms.Padding(4);
            this.CashReceivedText.Name = "CashReceivedText";
            this.CashReceivedText.Size = new System.Drawing.Size(156, 22);
            this.CashReceivedText.TabIndex = 3;
            this.CashReceivedText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // CurrentDueLabelBig
            // 
            this.CurrentDueLabelBig.AutoSize = true;
            this.CurrentDueLabelBig.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentDueLabelBig.Location = new System.Drawing.Point(7, 25);
            this.CurrentDueLabelBig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentDueLabelBig.Name = "CurrentDueLabelBig";
            this.CurrentDueLabelBig.Size = new System.Drawing.Size(95, 21);
            this.CurrentDueLabelBig.TabIndex = 0;
            this.CurrentDueLabelBig.Text = "Current Due";
            this.CurrentDueLabelBig.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // EmailAddressText
            // 
            this.EmailAddressText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EmailAddressText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailAddressText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAddressText.Location = new System.Drawing.Point(144, 180);
            this.EmailAddressText.Margin = new System.Windows.Forms.Padding(4);
            this.EmailAddressText.Name = "EmailAddressText";
            this.EmailAddressText.Size = new System.Drawing.Size(207, 22);
            this.EmailAddressText.TabIndex = 9;
            // 
            // EmailAddressLabel
            // 
            this.EmailAddressLabel.AutoSize = true;
            this.EmailAddressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAddressLabel.Location = new System.Drawing.Point(4, 180);
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
            this.NickNameText.Location = new System.Drawing.Point(144, 63);
            this.NickNameText.Margin = new System.Windows.Forms.Padding(4);
            this.NickNameText.Name = "NickNameText";
            this.NickNameText.Size = new System.Drawing.Size(207, 22);
            this.NickNameText.TabIndex = 3;
            // 
            // NickNameLabel
            // 
            this.NickNameLabel.AutoSize = true;
            this.NickNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NickNameLabel.Location = new System.Drawing.Point(4, 63);
            this.NickNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NickNameLabel.Name = "NickNameLabel";
            this.NickNameLabel.Size = new System.Drawing.Size(94, 21);
            this.NickNameLabel.TabIndex = 2;
            this.NickNameLabel.Text = "Nick Name :";
            this.NickNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semi Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(5, 9);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(350, 47);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Customer Information";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // AddressText
            // 
            this.AddressText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddressText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressText.Location = new System.Drawing.Point(144, 219);
            this.AddressText.Margin = new System.Windows.Forms.Padding(4);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(207, 22);
            this.AddressText.TabIndex = 11;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(4, 219);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(73, 21);
            this.AddressLabel.TabIndex = 10;
            this.AddressLabel.Text = "Address :";
            this.AddressLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // ContactNumberText
            // 
            this.ContactNumberText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ContactNumberText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContactNumberText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNumberText.Location = new System.Drawing.Point(144, 141);
            this.ContactNumberText.Margin = new System.Windows.Forms.Padding(4);
            this.ContactNumberText.Name = "ContactNumberText";
            this.ContactNumberText.Size = new System.Drawing.Size(207, 22);
            this.ContactNumberText.TabIndex = 7;
            // 
            // ContactNumberLabel
            // 
            this.ContactNumberLabel.AutoSize = true;
            this.ContactNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNumberLabel.Location = new System.Drawing.Point(4, 141);
            this.ContactNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContactNumberLabel.Name = "ContactNumberLabel";
            this.ContactNumberLabel.Size = new System.Drawing.Size(132, 21);
            this.ContactNumberLabel.TabIndex = 6;
            this.ContactNumberLabel.Text = "Contact Number :";
            this.ContactNumberLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // CompanyText
            // 
            this.CompanyText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CompanyText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CompanyText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyText.Location = new System.Drawing.Point(144, 102);
            this.CompanyText.Margin = new System.Windows.Forms.Padding(4);
            this.CompanyText.Name = "CompanyText";
            this.CompanyText.Size = new System.Drawing.Size(207, 22);
            this.CompanyText.TabIndex = 5;
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.AutoSize = true;
            this.CompanyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyLabel.Location = new System.Drawing.Point(4, 102);
            this.CompanyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(84, 21);
            this.CompanyLabel.TabIndex = 4;
            this.CompanyLabel.Text = "Company :";
            this.CompanyLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
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
            this.SaveButton.Location = new System.Drawing.Point(10, 363);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(341, 42);
            this.SaveButton.TabIndex = 16;
            this.SaveButton.Text = "Save";
            this.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CurrentDueTextBig
            // 
            this.CurrentDueTextBig.AutoSize = true;
            this.CurrentDueTextBig.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentDueTextBig.Location = new System.Drawing.Point(4, 50);
            this.CurrentDueTextBig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentDueTextBig.Name = "CurrentDueTextBig";
            this.CurrentDueTextBig.Size = new System.Drawing.Size(154, 30);
            this.CurrentDueTextBig.TabIndex = 1;
            this.CurrentDueTextBig.Text = "<Current Due>";
            // 
            // CashRecivedLabel
            // 
            this.CashRecivedLabel.AutoSize = true;
            this.CashRecivedLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashRecivedLabel.Location = new System.Drawing.Point(7, 93);
            this.CashRecivedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CashRecivedLabel.Name = "CashRecivedLabel";
            this.CashRecivedLabel.Size = new System.Drawing.Size(110, 21);
            this.CashRecivedLabel.TabIndex = 2;
            this.CashRecivedLabel.Text = "Cash Received";
            // 
            // DepositButton
            // 
            this.DepositButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.DepositButton.FlatAppearance.BorderSize = 0;
            this.DepositButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.DepositButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            this.DepositButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DepositButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositButton.ForeColor = System.Drawing.Color.White;
            this.DepositButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DepositButton.Location = new System.Drawing.Point(11, 145);
            this.DepositButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.DepositButton.Name = "DepositButton";
            this.DepositButton.Size = new System.Drawing.Size(156, 42);
            this.DepositButton.TabIndex = 4;
            this.DepositButton.Text = "Deposit";
            this.DepositButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DepositButton.UseVisualStyleBackColor = false;
            this.DepositButton.Click += new System.EventHandler(this.DepositButton_Click);
            // 
            // CurrentDueText
            // 
            this.CurrentDueText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CurrentDueText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrentDueText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentDueText.Location = new System.Drawing.Point(144, 258);
            this.CurrentDueText.Margin = new System.Windows.Forms.Padding(4);
            this.CurrentDueText.Name = "CurrentDueText";
            this.CurrentDueText.Size = new System.Drawing.Size(207, 22);
            this.CurrentDueText.TabIndex = 13;
            this.CurrentDueText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // CurrentDueLabel
            // 
            this.CurrentDueLabel.AutoSize = true;
            this.CurrentDueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentDueLabel.Location = new System.Drawing.Point(4, 258);
            this.CurrentDueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentDueLabel.Name = "CurrentDueLabel";
            this.CurrentDueLabel.Size = new System.Drawing.Size(102, 21);
            this.CurrentDueLabel.TabIndex = 12;
            this.CurrentDueLabel.Text = "Current Due :";
            // 
            // NotesText
            // 
            this.NotesText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NotesText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NotesText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesText.Location = new System.Drawing.Point(144, 296);
            this.NotesText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.NotesText.Name = "NotesText";
            this.NotesText.Size = new System.Drawing.Size(207, 51);
            this.NotesText.TabIndex = 15;
            this.NotesText.Text = "";
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesLabel.Location = new System.Drawing.Point(4, 296);
            this.NotesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(58, 21);
            this.NotesLabel.TabIndex = 14;
            this.NotesLabel.Text = "Notes :";
            // 
            // DueCollectionGroupBox
            // 
            this.DueCollectionGroupBox.Controls.Add(this.CurrentDueLabelBig);
            this.DueCollectionGroupBox.Controls.Add(this.CashReceivedText);
            this.DueCollectionGroupBox.Controls.Add(this.CurrentDueTextBig);
            this.DueCollectionGroupBox.Controls.Add(this.CashRecivedLabel);
            this.DueCollectionGroupBox.Controls.Add(this.DepositButton);
            this.DueCollectionGroupBox.Location = new System.Drawing.Point(380, 59);
            this.DueCollectionGroupBox.Name = "DueCollectionGroupBox";
            this.DueCollectionGroupBox.Size = new System.Drawing.Size(176, 196);
            this.DueCollectionGroupBox.TabIndex = 2;
            this.DueCollectionGroupBox.TabStop = false;
            this.DueCollectionGroupBox.Text = "Due Collection";
            // 
            // InfoGroupBox
            // 
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
            this.InfoGroupBox.Location = new System.Drawing.Point(13, 59);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.Size = new System.Drawing.Size(361, 416);
            this.InfoGroupBox.TabIndex = 1;
            this.InfoGroupBox.TabStop = false;
            // 
            // CustomerInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 480);
            this.Controls.Add(this.InfoGroupBox);
            this.Controls.Add(this.DueCollectionGroupBox);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustomerInformationForm";
            this.Text = "Customer Information";
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