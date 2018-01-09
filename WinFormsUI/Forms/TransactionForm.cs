using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MongoDB.Bson;
using ShopLibrary.Models;
using static ShopLibrary.GlobalConfig;
using static ShopLibrary.Models.UserRole;

namespace WinFormsUI.Forms {
    public partial class TransactionForm : Form {
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

        private Transaction _transaction;
        public TransactionForm() {
            InitializeComponent();
            _transaction = new Transaction();
            DialogResult = DialogResult.Cancel;
        }

        public TransactionForm(Transaction transaction)
        {
            InitializeComponent();
            _transaction = transaction;
            DialogResult = DialogResult.Cancel;
            ControlsGroupBox.Enabled = false;
        }

        private void LoadTransaction()
        {
            TransactionDateTime.Value          = _transaction.Meta.Created;
            AccountSelectorCombo.SelectedIndex = BankAccounts.FindIndex(a => a.ObjectId == _transaction.BankAccountId);
            TypeSelectorCombo.SelectedIndex    = (int)_transaction.TransactionType - 1;
            AmountText.Text                    = _transaction.Amount.ToString("0.##");
            IndividualCombo.Text               = _transaction.Individual;
            TransactionCodeText.Text           = _transaction.TransactionCode;
            CheckNoText.Text                   = _transaction.CheckNumber;
            NoteText.Text                      = _transaction.Note;
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            if (CurrentUser.AccessLevel >= AppUser)
                Close();

            AccountSelectorCombo.DataSource = null;
            AccountSelectorCombo.DataSource = BankAccounts;
            IndividualCombo.DataSource = null;
            IndividualCombo.DataSource = Customers;

            if (_transaction.ObjectId != ObjectId.Empty)
                LoadTransaction();
            IndividualCombo.SelectedIndex = -1;
        }

        private bool ValidateForm() {
            string message = string.Empty;
            string warning = string.Empty;
            if (TransactionDateTime.Value.Date < DateTime.Now.Date - TimeSpan.Parse("07:00:00:00"))
                message += "Invalid Date\n";
            if (AccountSelectorCombo.Text.Length == 0)
                message += "Invalid or Empty Bank Account\n";
            if (TypeSelectorCombo.Text != "Deposit" && TypeSelectorCombo.Text != "Withdrawal")
                message += "Invalid Transaction Type\n";
            if (!decimal.TryParse(AmountText.Text, out decimal m) || m < 0)
                message += "Invalid Amount\n";
            if (TypeSelectorCombo.Text == "Withdrawal" &&
                m > BankAccounts[AccountSelectorCombo.SelectedIndex].CurrentBalance)
                message += "Withdrawal amount is greater than Current Balance";

            if (CheckNoText.Text.Length == 0 && TransactionCodeText.Text.Length == 0)
                warning += "Both Check Number and Transaction Code fields are empty\n";

            if (message.Length > 0 || warning.Length > 0) {
                DialogResult result
                    = MessageBox.Show("The following error occurred while validating the form\n" + message +
                                      "\nThe following warnings should be addressed\n" + warning +
                                      "\n\nDo you want to ignore the warnings?",
                        "Attention",
                        MessageBoxButtons.YesNo);
                if (message.Length > 0 || result != DialogResult.Yes)
                    return false;
            }
            return true;
        }

        private void ResetForm() {
            TransactionDateTime.Value          = DateTime.Now;
            AccountSelectorCombo.SelectedIndex = 0;
            TypeSelectorCombo.SelectedIndex    = 0;
            AmountText.Text                    = "";
            IndividualCombo.Text               = "";
            TransactionCodeText.Text           = "";
            CheckNoText.Text                   = "";
            NoteText.Text                      = "";
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            if (!ValidateForm())
                return;
            Transaction model   = new Transaction {
                BankAccountId       = BankAccounts[AccountSelectorCombo.SelectedIndex].ObjectId,
                BankAccountName     = BankAccounts[AccountSelectorCombo.SelectedIndex].AccountName,
                TransactionType = (TransactionType)(TypeSelectorCombo.SelectedIndex + 1),
                Amount          = decimal.Parse(AmountText.Text),
                Individual      = IndividualCombo.Text,
                CustomerId      = IndividualCombo.SelectedIndex == -1
                                    ? ObjectId.Empty
                                    : Customers[IndividualCombo.SelectedIndex].ObjectId,
                TransactionCode = TransactionCodeText.Text,
                CheckNumber     = CheckNoText.Text,
                Note            = NoteText.Text,
                Meta            = new Metadata(TransactionDateTime.Value, CurrentUser.UserName)
            };

            DialogResult result = MessageBox.Show("Are you sure want to add this transaction?", "Confirm",
                MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
                return;

            DialogResult = DialogResult.OK;
            model = Connection[0].InsertTransaction(model);
            if (model.ObjectId != ObjectId.Empty) {
                MessageBox.Show("Transaction added");
                ResetForm();
            }
        }
    }
}