using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ShopLibrary.Models;
using static ShopLibrary.GlobalConfig;
using static ShopLibrary.Models.UserRole;

namespace WinFormsUI.Forms {
    public partial class CustomerInformationForm : Form {
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
        private Customer _customer = new Customer();

        public CustomerInformationForm() {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;

            SaveButton.Text = "Submit";
            _customer = new Customer();

            DueCollectionGroupBox.Enabled = false;
        }

        public CustomerInformationForm(Customer model) {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;

            SaveButton.Text = "Save";
            _customer = model;
            TitleLabel.Text = _customer.CustomerId;

            UserRole role                 = CurrentUser.AccessLevel;
            DueCollectionGroupBox.Enabled = role <= AppUser;
            InfoGroupBox.Enabled          = role <= AppUser;
            CurrentDueText.Enabled        = role <= Admin;
        }

        private void CustomerInformationForm_Load(object sender, EventArgs e) {
            FullNameText.Text      = _customer.FullName;
            NickNameText.Text      = _customer.NickName;
            CompanyText.Text       = _customer.CompanyName;
            ContactNumberText.Text = _customer.Phone;
            EmailAddressText.Text  = _customer.EmailAddress;
            AddressText.Text       = _customer.Address;
            NotesText.Text         = _customer.Note;
            CurrentDueText.Text    = _customer.GetDebt;
            CurrentDueTextBig.Text = _customer.GetDebt;
        }

        private void ResetForm() {
            FullNameText.Text      = "";
            NickNameText.Text      = "";
            CompanyText.Text       = "";
            ContactNumberText.Text = "";
            EmailAddressText.Text  = "";
            AddressText.Text       = "";
            CashReceivedText.Text  = "";
            CurrentDueTextBig.Text = "0 BDT";
        }

        private bool ValidateForm() {
            string error = string.Empty;
            string warning = string.Empty;

            if (FullNameText.Text.Length == 0)
                error += "Empty Name\n";
            if (NickNameText.Text.Length == 0)
                warning += "Empty Nick Name\n";
            if (CompanyText.Text.Length == 0)
                warning += "Empty Company Name\n";
            if (ContactNumberText.Text.Length == 0)
                warning += "Empty Phone Number\n";
            if (EmailAddressText.Text.Length == 0)
                warning += "Empty Email Address\n";
            if (AddressText.Text.Length == 0)
                warning += "Empty Address\n";
            if (NotesText.Text == "")
                warning += "Empty notes\n";

            if (!decimal.TryParse(CurrentDueTextBig.Text.Split()[0], out decimal d) || d < 0)
                error += "Invalid Due Amount";

            if (error.Length > 0) {
                MessageBox.Show("Following errors occurred during form validation:\n"
                                + error + "\nFollowing warnings should be considered:\n" + warning, "Error");
                return false;
            }
            if (warning.Length > 0)
                MessageBox.Show("Following warnings should be considered:\n" + warning, "Warning");
            return true;
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            if (!ValidateForm())
                return;

            _customer.FullName = FullNameText.Text;
            _customer.NickName = NickNameText.Text;
            _customer.CompanyName = CompanyText.Text;
            _customer.Phone = ContactNumberText.Text;
            _customer.EmailAddress = EmailAddressText.Text;
            _customer.Address = AddressText.Text;
            _customer.Note = NotesText.Text;
            _customer.Debt = decimal.Parse(CurrentDueText.Text.Split()[0]);

            if (SaveButton.Text == "Submit") {
                _customer = Connection[0].InsertCustomer(_customer);
                if (_customer.CustomerId != "") {
                    MessageBox.Show("Customer added successfully", "Success");
                    ResetForm();
                } else {
                    MessageBox.Show("Something went wrong", "Error");
                }
            } else if (SaveButton.Text == "Save") {
                if (Connection[0].UpdateCustomer(_customer))
                    MessageBox.Show("Customer updated successfully", "Success");
                else
                    MessageBox.Show("Something went wrong", "Error");
            }
            DialogResult = DialogResult.OK;
        }

        private void DepositButton_Click(object sender, EventArgs e) {
            if (!decimal.TryParse(CashReceivedText.Text, out decimal m) || m < 0) {
                MessageBox.Show("Invalid Amount");
                return;
            }

            if (m > _customer.Debt)
                MessageBox.Show("Deposit amount is greater than due");
            else {
                DebtCollection model = new DebtCollection {
                    CustomerId = _customer.ObjectId,
                    CustomerName = _customer.FullName,
                    Amount = m
                };
                model = Connection[0].CollectDebt(model);
                if (model.ObjectId.Increment != 0) {
                    CurrentDueTextBig.Text = _customer.Debt.ToString("0.##") + " BDT";
                    CashReceivedText.Text = "0";
                    _customer.Debt -= m;
                    CustomerInformationForm_Load(sender, e);
                    MessageBox.Show("Due Collected", "Success");
                } else {
                    MessageBox.Show("Something went wrong", "Error");
                }
            }
        }
    }
}