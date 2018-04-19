namespace WinFormsUI.Forms {
    partial class BankAccountInformationForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankAccountInformationForm));
            this.NoteText = new System.Windows.Forms.RichTextBox();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.AccountNameText = new System.Windows.Forms.TextBox();
            this.AccountNameLabel = new System.Windows.Forms.Label();
            this.CurrentBalanceText = new System.Windows.Forms.TextBox();
            this.CurrentBalanceLabel = new System.Windows.Forms.Label();
            this.AccountNumberText = new System.Windows.Forms.TextBox();
            this.AccountNumberLabel = new System.Windows.Forms.Label();
            this.BankNameText = new System.Windows.Forms.TextBox();
            this.BankNameLabel = new System.Windows.Forms.Label();
            this.InputsGroupBox = new System.Windows.Forms.GroupBox();
            this.InputsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NoteText
            // 
            resources.ApplyResources(this.NoteText, "NoteText");
            this.NoteText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NoteText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NoteText.Name = "NoteText";
            // 
            // NotesLabel
            // 
            resources.ApplyResources(this.NotesLabel, "NotesLabel");
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TitleLabel
            // 
            resources.ApplyResources(this.TitleLabel, "TitleLabel");
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // AddButton
            // 
            resources.ApplyResources(this.AddButton, "AddButton");
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Name = "AddButton";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AccountNameText
            // 
            resources.ApplyResources(this.AccountNameText, "AccountNameText");
            this.AccountNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AccountNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccountNameText.Name = "AccountNameText";
            // 
            // AccountNameLabel
            // 
            resources.ApplyResources(this.AccountNameLabel, "AccountNameLabel");
            this.AccountNameLabel.Name = "AccountNameLabel";
            this.AccountNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
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
            // AccountNumberText
            // 
            resources.ApplyResources(this.AccountNumberText, "AccountNumberText");
            this.AccountNumberText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AccountNumberText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccountNumberText.Name = "AccountNumberText";
            // 
            // AccountNumberLabel
            // 
            resources.ApplyResources(this.AccountNumberLabel, "AccountNumberLabel");
            this.AccountNumberLabel.Name = "AccountNumberLabel";
            this.AccountNumberLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // BankNameText
            // 
            resources.ApplyResources(this.BankNameText, "BankNameText");
            this.BankNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BankNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BankNameText.Name = "BankNameText";
            // 
            // BankNameLabel
            // 
            resources.ApplyResources(this.BankNameLabel, "BankNameLabel");
            this.BankNameLabel.Name = "BankNameLabel";
            this.BankNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // InputsGroupBox
            // 
            resources.ApplyResources(this.InputsGroupBox, "InputsGroupBox");
            this.InputsGroupBox.Controls.Add(this.AccountNameLabel);
            this.InputsGroupBox.Controls.Add(this.NoteText);
            this.InputsGroupBox.Controls.Add(this.BankNameLabel);
            this.InputsGroupBox.Controls.Add(this.NotesLabel);
            this.InputsGroupBox.Controls.Add(this.BankNameText);
            this.InputsGroupBox.Controls.Add(this.AccountNumberLabel);
            this.InputsGroupBox.Controls.Add(this.AddButton);
            this.InputsGroupBox.Controls.Add(this.AccountNumberText);
            this.InputsGroupBox.Controls.Add(this.AccountNameText);
            this.InputsGroupBox.Controls.Add(this.CurrentBalanceLabel);
            this.InputsGroupBox.Controls.Add(this.CurrentBalanceText);
            this.InputsGroupBox.Name = "InputsGroupBox";
            this.InputsGroupBox.TabStop = false;
            // 
            // BankAccountInformationForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.InputsGroupBox);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BankAccountInformationForm";
            this.Load += new System.EventHandler(this.AccountInformation_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            this.InputsGroupBox.ResumeLayout(false);
            this.InputsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox NoteText;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox AccountNameText;
        private System.Windows.Forms.Label AccountNameLabel;
        private System.Windows.Forms.TextBox CurrentBalanceText;
        private System.Windows.Forms.Label CurrentBalanceLabel;
        private System.Windows.Forms.TextBox AccountNumberText;
        private System.Windows.Forms.Label AccountNumberLabel;
        private System.Windows.Forms.TextBox BankNameText;
        private System.Windows.Forms.Label BankNameLabel;
        private System.Windows.Forms.GroupBox InputsGroupBox;
    }
}