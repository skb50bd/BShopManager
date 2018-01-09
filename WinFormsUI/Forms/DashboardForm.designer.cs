namespace WinFormsUI.Forms
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.LogoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.BrotalLabel = new System.Windows.Forms.Label();
            this.TagLineLabel = new System.Windows.Forms.Label();
            this.UpdateTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.CloudBackUpTimer = new System.Windows.Forms.Timer(this.components);
            this.CurrentUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.OptionsDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToJsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportSessionLogToJsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CurrentTimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.CurrentStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.CashButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.PurchaseReturnButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.PurchaseButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.EmployeeButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuppliersButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.ShopSettingsButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.ExpenseButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.SaleButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.RecordsButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.RefundButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.BankTransactionButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.UserSettingsButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.CustomersButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.ItemsButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI Semi Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(7, 11);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(307, 47);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Shop Management";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // LogoutLinkLabel
            // 
            this.LogoutLinkLabel.AutoSize = true;
            this.LogoutLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.LogoutLinkLabel.Location = new System.Drawing.Point(707, 51);
            this.LogoutLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogoutLinkLabel.Name = "LogoutLinkLabel";
            this.LogoutLinkLabel.Size = new System.Drawing.Size(59, 21);
            this.LogoutLinkLabel.TabIndex = 3;
            this.LogoutLinkLabel.TabStop = true;
            this.LogoutLinkLabel.Text = "Logout";
            this.LogoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
            // 
            // BrotalLabel
            // 
            this.BrotalLabel.AutoSize = true;
            this.BrotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.BrotalLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrotalLabel.Location = new System.Drawing.Point(89, 54);
            this.BrotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BrotalLabel.Name = "BrotalLabel";
            this.BrotalLabel.Size = new System.Drawing.Size(44, 17);
            this.BrotalLabel.TabIndex = 2;
            this.BrotalLabel.Text = "Brotal";
            this.BrotalLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TagLineLabel
            // 
            this.TagLineLabel.AutoSize = true;
            this.TagLineLabel.BackColor = System.Drawing.Color.Transparent;
            this.TagLineLabel.Font = new System.Drawing.Font("Segoe UI Semi Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TagLineLabel.Location = new System.Drawing.Point(12, 54);
            this.TagLineLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TagLineLabel.Name = "TagLineLabel";
            this.TagLineLabel.Size = new System.Drawing.Size(80, 17);
            this.TagLineLabel.TabIndex = 1;
            this.TagLineLabel.Text = "product from";
            this.TagLineLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // UpdateTimeTimer
            // 
            this.UpdateTimeTimer.Interval = 60000;
            this.UpdateTimeTimer.Tick += new System.EventHandler(this.UpdateTimeTimer_Tick);
            // 
            // CloudBackUpTimer
            // 
            this.CloudBackUpTimer.Interval = 600000;
            // 
            // CurrentUserName
            // 
            this.CurrentUserName.BackColor = System.Drawing.Color.Transparent;
            this.CurrentUserName.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CurrentUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentUserName.Name = "CurrentUserName";
            this.CurrentUserName.Size = new System.Drawing.Size(137, 22);
            this.CurrentUserName.Text = "CurrentUserName";
            this.CurrentUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CurrentUserName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // OptionsDropDown
            // 
            this.OptionsDropDown.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.OptionsDropDown.BackColor = System.Drawing.Color.Transparent;
            this.OptionsDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OptionsDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem});
            this.OptionsDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OptionsDropDown.Name = "OptionsDropDown";
            this.OptionsDropDown.Size = new System.Drawing.Size(78, 25);
            this.OptionsDropDown.Text = "Options";
            this.OptionsDropDown.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportDatabaseToolStripMenuItem,
            this.exportToJsonToolStripMenuItem,
            this.exportSessionLogToJsonToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // exportDatabaseToolStripMenuItem
            // 
            this.exportDatabaseToolStripMenuItem.Name = "exportDatabaseToolStripMenuItem";
            this.exportDatabaseToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.exportDatabaseToolStripMenuItem.Text = "Export Database";
            this.exportDatabaseToolStripMenuItem.Click += new System.EventHandler(this.ExportDatabaseToolStripMenuItem_Click);
            // 
            // exportToJsonToolStripMenuItem
            // 
            this.exportToJsonToolStripMenuItem.Name = "exportToJsonToolStripMenuItem";
            this.exportToJsonToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.exportToJsonToolStripMenuItem.Text = "Export to Json";
            // 
            // exportSessionLogToJsonToolStripMenuItem
            // 
            this.exportSessionLogToJsonToolStripMenuItem.Name = "exportSessionLogToJsonToolStripMenuItem";
            this.exportSessionLogToJsonToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.exportSessionLogToJsonToolStripMenuItem.Text = "Export Session Log to Json";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importDatabaseToolStripMenuItem,
            this.importFromExcelToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // importDatabaseToolStripMenuItem
            // 
            this.importDatabaseToolStripMenuItem.Name = "importDatabaseToolStripMenuItem";
            this.importDatabaseToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.importDatabaseToolStripMenuItem.Text = "Import Database";
            this.importDatabaseToolStripMenuItem.Click += new System.EventHandler(this.importDatabaseToolStripMenuItem_Click);
            // 
            // importFromExcelToolStripMenuItem
            // 
            this.importFromExcelToolStripMenuItem.Name = "importFromExcelToolStripMenuItem";
            this.importFromExcelToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.importFromExcelToolStripMenuItem.Text = "Import from Excel";
            // 
            // CurrentTimeLabel
            // 
            this.CurrentTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.CurrentTimeLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CurrentTimeLabel.Enabled = false;
            this.CurrentTimeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTimeLabel.Name = "CurrentTimeLabel";
            this.CurrentTimeLabel.Size = new System.Drawing.Size(97, 22);
            this.CurrentTimeLabel.Spring = true;
            this.CurrentTimeLabel.Text = "CurrentTime";
            this.CurrentTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CurrentTimeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurrentUserName,
            this.OptionsDropDown,
            this.CurrentTimeLabel,
            this.CurrentStatus});
            this.StatusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.StatusStrip.Location = new System.Drawing.Point(0, 472);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(777, 27);
            this.StatusStrip.SizingGrip = false;
            this.StatusStrip.TabIndex = 20;
            this.StatusStrip.Text = "StatusStrip";
            this.StatusStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // CurrentStatus
            // 
            this.CurrentStatus.BackColor = System.Drawing.Color.Transparent;
            this.CurrentStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CurrentStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentStatus.Name = "CurrentStatus";
            this.CurrentStatus.Size = new System.Drawing.Size(80, 22);
            this.CurrentStatus.Text = "Status: OK";
            this.CurrentStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CurrentStatus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // FolderBrowser
            // 
            this.FolderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // CashButton
            // 
            this.CashButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(190)))), ((int)(((byte)(199)))));
            this.CashButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(190)))), ((int)(((byte)(199)))));
            this.CashButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(126)))), ((int)(((byte)(132)))));
            this.CashButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CashButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashButton.ForeColor = System.Drawing.Color.White;
            this.CashButton.Image = global::WinFormsUI.Properties.Resources.icons8_Cash_Register_528px;
            this.CashButton.ImagePosition = 19;
            this.CashButton.ImageZoom = 50;
            this.CashButton.LabelPosition = 36;
            this.CashButton.LabelText = "Cash";
            this.CashButton.Location = new System.Drawing.Point(389, 337);
            this.CashButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CashButton.Name = "CashButton";
            this.CashButton.Size = new System.Drawing.Size(125, 125);
            this.CashButton.TabIndex = 21;
            this.CashButton.Click += new System.EventHandler(this.CashButton_Click);
            // 
            // PurchaseReturnButton
            // 
            this.PurchaseReturnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.PurchaseReturnButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.PurchaseReturnButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.PurchaseReturnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PurchaseReturnButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseReturnButton.ForeColor = System.Drawing.Color.White;
            this.PurchaseReturnButton.Image = global::WinFormsUI.Properties.Resources.icons8_Return_Purchase_500px;
            this.PurchaseReturnButton.ImagePosition = 19;
            this.PurchaseReturnButton.ImageZoom = 50;
            this.PurchaseReturnButton.LabelPosition = 36;
            this.PurchaseReturnButton.LabelText = "Purchase Return";
            this.PurchaseReturnButton.Location = new System.Drawing.Point(137, 337);
            this.PurchaseReturnButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PurchaseReturnButton.Name = "PurchaseReturnButton";
            this.PurchaseReturnButton.Size = new System.Drawing.Size(125, 125);
            this.PurchaseReturnButton.TabIndex = 13;
            this.PurchaseReturnButton.Click += new System.EventHandler(this.PurchaseReturnButton_Click);
            // 
            // PurchaseButton
            // 
            this.PurchaseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.PurchaseButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.PurchaseButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.PurchaseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PurchaseButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseButton.ForeColor = System.Drawing.Color.White;
            this.PurchaseButton.Image = global::WinFormsUI.Properties.Resources.icons8_Buy_500px;
            this.PurchaseButton.ImagePosition = 19;
            this.PurchaseButton.ImageZoom = 50;
            this.PurchaseButton.LabelPosition = 36;
            this.PurchaseButton.LabelText = "Purchase";
            this.PurchaseButton.Location = new System.Drawing.Point(11, 337);
            this.PurchaseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PurchaseButton.Name = "PurchaseButton";
            this.PurchaseButton.Size = new System.Drawing.Size(125, 125);
            this.PurchaseButton.TabIndex = 12;
            this.PurchaseButton.Click += new System.EventHandler(this.PurchaseButton_Click);
            // 
            // EmployeeButton
            // 
            this.EmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.EmployeeButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.EmployeeButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(46)))), ((int)(((byte)(170)))));
            this.EmployeeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmployeeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeButton.ForeColor = System.Drawing.Color.White;
            this.EmployeeButton.Image = global::WinFormsUI.Properties.Resources.icons8_Employee_500px;
            this.EmployeeButton.ImagePosition = 19;
            this.EmployeeButton.ImageZoom = 50;
            this.EmployeeButton.LabelPosition = 36;
            this.EmployeeButton.LabelText = "Employees";
            this.EmployeeButton.Location = new System.Drawing.Point(389, 211);
            this.EmployeeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmployeeButton.Name = "EmployeeButton";
            this.EmployeeButton.Size = new System.Drawing.Size(125, 125);
            this.EmployeeButton.TabIndex = 11;
            this.EmployeeButton.Click += new System.EventHandler(this.EmployeeButton_Click);
            // 
            // SuppliersButton
            // 
            this.SuppliersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.SuppliersButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.SuppliersButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(46)))), ((int)(((byte)(170)))));
            this.SuppliersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SuppliersButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppliersButton.ForeColor = System.Drawing.Color.White;
            this.SuppliersButton.Image = global::WinFormsUI.Properties.Resources.icons8_Supplier_500px;
            this.SuppliersButton.ImagePosition = 19;
            this.SuppliersButton.ImageZoom = 50;
            this.SuppliersButton.LabelPosition = 36;
            this.SuppliersButton.LabelText = "Suppliers";
            this.SuppliersButton.Location = new System.Drawing.Point(263, 211);
            this.SuppliersButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SuppliersButton.Name = "SuppliersButton";
            this.SuppliersButton.Size = new System.Drawing.Size(125, 125);
            this.SuppliersButton.TabIndex = 10;
            this.SuppliersButton.Click += new System.EventHandler(this.SuppliersButton_Click);
            // 
            // ShopSettingsButton
            // 
            this.ShopSettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.ShopSettingsButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.ShopSettingsButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.ShopSettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShopSettingsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopSettingsButton.ForeColor = System.Drawing.Color.White;
            this.ShopSettingsButton.Image = global::WinFormsUI.Properties.Resources.icons8_Shop_500px;
            this.ShopSettingsButton.ImagePosition = 19;
            this.ShopSettingsButton.ImageZoom = 50;
            this.ShopSettingsButton.LabelPosition = 36;
            this.ShopSettingsButton.LabelText = "Shop Settings";
            this.ShopSettingsButton.Location = new System.Drawing.Point(515, 337);
            this.ShopSettingsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShopSettingsButton.Name = "ShopSettingsButton";
            this.ShopSettingsButton.Size = new System.Drawing.Size(125, 125);
            this.ShopSettingsButton.TabIndex = 15;
            this.ShopSettingsButton.Click += new System.EventHandler(this.ShopSettingsButton_Click);
            // 
            // ExpenseButton
            // 
            this.ExpenseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(207)))), ((int)(((byte)(19)))));
            this.ExpenseButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(207)))), ((int)(((byte)(19)))));
            this.ExpenseButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(138)))), ((int)(((byte)(12)))));
            this.ExpenseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExpenseButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseButton.ForeColor = System.Drawing.Color.White;
            this.ExpenseButton.Image = global::WinFormsUI.Properties.Resources.icons8_General_Ledger_500px;
            this.ExpenseButton.ImagePosition = 19;
            this.ExpenseButton.ImageZoom = 50;
            this.ExpenseButton.LabelPosition = 36;
            this.ExpenseButton.LabelText = "Expense";
            this.ExpenseButton.Location = new System.Drawing.Point(137, 211);
            this.ExpenseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExpenseButton.Name = "ExpenseButton";
            this.ExpenseButton.Size = new System.Drawing.Size(125, 125);
            this.ExpenseButton.TabIndex = 9;
            this.ExpenseButton.Click += new System.EventHandler(this.ExpenseButton_Click);
            // 
            // SaleButton
            // 
            this.SaleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.SaleButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.SaleButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(170)))));
            this.SaleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaleButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleButton.ForeColor = System.Drawing.Color.White;
            this.SaleButton.Image = global::WinFormsUI.Properties.Resources.icons8_Sell_500px;
            this.SaleButton.ImagePosition = 19;
            this.SaleButton.ImageZoom = 25;
            this.SaleButton.LabelPosition = 36;
            this.SaleButton.LabelText = "Sale";
            this.SaleButton.Location = new System.Drawing.Point(11, 85);
            this.SaleButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.SaleButton.Name = "SaleButton";
            this.SaleButton.Size = new System.Drawing.Size(251, 125);
            this.SaleButton.TabIndex = 4;
            this.SaleButton.Click += new System.EventHandler(this.SaleButton_Click);
            // 
            // RecordsButton
            // 
            this.RecordsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.RecordsButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.RecordsButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.RecordsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecordsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsButton.ForeColor = System.Drawing.Color.White;
            this.RecordsButton.Image = global::WinFormsUI.Properties.Resources.icons8_Moleskine_500px;
            this.RecordsButton.ImagePosition = 40;
            this.RecordsButton.ImageZoom = 60;
            this.RecordsButton.LabelPosition = 36;
            this.RecordsButton.LabelText = "Records";
            this.RecordsButton.Location = new System.Drawing.Point(515, 85);
            this.RecordsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RecordsButton.Name = "RecordsButton";
            this.RecordsButton.Size = new System.Drawing.Size(251, 251);
            this.RecordsButton.TabIndex = 7;
            this.RecordsButton.Click += new System.EventHandler(this.RecordsButton_Click);
            // 
            // RefundButton
            // 
            this.RefundButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.RefundButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.RefundButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(170)))));
            this.RefundButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefundButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefundButton.ForeColor = System.Drawing.Color.White;
            this.RefundButton.Image = global::WinFormsUI.Properties.Resources.icons8_Refund_500px;
            this.RefundButton.ImagePosition = 19;
            this.RefundButton.ImageZoom = 50;
            this.RefundButton.LabelPosition = 36;
            this.RefundButton.LabelText = "Refund";
            this.RefundButton.Location = new System.Drawing.Point(11, 211);
            this.RefundButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RefundButton.Name = "RefundButton";
            this.RefundButton.Size = new System.Drawing.Size(125, 125);
            this.RefundButton.TabIndex = 8;
            this.RefundButton.Click += new System.EventHandler(this.RefundButton_Click);
            // 
            // BankTransactionButton
            // 
            this.BankTransactionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(190)))), ((int)(((byte)(199)))));
            this.BankTransactionButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(190)))), ((int)(((byte)(199)))));
            this.BankTransactionButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(126)))), ((int)(((byte)(132)))));
            this.BankTransactionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BankTransactionButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankTransactionButton.ForeColor = System.Drawing.Color.White;
            this.BankTransactionButton.Image = global::WinFormsUI.Properties.Resources.icons8_Bank_Building_500px;
            this.BankTransactionButton.ImagePosition = 19;
            this.BankTransactionButton.ImageZoom = 50;
            this.BankTransactionButton.LabelPosition = 36;
            this.BankTransactionButton.LabelText = "Transaction";
            this.BankTransactionButton.Location = new System.Drawing.Point(263, 337);
            this.BankTransactionButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BankTransactionButton.Name = "BankTransactionButton";
            this.BankTransactionButton.Size = new System.Drawing.Size(125, 125);
            this.BankTransactionButton.TabIndex = 14;
            this.BankTransactionButton.Click += new System.EventHandler(this.TransactionButton_Click);
            // 
            // UserSettingsButton
            // 
            this.UserSettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.UserSettingsButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.UserSettingsButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.UserSettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserSettingsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserSettingsButton.ForeColor = System.Drawing.Color.White;
            this.UserSettingsButton.Image = global::WinFormsUI.Properties.Resources.icons8_User_Account_500px;
            this.UserSettingsButton.ImagePosition = 19;
            this.UserSettingsButton.ImageZoom = 50;
            this.UserSettingsButton.LabelPosition = 36;
            this.UserSettingsButton.LabelText = "User Settings";
            this.UserSettingsButton.Location = new System.Drawing.Point(641, 337);
            this.UserSettingsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserSettingsButton.Name = "UserSettingsButton";
            this.UserSettingsButton.Size = new System.Drawing.Size(125, 125);
            this.UserSettingsButton.TabIndex = 16;
            this.UserSettingsButton.Click += new System.EventHandler(this.UserSettingsButton_Click);
            // 
            // CustomersButton
            // 
            this.CustomersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.CustomersButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.CustomersButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(46)))), ((int)(((byte)(170)))));
            this.CustomersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomersButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomersButton.ForeColor = System.Drawing.Color.White;
            this.CustomersButton.Image = global::WinFormsUI.Properties.Resources.icons8_Customer_500px_1;
            this.CustomersButton.ImagePosition = 19;
            this.CustomersButton.ImageZoom = 50;
            this.CustomersButton.LabelPosition = 36;
            this.CustomersButton.LabelText = "Customers";
            this.CustomersButton.Location = new System.Drawing.Point(389, 85);
            this.CustomersButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Size = new System.Drawing.Size(125, 125);
            this.CustomersButton.TabIndex = 6;
            this.CustomersButton.Click += new System.EventHandler(this.CustomersButton_Click);
            // 
            // ItemsButton
            // 
            this.ItemsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(41)))));
            this.ItemsButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(41)))));
            this.ItemsButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(84)))), ((int)(((byte)(27)))));
            this.ItemsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ItemsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsButton.ForeColor = System.Drawing.Color.White;
            this.ItemsButton.Image = global::WinFormsUI.Properties.Resources.icons8_Inventory_Flow_500px_1;
            this.ItemsButton.ImagePosition = 19;
            this.ItemsButton.ImageZoom = 50;
            this.ItemsButton.LabelPosition = 36;
            this.ItemsButton.LabelText = "Inventory";
            this.ItemsButton.Location = new System.Drawing.Point(263, 85);
            this.ItemsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ItemsButton.Name = "ItemsButton";
            this.ItemsButton.Size = new System.Drawing.Size(125, 125);
            this.ItemsButton.TabIndex = 5;
            this.ItemsButton.Click += new System.EventHandler(this.ItemsButton_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 499);
            this.Controls.Add(this.CashButton);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.PurchaseReturnButton);
            this.Controls.Add(this.PurchaseButton);
            this.Controls.Add(this.EmployeeButton);
            this.Controls.Add(this.SuppliersButton);
            this.Controls.Add(this.ShopSettingsButton);
            this.Controls.Add(this.ExpenseButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.BrotalLabel);
            this.Controls.Add(this.TagLineLabel);
            this.Controls.Add(this.SaleButton);
            this.Controls.Add(this.RecordsButton);
            this.Controls.Add(this.RefundButton);
            this.Controls.Add(this.BankTransactionButton);
            this.Controls.Add(this.UserSettingsButton);
            this.Controls.Add(this.CustomersButton);
            this.Controls.Add(this.LogoutLinkLabel);
            this.Controls.Add(this.ItemsButton);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DashboardForm";
            this.Text = "Shop Management";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.LinkLabel LogoutLinkLabel;
        private Bunifu.Framework.UI.BunifuTileButton SaleButton;
        private Bunifu.Framework.UI.BunifuTileButton ItemsButton;
        private Bunifu.Framework.UI.BunifuTileButton RecordsButton;
        private Bunifu.Framework.UI.BunifuTileButton CustomersButton;
        private Bunifu.Framework.UI.BunifuTileButton UserSettingsButton;
        private System.Windows.Forms.Label BrotalLabel;
        private System.Windows.Forms.Label TagLineLabel;
        private Bunifu.Framework.UI.BunifuTileButton ExpenseButton;
        private Bunifu.Framework.UI.BunifuTileButton ShopSettingsButton;
        private Bunifu.Framework.UI.BunifuTileButton RefundButton;
        private Bunifu.Framework.UI.BunifuTileButton BankTransactionButton;
        private Bunifu.Framework.UI.BunifuTileButton SuppliersButton;
        private Bunifu.Framework.UI.BunifuTileButton EmployeeButton;
        private Bunifu.Framework.UI.BunifuTileButton PurchaseButton;
        private Bunifu.Framework.UI.BunifuTileButton PurchaseReturnButton;
        private System.Windows.Forms.Timer UpdateTimeTimer;
        private System.Windows.Forms.Timer CloudBackUpTimer;
        private System.Windows.Forms.ToolStripStatusLabel CurrentUserName;
        private System.Windows.Forms.ToolStripDropDownButton OptionsDropDown;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToJsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportSessionLogToJsonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFromExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel CurrentTimeLabel;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel CurrentStatus;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private Bunifu.Framework.UI.BunifuTileButton CashButton;
    }
}