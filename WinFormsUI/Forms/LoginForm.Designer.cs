using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsUI.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this._titleLabel = new System.Windows.Forms.Label();
            this._tagLineLabel = new System.Windows.Forms.Label();
            this._brotalLabel = new System.Windows.Forms.Label();
            this._userNameLabel = new System.Windows.Forms.Label();
            this._passwordLabel = new System.Windows.Forms.Label();
            this._passwordText = new System.Windows.Forms.TextBox();
            this._loginButton = new System.Windows.Forms.Button();
            this._exitButton = new System.Windows.Forms.Button();
            this._userNameCombo = new System.Windows.Forms.ComboBox();
            this._activateLinkText = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // _titleLabel
            // 
            this._titleLabel.AutoSize = true;
            this._titleLabel.Font = new System.Drawing.Font("Segoe UI Semi Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._titleLabel.Location = new System.Drawing.Point(27, 31);
            this._titleLabel.Name = "_titleLabel";
            this._titleLabel.Size = new System.Drawing.Size(307, 47);
            this._titleLabel.TabIndex = 0;
            this._titleLabel.Text = "Shop Management";
            this._titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // _tagLineLabel
            // 
            this._tagLineLabel.AutoSize = true;
            this._tagLineLabel.Font = new System.Drawing.Font("Segoe UI Semi Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._tagLineLabel.Location = new System.Drawing.Point(202, 78);
            this._tagLineLabel.Name = "_tagLineLabel";
            this._tagLineLabel.Size = new System.Drawing.Size(80, 17);
            this._tagLineLabel.TabIndex = 1;
            this._tagLineLabel.Text = "product from";
            this._tagLineLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // _brotalLabel
            // 
            this._brotalLabel.AutoSize = true;
            this._brotalLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._brotalLabel.Location = new System.Drawing.Point(279, 78);
            this._brotalLabel.Name = "_brotalLabel";
            this._brotalLabel.Size = new System.Drawing.Size(44, 17);
            this._brotalLabel.TabIndex = 2;
            this._brotalLabel.Text = "Brotal";
            this._brotalLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // _userNameLabel
            // 
            this._userNameLabel.AutoSize = true;
            this._userNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._userNameLabel.Location = new System.Drawing.Point(31, 116);
            this._userNameLabel.Name = "_userNameLabel";
            this._userNameLabel.Size = new System.Drawing.Size(95, 21);
            this._userNameLabel.TabIndex = 3;
            this._userNameLabel.Text = "User Name :";
            this._userNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // _passwordLabel
            // 
            this._passwordLabel.AutoSize = true;
            this._passwordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._passwordLabel.Location = new System.Drawing.Point(31, 155);
            this._passwordLabel.Name = "_passwordLabel";
            this._passwordLabel.Size = new System.Drawing.Size(83, 21);
            this._passwordLabel.TabIndex = 5;
            this._passwordLabel.Text = "Password :";
            this._passwordLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // _passwordText
            // 
            this._passwordText.BackColor = System.Drawing.Color.WhiteSmoke;
            this._passwordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._passwordText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._passwordText.Location = new System.Drawing.Point(132, 155);
            this._passwordText.Name = "_passwordText";
            this._passwordText.Size = new System.Drawing.Size(191, 22);
            this._passwordText.TabIndex = 6;
            this._passwordText.UseSystemPasswordChar = true;
            this._passwordText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordText_KeyDown);
            // 
            // _loginButton
            // 
            this._loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this._loginButton.FlatAppearance.BorderSize = 0;
            this._loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this._loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            this._loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._loginButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._loginButton.ForeColor = System.Drawing.Color.White;
            this._loginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._loginButton.Location = new System.Drawing.Point(35, 189);
            this._loginButton.Name = "_loginButton";
            this._loginButton.Size = new System.Drawing.Size(288, 40);
            this._loginButton.TabIndex = 7;
            this._loginButton.Text = "Login";
            this._loginButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._loginButton.UseVisualStyleBackColor = false;
            this._loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // _exitButton
            // 
            this._exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this._exitButton.FlatAppearance.BorderSize = 0;
            this._exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this._exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(135)))));
            this._exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._exitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._exitButton.ForeColor = System.Drawing.Color.White;
            this._exitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._exitButton.Location = new System.Drawing.Point(35, 238);
            this._exitButton.Name = "_exitButton";
            this._exitButton.Size = new System.Drawing.Size(288, 40);
            this._exitButton.TabIndex = 8;
            this._exitButton.Text = "Exit";
            this._exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this._exitButton.UseVisualStyleBackColor = false;
            this._exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // _userNameCombo
            // 
            this._userNameCombo.BackColor = System.Drawing.Color.White;
            this._userNameCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._userNameCombo.FormattingEnabled = true;
            this._userNameCombo.Location = new System.Drawing.Point(132, 113);
            this._userNameCombo.Name = "_userNameCombo";
            this._userNameCombo.Size = new System.Drawing.Size(191, 29);
            this._userNameCombo.TabIndex = 4;
            this._userNameCombo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserNameCombo_KeyDown);
            // 
            // _activateLinkText
            // 
            this._activateLinkText.AutoSize = true;
            this._activateLinkText.LinkColor = System.Drawing.Color.Black;
            this._activateLinkText.Location = new System.Drawing.Point(270, 290);
            this._activateLinkText.Name = "_activateLinkText";
            this._activateLinkText.Size = new System.Drawing.Size(53, 17);
            this._activateLinkText.TabIndex = 9;
            this._activateLinkText.TabStop = true;
            this._activateLinkText.Text = "Activate";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(354, 326);
            this.Controls.Add(this._activateLinkText);
            this.Controls.Add(this._userNameCombo);
            this.Controls.Add(this._exitButton);
            this.Controls.Add(this._loginButton);
            this.Controls.Add(this._passwordText);
            this.Controls.Add(this._passwordLabel);
            this.Controls.Add(this._userNameLabel);
            this.Controls.Add(this._brotalLabel);
            this.Controls.Add(this._tagLineLabel);
            this.Controls.Add(this._titleLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label _titleLabel;
        private Label _tagLineLabel;
        private Label _brotalLabel;
        private Label _userNameLabel;
        private Label _passwordLabel;
        private TextBox _passwordText;
        private Button _loginButton;
        private Button _exitButton;
        private ComboBox _userNameCombo;
        private LinkLabel _activateLinkText;
    }
}

