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
            this.InputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CashAmountLabel
            // 
            this.CashAmountLabel.AutoSize = true;
            this.CashAmountLabel.Font = new System.Drawing.Font("Segoe UI Semi Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashAmountLabel.Location = new System.Drawing.Point(10, 39);
            this.CashAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CashAmountLabel.Name = "CashAmountLabel";
            this.CashAmountLabel.Size = new System.Drawing.Size(186, 47);
            this.CashAmountLabel.TabIndex = 2;
            this.CashAmountLabel.Text = "<Amount>";
            this.CashAmountLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // CurrentDueTextBig
            // 
            this.CurrentDueTextBig.AutoSize = true;
            this.CurrentDueTextBig.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentDueTextBig.Location = new System.Drawing.Point(13, 9);
            this.CurrentDueTextBig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentDueTextBig.Name = "CurrentDueTextBig";
            this.CurrentDueTextBig.Size = new System.Drawing.Size(211, 30);
            this.CurrentDueTextBig.TabIndex = 3;
            this.CurrentDueTextBig.Text = "Current Cash Balance";
            this.CurrentDueTextBig.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // AddAmountLabel
            // 
            this.AddAmountLabel.AutoSize = true;
            this.AddAmountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAmountLabel.Location = new System.Drawing.Point(4, 25);
            this.AddAmountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddAmountLabel.Name = "AddAmountLabel";
            this.AddAmountLabel.Size = new System.Drawing.Size(105, 21);
            this.AddAmountLabel.TabIndex = 17;
            this.AddAmountLabel.Text = "Add Amount :";
            this.AddAmountLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // LessAmount
            // 
            this.LessAmount.AutoSize = true;
            this.LessAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LessAmount.Location = new System.Drawing.Point(4, 63);
            this.LessAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LessAmount.Name = "LessAmount";
            this.LessAmount.Size = new System.Drawing.Size(134, 21);
            this.LessAmount.TabIndex = 19;
            this.LessAmount.Text = "Remove Amount :";
            this.LessAmount.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // NotesText
            // 
            this.NotesText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NotesText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NotesText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesText.Location = new System.Drawing.Point(144, 98);
            this.NotesText.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.NotesText.Name = "NotesText";
            this.NotesText.Size = new System.Drawing.Size(207, 51);
            this.NotesText.TabIndex = 22;
            this.NotesText.Text = "";
            // 
            // RemoveAmountText
            // 
            this.RemoveAmountText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RemoveAmountText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RemoveAmountText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveAmountText.Location = new System.Drawing.Point(144, 63);
            this.RemoveAmountText.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveAmountText.Name = "RemoveAmountText";
            this.RemoveAmountText.Size = new System.Drawing.Size(207, 22);
            this.RemoveAmountText.TabIndex = 20;
            this.RemoveAmountText.TextChanged += new System.EventHandler(this.RemoveAmountText_TextChanged);
            this.RemoveAmountText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesLabel.Location = new System.Drawing.Point(4, 98);
            this.NotesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(58, 21);
            this.NotesLabel.TabIndex = 21;
            this.NotesLabel.Text = "Notes :";
            this.NotesLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // AddAmountText
            // 
            this.AddAmountText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddAmountText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddAmountText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAmountText.Location = new System.Drawing.Point(144, 24);
            this.AddAmountText.Margin = new System.Windows.Forms.Padding(4);
            this.AddAmountText.Name = "AddAmountText";
            this.AddAmountText.Size = new System.Drawing.Size(207, 22);
            this.AddAmountText.TabIndex = 18;
            this.AddAmountText.TextChanged += new System.EventHandler(this.AddAmountText_TextChanged);
            this.AddAmountText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericValueValidation);
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
            this.SaveButton.Location = new System.Drawing.Point(10, 164);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(341, 42);
            this.SaveButton.TabIndex = 23;
            this.SaveButton.Text = "Save";
            this.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // InputGroupBox
            // 
            this.InputGroupBox.Controls.Add(this.AddAmountLabel);
            this.InputGroupBox.Controls.Add(this.LessAmount);
            this.InputGroupBox.Controls.Add(this.NotesText);
            this.InputGroupBox.Controls.Add(this.RemoveAmountText);
            this.InputGroupBox.Controls.Add(this.NotesLabel);
            this.InputGroupBox.Controls.Add(this.AddAmountText);
            this.InputGroupBox.Controls.Add(this.SaveButton);
            this.InputGroupBox.Location = new System.Drawing.Point(8, 94);
            this.InputGroupBox.Name = "InputGroupBox";
            this.InputGroupBox.Size = new System.Drawing.Size(360, 216);
            this.InputGroupBox.TabIndex = 24;
            this.InputGroupBox.TabStop = false;
            // 
            // CashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(376, 317);
            this.Controls.Add(this.InputGroupBox);
            this.Controls.Add(this.CashAmountLabel);
            this.Controls.Add(this.CurrentDueTextBig);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cash";
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
    }
}