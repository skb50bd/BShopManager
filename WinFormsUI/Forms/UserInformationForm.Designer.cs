namespace WinFormsUI {
    partial class UserInformationForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInformationForm));
            this.ContactNumberText = new System.Windows.Forms.TextBox();
            this.ContactNumberLabel = new System.Windows.Forms.Label();
            this.EmailAddressText = new System.Windows.Forms.TextBox();
            this.EmailAddressLabel = new System.Windows.Forms.Label();
            this.NickNameText = new System.Windows.Forms.TextBox();
            this.UserNameText = new System.Windows.Forms.TextBox();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.FullNameText = new System.Windows.Forms.TextBox();
            this.NickNameLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.AccessLevelCombo = new System.Windows.Forms.ComboBox();
            this.AccessLabel = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.AddSaveButton = new System.Windows.Forms.Button();
            this.ConfirmPasswordText = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.InputsGroupBox = new System.Windows.Forms.GroupBox();
            this.InputsGroupBox.SuspendLayout();
            this.SuspendLayout();
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
            // UserNameText
            // 
            resources.ApplyResources(this.UserNameText, "UserNameText");
            this.UserNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UserNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserNameText.Name = "UserNameText";
            // 
            // AddressText
            // 
            resources.ApplyResources(this.AddressText, "AddressText");
            this.AddressText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddressText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressText.Name = "AddressText";
            // 
            // UserNameLabel
            // 
            resources.ApplyResources(this.UserNameLabel, "UserNameLabel");
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // AddressLabel
            // 
            resources.ApplyResources(this.AddressLabel, "AddressLabel");
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // FullNameText
            // 
            resources.ApplyResources(this.FullNameText, "FullNameText");
            this.FullNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FullNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FullNameText.Name = "FullNameText";
            // 
            // NickNameLabel
            // 
            resources.ApplyResources(this.NickNameLabel, "NickNameLabel");
            this.NickNameLabel.Name = "NickNameLabel";
            this.NickNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // FullNameLabel
            // 
            resources.ApplyResources(this.FullNameLabel, "FullNameLabel");
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // AccessLevelCombo
            // 
            resources.ApplyResources(this.AccessLevelCombo, "AccessLevelCombo");
            this.AccessLevelCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.AccessLevelCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.AccessLevelCombo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AccessLevelCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccessLevelCombo.FormattingEnabled = true;
            this.AccessLevelCombo.Items.AddRange(new object[] {
            resources.GetString("AccessLevelCombo.Items"),
            resources.GetString("AccessLevelCombo.Items1"),
            resources.GetString("AccessLevelCombo.Items2")});
            this.AccessLevelCombo.Name = "AccessLevelCombo";
            // 
            // AccessLabel
            // 
            resources.ApplyResources(this.AccessLabel, "AccessLabel");
            this.AccessLabel.Name = "AccessLabel";
            this.AccessLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // PasswordText
            // 
            resources.ApplyResources(this.PasswordText, "PasswordText");
            this.PasswordText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PasswordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.UseSystemPasswordChar = true;
            this.PasswordText.Enter += new System.EventHandler(this.PasswordText_Enter);
            // 
            // PasswordLabel
            // 
            resources.ApplyResources(this.PasswordLabel, "PasswordLabel");
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // AddSaveButton
            // 
            resources.ApplyResources(this.AddSaveButton, "AddSaveButton");
            this.AddSaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.AddSaveButton.FlatAppearance.BorderSize = 0;
            this.AddSaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(170)))));
            this.AddSaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.AddSaveButton.ForeColor = System.Drawing.Color.White;
            this.AddSaveButton.Name = "AddSaveButton";
            this.AddSaveButton.UseVisualStyleBackColor = false;
            this.AddSaveButton.Click += new System.EventHandler(this.AddSaveButton_Click);
            // 
            // ConfirmPasswordText
            // 
            resources.ApplyResources(this.ConfirmPasswordText, "ConfirmPasswordText");
            this.ConfirmPasswordText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ConfirmPasswordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConfirmPasswordText.Name = "ConfirmPasswordText";
            this.ConfirmPasswordText.UseSystemPasswordChar = true;
            this.ConfirmPasswordText.Enter += new System.EventHandler(this.PasswordText_Enter);
            // 
            // ConfirmPasswordLabel
            // 
            resources.ApplyResources(this.ConfirmPasswordLabel, "ConfirmPasswordLabel");
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TitleLabel
            // 
            resources.ApplyResources(this.TitleLabel, "TitleLabel");
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // contextMenuStrip1
            // 
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            // 
            // InputsGroupBox
            // 
            resources.ApplyResources(this.InputsGroupBox, "InputsGroupBox");
            this.InputsGroupBox.Controls.Add(this.FullNameLabel);
            this.InputsGroupBox.Controls.Add(this.ConfirmPasswordLabel);
            this.InputsGroupBox.Controls.Add(this.ConfirmPasswordText);
            this.InputsGroupBox.Controls.Add(this.ContactNumberText);
            this.InputsGroupBox.Controls.Add(this.AddSaveButton);
            this.InputsGroupBox.Controls.Add(this.ContactNumberLabel);
            this.InputsGroupBox.Controls.Add(this.PasswordLabel);
            this.InputsGroupBox.Controls.Add(this.EmailAddressText);
            this.InputsGroupBox.Controls.Add(this.PasswordText);
            this.InputsGroupBox.Controls.Add(this.EmailAddressLabel);
            this.InputsGroupBox.Controls.Add(this.AccessLabel);
            this.InputsGroupBox.Controls.Add(this.NickNameText);
            this.InputsGroupBox.Controls.Add(this.AccessLevelCombo);
            this.InputsGroupBox.Controls.Add(this.UserNameText);
            this.InputsGroupBox.Controls.Add(this.NickNameLabel);
            this.InputsGroupBox.Controls.Add(this.AddressText);
            this.InputsGroupBox.Controls.Add(this.FullNameText);
            this.InputsGroupBox.Controls.Add(this.UserNameLabel);
            this.InputsGroupBox.Controls.Add(this.AddressLabel);
            this.InputsGroupBox.Name = "InputsGroupBox";
            this.InputsGroupBox.TabStop = false;
            // 
            // UserInformationForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.InputsGroupBox);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserInformationForm";
            this.Load += new System.EventHandler(this.UserInformationForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            this.InputsGroupBox.ResumeLayout(false);
            this.InputsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ContactNumberText;
        private System.Windows.Forms.Label ContactNumberLabel;
        private System.Windows.Forms.TextBox EmailAddressText;
        private System.Windows.Forms.Label EmailAddressLabel;
        private System.Windows.Forms.TextBox NickNameText;
        private System.Windows.Forms.TextBox UserNameText;
        private System.Windows.Forms.TextBox AddressText;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox FullNameText;
        private System.Windows.Forms.Label NickNameLabel;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.ComboBox AccessLevelCombo;
        private System.Windows.Forms.Label AccessLabel;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button AddSaveButton;
        private System.Windows.Forms.TextBox ConfirmPasswordText;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox InputsGroupBox;
    }
}