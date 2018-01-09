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
            this.CurrentBalanceText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CurrentBalanceText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrentBalanceText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentBalanceText.Location = new System.Drawing.Point(144, 364);
            this.CurrentBalanceText.Margin = new System.Windows.Forms.Padding(4);
            this.CurrentBalanceText.Name = "CurrentBalanceText";
            this.CurrentBalanceText.Size = new System.Drawing.Size(207, 22);
            this.CurrentBalanceText.TabIndex = 19;
            this.CurrentBalanceText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // CurrentBalanceLabel
            // 
            this.CurrentBalanceLabel.AutoSize = true;
            this.CurrentBalanceLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentBalanceLabel.Location = new System.Drawing.Point(4, 364);
            this.CurrentBalanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentBalanceLabel.Name = "CurrentBalanceLabel";
            this.CurrentBalanceLabel.Size = new System.Drawing.Size(127, 21);
            this.CurrentBalanceLabel.TabIndex = 18;
            this.CurrentBalanceLabel.Text = "Current Balance :";
            this.CurrentBalanceLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // PayButton
            // 
            this.PayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.PayButton.FlatAppearance.BorderSize = 0;
            this.PayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.PayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            this.PayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PayButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayButton.ForeColor = System.Drawing.Color.White;
            this.PayButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PayButton.Location = new System.Drawing.Point(11, 145);
            this.PayButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(156, 42);
            this.PayButton.TabIndex = 4;
            this.PayButton.Text = "Pay";
            this.PayButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PayButton.UseVisualStyleBackColor = false;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // PaySalaryLabel
            // 
            this.PaySalaryLabel.AutoSize = true;
            this.PaySalaryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaySalaryLabel.Location = new System.Drawing.Point(7, 93);
            this.PaySalaryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PaySalaryLabel.Name = "PaySalaryLabel";
            this.PaySalaryLabel.Size = new System.Drawing.Size(66, 21);
            this.PaySalaryLabel.TabIndex = 2;
            this.PaySalaryLabel.Text = "Amount";
            this.PaySalaryLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // CurrentBalanceTextBig
            // 
            this.CurrentBalanceTextBig.AutoSize = true;
            this.CurrentBalanceTextBig.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentBalanceTextBig.Location = new System.Drawing.Point(4, 50);
            this.CurrentBalanceTextBig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentBalanceTextBig.Name = "CurrentBalanceTextBig";
            this.CurrentBalanceTextBig.Size = new System.Drawing.Size(113, 30);
            this.CurrentBalanceTextBig.TabIndex = 1;
            this.CurrentBalanceTextBig.Text = "<Balance>";
            this.CurrentBalanceTextBig.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
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
            this.SaveButton.Location = new System.Drawing.Point(10, 466);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(341, 42);
            this.SaveButton.TabIndex = 22;
            this.SaveButton.Text = "Save";
            this.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DesignationText
            // 
            this.DesignationText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DesignationText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DesignationText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesignationText.Location = new System.Drawing.Point(144, 98);
            this.DesignationText.Margin = new System.Windows.Forms.Padding(4);
            this.DesignationText.Name = "DesignationText";
            this.DesignationText.Size = new System.Drawing.Size(207, 22);
            this.DesignationText.TabIndex = 5;
            // 
            // DesignationLabel
            // 
            this.DesignationLabel.AutoSize = true;
            this.DesignationLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesignationLabel.Location = new System.Drawing.Point(4, 98);
            this.DesignationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DesignationLabel.Name = "DesignationLabel";
            this.DesignationLabel.Size = new System.Drawing.Size(100, 21);
            this.DesignationLabel.TabIndex = 4;
            this.DesignationLabel.Text = "Designation :";
            this.DesignationLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // ContactNumberText
            // 
            this.ContactNumberText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ContactNumberText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContactNumberText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNumberText.Location = new System.Drawing.Point(144, 174);
            this.ContactNumberText.Margin = new System.Windows.Forms.Padding(4);
            this.ContactNumberText.Name = "ContactNumberText";
            this.ContactNumberText.Size = new System.Drawing.Size(207, 22);
            this.ContactNumberText.TabIndex = 9;
            // 
            // ContactNumberLabel
            // 
            this.ContactNumberLabel.AutoSize = true;
            this.ContactNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactNumberLabel.Location = new System.Drawing.Point(4, 174);
            this.ContactNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContactNumberLabel.Name = "ContactNumberLabel";
            this.ContactNumberLabel.Size = new System.Drawing.Size(132, 21);
            this.ContactNumberLabel.TabIndex = 8;
            this.ContactNumberLabel.Text = "Contact Number :";
            this.ContactNumberLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // AddressText
            // 
            this.AddressText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddressText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressText.Location = new System.Drawing.Point(144, 250);
            this.AddressText.Margin = new System.Windows.Forms.Padding(4);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(207, 22);
            this.AddressText.TabIndex = 13;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(4, 250);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(73, 21);
            this.AddressLabel.TabIndex = 12;
            this.AddressLabel.Text = "Address :";
            this.AddressLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semi Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(5, 9);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(352, 47);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Employee Information";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // FullNameText
            // 
            this.FullNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FullNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FullNameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameText.Location = new System.Drawing.Point(144, 22);
            this.FullNameText.Margin = new System.Windows.Forms.Padding(4);
            this.FullNameText.Name = "FullNameText";
            this.FullNameText.Size = new System.Drawing.Size(207, 22);
            this.FullNameText.TabIndex = 1;
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameLabel.Location = new System.Drawing.Point(4, 22);
            this.FullNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(88, 21);
            this.FullNameLabel.TabIndex = 0;
            this.FullNameLabel.Text = "Full Name :";
            this.FullNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // SalaryAmountText
            // 
            this.SalaryAmountText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SalaryAmountText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SalaryAmountText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryAmountText.Location = new System.Drawing.Point(11, 117);
            this.SalaryAmountText.Margin = new System.Windows.Forms.Padding(4);
            this.SalaryAmountText.Name = "SalaryAmountText";
            this.SalaryAmountText.Size = new System.Drawing.Size(156, 22);
            this.SalaryAmountText.TabIndex = 3;
            this.SalaryAmountText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // CurrentBalanceLabelBig
            // 
            this.CurrentBalanceLabelBig.AutoSize = true;
            this.CurrentBalanceLabelBig.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentBalanceLabelBig.Location = new System.Drawing.Point(7, 25);
            this.CurrentBalanceLabelBig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentBalanceLabelBig.Name = "CurrentBalanceLabelBig";
            this.CurrentBalanceLabelBig.Size = new System.Drawing.Size(120, 21);
            this.CurrentBalanceLabelBig.TabIndex = 0;
            this.CurrentBalanceLabelBig.Text = "Current Balance";
            this.CurrentBalanceLabelBig.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // EmailAddressText
            // 
            this.EmailAddressText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EmailAddressText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailAddressText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAddressText.Location = new System.Drawing.Point(144, 212);
            this.EmailAddressText.Margin = new System.Windows.Forms.Padding(4);
            this.EmailAddressText.Name = "EmailAddressText";
            this.EmailAddressText.Size = new System.Drawing.Size(207, 22);
            this.EmailAddressText.TabIndex = 11;
            // 
            // EmailAddressLabel
            // 
            this.EmailAddressLabel.AutoSize = true;
            this.EmailAddressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAddressLabel.Location = new System.Drawing.Point(4, 212);
            this.EmailAddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailAddressLabel.Name = "EmailAddressLabel";
            this.EmailAddressLabel.Size = new System.Drawing.Size(115, 21);
            this.EmailAddressLabel.TabIndex = 10;
            this.EmailAddressLabel.Text = "Email Address :";
            this.EmailAddressLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // NickNameText
            // 
            this.NickNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NickNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NickNameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NickNameText.Location = new System.Drawing.Point(144, 60);
            this.NickNameText.Margin = new System.Windows.Forms.Padding(4);
            this.NickNameText.Name = "NickNameText";
            this.NickNameText.Size = new System.Drawing.Size(207, 22);
            this.NickNameText.TabIndex = 3;
            // 
            // NickNameLabel
            // 
            this.NickNameLabel.AutoSize = true;
            this.NickNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NickNameLabel.Location = new System.Drawing.Point(4, 60);
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
            this.NotesText.Location = new System.Drawing.Point(144, 402);
            this.NotesText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.NotesText.Name = "NotesText";
            this.NotesText.Size = new System.Drawing.Size(207, 51);
            this.NotesText.TabIndex = 21;
            this.NotesText.Text = "";
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesLabel.Location = new System.Drawing.Point(4, 402);
            this.NotesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(58, 21);
            this.NotesLabel.TabIndex = 20;
            this.NotesLabel.Text = "Notes :";
            this.NotesLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // NidText
            // 
            this.NidText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NidText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NidText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NidText.Location = new System.Drawing.Point(144, 135);
            this.NidText.Margin = new System.Windows.Forms.Padding(4);
            this.NidText.Name = "NidText";
            this.NidText.Size = new System.Drawing.Size(207, 22);
            this.NidText.TabIndex = 7;
            // 
            // NidLabel
            // 
            this.NidLabel.AutoSize = true;
            this.NidLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NidLabel.Location = new System.Drawing.Point(4, 136);
            this.NidLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NidLabel.Name = "NidLabel";
            this.NidLabel.Size = new System.Drawing.Size(106, 21);
            this.NidLabel.TabIndex = 6;
            this.NidLabel.Text = "NID Number :";
            this.NidLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // MonthlySalaryText
            // 
            this.MonthlySalaryText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MonthlySalaryText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MonthlySalaryText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthlySalaryText.Location = new System.Drawing.Point(144, 326);
            this.MonthlySalaryText.Margin = new System.Windows.Forms.Padding(4);
            this.MonthlySalaryText.Name = "MonthlySalaryText";
            this.MonthlySalaryText.Size = new System.Drawing.Size(207, 22);
            this.MonthlySalaryText.TabIndex = 17;
            this.MonthlySalaryText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // MonthlySalaryLabel
            // 
            this.MonthlySalaryLabel.AutoSize = true;
            this.MonthlySalaryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthlySalaryLabel.Location = new System.Drawing.Point(4, 326);
            this.MonthlySalaryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MonthlySalaryLabel.Name = "MonthlySalaryLabel";
            this.MonthlySalaryLabel.Size = new System.Drawing.Size(122, 21);
            this.MonthlySalaryLabel.TabIndex = 16;
            this.MonthlySalaryLabel.Text = "Monthly Salary :";
            this.MonthlySalaryLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // JoinDateLabel
            // 
            this.JoinDateLabel.AutoSize = true;
            this.JoinDateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JoinDateLabel.Location = new System.Drawing.Point(4, 288);
            this.JoinDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JoinDateLabel.Name = "JoinDateLabel";
            this.JoinDateLabel.Size = new System.Drawing.Size(81, 21);
            this.JoinDateLabel.TabIndex = 14;
            this.JoinDateLabel.Text = "Join Date :";
            this.JoinDateLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // JoinDateTime
            // 
            this.JoinDateTime.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.JoinDateTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JoinDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.JoinDateTime.Location = new System.Drawing.Point(144, 282);
            this.JoinDateTime.Margin = new System.Windows.Forms.Padding(4);
            this.JoinDateTime.Name = "JoinDateTime";
            this.JoinDateTime.Size = new System.Drawing.Size(207, 29);
            this.JoinDateTime.TabIndex = 15;
            // 
            // InfoGroupBox
            // 
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
            this.InfoGroupBox.Location = new System.Drawing.Point(13, 56);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.Size = new System.Drawing.Size(361, 518);
            this.InfoGroupBox.TabIndex = 1;
            this.InfoGroupBox.TabStop = false;
            // 
            // PaymentGroupBox
            // 
            this.PaymentGroupBox.Controls.Add(this.CurrentBalanceLabelBig);
            this.PaymentGroupBox.Controls.Add(this.PayButton);
            this.PaymentGroupBox.Controls.Add(this.SalaryAmountText);
            this.PaymentGroupBox.Controls.Add(this.PaySalaryLabel);
            this.PaymentGroupBox.Controls.Add(this.CurrentBalanceTextBig);
            this.PaymentGroupBox.Location = new System.Drawing.Point(380, 56);
            this.PaymentGroupBox.Name = "PaymentGroupBox";
            this.PaymentGroupBox.Size = new System.Drawing.Size(176, 196);
            this.PaymentGroupBox.TabIndex = 2;
            this.PaymentGroupBox.TabStop = false;
            this.PaymentGroupBox.Text = "Payment";
            // 
            // EmployeeInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(568, 585);
            this.Controls.Add(this.PaymentGroupBox);
            this.Controls.Add(this.InfoGroupBox);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EmployeeInformation";
            this.Text = "Employee Information";
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