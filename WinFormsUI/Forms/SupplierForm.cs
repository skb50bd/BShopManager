using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ShopLibrary.Models;
using static ShopLibrary.GlobalConfig;
using static ShopLibrary.Models.UserRole;

namespace WinFormsUI.Forms {
    public partial class SupplierForm : Form {
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
        #region Global Variables

        private List<Supplier> _groupedSuppliers;
        private List<ISupplierReportable> _records;
        private List<Purchase> _purhcases;
        private List<Repayment> _repayments;
        private List<PurchaseReturn> _purchaseReturns;

        #endregion
        public SupplierForm() {
            InitializeComponent();
        }


        private void SupplierForm_Load(object sender, EventArgs e) {
            SupplierHistoryDataGrid.AutoGenerateColumns = false;
            SuppliersDataGrid.AutoGenerateColumns = false;

            UserRole role = CurrentUser.AccessLevel;
            if (role <= Admin) {
                DeleteSupplierButton.Enabled = true;
                DeleteRecordsButton.Enabled = true;
            } else {
                DeleteSupplierButton.Enabled = false;
                DeleteRecordsButton.Enabled = false;
                if (role <= AppUser)
                {
                    AddSupplierButton.Enabled = true;
                    ViewEditSupplierButton.Enabled = true;
                    ViewRecordButton.Enabled = true;
                }
                else
                {
                    AddSupplierButton.Enabled = false;
                    ViewEditSupplierButton.Enabled = false;
                    ViewRecordButton.Enabled = false;
                    SearchSupplierText.Enabled = false;
                }
            }
            WireUp();
        }

        private void WireUp() {
            SuppliersDataGrid.DataSource = null;
            _groupedSuppliers = Suppliers;
            SuppliersDataGrid.DataSource = _groupedSuppliers;
        }

        private void AddSupplierButton_Click(object sender, EventArgs e) {
            Form ac = new SupplierInformationForm();
            DialogResult result = ac.ShowDialog();
            if (result != DialogResult.OK)
                WireUp();
        }

        private void SearchSupplierText_TextChanged(object sender, EventArgs e) {
            string text = SearchSupplierText.Text.ToLowerInvariant();
            if (text.Length == 0) {
                _groupedSuppliers = Suppliers;

            } else {
                string[] tokens = text.Split();
                switch (tokens.Length) {
                    case 1:
                        if (decimal.TryParse(text, out decimal min))
                            _groupedSuppliers = Suppliers
                                .Where(sp => sp.Payable >= min).ToList();

                        else if (text.Length > 2)
                            if(text.Substring(0, 2).ToLowerInvariant() == "SP".ToLowerInvariant())
                                _groupedSuppliers = Suppliers
                                    .Where(sp => sp.SupplierId.ToLowerInvariant().Contains(text))
                                    .ToList();
                        else
                            _groupedSuppliers = Suppliers
                                .Where(sp => sp.FullName.ToLowerInvariant().Contains(text) ||
                                sp.NickName.ToLowerInvariant().Contains(text) ||
                                sp.CompanyName.ToLowerInvariant().Contains(text)).ToList();
                        break;
                    case 2:
                        if (decimal.TryParse(tokens[0], out min) && decimal.TryParse(tokens[1], out decimal max))
                            _groupedSuppliers = Suppliers
                                .Where(c => c.Payable >= min && c.Payable <= max)
                                .ToList();
                        else
                            _groupedSuppliers = Suppliers
                                .Where(c => c.FullName.ToLowerInvariant().Contains(text) ||
                                c.NickName.ToLowerInvariant().Contains(text) ||
                                c.CompanyName.ToLowerInvariant().Contains(text)).ToList();
                        break;
                    default:
                        _groupedSuppliers = Suppliers
                                .Where(c => c.FullName.ToLowerInvariant().Contains(text) ||
                                c.NickName.ToLowerInvariant().Contains(text) ||
                                c.CompanyName.ToLowerInvariant().Contains(text)).ToList();
                        break;
                }
            }
            SuppliersDataGrid.ClearSelection();
            SuppliersDataGrid.DataSource = null;
            SuppliersDataGrid.DataSource = _groupedSuppliers;
        }

        private void ViewEditSupplierButton_Click(object sender, EventArgs e) {
            try {
                Form ci = new SupplierInformationForm(_groupedSuppliers[SuppliersDataGrid.SelectedCells[0].RowIndex]);
                DialogResult result = ci.ShowDialog();
                if (result == DialogResult.OK)
                    WireUp();
            } catch (Exception exception) {
                Console.WriteLine(exception);
            }
        }

        private void SuppliersDataGrid_SelectionChanged(object sender, EventArgs e) {
            Supplier supplier;
            int index = SuppliersDataGrid.CurrentRow.Index;
            if (_groupedSuppliers.Count > 0 && index < _groupedSuppliers.Count) {
                supplier = _groupedSuppliers[index];
                _purhcases = Connection[0]
                    .GetPurchaseBySupplier(supplier, DateTime.Today.AddYears(-1), DateTime.Now);
                _records = _purhcases.ToList<ISupplierReportable>();

                _repayments = Connection[0].GetRepaymentBySupplier(
                    supplier,
                    DateTime.Today.AddYears(-1),
                    DateTime.Now);
                _records.AddRange(_repayments.ToList<ISupplierReportable>());

                _purchaseReturns = Connection[0].GetPurchaseReturnBySupplier(
                    supplier,
                    DateTime.Today.AddYears(-1),
                    DateTime.Now);
                _records.AddRange(_purchaseReturns.ToList<ISupplierReportable>());

                _records = _records.OrderByDescending(r => r.TimeStamp).ToList();
            } else
                _records = null;
            SupplierHistoryDataGrid.DataSource = null;
            SupplierHistoryDataGrid.DataSource = _records;
        }

        private void DeleteSupplierButton_Click(object sender, EventArgs e) {
            DialogResult result =
                MessageBox.Show($"Do you really want to delete {SuppliersDataGrid.SelectedRows.Count} supplier?\n" +
                    "This process is irreversible\n",
                    "Confirm",
                    MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
                return;

            foreach (DataGridViewRow row in SuppliersDataGrid.Rows)
                Connection[0].DisableSupplier(_groupedSuppliers[row.Index]);
            WireUp();
        }

        private void DeleteEntryButton_Click(object sender, EventArgs e) {
            int selectedIndex = SuppliersDataGrid.CurrentRow.Index;
            if (selectedIndex > 0) {
                DialogResult result =
                    MessageBox.Show($"Do you really want to delete { SupplierHistoryDataGrid.SelectedRows.Count } records?\n" +
                                    "This action is irreversible\n",
                        "Confirm",
                        MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                    return;

                foreach (DataGridViewRow row in SupplierHistoryDataGrid.SelectedRows) {
                    if (row.Cells[0].Value.ToString() == "Purchase")
                        Connection[0].DeletePurchase(
                            _purhcases.Single(p => p.PurchaseId == _records[row.Index].Id));
                    else if (row.Cells[0].Value.ToString() == "Repayment")
                        Connection[0].DeleteRepayment(
                            _repayments.Single(r => r.RepaymentId == _records[row.Index].Id));
                    else if (row.Cells[0].Value.ToString() == "Prc. Rtrn")
                        Connection[0].DeletePurchaseReturn(
                            _purchaseReturns.Single(pr => pr.PurchaseReturnId == _records[row.Index].Id));
                }
            }
            WireUp();
            SuppliersDataGrid.ClearSelection();
            SuppliersDataGrid.Rows[selectedIndex].Selected = true;
        }

        private void RefreshSuppliersButton_Click(object sender, EventArgs e)
        {
            Suppliers = Connection[0].GetSupplierAll();
            WireUp();
        }

        private void ViewRecordButton_Click(object sender, EventArgs e) {
            // Todo - Show Record
        }
    }
}
