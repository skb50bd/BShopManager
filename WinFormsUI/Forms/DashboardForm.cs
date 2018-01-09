using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ShopLibrary.Models;
using static ShopLibrary.GlobalConfig;


namespace WinFormsUI.Forms {
    public partial class DashboardForm : Form
    {
        #region MakeDraggable
        /// <summary>
        ///     This Part Makes the Form Draggable, as the Form Has No Border
        /// </summary>
        public const int WmNclbuttondown = 0xA1;
        public const int HtCaption = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MakeDraggable(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WmNclbuttondown, HtCaption, 0);
            }
        }
        #endregion
        public DashboardForm()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            CurrentUserName.Text = CurrentUser.FullName;
            CurrentTimeLabel.Text = " | " + DateTime.Now.ToLocalTime().ToString("ddd, dd/MM/yyyy, hh:mm tt") + " | ";
            UpdateTimeTimer.Start();
        }

        private void LogoutLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Connection[0].Logout();
            CurrentUser = new User();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void UserSettingsButton_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
                if (form is UsersForm)
                {
                    form.Show();
                    if (form.WindowState == FormWindowState.Minimized)
                        form.WindowState = FormWindowState.Normal;
                    return;
                }
            Form u = new UsersForm();
            u.Show();
        }

        private void BankAccountsButton_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
                if (form is BankAccountsForm)
                {
                    form.Show();
                    if (form.WindowState == FormWindowState.Minimized)
                        form.WindowState = FormWindowState.Normal;
                    return;
                }
            Form b = new BankAccountsForm();
            b.Show();
        }

        private void TransactionButton_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
                if (form is BankAccountsForm)
                {
                    form.Show();
                    if (form.WindowState == FormWindowState.Minimized)
                        form.WindowState = FormWindowState.Normal;
                    return;
                }
            Form b = new BankAccountsForm();
            b.Show();
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
                if (form is CustomerForm) {
                    form.Show();
                    if (form.WindowState == FormWindowState.Minimized)
                        form.WindowState = FormWindowState.Normal;
                    return;
                }
            Form s = new CustomerForm();
            s.Show();
        }

        private void ShopSettingsButton_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
                if (form is ShopForm)
                {
                    form.Show();
                    if (form.WindowState == FormWindowState.Minimized)
                        form.WindowState = FormWindowState.Normal;
                    return;
                }
            Form s = new ShopForm();
            s.Show();
        }

        private void ItemsButton_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
                if (form is ProductsForm) {
                    form.Show();
                    if (form.WindowState == FormWindowState.Minimized)
                        form.WindowState = FormWindowState.Normal;
                    return;
                }
            Form p = new ProductsForm();
            p.Show();
        }

        private void SaleButton_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
                if (form is SaleForm) {
                    form.Show();
                    if (form.WindowState == FormWindowState.Minimized)
                        form.WindowState = FormWindowState.Normal;
                    return;
                }
            Form p = new SaleForm();
            p.Show();
        }

        private void ExpenseButton_Click(object sender, EventArgs e) {
            foreach (Form form in Application.OpenForms)
                if (form is ExpenseForm) {
                    form.Show();
                    if (form.WindowState == FormWindowState.Minimized)
                        form.WindowState = FormWindowState.Normal;
                    return;
                }
            Form p = new ExpenseForm();
            p.Show();
        }

        private void PurchaseButton_Click(object sender, EventArgs e) {
            foreach (Form form in Application.OpenForms)
                if (form is PurchaseForm) {
                    form.Show();
                    if (form.WindowState == FormWindowState.Minimized)
                        form.WindowState = FormWindowState.Normal;
                    return;
                }
            Form p = new PurchaseForm();
            p.Show();
        }

        private void RecordsButton_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
                if (form is ReportsForm) {
                    form.Show();
                    if (form.WindowState == FormWindowState.Minimized)
                        form.WindowState = FormWindowState.Normal;
                    return;
                }
            Form r = new ReportsForm();
            r.Show();
        }

        private void SuppliersButton_Click(object sender, EventArgs e) {
            foreach (Form form in Application.OpenForms)
                if (form is SupplierForm) {
                    form.Show();
                    if (form.WindowState == FormWindowState.Minimized)
                        form.WindowState = FormWindowState.Normal;
                    return;
                }
            Form s = new SupplierForm();
            s.Show();
        }

        private void EmployeeButton_Click(object sender, EventArgs e) {
            foreach (Form form in Application.OpenForms)
                if (form is EmployeeForm) {
                    form.Show();
                    if (form.WindowState == FormWindowState.Minimized)
                        form.WindowState = FormWindowState.Normal;
                    return;
                }
            Form s = new EmployeeForm();
            s.Show();
        }

        private void RefundButton_Click(object sender, EventArgs e) {
            foreach (Form form in Application.OpenForms)
                if (form is ReturnForm) {
                    form.Show();
                    if (form.WindowState == FormWindowState.Minimized)
                        form.WindowState = FormWindowState.Normal;
                    return;
                }
            Form s = new ReturnForm(ReturnType.Refund);
            s.Show();
        }

        private void PurchaseReturnButton_Click(object sender, EventArgs e) {
            foreach (Form form in Application.OpenForms)
                if (form is ReturnForm) {
                    form.Show();
                    if (form.WindowState == FormWindowState.Minimized)
                        form.WindowState = FormWindowState.Normal;
                    return;
                }
            Form s = new ReturnForm(ReturnType.PurchaseReturn);
            s.Show();
        }

        private void CashButton_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
                if (form is CashForm)
                {
                    form.Show();
                    if (form.WindowState == FormWindowState.Minimized)
                        form.WindowState = FormWindowState.Normal;
                    return;
                }
            Form s = new CashForm();
            s.Show();
        }

        // TODO - Complete the Dashboard

        // Show Status
        private void BackUpDb()
        {
            string dumpLocation;
                if(FolderBrowser.ShowDialog() == DialogResult.OK)
                    dumpLocation = FolderBrowser.SelectedPath;
            else
                return;

            dumpLocation += DateTime.Now.ToLocalTime().ToString("yyyymmddHHmmss");
            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "mongodump",
                    Arguments = "-d BShopManDb -o " + dumpLocation,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                }
            };
            process.OutputDataReceived += StandardOutputHandler;
            process.ErrorDataReceived  += StandardErrorHandler;
            //* Start process and handlers
            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
            process.WaitForExit();
        }

        private void RestoreDb()
        {
            string dumpLocation;
            if (FolderBrowser.ShowDialog() == DialogResult.OK)
                dumpLocation = FolderBrowser.SelectedPath;
            else
                return;

            Process process = new Process {
                StartInfo = new ProcessStartInfo {
                    FileName = "mongorestore",
                    Arguments = "-d BShopManDb " + dumpLocation,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                }
            };
            process.OutputDataReceived += StandardOutputHandler;
            process.ErrorDataReceived += StandardErrorHandler;
            //* Start process and handlers
            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
            process.WaitForExit();
        }

        void StandardOutputHandler(object sendingProcess, DataReceivedEventArgs outLine) {
           CurrentStatus.Text = "Complete";
           Debug.WriteLine(outLine.Data);
        }

        void StandardErrorHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            CurrentStatus.Text = "Error";
            Debug.WriteLine(outLine.Data);
        }

        private void ExportDatabaseToolStripMenuItem_Click(object sender, EventArgs e) => BackUpDb();

        private void UpdateTimeTimer_Tick(object sender, EventArgs e) => CurrentTimeLabel.Text = " | " + DateTime.Now.ToLocalTime().ToString("ddd, dd/MM/yyyy hh:mm tt");

        private void importDatabaseToolStripMenuItem_Click(object sender, EventArgs e) => RestoreDb();
    }
}