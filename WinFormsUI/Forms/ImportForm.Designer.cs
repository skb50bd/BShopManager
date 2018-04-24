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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportForm));
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
            resources.ApplyResources(this.FilePathText, "FilePathText");
            this.FilePathText.Name = "FilePathText";
            // 
            // PathLabel
            // 
            resources.ApplyResources(this.PathLabel, "PathLabel");
            this.PathLabel.Name = "PathLabel";
            // 
            // SelectFileButton
            // 
            resources.ApplyResources(this.SelectFileButton, "SelectFileButton");
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // CustomerButton
            // 
            resources.ApplyResources(this.CustomerButton, "CustomerButton");
            this.CustomerButton.Name = "CustomerButton";
            this.CustomerButton.UseVisualStyleBackColor = true;
            this.CustomerButton.Click += new System.EventHandler(this.CustomerButton_Click);
            // 
            // ProductButton
            // 
            resources.ApplyResources(this.ProductButton, "ProductButton");
            this.ProductButton.Name = "ProductButton";
            this.ProductButton.UseVisualStyleBackColor = true;
            this.ProductButton.Click += new System.EventHandler(this.ProductButton_Click);
            // 
            // SupplierButton
            // 
            resources.ApplyResources(this.SupplierButton, "SupplierButton");
            this.SupplierButton.Name = "SupplierButton";
            this.SupplierButton.UseVisualStyleBackColor = true;
            this.SupplierButton.Click += new System.EventHandler(this.SupplierButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // ImportForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.SupplierButton);
            this.Controls.Add(this.ProductButton);
            this.Controls.Add(this.CustomerButton);
            this.Controls.Add(this.SelectFileButton);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.FilePathText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ImportForm";
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