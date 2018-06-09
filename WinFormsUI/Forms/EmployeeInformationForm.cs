using System;
using System.Configuration;
using System.Resources;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ShopLibrary.Models;
using static ShopLibrary.GlobalConfig;
using static ShopLibrary.Models.UserRole;


namespace WinFormsUI.Forms {
    public partial class EmployeeInformationForm : Form {
        ResourceManager rm = new ResourceManager(typeof(EmployeeInformationForm));
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

        private Employee _employee = new Employee();
        public EmployeeInformationForm() {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;

            if (CurrentUser.AccessLevel > AppUser)
            {
                MessageBox.Show("Access denied", "Error");
                return;
            }

            if (ConfigurationManager.AppSettings["Language"] == "bn-BD")
            {
                SaveButton.Text = rm.GetString("Submit");
            }
            else
                SaveButton.Text = "Submit";
            _employee                = new Employee();
            InfoGroupBox.Enabled     = CurrentUser.AccessLevel <= AppUser;
            PaymentGroupBox.Enabled  = false;
        }

        public EmployeeInformationForm(Employee model) {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;

            if (ConfigurationManager.AppSettings["Language"] == "bn-BD")
            {
                SaveButton.Text = rm.GetString("SaveButton.Text");
            }
            else
                SaveButton.Text = "Save";

            _employee = model;
            TitleLabel.Text = _employee.EmployeeId;

            InfoGroupBox.Enabled =
                PaymentGroupBox.Enabled = CurrentUser.AccessLevel <= AppUser;
            MonthlySalaryText.Enabled =
                CurrentBalanceText.Enabled =
                    JoinDateTime.Enabled = CurrentUser.AccessLevel <= Admin;
        }

        private void EmployeeInformationForm_Load(object sender, EventArgs e) {
            FullNameText.Text          = _employee.FullName;
            NickNameText.Text          = _employee.NickName;
            DesignationText.Text       = _employee.Designation;
            NidText.Text               = _employee.NationalIdN;
            ContactNumberText.Text     = _employee.Phone;
            EmailAddressText.Text      = _employee.EmailAddress;
            AddressText.Text           = _employee.Address;
            JoinDateTime.Value         = _employee.JoinDate;
            MonthlySalaryText.Text     = _employee.GetMonthlySalary;
            NotesText.Text             = _employee.Note;
            CurrentBalanceText.Text    = _employee.GetBalance;
            CurrentBalanceTextBig.Text = _employee.GetBalance;
        }

        private void ResetForm() {
            FullNameText.Text          = "";
            NickNameText.Text          = "";
            DesignationText.Text       = "";
            NidText.Text               = "";
            ContactNumberText.Text     = "";
            EmailAddressText.Text      = "";
            AddressText.Text           = "";
            JoinDateTime.Value         = DateTime.Now;
            MonthlySalaryText.Text     = "";
            CurrentBalanceText.Text    = "";
            NotesText.Text             = "";
            SalaryAmountText.Text      = "";
            CurrentBalanceTextBig.Text = "0 BDT";
        }

        private bool ValidateForm() {
            var error = string.Empty;
            var warning = string.Empty;

            if (FullNameText.Text.Length == 0)
                error += "Empty Name\n";
            if (NickNameText.Text.Length == 0)
                warning += "Empty Nick Name\n";
            if (DesignationText.Text.Length == 0)
                error += "Empty Company Name\n";
            if (NidText.Text.Length == 0)
                warning += "Empty NID Number\n";
            if (ContactNumberText.Text.Length == 0)
                warning += "Empty Phone Number\n";
            if (EmailAddressText.Text.Length == 0)
                warning += "Empty Email Address\n";
            if (AddressText.Text.Length == 0)
                warning += "Empty Address\n";
            if (JoinDateTime.Value > DateTime.Now)
                error += "Join date is in future\n";
            if (!decimal.TryParse(MonthlySalaryText.Text, out var s) || s < 0)
                error += "Invalid monthly salary\n";
            if (!decimal.TryParse(CurrentBalanceText.Text, out var b))
                error += "Invalid balance\n";
            if (NotesText.Text.Length == 0)
                warning += "Empty notes\n";

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

            _employee.FullName      = FullNameText.Text;
            _employee.NickName      = NickNameText.Text;
            _employee.Designation   = DesignationText.Text;
            _employee.NationalIdN   = NidText.Text;
            _employee.Phone         = ContactNumberText.Text;
            _employee.EmailAddress  = EmailAddressText.Text;
            _employee.Address       = AddressText.Text;
            _employee.JoinDate      = JoinDateTime.Value;
            _employee.MonthlySalary = decimal.Parse(MonthlySalaryText.Text);
            _employee.Balance       = decimal.Parse(CurrentBalanceText.Text);
            _employee.Note          = NotesText.Text;
            _employee.Balance       = decimal.Parse(CurrentBalanceText.Text.Split()[0]);

            if (SaveButton.Text == "Submit" || SaveButton.Text == rm.GetString("Submit")) {
                _employee = Connection[0].InsertEmployee(_employee);
                if (_employee.EmployeeId != "") {
                    MessageBox.Show("Employee added successfully", "Success");
                    ResetForm();
                } else {
                    MessageBox.Show("Something went wrong", "Error");
                }
            } else if (SaveButton.Text == "Save" || SaveButton.Text == rm.GetString("SaveButton.Text")) {
                if (Connection[0].UpdateEmployee(_employee))
                    MessageBox.Show("Employee updated successfully", "Success");
                else
                    MessageBox.Show("Something went wrong", "Error");
            }
        }

        private void PayButton_Click(object sender, EventArgs e) {
            if (!decimal.TryParse(SalaryAmountText.Text, out var m) || m < 0) {
                MessageBox.Show("Invalid Amount");
                return;
            }

            if (m > _employee.Balance) {
                var result = MessageBox.Show("Payment amount is greater than balance\n" +
                                                      "Do you want to proceed anyway?",
                                                      "Warning", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                    return;
            }
            var model    = new Payment {
                EmployeeId   = _employee.ObjectId,
                EmployeeName = _employee.FullName,
                Amount       = m
            };

            _employee.Balance -= m;
            model = Connection[0].Pay(model);
            if (model.ObjectId.Increment != 0) {
                CurrentBalanceTextBig.Text = _employee.Balance.ToString("0.##") + " BDT";
                SalaryAmountText.Text = "0";
                MessageBox.Show("Payment Successful", "Success");
            } else {
                MessageBox.Show("Something went wrong", "Error");
            }

            EmployeeInformationForm_Load(sender, e);
            DialogResult = DialogResult.OK;
        }
    }
}
