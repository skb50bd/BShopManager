using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MongoDB.Bson;
using ShopLibrary.Models;
using static ShopLibrary.GlobalConfig;
using static ShopLibrary.Models.UserRole;

namespace WinFormsUI.Forms {
    public partial class SupplierInformationForm : Form {
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

        private Supplier _supplier = new Supplier();
        public SupplierInformationForm() {
            InitializeComponent();
            SaveButton.Text = "Submit";
            DialogResult    = DialogResult.Cancel;
            _supplier       = new Supplier();

            RepayAmountText.Enabled = false;
            RepayButton.Enabled = false;
        }

        public SupplierInformationForm(Supplier model) {
            InitializeComponent();
            SaveButton.Text = "Save";
            DialogResult = DialogResult.Cancel;
            _supplier = model;
            TitleLabel.Text = _supplier.SupplierId;
        }

        private void SupplierInformationForm_Load(object sender, EventArgs e) {
            UserRole role = CurrentUser.AccessLevel;

            if (role > Admin) {
                CurrentPayableText.Enabled = false;
            }
            if (role                           == AppUser) {
                if (_supplier                  == new Supplier()) {
                    FullNameText.Enabled       = true;
                    NickNameText.Enabled       = true;
                    CompanyText.Enabled        = true;
                    ContactNumberText.Enabled  = true;
                    EmailAddressText.Enabled   = true;
                    AddressText.Enabled        = true;
                    CurrentPayableText.Enabled = true;
                    NotesText.Enabled = true;
                    SaveButton.Enabled         = true;
                    RepayAmountText.Enabled    = false;
                    RepayButton.Enabled        = false;
                } else {
                    FullNameText.Enabled       = false;
                    NickNameText.Enabled       = false;
                    CompanyText.Enabled        = false;
                    ContactNumberText.Enabled  = false;
                    EmailAddressText.Enabled   = false;
                    AddressText.Enabled        = false;
                    NotesText.Enabled = false;
                    CurrentPayableText.Enabled = false;
                    SaveButton.Enabled         = false;
                    RepayAmountText.Enabled    = true;
                    RepayButton.Enabled        = true;
                }
            }
            if (role                       == Viewer) {
                FullNameText.Enabled       = false;
                NickNameText.Enabled       = false;
                CompanyText.Enabled        = false;
                ContactNumberText.Enabled  = false;
                EmailAddressText.Enabled   = false;
                AddressText.Enabled        = false;
                NotesText.Enabled = false;
                CurrentPayableText.Enabled = false;
                SaveButton.Enabled         = false;
                RepayAmountText.Enabled    = false;
                RepayButton.Enabled        = false;
            }

            FullNameText.Text          = _supplier.FullName;
            NickNameText.Text          = _supplier.NickName;
            CompanyText.Text           = _supplier.CompanyName;
            ContactNumberText.Text     = _supplier.Phone;
            EmailAddressText.Text      = _supplier.EmailAddress;
            AddressText.Text           = _supplier.Address;
            NotesText.Text             = _supplier.Note;
            CurrentPayableText.Text    = _supplier.GetPayable;
            CurrentPayableTextBig.Text = _supplier.GetPayable;
        }

        private void ResetForm() {
            FullNameText.Text          = "";
            NickNameText.Text          = "";
            CompanyText.Text           = "";
            ContactNumberText.Text     = "";
            EmailAddressText.Text      = "";
            AddressText.Text           = "";
            NotesText.Text             = "";
            RepayAmountText.Text       = "";
            CurrentPayableTextBig.Text = "0 BDT";
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
            if (NotesText.Text.Length == 0)
                warning += "Empty notes\n";

            if (!decimal.TryParse(CurrentPayableTextBig.Text.Split()[0], out decimal d) || d < 0)
                error += "Invalid Payable";

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

            DialogResult           = DialogResult.Cancel;
            _supplier.FullName     = FullNameText.Text;
            _supplier.NickName     = NickNameText.Text;
            _supplier.CompanyName  = CompanyText.Text;
            _supplier.Phone        = ContactNumberText.Text;
            _supplier.EmailAddress = EmailAddressText.Text;
            _supplier.Address      = AddressText.Text;
            _supplier.Note         = NotesText.Text;
            _supplier.Payable      = decimal.Parse(CurrentPayableText.Text.Split()[0]);

            if (SaveButton.Text == "Submit") {
                _supplier = Connection[0].InsertSupplier(_supplier);
                if (_supplier.ObjectId != ObjectId.Empty) {
                    MessageBox.Show("Supplier added successfully", "Success");
                    DialogResult = DialogResult.OK;
                    ResetForm();
                } else {
                    MessageBox.Show("Something went wrong", "Error");
                }
            } else if (SaveButton.Text == "Save") {
                if (Connection[0].UpdateSupplier(_supplier))
                {
                    MessageBox.Show("Supplier updated successfully", "Success");
                    DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("Something went wrong", "Error");
            }
        }

        private void RepayButton_Click(object sender, EventArgs e) {
            if (!decimal.TryParse(RepayAmountText.Text, out decimal m) || m < 0) {
                MessageBox.Show("Invalid Amount");
                return;
            }

            if (m > _supplier.Payable)
                MessageBox.Show("Repayment amount is greater than payable");
            else {
                Repayment model  = new Repayment {
                    SupplierId   = _supplier.ObjectId,
                    SupplierName = _supplier.FullName,
                    Amount       = m
                };
                _supplier.Payable -= m;
                model                          = Connection[0].Repay(model);
                if (model.ObjectId != ObjectId.Empty) {
                    CurrentPayableTextBig.Text = _supplier.Payable.ToString("0.##") + " BDT";
                    RepayAmountText.Text       = "0";
                    MessageBox.Show("Repayment Successful", "Success");
                    DialogResult = DialogResult.OK;
                } else {
                    MessageBox.Show("Something went wrong", "Error");
                }
            }
        }
    }
}
