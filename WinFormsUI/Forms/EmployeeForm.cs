using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ShopLibrary.Models;
using static ShopLibrary.GlobalConfig;
using static ShopLibrary.Models.UserRole;
using System.Configuration;

namespace WinFormsUI.Forms {
    public partial class EmployeeForm : Form {
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
        private List<Employee> _groupedEmployees;
        private List<Payment> _records;

        public EmployeeForm() {
            InitializeComponent();
        }


        private void EmployeeForm_Load(object sender, EventArgs e) {
            var role = CurrentUser.AccessLevel;
            DeleteEmployeeButton.Enabled = role <= Admin;
            DeleteEntryButton.Enabled = role <= Admin;
            AddEmployeeButton.Enabled = role <= AppUser;
            EmployeesDataGrid.AutoGenerateColumns = false;
            EmployeeHistoryDataGrid.AutoGenerateColumns = false;
            WireUp();
            EmployeesDataGrid.ClearSelection();
        }

        private void WireUp() {
            EmployeesDataGrid.DataSource = null;
            _groupedEmployees = Employees;
            EmployeesDataGrid.DataSource = _groupedEmployees;
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e) {
            Form ac = new EmployeeInformationForm();
            var result = ac.ShowDialog();
            if (result != DialogResult.OK)
                WireUp();
        }

        private void SearchEmployeeText_TextChanged(object sender, EventArgs e) {
            var text = SearchEmployeeText.Text.ToLowerInvariant();
            if (text.Length == 0) {
                _groupedEmployees = Employees;

            } else {
                var tokens = text.Split();
                switch (tokens.Length) {
                    case 1:
                        if (decimal.TryParse(text, out var min))
                            _groupedEmployees = Employees
                                .Where(sp => sp.Balance >= min).ToList();

                        else if (text.Length > 1)
                            if (text.Substring(0, 2).ToLowerInvariant() == "EM".ToLowerInvariant())
                                _groupedEmployees = Employees
                                    .Where(sp => sp.EmployeeId.ToLowerInvariant().Contains(text))
                                    .ToList();
                            else
                                _groupedEmployees = Employees
                                    .Where(sp => sp.FullName.ToLowerInvariant().Contains(text) ||
                                    sp.NickName.ToLowerInvariant().Contains(text) ||
                                    sp.Designation.ToLowerInvariant().Contains(text)).ToList();
                        break;
                    case 2:
                        if (decimal.TryParse(tokens[0], out min) && decimal.TryParse(tokens[1], out var max))
                            _groupedEmployees = Employees
                                .Where(c => c.Balance >= min && c.Balance <= max)
                                .ToList();
                        else
                            _groupedEmployees = Employees
                                .Where(c => c.FullName.ToLowerInvariant().Contains(text) ||
                                c.NickName.ToLowerInvariant().Contains(text) ||
                                c.Designation.ToLowerInvariant().Contains(text)).ToList();
                        break;
                    default:
                        _groupedEmployees = Employees
                                .Where(c => c.FullName.ToLowerInvariant().Contains(text) ||
                                c.NickName.ToLowerInvariant().Contains(text) ||
                                c.Designation.ToLowerInvariant().Contains(text)).ToList();
                        break;
                }
            }
            EmployeesDataGrid.ClearSelection();
            EmployeesDataGrid.DataSource = null;
            EmployeesDataGrid.DataSource = _groupedEmployees;
        }

        private void ViewEditEmployeeButton_Click(object sender, EventArgs e)
        {
            var index = EmployeesDataGrid.CurrentRow.Index;
            try {
                Form ci = new EmployeeInformationForm(_groupedEmployees[index]);
                var result = ci.ShowDialog();
                if (result == DialogResult.OK)
                    WireUp();
            } catch (Exception exception) {
                Console.WriteLine(exception);
            }

            EmployeesDataGrid.ClearSelection();
            EmployeesDataGrid.Rows[index].Selected = true;
        }

        private void DeleteEmployeeButton_Click(object sender, EventArgs e) {
            var result =
                MessageBox.Show($"Do you really want to delete {EmployeesDataGrid.SelectedRows.Count} employees?\n" +
                    "This process is irreversible\n",
                    "Confirm",
                    MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
                return;

            foreach (DataGridViewRow row in EmployeesDataGrid.SelectedRows)
                Connection[0].DisableEmployee(_groupedEmployees[row.Index]);
            WireUp();
        }

        private void DeleteEntryButton_Click(object sender, EventArgs e) {
            var result =
                MessageBox.Show($"Do you really want to delete {EmployeeHistoryDataGrid.SelectedRows.Count} payment records?\n" +
                                "This action is irreversible\n",
                    "Confirm",
                    MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
                return;

            foreach (DataGridViewRow row in EmployeeHistoryDataGrid.SelectedRows)
                Connection[0].DeletePayment(_records[row.Index]);

            MessageBox.Show("Deletion completed", "Success");
            WireUp();
        }

        private void EmployeesDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (EmployeesDataGrid.CurrentRow.Index > -1) {
                if (_groupedEmployees.Count > 0) {
                    _records = Connection[0].GetPaymentByEmployee(
                        _groupedEmployees[EmployeesDataGrid.CurrentCell.RowIndex], 
                        DateTime.Today.AddYears(-1),
                        DateTime.Now);
                } else {
                    _records = new List<Payment>();
                }
                EmployeeHistoryDataGrid.DataSource = null;
                EmployeeHistoryDataGrid.DataSource = _records;
            }
        }

        private void ReloadEmployees_Click(object sender, EventArgs e) {
            Employees = Connection[0].GetEmployeeAll();
            WireUp();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CurrentUser.AccessLevel <= Admin)
            {
                BulkPayment pay, pay2 = new BulkPayment();
                pay = Connection[0].LatestPay();
                if (pay != null && pay.Meta.Created.Month == DateTime.Today.Month)
                {
                    DialogResult result;
                    if (ConfigurationManager.AppSettings["Language"] == "bn-BD")
                    {
                        result = MessageBox.Show("এই মাসের বেতন বিতরণ করা হয়ে গেছে!\nআপনি কি আবার বেতন বিতরণ করতে চান?", "অনুমোদন", MessageBoxButtons.YesNo);
                    }
                    else
                         result = MessageBox.Show("This month's payment has already been Given!\nDo you still with to Continue?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        pay2.Meta = new Metadata {
                            Creator = CurrentUser.UserName
                        };
                        Connection[0].Payall(pay2);
                        if (ConfigurationManager.AppSettings["Language"] == "bn-BD")
                            MessageBox.Show("কাজ সুষ্ঠভাবে সম্পন্ন হয়েছে!");
                        else
                            MessageBox.Show("Operation Successful!");
                    }
                }
                else
                {
                    pay2.Meta.Creator = CurrentUser.UserName;
                    Connection[0].Payall(pay2);
                    if (ConfigurationManager.AppSettings["Language"] == "bn-BD")
                        MessageBox.Show("কাজ সুষ্ঠভাবে সম্পন্ন হয়েছে!");
                    else
                        MessageBox.Show("Operation Successful!");
                }
            }
            else
                MessageBox.Show("You are not Authorized!");
        }
    }
}
