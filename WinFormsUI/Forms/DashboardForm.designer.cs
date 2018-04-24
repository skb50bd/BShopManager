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
            resources.ApplyResources(this.TitleLabel, "TitleLabel");
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // LogoutLinkLabel
            // 
            resources.ApplyResources(this.LogoutLinkLabel, "LogoutLinkLabel");
            this.LogoutLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.LogoutLinkLabel.Name = "LogoutLinkLabel";
            this.LogoutLinkLabel.TabStop = true;
            this.LogoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
            // 
            // BrotalLabel
            // 
            resources.ApplyResources(this.BrotalLabel, "BrotalLabel");
            this.BrotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.BrotalLabel.Name = "BrotalLabel";
            this.BrotalLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // TagLineLabel
            // 
            resources.ApplyResources(this.TagLineLabel, "TagLineLabel");
            this.TagLineLabel.BackColor = System.Drawing.Color.Transparent;
            this.TagLineLabel.Name = "TagLineLabel";
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
            resources.ApplyResources(this.CurrentUserName, "CurrentUserName");
            this.CurrentUserName.Name = "CurrentUserName";
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
            resources.ApplyResources(this.OptionsDropDown, "OptionsDropDown");
            this.OptionsDropDown.Name = "OptionsDropDown";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportDatabaseToolStripMenuItem,
            this.exportToJsonToolStripMenuItem,
            this.exportSessionLogToJsonToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            resources.ApplyResources(this.exportToolStripMenuItem, "exportToolStripMenuItem");
            // 
            // exportDatabaseToolStripMenuItem
            // 
            this.exportDatabaseToolStripMenuItem.Name = "exportDatabaseToolStripMenuItem";
            resources.ApplyResources(this.exportDatabaseToolStripMenuItem, "exportDatabaseToolStripMenuItem");
            this.exportDatabaseToolStripMenuItem.Click += new System.EventHandler(this.ExportDatabaseToolStripMenuItem_Click);
            // 
            // exportToJsonToolStripMenuItem
            // 
            this.exportToJsonToolStripMenuItem.Name = "exportToJsonToolStripMenuItem";
            resources.ApplyResources(this.exportToJsonToolStripMenuItem, "exportToJsonToolStripMenuItem");
            // 
            // exportSessionLogToJsonToolStripMenuItem
            // 
            this.exportSessionLogToJsonToolStripMenuItem.Name = "exportSessionLogToJsonToolStripMenuItem";
            resources.ApplyResources(this.exportSessionLogToJsonToolStripMenuItem, "exportSessionLogToJsonToolStripMenuItem");
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importDatabaseToolStripMenuItem,
            this.importFromExcelToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            resources.ApplyResources(this.importToolStripMenuItem, "importToolStripMenuItem");
            // 
            // importDatabaseToolStripMenuItem
            // 
            this.importDatabaseToolStripMenuItem.Name = "importDatabaseToolStripMenuItem";
            resources.ApplyResources(this.importDatabaseToolStripMenuItem, "importDatabaseToolStripMenuItem");
            this.importDatabaseToolStripMenuItem.Click += new System.EventHandler(this.importDatabaseToolStripMenuItem_Click);
            // 
            // importFromExcelToolStripMenuItem
            // 
            this.importFromExcelToolStripMenuItem.Name = "importFromExcelToolStripMenuItem";
            resources.ApplyResources(this.importFromExcelToolStripMenuItem, "importFromExcelToolStripMenuItem");
            this.importFromExcelToolStripMenuItem.Click += new System.EventHandler(this.importFromExcelToolStripMenuItem_Click);
            // 
            // CurrentTimeLabel
            // 
            this.CurrentTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.CurrentTimeLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.CurrentTimeLabel, "CurrentTimeLabel");
            this.CurrentTimeLabel.Name = "CurrentTimeLabel";
            this.CurrentTimeLabel.Spring = true;
            this.CurrentTimeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // StatusStrip
            // 
            resources.ApplyResources(this.StatusStrip, "StatusStrip");
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurrentUserName,
            this.OptionsDropDown,
            this.CurrentTimeLabel,
            this.CurrentStatus});
            this.StatusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.SizingGrip = false;
            this.StatusStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MakeDraggable);
            // 
            // CurrentStatus
            // 
            this.CurrentStatus.BackColor = System.Drawing.Color.Transparent;
            this.CurrentStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.CurrentStatus, "CurrentStatus");
            this.CurrentStatus.Name = "CurrentStatus";
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
            resources.ApplyResources(this.CashButton, "CashButton");
            this.CashButton.ForeColor = System.Drawing.Color.White;
            this.CashButton.Image = global::WinFormsUI.Properties.Resources.icons8_Cash_Register_528px;
            this.CashButton.ImagePosition = 19;
            this.CashButton.ImageZoom = 50;
            this.CashButton.LabelPosition = 36;
            this.CashButton.LabelText = "Cash";
            this.CashButton.Name = "CashButton";
            this.CashButton.Click += new System.EventHandler(this.CashButton_Click);
            // 
            // PurchaseReturnButton
            // 
            this.PurchaseReturnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.PurchaseReturnButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.PurchaseReturnButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.PurchaseReturnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.PurchaseReturnButton, "PurchaseReturnButton");
            this.PurchaseReturnButton.ForeColor = System.Drawing.Color.White;
            this.PurchaseReturnButton.Image = global::WinFormsUI.Properties.Resources.icons8_Return_Purchase_500px;
            this.PurchaseReturnButton.ImagePosition = 19;
            this.PurchaseReturnButton.ImageZoom = 50;
            this.PurchaseReturnButton.LabelPosition = 36;
            this.PurchaseReturnButton.LabelText = "Purchase Return";
            this.PurchaseReturnButton.Name = "PurchaseReturnButton";
            this.PurchaseReturnButton.Click += new System.EventHandler(this.PurchaseReturnButton_Click);
            // 
            // PurchaseButton
            // 
            this.PurchaseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.PurchaseButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(184)))), ((int)(((byte)(104)))));
            this.PurchaseButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(122)))), ((int)(((byte)(69)))));
            this.PurchaseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.PurchaseButton, "PurchaseButton");
            this.PurchaseButton.ForeColor = System.Drawing.Color.White;
            this.PurchaseButton.Image = global::WinFormsUI.Properties.Resources.icons8_Buy_500px;
            this.PurchaseButton.ImagePosition = 19;
            this.PurchaseButton.ImageZoom = 50;
            this.PurchaseButton.LabelPosition = 36;
            this.PurchaseButton.LabelText = "Purchase";
            this.PurchaseButton.Name = "PurchaseButton";
            this.PurchaseButton.Click += new System.EventHandler(this.PurchaseButton_Click);
            // 
            // EmployeeButton
            // 
            this.EmployeeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.EmployeeButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.EmployeeButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(46)))), ((int)(((byte)(170)))));
            this.EmployeeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.EmployeeButton, "EmployeeButton");
            this.EmployeeButton.ForeColor = System.Drawing.Color.White;
            this.EmployeeButton.Image = global::WinFormsUI.Properties.Resources.icons8_Employee_500px;
            this.EmployeeButton.ImagePosition = 19;
            this.EmployeeButton.ImageZoom = 50;
            this.EmployeeButton.LabelPosition = 36;
            this.EmployeeButton.LabelText = "Emploees";
            this.EmployeeButton.Name = "EmployeeButton";
            this.EmployeeButton.Click += new System.EventHandler(this.EmployeeButton_Click);
            // 
            // SuppliersButton
            // 
            this.SuppliersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.SuppliersButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.SuppliersButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(46)))), ((int)(((byte)(170)))));
            this.SuppliersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.SuppliersButton, "SuppliersButton");
            this.SuppliersButton.ForeColor = System.Drawing.Color.White;
            this.SuppliersButton.Image = global::WinFormsUI.Properties.Resources.icons8_Supplier_500px;
            this.SuppliersButton.ImagePosition = 19;
            this.SuppliersButton.ImageZoom = 50;
            this.SuppliersButton.LabelPosition = 36;
            this.SuppliersButton.LabelText = "Supliers";
            this.SuppliersButton.Name = "SuppliersButton";
            this.SuppliersButton.Click += new System.EventHandler(this.SuppliersButton_Click);
            // 
            // ShopSettingsButton
            // 
            this.ShopSettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.ShopSettingsButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.ShopSettingsButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.ShopSettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.ShopSettingsButton, "ShopSettingsButton");
            this.ShopSettingsButton.ForeColor = System.Drawing.Color.White;
            this.ShopSettingsButton.Image = global::WinFormsUI.Properties.Resources.icons8_Shop_500px;
            this.ShopSettingsButton.ImagePosition = 19;
            this.ShopSettingsButton.ImageZoom = 50;
            this.ShopSettingsButton.LabelPosition = 36;
            this.ShopSettingsButton.LabelText = "Settings";
            this.ShopSettingsButton.Name = "ShopSettingsButton";
            this.ShopSettingsButton.Click += new System.EventHandler(this.ShopSettingsButton_Click);
            // 
            // ExpenseButton
            // 
            this.ExpenseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(207)))), ((int)(((byte)(19)))));
            this.ExpenseButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(207)))), ((int)(((byte)(19)))));
            this.ExpenseButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(138)))), ((int)(((byte)(12)))));
            this.ExpenseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.ExpenseButton, "ExpenseButton");
            this.ExpenseButton.ForeColor = System.Drawing.Color.White;
            this.ExpenseButton.Image = global::WinFormsUI.Properties.Resources.icons8_General_Ledger_500px;
            this.ExpenseButton.ImagePosition = 19;
            this.ExpenseButton.ImageZoom = 50;
            this.ExpenseButton.LabelPosition = 36;
            this.ExpenseButton.LabelText = "Expense";
            this.ExpenseButton.Name = "ExpenseButton";
            this.ExpenseButton.Click += new System.EventHandler(this.ExpenseButton_Click);
            // 
            // SaleButton
            // 
            this.SaleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.SaleButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.SaleButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(170)))));
            this.SaleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.SaleButton, "SaleButton");
            this.SaleButton.ForeColor = System.Drawing.Color.White;
            this.SaleButton.Image = global::WinFormsUI.Properties.Resources.icons8_Sell_500px;
            this.SaleButton.ImagePosition = 19;
            this.SaleButton.ImageZoom = 25;
            this.SaleButton.LabelPosition = 36;
            this.SaleButton.LabelText = "Sale";
            this.SaleButton.Name = "SaleButton";
            this.SaleButton.Click += new System.EventHandler(this.SaleButton_Click);
            // 
            // RecordsButton
            // 
            this.RecordsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.RecordsButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.RecordsButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.RecordsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.RecordsButton, "RecordsButton");
            this.RecordsButton.ForeColor = System.Drawing.Color.White;
            this.RecordsButton.Image = global::WinFormsUI.Properties.Resources.icons8_Moleskine_500px;
            this.RecordsButton.ImagePosition = 40;
            this.RecordsButton.ImageZoom = 60;
            this.RecordsButton.LabelPosition = 36;
            this.RecordsButton.LabelText = "Reports";
            this.RecordsButton.Name = "RecordsButton";
            this.RecordsButton.Click += new System.EventHandler(this.RecordsButton_Click);
            // 
            // RefundButton
            // 
            this.RefundButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.RefundButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.RefundButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(170)))));
            this.RefundButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.RefundButton, "RefundButton");
            this.RefundButton.ForeColor = System.Drawing.Color.White;
            this.RefundButton.Image = global::WinFormsUI.Properties.Resources.icons8_Refund_500px;
            this.RefundButton.ImagePosition = 19;
            this.RefundButton.ImageZoom = 50;
            this.RefundButton.LabelPosition = 36;
            this.RefundButton.LabelText = "Refund";
            this.RefundButton.Name = "RefundButton";
            this.RefundButton.Click += new System.EventHandler(this.RefundButton_Click);
            // 
            // BankTransactionButton
            // 
            this.BankTransactionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(190)))), ((int)(((byte)(199)))));
            this.BankTransactionButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(190)))), ((int)(((byte)(199)))));
            this.BankTransactionButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(126)))), ((int)(((byte)(132)))));
            this.BankTransactionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BankTransactionButton, "BankTransactionButton");
            this.BankTransactionButton.ForeColor = System.Drawing.Color.White;
            this.BankTransactionButton.Image = global::WinFormsUI.Properties.Resources.icons8_Bank_Building_500px;
            this.BankTransactionButton.ImagePosition = 19;
            this.BankTransactionButton.ImageZoom = 50;
            this.BankTransactionButton.LabelPosition = 36;
            this.BankTransactionButton.LabelText = "Transaction";
            this.BankTransactionButton.Name = "BankTransactionButton";
            this.BankTransactionButton.Click += new System.EventHandler(this.TransactionButton_Click);
            // 
            // UserSettingsButton
            // 
            this.UserSettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.UserSettingsButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.UserSettingsButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.UserSettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.UserSettingsButton, "UserSettingsButton");
            this.UserSettingsButton.ForeColor = System.Drawing.Color.White;
            this.UserSettingsButton.Image = global::WinFormsUI.Properties.Resources.icons8_User_Account_500px;
            this.UserSettingsButton.ImagePosition = 19;
            this.UserSettingsButton.ImageZoom = 50;
            this.UserSettingsButton.LabelPosition = 36;
            this.UserSettingsButton.LabelText = "User Settings";
            this.UserSettingsButton.Name = "UserSettingsButton";
            this.UserSettingsButton.Click += new System.EventHandler(this.UserSettingsButton_Click);
            // 
            // CustomersButton
            // 
            this.CustomersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.CustomersButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.CustomersButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(46)))), ((int)(((byte)(170)))));
            this.CustomersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.CustomersButton, "CustomersButton");
            this.CustomersButton.ForeColor = System.Drawing.Color.White;
            this.CustomersButton.Image = global::WinFormsUI.Properties.Resources.icons8_Customer_500px_1;
            this.CustomersButton.ImagePosition = 19;
            this.CustomersButton.ImageZoom = 50;
            this.CustomersButton.LabelPosition = 36;
            this.CustomersButton.LabelText = "Customers";
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Click += new System.EventHandler(this.CustomersButton_Click);
            // 
            // ItemsButton
            // 
            this.ItemsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(41)))));
            this.ItemsButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(41)))));
            this.ItemsButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(84)))), ((int)(((byte)(27)))));
            this.ItemsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.ItemsButton, "ItemsButton");
            this.ItemsButton.ForeColor = System.Drawing.Color.White;
            this.ItemsButton.Image = global::WinFormsUI.Properties.Resources.icons8_Inventory_Flow_500px_1;
            this.ItemsButton.ImagePosition = 19;
            this.ItemsButton.ImageZoom = 50;
            this.ItemsButton.LabelPosition = 36;
            this.ItemsButton.LabelText = "Inventory";
            this.ItemsButton.Name = "ItemsButton";
            this.ItemsButton.Click += new System.EventHandler(this.ItemsButton_Click);
            // 
            // DashboardForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DashboardForm";
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