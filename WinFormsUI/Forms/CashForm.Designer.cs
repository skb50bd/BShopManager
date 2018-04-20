namespace WinFormsUI.Forms
{
    partial class CashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashForm));
            this.CashAmountLabel = new System.Windows.Forms.Label();
            this.CurrentDueTextBig = new System.Windows.Forms.Label();
            this.AddAmountLabel = new System.Windows.Forms.Label();
            this.LessAmount = new System.Windows.Forms.Label();
            this.NotesText = new System.Windows.Forms.RichTextBox();
            this.RemoveAmountText = new System.Windows.Forms.TextBox();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.AddAmountText = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.InputGroupBox = new System.Windows.Forms.GroupBox();
            this.CurrentStockAsset = new System.Windows.Forms.Label();
            this.CurrentStockAssetAmount = new System.Windows.Forms.Label();
            this.TotalReceivablesAmount = new System.Windows.Forms.Label();
            this.TotalReceivables = new System.Windows.Forms.Label();
            this.TotalPayablesAmount = new System.Windows.Forms.Label();
            this.TotalPayables = new System.Windows.Forms.Label();
            this.InputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CashAmountLabel
            // 
            resources.ApplyResources(this.CashAmountLabel, "CashAmountLabel");
            this.CashAmountLabel.Name = "CashAmountLabel";
            this.CashAmountLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // CurrentDueTextBig
            // 
            resources.ApplyResources(this.CurrentDueTextBig, "CurrentDueTextBig");
            this.CurrentDueTextBig.Name = "CurrentDueTextBig";
            this.CurrentDueTextBig.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // AddAmountLabel
            // 
            resources.ApplyResources(this.AddAmountLabel, "AddAmountLabel");
            this.AddAmountLabel.Name = "AddAmountLabel";
            this.AddAmountLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // LessAmount
            // 
            resources.ApplyResources(this.LessAmount, "LessAmount");
            this.LessAmount.Name = "LessAmount";
            this.LessAmount.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // NotesText
            // 
            resources.ApplyResources(this.NotesText, "NotesText");
            this.NotesText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NotesText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NotesText.Name = "NotesText";
            // 
            // RemoveAmountText
            // 
            resources.ApplyResources(this.RemoveAmountText, "RemoveAmountText");
            this.RemoveAmountText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RemoveAmountText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RemoveAmountText.Name = "RemoveAmountText";
            this.RemoveAmountText.TextChanged += new System.EventHandler(this.RemoveAmountText_TextChanged);
            this.RemoveAmountText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // NotesLabel
            // 
            resources.ApplyResources(this.NotesLabel, "NotesLabel");
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // AddAmountText
            // 
            resources.ApplyResources(this.AddAmountText, "AddAmountText");
            this.AddAmountText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddAmountText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddAmountText.Name = "AddAmountText";
            this.AddAmountText.TextChanged += new System.EventHandler(this.AddAmountText_TextChanged);
            this.AddAmountText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
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
            // InputGroupBox
            // 
            resources.ApplyResources(this.InputGroupBox, "InputGroupBox");
            this.InputGroupBox.Controls.Add(this.AddAmountLabel);
            this.InputGroupBox.Controls.Add(this.LessAmount);
            this.InputGroupBox.Controls.Add(this.NotesText);
            this.InputGroupBox.Controls.Add(this.RemoveAmountText);
            this.InputGroupBox.Controls.Add(this.NotesLabel);
            this.InputGroupBox.Controls.Add(this.AddAmountText);
            this.InputGroupBox.Controls.Add(this.SaveButton);
            this.InputGroupBox.Name = "InputGroupBox";
            this.InputGroupBox.TabStop = false;
            // 
            // CurrentStockAsset
            // 
            resources.ApplyResources(this.CurrentStockAsset, "CurrentStockAsset");
            this.CurrentStockAsset.Name = "CurrentStockAsset";
            // 
            // CurrentStockAssetAmount
            // 
            resources.ApplyResources(this.CurrentStockAssetAmount, "CurrentStockAssetAmount");
            this.CurrentStockAssetAmount.Name = "CurrentStockAssetAmount";
            // 
            // TotalReceivablesAmount
            // 
            resources.ApplyResources(this.TotalReceivablesAmount, "TotalReceivablesAmount");
            this.TotalReceivablesAmount.Name = "TotalReceivablesAmount";
            // 
            // TotalReceivables
            // 
            resources.ApplyResources(this.TotalReceivables, "TotalReceivables");
            this.TotalReceivables.Name = "TotalReceivables";
            // 
            // TotalPayablesAmount
            // 
            resources.ApplyResources(this.TotalPayablesAmount, "TotalPayablesAmount");
            this.TotalPayablesAmount.Name = "TotalPayablesAmount";
            // 
            // TotalPayables
            // 
            resources.ApplyResources(this.TotalPayables, "TotalPayables");
            this.TotalPayables.Name = "TotalPayables";
            // 
            // CashForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TotalPayablesAmount);
            this.Controls.Add(this.TotalPayables);
            this.Controls.Add(this.TotalReceivablesAmount);
            this.Controls.Add(this.TotalReceivables);
            this.Controls.Add(this.CurrentStockAssetAmount);
            this.Controls.Add(this.CurrentStockAsset);
            this.Controls.Add(this.InputGroupBox);
            this.Controls.Add(this.CashAmountLabel);
            this.Controls.Add(this.CurrentDueTextBig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CashForm";
            this.Load += new System.EventHandler(this.CashForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            this.InputGroupBox.ResumeLayout(false);
            this.InputGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CashAmountLabel;
        private System.Windows.Forms.Label CurrentDueTextBig;
        private System.Windows.Forms.Label AddAmountLabel;
        private System.Windows.Forms.Label LessAmount;
        private System.Windows.Forms.RichTextBox NotesText;
        private System.Windows.Forms.TextBox RemoveAmountText;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.TextBox AddAmountText;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.GroupBox InputGroupBox;
        private System.Windows.Forms.Label CurrentStockAsset;
        private System.Windows.Forms.Label CurrentStockAssetAmount;
        private System.Windows.Forms.Label TotalReceivablesAmount;
        private System.Windows.Forms.Label TotalReceivables;
        private System.Windows.Forms.Label TotalPayablesAmount;
        private System.Windows.Forms.Label TotalPayables;
    }
}