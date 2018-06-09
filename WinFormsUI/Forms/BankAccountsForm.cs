using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopLibrary.Models;
using static ShopLibrary.GlobalConfig;
using static ShopLibrary.Models.UserRole;

namespace WinFormsUI.Forms {
    public partial class BankAccountsForm : Form {
    #region MakeDraggable
        /// <summary>
        ///     This Part Makes the Form Draggable, as the Form Has No Border
        /// </summary>
        public const int WmNclbuttondown = 0xA1;

        public const int HtCaption = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage (IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture ();

        private void MakeDraggable (object sender, MouseEventArgs e) {
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
        private void NumericValueValidation (object sender, KeyPressEventArgs e) {
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

        private List<Transaction> _groupedTransactions;

        public BankAccountsForm () {
            InitializeComponent();
        }

        private void BankAccountsForm_Load (object sender, EventArgs e) {
            TransactionsDataGrid.AutoGenerateColumns = false;
            var role = CurrentUser.AccessLevel;
            AddAccountButton.Enabled        = role <= Admin;
            EditAccountButton.Enabled       = role <= Admin;
            DeleteAccountButton.Enabled     = role <= Admin;
            AddTransactionButton.Enabled    = role <= AppUser;
            DeleteTransactionButton.Enabled = role <= Admin;
            WireUp();

            TransactionTypeSelectorCombo.SelectedIndex = 0;
        }

        private void WireUp () {
            BankAccounts         = Connection[0].GetBankAccountsAll();
            _groupedTransactions = Connection[0].GetTransactionsAll();

            AccountSelectorCombo.DataSource = null;
            AccountSelectorCombo.DataSource = BankAccounts
                                              .Select(ba => ba.AccountName + " - " + ba.CurrentBalance.ToString("N"))
                                              .ToList();
            AccountSelectorCombo_SelectedIndexChanged();
        }

        private void AccountSelectorCombo_SelectedIndexChanged () {
            TransactionsDataGrid.DataSource = null;
            TransactionsDataGrid.DataSource = _groupedTransactions;
            TransactionTypeSelectorCombo_SelectedIndexChanged();
        }

        private void TransactionTypeSelectorCombo_SelectedIndexChanged () {
            var index = AccountSelectorCombo.SelectedIndex;
            if (index >= 0)
                _groupedTransactions = Connection[0]
                    .GetTransactionsByBankAccount(
                                                  BankAccounts[index],
                                                  DateTime.Today.AddYears(-1),
                                                  DateTime.Now);

            if (TransactionTypeSelectorCombo.SelectedIndex == (int) TransactionType.Deposit)
                _groupedTransactions =
                    _groupedTransactions
                        .Where(t => t.TransactionType == TransactionType.Deposit)
                        .ToList();
            else if (TransactionTypeSelectorCombo.SelectedIndex == (int) TransactionType.Withdrawal)
                _groupedTransactions =
                    _groupedTransactions
                        .Where(t => t.TransactionType == TransactionType.Withdrawal)
                        .ToList();
            TransactionsDataGrid.DataSource = _groupedTransactions;
        }

        private void AccountSelectorCombo_SelectedIndexChanged (object sender, EventArgs e) =>
            AccountSelectorCombo_SelectedIndexChanged();

        private void TransactionTypeSelectorCombo_SelectedIndexChanged (object sender, EventArgs e) =>
            TransactionTypeSelectorCombo_SelectedIndexChanged();

        private void DeleteTransactionButton_Click (object sender, EventArgs e) {
            var confirm = MessageBox.Show("Are you sure want to delete "
                                                 + $"{TransactionsDataGrid.SelectedRows.Count} "
                                                 + "items?\n"
                                                 + "The deletion is permanent",
                                                   "Warning",
                                                   MessageBoxButtons.YesNo);

            if (confirm != DialogResult.Yes)
                return;

            foreach (DataGridViewRow row in TransactionsDataGrid.SelectedRows)
                Connection[0].DeleteTransaction(_groupedTransactions[row.Index]);

            MessageBox.Show("Transactions deleted successfully", "Success");
            WireUp();
        }

        private void PrintButton_Click (object sender, EventArgs e) =>

            // Todo -  Enable Printing
            MessageBox.Show("This feature is currently under development", "Information");

        private void AddAccountButton_Click (object sender, EventArgs e) {
            Form         form   = new BankAccountInformationForm();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
                WireUp();
        }

        private void EditAccountButton_Click (object sender, EventArgs e) {
            Form         form   = new BankAccountInformationForm(BankAccounts[AccountSelectorCombo.SelectedIndex]);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
                WireUp();
        }

        private async void DeleteAccountButton_ClickAsync (object sender, EventArgs e) {
            var confirm = MessageBox.Show("Do You Really Want to Delete"
                                                 + $"{AccountSelectorCombo.Text}?"
                                                 + "\nAll related Transactions will be deleted",
                                                   "Confirm",
                                                   MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes) {
                var res = await Connection[0].DeleteBankAccount(BankAccounts[AccountSelectorCombo.SelectedIndex]);
                if (res) {
                    MessageBox.Show("Deleted successfully", "Success");
                    WireUp();
                }
                else
                    MessageBox.Show("An error occurred", "Error");
            }
        }

        private void AddTransactionButton_Click (object sender, EventArgs e) {
            Form         form   = new TransactionForm();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
                WireUp();
        }

        private void ViewEditEmployeeButton_Click (object sender, EventArgs e) {
            var index = TransactionsDataGrid.CurrentRow.Index;

            if (index > -1) {
                Form form = new TransactionForm(_groupedTransactions[index]);
                form.ShowDialog();
            }
        }
    }
}
