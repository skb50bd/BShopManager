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
            resources.ApplyResources(this.ShopSelectorCombo, "ShopSelectorCombo");
            this.ShopSelectorCombo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ShopSelectorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShopSelectorCombo.FormattingEnabled = true;
            this.ShopSelectorCombo.Name = "ShopSelectorCombo";
            this.buttonToolTip.SetToolTip(this.ShopSelectorCombo, resources.GetString("ShopSelectorCombo.ToolTip"));
            this.ShopSelectorCombo.SelectedIndexChanged += new System.EventHandler(this.ShopSelectorCombo_SelectedIndexChanged);
            // 
            // SelectShopLabel
            // 
            resources.ApplyResources(this.SelectShopLabel, "SelectShopLabel");
            this.SelectShopLabel.Name = "SelectShopLabel";
            this.buttonToolTip.SetToolTip(this.SelectShopLabel, resources.GetString("SelectShopLabel.ToolTip"));
            this.SelectShopLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TitleLabel
            // 
            resources.ApplyResources(this.TitleLabel, "TitleLabel");
            this.TitleLabel.Name = "TitleLabel";
            this.buttonToolTip.SetToolTip(this.TitleLabel, resources.GetString("TitleLabel.ToolTip"));
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // PhoneNumbersText
            // 
            resources.ApplyResources(this.PhoneNumbersText, "PhoneNumbersText");
            this.PhoneNumbersText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PhoneNumbersText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneNumbersText.Name = "PhoneNumbersText";
            this.buttonToolTip.SetToolTip(this.PhoneNumbersText, resources.GetString("PhoneNumbersText.ToolTip"));
            // 
            // DeleteCancelButton
            // 
            resources.ApplyResources(this.DeleteCancelButton, "DeleteCancelButton");
            this.DeleteCancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.DeleteCancelButton.FlatAppearance.BorderSize = 0;
            this.DeleteCancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.DeleteCancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(135)))));
            this.DeleteCancelButton.ForeColor = System.Drawing.Color.White;
            this.DeleteCancelButton.Name = "DeleteCancelButton";
            this.buttonToolTip.SetToolTip(this.DeleteCancelButton, resources.GetString("DeleteCancelButton.ToolTip"));
            this.DeleteCancelButton.UseVisualStyleBackColor = false;
            this.DeleteCancelButton.Click += new System.EventHandler(this.DeleteCancelButton_Click);
            // 
            // PhoneNumbersLabel
            // 
            resources.ApplyResources(this.PhoneNumbersLabel, "PhoneNumbersLabel");
            this.PhoneNumbersLabel.Name = "PhoneNumbersLabel";
            this.buttonToolTip.SetToolTip(this.PhoneNumbersLabel, resources.GetString("PhoneNumbersLabel.ToolTip"));
            // 
            // EmailAddressesText
            // 
            resources.ApplyResources(this.EmailAddressesText, "EmailAddressesText");
            this.EmailAddressesText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EmailAddressesText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailAddressesText.Name = "EmailAddressesText";
            this.buttonToolTip.SetToolTip(this.EmailAddressesText, resources.GetString("EmailAddressesText.ToolTip"));
            // 
            // EmailAddressesLabel
            // 
            resources.ApplyResources(this.EmailAddressesLabel, "EmailAddressesLabel");
            this.EmailAddressesLabel.Name = "EmailAddressesLabel";
            this.buttonToolTip.SetToolTip(this.EmailAddressesLabel, resources.GetString("EmailAddressesLabel.ToolTip"));
            // 
            // PropietorLabel
            // 
            resources.ApplyResources(this.PropietorLabel, "PropietorLabel");
            this.PropietorLabel.Name = "PropietorLabel";
            this.buttonToolTip.SetToolTip(this.PropietorLabel, resources.GetString("PropietorLabel.ToolTip"));
            // 
            // DetailsText
            // 
            resources.ApplyResources(this.DetailsText, "DetailsText");
            this.DetailsText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DetailsText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetailsText.Name = "DetailsText";
            this.buttonToolTip.SetToolTip(this.DetailsText, resources.GetString("DetailsText.ToolTip"));
            // 
            // DetailsLabel
            // 
            resources.ApplyResources(this.DetailsLabel, "DetailsLabel");
            this.DetailsLabel.Name = "DetailsLabel";
            this.buttonToolTip.SetToolTip(this.DetailsLabel, resources.GetString("DetailsLabel.ToolTip"));
            // 
            // AddressText
            // 
            resources.ApplyResources(this.AddressText, "AddressText");
            this.AddressText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddressText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressText.Name = "AddressText";
            this.buttonToolTip.SetToolTip(this.AddressText, resources.GetString("AddressText.ToolTip"));
            // 
            // AddressLabel
            // 
            resources.ApplyResources(this.AddressLabel, "AddressLabel");
            this.AddressLabel.Name = "AddressLabel";
            this.buttonToolTip.SetToolTip(this.AddressLabel, resources.GetString("AddressLabel.ToolTip"));
            // 
            // EditSaveButton
            // 
            resources.ApplyResources(this.EditSaveButton, "EditSaveButton");
            this.EditSaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.EditSaveButton.FlatAppearance.BorderSize = 0;
            this.EditSaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.EditSaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            this.EditSaveButton.ForeColor = System.Drawing.Color.White;
            this.EditSaveButton.Name = "EditSaveButton";
            this.buttonToolTip.SetToolTip(this.EditSaveButton, resources.GetString("EditSaveButton.ToolTip"));
            this.EditSaveButton.UseVisualStyleBackColor = false;
            this.EditSaveButton.Click += new System.EventHandler(this.EditSaveButton_Click);
            // 
            // TaglineText
            // 
            resources.ApplyResources(this.TaglineText, "TaglineText");
            this.TaglineText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TaglineText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TaglineText.Name = "TaglineText";
            this.buttonToolTip.SetToolTip(this.TaglineText, resources.GetString("TaglineText.ToolTip"));
            // 
            // TaglineLabel
            // 
            resources.ApplyResources(this.TaglineLabel, "TaglineLabel");
            this.TaglineLabel.Name = "TaglineLabel";
            this.buttonToolTip.SetToolTip(this.TaglineLabel, resources.GetString("TaglineLabel.ToolTip"));
            // 
            // ShopNameText
            // 
            resources.ApplyResources(this.ShopNameText, "ShopNameText");
            this.ShopNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ShopNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShopNameText.Name = "ShopNameText";
            this.buttonToolTip.SetToolTip(this.ShopNameText, resources.GetString("ShopNameText.ToolTip"));
            // 
            // ShopNameLabel
            // 
            resources.ApplyResources(this.ShopNameLabel, "ShopNameLabel");
            this.ShopNameLabel.Name = "ShopNameLabel";
            this.buttonToolTip.SetToolTip(this.ShopNameLabel, resources.GetString("ShopNameLabel.ToolTip"));
            // 
            // AddNewShopButton
            // 
            resources.ApplyResources(this.AddNewShopButton, "AddNewShopButton");
            this.AddNewShopButton.BackColor = System.Drawing.Color.White;
            this.AddNewShopButton.BackgroundImage = global::WinFormsUI.Properties.Resources.icons8_Plus_Math_96px_11;
            this.AddNewShopButton.FlatAppearance.BorderSize = 0;
            this.AddNewShopButton.ForeColor = System.Drawing.Color.Transparent;
            this.AddNewShopButton.Name = "AddNewShopButton";
            this.buttonToolTip.SetToolTip(this.AddNewShopButton, resources.GetString("AddNewShopButton.ToolTip"));
            this.AddNewShopButton.UseVisualStyleBackColor = false;
            this.AddNewShopButton.Click += new System.EventHandler(this.AddNewShopButton_Click);
            // 
            // PropietorNameText
            // 
            resources.ApplyResources(this.PropietorNameText, "PropietorNameText");
            this.PropietorNameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PropietorNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PropietorNameText.Name = "PropietorNameText";
            this.buttonToolTip.SetToolTip(this.PropietorNameText, resources.GetString("PropietorNameText.ToolTip"));
            // 
            // ShopForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ShopForm";
            this.buttonToolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
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