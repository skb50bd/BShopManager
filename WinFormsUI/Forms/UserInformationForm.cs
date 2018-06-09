using System;
using System.Configuration;
using System.Resources;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MongoDB.Bson;
using ShopLibrary.Models;
using static ShopLibrary.GlobalConfig;


namespace WinFormsUI {
    public partial class UserInformationForm : Form {
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
        ResourceManager rm = new ResourceManager(typeof(UserInformationForm));
        private User user;
        private bool passwordChanged = false;

        public UserInformationForm() {
            InitializeComponent();
            if (ConfigurationManager.AppSettings["Language"] == "bn-BD")
            {
                TitleLabel.Text = rm.GetString("NewUser");
            }
            else
                TitleLabel.Text = "Add new user";
            user = new User();
            ResetFields();
            DialogResult = DialogResult.Cancel;
        }

        public UserInformationForm(User user) {
            InitializeComponent();
            UserNameText.Enabled = false;
            this.user = user;

            TitleLabel.Text = user.UserName;
            FullNameText.Text = user.FullName;
            NickNameText.Text = user.NickName;
            AccessLevelCombo.SelectedIndex = (int)user.AccessLevel - 2;
            AddressText.Text = user.Address;
            ContactNumberText.Text = user.Phone;
            EmailAddressText.Text = user.EmailAddress;
            UserNameText.Text = user.UserName;
            PasswordText.Text = "**********";
            ConfirmPasswordText.Text = "**********";

            if (ConfigurationManager.AppSettings["Language"] == "bn-BD")
            {
                AddSaveButton.Text = rm.GetString("Update");
            }
            else
                AddSaveButton.Text = "Update";
            DialogResult = DialogResult.Cancel;
        }

        private void UserInformationForm_Load(object sender, EventArgs e) {

        }

        private void PasswordText_Enter(object sender, EventArgs e) {
            if (PasswordText.Text == "**********")
                PasswordText.Text = "";
            if (ConfirmPasswordText.Text == "**********")
                ConfirmPasswordText.Text = "";
            passwordChanged = true;
        }

        private void ResetFields() {
            FullNameText.Text = "";
            UserNameText.Text = "";
            AccessLevelCombo.Text = "";
            AddressText.Text = "";
            ContactNumberText.Text = "";
            EmailAddressText.Text = "";
            PasswordText.Text = "";
            ConfirmPasswordText.Text = "";
            if (ConfigurationManager.AppSettings["Language"] == "bn-BD")
            {
                AddSaveButton.Text = rm.GetString("AddSaveButton.Text");
            }
            else
                AddSaveButton.Text = "Add User";
        }

        private bool ValidateAddUserForm() {
            var error = string.Empty;

            if (FullNameText.Text.Length == 0)
                error += "Empty Person Name\n";
            if (UserNameText.Text.Length == 0)
                error += "Empty User Name\n";
            if (UserNameText.Enabled)
                if (Connection[0].NewUserNameIsValid(UserNameText.Text))
                    error += "This User Name is taken\n";
            if (AccessLevelCombo.Text != "Admin" &&
                AccessLevelCombo.Text != "App User" &&
                AccessLevelCombo.Text != "Viewer")
                error += "Empty or Invalid User Role\n";
            if (passwordChanged) {
                if (PasswordText.Text == "" || PasswordText.Text == "**********")
                    error += "Empty or Invalid Password\n";

                if (ConfirmPasswordText.Text != PasswordText.Text)
                    error += "Repeated Password Does Not Match\n";
            }
            if (error.Length > 0) {
                MessageBox.Show("The Following Error(s) Occured While Validating the Form\n" + error);
                return false;
            }
            return true;
        }

        private void AddSaveButton_Click(object sender, EventArgs e) {
            if (ValidateAddUserForm()) {
                if (passwordChanged) {
                    var objId = user.ObjectId;
                    user = new User(
                        FullNameText.Text,
                        NickNameText.Text,
                        AddressText.Text,
                        ContactNumberText.Text,
                        EmailAddressText.Text,
                        UserNameText.Text,
                        (UserRole)(AccessLevelCombo.SelectedIndex + 2),
                        PasswordText.Text) {
                        ObjectId = objId
                    };
                    if (AddSaveButton.Text == "Add User" || AddSaveButton.Text == rm.GetString("AddSaveButton.Text")) {
                        Connection[0].InsertUser(user);
                        MessageBox.Show("User Added");
                        DialogResult = DialogResult.OK;
                        ResetFields();
                        user = new User();
                    } else if (Connection[0].UpdateUser(user)) {
                        MessageBox.Show("Updated Successfully");
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                } else {
                    user.FullName = FullNameText.Text;
                    user.NickName = NickNameText.Text;
                    user.AccessLevel = (UserRole)(AccessLevelCombo.SelectedIndex + 2);
                    user.Address = AddressText.Text;
                    user.Phone = ContactNumberText.Text;
                    user.EmailAddress = EmailAddressText.Text;
                    user.Meta.Modified = DateTime.Now;
                    user.Meta.Modifier = CurrentUser.UserName;

                    if (Connection[0].UpdateUser(user)) {
                        MessageBox.Show("Updated Successfully");
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
            }
        }
    }
}
