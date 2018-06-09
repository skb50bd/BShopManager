using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static ShopLibrary.GlobalConfig;
using static ShopLibrary.Models.UserRole;

namespace WinFormsUI.Forms {
    public partial class UsersForm : Form {
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
        public UsersForm() {
            InitializeComponent();
        }

        private void UsersForm_Load(object sender, EventArgs e) {
            if (CurrentUser.AccessLevel <= Admin) {
                DeleteUserButton.Enabled = true;
                DeleteUserButton.ForeColor = Color.White;
                EditUserButton.Enabled = true;
                EditUserButton.ForeColor = Color.White;
                AddUserButton.Enabled = true;
                AddUserButton.ForeColor = Color.White;
            } else {
                AddUserButton.ForeColor = Color.Gray;
                AddUserButton.Enabled = false;
                EditUserButton.ForeColor = Color.Gray;
                EditUserButton.Enabled = false;
                DeleteUserButton.ForeColor = Color.Gray;
                DeleteUserButton.Enabled = false;
            }

            UsersDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UsersDataGrid.AutoGenerateColumns = false;
            LoadGrid();
        }

        private void LoadGrid() {
            UsersDataGrid.DataSource = null;
            UsersDataGrid.DataSource = Users;
        }

        private void DeleteUserButton_Click(object sender, EventArgs e) {
            var result = MessageBox.Show($"Are you sure want to delete {UsersDataGrid.SelectedRows.Count} users?\nThis cannot be undone.",
                "Confirmation",
                MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK) {
                foreach (DataGridViewRow row in UsersDataGrid.SelectedRows) {
                    if (Users[row.Index].AccessLevel == Root) {
                        MessageBox.Show("Hey! Hey! Hey!\nYou cannot remove me!", "Read only user");
                        continue;
                    }
                    if (Users[row.Index] == CurrentUser) {
                        var res = MessageBox.Show(
                            "Hey, you are trying to remove your OWN account!\nAre you sure?\nThis cannot be undone.",
                            "Confirm", MessageBoxButtons.OKCancel);
                        if (res == DialogResult.Cancel)
                            continue;
                    }
                    Connection[0].DisableUserByUserName(Users[row.Index].UserName);
                }
                LoadGrid();
            }
        }

        private void EditUserButton_Click(object sender, EventArgs e) {
            var index = UsersDataGrid.CurrentRow.Index;
            if (Users[index].AccessLevel > Root && index > -1) {
                Form editUser       = new UserInformationForm(Users[index]);
                var result = editUser.ShowDialog();
                if (result          == DialogResult.OK)
                    LoadGrid();
            } else
                MessageBox.Show("Readonly user or invalid selection", "Information");
        }

        private void AddUserButton_Click(object sender, EventArgs e) {
            Form newUser = new UserInformationForm();
            var result = newUser.ShowDialog();
            if (result == DialogResult.OK)
                LoadGrid();
        }
    }
}