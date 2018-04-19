using System;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ShopLibrary.Models;
using static ShopLibrary.GlobalConfig;
using static ShopLibrary.Models.UserRole;
namespace WinFormsUI.Forms {
    public partial class ShopForm : Form {
        ResourceManager rm = new ResourceManager(typeof(ShopForm));
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
        public ShopForm() {
            InitializeComponent();
        }

        private void ShopForm_Load(object sender, EventArgs e) {
            if (CurrentUser.AccessLevel    != Root
                && CurrentUser.AccessLevel != Admin) {
                ShopNameText.Enabled                     = false;
                TaglineText.Enabled                      = false;
                PropietorNameText.Enabled                = false;
                AddressText.Enabled                      = false;
                DetailsText.Enabled                      = false;
                PhoneNumbersText.Enabled                 = false;
                EmailAddressesText.Enabled               = false;
                DeleteCancelButton.Enabled               = false;
                EditSaveButton.Enabled                   = false;
                AddNewShopButton.Enabled                 = false;
            }
            WireUp();
        }

        private void WireUp() {
            Shops = Connection[0].GetShopsAll();

            ShopSelectorCombo.DataSource = null;
            ShopSelectorCombo.DataSource = Shops;

            ShopSelectorCombo.Show();
            AddNewShopButton.Show();
            SelectShopLabel.Show();
        }

        private bool ValidateForm() {
            string error = string.Empty;
            string warning = string.Empty;
            if (ShopNameText.Text.Length == 0)
                error += "Empty Shopname\n";
            if (EditSaveButton.Text == "Add Shop"
                && Shops.Exists(s => s.ShopName == ShopNameText.Text))
                error += "Another Shop with same name exists";
            if (TaglineText.Text.Length == 0)
                warning += "Empty Tagline";
            if (PropietorNameText.Text.Length == 0)
                error += "Invalid Propietor name\n";
            if (AddressText.Text.Length == 0)
                warning += "Empty Address\n";
            if (DetailsText.Text.Length == 0)
                warning += "Empty Details\n";
            if (PhoneNumbersText.Text.Length == 0)
                warning += "Empty Phone Number(s)\n";
            if (EmailAddressesText.Text.Length == 0)
                warning += "Empty Email Address(es)";

            if (error.Length > 0 || warning.Length > 0) {
                DialogResult result
                    = MessageBox.Show("Following Errors occurred during Validation:\n" + error +
                        "Following Warnings should be considered:\n" + warning +
                        "\n\nDo you want to ignore the warnings?",
                        "Alert",
                        MessageBoxButtons.YesNo);
                if (error.Length > 0 ||
                    result != DialogResult.Yes)
                    return false;
            }
            return true;
        }

        private void ResetForm() {
            ShopNameText.Text         = "";
            TaglineText.Text          = "";
            PropietorNameText.Text    = "";
            AddressText.Text          = "";
            DetailsText.Text          = "";
            PhoneNumbersText.Text     = "";
            EmailAddressesText.Text   = "";
            if (ConfigurationManager.AppSettings["Language"] == "bn-BD")
            {  
                EditSaveButton.Text = rm.GetString("add"); 
                DeleteCancelButton.Text = rm.GetString("cancel"); 
            }
            else
            {
                EditSaveButton.Text = "Add Shop";
                DeleteCancelButton.Text = "Cancel";
            }
            AddNewShopButton.Hide();
            ShopSelectorCombo.Hide();
            SelectShopLabel.Hide();
        }


        private void AddNewShopButton_Click(object sender, EventArgs e) => ResetForm();

        private void DeleteCancelButton_Click(object sender, EventArgs e) {
            ShopSelectorCombo.Show();
            AddNewShopButton.Show();
            SelectShopLabel.Show();
            if (DeleteCancelButton.Text == "Cancel" || DeleteCancelButton.Text == rm.GetString("cancel")) {
                ResetForm();
            } else if (DeleteCancelButton.Text == "Delete This Shop" || DeleteCancelButton.Text == rm.GetString("DeleteCancelButton.Text")) {
                DialogResult confirm           = MessageBox.Show("Do You Really Want to Delete" +
                    $"\n {ShopSelectorCombo.Text}?" +
                    "\n All related Records will be DELETED",
                    "Confirm", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes) {
                    if (Connection[0]
                        .DeleteShop(Shops[ShopSelectorCombo.SelectedIndex]))
                        MessageBox.Show("Deleted successfully", "Success");
                    else
                        MessageBox.Show("An error occurred", "Error");
                    WireUp();
                    TitleLabel.Focus();
                }
            }
        }

        private void EditSaveButton_Click(object sender, EventArgs e) {
            if (!ValidateForm())
                return;

            if (EditSaveButton.Text == "Add Shop" || EditSaveButton.Text == rm.GetString("add")) {
                DialogResult result = MessageBox.Show("Are you sure want to add this Shop?", "Confirm",
                    MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                    return;

                Shop model         = new Shop {
                    ShopName       = ShopNameText.Text,
                    Tagline        = TaglineText.Text,
                    PropietorName  = PropietorNameText.Text,
                    Address        = AddressText.Text,
                    Details        = DetailsText.Text,
                    ContactNumbers = Regex.Split(PhoneNumbersText.Text, @"\W+").ToList(),
                    EmailAddresses = EmailAddressesText.Text.Split(',').ToList()
                };
                model = Connection[0].InsertShop(model);
                WireUp();
            } else if (EditSaveButton.Text == "Save" || EditSaveButton.Text == rm.GetString("EditSaveButton.Text")) {
                if (Shops.Exists(s => s.ShopName == ShopNameText.Text
                    && s.ShopId != Shops[ShopSelectorCombo.SelectedIndex].ShopId)) {
                    MessageBox.Show("Another Shop with same name exists", "Error");
                    return;
                }
                DialogResult result = MessageBox.Show("Are you sure want to update this Shop?", "Confirm",
                    MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                    return;
                Shop model           = Shops[ShopSelectorCombo.SelectedIndex];
                model.ShopName       = ShopNameText.Text;
                model.Tagline        = TaglineText.Text;
                model.PropietorName  = PropietorNameText.Text;
                model.Address        = AddressText.Text;
                model.Details        = DetailsText.Text;
                model.ContactNumbers = Regex.Split(PhoneNumbersText.Text, @"\W+").ToList();
                model.EmailAddresses = EmailAddressesText.Text.Split(',').ToList();
                model.EmailAddresses.ForEach(s => s.Trim());

                if (Connection[0].UpdateShop(model)) {
                    WireUp();
                    MessageBox.Show("Shop updated successfully");
                } else
                    MessageBox.Show("Something went wrong");
            }
        }

        private void ShopSelectorCombo_SelectedIndexChanged(object sender, EventArgs e) {
            if (ShopSelectorCombo.SelectedIndex < 0 ||
                ShopSelectorCombo.SelectedIndex >= Shops.Count)
                ShopSelectorCombo.SelectedIndex = 0;

            if (Shops.Count != 0) {
                ShopNameText.Text       = Shops[ShopSelectorCombo.SelectedIndex].ShopName;
                TaglineText.Text        = Shops[ShopSelectorCombo.SelectedIndex].Tagline;
                PropietorNameText.Text  = Shops[ShopSelectorCombo.SelectedIndex].PropietorName;
                AddressText.Text        = Shops[ShopSelectorCombo.SelectedIndex].Address;
                DetailsText.Text        = Shops[ShopSelectorCombo.SelectedIndex].Details;
                PhoneNumbersText.Text   = string.Join(", ", Shops[ShopSelectorCombo.SelectedIndex].ContactNumbers);
                EmailAddressesText.Text = string.Join(", ", Shops[ShopSelectorCombo.SelectedIndex].EmailAddresses);
                if (ConfigurationManager.AppSettings["Language"] == "bn-BD")
                {
                    DeleteCancelButton.Text = rm.GetString("DeleteCancelButton.Text");
                    EditSaveButton.Text = rm.GetString("EditSaveButton.Text");
                }
                else
                {
                    DeleteCancelButton.Text = "Delete This Shop";
                    EditSaveButton.Text = "Save";
                }
            } else
                ResetForm();
        }
    }
}