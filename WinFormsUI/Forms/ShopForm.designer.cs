namespace WinFormsUI.Forms
{
    partial class ShopForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopForm));
            this.ShopSelectorCombo = new System.Windows.Forms.ComboBox();
            this.SelectShopLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.PhoneNumbersText = new System.Windows.Forms.RichTextBox();
            this.DeleteCancelButton = new System.Windows.Forms.Button();
            this.PhoneNumbersLabel = new System.Windows.Forms.Label();
            this.EmailAddressesText = new System.Windows.Forms.RichTextBox();
            this.EmailAddressesLabel = new System.Windows.Forms.Label();
            this.PropietorLabel = new System.Windows.Forms.Label();
            this.DetailsText = new System.Windows.Forms.RichTextBox();
            this.DetailsLabel = new System.Windows.Forms.Label();
            this.AddressText = new System.Windows.Forms.RichTextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.EditSaveButton = new System.Windows.Forms.Button();
            this.TaglineText = new System.Windows.Forms.TextBox();
            this.TaglineLabel = new System.Windows.Forms.Label();
            this.ShopNameText = new System.Windows.Forms.TextBox();
            this.ShopNameLabel = new System.Windows.Forms.Label();
            this.buttonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AddNewShopButton = new System.Windows.Forms.Button();
            this.PropietorNameText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ShopSelectorCombo
            // 
            this.ShopSelectorCombo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ShopSelectorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShopSelectorCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopSelectorCombo.FormattingEnabled = true;
            this.ShopSelectorCombo.Location = new System.Drawing.Point(158, 68);
            this.ShopSelectorCombo.Margin = new System.Windows.Forms.Padding(4);
            this.ShopSelectorCombo.Name = "ShopSelectorCombo";
            this.ShopSelectorCombo.Size = new System.Drawing.Size(342, 29);
            this.ShopSelectorCombo.TabIndex = 2;
            this.ShopSelectorCombo.SelectedIndexChanged += new System.EventHandler(this.ShopSelectorCombo_SelectedIndexChanged);
            // 
            // SelectShopLabel
            // 
            this.SelectShopLabel.AutoSize = true;
            this.SelectShopLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectShopLabel.Location = new System.Drawing.Point(11, 71);
            this.SelectShopLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectShopLabel.Name = "SelectShopLabel";
            this.SelectShopLabel.Size = new System.Drawing.Size(98, 21);
            this.SelectShopLabel.TabIndex = 1;
            this.SelectShopLabel.Text = "Select Shop :";
            this.SelectShopLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semi Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(7, 8);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(282, 47);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Shop Information";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // PhoneNumbersText
            // 
            this.PhoneNumbersText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PhoneNumbersText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneNumbersText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumbersText.Location = new System.Drawing.Point(158, 354);
            this.PhoneNumbersText.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneNumbersText.Name = "PhoneNumbersText";
            this.PhoneNumbersText.Size = new System.Drawing.Size(388, 67);
            this.PhoneNumbersText.TabIndex = 15;
            this.PhoneNumbersText.Text = "";
            // 
            // DeleteCancelButton
            // 
            this.DeleteCancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.DeleteCancelButton.FlatAppearance.BorderSize = 0;
            this.DeleteCancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.DeleteCancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(135)))));
            this.DeleteCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteCancelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteCancelButton.ForeColor = System.Drawing.Color.White;
            this.DeleteCancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteCancelButton.Location = new System.Drawing.Point(15, 509);
            this.DeleteCancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteCancelButton.Name = "DeleteCancelButton";
            this.DeleteCancelButton.Size = new System.Drawing.Size(260, 42);
            this.DeleteCancelButton.TabIndex = 19;
            this.DeleteCancelButton.Text = "Delete This Shop";
            this.DeleteCancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteCancelButton.UseVisualStyleBackColor = false;
            this.DeleteCancelButton.Click += new System.EventHandler(this.DeleteCancelButton_Click);
            // 
            // PhoneNumbersLabel
            // 
            this.PhoneNumbersLabel.AutoSize = true;
            this.PhoneNumbersLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumbersLabel.Location = new System.Drawing.Point(10, 354);
            this.PhoneNumbersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneNumbersLabel.Name = "PhoneNumbersLabel";
            this.PhoneNumbersLabel.Size = new System.Drawing.Size(130, 21);
            this.PhoneNumbersLabel.TabIndex = 14;
            this.PhoneNumbersLabel.Text = "Phone Numbers :";
            // 
            // EmailAddressesText
            // 
            this.EmailAddressesText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EmailAddressesText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailAddressesText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAddressesText.Location = new System.Drawing.Point(158, 430);
            this.EmailAddressesText.Margin = new System.Windows.Forms.Padding(4);
            this.EmailAddressesText.Name = "EmailAddressesText";
            this.EmailAddressesText.Size = new System.Drawing.Size(388, 67);
            this.EmailAddressesText.TabIndex = 17;
            this.EmailAddressesText.Text = "";
            // 
            // EmailAddressesLabel
            // 
            this.EmailAddressesLabel.AutoSize = true;
            this.EmailAddressesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAddressesLabel.Location = new System.Drawing.Point(10, 430);
            this.EmailAddressesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailAddressesLabel.Name = "EmailAddressesLabel";
            this.EmailAddressesLabel.Size = new System.Drawing.Size(134, 21);
            this.EmailAddressesLabel.TabIndex = 16;
            this.EmailAddressesLabel.Text = "Email Addresses : ";
            // 
            // PropietorLabel
            // 
            this.PropietorLabel.AutoSize = true;
            this.PropietorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PropietorLabel.Location = new System.Drawing.Point(10, 168);
            this.PropietorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PropietorLabel.Name = "PropietorLabel";
            this.PropietorLabel.Size = new System.Drawing.Size(82, 21);
            this.PropietorLabel.TabIndex = 8;
            this.PropietorLabel.Text = "Propietor :";
            // 
            // DetailsText
            // 
            this.DetailsText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DetailsText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetailsText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsText.Location = new System.Drawing.Point(158, 277);
            this.DetailsText.Margin = new System.Windows.Forms.Padding(4);
            this.DetailsText.Name = "DetailsText";
            this.DetailsText.Size = new System.Drawing.Size(388, 67);
            this.DetailsText.TabIndex = 13;
            this.DetailsText.Text = "";
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.AutoSize = true;
            this.DetailsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsLabel.Location = new System.Drawing.Point(10, 277);
            this.DetailsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(64, 21);
            this.DetailsLabel.TabIndex = 12;
            this.DetailsLabel.Text = "Details :";
            // 
            // AddressText
            // 
            this.AddressText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddressText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressText.Location = new System.Drawing.Point(158, 200);
            this.AddressText.Margin = new System.Windows.Forms.Padding(4);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(388, 67);
            this.AddressText.TabIndex = 11;
            this.AddressText.Text = "";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(10, 200);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(73, 21);
            this.AddressLabel.TabIndex = 10;
            this.AddressLabel.Text = "Address :";
            // 
            // EditSaveButton
            // 
            this.EditSaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.EditSaveButton.FlatAppearance.BorderSize = 0;
            this.EditSaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.EditSaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            this.EditSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditSaveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditSaveButton.ForeColor = System.Drawing.Color.White;
            this.EditSaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditSaveButton.Location = new System.Drawing.Point(287, 509);
            this.EditSaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditSaveButton.Name = "EditSaveButton";
            this.EditSaveButton.Size = new System.Drawing.Size(260, 42);
            this.EditSaveButton.TabIndex = 18;
            this.EditSaveButton.Text = "Save";
            this.EditSaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditSaveButton.UseVisualStyleBackColor = false;
            this.EditSaveButton.Click += new System.EventHandler(this.EditSaveButton_Click);
            // 
            // TaglineText
            // 
            this.TaglineText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TaglineText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TaglineText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaglineText.Location = new System.Drawing.Point(158, 136);
            this.TaglineText.Margin = new System.Windows.Forms.Padding(4);
            this.TaglineText.Name = "TaglineText";
            this.TaglineText.Size = new System.Drawing.Size(388, 22);
            this.TaglineText.TabIndex = 7;
            // 
            // TaglineLabel
            // 
            this.TaglineLabel.AutoSize = true;
            this.TaglineLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaglineLabel.Location = new System.Drawing.Point(10, 136);
            this.TaglineLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TaglineLabel.Name = "TaglineLabel";
            this.TaglineLabel.Size = new System.Drawing.Size(65, 21);
            this.TaglineLabel.TabIndex = 6;
            this.TaglineLabel.Text = "Tagline :";
            // 
            // ShopNameText
            // 
            this.ShopNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ShopNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShopNameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopNameText.Location = new System.Drawing.Point(159, 107);
            this.ShopNameText.Margin = new System.Windows.Forms.Padding(4);
            this.ShopNameText.Name = "ShopNameText";
            this.ShopNameText.Size = new System.Drawing.Size(388, 22);
            this.ShopNameText.TabIndex = 5;
            // 
            // ShopNameLabel
            // 
            this.ShopNameLabel.AutoSize = true;
            this.ShopNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopNameLabel.Location = new System.Drawing.Point(11, 107);
            this.ShopNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ShopNameLabel.Name = "ShopNameLabel";
            this.ShopNameLabel.Size = new System.Drawing.Size(99, 21);
            this.ShopNameLabel.TabIndex = 4;
            this.ShopNameLabel.Text = "Shop Name :";
            // 
            // AddNewShopButton
            // 
            this.AddNewShopButton.BackColor = System.Drawing.Color.White;
            this.AddNewShopButton.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Plus_Math_96px_11;
            this.AddNewShopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddNewShopButton.FlatAppearance.BorderSize = 0;
            this.AddNewShopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewShopButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewShopButton.ForeColor = System.Drawing.Color.Transparent;
            this.AddNewShopButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddNewShopButton.Location = new System.Drawing.Point(511, 64);
            this.AddNewShopButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddNewShopButton.Name = "AddNewShopButton";
            this.AddNewShopButton.Size = new System.Drawing.Size(35, 35);
            this.AddNewShopButton.TabIndex = 3;
            this.AddNewShopButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonToolTip.SetToolTip(this.AddNewShopButton, "Add a new shop");
            this.AddNewShopButton.UseVisualStyleBackColor = false;
            this.AddNewShopButton.Click += new System.EventHandler(this.AddNewShopButton_Click);
            // 
            // PropietorNameText
            // 
            this.PropietorNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PropietorNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PropietorNameText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PropietorNameText.Location = new System.Drawing.Point(158, 168);
            this.PropietorNameText.Margin = new System.Windows.Forms.Padding(4);
            this.PropietorNameText.Name = "PropietorNameText";
            this.PropietorNameText.Size = new System.Drawing.Size(388, 22);
            this.PropietorNameText.TabIndex = 9;
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(561, 568);
            this.Controls.Add(this.PropietorNameText);
            this.Controls.Add(this.PhoneNumbersText);
            this.Controls.Add(this.DeleteCancelButton);
            this.Controls.Add(this.PhoneNumbersLabel);
            this.Controls.Add(this.EmailAddressesText);
            this.Controls.Add(this.EmailAddressesLabel);
            this.Controls.Add(this.PropietorLabel);
            this.Controls.Add(this.DetailsText);
            this.Controls.Add(this.DetailsLabel);
            this.Controls.Add(this.AddressText);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.EditSaveButton);
            this.Controls.Add(this.TaglineText);
            this.Controls.Add(this.TaglineLabel);
            this.Controls.Add(this.ShopNameText);
            this.Controls.Add(this.ShopNameLabel);
            this.Controls.Add(this.AddNewShopButton);
            this.Controls.Add(this.ShopSelectorCombo);
            this.Controls.Add(this.SelectShopLabel);
            this.Controls.Add(this.TitleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ShopForm";
            this.Text = "Shops";
            this.Load += new System.EventHandler(this.ShopForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ShopSelectorCombo;
        private System.Windows.Forms.Label SelectShopLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button AddNewShopButton;
        private System.Windows.Forms.ToolTip buttonToolTip;
        private System.Windows.Forms.RichTextBox PhoneNumbersText;
        private System.Windows.Forms.Button DeleteCancelButton;
        private System.Windows.Forms.Label PhoneNumbersLabel;
        private System.Windows.Forms.RichTextBox EmailAddressesText;
        private System.Windows.Forms.Label EmailAddressesLabel;
        private System.Windows.Forms.Label PropietorLabel;
        private System.Windows.Forms.RichTextBox DetailsText;
        private System.Windows.Forms.Label DetailsLabel;
        private System.Windows.Forms.RichTextBox AddressText;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Button EditSaveButton;
        private System.Windows.Forms.TextBox TaglineText;
        private System.Windows.Forms.Label TaglineLabel;
        private System.Windows.Forms.TextBox ShopNameText;
        private System.Windows.Forms.Label ShopNameLabel;
        private System.Windows.Forms.TextBox PropietorNameText;
    }
}