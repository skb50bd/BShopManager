using System;
using System.Configuration;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ShopLibrary.Models;
using static ShopLibrary.GlobalConfig;
using static ShopLibrary.Models.UserRole;

namespace WinFormsUI.Forms {
    public partial class BankAccountInformationForm : Form {
        ResourceManager rm = new ResourceManager(typeof(BankAccountInformationForm));
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
        #region NumericValidation
        /// <summary>
        ///     This Function Checks if The Field has valid Numeric value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumericValueValidation(object sender, KeyPressEventArgs e) {
            // allows 0-9, backspace, and decimal
            if ((e.KeyChar < 0x30 || e.KeyChar > 0x39) && e.KeyChar != 0x8 && e.KeyChar != 0x2E && e.KeyChar != 0x2D) {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
        }
        #endregion

        private BankAccount _account { get; }
        public BankAccountInformationForm() {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            _account = new BankAccount();
        }

        public BankAccountInformationForm(BankAccount account) {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            _account = account;
            TitleLabel.Text = _account.AccountName;
            if (ConfigurationManager.AppSettings["Language"] == "bn-BD")
            {
                AddButton.Text = rm.GetString("Update");
            }
            else
                AddButton.Text = "Update account";
        }

        private bool ValidateForm() {
            var message = string.Empty;
            if (AddButton.Text == "Add account" || AddButton.Text == rm.GetString("AddButton.Text"))
                if (BankAccounts.Any(a => a.AccountName == AccountNameText.Text))
                    message += "Invalid or duplicate account name";
            else
                if (BankAccounts.Any(a => a.AccountName == AccountNameText.Text && a.BankAccountId!= _account.BankAccountId))
                    message += "Invalid or duplicate account name";
            if (BankNameText.Text.Length == 0)
                message += "Empty bank name";
            if (AccountNumberText.Text.Length == 0)
                message += "Empty account number";
            if (decimal.TryParse(CurrentBalanceText.Text, out var m) == false || m < 0)
                message += "Invalid current balance";

            if (message.Length == 0)
                return true;
            MessageBox.Show("These error(s) occurred during validation \n" + message, "Error");
            return false;
        }

        private void AccountInformation_Load(object sender, EventArgs e) {
            AccountNameText.Text = _account.AccountName;
            BankNameText.Text = _account.BankName;
            AccountNumberText.Text = _account.AccountNumber;
            CurrentBalanceText.Text = _account.CurrentBalance.ToString("N");
            NoteText.Text = _account.Note;

            if (CurrentUser.AccessLevel != Root
                && CurrentUser.AccessLevel != Admin) {
                AccountNameText.Enabled = false;
                BankNameText.Enabled = false;
                AccountNumberText.Enabled = false;
                CurrentBalanceText.Enabled = false;
                NoteText.Enabled = false;
            }
        }

        private void AddButton_Click(object sender, EventArgs e) {
            if (ValidateForm()) {
                _account.AccountName = AccountNameText.Text;
                _account.BankName = BankNameText.Text;
                _account.AccountNumber = AccountNumberText.Text;
                _account.CurrentBalance = decimal.Parse(CurrentBalanceText.Text);
                _account.Note = NoteText.Text;

                if (AddButton.Text == "Add Account" || AddButton.Text == rm.GetString("AddButton.Text"))
                    Connection[0].InsertBankAccount(_account);
                else
                    Connection[0].UpdateBankAccount(_account);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
