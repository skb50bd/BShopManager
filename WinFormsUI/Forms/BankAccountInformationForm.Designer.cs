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
            this.NoteText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NoteText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NoteText.Location = new System.Drawing.Point(146, 177);
            this.NoteText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NoteText.Name = "NoteText";
            this.NoteText.Size = new System.Drawing.Size(228, 76);
            this.NoteText.TabIndex = 9;
            this.NoteText.Text = "";
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesLabel.Location = new System.Drawing.Point(6, 177);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(58, 21);
            this.NotesLabel.TabIndex = 8;
            this.NotesLabel.Text = "Notes :";
            this.NotesLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semi Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(7, 6);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(226, 47);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Bank Account";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(10, 267);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(364, 42);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "Add Account";
            this.AddButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AccountNameText
            // 
            this.AccountNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AccountNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccountNameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNameText.Location = new System.Drawing.Point(146, 25);
            this.AccountNameText.Name = "AccountNameText";
            this.AccountNameText.Size = new System.Drawing.Size(228, 22);
            this.AccountNameText.TabIndex = 1;
            // 
            // AccountNameLabel
            // 
            this.AccountNameLabel.AutoSize = true;
            this.AccountNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNameLabel.Location = new System.Drawing.Point(6, 25);
            this.AccountNameLabel.Name = "AccountNameLabel";
            this.AccountNameLabel.Size = new System.Drawing.Size(119, 21);
            this.AccountNameLabel.TabIndex = 0;
            this.AccountNameLabel.Text = "Account Name :";
            this.AccountNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // CurrentBalanceText
            // 
            this.CurrentBalanceText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CurrentBalanceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrentBalanceText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentBalanceText.Location = new System.Drawing.Point(146, 139);
            this.CurrentBalanceText.Name = "CurrentBalanceText";
            this.CurrentBalanceText.Size = new System.Drawing.Size(228, 22);
            this.CurrentBalanceText.TabIndex = 7;
            this.CurrentBalanceText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // CurrentBalanceLabel
            // 
            this.CurrentBalanceLabel.AutoSize = true;
            this.CurrentBalanceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentBalanceLabel.Location = new System.Drawing.Point(6, 139);
            this.CurrentBalanceLabel.Name = "CurrentBalanceLabel";
            this.CurrentBalanceLabel.Size = new System.Drawing.Size(127, 21);
            this.CurrentBalanceLabel.TabIndex = 6;
            this.CurrentBalanceLabel.Text = "Current Balance :";
            this.CurrentBalanceLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // AccountNumberText
            // 
            this.AccountNumberText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AccountNumberText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccountNumberText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNumberText.Location = new System.Drawing.Point(146, 101);
            this.AccountNumberText.Name = "AccountNumberText";
            this.AccountNumberText.Size = new System.Drawing.Size(228, 22);
            this.AccountNumberText.TabIndex = 5;
            // 
            // AccountNumberLabel
            // 
            this.AccountNumberLabel.AutoSize = true;
            this.AccountNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNumberLabel.Location = new System.Drawing.Point(6, 101);
            this.AccountNumberLabel.Name = "AccountNumberLabel";
            this.AccountNumberLabel.Size = new System.Drawing.Size(135, 21);
            this.AccountNumberLabel.TabIndex = 4;
            this.AccountNumberLabel.Text = "Account Number :";
            this.AccountNumberLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // BankNameText
            // 
            this.BankNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BankNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BankNameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankNameText.Location = new System.Drawing.Point(146, 63);
            this.BankNameText.Name = "BankNameText";
            this.BankNameText.Size = new System.Drawing.Size(228, 22);
            this.BankNameText.TabIndex = 3;
            // 
            // BankNameLabel
            // 
            this.BankNameLabel.AutoSize = true;
            this.BankNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankNameLabel.Location = new System.Drawing.Point(6, 63);
            this.BankNameLabel.Name = "BankNameLabel";
            this.BankNameLabel.Size = new System.Drawing.Size(97, 21);
            this.BankNameLabel.TabIndex = 2;
            this.BankNameLabel.Text = "Bank Name :";
            this.BankNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // InputsGroupBox
            // 
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
            this.InputsGroupBox.Location = new System.Drawing.Point(9, 51);
            this.InputsGroupBox.Name = "InputsGroupBox";
            this.InputsGroupBox.Size = new System.Drawing.Size(385, 319);
            this.InputsGroupBox.TabIndex = 0;
            this.InputsGroupBox.TabStop = false;
            // 
            // BankAccountInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 379);
            this.Controls.Add(this.InputsGroupBox);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BankAccountInformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bank Account Information";
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