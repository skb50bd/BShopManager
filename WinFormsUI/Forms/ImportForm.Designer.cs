namespace WinFormsUI.Forms {
    partial class ImportForm {
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
            this.FilePathText = new System.Windows.Forms.TextBox();
            this.PathLabel = new System.Windows.Forms.Label();
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.CustomerButton = new System.Windows.Forms.Button();
            this.ProductButton = new System.Windows.Forms.Button();
            this.SupplierButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // FilePathText
            // 
            this.FilePathText.Location = new System.Drawing.Point(12, 42);
            this.FilePathText.Name = "FilePathText";
            this.FilePathText.Size = new System.Drawing.Size(440, 29);
            this.FilePathText.TabIndex = 1;
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(8, 18);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(106, 21);
            this.PathLabel.TabIndex = 0;
            this.PathLabel.Text = "Excel File Path";
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Location = new System.Drawing.Point(12, 77);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(440, 39);
            this.SelectFileButton.TabIndex = 2;
            this.SelectFileButton.Text = "Select File";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // CustomerButton
            // 
            this.CustomerButton.Location = new System.Drawing.Point(12, 149);
            this.CustomerButton.Name = "CustomerButton";
            this.CustomerButton.Size = new System.Drawing.Size(213, 43);
            this.CustomerButton.TabIndex = 3;
            this.CustomerButton.Text = "Import Customer";
            this.CustomerButton.UseVisualStyleBackColor = true;
            this.CustomerButton.Click += new System.EventHandler(this.CustomerButton_Click);
            // 
            // ProductButton
            // 
            this.ProductButton.Location = new System.Drawing.Point(12, 208);
            this.ProductButton.Name = "ProductButton";
            this.ProductButton.Size = new System.Drawing.Size(440, 43);
            this.ProductButton.TabIndex = 5;
            this.ProductButton.Text = "Import Product";
            this.ProductButton.UseVisualStyleBackColor = true;
            this.ProductButton.Click += new System.EventHandler(this.ProductButton_Click);
            // 
            // SupplierButton
            // 
            this.SupplierButton.Location = new System.Drawing.Point(244, 149);
            this.SupplierButton.Name = "SupplierButton";
            this.SupplierButton.Size = new System.Drawing.Size(208, 43);
            this.SupplierButton.TabIndex = 4;
            this.SupplierButton.Text = "Import Supplier";
            this.SupplierButton.UseVisualStyleBackColor = true;
            this.SupplierButton.Click += new System.EventHandler(this.SupplierButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 263);
            this.Controls.Add(this.SupplierButton);
            this.Controls.Add(this.ProductButton);
            this.Controls.Add(this.CustomerButton);
            this.Controls.Add(this.SelectFileButton);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.FilePathText);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ImportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FilePathText;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.Button CustomerButton;
        private System.Windows.Forms.Button ProductButton;
        private System.Windows.Forms.Button SupplierButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}