using ShopLibrary.Models;
using System;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using static ShopLibrary.GlobalConfig;


namespace WinFormsUI.Forms {
    public partial class LoginForm : Form {
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

        //Creates the List of Users
        public LoginForm() {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(ConfigurationManager.AppSettings["Language"]);
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(ConfigurationManager.AppSettings["Language"]);
            Users = Connection[0].GetUserAll();
            InitializeComponent();
            WireUpLists();
            DialogResult = DialogResult.Cancel;
        }

        public void WireUpLists() {
            _userNameCombo.DataSource = null;
            _userNameCombo.DataSource = Users.Where(u => u.IsActive).Select(u => u.UserName).ToList();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


        /// <summary>
        ///     Validates the UserName and Password Text Box
        /// </summary>
        /// <returns> True - if valid </returns>
        private bool ValidateForm() {
            string errorMessage = string.Empty;

            if (_passwordText.Text.Length == 0)
                errorMessage += "Empty Password\n";

            if (errorMessage.Length > 0)
                MessageBox.Show(errorMessage);

            return errorMessage.Length == 0;
        }

        private void LoginButton_Click(object sender, EventArgs e) {
            if (ValidateForm())
                if (Connection[0].Login(_userNameCombo.Text, _passwordText.Text)) // Log-in Successful
                {
                    BulkPayment b = new BulkPayment();
                    b = Connection[0].LatestPay();
                    if (CurrentUser.AccessLevel <= ShopLibrary.Models.UserRole.Admin)
                    {
                       if(b == null || b.Date.Month != DateTime.Today.Month)
                        {
                            DialogResult result = MessageBox.Show("This month's Payment has not been given\n Do you want to Distribute Payment now?", "Confirmation", MessageBoxButtons.YesNo);
                            if(result == DialogResult.Yes)
                            {
                                BulkPayment model = new BulkPayment();
                                model.userId = CurrentUser.UserId;
                                model.userName = CurrentUser.UserName;
                                if (Connection[0].Payall(model))
                                {
                                    MessageBox.Show("Operation Successful!");
                                }
                            }
                        }
                     
                    }
                    DialogResult = DialogResult.OK;
                    Close();
                } else // Log-in Fail
                  {
                    MessageBox.Show("Invalid username/password combination", "Login error");
                }
        }

        /// <summary>
        ///     Changes Focus to The Next TextBox On Pressing Enter
        /// </summary>
        private void UserNameCombo_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                if (_userNameCombo.Text.Length != 0)
                    _passwordText.Focus();
        }

        /// <summary>
        ///     Calls the Login Button Click Event on Pressing Enter
        /// </summary>
        private void PasswordText_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                if (_passwordText.Text.Length != 0)
                    LoginButton_Click(sender, e);
        }

        private void LoginForm_Load(object sender, EventArgs e) {
            _activateLinkText.Hide();
            WireUpLists();
        }
    }
}

