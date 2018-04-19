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
            resources.ApplyResources(this._titleLabel, "_titleLabel");
            this._titleLabel.Name = "_titleLabel";
            this._titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // _tagLineLabel
            // 
            resources.ApplyResources(this._tagLineLabel, "_tagLineLabel");
            this._tagLineLabel.Name = "_tagLineLabel";
            this._tagLineLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // _brotalLabel
            // 
            resources.ApplyResources(this._brotalLabel, "_brotalLabel");
            this._brotalLabel.Name = "_brotalLabel";
            this._brotalLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // _userNameLabel
            // 
            resources.ApplyResources(this._userNameLabel, "_userNameLabel");
            this._userNameLabel.Name = "_userNameLabel";
            this._userNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // _passwordLabel
            // 
            resources.ApplyResources(this._passwordLabel, "_passwordLabel");
            this._passwordLabel.Name = "_passwordLabel";
            this._passwordLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // _passwordText
            // 
            resources.ApplyResources(this._passwordText, "_passwordText");
            this._passwordText.BackColor = System.Drawing.Color.WhiteSmoke;
            this._passwordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._passwordText.Name = "_passwordText";
            this._passwordText.UseSystemPasswordChar = true;
            this._passwordText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordText_KeyDown);
            // 
            // _loginButton
            // 
            resources.ApplyResources(this._loginButton, "_loginButton");
            this._loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this._loginButton.FlatAppearance.BorderSize = 0;
            this._loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this._loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(207)))), ((int)(((byte)(154)))));
            this._loginButton.ForeColor = System.Drawing.Color.White;
            this._loginButton.Name = "_loginButton";
            this._loginButton.UseVisualStyleBackColor = false;
            this._loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // _exitButton
            // 
            resources.ApplyResources(this._exitButton, "_exitButton");
            this._exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this._exitButton.FlatAppearance.BorderSize = 0;
            this._exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this._exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(125)))), ((int)(((byte)(135)))));
            this._exitButton.ForeColor = System.Drawing.Color.White;
            this._exitButton.Name = "_exitButton";
            this._exitButton.UseVisualStyleBackColor = false;
            this._exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // _userNameCombo
            // 
            resources.ApplyResources(this._userNameCombo, "_userNameCombo");
            this._userNameCombo.BackColor = System.Drawing.Color.White;
            this._userNameCombo.FormattingEnabled = true;
            this._userNameCombo.Name = "_userNameCombo";
            this._userNameCombo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserNameCombo_KeyDown);
            // 
            // _activateLinkText
            // 
            resources.ApplyResources(this._activateLinkText, "_activateLinkText");
            this._activateLinkText.LinkColor = System.Drawing.Color.Black;
            this._activateLinkText.Name = "_activateLinkText";
            this._activateLinkText.TabStop = true;
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
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

